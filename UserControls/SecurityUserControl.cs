using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp2.SmartHomeSecurity;

namespace WinFormsApp2.UserControls
{
    public partial class SecurityUserControl : UserControl
    {
        private readonly SecurityService securityService;
        private readonly Random random = new Random();
        private SecurityAlarmPopup? alarmPopup;
        private bool wasHosted;
        private bool eventsAttached;

        // The Designer uses an in-memory service and does not write security files.
        public SecurityUserControl() : this(new SecurityService())
        {
        }
       
        public SecurityUserControl(SecurityService service)
        {
            securityService = service;
            InitializeComponent();
        
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            securityService.StateChanged += SecurityStateChanged;
            securityService.EventLogged += SecurityEventLogged;
            eventsAttached = true;
            RefreshSecurity();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;
            tmrUi.Start();
        }

        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;
            if (Parent != null)
                wasHosted = true;
            else if (wasHosted && !IsDisposed && !Disposing)
                Dispose();
        }

        private void DetachSecurityEvents()
        {
            if (!eventsAttached)
                return;
            eventsAttached = false;
            securityService.StateChanged -= SecurityStateChanged;
            securityService.EventLogged -= SecurityEventLogged;
            tmrAuto.Stop();
            tmrUi.Stop();
            alarmPopup?.Dispose();
        }

        private void btnArm_Click(object? sender, EventArgs e)
        {
            securityService.Arm();
        }

        private void btnDisarm_Click(object? sender, EventArgs e)
        {
            securityService.Disarm();
            alarmPopup?.Close();
        }

        private void btnClearLog_Click(object? sender, EventArgs e)
        {
            securityService.ClearLog();
            RefreshSecurity();
        }

        private void chkAutoSim_CheckedChanged(object? sender, EventArgs e)
        {
            if (!DesignMode && LicenseManager.UsageMode != LicenseUsageMode.Designtime)
                tmrAuto.Enabled = chkAutoSim.Checked;
        }

        private void btnMotion_Click(object? sender, EventArgs e)
        {
            if (sender is Button button && button.Tag is string zone)
                securityService.SimulateMotion(zone);
        }

        private void btnDoor_Click(object? sender, EventArgs e)
        {
            if (sender is Button button && button.Tag is string name)
            {
                ZoneState zone = securityService.GetZones().First(z => z.Name == name);
                securityService.SimulateDoor(name + " Door", !zone.DoorOpen);
            }
        }

        private void btnCamera_Click(object? sender, EventArgs e)
        {
            if (sender is Button button && button.Tag is string name)
            {
                ZoneState zone = securityService.GetZones().First(z => z.Name == name);
                securityService.SetCamera(name, !zone.CameraOn);
            }
        }

        private void btnReset_Click(object? sender, EventArgs e)
        {
            if (sender is Button button && button.Tag is string name)
            {
                securityService.ResetZone(name);
                RefreshSecurity();
            }
        }

        private void tmrAuto_Tick(object? sender, EventArgs e)
        {
            var zones = securityService.GetZones();
            ZoneState zone = zones[random.Next(zones.Count)];
            if (random.Next(2) == 0)
                securityService.SimulateMotion(zone.Name);
            else
                securityService.SimulateDoor(zone.Name + " Door", !zone.DoorOpen);
        }

        private void tmrUi_Tick(object? sender, EventArgs e)
        {
            if (securityService.ExpireMotion())
                RefreshSecurity();
        }

        private void SecurityStateChanged(AlarmState state)
        {
            RefreshSecurity();
        }

        private void SecurityEventLogged(SecurityEvent securityEvent)
        {
            RefreshSecurity();
            if (securityEvent.Type == SecurityEventType.AlarmTriggered &&
                (alarmPopup == null || alarmPopup.IsDisposed))
            {
                alarmPopup = new SecurityAlarmPopup(securityEvent.Location);
                alarmPopup.Show(FindForm());
            }
        }

