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
        UpdateRoomCounters();
    }

    private void AddRoom_Click(object? sender, EventArgs e)
    {
        using var dialog = new Popups.AddRoomForm();
        dialog.ShowDialog(this);
    }

    private void DeleteRoom_Click(object? sender, EventArgs e)
    {
        if (sender is not Button { Parent: Panel card }) return;
        if (MessageBox.Show(this, "Delete this room?", "Delete Room",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
        flowRoomCards.Controls.Remove(card);
        card.Dispose();
        UpdateRoomCounters();
    }

    private void UpdateRoomCounters()
    {
        var cards = flowRoomCards.Controls.OfType<Panel>().ToArray();
        Label Field(Panel card, string suffix) => card.Controls.OfType<Label>()
            .Single(label => label.Name == card.Name + suffix);
        int active = cards.Count(card => Field(card, "_status").Text.Contains("Online"));
        statRooms_val.Text = $"{active} / {cards.Length}";
        statRooms_badge.Text = active > 0 ? "\u25CF Online" : "\u25CF Offline";
        statRooms_badge.ForeColor = active > 0 ? Color.LightGreen : Muted;
        int lights = 0, devices = 0;
        double temperature = 0;
        foreach (var card in cards)
        {
            var counts = System.Text.RegularExpressions.Regex.Matches(Field(card, "_counts").Text, @"\d+");
            lights += int.Parse(counts[0].Value);
            devices += int.Parse(counts[1].Value);
            var value = System.Text.RegularExpressions.Regex.Match(Field(card, "_temp").Text, @"\d+");
            temperature += double.Parse(value.Value, System.Globalization.CultureInfo.InvariantCulture);
        }
        statLights_val.Text = lights.ToString();
        statDevices_val.Text = devices.ToString();
        statTemp_val.Text = cards.Length == 0 ? "\u2014" : $"{temperature / cards.Length:0.#}\u00B0C";
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
                if (c is not Button b || b.Name.EndsWith("_delete")) continue;
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
