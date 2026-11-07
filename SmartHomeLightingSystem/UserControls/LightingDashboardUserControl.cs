using System;
using System.Globalization;
using System.Windows.Forms;
using SmartHomeLightingSystem.Data;

namespace SmartHomeLightingSystem.UserControls
{
    // The main Lighting page: header, 4 room cards, color control, quick actions and system overview.
    public partial class LightingDashboardUserControl : UserControl
    {
        public LightingDashboardUserControl()
        {
            InitializeComponent();
        }

        // Called once by MainForm when the application starts
        public void LoadData()
        {
            cardLivingRoom.Room = AppData.Rooms[0];
            cardBedroom.Room = AppData.Rooms[1];
            cardKitchen.Room = AppData.Rooms[2];
            cardBathroom.Room = AppData.Rooms[3];

            RefreshData();

            UpdateClock();
            timerClock.Start();
        }

        // Called every time the lighting data changes
        public void RefreshData()
        {
            cardLivingRoom.RefreshFromRoom();
            cardBedroom.RefreshFromRoom();
            cardKitchen.RefreshFromRoom();
            cardBathroom.RefreshFromRoom();
            systemOverview.RefreshData();
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
    }
}