        private void RefreshSecurity()
        {
            AlarmState state = securityService.State;
            Color stateColor = state == AlarmState.Disarmed ? Color.FromArgb(111, 227, 160)
                : state == AlarmState.Armed ? Color.FromArgb(255, 167, 38)
                : Color.FromArgb(255, 107, 107);
            lblAlarmState.Text = state.ToString();
            lblAlarmState.ForeColor = stateColor;
            lblStatAlarm.Text = state.ToString();
            lblStatAlarm.ForeColor = stateColor;
            if (state == AlarmState.Armed)
                lblAlarmHint.Text = "Any motion or open door will trigger the alarm.";
            else if (state == AlarmState.Triggered)
                lblAlarmHint.Text = "Intrusion detected! Press Disarm to stop the alarm.";
            else
                lblAlarmHint.Text = "System is not monitoring. Press Arm to start.";

            // These are existing Designer controls, not controls created at runtime.
            Label[] statusLabels = { lblLivingStatus, lblBedroomStatus, lblKitchenStatus, lblBathroomStatus, lblGarageStatus };
            Label[] onlineLabels = { lblLivingOnline, lblBedroomOnline, lblKitchenOnline, lblBathroomOnline, lblGarageOnline };
            Button[] motionButtons = { btnLivingMotion, btnBedroomMotion, btnKitchenMotion, btnBathroomMotion, btnGarageMotion };
            Button[] doorButtons = { btnLivingDoor, btnBedroomDoor, btnKitchenDoor, btnBathroomDoor, btnGarageDoor };
            Button[] cameraButtons = { btnLivingCamera, btnBedroomCamera, btnKitchenCamera, btnBathroomCamera, btnGarageCamera };
            var zones = securityService.GetZones();
            for (int i = 0; i < zones.Count && i < statusLabels.Length; i++)
            {
                ZoneState zone = zones[i];
                bool alert = state == AlarmState.Triggered && (zone.MotionActive || zone.DoorOpen);
                statusLabels[i].Text = zone.MotionActive ? "Motion" : zone.DoorOpen ? "Door open" : "Secure";
                statusLabels[i].ForeColor = zone.MotionActive || zone.DoorOpen
                    ? Color.FromArgb(255, 167, 38) : Color.FromArgb(111, 227, 160);
                onlineLabels[i].Text = alert ? "● Alert" : "● Online";
                onlineLabels[i].ForeColor = alert ? Color.FromArgb(255, 107, 107) : Color.FromArgb(111, 227, 160);
                motionButtons[i].Text = zone.MotionActive ? "Motion\r\nDetected" : "Motion\r\nClear";
                doorButtons[i].Text = zone.DoorOpen ? "Door\r\nOpen" : "Door\r\nClosed";
                cameraButtons[i].Text = zone.CameraOn ? "Camera\r\nActive" : "Camera\r\nOff";
                motionButtons[i].BackColor = zone.MotionActive ? Color.FromArgb(150, 92, 20) : Color.FromArgb(40, 36, 86);
                doorButtons[i].BackColor = zone.DoorOpen ? Color.FromArgb(150, 92, 20) : Color.FromArgb(40, 36, 86);
                cameraButtons[i].BackColor = zone.CameraOn ? Color.FromArgb(124, 77, 255) : Color.FromArgb(40, 36, 86);
            }
            lblStatZones.Text = zones.Count.ToString();
            lblStatEvents.Text = securityService.LogCount.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnsystem_Click(object sender, EventArgs e)
        {
            string diagnosticsReport =
        "SYSTEM DIAGNOSTICS REPORT \n\n" +
        "• System Integrity: Optimal (100%)\n" +
        "• Power Reserve: Stable (85% Battery)\n" +
        "• Network Strength: Excellent (-55 dBm)\n" +
        "• Security Firewall: Active & Secure\n\n" +
        "Status: All security protocols operating normally.";

            MessageBox.Show(diagnosticsReport, "System Health Diagnostics", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

     
    }

    // Kept in the approved Security files so no extra project files are required.
    internal partial class SecurityAlarmPopup : Form
    {
        public SecurityAlarmPopup()
        {
            InitializeComponent();
        }

        public SecurityAlarmPopup(string source) : this()
        {
            lblPopupMessage.Text = "Source: " + source + "\r\n" + DateTime.Now.ToString("HH:mm:ss");
        }

        protected override bool ShowWithoutActivation => true;

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            popupTimer.Start();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            base.OnKeyDown(e);
        }

        private void btnDismiss_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void popupTimer_Tick(object? sender, EventArgs e)
        {
            Close();
        }
    }
}
