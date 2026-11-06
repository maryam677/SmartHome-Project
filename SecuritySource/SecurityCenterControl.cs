using WinFormsApp2.SmartHomeSecurity;
using WinFormsApp2.SmartHomeSecurity.Popups;

namespace SmartHome;

public partial class SecurityCenterControl : UserControl
{
    private readonly SecurityService _service;
    private readonly Random _rnd = new();
    private readonly List<SecZoneCard> _zones = new();
    private bool _layouting;

    // Needed only so the Visual Studio designer can open this control.
    // In the real app always use the constructor that takes the shared service.
    public SecurityCenterControl() : this(new SecurityService()) { }

    public SecurityCenterControl(SecurityService service)
    {
        InitializeComponent();
        _service = service;
        // the 5 zone cards are placed in the Designer; map them to the service zones by order
        _zones.AddRange(new[] { zoneLiving, zoneBedroom, zoneKitchen, zoneBathroom, zoneGarage });
        foreach (var z in _zones) z.TileClicked += OnTileClicked;
        dgvLog.AutoGenerateColumns = false;

        _service.StateChanged += OnStateChanged;
        _service.EventLogged += OnEventLogged;

        // The page is re-created each time it is shown, so unsubscribe when it is closed.
        Disposed += (_, _) =>
        {
            tmrAuto.Stop();
            tmrUi.Stop();
            _service.StateChanged -= OnStateChanged;
            _service.EventLogged -= OnEventLogged;
        };

        Resize += (_, _) => ApplyLayout();
        ApplyLayout();
        UpdateStateUI(_service.State);
        RefreshAll();
    }

    private int S(int v) => (int)Math.Round(v * DeviceDpi / 96.0);

    // ---------- Layout (the page is docked inside pnlContent) ----------
    private void ApplyLayout()
    {
        if (_layouting || _zones.Count == 0) return;
        _layouting = true;
        try
        {
            for (int pass = 0; pass < 2; pass++)
            {
                int before = ClientSize.Width;
                LayoutOnce();
                if (ClientSize.Width == before) break;
            }
        }
        finally
        {
            _layouting = false;
        }
    }

    private void LayoutOnce()
    {
        int ox = AutoScrollPosition.X, oy = AutoScrollPosition.Y;
        int m = S(24), gap = S(14);
        int w = Math.Max(S(700), ClientSize.Width - m * 2);

        void Place(Control c, int x, int y, int cw, int ch) => c.SetBounds(x + ox, y + oy, cw, ch);

        // header
        lblPageIcon.Location = new Point(m + ox, S(18) + oy);
        lblTitle.Location = new Point(m + S(52) + ox, S(10) + oy);
        lblSubtitle.Location = new Point(m + S(55) + ox, S(52) + oy);

        int sw = S(132), sh = S(64), sg = S(10);
        int sx = m + w - sw * 3 - sg * 2;
        Place(cardStatAlarm, sx, S(12), sw, sh);
        Place(cardStatZones, sx + sw + sg, S(12), sw, sh);
        Place(cardStatEvents, sx + (sw + sg) * 2, S(12), sw, sh);

        // zone cards: 3 on the first row, 2 on the second, alarm card fills the last slot
        int cw = (w - gap * 2) / 3, ch = S(276);
        int top1 = S(104), top2 = top1 + ch + gap;
        for (int i = 0; i < _zones.Count; i++)
        {
            int row = i / 3, col = i % 3;
            Place(_zones[i], m + col * (cw + gap), row == 0 ? top1 : top2, cw, ch);
        }
        Place(cardAlarm, m + 2 * (cw + gap), top2, cw, ch);

        int ip = S(18), bw = (cw - ip * 2 - S(10)) / 2;
        lblAlarmHint.MaximumSize = new Size(cw - ip * 2, 0);
        btnArm.SetBounds(ip, S(166), bw, S(44));
        btnDisarm.SetBounds(ip + bw + S(10), S(166), bw, S(44));
        chkAutoSim.Location = new Point(ip, S(226));

        // log
        int logTop = top2 + ch + gap + S(6);
        lblLog.Location = new Point(m + ox, logTop + oy);
        Place(btnClearLog, m + w - S(110), logTop - S(2), S(110), S(34));
        int dgvTop = logTop + S(44);
        int dgvH = Math.Max(S(180), ClientSize.Height - dgvTop - m);
        Place(dgvLog, m, dgvTop, w, dgvH);

        AutoScrollMinSize = new Size(0, dgvTop + dgvH + m);
    }

