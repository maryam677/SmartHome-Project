using System;
using System.Windows.Forms;
using SmartHomeLightingSystem.Controls;
using SmartHomeLightingSystem.Data;

namespace SmartHomeLightingSystem.UserControls
{
    // The Energy page: estimated power of every room and energy saving mode.
    public partial class EnergyUserControl : UserControl
    {
        public EnergyUserControl()
        {
            InitializeComponent();
        }

        public void RefreshData()
        {
            double watts = AppData.GetTotalWatts();
            double maxWatts = AppData.Rooms.Count * 60.0;
            double dailyKwh = watts * 6 / 1000;      // lights are on about 6 hours a day
            double monthlyKwh = dailyKwh * 30;

            // Statistic cards
            lblCurrentPowerValue.Text = Math.Round(watts) + " W";
            lblDailyEnergyValue.Text = dailyKwh.ToString("0.00") + " kWh";
            lblMonthlyEnergyValue.Text = monthlyKwh.ToString("0.0") + " kWh";
            lblActiveRoomsValue.Text = AppData.GetOnRoomsCount() + " / " + AppData.Rooms.Count;

            // Usage per room
            Label[] nameLabels = { lblLivingRoomName, lblBedroomName, lblKitchenName, lblBathroomName };
            Label[] wattLabels = { lblLivingRoomWatts, lblBedroomWatts, lblKitchenWatts, lblBathroomWatts };
            SimpleProgressBar[] bars = { progressLivingRoom, progressBedroom, progressKitchen, progressBathroom };

            for (int i = 0; i < AppData.Rooms.Count; i++)
            {
                RoomData room = AppData.Rooms[i];
                nameLabels[i].Text = room.Name;
                wattLabels[i].Text = room.GetWatts().ToString("0.0") + " W";
                bars[i].Value = (int)room.GetWatts();
            }

            // Energy saving mode box
            lblEstimatedPower.Text = Math.Round(watts) + " W of " + maxWatts + " W maximum";

            if (AppData.EnergySavingMode)
            {
                lblSavingStatus.Text = "Status: On";
                lblSavingStatus.ForeColor = AppColors.OnlineGreen;
                btnEnergySaving.Text = "Disable Saving Mode";
            }
            else
            {
                lblSavingStatus.Text = "Status: Off";
                lblSavingStatus.ForeColor = AppColors.SecondaryText;
                btnEnergySaving.Text = "Enable Saving Mode";
            }
        }

        private void btnEnergySaving_Click(object sender, EventArgs e)
        {
            AppData.EnergySavingMode = !AppData.EnergySavingMode;

            if (AppData.EnergySavingMode)
            {
                AppData.ApplyEnergySaving();   // this also refreshes all pages
            }
            else
            {
                RefreshData();
            }
        }
    }
}
