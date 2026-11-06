namespace WinFormsApp2.SmartHomeSecurity;

public enum AlarmState
{
    Disarmed,
    Armed,
    Triggered
}

public enum SecurityEventType
{
    MotionDetected,
    DoorOpened,
    DoorClosed,
    AlarmArmed,
    AlarmDisarmed,
    AlarmTriggered,
    CameraOn,
    CameraOff
}

public class SecurityEvent
{
    public int Id { get; set; }
    public DateTime Time { get; set; } = DateTime.Now;
    public SecurityEventType Type { get; set; }
    public string Location { get; set; } = "";
    public string Details { get; set; } = "";
}

// Live state of one security zone (room). Kept in SecurityService so it survives
// the page being closed and re-created.
public class ZoneState
{
    public string Name { get; set; } = "";
    public bool MotionActive { get; set; }
    public bool DoorOpen { get; set; }
    public bool CameraOn { get; set; } = true;
    public DateTime? MotionUntil { get; set; }

    public ZoneState Clone() => (ZoneState)MemberwiseClone();
}
