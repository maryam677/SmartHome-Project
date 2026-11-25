namespace WinFormsApp2.Popups;

public partial class AddRoomForm : Form
{
    public string RoomName { get; private set; } = string.Empty;
    public string RoomType { get; private set; } = string.Empty;

    public AddRoomForm()
    {
        InitializeComponent();
        cmbRoomType.SelectedIndex = 0;
    }

    private void Add_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtRoomName.Text))
        {
            MessageBox.Show(this, "Please enter a room name.", "Add Room",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtRoomName.Focus();
            return;
        }

        RoomName = txtRoomName.Text.Trim();
        RoomType = cmbRoomType.Text;
        MessageBox.Show(this, "Room details collected successfully.", "Add Room",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        DialogResult = DialogResult.OK;
        Close();
    }
}
