using SmartHomeRooms;

namespace WinFormsApp2;

public partial class RoomsOverviewControl : UserControl
{
    private static readonly Color ButtonOn = Color.FromArgb(108, 92, 231);
    private static readonly Color ButtonOff = Color.FromArgb(55, 55, 85);
    private static readonly Color Muted = Color.FromArgb(180, 180, 200);

    public RoomsOverviewControl()
    {
        InitializeComponent();
        WireRoomCardEvents();
    }

    private void WireRoomCardEvents()
    {
        foreach (Control card in flowRoomCards.Controls)
        {
            if (card is not Panel) continue;
            var roomName = card.Controls.OfType<Label>()
                .FirstOrDefault(l => l.Font.Bold && l.Location.Y >= 180)?.Text ?? "Room";

            foreach (Control c in card.Controls)
            {
                if (c is not Button b) continue;
                if (b.Text == "★")
                {
                    b.Click += StarButton_Click;
                    continue;
                }
                b.Tag = roomName;
                if (b.Text == "...")
                    b.Click += MoreButton_Click;
                else
                    b.Click += QuickActionButton_Click;
            }
        }
    }

    private void QuickActionButton_Click(object? sender, EventArgs e)
    {
        if (sender is not Button btn) return;

        var isOn = btn.BackColor.R > 80;
        btn.BackColor = isOn ? ButtonOff : ButtonOn;
        var state = isOn ? "OFF" : "ON";

        var room = btn.Tag as string ?? "Room";
        MessageBox.Show(
            FindForm(),
            $"{room}\n{btn.Text} → {state}",
            "Device updated",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    private void MoreButton_Click(object? sender, EventArgs e)
    {
        if (sender is not Button btn) return;
        var room = btn.Tag as string ?? "Room";
        var owner = FindForm();

        using var dialog = new RoomControlDialog(room);
        if (dialog.ShowDialog(owner) == DialogResult.OK)
        {
            MessageBox.Show(
                owner,
                $"Saved for {room}:\n{dialog.SelectedAction}",
                "Smart Home",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }

    private void StarButton_Click(object? sender, EventArgs e)
    {
        if (sender is not Button star) return;
        star.ForeColor = star.ForeColor == Color.Gold ? Muted : Color.Gold;
    }
}
