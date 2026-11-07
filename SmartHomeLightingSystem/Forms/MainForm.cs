using System;
using System.Windows.Forms;
using SmartHomeLightingSystem.Data;

namespace SmartHomeLightingSystem.Forms
{
    // The main window of the application.
    // All controls are created in MainForm.Designer.cs (open MainForm.cs [Design] to see them).
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // When maximized, do not cover the Windows taskbar
            MaximizedBounds = Screen.PrimaryScreen.WorkingArea;

            // Load the saved settings from settings.json
            AppData.LoadSettings();

            // Give every page its data
            lightingDashboard.LoadData();
            roomsPage.LoadData();
            settingsPage.LoadData();
            securityPage.LoadData();
            overviewPage.RefreshData();
            energyPage.RefreshData();

            // React when the user clicks a navigation item
            navigationControl.PageSelected += NavigationControl_PageSelected;

            // Refresh all pages every time the lighting data changes
            AppData.DataChanged += AppData_DataChanged;
        }

        private void NavigationControl_PageSelected(string pageName)
        {
            // Hide every page first
            lightingDashboard.Visible = false;
            roomsPage.Visible = false;
            overviewPage.Visible = false;
            settingsPage.Visible = false;
            securityPage.Visible = false;
            energyPage.Visible = false;

            // Show only the selected page
            switch (pageName)
            {
                case "Lighting": lightingDashboard.Visible = true; break;
                case "Rooms": roomsPage.Visible = true; break;
                case "Overview": overviewPage.Visible = true; break;
                case "Settings": settingsPage.Visible = true; break;
                case "Security": securityPage.Visible = true; break;
                case "Energy": energyPage.Visible = true; break;
            }
        }

        private void AppData_DataChanged()
        {
            lightingDashboard.RefreshData();
            roomsPage.RefreshData();
            overviewPage.RefreshData();
            energyPage.RefreshData();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            AppData.DataChanged -= AppData_DataChanged;
            base.OnFormClosed(e);
        }

        private void navigationControl_Load(object sender, EventArgs e)
        {

        }
    }
}
