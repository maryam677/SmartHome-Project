namespace WinFormsApp2.SmartHomeSecurity;

public class SecurityService
{
    public static readonly string[] DefaultZones =
        { "Living Room", "Bedroom", "Kitchen", "Bathroom", "Garage" };

    private const int MotionSeconds = 6;

    private readonly object _lock = new();
    private readonly ISecurityRepository _repo;
    private readonly List<SecurityEvent> _log = new();
    private readonly Dictionary<string, ZoneState> _zones = new();
    private readonly List<string> _zoneOrder = new();
    private int _nextId = 1;
    private AlarmState _state = AlarmState.Disarmed;

    public event Action<SecurityEvent>? EventLogged;
    public event Action<AlarmState>? StateChanged;
    public event Action<Exception>? PersistenceError;

    public SecurityService(ISecurityRepository? repository = null, IEnumerable<string>? zoneNames = null)
    {
        _repo = repository ?? new NullSecurityRepository();
        foreach (var name in zoneNames ?? DefaultZones)
        {
            _zones[name] = new ZoneState { Name = name };
            _zoneOrder.Add(name);
        }

        // Restore the previous session (alarm state, doors, cameras) from the stored log.
        try
        {
            foreach (var e in _repo.LoadAll().OrderBy(x => x.Id))
            {
                _log.Add(e);
                Replay(e);
            }
            _nextId = _log.Count == 0 ? 1 : _log.Max(x => x.Id) + 1;
        }
        catch (Exception ex)
        {
            PersistenceError?.Invoke(ex);
        }
    }

    // ---------- Read access (thread-safe snapshots) ----------
    public AlarmState State { get { lock (_lock) return _state; } }

    public int LogCount { get { lock (_lock) return _log.Count; } }

    public List<SecurityEvent> GetLog() { lock (_lock) return _log.ToList(); }

    public List<ZoneState> GetZones()
    {
        lock (_lock) return _zoneOrder.Select(n => _zones[n].Clone()).ToList();
    }

    // ---------- Commands ----------
    public void Arm() => Run(n => SetState(AlarmState.Armed, SecurityEventType.AlarmArmed, "Alarm armed", n));

    public void Disarm() => Run(n => SetState(AlarmState.Disarmed, SecurityEventType.AlarmDisarmed, "Alarm disarmed", n));

    public void SimulateMotion(string room) => Run(n =>
    {
        if (_zones.TryGetValue(room, out var z))
        {
            z.MotionActive = true;
            z.MotionUntil = DateTime.Now.AddSeconds(MotionSeconds);
        }
        AddEvent(SecurityEventType.MotionDetected, room, "Motion sensor triggered", n);
        if (_state == AlarmState.Armed) Trigger(room, n);
    });

    public void SimulateDoor(string door, bool open) => Run(n => DoorCore(door, open, n));

    public void SetCamera(string zone, bool on) => Run(n =>
    {
        if (!_zones.TryGetValue(zone, out var z) || z.CameraOn == on) return;
        z.CameraOn = on;
        AddEvent(on ? SecurityEventType.CameraOn : SecurityEventType.CameraOff,
                 zone, on ? "Camera turned on" : "Camera turned off", n);
    });

    // "More" tile: clear motion and close the door of one zone.
    public void ResetZone(string zone) => Run(n =>
    {
        if (!_zones.TryGetValue(zone, out var z)) return;
        z.MotionActive = false;
        z.MotionUntil = null;
        if (z.DoorOpen) DoorCore(zone + " Door", false, n);
    });

    // Called by the UI timer. Returns true if any motion indicator expired.
    public bool ExpireMotion()
    {
        lock (_lock)
        {
            bool changed = false;
            var now = DateTime.Now;
            foreach (var z in _zones.Values)
            {
                if (z.MotionActive && z.MotionUntil.HasValue && now >= z.MotionUntil.Value)
                {
                    z.MotionActive = false;
                    z.MotionUntil = null;
                    changed = true;
                }
            }
            return changed;
        }
    }

    public void ClearLog()
    {
        lock (_lock)
        {
            _log.Clear();
            _nextId = 1;
            try { _repo.Clear(); }
            catch (Exception ex) { PersistenceError?.Invoke(ex); }
        }
    }

    // ---------- Internals (always called while holding _lock) ----------
    private void DoorCore(string door, bool open, List<Action> notes)
    {
        string zoneName = door.EndsWith(" Door") ? door[..^5] : door;
        if (_zones.TryGetValue(zoneName, out var z)) z.DoorOpen = open;

        AddEvent(open ? SecurityEventType.DoorOpened : SecurityEventType.DoorClosed,
                 door, open ? "Door opened" : "Door closed", notes);
        if (open && _state == AlarmState.Armed) Trigger(door, notes);
    }

    private void Trigger(string source, List<Action> notes)
    {
        _state = AlarmState.Triggered;
        var s = _state;
        notes.Add(() => StateChanged?.Invoke(s));
        AddEvent(SecurityEventType.AlarmTriggered, source, "Alarm triggered!", notes);
    }

    private void SetState(AlarmState s, SecurityEventType t, string details, List<Action> notes)
    {
        if (_state == s) return;
        _state = s;
        notes.Add(() => StateChanged?.Invoke(s));
        AddEvent(t, "System", details, notes);
    }

    private void AddEvent(SecurityEventType t, string location, string details, List<Action> notes)
    {
        var e = new SecurityEvent
        {
            Id = _nextId++,
            Type = t,
            Location = location,
            Details = details
        };
        _log.Add(e);
        try { _repo.Save(e); }
        catch (Exception ex) { notes.Add(() => PersistenceError?.Invoke(ex)); }
        notes.Add(() => EventLogged?.Invoke(e));
    }

    // Rebuilds state from a stored event (used on startup).
    private void Replay(SecurityEvent e)
    {
        switch (e.Type)
        {
            case SecurityEventType.AlarmArmed: _state = AlarmState.Armed; break;
            case SecurityEventType.AlarmDisarmed: _state = AlarmState.Disarmed; break;
            case SecurityEventType.AlarmTriggered: _state = AlarmState.Triggered; break;
            case SecurityEventType.DoorOpened:
            case SecurityEventType.DoorClosed:
                if (e.Location.EndsWith(" Door") && _zones.TryGetValue(e.Location[..^5], out var dz))
                    dz.DoorOpen = e.Type == SecurityEventType.DoorOpened;
                break;
            case SecurityEventType.CameraOn:
            case SecurityEventType.CameraOff:
                if (_zones.TryGetValue(e.Location, out var cz))
                    cz.CameraOn = e.Type == SecurityEventType.CameraOn;
                break;
        }
    }

    // Runs a change under the lock, then raises the events after the lock is released
    // so handlers (and other threads) can never deadlock the service.
    private void Run(Action<List<Action>> body)
    {
        var notes = new List<Action>();
        lock (_lock) body(notes);
        foreach (var n in notes) n();
    }
}
