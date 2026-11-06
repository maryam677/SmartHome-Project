using System;
using System.Windows.Forms;
using WinFormsApp2.Controls;
using WinFormsApp2.Data;

namespace WinFormsApp2.UserControls
{
    // The Overview page: statistic cards and the brightness of every room.
    public partial class OverviewUserControl : UserControl
    {
        public OverviewUserControl()
        {
            InitializeComponent();
        }

        public void RefreshData()
        {
            int roomCount = AppData.Rooms.Count;
            int onCount = AppData.GetOnRoomsCount();
            int offCount = AppData.GetOffRoomsCount();
            int average = AppData.GetAverageBrightness();
            double watts = AppData.GetTotalWatts();
            double maxWatts = roomCount * 60.0;

            // Statistic cards
            lblTotalRoomsValue.Text = roomCount.ToString();
            lblLightsOnValue.Text = onCount.ToString();
            lblLightsOffValue.Text = offCount.ToString();
            lblAvgBrightnessValue.Text = average + "%";
            lblEnergyValue.Text = Math.Round(watts) + " W";

            progressTotalRooms.Value = 100;
            progressLightsOn.Value = onCount * 100 / roomCount;
            progressLightsOff.Value = offCount * 100 / roomCount;
            progressAvgBrightness.Value = average;
            progressEnergy.Value = (int)(watts * 100 / maxWatts);

            // Room brightness list
            Label[] nameLabels = { lblLivingRoomName, lblBedroomName, lblKitchenName, lblBathroomName };
            Label[] statusLabels = { lblLivingRoomStatus, lblBedroomStatus, lblKitchenStatus, lblBathroomStatus };
            Label[] valueLabels = { lblLivingRoomValue, lblBedroomValue, lblKitchenValue, lblBathroomValue };
            SimpleProgressBar[] bars = { progressLivingRoom, progressBedroom, progressKitchen, progressBathroom };

            for (int i = 0; i < roomCount; i++)
            {
                RoomData room = AppData.Rooms[i];
                nameLabels[i].Text = room.Name;
                statusLabels[i].Text = room.IsOn ? "On" : "Off";
                statusLabels[i].ForeColor = room.IsOn ? AppColors.OnlineGreen : AppColors.SecondaryText;
                valueLabels[i].Text = room.Brightness + "%";
                bars[i].Value = room.Brightness;
                bars[i].BarColor = room.LightColor;
            }
        }
    }
}
