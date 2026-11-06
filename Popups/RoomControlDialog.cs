namespace SmartHomeRooms;

public partial class RoomControlDialog : Form
{
    public string SelectedAction => cmbAction.SelectedItem?.ToString() ?? "";

    public RoomControlDialog()
    {
        InitializeComponent();
    }

    public RoomControlDialog(string roomName) : this()
    {
        lblTitle.Text = $"More controls — {roomName}";
        Text = $"Smart Home — {roomName}";
    }
}
