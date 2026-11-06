using System;
using System.Windows.Forms;
using WinFormsApp2.Data;

namespace WinFormsApp2.UserControls
{
    // The Settings page. Settings are saved to settings.json.
    public partial class SettingsUserControl : UserControl
    {
        public SettingsUserControl()
        {
            InitializeComponent();
        }

        // Shows the current settings in the controls
        public void LoadData()
        {
            AppSettings settings = AppData.Settings;

            trackDefaultBrightness.Value = settings.DefaultBrightness;
            lblDefaultBrightnessValue.Text = settings.DefaultBrightness + "%";
            chkNotifications.Checked = settings.NotificationsEnabled;
            chkAutoOff.Checked = settings.AutoOffEnabled;

            cmbTheme.SelectedIndex = cmbTheme.Items.IndexOf(settings.Theme);
            if (cmbTheme.SelectedIndex < 0)
            {
                cmbTheme.SelectedIndex = 0;
            }
        }

        private void trackDefaultBrightness_Scroll(object sender, EventArgs e)
        {
            lblDefaultBrightnessValue.Text = trackDefaultBrightness.Value + "%";
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            AppData.Settings.DefaultBrightness = trackDefaultBrightness.Value;
            AppData.Settings.NotificationsEnabled = chkNotifications.Checked;
            AppData.Settings.AutoOffEnabled = chkAutoOff.Checked;
            AppData.Settings.Theme = cmbTheme.Text;
            AppData.SaveSettings();

            lblSaveStatus.Text = "Settings saved successfully.";
        }

        private void btnResetSettings_Click(object sender, EventArgs e)
        {
            AppData.Settings = new AppSettings();
            AppData.SaveSettings();
            LoadData();

            lblSaveStatus.Text = "Settings reset to default values.";
        }
    }
}