    // ---------- Button handlers (wired in the Designer) ----------
    private void btnArm_Click(object? sender, EventArgs e) => _service.Arm();

    private void btnDisarm_Click(object? sender, EventArgs e) => _service.Disarm();

    private void btnClearLog_Click(object? sender, EventArgs e)
    {
        _service.ClearLog();
        RefreshAll();
    }

    private void chkAutoSim_CheckedChanged(object? sender, EventArgs e) => tmrAuto.Enabled = chkAutoSim.Checked;

    // ---------- Zone tiles ----------
    private void OnTileClicked(SecZoneCard card, int tile)
    {
        switch (tile)
        {
            case 0:
                _service.SimulateMotion(card.ZoneName);
                break;
            case 1:
                _service.SimulateDoor($"{card.ZoneName} Door", !card.DoorOpen);
                break;
            case 2:
                _service.SetCamera(card.ZoneName, !card.CameraOn);
                break;
            case 3:
                _service.ResetZone(card.ZoneName);
                break;
        }
        RefreshAll();
    }

    // ---------- Timers ----------
    private void tmrAuto_Tick(object? sender, EventArgs e)
    {
        var zones = _service.GetZones();
        var z = zones[_rnd.Next(zones.Count)];
        if (_rnd.Next(2) == 0)
            _service.SimulateMotion(z.Name);
        else
            _service.SimulateDoor($"{z.Name} Door", !z.DoorOpen);
    }

    private void tmrUi_Tick(object? sender, EventArgs e)
    {
        if (_service.ExpireMotion()) SyncZones();
    }

    // ---------- Service events ----------
    private void OnStateChanged(AlarmState s)
    {
        if (IsDisposed) return;
        if (InvokeRequired) { Invoke(new Action(() => UpdateStateUI(s))); return; }
        UpdateStateUI(s);
    }

    private void OnEventLogged(SecurityEvent ev)
    {
        if (IsDisposed) return;
        if (InvokeRequired) { Invoke(new Action(() => HandleEvent(ev))); return; }
        HandleEvent(ev);
    }

    private AlarmPopup? _popup;

    private void HandleEvent(SecurityEvent ev)
    {
        if (ev.Type == SecurityEventType.AlarmTriggered && (_popup == null || _popup.IsDisposed))
        {
            _popup = new AlarmPopup(ev.Location);
            _popup.Show(FindForm());
        }
        RefreshAll();
    }

    // ---------- UI helpers ----------
    private void UpdateStateUI(AlarmState s)
    {
        Color c = s switch
        {
            AlarmState.Armed => SecTheme.Warn,
            AlarmState.Triggered => SecTheme.Bad,
            _ => SecTheme.Good
        };

        lblAlarmState.Text = s.ToString();
        lblAlarmState.ForeColor = c;
        lblStatAlarm.Text = s.ToString();
        lblStatAlarm.ForeColor = c;

        lblAlarmHint.Text = s switch
        {
            AlarmState.Armed => "Any motion or open door will trigger the alarm.",
            AlarmState.Triggered => "Intrusion detected! Press Disarm to stop the alarm.",
            _ => "System is not monitoring. Press Arm to start."
        };

        RefreshZoneAlerts();
    }

    private void RefreshZoneAlerts()
    {
        foreach (var z in _zones)
            z.Alert = _service.State == AlarmState.Triggered && (z.MotionActive || z.DoorOpen);
    }

    // Copies the service's zone state into the zone cards.
    private void SyncZones()
    {
        var states = _service.GetZones().ToDictionary(z => z.Name);
        foreach (var card in _zones)
        {
            if (!states.TryGetValue(card.ZoneName, out var st)) continue;
            card.MotionActive = st.MotionActive;
            card.DoorOpen = st.DoorOpen;
            card.CameraOn = st.CameraOn;
        }
        RefreshZoneAlerts();
    }

    private void RefreshAll()
    {
        SyncZones();
        lblStatZones.Text = _zones.Count.ToString();
        lblStatEvents.Text = _service.LogCount.ToString();
        RefreshLog();
    }

    private void RefreshLog()
    {
        dgvLog.DataSource = null;
        dgvLog.DataSource = _service.GetLog().OrderByDescending(x => x.Time).ThenByDescending(x => x.Id).ToList();

        if (dgvLog.Columns["Time"] != null)
            dgvLog.Columns["Time"]!.DefaultCellStyle.Format = "HH:mm:ss";
        if (dgvLog.Columns["Id"] != null)
            dgvLog.Columns["Id"]!.Width = 50;
        if (dgvLog.Columns["Details"] != null)
            dgvLog.Columns["Details"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    }
}
