using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
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
        private bool chromeReady;
        private readonly HashSet<Button> hoveredButtons = new();

        private static readonly Color PageBack = Color.FromArgb(16, 11, 40);
        private static readonly Color CardFill = Color.FromArgb(30, 22, 68);
        private static readonly Color CardBorder = Color.FromArgb(118, 84, 196);
        private static readonly Color MutedText = Color.FromArgb(176, 170, 206);
        private static readonly Color Green = Color.FromArgb(52, 211, 153);
        private static readonly Color Purple = Color.FromArgb(124, 77, 255);
        private static readonly Color ButtonIdle = Color.FromArgb(46, 36, 102);
        private const float HealthIntegrity = 0.65f;
        private const float HealthPower = 0.58f;
        private const float HealthNetwork = 0.72f;

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

            ApplySecurityChrome();

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
            ArrangeSecurity();
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
            lblStatAlarm.ForeColor = Color.White;
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
            lbl58.Text = securityService.LogCount.ToString();
            lbl58.ForeColor = Green;
            cardAlarm.Invalidate();
            if (chromeReady)
                RebuildAllWaves();
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
            PaintFooter(e.Graphics, panel1);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
        }

        private void ApplySecurityChrome()
        {
            if (chromeReady)
                return;
            chromeReady = true;

            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw, true);
            UpdateStyles();
            BackColor = PageBack;
            Resize += (_, _) => ArrangeSecurity();

            StyleTitle();
            WireZone(zoneLiving);
            WireZone(zoneBathroom);
            WireZone(zoneBedroom);
            WireZone(zoneKitchen);
            WireZone(zoneGarage);
            WireBanner(pnlLivingBanner);
            WireBanner(pnlBathroomBanner);
            WireBanner(pnlBedroomBanner);
            WireBanner(pnlKitchenBanner);
            WireBanner(pnlGarageBanner);
            HideGlyph(lblLivingHome);
            HideGlyph(lblBathroomHome);
            HideGlyph(lblBedroomHome);
            HideGlyph(lblKitchenHome);
            HideGlyph(lblGarageHome);
            HideGlyph(lblLivingOnline);
            HideGlyph(lblBathroomOnline);
            HideGlyph(lblBedroomOnline);
            HideGlyph(lblKitchenOnline);
            HideGlyph(lblGarageOnline);

            WireStatus(lblLivingStatus);
            WireStatus(lblBathroomStatus);
            WireStatus(lblBedroomStatus);
            WireStatus(lblKitchenStatus);
            WireStatus(lblGarageStatus);
            WireInfo(pnlLivingInfo);
            WireInfo(pnlBathroomInfo);
            WireInfo(pnlBedroomInfo);
            WireInfo(pnlKitchenInfo);
            WireInfo(pnlGarageInfo);

            foreach (Button button in new[]
            {
                btnLivingMotion, btnLivingDoor, btnLivingCamera, btnLivingReset,
                btnBathroomMotion, btnBathroomDoor, btnBathroomCamera, btnBathroomReset,
                btnBedroomMotion, btnBedroomDoor, btnBedroomCamera, btnBedroomReset,
                btnKitchenMotion, btnKitchenDoor, btnKitchenCamera, btnKitchenReset,
                btnGarageMotion, btnGarageDoor, btnGarageCamera, btnGarageReset,
                btnArm, btnDisarm, btnsystem
            })
                WireButton(button);

            WireStat(cardStatAlarm);
            WireStat(cardStatZones);
            WireStat(cardStatEvents);
            Tune(cardAlarm);
            Tune(pnlsys);
            Tune(panel1);
            cardAlarm.BackColor = CardFill;
            pnlsys.BackColor = CardFill;
            pnlsys.BorderStyle = BorderStyle.None;
            panel1.BackColor = CardFill;
            panel1.BorderStyle = BorderStyle.None;
            cardAlarm.Paint += (_, e) => PaintAlarmCard(e.Graphics, cardAlarm);
            pnlsys.Paint += (_, e) => PaintHealthCard(e.Graphics, pnlsys);
            panel1.Paint += (_, e) => PaintFooter(e.Graphics, panel1);

            pictureBox1.Visible = false;
            panel2.Visible = false;
            panel4.Visible = false;
            lbl95.Visible = false;
            progressBar1.Visible = false;
            progressBar2.Visible = false;
            progressBar3.Visible = false;
            pnl7.Visible = false;
            pnl9.Visible = false;

            lblpower.Text = "Power Reserve";
            lbl66.Text = "System integrity";
            lblnet.Text = "Network strength";
            lblsecurity.Text = "System Health Overview";
            chkAutoSim.FlatStyle = FlatStyle.Flat;
            chkAutoSim.ForeColor = MutedText;
            chkAutoSim.BackColor = CardFill;

            ArrangeSecurity();
        }

        private void StyleTitle()
        {
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.BackColor = PageBack;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = MutedText;
            lblSubtitle.BackColor = PageBack;
            EnableOwnerDraw(lblPageIcon);
            lblPageIcon.Text = string.Empty;
            lblPageIcon.Paint += (_, e) => PaintPageBadge(e.Graphics, lblPageIcon);
        }

        private void ArrangeSecurity()
        {
            if (!chromeReady)
                return;

            int w = ClientSize.Width;
            int h = ClientSize.Height;
            if (w < 200 || h < 200)
                return;

            const int pad = 16;
            const int gap = 12;
            const int headerH = 76;
            const int footerH = 56;

            lblPageIcon.SetBounds(pad, 14, 48, 48);
            lblTitle.SetBounds(pad + 56, 8, 360, 40);
            lblSubtitle.SetBounds(pad + 56, 46, 420, 22);

            int statW = Math.Min(188, Math.Max(150, (w - 520) / 3));
            int statH = 64;
            int statRight = w - pad;
            PlaceStat(cardStatEvents, lblStatEvents, lblStatEventsCaption, statRight - statW, 10, statW, statH);
            PlaceStat(cardStatZones, lblStatZones, lblStatZonesCaption, statRight - statW * 2 - gap, 10, statW, statH);
            PlaceStat(cardStatAlarm, lblStatAlarm, lblStatAlarmCaption, statRight - statW * 3 - gap * 2, 10, statW, statH);

            int bodyTop = headerH + 8;
            int bodyH = h - bodyTop - footerH - pad - 8;
            int bottomH = Math.Max(268, (int)(bodyH * 0.46));
            int zoneH = bodyH - bottomH - gap;
            if (zoneH < 286)
            {
                zoneH = 286;
                bottomH = Math.Max(240, bodyH - zoneH - gap);
            }

            int cardW = (w - pad * 2 - gap * 3) / 4;
            int rowY = bodyTop;
            PlaceZone(ZoneOf("living"), pad, rowY, cardW, zoneH);
            PlaceZone(ZoneOf("bathroom"), pad + (cardW + gap), rowY, cardW, zoneH);
            PlaceZone(ZoneOf("bedroom"), pad + (cardW + gap) * 2, rowY, cardW, zoneH);
            PlaceZone(ZoneOf("kitchen"), pad + (cardW + gap) * 3, rowY, cardW, zoneH);

            int bottomY = rowY + zoneH + gap;
            PlaceZone(ZoneOf("garage"), pad, bottomY, cardW, bottomH);

            int healthX = pad + cardW + gap;
            int healthW = cardW * 2 + gap;
            pnlsys.SetBounds(healthX, bottomY, healthW, bottomH);
            SetRoundedRegion(pnlsys, 20);
            PlaceHealth(healthW, bottomH);

            int alarmX = healthX + healthW + gap;
            int alarmW = w - pad - alarmX;
            cardAlarm.SetBounds(alarmX, bottomY, alarmW, bottomH);
            SetRoundedRegion(cardAlarm, 20);
            PlaceAlarm(alarmW, bottomH);

            panel1.SetBounds(pad, h - pad - footerH, w - pad * 2, footerH);
            SetRoundedRegion(panel1, 18);
            PlaceFooter(panel1.Width);

            RebuildAllWaves();
        }

        private void RebuildAllWaves()
        {
            RebuildWave(pnlLivingBanner, lblLivingOnline);
            RebuildWave(pnlBathroomBanner, lblBathroomOnline);
            RebuildWave(pnlBedroomBanner, lblBedroomOnline);
            RebuildWave(pnlKitchenBanner, lblKitchenOnline);
            RebuildWave(pnlGarageBanner, lblGarageOnline);
        }

        private ZoneUi ZoneOf(string key)
        {
            return key switch
            {
                "bathroom" => new ZoneUi(zoneBathroom, pnlBathroomBanner, lblBathroomOnline, lblBathroomName, lblBathroomStatus, lblBathroomSubtitle, pnlBathroomInfo, lblBathroomCameras, lblBathroomSensors, lblBathroomQuick, btnBathroomMotion, btnBathroomDoor, btnBathroomCamera, btnBathroomReset),
                "bedroom" => new ZoneUi(zoneBedroom, pnlBedroomBanner, lblBedroomOnline, lblBedroomName, lblBedroomStatus, lblBedroomSubtitle, pnlBedroomInfo, lblBedroomCameras, lblBedroomSensors, lblBedroomQuick, btnBedroomMotion, btnBedroomDoor, btnBedroomCamera, btnBedroomReset),
                "kitchen" => new ZoneUi(zoneKitchen, pnlKitchenBanner, lblKitchenOnline, lblKitchenName, lblKitchenStatus, lblKitchenSubtitle, pnlKitchenInfo, lblKitchenCameras, lblKitchenSensors, lblKitchenQuick, btnKitchenMotion, btnKitchenDoor, btnKitchenCamera, btnKitchenReset),
                "garage" => new ZoneUi(zoneGarage, pnlGarageBanner, lblGarageOnline, lblGarageName, lblGarageStatus, lblGarageSubtitle, pnlGarageInfo, lblGarageCameras, lblGarageSensors, lblGarageQuick, btnGarageMotion, btnGarageDoor, btnGarageCamera, btnGarageReset),
                _ => new ZoneUi(zoneLiving, pnlLivingBanner, lblLivingOnline, lblLivingName, lblLivingStatus, lblLivingSubtitle, pnlLivingInfo, lblLivingCameras, lblLivingSensors, lblLivingQuick, btnLivingMotion, btnLivingDoor, btnLivingCamera, btnLivingReset)
            };
        }

        private void PlaceZone(ZoneUi zone, int x, int y, int width, int height)
        {
            zone.Card.SetBounds(x, y, width, height);
            SetRoundedRegion(zone.Card, 20);

            int bannerH = Math.Clamp((int)(height * 0.27), 62, 96);
            zone.Banner.SetBounds(10, 10, Math.Max(40, width - 20), bannerH);
            SetRoundedRegion(zone.Banner, 16);
            zone.Online.SetBounds(12, 10, 110, 22);
            zone.Online.BackColor = Color.Transparent;
            zone.Online.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            int yName = bannerH + 16;
            zone.Name.SetBounds(14, yName, Math.Max(80, width - 124), 26);
            zone.Name.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            zone.Name.ForeColor = Color.White;
            zone.Name.BackColor = Color.Transparent;
            zone.Status.SetBounds(width - 104, yName, 88, 26);
            zone.Status.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            zone.Subtitle.SetBounds(14, yName + 28, width - 28, 18);
            zone.Subtitle.Font = new Font("Segoe UI", 8.5F);
            zone.Subtitle.ForeColor = MutedText;
            zone.Subtitle.BackColor = Color.Transparent;

            int yInfo = yName + 52;
            zone.Info.SetBounds(14, yInfo, width - 28, 28);
            int mid = zone.Info.Width / 2;
            zone.Cameras.SetBounds(26, 4, Math.Max(40, mid - 34), 20);
            zone.Sensors.SetBounds(mid + 28, 4, Math.Max(40, mid - 36), 20);
            zone.Cameras.ForeColor = MutedText;
            zone.Sensors.ForeColor = MutedText;
            zone.Cameras.BackColor = Color.Transparent;
            zone.Sensors.BackColor = Color.Transparent;
            zone.Cameras.Font = new Font("Segoe UI", 8.5F);
            zone.Sensors.Font = new Font("Segoe UI", 8.5F);

            int btnH = Math.Clamp(height - (yInfo + 78), 50, 64);
            int btnY = height - btnH - 12;
            zone.Quick.SetBounds(14, Math.Min(yInfo + 32, btnY - 24), 160, 20);
            zone.Quick.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            zone.Quick.ForeColor = Color.White;
            zone.Quick.BackColor = Color.Transparent;

            int btnW = Math.Max(48, (width - 28 - 18) / 4);
            int step = btnW + 6;
            zone.Motion.SetBounds(14, btnY, btnW, btnH);
            zone.Door.SetBounds(14 + step, btnY, btnW, btnH);
            zone.Camera.SetBounds(14 + step * 2, btnY, btnW, btnH);
            zone.Reset.SetBounds(14 + step * 3, btnY, btnW, btnH);
        }

        private static void PlaceStat(Panel card, Label value, Label caption, int x, int y, int width, int height)
        {
            card.SetBounds(x, y, width, height);
            SetRoundedRegion(card, 16);
            value.SetBounds(46, 6, width - 54, 28);
            value.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            value.BackColor = Color.Transparent;
            value.ForeColor = Color.White;
            caption.SetBounds(46, 34, width - 54, 20);
            caption.Font = new Font("Segoe UI", 8.5F);
            caption.ForeColor = MutedText;
            caption.BackColor = Color.Transparent;
        }

        private void PlaceHealth(int width, int height)
        {
            lblsecurity.SetBounds(48, 16, width - 64, 30);
            lblsecurity.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblsecurity.ForeColor = Color.White;
            lblsecurity.BackColor = Color.Transparent;

            int top = 68;
            int usable = height - top - 72;
            int step = Math.Max(48, usable / 3);
            PlaceHealthLabel(lbl66, top, width);
            PlaceHealthLabel(lblpower, top + step, width);
            PlaceHealthLabel(lblnet, top + step * 2, width);

            btnsystem.SetBounds(Math.Max(16, (width - 240) / 2), height - 58, 240, 42);
            btnsystem.Text = "System Diagnostics";
        }

        private static void PlaceHealthLabel(Label label, int y, int width)
        {
            label.SetBounds(48, y, Math.Min(170, width / 3), 24);
            label.Font = new Font("Segoe UI", 9.5F);
            label.ForeColor = Color.FromArgb(230, 226, 245);
            label.BackColor = Color.Transparent;
        }

        private void PlaceAlarm(int width, int height)
        {
            lblAlarmCaption.SetBounds(46, 16, width - 62, 24);
            lblAlarmCaption.Font = new Font("Segoe UI", 10F);
            lblAlarmCaption.ForeColor = MutedText;
            lblAlarmCaption.BackColor = Color.Transparent;
            lblAlarmState.SetBounds(68, 52, width - 86, 48);
            lblAlarmState.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblAlarmState.BackColor = Color.Transparent;
            lblAlarmHint.SetBounds(18, 112, width - 36, 52);
            lblAlarmHint.Font = new Font("Segoe UI", 9F);
            lblAlarmHint.ForeColor = MutedText;
            lblAlarmHint.BackColor = Color.Transparent;

            int btnW = Math.Max(80, (width - 42) / 2);
            int btnY = height - 98;
            btnArm.SetBounds(16, btnY, btnW, 44);
            btnDisarm.SetBounds(26 + btnW, btnY, btnW, 44);
            btnArm.Text = "Arm";
            btnDisarm.Text = "Disarm";
            chkAutoSim.SetBounds(16, height - 42, width - 32, 26);
        }

        private void PlaceFooter(int width)
        {
            lbl88.SetBounds(46, 15, 250, 26);
            lbl88.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbl88.ForeColor = Color.White;
            lbl88.BackColor = Color.Transparent;
            lbl88.Text = "Daily Security Overview";
            lbldaily.SetBounds(Math.Min(360, width / 3 + 40), 16, 190, 24);
            lbldaily.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lbldaily.ForeColor = Color.White;
            lbldaily.BackColor = Color.Transparent;
            lbldaily.Text = "Total Events Today";
            lbl58.SetBounds(lbldaily.Right + 6, 10, 80, 32);
            lbl58.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lbl58.BackColor = Color.Transparent;
            lbl58.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void WireZone(Panel panel)
        {
            Tune(panel);
            panel.BackColor = CardFill;
            panel.Paint += (_, e) => DrawCardBorder(e.Graphics, panel, 20);
        }

        private static void WireBanner(Panel banner)
        {
            Tune(banner);
            banner.BackColor = Color.FromArgb(98, 58, 198);
        }

        private void WireStat(Panel card)
        {
            Tune(card);
            card.BackColor = CardFill;
            card.Paint += (_, e) =>
            {
                DrawCardBorder(e.Graphics, card, 16);
                var icon = new Rectangle(14, 16, 24, 26);
                if (card == cardStatAlarm)
                    DrawShield(e.Graphics, icon, Green);
                else if (card == cardStatZones)
                    DrawGrid(e.Graphics, icon, Color.FromArgb(196, 168, 255));
                else
                    DrawCalendar(e.Graphics, icon, Color.FromArgb(196, 168, 255));
            };
        }

        private void WireStatus(Label label)
        {
            EnableOwnerDraw(label);
            label.Paint += (_, e) => PaintStatusPill(e.Graphics, label);
            label.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void WireInfo(Panel panel)
        {
            Tune(panel);
            panel.BackColor = Color.Transparent;
            panel.Paint += (_, e) => PaintInfoRow(e.Graphics, panel);
        }

        private void WireButton(Button button)
        {
            EnableOwnerDraw(button);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.ForeColor = Color.White;
            button.Paint += (_, e) => PaintActionButton(e.Graphics, button);
            button.MouseEnter += (_, _) => { hoveredButtons.Add(button); button.Invalidate(); };
            button.MouseLeave += (_, _) => { hoveredButtons.Remove(button); button.Invalidate(); };
        }

        private static void HideGlyph(Label label)
        {
            label.Visible = false;
        }

        private void RebuildWave(Panel banner, Label online)
        {
            if (banner.Width < 8 || banner.Height < 8)
                return;
            Image image = CreateWaveBitmap(banner.Width, banner.Height, online.Text, online.ForeColor);
            Image? previous = banner.BackgroundImage;
            banner.BackgroundImage = image;
            previous?.Dispose();
        }

        private static Bitmap CreateWaveBitmap(int width, int height, string onlineText, Color onlineColor)
        {
            Bitmap bitmap = new Bitmap(width, height);
            using Graphics graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle bounds = new Rectangle(0, 0, width, height);
            using (LinearGradientBrush brush = new LinearGradientBrush(bounds,
                       Color.FromArgb(86, 46, 186),
                       Color.FromArgb(138, 72, 224),
                       LinearGradientMode.ForwardDiagonal))
                graphics.FillRectangle(brush, bounds);

            using (LinearGradientBrush sheen = new LinearGradientBrush(new Rectangle(0, 0, width, height / 2),
                       Color.FromArgb(70, 255, 255, 255),
                       Color.FromArgb(0, 255, 255, 255),
                       LinearGradientMode.Vertical))
                graphics.FillRectangle(sheen, 0, 0, width, height / 2);

            FillWave(graphics, width, height, 0.58f, 0.16f, 22f, Color.FromArgb(55, 255, 255, 255));
            FillWave(graphics, width, height, 0.72f, 0.10f, 34f, Color.FromArgb(40, 210, 180, 255));
            DrawHouse(graphics, new Rectangle(width - 50, 14, 30, 26), Color.FromArgb(226, 214, 255));
            using Font onlineFont = new Font("Segoe UI", 9F, FontStyle.Bold);
            TextRenderer.DrawText(graphics, onlineText, onlineFont, new Rectangle(12, 8, width - 70, 22), onlineColor,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
            return bitmap;
        }

        private static void FillWave(Graphics graphics, int width, int height, float baseline, float amplitude, float length, Color color)
        {
            PointF[] points = new PointF[width / 3 + 3];
            int index = 0;
            for (int x = 0; x <= width; x += 3)
            {
                float y = height * baseline + (float)Math.Sin(x / length) * (height * amplitude);
                points[index++] = new PointF(x, y);
            }
            points[index++] = new PointF(width, height);
            points[index++] = new PointF(0, height);
            using SolidBrush brush = new SolidBrush(color);
            graphics.FillPolygon(brush, points.Take(index).ToArray());
        }

        private void PaintPageBadge(Graphics graphics, Control box)
        {
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.Clear(PageBack);
            Rectangle disc = new Rectangle(2, 2, 40, 40);
            using (LinearGradientBrush brush = new LinearGradientBrush(disc, Color.FromArgb(124, 77, 255), Color.FromArgb(176, 96, 250), 50f))
                graphics.FillEllipse(brush, disc);
            DrawShield(graphics, new Rectangle(12, 11, 20, 22), Color.White);
        }

        private static void PaintStatusPill(Graphics graphics, Label label)
        {
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.Clear(CardFill);
            bool secure = label.Text == "Secure";
            Color ink = secure ? Green : Color.FromArgb(255, 186, 92);
            Color wash = secure ? Color.FromArgb(46, 52, 211, 153) : Color.FromArgb(50, 255, 186, 92);
            Rectangle rect = new Rectangle(0, 1, Math.Max(8, label.Width - 2), Math.Max(8, label.Height - 3));
            using GraphicsPath path = RoundedRect(rect, 11);
            using (SolidBrush brush = new SolidBrush(wash))
                graphics.FillPath(brush, path);
            using (Pen pen = new Pen(Color.FromArgb(140, ink), 1f))
                graphics.DrawPath(pen, path);
            TextRenderer.DrawText(graphics, label.Text, label.Font, rect, ink,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
        }

        private static void PaintInfoRow(Graphics graphics, Panel panel)
        {
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Color ink = Color.FromArgb(186, 178, 214);
            DrawCamera(graphics, new Rectangle(4, 6, 16, 16), ink);
            int mid = panel.Width / 2;
            using Pen pen = new Pen(Color.FromArgb(90, 186, 178, 214), 1f);
            graphics.DrawLine(pen, mid, 5, mid, panel.Height - 5);
            DrawWifi(graphics, new Rectangle(mid + 8, 5, 16, 16), ink);
        }

        private void PaintActionButton(Graphics graphics, Button button)
        {
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.Clear(CardFill);
            bool hover = hoveredButtons.Contains(button);
            bool diagnostic = button == btnsystem;
            bool disarm = button == btnDisarm;
            bool arm = button == btnArm;
            bool accent = !diagnostic && !disarm && !arm && button.BackColor.ToArgb() == Purple.ToArgb();
            bool alert = !diagnostic && !disarm && !arm && button.BackColor.ToArgb() == Color.FromArgb(150, 92, 20).ToArgb();
            Color fill = diagnostic || disarm
                ? CardFill
                : accent || arm
                    ? (hover ? Color.FromArgb(142, 96, 255) : Purple)
                    : alert
                        ? (hover ? Color.FromArgb(186, 122, 42) : Color.FromArgb(150, 92, 20))
                        : (hover ? Color.FromArgb(64, 52, 128) : ButtonIdle);
            Rectangle rect = new Rectangle(1, 1, Math.Max(4, button.Width - 3), Math.Max(4, button.Height - 3));
            using GraphicsPath path = RoundedRect(rect, 12);
            using (SolidBrush brush = new SolidBrush(fill))
                graphics.FillPath(brush, path);
            if (diagnostic)
            {
                using Pen pen = new Pen(Green, 1.6f);
                graphics.DrawPath(pen, path);
            }
            else if (disarm)
            {
                using Pen pen = new Pen(Color.FromArgb(150, 130, 196), 1.3f);
                graphics.DrawPath(pen, path);
            }

            Color ink = diagnostic ? Green : Color.White;
            string[] lines = button.Text.Replace("\r", string.Empty).Split('\n');
            bool stacked = !arm && !disarm && !diagnostic && lines.Length > 1;
            if (stacked)
            {
                Rectangle icon = new Rectangle(rect.X + (rect.Width - 16) / 2, rect.Y + 6, 16, 16);
                DrawButtonIcon(graphics, button, icon, ink);
                Rectangle text = new Rectangle(2, 24, button.Width - 4, button.Height - 26);
                using Font stackedFont = new Font("Segoe UI", 7.5F);
                TextRenderer.DrawText(graphics, lines[0] + "\n" + lines[1], stackedFont, text, ink,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.Top | TextFormatFlags.WordBreak);
            }
            else
            {
                Rectangle icon = new Rectangle(rect.X + 16, rect.Y + (rect.Height - 16) / 2, 16, 16);
                DrawButtonIcon(graphics, button, icon, ink);
                Rectangle text = new Rectangle(icon.Right + 6, rect.Y, rect.Width - 40, rect.Height);
                using Font wideFont = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                TextRenderer.DrawText(graphics, button.Text.Trim(), wideFont, text, ink,
                    TextFormatFlags.VerticalCenter | TextFormatFlags.Left | TextFormatFlags.EndEllipsis);
            }
        }

        private void DrawButtonIcon(Graphics graphics, Button button, Rectangle icon, Color color)
        {
            if (button.Name.Contains("Motion"))
                DrawWalker(graphics, icon, color);
            else if (button.Name.Contains("Door") || button == btnDisarm || button == btnArm)
                DrawDoor(graphics, icon, color);
            else if (button.Name.Contains("Camera"))
                DrawCamera(graphics, icon, color);
            else if (button == btnsystem)
                DrawGear(graphics, icon, color);
            else
                DrawSliders(graphics, icon, color);
        }

        private void PaintAlarmCard(Graphics graphics, Panel panel)
        {
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            DrawCardBorder(graphics, panel, 20);
            DrawBell(graphics, new Rectangle(16, 16, 20, 20), Color.FromArgb(196, 168, 255));
            Color state = lblAlarmState.ForeColor;
            DrawShield(graphics, new Rectangle(16, 58, 40, 42), state);
        }

        private void PaintHealthCard(Graphics graphics, Panel panel)
        {
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            DrawCardBorder(graphics, panel, 20);
            DrawPulse(graphics, new Rectangle(16, 18, 22, 18), Color.FromArgb(196, 168, 255));
            PaintHealthRow(graphics, panel, lbl66, HealthIntegrity, "integrity");
            PaintHealthRow(graphics, panel, lblpower, HealthPower, "power");
            PaintHealthRow(graphics, panel, lblnet, HealthNetwork, "network");
        }

        private static void PaintHealthRow(Graphics graphics, Panel panel, Label label, float amount, string kind)
        {
            Rectangle bubble = new Rectangle(16, label.Top - 2, 24, 24);
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(52, 40, 104)))
                graphics.FillEllipse(brush, bubble);
            Rectangle glyph = new Rectangle(bubble.X + 4, bubble.Y + 4, 16, 16);
            Color ink = Color.FromArgb(214, 206, 245);
            if (kind == "power")
                DrawBolt(graphics, glyph, ink);
            else if (kind == "network")
                DrawWifi(graphics, glyph, ink);
            else
                DrawPulse(graphics, glyph, ink);

            int barX = Math.Max(label.Right + 12, 200);
            int barW = panel.Width - barX - 62;
            if (barW < 40)
                return;
            Rectangle bar = new Rectangle(barX, label.Top + 6, barW, 12);
            DrawGradientBar(graphics, bar, amount);
            using Font percentFont = new Font("Segoe UI", 9F, FontStyle.Bold);
            TextRenderer.DrawText(graphics, ((int)Math.Round(amount * 100)).ToString() + "%",
                percentFont,
                new Rectangle(bar.Right + 8, label.Top, 48, 24),
                Color.FromArgb(236, 240, 248),
                TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
        }

        private static void PaintFooter(Graphics graphics, Panel panel)
        {
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            DrawCardBorder(graphics, panel, 18);
            DrawCalendar(graphics, new Rectangle(16, 16, 20, 20), Color.FromArgb(196, 168, 255));
            int split = Math.Min(330, panel.Width / 3);
            using Pen pen = new Pen(Color.FromArgb(120, 118, 84, 196), 1.2f);
            graphics.DrawLine(pen, split, 14, split, panel.Height - 14);
        }

        private static void DrawCardBorder(Graphics graphics, Control control, int radius)
        {
            if (control.Width < 4 || control.Height < 4)
                return;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = new Rectangle(1, 1, control.Width - 3, control.Height - 3);
            using GraphicsPath path = RoundedRect(rect, radius);
            using Pen pen = new Pen(CardBorder, 1.4f);
            graphics.DrawPath(pen, path);
        }

        private static void DrawGradientBar(Graphics graphics, Rectangle bar, float amount)
        {
            using GraphicsPath track = RoundedRect(bar, bar.Height);
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(46, 38, 92)))
                graphics.FillPath(brush, track);
            int fillWidth = Math.Max(bar.Height, (int)(bar.Width * Math.Clamp(amount, 0f, 1f)));
            Rectangle fill = new Rectangle(bar.X, bar.Y, Math.Min(bar.Width, fillWidth), bar.Height);
            using GraphicsPath fillPath = RoundedRect(fill, bar.Height);
            using LinearGradientBrush gradient = new LinearGradientBrush(fill,
                Color.FromArgb(170, 255, 196),
                Color.FromArgb(16, 185, 110),
                LinearGradientMode.Horizontal);
            graphics.SetClip(track);
            graphics.FillPath(gradient, fillPath);
            graphics.ResetClip();
        }

        private static void DrawShield(Graphics graphics, Rectangle rect, Color color)
        {
            Point[] shape =
            {
                new(rect.X + rect.Width / 2, rect.Y),
                new(rect.Right - 1, rect.Y + rect.Height / 4),
                new(rect.Right - 2, rect.Y + rect.Height * 2 / 3),
                new(rect.X + rect.Width / 2, rect.Bottom - 1),
                new(rect.X + 2, rect.Y + rect.Height * 2 / 3),
                new(rect.X + 1, rect.Y + rect.Height / 4)
            };
            using Pen pen = new Pen(color, 1.7f) { LineJoin = LineJoin.Round };
            graphics.DrawPolygon(pen, shape);
            graphics.DrawLines(pen, new[]
            {
                new Point(rect.X + rect.Width / 3, rect.Y + rect.Height / 2),
                new Point(rect.X + rect.Width / 2 - 1, rect.Y + rect.Height * 5 / 8),
                new Point(rect.Right - rect.Width / 3, rect.Y + rect.Height / 3)
            });
        }

        private static void DrawHouse(Graphics graphics, Rectangle rect, Color color)
        {
            using Pen pen = new Pen(color, 1.7f) { LineJoin = LineJoin.Round };
            graphics.DrawLines(pen, new[]
            {
                new Point(rect.X + rect.Width / 2, rect.Y),
                new Point(rect.Right, rect.Y + rect.Height / 2),
                new Point(rect.Right - 3, rect.Y + rect.Height / 2),
                new Point(rect.Right - 3, rect.Bottom),
                new Point(rect.X + 3, rect.Bottom),
                new Point(rect.X + 3, rect.Y + rect.Height / 2),
                new Point(rect.X, rect.Y + rect.Height / 2),
                new Point(rect.X + rect.Width / 2, rect.Y)
            });
        }

        private static void DrawGrid(Graphics graphics, Rectangle rect, Color color)
        {
            using Pen pen = new Pen(color, 1.6f);
            int cell = rect.Width / 2 - 2;
            graphics.DrawRectangle(pen, rect.X + 1, rect.Y + 1, cell, cell);
            graphics.DrawRectangle(pen, rect.X + cell + 4, rect.Y + 1, cell, cell);
            graphics.DrawRectangle(pen, rect.X + 1, rect.Y + cell + 4, cell, cell);
            graphics.DrawRectangle(pen, rect.X + cell + 4, rect.Y + cell + 4, cell, cell);
        }

        private static void DrawCalendar(Graphics graphics, Rectangle rect, Color color)
        {
            using Pen pen = new Pen(color, 1.6f);
            graphics.DrawRectangle(pen, rect.X + 1, rect.Y + 4, rect.Width - 3, rect.Height - 6);
            graphics.DrawLine(pen, rect.X + 1, rect.Y + 9, rect.Right - 2, rect.Y + 9);
            graphics.DrawLine(pen, rect.X + 6, rect.Y + 1, rect.X + 6, rect.Y + 7);
            graphics.DrawLine(pen, rect.Right - 7, rect.Y + 1, rect.Right - 7, rect.Y + 7);
        }

        private static void DrawCamera(Graphics graphics, Rectangle rect, Color color)
        {
            using Pen pen = new Pen(color, 1.5f);
            graphics.DrawRectangle(pen, rect.X + 1, rect.Y + 4, rect.Width - 6, rect.Height - 8);
            graphics.DrawEllipse(pen, rect.X + rect.Width / 2 - 5, rect.Y + rect.Height / 2 - 4, 8, 8);
            graphics.DrawLine(pen, rect.Right - 5, rect.Y + 6, rect.Right - 1, rect.Y + 3);
            graphics.DrawLine(pen, rect.Right - 5, rect.Bottom - 6, rect.Right - 1, rect.Bottom - 3);
        }

        private static void DrawWifi(Graphics graphics, Rectangle rect, Color color)
        {
            using Pen pen = new Pen(color, 1.5f);
            using SolidBrush dot = new SolidBrush(color);
            graphics.FillEllipse(dot, rect.X + rect.Width / 2 - 1, rect.Bottom - 4, 3, 3);
            graphics.DrawArc(pen, rect.X + 3, rect.Y + 8, rect.Width - 6, rect.Height - 8, 200, 140);
            graphics.DrawArc(pen, rect.X, rect.Y + 3, rect.Width, rect.Height - 4, 200, 140);
        }

        private static void DrawWalker(Graphics graphics, Rectangle rect, Color color)
        {
            using Pen pen = new Pen(color, 1.5f) { StartCap = LineCap.Round, EndCap = LineCap.Round };
            graphics.DrawEllipse(pen, rect.X + 6, rect.Y, 6, 6);
            graphics.DrawLine(pen, rect.X + 9, rect.Y + 6, rect.X + 8, rect.Y + 12);
            graphics.DrawLine(pen, rect.X + 8, rect.Y + 8, rect.X + 3, rect.Y + 11);
            graphics.DrawLine(pen, rect.X + 8, rect.Y + 8, rect.X + 13, rect.Y + 10);
            graphics.DrawLine(pen, rect.X + 8, rect.Y + 12, rect.X + 4, rect.Bottom - 1);
            graphics.DrawLine(pen, rect.X + 8, rect.Y + 12, rect.X + 13, rect.Bottom - 1);
        }

        private static void DrawDoor(Graphics graphics, Rectangle rect, Color color)
        {
            using Pen pen = new Pen(color, 1.6f);
            graphics.DrawRectangle(pen, rect.X + 3, rect.Y + 1, rect.Width - 8, rect.Height - 3);
            using SolidBrush knob = new SolidBrush(color);
            graphics.FillEllipse(knob, rect.Right - 8, rect.Y + rect.Height / 2, 3, 3);
        }

        private static void DrawSliders(Graphics graphics, Rectangle rect, Color color)
        {
            using Pen pen = new Pen(color, 1.5f);
            graphics.DrawLine(pen, rect.X + 1, rect.Y + 3, rect.Right - 1, rect.Y + 3);
            graphics.DrawLine(pen, rect.X + 1, rect.Y + 8, rect.Right - 1, rect.Y + 8);
            graphics.DrawLine(pen, rect.X + 1, rect.Y + 13, rect.Right - 1, rect.Y + 13);
            using SolidBrush brush = new SolidBrush(color);
            graphics.FillEllipse(brush, rect.X + 3, rect.Y + 1, 4, 4);
            graphics.FillEllipse(brush, rect.X + 9, rect.Y + 6, 4, 4);
            graphics.FillEllipse(brush, rect.X + 5, rect.Y + 11, 4, 4);
        }

        private static void DrawBell(Graphics graphics, Rectangle rect, Color color)
        {
            using Pen pen = new Pen(color, 1.6f);
            graphics.DrawArc(pen, rect.X + 3, rect.Y + 2, rect.Width - 6, rect.Height - 6, 200, 140);
            graphics.DrawLine(pen, rect.X + 3, rect.Bottom - 5, rect.Right - 3, rect.Bottom - 5);
            graphics.DrawArc(pen, rect.X + rect.Width / 2 - 3, rect.Bottom - 7, 6, 5, 0, 180);
        }

        private static void DrawPulse(Graphics graphics, Rectangle rect, Color color)
        {
            using Pen pen = new Pen(color, 1.6f) { LineJoin = LineJoin.Round };
            graphics.DrawLines(pen, new[]
            {
                new Point(rect.X, rect.Y + rect.Height / 2),
                new Point(rect.X + rect.Width / 4, rect.Y + rect.Height / 2),
                new Point(rect.X + rect.Width / 3, rect.Y + 2),
                new Point(rect.X + rect.Width / 2, rect.Bottom - 2),
                new Point(rect.X + rect.Width * 2 / 3, rect.Y + rect.Height / 2),
                new Point(rect.Right, rect.Y + rect.Height / 2)
            });
        }

        private static void DrawBolt(Graphics graphics, Rectangle rect, Color color)
        {
            Point[] bolt =
            {
                new(rect.X + rect.Width / 2, rect.Y),
                new(rect.X + 2, rect.Y + rect.Height / 2),
                new(rect.X + rect.Width / 2, rect.Y + rect.Height / 2),
                new(rect.X + rect.Width / 3, rect.Bottom),
                new(rect.Right - 2, rect.Y + rect.Height / 2 - 1),
                new(rect.X + rect.Width / 2, rect.Y + rect.Height / 2 - 1)
            };
            using SolidBrush brush = new SolidBrush(color);
            graphics.FillPolygon(brush, bolt);
        }

        private static void DrawGear(Graphics graphics, Rectangle rect, Color color)
        {
            using Pen pen = new Pen(color, 1.6f);
            graphics.DrawEllipse(pen, rect.X + 4, rect.Y + 4, rect.Width - 8, rect.Height - 8);
            graphics.DrawEllipse(pen, rect.X + 6, rect.Y + 6, rect.Width - 12, rect.Height - 12);
            graphics.DrawLine(pen, rect.X + rect.Width / 2, rect.Y, rect.X + rect.Width / 2, rect.Y + 4);
            graphics.DrawLine(pen, rect.X + rect.Width / 2, rect.Bottom - 4, rect.X + rect.Width / 2, rect.Bottom);
            graphics.DrawLine(pen, rect.X, rect.Y + rect.Height / 2, rect.X + 4, rect.Y + rect.Height / 2);
            graphics.DrawLine(pen, rect.Right - 4, rect.Y + rect.Height / 2, rect.Right, rect.Y + rect.Height / 2);
        }

        private static void SetRoundedRegion(Control control, int radius)
        {
            if (control.Width <= 1 || control.Height <= 1)
                return;
            using GraphicsPath path = RoundedRect(new Rectangle(0, 0, control.Width, control.Height), radius);
            Region? previous = control.Region;
            control.Region = new Region(path);
            previous?.Dispose();
        }

        private static GraphicsPath RoundedRect(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = Math.Min(Math.Max(radius, 1) * 2, Math.Min(rect.Width, rect.Height));
            if (diameter < 2)
            {
                path.AddRectangle(rect);
                return path;
            }

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }

        private static void Tune(Control control)
        {
            typeof(Control).InvokeMember(
                "DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.SetProperty,
                null,
                control,
                new object[] { true });
        }

        private static void EnableOwnerDraw(Control control)
        {
            MethodInfo? setStyle = typeof(Control).GetMethod("SetStyle", BindingFlags.Instance | BindingFlags.NonPublic);
            setStyle?.Invoke(control, new object[]
            {
                ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw,
                true
            });
            typeof(Control).GetMethod("UpdateStyles", BindingFlags.Instance | BindingFlags.NonPublic)?.Invoke(control, null);
        }

        private readonly struct ZoneUi
        {
            public ZoneUi(Panel card, Panel banner, Label online, Label name, Label status, Label subtitle, Panel info, Label cameras, Label sensors, Label quick, Button motion, Button door, Button camera, Button reset)
            {
                Card = card;
                Banner = banner;
                Online = online;
                Name = name;
                Status = status;
                Subtitle = subtitle;
                Info = info;
                Cameras = cameras;
                Sensors = sensors;
                Quick = quick;
                Motion = motion;
                Door = door;
                Camera = camera;
                Reset = reset;
            }

            public Panel Card { get; }
            public Panel Banner { get; }
            public Label Online { get; }
            public Label Name { get; }
            public Label Status { get; }
            public Label Subtitle { get; }
            public Panel Info { get; }
            public Label Cameras { get; }
            public Label Sensors { get; }
            public Label Quick { get; }
            public Button Motion { get; }
            public Button Door { get; }
            public Button Camera { get; }
            public Button Reset { get; }
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
