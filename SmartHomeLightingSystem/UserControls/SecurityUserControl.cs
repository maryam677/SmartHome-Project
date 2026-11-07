using System;
using System.Globalization;
using System.Windows.Forms;
using SmartHomeLightingSystem.Data;

namespace SmartHomeLightingSystem.UserControls
{
    // The Security page (simulation only, no real sensors).
    public partial class SecurityUserControl : UserControl
    {
        public SecurityUserControl()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            UpdateStatus();
        }

        private void btnArm_Click(object sender, EventArgs e)
        {
            AppData.SecurityArmed = true;
            UpdateStatus();
            AddNotification("Security system armed");
        }

        private void btnDisarm_Click(object sender, EventArgs e)
        {
            AppData.SecurityArmed = false;
            UpdateStatus();
            AddNotification("Security system disarmed");
        }

        private void UpdateStatus()
        {
            if (AppData.SecurityArmed)
            {
                lblSecurityStatus.Text = "ARMED";
                lblSecurityStatus.ForeColor = AppColors.OnlineGreen;
                lblShieldIcon.ForeColor = AppColors.OnlineGreen;
                lblSecurityStatusInfo.Text = "All doors locked • All sensors active";
                lblMotionSensorStatus.Text = "● Active - No motion";
                lblMotionSensorStatus.ForeColor = AppColors.OnlineGreen;
                lblDoorSensorStatus.Text = "● Closed & Locked";
                lblDoorSensorStatus.ForeColor = AppColors.OnlineGreen;
            }
            else
            {
                lblSecurityStatus.Text = "DISARMED";
                lblSecurityStatus.ForeColor = AppColors.DangerRed;
                lblShieldIcon.ForeColor = AppColors.DangerRed;
                lblSecurityStatusInfo.Text = "Sensors are paused";
                lblMotionSensorStatus.Text = "● Paused";
                lblMotionSensorStatus.ForeColor = AppColors.SecondaryText;
                lblDoorSensorStatus.Text = "● Not monitored";
                lblDoorSensorStatus.ForeColor = AppColors.SecondaryText;
            }
        }

        private void AddNotification(string message)
        {
            string time = DateTime.Now.ToString("hh:mm tt", CultureInfo.InvariantCulture);
            lstNotifications.Items.Insert(0, time + "    " + message);
        }
    }
}
