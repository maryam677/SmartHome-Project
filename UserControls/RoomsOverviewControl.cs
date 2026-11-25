using WinFormsApp2.Controls;
using WinFormsApp2.Data;

namespace WinFormsApp2;

public partial class RoomsOverviewControl : UserControl
{
    private readonly Panel cardsHost = new();
    private readonly RoomEnergyChart energyChart = new();
    private readonly DeviceStatusDonut statusDonut = new();
    private readonly AddRoomButton addButton = new();

    public RoomsOverviewControl()
    {
        InitializeComponent();
        DoubleBuffered = true;
        BackColor = RoomsTheme.Page;
        ForeColor = Color.White;

        cardsHost.BackColor = RoomsTheme.Page;
        cardsHost.AutoScroll = true;

        Controls.Add(energyChart);
        Controls.Add(statusDonut);
        Controls.Add(cardsHost);
        Controls.Add(addButton);
        addButton.BringToFront();
        addButton.Click += AddRoom_Click;

        RebuildCards();
        Resize += (_, _) => LayoutDashboard();
        Paint += PaintHeader;
        LayoutDashboard();
    }

    private void AddRoom_Click(object? sender, EventArgs e)
    {
        using Popups.AddRoomForm dialog = new Popups.AddRoomForm();
        if (dialog.ShowDialog(FindForm()) != DialogResult.OK) return;

        RoomCatalog.Add(RoomCatalog.Create(dialog.RoomName, dialog.RoomType));
        RebuildCards();
        LayoutDashboard();
    }

    private void DeleteRoom(RoomRecord room)
    {
        if (MessageBox.Show(FindForm(), "Delete " + room.Name + "?", "Delete Room",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
            return;

        RoomCatalog.Remove(room);
        RebuildCards();
        LayoutDashboard();
    }

    private void RebuildCards()
    {
        cardsHost.SuspendLayout();
        while (cardsHost.Controls.Count > 0)
        {
            Control card = cardsHost.Controls[0];
            cardsHost.Controls.RemoveAt(0);
            card.Dispose();
        }

        foreach (RoomRecord room in RoomCatalog.Rooms)
        {
            RoomCardControl card = new RoomCardControl
            {
                RoomName = room.Name,
                Photo = room.Photo,
                Marks = room.Devices.ToArray(),
                Tag = room
            };
            card.DevicesChanged += (_, _) =>
            {
                RoomCatalog.Save();
                RefreshCharts();
            };
            card.DeleteRequested += (_, _) => DeleteRoom(room);
            cardsHost.Controls.Add(card);
        }

        cardsHost.ResumeLayout();
        RefreshCharts();
    }

    private void RefreshCharts()
    {
        energyChart.SetRows(RoomCatalog.Rooms.Select(room => (room.Name, room.LiveKwh)).ToArray());
        statusDonut.SetCounts(RoomCatalog.DevicesOn, RoomCatalog.DevicesOff);
    }

    private void LayoutDashboard()
    {
        int pad = 16;
        int buttonW = 148;
        addButton.SetBounds(Math.Max(pad, ClientSize.Width - pad - buttonW), 12, buttonW, 40);

        int header = 70;
        int columns = 3;
        int cardGap = 12;
        int cardH = 176;
        int rows = Math.Max(1, (int)Math.Ceiling(Math.Max(1, cardsHost.Controls.Count) / (double)columns));
        if (cardsHost.Controls.Count == 0) rows = 0;
        int cardsHeight = rows == 0 ? 8 : rows * cardH + Math.Max(0, rows - 1) * cardGap;
        int chartTop = header + cardsHeight + 14;
        int chartH = Math.Max(210, ClientSize.Height - chartTop - pad);
        int gap = 12;
        int chartW = Math.Max(220, (int)((ClientSize.Width - pad * 2 - gap) * 0.64));
        energyChart.SetBounds(pad, chartTop, chartW, chartH);
        statusDonut.SetBounds(pad + chartW + gap, chartTop, Math.Max(220, ClientSize.Width - pad * 2 - chartW - gap), chartH);

        cardsHost.SetBounds(pad, header, Math.Max(100, ClientSize.Width - pad * 2), Math.Max(cardsHeight, 8));
        if (cardsHost.Controls.Count == 0) return;

        int cardW = Math.Max(240, (cardsHost.ClientSize.Width - cardGap * (columns - 1)) / columns);
        for (int i = 0; i < cardsHost.Controls.Count; i++)
        {
            int col = i % columns;
            int row = i / columns;
            cardsHost.Controls[i].SetBounds(col * (cardW + cardGap), row * (cardH + cardGap), cardW, cardH);
        }
    }

    private void PaintHeader(object? sender, PaintEventArgs e)
    {
        TextRenderer.DrawText(e.Graphics, "Rooms Overview", RoomsTheme.Title,
            new Rectangle(16, 8, Width - 190, 32), Color.White,
            TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding | TextFormatFlags.EndEllipsis);
        TextRenderer.DrawText(e.Graphics, "Manage your rooms, view devices, and monitor energy consumption.", RoomsTheme.Subtitle,
            new Rectangle(18, 40, Width - 190, 22), RoomsTheme.Muted,
            TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding | TextFormatFlags.EndEllipsis);
    }
}
