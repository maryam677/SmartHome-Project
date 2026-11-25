using System;
using System.Globalization;
using System.Windows.Forms;
using WinFormsApp2.Data;

namespace WinFormsApp2.UserControls
{
    // The main Lighting page: header, 4 room cards, color control, quick actions and system overview.
    public partial class LightingDashboardUserControl : UserControl
    {
        public LightingDashboardUserControl()
        {
            InitializeComponent();

            Load += (s, e) =>
            {
                if (cardLivingRoom.Room == null)
                {
                    LoadData();
                }
            };
        }

        // Called once by MainForm when the application starts
        public void LoadData()
        {
            cardLivingRoom.Room = AppData.Rooms[0];
            cardBedroom.Room = AppData.Rooms[1];
            cardKitchen.Room = AppData.Rooms[2];
            cardBathroom.Room = AppData.Rooms[3];

            RefreshData();

            AppData.DataChanged += OnDataChanged;

            visualizationPanel.StartListening();

            UpdateClock();
            timerClock.Start();
        }

        private void OnDataChanged()
        {
            if (IsDisposed) return;
            if (InvokeRequired)
            {
                BeginInvoke(new Action(OnDataChanged));
                return;
            }
            RefreshData();
        }

        // Called every time the lighting data changes
        public void RefreshData()
        {
            cardLivingRoom.RefreshFromRoom();
            cardBedroom.RefreshFromRoom();
            cardKitchen.RefreshFromRoom();
            cardBathroom.RefreshFromRoom();
            systemOverview.RefreshData();
            visualizationPanel?.RefreshVisuals();
        }

        private void UpdateClock()
        {
            lblTime.Text = DateTime.Now.ToString("h:mm tt", CultureInfo.InvariantCulture);
            lblDate.Text = DateTime.Now.ToString("MMM d, yyyy", CultureInfo.InvariantCulture);
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            UpdateClock();
        }

private void cardLivingRoom_Load(object sender, EventArgs e)
{
}

private void btnLight_Click(object sender, EventArgs e)
{
    Form1 popup = new Form1();
    popup.ShowDialog();
}

private void cardLivingRoom_Click(object sender, EventArgs e)
{
}

private void btnSettings_Click(object sender, EventArgs e)
{
    Form1 popup = new Form1();
    popup.ShowDialog();
}

private void cardBedroom_Click(object sender, EventArgs e)
{
}

protected override void OnHandleDestroyed(EventArgs e)
{
    AppData.DataChanged -= OnDataChanged;
    base.OnHandleDestroyed(e);
}
        }
    }



