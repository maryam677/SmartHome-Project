namespace WinFormsApp2.UserControls
{
    partial class SecurityUserControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                DetachSecurityEvents();
                components?.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tmrAuto = new System.Windows.Forms.Timer(components);
            tmrUi = new System.Windows.Forms.Timer(components);
            lblPageIcon = new Label();
            lblTitle = new Label();
            lblSubtitle = new Label();
            cardStatAlarm = new Panel();
            lblStatAlarm = new Label();
            lblStatAlarmCaption = new Label();
            cardStatZones = new Panel();
            lblStatZones = new Label();
            lblStatZonesCaption = new Label();
            cardStatEvents = new Panel();
            lblStatEvents = new Label();
            lblStatEventsCaption = new Label();
            zoneLiving = new Panel();
            pnlLivingBanner = new Panel();
            lblLivingHome = new Label();
            lblLivingOnline = new Label();
            lblLivingName = new Label();
            lblLivingStatus = new Label();
            lblLivingSubtitle = new Label();
            pnlLivingInfo = new Panel();
            lblLivingCameras = new Label();
            lblLivingSensors = new Label();
            lblLivingQuick = new Label();
            btnLivingMotion = new Button();
            btnLivingDoor = new Button();
            btnLivingCamera = new Button();
            btnLivingReset = new Button();
            zoneBedroom = new Panel();
            pnlBedroomBanner = new Panel();
            lblBedroomHome = new Label();
            lblBedroomOnline = new Label();
            lblBedroomName = new Label();
            lblBedroomStatus = new Label();
            lblBedroomSubtitle = new Label();
            pnlBedroomInfo = new Panel();
            lblBedroomCameras = new Label();
            lblBedroomSensors = new Label();
            lblBedroomQuick = new Label();
            btnBedroomMotion = new Button();
            btnBedroomDoor = new Button();
            btnBedroomCamera = new Button();
            btnBedroomReset = new Button();
            zoneKitchen = new Panel();
            pnlKitchenBanner = new Panel();
            lblKitchenHome = new Label();
            lblKitchenOnline = new Label();
            lblKitchenName = new Label();
            lblKitchenStatus = new Label();
            lblKitchenSubtitle = new Label();
            pnlKitchenInfo = new Panel();
            lblKitchenCameras = new Label();
            lblKitchenSensors = new Label();
            lblKitchenQuick = new Label();
            btnKitchenMotion = new Button();
            btnKitchenDoor = new Button();
            btnKitchenCamera = new Button();
            btnKitchenReset = new Button();
            zoneBathroom = new Panel();
            pnlBathroomBanner = new Panel();
            lblBathroomHome = new Label();
            lblBathroomOnline = new Label();
            lblBathroomName = new Label();
            lblBathroomStatus = new Label();
            lblBathroomSubtitle = new Label();
            pnlBathroomInfo = new Panel();
            lblBathroomCameras = new Label();
            lblBathroomSensors = new Label();
            lblBathroomQuick = new Label();
            btnBathroomMotion = new Button();
            btnBathroomDoor = new Button();
            btnBathroomCamera = new Button();
            btnBathroomReset = new Button();
            zoneGarage = new Panel();
            pnlGarageBanner = new Panel();
            lblGarageHome = new Label();
            lblGarageOnline = new Label();
            lblGarageName = new Label();
            lblGarageStatus = new Label();
            lblGarageSubtitle = new Label();
            pnlGarageInfo = new Panel();
            lblGarageCameras = new Label();
            lblGarageSensors = new Label();
            lblGarageQuick = new Label();
            btnGarageMotion = new Button();
            btnGarageDoor = new Button();
            btnGarageCamera = new Button();
            btnGarageReset = new Button();
            cardAlarm = new Panel();
            lblAlarmCaption = new Label();
            lblAlarmState = new Label();
            lblAlarmHint = new Label();
            btnArm = new Button();
            btnDisarm = new Button();
            chkAutoSim = new CheckBox();
            pnlsys = new Panel();
            btnsystem = new Button();
            pnl6 = new Panel();
            panel6 = new Panel();
            lblnet = new Label();
            pnl7 = new Panel();
            pnl5 = new Panel();
            panel3 = new Panel();
            lblpower = new Label();
            pnlTrack = new Panel();
            pnlfill = new Panel();
            pnl9 = new Panel();
            lblsecurity = new Label();
            lbl66 = new Label();
            col4 = new DataGridViewTextBoxColumn();
            col3 = new DataGridViewTextBoxColumn();
            col2 = new DataGridViewTextBoxColumn();
            col1 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            lbl88 = new Label();
            lbldaily = new Label();
            pictureBox1 = new PictureBox();
            lbl58 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            lbl95 = new Label();
            cardStatAlarm.SuspendLayout();
            cardStatZones.SuspendLayout();
            cardStatEvents.SuspendLayout();
            zoneLiving.SuspendLayout();
            pnlLivingBanner.SuspendLayout();
            pnlLivingInfo.SuspendLayout();
            zoneBedroom.SuspendLayout();
            pnlBedroomBanner.SuspendLayout();
            pnlBedroomInfo.SuspendLayout();
            zoneKitchen.SuspendLayout();
            pnlKitchenBanner.SuspendLayout();
            pnlKitchenInfo.SuspendLayout();
            zoneBathroom.SuspendLayout();
            pnlBathroomBanner.SuspendLayout();
            pnlBathroomInfo.SuspendLayout();
            zoneGarage.SuspendLayout();
            pnlGarageBanner.SuspendLayout();
            pnlGarageInfo.SuspendLayout();
            cardAlarm.SuspendLayout();
            pnlsys.SuspendLayout();
            pnl6.SuspendLayout();
            pnl5.SuspendLayout();
            pnlTrack.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tmrAuto
            // 
            tmrAuto.Interval = 4000;
            tmrAuto.Tick += tmrAuto_Tick;
            // 
            // tmrUi
            // 
            tmrUi.Interval = 1000;
            tmrUi.Tick += tmrUi_Tick;
            // 
            // lblPageIcon
            // 
            lblPageIcon.BackColor = Color.Transparent;
            lblPageIcon.Font = new Font("Segoe MDL2 Assets", 26F);
            lblPageIcon.ForeColor = Color.FromArgb(179, 157, 255);
            lblPageIcon.Location = new Point(24, 18);
            lblPageIcon.Name = "lblPageIcon";
            lblPageIcon.Size = new Size(44, 40);
            lblPageIcon.TabIndex = 0;
            lblPageIcon.Text = "";
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(255, 255, 255);
            lblTitle.Location = new Point(76, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(330, 53);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Security Center";
            // 
            // lblSubtitle
            // 
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(169, 166, 201);
            lblSubtitle.Location = new Point(76, 63);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(390, 22);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Monitor and control your home security";
            // 
            // cardStatAlarm
            // 
            cardStatAlarm.BackColor = Color.FromArgb(26, 22, 62);
            cardStatAlarm.Controls.Add(lblStatAlarm);
            cardStatAlarm.Controls.Add(lblStatAlarmCaption);
            cardStatAlarm.Location = new Point(560, 12);
            cardStatAlarm.Name = "cardStatAlarm";
            cardStatAlarm.Size = new Size(132, 64);
            cardStatAlarm.TabIndex = 3;
            // 
            // lblStatAlarm
            // 
            lblStatAlarm.BackColor = Color.Transparent;
            lblStatAlarm.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblStatAlarm.ForeColor = Color.FromArgb(111, 227, 160);
            lblStatAlarm.Location = new Point(14, 8);
            lblStatAlarm.Name = "lblStatAlarm";
            lblStatAlarm.Size = new Size(116, 28);
            lblStatAlarm.TabIndex = 4;
            lblStatAlarm.Text = "Disarmed";
            // 
            // lblStatAlarmCaption
            // 
            lblStatAlarmCaption.BackColor = Color.Transparent;
            lblStatAlarmCaption.Font = new Font("Segoe UI", 9F);
            lblStatAlarmCaption.ForeColor = Color.FromArgb(169, 166, 201);
            lblStatAlarmCaption.Location = new Point(14, 38);
            lblStatAlarmCaption.Name = "lblStatAlarmCaption";
            lblStatAlarmCaption.Size = new Size(116, 22);
            lblStatAlarmCaption.TabIndex = 5;
            lblStatAlarmCaption.Text = "Alarm status";
            // 
            // cardStatZones
            // 
            cardStatZones.BackColor = Color.FromArgb(26, 22, 62);
            cardStatZones.Controls.Add(lblStatZones);
            cardStatZones.Controls.Add(lblStatZonesCaption);
            cardStatZones.Location = new Point(702, 12);
            cardStatZones.Name = "cardStatZones";
            cardStatZones.Size = new Size(132, 64);
            cardStatZones.TabIndex = 6;
            // 
            // lblStatZones
            // 
            lblStatZones.BackColor = Color.Transparent;
            lblStatZones.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblStatZones.ForeColor = Color.FromArgb(255, 255, 255);
            lblStatZones.Location = new Point(14, 8);
            lblStatZones.Name = "lblStatZones";
            lblStatZones.Size = new Size(116, 28);
            lblStatZones.TabIndex = 7;
            lblStatZones.Text = "5";
            // 
            // lblStatZonesCaption
            // 
            lblStatZonesCaption.BackColor = Color.Transparent;
            lblStatZonesCaption.Font = new Font("Segoe UI", 9F);
            lblStatZonesCaption.ForeColor = Color.FromArgb(169, 166, 201);
            lblStatZonesCaption.Location = new Point(14, 38);
            lblStatZonesCaption.Name = "lblStatZonesCaption";
            lblStatZonesCaption.Size = new Size(116, 22);
            lblStatZonesCaption.TabIndex = 8;
            lblStatZonesCaption.Text = "Security zones";
            // 
            // cardStatEvents
            // 
            cardStatEvents.BackColor = Color.FromArgb(26, 22, 62);
            cardStatEvents.Controls.Add(lblStatEvents);
            cardStatEvents.Controls.Add(lblStatEventsCaption);
            cardStatEvents.Location = new Point(844, 12);
            cardStatEvents.Name = "cardStatEvents";
            cardStatEvents.Size = new Size(132, 64);
            cardStatEvents.TabIndex = 9;
            // 
            // lblStatEvents
            // 
            lblStatEvents.BackColor = Color.Transparent;
            lblStatEvents.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblStatEvents.ForeColor = Color.FromArgb(255, 255, 255);
            lblStatEvents.Location = new Point(14, 8);
            lblStatEvents.Name = "lblStatEvents";
            lblStatEvents.Size = new Size(116, 28);
            lblStatEvents.TabIndex = 10;
            lblStatEvents.Text = "0";
            // 
            // lblStatEventsCaption
            // 
            lblStatEventsCaption.BackColor = Color.Transparent;
            lblStatEventsCaption.Font = new Font("Segoe UI", 9F);
            lblStatEventsCaption.ForeColor = Color.FromArgb(169, 166, 201);
            lblStatEventsCaption.Location = new Point(14, 38);
            lblStatEventsCaption.Name = "lblStatEventsCaption";
            lblStatEventsCaption.Size = new Size(116, 22);
            lblStatEventsCaption.TabIndex = 11;
            lblStatEventsCaption.Text = "Events logged";
            // 
            // zoneLiving
            // 
            zoneLiving.BackColor = Color.FromArgb(26, 22, 62);
            zoneLiving.Controls.Add(pnlLivingBanner);
            zoneLiving.Controls.Add(lblLivingName);
            zoneLiving.Controls.Add(lblLivingStatus);
            zoneLiving.Controls.Add(lblLivingSubtitle);
            zoneLiving.Controls.Add(pnlLivingInfo);
            zoneLiving.Controls.Add(lblLivingQuick);
            zoneLiving.Controls.Add(btnLivingMotion);
            zoneLiving.Controls.Add(btnLivingDoor);
            zoneLiving.Controls.Add(btnLivingCamera);
            zoneLiving.Controls.Add(btnLivingReset);
            zoneLiving.Location = new Point(24, 104);
            zoneLiving.Name = "zoneLiving";
            zoneLiving.Size = new Size(365, 326);
            zoneLiving.TabIndex = 12;
            // 
            // pnlLivingBanner
            // 
            pnlLivingBanner.BackColor = Color.FromArgb(58, 42, 123);
            pnlLivingBanner.Controls.Add(lblLivingHome);
            pnlLivingBanner.Controls.Add(lblLivingOnline);
            pnlLivingBanner.Location = new Point(14, 8);
            pnlLivingBanner.Name = "pnlLivingBanner";
            pnlLivingBanner.Size = new Size(338, 80);
            pnlLivingBanner.TabIndex = 13;
            // 
            // lblLivingHome
            // 
            lblLivingHome.BackColor = Color.Transparent;
            lblLivingHome.Font = new Font("Segoe MDL2 Assets", 30F);
            lblLivingHome.ForeColor = Color.FromArgb(150, 125, 235);
            lblLivingHome.Location = new Point(257, 10);
            lblLivingHome.Name = "lblLivingHome";
            lblLivingHome.Size = new Size(65, 58);
            lblLivingHome.TabIndex = 14;
            lblLivingHome.Text = "";
            // 
            // lblLivingOnline
            // 
            lblLivingOnline.BackColor = Color.Transparent;
            lblLivingOnline.Font = new Font("Segoe UI", 10F);
            lblLivingOnline.ForeColor = Color.FromArgb(111, 227, 160);
            lblLivingOnline.Location = new Point(10, 10);
            lblLivingOnline.Name = "lblLivingOnline";
            lblLivingOnline.Size = new Size(84, 24);
            lblLivingOnline.TabIndex = 15;
            lblLivingOnline.Text = "● Online";
            // 
            // lblLivingName
            // 
            lblLivingName.BackColor = Color.Transparent;
            lblLivingName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblLivingName.ForeColor = Color.FromArgb(255, 255, 255);
            lblLivingName.Location = new Point(14, 98);
            lblLivingName.Name = "lblLivingName";
            lblLivingName.Size = new Size(174, 39);
            lblLivingName.TabIndex = 16;
            lblLivingName.Text = "Living Room";
            // 
            // lblLivingStatus
            // 
            lblLivingStatus.BackColor = Color.Transparent;
            lblLivingStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblLivingStatus.ForeColor = Color.FromArgb(111, 227, 160);
            lblLivingStatus.Location = new Point(196, 98);
            lblLivingStatus.Name = "lblLivingStatus";
            lblLivingStatus.Size = new Size(100, 25);
            lblLivingStatus.TabIndex = 17;
            lblLivingStatus.Text = "Secure";
            // 
            // lblLivingSubtitle
            // 
            lblLivingSubtitle.BackColor = Color.Transparent;
            lblLivingSubtitle.Font = new Font("Segoe UI", 9F);
            lblLivingSubtitle.ForeColor = Color.FromArgb(169, 166, 201);
            lblLivingSubtitle.Location = new Point(14, 137);
            lblLivingSubtitle.Name = "lblLivingSubtitle";
            lblLivingSubtitle.Size = new Size(280, 20);
            lblLivingSubtitle.TabIndex = 18;
            lblLivingSubtitle.Text = "Main entertainment area";
            // 
            // pnlLivingInfo
            // 
            pnlLivingInfo.BackColor = Color.FromArgb(32, 28, 72);
            pnlLivingInfo.Controls.Add(lblLivingCameras);
            pnlLivingInfo.Controls.Add(lblLivingSensors);
            pnlLivingInfo.Location = new Point(14, 174);
            pnlLivingInfo.Name = "pnlLivingInfo";
            pnlLivingInfo.Size = new Size(294, 30);
            pnlLivingInfo.TabIndex = 19;
            // 
            // lblLivingCameras
            // 
            lblLivingCameras.BackColor = Color.Transparent;
            lblLivingCameras.Font = new Font("Segoe UI", 9F);
            lblLivingCameras.ForeColor = Color.FromArgb(169, 166, 201);
            lblLivingCameras.Location = new Point(16, 6);
            lblLivingCameras.Name = "lblLivingCameras";
            lblLivingCameras.Size = new Size(118, 20);
            lblLivingCameras.TabIndex = 20;
            lblLivingCameras.Text = "1 Camera";
            // 
            // lblLivingSensors
            // 
            lblLivingSensors.BackColor = Color.Transparent;
            lblLivingSensors.Font = new Font("Segoe UI", 9F);
            lblLivingSensors.ForeColor = Color.FromArgb(169, 166, 201);
            lblLivingSensors.Location = new Point(158, 6);
            lblLivingSensors.Name = "lblLivingSensors";
            lblLivingSensors.Size = new Size(118, 20);
            lblLivingSensors.TabIndex = 21;
            lblLivingSensors.Text = "2 Sensors";
            // 
            // lblLivingQuick
            // 
            lblLivingQuick.BackColor = Color.Transparent;
            lblLivingQuick.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblLivingQuick.ForeColor = Color.FromArgb(255, 255, 255);
            lblLivingQuick.Location = new Point(14, 215);
            lblLivingQuick.Name = "lblLivingQuick";
            lblLivingQuick.Size = new Size(205, 20);
            lblLivingQuick.TabIndex = 22;
            lblLivingQuick.Text = "Quick Controls";
            // 
            // btnLivingMotion
            // 
            btnLivingMotion.BackColor = Color.FromArgb(40, 36, 86);
            btnLivingMotion.Cursor = Cursors.Hand;
            btnLivingMotion.FlatAppearance.BorderSize = 0;
            btnLivingMotion.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 56, 124);
            btnLivingMotion.FlatStyle = FlatStyle.Flat;
            btnLivingMotion.Font = new Font("Segoe UI", 8F);
            btnLivingMotion.ForeColor = Color.White;
            btnLivingMotion.Location = new Point(14, 252);
            btnLivingMotion.Name = "btnLivingMotion";
            btnLivingMotion.Size = new Size(64, 58);
            btnLivingMotion.TabIndex = 23;
            btnLivingMotion.Tag = "Living Room";
            btnLivingMotion.Text = "Motion\r\nClear";
            btnLivingMotion.UseVisualStyleBackColor = false;
            btnLivingMotion.Click += btnMotion_Click;
            // 
            // btnLivingDoor
            // 
            btnLivingDoor.BackColor = Color.FromArgb(40, 36, 86);
            btnLivingDoor.Cursor = Cursors.Hand;
            btnLivingDoor.FlatAppearance.BorderSize = 0;
            btnLivingDoor.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 56, 124);
            btnLivingDoor.FlatStyle = FlatStyle.Flat;
            btnLivingDoor.Font = new Font("Segoe UI", 8F);
            btnLivingDoor.ForeColor = Color.White;
            btnLivingDoor.Location = new Point(101, 252);
            btnLivingDoor.Name = "btnLivingDoor";
            btnLivingDoor.Size = new Size(73, 58);
            btnLivingDoor.TabIndex = 24;
            btnLivingDoor.Tag = "Living Room";
            btnLivingDoor.Text = "Door\r\nClosed";
            btnLivingDoor.UseVisualStyleBackColor = false;
            btnLivingDoor.Click += btnDoor_Click;
            // 
            // btnLivingCamera
            // 
            btnLivingCamera.BackColor = Color.FromArgb(124, 77, 255);
            btnLivingCamera.Cursor = Cursors.Hand;
            btnLivingCamera.FlatAppearance.BorderSize = 0;
            btnLivingCamera.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 56, 124);
            btnLivingCamera.FlatStyle = FlatStyle.Flat;
            btnLivingCamera.Font = new Font("Segoe UI", 8F);
            btnLivingCamera.ForeColor = Color.White;
            btnLivingCamera.Location = new Point(196, 252);
            btnLivingCamera.Name = "btnLivingCamera";
            btnLivingCamera.Size = new Size(64, 58);
            btnLivingCamera.TabIndex = 25;
            btnLivingCamera.Tag = "Living Room";
            btnLivingCamera.Text = "Camera\r\nActive";
            btnLivingCamera.UseVisualStyleBackColor = false;
            btnLivingCamera.Click += btnCamera_Click;
            // 
            // btnLivingReset
            // 
            btnLivingReset.BackColor = Color.FromArgb(40, 36, 86);
            btnLivingReset.Cursor = Cursors.Hand;
            btnLivingReset.FlatAppearance.BorderSize = 0;
            btnLivingReset.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 56, 124);
            btnLivingReset.FlatStyle = FlatStyle.Flat;
            btnLivingReset.Font = new Font("Segoe UI", 8F);
            btnLivingReset.ForeColor = Color.White;
            btnLivingReset.Location = new Point(280, 252);
            btnLivingReset.Name = "btnLivingReset";
            btnLivingReset.Size = new Size(72, 58);
            btnLivingReset.TabIndex = 26;
            btnLivingReset.Tag = "Living Room";
            btnLivingReset.Text = "More\r\nReset";
            btnLivingReset.UseVisualStyleBackColor = false;
            btnLivingReset.Click += btnReset_Click;
            // 
            // zoneBedroom
            // 
            zoneBedroom.BackColor = Color.FromArgb(26, 22, 62);
            zoneBedroom.Controls.Add(pnlBedroomBanner);
            zoneBedroom.Controls.Add(lblBedroomName);
            zoneBedroom.Controls.Add(lblBedroomStatus);
            zoneBedroom.Controls.Add(lblBedroomSubtitle);
            zoneBedroom.Controls.Add(pnlBedroomInfo);
            zoneBedroom.Controls.Add(lblBedroomQuick);
            zoneBedroom.Controls.Add(btnBedroomMotion);
            zoneBedroom.Controls.Add(btnBedroomDoor);
            zoneBedroom.Controls.Add(btnBedroomCamera);
            zoneBedroom.Controls.Add(btnBedroomReset);
            zoneBedroom.Location = new Point(822, 104);
            zoneBedroom.Name = "zoneBedroom";
            zoneBedroom.Size = new Size(369, 326);
            zoneBedroom.TabIndex = 27;
            // 
            // pnlBedroomBanner
            // 
            pnlBedroomBanner.BackColor = Color.FromArgb(58, 42, 123);
            pnlBedroomBanner.Controls.Add(lblBedroomHome);
            pnlBedroomBanner.Controls.Add(lblBedroomOnline);
            pnlBedroomBanner.Location = new Point(8, 8);
            pnlBedroomBanner.Name = "pnlBedroomBanner";
            pnlBedroomBanner.Size = new Size(344, 80);
            pnlBedroomBanner.TabIndex = 28;
            // 
            // lblBedroomHome
            // 
            lblBedroomHome.BackColor = Color.Transparent;
            lblBedroomHome.Font = new Font("Segoe MDL2 Assets", 30F);
            lblBedroomHome.ForeColor = Color.FromArgb(150, 125, 235);
            lblBedroomHome.Location = new Point(261, 10);
            lblBedroomHome.Name = "lblBedroomHome";
            lblBedroomHome.Size = new Size(65, 58);
            lblBedroomHome.TabIndex = 29;
            lblBedroomHome.Text = "";
            // 
            // lblBedroomOnline
            // 
            lblBedroomOnline.BackColor = Color.Transparent;
            lblBedroomOnline.Font = new Font("Segoe UI", 10F);
            lblBedroomOnline.ForeColor = Color.FromArgb(111, 227, 160);
            lblBedroomOnline.Location = new Point(14, 10);
            lblBedroomOnline.Name = "lblBedroomOnline";
            lblBedroomOnline.Size = new Size(84, 24);
            lblBedroomOnline.TabIndex = 30;
            lblBedroomOnline.Text = "● Online";
            // 
            // lblBedroomName
            // 
            lblBedroomName.BackColor = Color.Transparent;
            lblBedroomName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBedroomName.ForeColor = Color.FromArgb(255, 255, 255);
            lblBedroomName.Location = new Point(14, 98);
            lblBedroomName.Name = "lblBedroomName";
            lblBedroomName.Size = new Size(174, 25);
            lblBedroomName.TabIndex = 31;
            lblBedroomName.Text = "Bedroom";
            // 
            // lblBedroomStatus
            // 
            lblBedroomStatus.BackColor = Color.Transparent;
            lblBedroomStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblBedroomStatus.ForeColor = Color.FromArgb(111, 227, 160);
            lblBedroomStatus.Location = new Point(196, 98);
            lblBedroomStatus.Name = "lblBedroomStatus";
            lblBedroomStatus.Size = new Size(100, 25);
            lblBedroomStatus.TabIndex = 32;
            lblBedroomStatus.Text = "Secure";
            // 
            // lblBedroomSubtitle
            // 
            lblBedroomSubtitle.BackColor = Color.Transparent;
            lblBedroomSubtitle.Font = new Font("Segoe UI", 9F);
            lblBedroomSubtitle.ForeColor = Color.FromArgb(169, 166, 201);
            lblBedroomSubtitle.Location = new Point(14, 137);
            lblBedroomSubtitle.Name = "lblBedroomSubtitle";
            lblBedroomSubtitle.Size = new Size(221, 20);
            lblBedroomSubtitle.TabIndex = 33;
            lblBedroomSubtitle.Text = "Rest and sleep zone";
            // 
            // pnlBedroomInfo
            // 
            pnlBedroomInfo.BackColor = Color.FromArgb(32, 28, 72);
            pnlBedroomInfo.Controls.Add(lblBedroomCameras);
            pnlBedroomInfo.Controls.Add(lblBedroomSensors);
            pnlBedroomInfo.Location = new Point(14, 170);
            pnlBedroomInfo.Name = "pnlBedroomInfo";
            pnlBedroomInfo.Size = new Size(280, 30);
            pnlBedroomInfo.TabIndex = 34;
            // 
            // lblBedroomCameras
            // 
            lblBedroomCameras.BackColor = Color.Transparent;
            lblBedroomCameras.Font = new Font("Segoe UI", 9F);
            lblBedroomCameras.ForeColor = Color.FromArgb(169, 166, 201);
            lblBedroomCameras.Location = new Point(16, 6);
            lblBedroomCameras.Name = "lblBedroomCameras";
            lblBedroomCameras.Size = new Size(118, 20);
            lblBedroomCameras.TabIndex = 35;
            lblBedroomCameras.Text = "1 Camera";
            // 
            // lblBedroomSensors
            // 
            lblBedroomSensors.BackColor = Color.Transparent;
            lblBedroomSensors.Font = new Font("Segoe UI", 9F);
            lblBedroomSensors.ForeColor = Color.FromArgb(169, 166, 201);
            lblBedroomSensors.Location = new Point(158, 6);
            lblBedroomSensors.Name = "lblBedroomSensors";
            lblBedroomSensors.Size = new Size(118, 20);
            lblBedroomSensors.TabIndex = 36;
            lblBedroomSensors.Text = "2 Sensors";
            // 
            // lblBedroomQuick
            // 
            lblBedroomQuick.BackColor = Color.Transparent;
            lblBedroomQuick.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblBedroomQuick.ForeColor = Color.FromArgb(255, 255, 255);
            lblBedroomQuick.Location = new Point(14, 215);
            lblBedroomQuick.Name = "lblBedroomQuick";
            lblBedroomQuick.Size = new Size(174, 20);
            lblBedroomQuick.TabIndex = 37;
            lblBedroomQuick.Text = "Quick Controls";
            // 
            // btnBedroomMotion
            // 
            btnBedroomMotion.BackColor = Color.FromArgb(40, 36, 86);
            btnBedroomMotion.Cursor = Cursors.Hand;
            btnBedroomMotion.FlatAppearance.BorderSize = 0;
            btnBedroomMotion.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 56, 124);
            btnBedroomMotion.FlatStyle = FlatStyle.Flat;
            btnBedroomMotion.Font = new Font("Segoe UI", 8F);
            btnBedroomMotion.ForeColor = Color.White;
            btnBedroomMotion.Location = new Point(18, 252);
            btnBedroomMotion.Name = "btnBedroomMotion";
            btnBedroomMotion.Size = new Size(64, 58);
            btnBedroomMotion.TabIndex = 38;
            btnBedroomMotion.Tag = "Bedroom";
            btnBedroomMotion.Text = "Motion\r\nClear";
            btnBedroomMotion.UseVisualStyleBackColor = false;
            btnBedroomMotion.Click += btnMotion_Click;
            // 
            // btnBedroomDoor
            // 
            btnBedroomDoor.BackColor = Color.FromArgb(40, 36, 86);
            btnBedroomDoor.Cursor = Cursors.Hand;
            btnBedroomDoor.FlatAppearance.BorderSize = 0;
            btnBedroomDoor.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 56, 124);
            btnBedroomDoor.FlatStyle = FlatStyle.Flat;
            btnBedroomDoor.Font = new Font("Segoe UI", 8F);
            btnBedroomDoor.ForeColor = Color.White;
            btnBedroomDoor.Location = new Point(108, 252);
            btnBedroomDoor.Name = "btnBedroomDoor";
            btnBedroomDoor.Size = new Size(64, 58);
            btnBedroomDoor.TabIndex = 39;
            btnBedroomDoor.Tag = "Bedroom";
            btnBedroomDoor.Text = "Door\r\nClosed";
            btnBedroomDoor.UseVisualStyleBackColor = false;
            btnBedroomDoor.Click += btnDoor_Click;
            // 
            // btnBedroomCamera
            // 
            btnBedroomCamera.BackColor = Color.FromArgb(124, 77, 255);
            btnBedroomCamera.Cursor = Cursors.Hand;
            btnBedroomCamera.FlatAppearance.BorderSize = 0;
            btnBedroomCamera.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 56, 124);
            btnBedroomCamera.FlatStyle = FlatStyle.Flat;
            btnBedroomCamera.Font = new Font("Segoe UI", 8F);
            btnBedroomCamera.ForeColor = Color.White;
            btnBedroomCamera.Location = new Point(196, 252);
            btnBedroomCamera.Name = "btnBedroomCamera";
            btnBedroomCamera.Size = new Size(64, 58);
            btnBedroomCamera.TabIndex = 40;
            btnBedroomCamera.Tag = "Bedroom";
            btnBedroomCamera.Text = "Camera\r\nActive";
            btnBedroomCamera.UseVisualStyleBackColor = false;
            btnBedroomCamera.Click += btnCamera_Click;
            // 
            // btnBedroomReset
            // 
            btnBedroomReset.BackColor = Color.FromArgb(40, 36, 86);
            btnBedroomReset.Cursor = Cursors.Hand;
            btnBedroomReset.FlatAppearance.BorderSize = 0;
            btnBedroomReset.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 56, 124);
            btnBedroomReset.FlatStyle = FlatStyle.Flat;
            btnBedroomReset.Font = new Font("Segoe UI", 8F);
            btnBedroomReset.ForeColor = Color.White;
            btnBedroomReset.Location = new Point(283, 252);
            btnBedroomReset.Name = "btnBedroomReset";
            btnBedroomReset.Size = new Size(69, 58);
            btnBedroomReset.TabIndex = 41;
            btnBedroomReset.Tag = "Bedroom";
            btnBedroomReset.Text = "More\r\nReset";
            btnBedroomReset.UseVisualStyleBackColor = false;
            btnBedroomReset.Click += btnReset_Click;
            // 
            // zoneKitchen
            // 
            zoneKitchen.BackColor = Color.FromArgb(26, 22, 62);
            zoneKitchen.Controls.Add(pnlKitchenBanner);
            zoneKitchen.Controls.Add(lblKitchenName);
            zoneKitchen.Controls.Add(lblKitchenStatus);
            zoneKitchen.Controls.Add(lblKitchenSubtitle);
            zoneKitchen.Controls.Add(pnlKitchenInfo);
            zoneKitchen.Controls.Add(lblKitchenQuick);
            zoneKitchen.Controls.Add(btnKitchenMotion);
            zoneKitchen.Controls.Add(btnKitchenDoor);
            zoneKitchen.Controls.Add(btnKitchenCamera);
            zoneKitchen.Controls.Add(btnKitchenReset);
            zoneKitchen.Location = new Point(1219, 104);
            zoneKitchen.Name = "zoneKitchen";
            zoneKitchen.Size = new Size(369, 326);
            zoneKitchen.TabIndex = 42;
            // 
            // pnlKitchenBanner
            // 
            pnlKitchenBanner.BackColor = Color.FromArgb(58, 42, 123);
            pnlKitchenBanner.Controls.Add(lblKitchenHome);
            pnlKitchenBanner.Controls.Add(lblKitchenOnline);
            pnlKitchenBanner.Location = new Point(8, 8);
            pnlKitchenBanner.Name = "pnlKitchenBanner";
            pnlKitchenBanner.Size = new Size(339, 80);
            pnlKitchenBanner.TabIndex = 43;
            // 
            // lblKitchenHome
            // 
            lblKitchenHome.BackColor = Color.Transparent;
            lblKitchenHome.Font = new Font("Segoe MDL2 Assets", 30F);
            lblKitchenHome.ForeColor = Color.FromArgb(150, 125, 235);
            lblKitchenHome.Location = new Point(252, 10);
            lblKitchenHome.Name = "lblKitchenHome";
            lblKitchenHome.Size = new Size(65, 58);
            lblKitchenHome.TabIndex = 44;
            lblKitchenHome.Text = "";
            // 
            // lblKitchenOnline
            // 
            lblKitchenOnline.BackColor = Color.Transparent;
            lblKitchenOnline.Font = new Font("Segoe UI", 10F);
            lblKitchenOnline.ForeColor = Color.FromArgb(111, 227, 160);
            lblKitchenOnline.Location = new Point(15, 10);
            lblKitchenOnline.Name = "lblKitchenOnline";
            lblKitchenOnline.Size = new Size(84, 24);
            lblKitchenOnline.TabIndex = 45;
            lblKitchenOnline.Text = "● Online";
            // 
            // lblKitchenName
            // 
            lblKitchenName.BackColor = Color.Transparent;
            lblKitchenName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblKitchenName.ForeColor = Color.FromArgb(255, 255, 255);
            lblKitchenName.Location = new Point(14, 98);
            lblKitchenName.Name = "lblKitchenName";
            lblKitchenName.Size = new Size(174, 25);
            lblKitchenName.TabIndex = 46;
            lblKitchenName.Text = "Kitchen";
            // 
            // lblKitchenStatus
            // 
            lblKitchenStatus.BackColor = Color.Transparent;
            lblKitchenStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblKitchenStatus.ForeColor = Color.FromArgb(111, 227, 160);
            lblKitchenStatus.Location = new Point(196, 98);
            lblKitchenStatus.Name = "lblKitchenStatus";
            lblKitchenStatus.Size = new Size(100, 25);
            lblKitchenStatus.TabIndex = 47;
            lblKitchenStatus.Text = "Secure";
            // 
            // lblKitchenSubtitle
            // 
            lblKitchenSubtitle.BackColor = Color.Transparent;
            lblKitchenSubtitle.Font = new Font("Segoe UI", 9F);
            lblKitchenSubtitle.ForeColor = Color.FromArgb(169, 166, 201);
            lblKitchenSubtitle.Location = new Point(14, 124);
            lblKitchenSubtitle.Name = "lblKitchenSubtitle";
            lblKitchenSubtitle.Size = new Size(280, 20);
            lblKitchenSubtitle.TabIndex = 48;
            lblKitchenSubtitle.Text = "Cooking and dining area";
            // 
            // pnlKitchenInfo
            // 
            pnlKitchenInfo.BackColor = Color.FromArgb(32, 28, 72);
            pnlKitchenInfo.Controls.Add(lblKitchenCameras);
            pnlKitchenInfo.Controls.Add(lblKitchenSensors);
            pnlKitchenInfo.Location = new Point(14, 146);
            pnlKitchenInfo.Name = "pnlKitchenInfo";
            pnlKitchenInfo.Size = new Size(280, 30);
            pnlKitchenInfo.TabIndex = 49;
            // 
            // lblKitchenCameras
            // 
            lblKitchenCameras.BackColor = Color.Transparent;
            lblKitchenCameras.Font = new Font("Segoe UI", 9F);
            lblKitchenCameras.ForeColor = Color.FromArgb(169, 166, 201);
            lblKitchenCameras.Location = new Point(16, 6);
            lblKitchenCameras.Name = "lblKitchenCameras";
            lblKitchenCameras.Size = new Size(118, 20);
            lblKitchenCameras.TabIndex = 50;
            lblKitchenCameras.Text = "1 Camera";
            // 
            // lblKitchenSensors
            // 
            lblKitchenSensors.BackColor = Color.Transparent;
            lblKitchenSensors.Font = new Font("Segoe UI", 9F);
            lblKitchenSensors.ForeColor = Color.FromArgb(169, 166, 201);
            lblKitchenSensors.Location = new Point(158, 6);
            lblKitchenSensors.Name = "lblKitchenSensors";
            lblKitchenSensors.Size = new Size(118, 20);
            lblKitchenSensors.TabIndex = 51;
            lblKitchenSensors.Text = "2 Sensors";
            // 
            // lblKitchenQuick
            // 
            lblKitchenQuick.BackColor = Color.Transparent;
            lblKitchenQuick.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblKitchenQuick.ForeColor = Color.FromArgb(255, 255, 255);
            lblKitchenQuick.Location = new Point(14, 184);
            lblKitchenQuick.Name = "lblKitchenQuick";
            lblKitchenQuick.Size = new Size(230, 20);
            lblKitchenQuick.TabIndex = 52;
            lblKitchenQuick.Text = "Quick Controls";
            // 
            // btnKitchenMotion
            // 
            btnKitchenMotion.BackColor = Color.FromArgb(40, 36, 86);
            btnKitchenMotion.Cursor = Cursors.Hand;
            btnKitchenMotion.FlatAppearance.BorderSize = 0;
            btnKitchenMotion.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 56, 124);
            btnKitchenMotion.FlatStyle = FlatStyle.Flat;
            btnKitchenMotion.Font = new Font("Segoe UI", 8F);
            btnKitchenMotion.ForeColor = Color.White;
            btnKitchenMotion.Location = new Point(14, 252);
            btnKitchenMotion.Name = "btnKitchenMotion";
            btnKitchenMotion.Size = new Size(64, 58);
            btnKitchenMotion.TabIndex = 53;
            btnKitchenMotion.Tag = "Kitchen";
            btnKitchenMotion.Text = "Motion\r\nClear";
            btnKitchenMotion.UseVisualStyleBackColor = false;
            btnKitchenMotion.Click += btnMotion_Click;
            // 
            // btnKitchenDoor
            // 
            btnKitchenDoor.BackColor = Color.FromArgb(40, 36, 86);
            btnKitchenDoor.Cursor = Cursors.Hand;
            btnKitchenDoor.FlatAppearance.BorderSize = 0;
            btnKitchenDoor.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 56, 124);
            btnKitchenDoor.FlatStyle = FlatStyle.Flat;
            btnKitchenDoor.Font = new Font("Segoe UI", 8F);
            btnKitchenDoor.ForeColor = Color.White;
            btnKitchenDoor.Location = new Point(103, 252);
            btnKitchenDoor.Name = "btnKitchenDoor";
            btnKitchenDoor.Size = new Size(64, 58);
            btnKitchenDoor.TabIndex = 54;
            btnKitchenDoor.Tag = "Kitchen";
            btnKitchenDoor.Text = "Door\r\nClosed";
            btnKitchenDoor.UseVisualStyleBackColor = false;
            btnKitchenDoor.Click += btnDoor_Click;
            // 
            // btnKitchenCamera
            // 
            btnKitchenCamera.BackColor = Color.FromArgb(124, 77, 255);
            btnKitchenCamera.Cursor = Cursors.Hand;
            btnKitchenCamera.FlatAppearance.BorderSize = 0;
            btnKitchenCamera.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 56, 124);
            btnKitchenCamera.FlatStyle = FlatStyle.Flat;
            btnKitchenCamera.Font = new Font("Segoe UI", 8F);
            btnKitchenCamera.ForeColor = Color.White;
            btnKitchenCamera.Location = new Point(196, 252);
            btnKitchenCamera.Name = "btnKitchenCamera";
            btnKitchenCamera.Size = new Size(64, 58);
            btnKitchenCamera.TabIndex = 55;
            btnKitchenCamera.Tag = "Kitchen";
            btnKitchenCamera.Text = "Camera\r\nActive";
            btnKitchenCamera.UseVisualStyleBackColor = false;
            btnKitchenCamera.Click += btnCamera_Click;
            // 
            // btnKitchenReset
            // 
            btnKitchenReset.BackColor = Color.FromArgb(40, 36, 86);
            btnKitchenReset.Cursor = Cursors.Hand;
            btnKitchenReset.FlatAppearance.BorderSize = 0;
            btnKitchenReset.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 56, 124);
            btnKitchenReset.FlatStyle = FlatStyle.Flat;
            btnKitchenReset.Font = new Font("Segoe UI", 8F);
            btnKitchenReset.ForeColor = Color.White;
            btnKitchenReset.Location = new Point(283, 252);
            btnKitchenReset.Name = "btnKitchenReset";
            btnKitchenReset.Size = new Size(64, 58);
            btnKitchenReset.TabIndex = 56;
            btnKitchenReset.Tag = "Kitchen";
            btnKitchenReset.Text = "More\r\nReset";
            btnKitchenReset.UseVisualStyleBackColor = false;
            btnKitchenReset.Click += btnReset_Click;
            // 
            // zoneBathroom
            // 
            zoneBathroom.BackColor = Color.FromArgb(26, 22, 62);
            zoneBathroom.Controls.Add(pnlBathroomBanner);
            zoneBathroom.Controls.Add(lblBathroomName);
            zoneBathroom.Controls.Add(lblBathroomStatus);
            zoneBathroom.Controls.Add(lblBathroomSubtitle);
            zoneBathroom.Controls.Add(pnlBathroomInfo);
            zoneBathroom.Controls.Add(lblBathroomQuick);
            zoneBathroom.Controls.Add(btnBathroomMotion);
            zoneBathroom.Controls.Add(btnBathroomDoor);
            zoneBathroom.Controls.Add(btnBathroomCamera);
            zoneBathroom.Controls.Add(btnBathroomReset);
            zoneBathroom.Location = new Point(421, 104);
            zoneBathroom.Name = "zoneBathroom";
            zoneBathroom.Size = new Size(371, 326);
            zoneBathroom.TabIndex = 57;
            // 
            // pnlBathroomBanner
            // 
            pnlBathroomBanner.BackColor = Color.FromArgb(58, 42, 123);
            pnlBathroomBanner.Controls.Add(lblBathroomHome);
            pnlBathroomBanner.Controls.Add(lblBathroomOnline);
            pnlBathroomBanner.Location = new Point(8, 8);
            pnlBathroomBanner.Name = "pnlBathroomBanner";
            pnlBathroomBanner.Size = new Size(345, 80);
            pnlBathroomBanner.TabIndex = 58;
            // 
            // lblBathroomHome
            // 
            lblBathroomHome.BackColor = Color.Transparent;
            lblBathroomHome.Font = new Font("Segoe MDL2 Assets", 30F);
            lblBathroomHome.ForeColor = Color.FromArgb(150, 125, 235);
            lblBathroomHome.Location = new Point(263, 10);
            lblBathroomHome.Name = "lblBathroomHome";
            lblBathroomHome.Size = new Size(65, 58);
            lblBathroomHome.TabIndex = 59;
            lblBathroomHome.Text = "";
            // 
            // lblBathroomOnline
            // 
            lblBathroomOnline.BackColor = Color.Transparent;
            lblBathroomOnline.Font = new Font("Segoe UI", 10F);
            lblBathroomOnline.ForeColor = Color.FromArgb(111, 227, 160);
            lblBathroomOnline.Location = new Point(8, 10);
            lblBathroomOnline.Name = "lblBathroomOnline";
            lblBathroomOnline.Size = new Size(84, 24);
            lblBathroomOnline.TabIndex = 60;
            lblBathroomOnline.Text = "● Online";
            // 
            // lblBathroomName
            // 
            lblBathroomName.BackColor = Color.Transparent;
            lblBathroomName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBathroomName.ForeColor = Color.FromArgb(255, 255, 255);
            lblBathroomName.Location = new Point(14, 98);
            lblBathroomName.Name = "lblBathroomName";
            lblBathroomName.Size = new Size(174, 25);
            lblBathroomName.TabIndex = 61;
            lblBathroomName.Text = "Bathroom";
            // 
            // lblBathroomStatus
            // 
            lblBathroomStatus.BackColor = Color.Transparent;
            lblBathroomStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblBathroomStatus.ForeColor = Color.FromArgb(111, 227, 160);
            lblBathroomStatus.Location = new Point(196, 98);
            lblBathroomStatus.Name = "lblBathroomStatus";
            lblBathroomStatus.Size = new Size(100, 25);
            lblBathroomStatus.TabIndex = 62;
            lblBathroomStatus.Text = "Secure";
            // 
            // lblBathroomSubtitle
            // 
            lblBathroomSubtitle.BackColor = Color.Transparent;
            lblBathroomSubtitle.Font = new Font("Segoe UI", 9F);
            lblBathroomSubtitle.ForeColor = Color.FromArgb(169, 166, 201);
            lblBathroomSubtitle.Location = new Point(14, 137);
            lblBathroomSubtitle.Name = "lblBathroomSubtitle";
            lblBathroomSubtitle.Size = new Size(280, 20);
            lblBathroomSubtitle.TabIndex = 63;
            lblBathroomSubtitle.Text = "Personal care area";
            // 
            // pnlBathroomInfo
            // 
            pnlBathroomInfo.BackColor = Color.FromArgb(32, 28, 72);
            pnlBathroomInfo.Controls.Add(lblBathroomCameras);
            pnlBathroomInfo.Controls.Add(lblBathroomSensors);
            pnlBathroomInfo.Location = new Point(16, 174);
            pnlBathroomInfo.Name = "pnlBathroomInfo";
            pnlBathroomInfo.Size = new Size(280, 30);
            pnlBathroomInfo.TabIndex = 64;
            // 
            // lblBathroomCameras
            // 
            lblBathroomCameras.BackColor = Color.Transparent;
            lblBathroomCameras.Font = new Font("Segoe UI", 9F);
            lblBathroomCameras.ForeColor = Color.FromArgb(169, 166, 201);
            lblBathroomCameras.Location = new Point(16, 6);
            lblBathroomCameras.Name = "lblBathroomCameras";
            lblBathroomCameras.Size = new Size(118, 20);
            lblBathroomCameras.TabIndex = 65;
            lblBathroomCameras.Text = "1 Camera";
            // 
            // lblBathroomSensors
            // 
            lblBathroomSensors.BackColor = Color.Transparent;
            lblBathroomSensors.Font = new Font("Segoe UI", 9F);
            lblBathroomSensors.ForeColor = Color.FromArgb(169, 166, 201);
            lblBathroomSensors.Location = new Point(158, 6);
            lblBathroomSensors.Name = "lblBathroomSensors";
            lblBathroomSensors.Size = new Size(118, 20);
            lblBathroomSensors.TabIndex = 66;
            lblBathroomSensors.Text = "2 Sensors";
            // 
            // lblBathroomQuick
            // 
            lblBathroomQuick.BackColor = Color.Transparent;
            lblBathroomQuick.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblBathroomQuick.ForeColor = Color.FromArgb(255, 255, 255);
            lblBathroomQuick.Location = new Point(14, 215);
            lblBathroomQuick.Name = "lblBathroomQuick";
            lblBathroomQuick.Size = new Size(161, 20);
            lblBathroomQuick.TabIndex = 67;
            lblBathroomQuick.Text = "Quick Controls";
            // 
            // btnBathroomMotion
            // 
            btnBathroomMotion.BackColor = Color.FromArgb(40, 36, 86);
            btnBathroomMotion.Cursor = Cursors.Hand;
            btnBathroomMotion.FlatAppearance.BorderSize = 0;
            btnBathroomMotion.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 56, 124);
            btnBathroomMotion.FlatStyle = FlatStyle.Flat;
            btnBathroomMotion.Font = new Font("Segoe UI", 8F);
            btnBathroomMotion.ForeColor = Color.White;
            btnBathroomMotion.Location = new Point(16, 252);
            btnBathroomMotion.Name = "btnBathroomMotion";
            btnBathroomMotion.Size = new Size(64, 58);
            btnBathroomMotion.TabIndex = 68;
            btnBathroomMotion.Tag = "Bathroom";
            btnBathroomMotion.Text = "Motion\r\nClear";
            btnBathroomMotion.UseVisualStyleBackColor = false;
            btnBathroomMotion.Click += btnMotion_Click;
            // 
            // btnBathroomDoor
            // 
            btnBathroomDoor.BackColor = Color.FromArgb(40, 36, 86);
            btnBathroomDoor.Cursor = Cursors.Hand;
            btnBathroomDoor.FlatAppearance.BorderSize = 0;
            btnBathroomDoor.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 56, 124);
            btnBathroomDoor.FlatStyle = FlatStyle.Flat;
            btnBathroomDoor.Font = new Font("Segoe UI", 8F);
            btnBathroomDoor.ForeColor = Color.White;
            btnBathroomDoor.Location = new Point(104, 252);
            btnBathroomDoor.Name = "btnBathroomDoor";
            btnBathroomDoor.Size = new Size(64, 58);
            btnBathroomDoor.TabIndex = 69;
            btnBathroomDoor.Tag = "Bathroom";
            btnBathroomDoor.Text = "Door\r\nClosed";
            btnBathroomDoor.UseVisualStyleBackColor = false;
            btnBathroomDoor.Click += btnDoor_Click;
            // 
            // btnBathroomCamera
            // 
            btnBathroomCamera.BackColor = Color.FromArgb(124, 77, 255);
            btnBathroomCamera.Cursor = Cursors.Hand;
            btnBathroomCamera.FlatAppearance.BorderSize = 0;
            btnBathroomCamera.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 56, 124);
            btnBathroomCamera.FlatStyle = FlatStyle.Flat;
            btnBathroomCamera.Font = new Font("Segoe UI", 8F);
            btnBathroomCamera.ForeColor = Color.White;
            btnBathroomCamera.Location = new Point(196, 252);
            btnBathroomCamera.Name = "btnBathroomCamera";
            btnBathroomCamera.Size = new Size(64, 58);
            btnBathroomCamera.TabIndex = 70;
            btnBathroomCamera.Tag = "Bathroom";
            btnBathroomCamera.Text = "Camera\r\nActive";
            btnBathroomCamera.UseVisualStyleBackColor = false;
            btnBathroomCamera.Click += btnCamera_Click;
            // 
            // btnBathroomReset
            // 
            btnBathroomReset.BackColor = Color.FromArgb(40, 36, 86);
            btnBathroomReset.Cursor = Cursors.Hand;
            btnBathroomReset.FlatAppearance.BorderSize = 0;
            btnBathroomReset.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 56, 124);
            btnBathroomReset.FlatStyle = FlatStyle.Flat;
            btnBathroomReset.Font = new Font("Segoe UI", 8F);
            btnBathroomReset.ForeColor = Color.White;
            btnBathroomReset.Location = new Point(281, 252);
            btnBathroomReset.Name = "btnBathroomReset";
            btnBathroomReset.Size = new Size(72, 58);
            btnBathroomReset.TabIndex = 71;
            btnBathroomReset.Tag = "Bathroom";
            btnBathroomReset.Text = "More\r\nReset";
            btnBathroomReset.UseVisualStyleBackColor = false;
            btnBathroomReset.Click += btnReset_Click;
            // 
            // zoneGarage
            // 
            zoneGarage.BackColor = Color.FromArgb(26, 22, 62);
            zoneGarage.Controls.Add(pnlGarageBanner);
            zoneGarage.Controls.Add(lblGarageName);
            zoneGarage.Controls.Add(lblGarageStatus);
            zoneGarage.Controls.Add(lblGarageSubtitle);
            zoneGarage.Controls.Add(pnlGarageInfo);
            zoneGarage.Controls.Add(lblGarageQuick);
            zoneGarage.Controls.Add(btnGarageMotion);
            zoneGarage.Controls.Add(btnGarageDoor);
            zoneGarage.Controls.Add(btnGarageCamera);
            zoneGarage.Controls.Add(btnGarageReset);
            zoneGarage.Location = new Point(24, 455);
            zoneGarage.Name = "zoneGarage";
            zoneGarage.Size = new Size(365, 323);
            zoneGarage.TabIndex = 72;
            // 
            // pnlGarageBanner
            // 
            pnlGarageBanner.BackColor = Color.FromArgb(58, 42, 123);
            pnlGarageBanner.Controls.Add(lblGarageHome);
            pnlGarageBanner.Controls.Add(lblGarageOnline);
            pnlGarageBanner.Location = new Point(8, 8);
            pnlGarageBanner.Name = "pnlGarageBanner";
            pnlGarageBanner.Size = new Size(344, 80);
            pnlGarageBanner.TabIndex = 73;
            // 
            // lblGarageHome
            // 
            lblGarageHome.BackColor = Color.Transparent;
            lblGarageHome.Font = new Font("Segoe MDL2 Assets", 30F);
            lblGarageHome.ForeColor = Color.FromArgb(150, 125, 235);
            lblGarageHome.Location = new Point(263, 10);
            lblGarageHome.Name = "lblGarageHome";
            lblGarageHome.Size = new Size(65, 58);
            lblGarageHome.TabIndex = 74;
            lblGarageHome.Text = "";
            // 
            // lblGarageOnline
            // 
            lblGarageOnline.BackColor = Color.Transparent;
            lblGarageOnline.Font = new Font("Segoe UI", 10F);
            lblGarageOnline.ForeColor = Color.FromArgb(111, 227, 160);
            lblGarageOnline.Location = new Point(16, 22);
            lblGarageOnline.Name = "lblGarageOnline";
            lblGarageOnline.Size = new Size(84, 24);
            lblGarageOnline.TabIndex = 75;
            lblGarageOnline.Text = "● Online";
            // 
            // lblGarageName
            // 
            lblGarageName.BackColor = Color.Transparent;
            lblGarageName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblGarageName.ForeColor = Color.FromArgb(255, 255, 255);
            lblGarageName.Location = new Point(14, 98);
            lblGarageName.Name = "lblGarageName";
            lblGarageName.Size = new Size(174, 38);
            lblGarageName.TabIndex = 76;
            lblGarageName.Text = "Garage";
            // 
            // lblGarageStatus
            // 
            lblGarageStatus.BackColor = Color.Transparent;
            lblGarageStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblGarageStatus.ForeColor = Color.FromArgb(111, 227, 160);
            lblGarageStatus.Location = new Point(196, 98);
            lblGarageStatus.Name = "lblGarageStatus";
            lblGarageStatus.Size = new Size(100, 25);
            lblGarageStatus.TabIndex = 77;
            lblGarageStatus.Text = "Secure";
            // 
            // lblGarageSubtitle
            // 
            lblGarageSubtitle.BackColor = Color.Transparent;
            lblGarageSubtitle.Font = new Font("Segoe UI", 9F);
            lblGarageSubtitle.ForeColor = Color.FromArgb(169, 166, 201);
            lblGarageSubtitle.Location = new Point(14, 136);
            lblGarageSubtitle.Name = "lblGarageSubtitle";
            lblGarageSubtitle.Size = new Size(280, 20);
            lblGarageSubtitle.TabIndex = 78;
            lblGarageSubtitle.Text = "Parking and storage area";
            // 
            // pnlGarageInfo
            // 
            pnlGarageInfo.BackColor = Color.FromArgb(32, 28, 72);
            pnlGarageInfo.Controls.Add(lblGarageCameras);
            pnlGarageInfo.Controls.Add(lblGarageSensors);
            pnlGarageInfo.Location = new Point(14, 167);
            pnlGarageInfo.Name = "pnlGarageInfo";
            pnlGarageInfo.Size = new Size(280, 30);
            pnlGarageInfo.TabIndex = 79;
            // 
            // lblGarageCameras
            // 
            lblGarageCameras.BackColor = Color.Transparent;
            lblGarageCameras.Font = new Font("Segoe UI", 9F);
            lblGarageCameras.ForeColor = Color.FromArgb(169, 166, 201);
            lblGarageCameras.Location = new Point(16, 6);
            lblGarageCameras.Name = "lblGarageCameras";
            lblGarageCameras.Size = new Size(118, 20);
            lblGarageCameras.TabIndex = 80;
            lblGarageCameras.Text = "1 Camera";
            // 
            // lblGarageSensors
            // 
            lblGarageSensors.BackColor = Color.Transparent;
            lblGarageSensors.Font = new Font("Segoe UI", 9F);
            lblGarageSensors.ForeColor = Color.FromArgb(169, 166, 201);
            lblGarageSensors.Location = new Point(158, 6);
            lblGarageSensors.Name = "lblGarageSensors";
            lblGarageSensors.Size = new Size(118, 20);
            lblGarageSensors.TabIndex = 81;
            lblGarageSensors.Text = "2 Sensors";
            // 
            // lblGarageQuick
            // 
            lblGarageQuick.BackColor = Color.Transparent;
            lblGarageQuick.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblGarageQuick.ForeColor = Color.FromArgb(255, 255, 255);
            lblGarageQuick.Location = new Point(14, 215);
            lblGarageQuick.Name = "lblGarageQuick";
            lblGarageQuick.Size = new Size(160, 20);
            lblGarageQuick.TabIndex = 82;
            lblGarageQuick.Text = "Quick Controls";
            // 
            // btnGarageMotion
            // 
            btnGarageMotion.BackColor = Color.FromArgb(40, 36, 86);
            btnGarageMotion.Cursor = Cursors.Hand;
            btnGarageMotion.FlatAppearance.BorderSize = 0;
            btnGarageMotion.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 56, 124);
            btnGarageMotion.FlatStyle = FlatStyle.Flat;
            btnGarageMotion.Font = new Font("Segoe UI", 8F);
            btnGarageMotion.ForeColor = Color.White;
            btnGarageMotion.Location = new Point(14, 250);
            btnGarageMotion.Name = "btnGarageMotion";
            btnGarageMotion.Size = new Size(64, 58);
            btnGarageMotion.TabIndex = 83;
            btnGarageMotion.Tag = "Garage";
            btnGarageMotion.Text = "Motion\r\nClear";
            btnGarageMotion.UseVisualStyleBackColor = false;
            btnGarageMotion.Click += btnMotion_Click;
            // 
            // btnGarageDoor
            // 
            btnGarageDoor.BackColor = Color.FromArgb(40, 36, 86);
            btnGarageDoor.Cursor = Cursors.Hand;
            btnGarageDoor.FlatAppearance.BorderSize = 0;
            btnGarageDoor.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 56, 124);
            btnGarageDoor.FlatStyle = FlatStyle.Flat;
            btnGarageDoor.Font = new Font("Segoe UI", 8F);
            btnGarageDoor.ForeColor = Color.White;
            btnGarageDoor.Location = new Point(101, 250);
            btnGarageDoor.Name = "btnGarageDoor";
            btnGarageDoor.Size = new Size(73, 58);
            btnGarageDoor.TabIndex = 84;
            btnGarageDoor.Tag = "Garage";
            btnGarageDoor.Text = "Door\r\nClosed";
            btnGarageDoor.UseVisualStyleBackColor = false;
            btnGarageDoor.Click += btnDoor_Click;
            // 
            // btnGarageCamera
            // 
            btnGarageCamera.BackColor = Color.FromArgb(124, 77, 255);
            btnGarageCamera.Cursor = Cursors.Hand;
            btnGarageCamera.FlatAppearance.BorderSize = 0;
            btnGarageCamera.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 56, 124);
            btnGarageCamera.FlatStyle = FlatStyle.Flat;
            btnGarageCamera.Font = new Font("Segoe UI", 8F);
            btnGarageCamera.ForeColor = Color.White;
            btnGarageCamera.Location = new Point(196, 250);
            btnGarageCamera.Name = "btnGarageCamera";
            btnGarageCamera.Size = new Size(64, 58);
            btnGarageCamera.TabIndex = 85;
            btnGarageCamera.Tag = "Garage";
            btnGarageCamera.Text = "Camera\r\nActive";
            btnGarageCamera.UseVisualStyleBackColor = false;
            btnGarageCamera.Click += btnCamera_Click;
            // 
            // btnGarageReset
            // 
            btnGarageReset.BackColor = Color.FromArgb(40, 36, 86);
            btnGarageReset.Cursor = Cursors.Hand;
            btnGarageReset.FlatAppearance.BorderSize = 0;
            btnGarageReset.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 56, 124);
            btnGarageReset.FlatStyle = FlatStyle.Flat;
            btnGarageReset.Font = new Font("Segoe UI", 8F);
            btnGarageReset.ForeColor = Color.White;
            btnGarageReset.Location = new Point(280, 250);
            btnGarageReset.Name = "btnGarageReset";
            btnGarageReset.Size = new Size(64, 58);
            btnGarageReset.TabIndex = 86;
            btnGarageReset.Tag = "Garage";
            btnGarageReset.Text = "More\r\nReset";
            btnGarageReset.UseVisualStyleBackColor = false;
            btnGarageReset.Click += btnReset_Click;
            // 
            // cardAlarm
            // 
            cardAlarm.BackColor = Color.FromArgb(26, 22, 62);
            cardAlarm.Controls.Add(lblAlarmCaption);
            cardAlarm.Controls.Add(lblAlarmState);
            cardAlarm.Controls.Add(lblAlarmHint);
            cardAlarm.Controls.Add(btnArm);
            cardAlarm.Controls.Add(btnDisarm);
            cardAlarm.Controls.Add(chkAutoSim);
            cardAlarm.Location = new Point(1195, 455);
            cardAlarm.Name = "cardAlarm";
            cardAlarm.Size = new Size(349, 323);
            cardAlarm.TabIndex = 87;
            // 
            // lblAlarmCaption
            // 
            lblAlarmCaption.BackColor = Color.Transparent;
            lblAlarmCaption.Font = new Font("Segoe UI", 10F);
            lblAlarmCaption.ForeColor = Color.FromArgb(169, 166, 201);
            lblAlarmCaption.Location = new Point(18, 14);
            lblAlarmCaption.Name = "lblAlarmCaption";
            lblAlarmCaption.Size = new Size(270, 22);
            lblAlarmCaption.TabIndex = 88;
            lblAlarmCaption.Text = "Alarm status";
            // 
            // lblAlarmState
            // 
            lblAlarmState.BackColor = Color.Transparent;
            lblAlarmState.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblAlarmState.ForeColor = Color.FromArgb(111, 227, 160);
            lblAlarmState.Location = new Point(18, 52);
            lblAlarmState.Name = "lblAlarmState";
            lblAlarmState.Size = new Size(286, 50);
            lblAlarmState.TabIndex = 89;
            lblAlarmState.Text = "Disarmed";
            // 
            // lblAlarmHint
            // 
            lblAlarmHint.BackColor = Color.Transparent;
            lblAlarmHint.Font = new Font("Segoe UI", 9.5F);
            lblAlarmHint.ForeColor = Color.FromArgb(169, 166, 201);
            lblAlarmHint.Location = new Point(18, 119);
            lblAlarmHint.Name = "lblAlarmHint";
            lblAlarmHint.Size = new Size(272, 56);
            lblAlarmHint.TabIndex = 90;
            lblAlarmHint.Text = "System is not monitoring. Press Arm to start.";
            // 
            // btnArm
            // 
            btnArm.BackColor = Color.FromArgb(124, 77, 255);
            btnArm.Cursor = Cursors.Hand;
            btnArm.FlatAppearance.BorderSize = 0;
            btnArm.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 56, 124);
            btnArm.FlatStyle = FlatStyle.Flat;
            btnArm.Font = new Font("Segoe UI", 8F);
            btnArm.ForeColor = Color.White;
            btnArm.Location = new Point(14, 197);
            btnArm.Name = "btnArm";
            btnArm.Size = new Size(131, 44);
            btnArm.TabIndex = 91;
            btnArm.Tag = "";
            btnArm.Text = "Arm";
            btnArm.UseVisualStyleBackColor = false;
            btnArm.Click += btnArm_Click;
            // 
            // btnDisarm
            // 
            btnDisarm.BackColor = Color.FromArgb(40, 36, 86);
            btnDisarm.Cursor = Cursors.Hand;
            btnDisarm.FlatAppearance.BorderSize = 0;
            btnDisarm.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 56, 124);
            btnDisarm.FlatStyle = FlatStyle.Flat;
            btnDisarm.Font = new Font("Segoe UI", 8F);
            btnDisarm.ForeColor = Color.White;
            btnDisarm.Location = new Point(173, 196);
            btnDisarm.Name = "btnDisarm";
            btnDisarm.Size = new Size(133, 45);
            btnDisarm.TabIndex = 92;
            btnDisarm.Tag = "";
            btnDisarm.Text = "Disarm";
            btnDisarm.UseVisualStyleBackColor = false;
            btnDisarm.Click += btnDisarm_Click;
            // 
            // chkAutoSim
            // 
            chkAutoSim.ForeColor = Color.White;
            chkAutoSim.Location = new Point(14, 268);
            chkAutoSim.Name = "chkAutoSim";
            chkAutoSim.Size = new Size(270, 24);
            chkAutoSim.TabIndex = 93;
            chkAutoSim.Text = "Auto simulate events";
            chkAutoSim.CheckedChanged += chkAutoSim_CheckedChanged;
            // 
            // pnlsys
            // 
            pnlsys.BorderStyle = BorderStyle.FixedSingle;
            pnlsys.Controls.Add(btnsystem);
            pnlsys.Controls.Add(pnl6);
            pnlsys.Controls.Add(lblnet);
            pnlsys.Controls.Add(pnl7);
            pnlsys.Controls.Add(pnl5);
            pnlsys.Controls.Add(lblpower);
            pnlsys.Controls.Add(pnlTrack);
            pnlsys.Controls.Add(pnl9);
            pnlsys.Controls.Add(lblsecurity);
            pnlsys.Controls.Add(lbl66);
            pnlsys.Location = new Point(468, 447);
            pnlsys.Name = "pnlsys";
            pnlsys.Size = new Size(650, 331);
            pnlsys.TabIndex = 27;
            // 
            // btnsystem
            // 
            btnsystem.BackColor = Color.Green;
            btnsystem.Font = new Font("Segoe UI", 10F);
            btnsystem.ForeColor = Color.White;
            btnsystem.Location = new Point(205, 265);
            btnsystem.Name = "btnsystem";
            btnsystem.Size = new Size(175, 40);
            btnsystem.TabIndex = 33;
            btnsystem.Text = "System Diagnostics ";
            btnsystem.UseVisualStyleBackColor = false;
            btnsystem.Click += btnsystem_Click;
            // 
            // pnl6
            // 
            pnl6.BorderStyle = BorderStyle.FixedSingle;
            pnl6.Controls.Add(panel6);
            pnl6.Location = new Point(408, 236);
            pnl6.Name = "pnl6";
            pnl6.Size = new Size(180, 23);
            pnl6.TabIndex = 32;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 192, 0);
            panel6.Location = new Point(-1, -1);
            panel6.Name = "panel6";
            panel6.Size = new Size(46, 23);
            panel6.TabIndex = 28;
            // 
            // lblnet
            // 
            lblnet.Font = new Font("Segoe UI", 10F);
            lblnet.Location = new Point(17, 236);
            lblnet.Name = "lblnet";
            lblnet.Size = new Size(149, 23);
            lblnet.TabIndex = 31;
            lblnet.Text = "Network strength";
            // 
            // pnl7
            // 
            pnl7.BackColor = Color.DarkGray;
            pnl7.Location = new Point(17, 204);
            pnl7.Name = "pnl7";
            pnl7.Size = new Size(608, 11);
            pnl7.TabIndex = 30;
            // 
            // pnl5
            // 
            pnl5.BorderStyle = BorderStyle.FixedSingle;
            pnl5.Controls.Add(panel3);
            pnl5.Location = new Point(408, 159);
            pnl5.Name = "pnl5";
            pnl5.Size = new Size(180, 23);
            pnl5.TabIndex = 29;
            pnl5.Paint += panel1_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 192, 0);
            panel3.Location = new Point(-3, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(87, 23);
            panel3.TabIndex = 28;
            // 
            // lblpower
            // 
            lblpower.Font = new Font("Segoe UI", 10F);
            lblpower.Location = new Point(17, 159);
            lblpower.Name = "lblpower";
            lblpower.Size = new Size(124, 23);
            lblpower.TabIndex = 28;
            lblpower.Text = "Power Resevo ";
            // 
            // pnlTrack
            // 
            pnlTrack.BorderStyle = BorderStyle.FixedSingle;
            pnlTrack.Controls.Add(pnlfill);
            pnlTrack.Location = new Point(408, 74);
            pnlTrack.Name = "pnlTrack";
            pnlTrack.Size = new Size(180, 23);
            pnlTrack.TabIndex = 27;
            // 
            // pnlfill
            // 
            pnlfill.BackColor = Color.FromArgb(0, 192, 0);
            pnlfill.Location = new Point(-1, -1);
            pnlfill.Name = "pnlfill";
            pnlfill.Size = new Size(120, 23);
            pnlfill.TabIndex = 28;
            // 
            // pnl9
            // 
            pnl9.BackColor = Color.DarkGray;
            pnl9.Location = new Point(17, 132);
            pnl9.Name = "pnl9";
            pnl9.Size = new Size(608, 11);
            pnl9.TabIndex = 2;
            // 
            // lblsecurity
            // 
            lblsecurity.Font = new Font("Segoe UI", 14F);
            lblsecurity.Location = new Point(17, 26);
            lblsecurity.Name = "lblsecurity";
            lblsecurity.Size = new Size(311, 36);
            lblsecurity.TabIndex = 1;
            lblsecurity.Text = "System Health Overview";
            // 
            // lbl66
            // 
            lbl66.AutoSize = true;
            lbl66.Font = new Font("Segoe UI", 10F);
            lbl66.Location = new Point(17, 86);
            lbl66.Name = "lbl66";
            lbl66.Size = new Size(138, 23);
            lbl66.TabIndex = 0;
            lbl66.Text = "System Integrity ";
            // 
            // col4
            // 
            col4.HeaderText = "Status";
            col4.MinimumWidth = 6;
            col4.Name = "col4";
            col4.Width = 125;
            // 
            // col3
            // 
            col3.HeaderText = "Location";
            col3.MinimumWidth = 6;
            col3.Name = "col3";
            col3.Width = 125;
            // 
            // col2
            // 
            col2.HeaderText = "Event";
            col2.MinimumWidth = 6;
            col2.Name = "col2";
            col2.Width = 125;
            // 
            // col1
            // 
            col1.HeaderText = "Time";
            col1.MinimumWidth = 6;
            col1.Name = "col1";
            col1.Width = 125;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbl95);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lbl58);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lbldaily);
            panel1.Controls.Add(lbl88);
            panel1.Location = new Point(24, 794);
            panel1.Name = "panel1";
            panel1.Size = new Size(870, 259);
            panel1.TabIndex = 88;
            // 
            // lbl88
            // 
            lbl88.BackColor = Color.Transparent;
            lbl88.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl88.ForeColor = Color.FromArgb(255, 255, 255);
            lbl88.Location = new Point(30, 27);
            lbl88.Name = "lbl88";
            lbl88.Size = new Size(278, 38);
            lbl88.TabIndex = 77;
            lbl88.Text = "Daily Security Overview ";
            // 
            // lbldaily
            // 
            lbldaily.BackColor = Color.Transparent;
            lbldaily.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbldaily.ForeColor = Color.FromArgb(255, 255, 255);
            lbldaily.Location = new Point(333, 39);
            lbldaily.Name = "lbldaily";
            lbldaily.Size = new Size(278, 207);
            lbldaily.TabIndex = 78;
            lbldaily.Text = "Total Events Today\r\n\r\nSecurity Alerts\r\n\r\nSystem Health\r\n\r\nOveralls System Security\r\n\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(52, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 116);
            pictureBox1.TabIndex = 79;
            pictureBox1.TabStop = false;
            // 
            // lbl58
            // 
            lbl58.BackColor = Color.Transparent;
            lbl58.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl58.ForeColor = Color.FromArgb(0, 192, 0);
            lbl58.Location = new Point(571, 39);
            lbl58.Name = "lbl58";
            lbl58.Size = new Size(278, 207);
            lbl58.TabIndex = 80;
            lbl58.Text = "18\r\n\r\n0\r\n\r\nOptimal\r\n";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(588, 212);
            panel2.Name = "panel2";
            panel2.Size = new Size(180, 23);
            panel2.TabIndex = 81;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 192, 0);
            panel4.Location = new Point(-3, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(164, 23);
            panel4.TabIndex = 28;
            // 
            // lbl95
            // 
            lbl95.BackColor = Color.Transparent;
            lbl95.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lbl95.ForeColor = Color.Lime;
            lbl95.Location = new Point(774, 210);
            lbl95.Name = "lbl95";
            lbl95.Size = new Size(75, 25);
            lbl95.TabIndex = 82;
            lbl95.Text = "95 ";
            // 
            // SecurityUserControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            BackColor = Color.FromArgb(14, 12, 38);
            Controls.Add(panel1);
            Controls.Add(pnlsys);
            Controls.Add(lblPageIcon);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(cardStatAlarm);
            Controls.Add(cardStatZones);
            Controls.Add(cardStatEvents);
            Controls.Add(zoneLiving);
            Controls.Add(zoneBedroom);
            Controls.Add(zoneKitchen);
            Controls.Add(zoneBathroom);
            Controls.Add(zoneGarage);
            Controls.Add(cardAlarm);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.White;
            Name = "SecurityUserControl";
            Size = new Size(1603, 1056);
            cardStatAlarm.ResumeLayout(false);
            cardStatZones.ResumeLayout(false);
            cardStatEvents.ResumeLayout(false);
            zoneLiving.ResumeLayout(false);
            pnlLivingBanner.ResumeLayout(false);
            pnlLivingInfo.ResumeLayout(false);
            zoneBedroom.ResumeLayout(false);
            pnlBedroomBanner.ResumeLayout(false);
            pnlBedroomInfo.ResumeLayout(false);
            zoneKitchen.ResumeLayout(false);
            pnlKitchenBanner.ResumeLayout(false);
            pnlKitchenInfo.ResumeLayout(false);
            zoneBathroom.ResumeLayout(false);
            pnlBathroomBanner.ResumeLayout(false);
            pnlBathroomInfo.ResumeLayout(false);
            zoneGarage.ResumeLayout(false);
            pnlGarageBanner.ResumeLayout(false);
            pnlGarageInfo.ResumeLayout(false);
            cardAlarm.ResumeLayout(false);
            pnlsys.ResumeLayout(false);
            pnlsys.PerformLayout();
            pnl6.ResumeLayout(false);
            pnl5.ResumeLayout(false);
            pnlTrack.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Timer tmrAuto;
        private System.Windows.Forms.Timer tmrUi;
        private Label lblPageIcon;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel cardStatAlarm;
        private Label lblStatAlarm;
        private Label lblStatAlarmCaption;
        private Panel cardStatZones;
        private Label lblStatZones;
        private Label lblStatZonesCaption;
        private Panel cardStatEvents;
        private Label lblStatEvents;
        private Label lblStatEventsCaption;
        private Panel zoneLiving;
        private Panel pnlLivingBanner;
        private Label lblLivingHome;
        private Label lblLivingOnline;
        private Label lblLivingName;
        private Label lblLivingStatus;
        private Label lblLivingSubtitle;
        private Panel pnlLivingInfo;
        private Label lblLivingCameras;
        private Label lblLivingSensors;
        private Label lblLivingQuick;
        private Button btnLivingMotion;
        private Button btnLivingDoor;
        private Button btnLivingCamera;
        private Button btnLivingReset;
        private Panel zoneBedroom;
        private Panel pnlBedroomBanner;
        private Label lblBedroomHome;
        private Label lblBedroomOnline;
        private Label lblBedroomName;
        private Label lblBedroomStatus;
        private Label lblBedroomSubtitle;
        private Panel pnlBedroomInfo;
        private Label lblBedroomCameras;
        private Label lblBedroomSensors;
        private Label lblBedroomQuick;
        private Button btnBedroomMotion;
        private Button btnBedroomDoor;
        private Button btnBedroomCamera;
        private Button btnBedroomReset;
        private Panel zoneKitchen;
        private Panel pnlKitchenBanner;
        private Label lblKitchenHome;
        private Label lblKitchenOnline;
        private Label lblKitchenName;
        private Label lblKitchenStatus;
        private Label lblKitchenSubtitle;
        private Panel pnlKitchenInfo;
        private Label lblKitchenCameras;
        private Label lblKitchenSensors;
        private Label lblKitchenQuick;
        private Button btnKitchenMotion;
        private Button btnKitchenDoor;
        private Button btnKitchenCamera;
        private Button btnKitchenReset;
        private Panel zoneBathroom;
        private Panel pnlBathroomBanner;
        private Label lblBathroomHome;
        private Label lblBathroomOnline;
        private Label lblBathroomName;
        private Label lblBathroomStatus;
        private Label lblBathroomSubtitle;
        private Panel pnlBathroomInfo;
        private Label lblBathroomCameras;
        private Label lblBathroomSensors;
        private Label lblBathroomQuick;
        private Button btnBathroomMotion;
        private Button btnBathroomDoor;
        private Button btnBathroomCamera;
        private Button btnBathroomReset;
        private Panel zoneGarage;
        private Panel pnlGarageBanner;
        private Label lblGarageHome;
        private Label lblGarageOnline;
        private Label lblGarageName;
        private Label lblGarageStatus;
        private Label lblGarageSubtitle;
        private Panel pnlGarageInfo;
        private Label lblGarageCameras;
        private Label lblGarageSensors;
        private Label lblGarageQuick;
        private Button btnGarageMotion;
        private Button btnGarageDoor;
        private Button btnGarageCamera;
        private Button btnGarageReset;
        private Panel cardAlarm;
        private Label lblAlarmCaption;
        private Label lblAlarmState;
        private Label lblAlarmHint;
        private Button btnArm;
        private Button btnDisarm;
        private CheckBox chkAutoSim;
        
        private Panel pnlsys;
        private Label lbl66;
        private Label lblsecurity;
        private Panel pnl9;
        private Panel pnlfill;
        private Panel pnlTrack;
        private Label lblpower;
        private Panel pnl6;
        private Panel panel6;
        private Label lblnet;
        private Panel pnl7;
        private Panel pnl5;
        private Panel panel3;
        private Button btnsystem;
        private DataGridViewTextBoxColumn col4;
        private DataGridViewTextBoxColumn col3;
        private DataGridViewTextBoxColumn col2;
        private DataGridViewTextBoxColumn col1;
        private Panel panel1;
        private Label lbldaily;
        private Label lbl88;
        private PictureBox pictureBox1;
        private Label lbl95;
        private Panel panel2;
        private Panel panel4;
        private Label lbl58;
    }
    internal partial class SecurityAlarmPopup
    {
        private System.ComponentModel.IContainer popupComponents = null;
        private System.Windows.Forms.Timer popupTimer;
        private Label lblPopupIcon;
        private Label lblPopupTitle;
        private Label lblPopupMessage;
        private Button btnDismiss;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                popupComponents?.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            popupComponents = new System.ComponentModel.Container();
            popupTimer = new System.Windows.Forms.Timer(popupComponents);
            lblPopupIcon = new Label();
            lblPopupTitle = new Label();
            lblPopupMessage = new Label();
            btnDismiss = new Button();
            SuspendLayout();
            popupTimer.Interval = 8000;
            popupTimer.Tick += popupTimer_Tick;
            lblPopupIcon.AutoSize = true;
            lblPopupIcon.Text = "\uE7BA";
            lblPopupIcon.Font = new Font("Segoe MDL2 Assets", 26F);
            lblPopupIcon.ForeColor = Color.FromArgb(255, 107, 107);
            lblPopupIcon.Location = new Point(22, 20);
            lblPopupIcon.Name = "lblPopupIcon";
            lblPopupTitle.AutoSize = true;
            lblPopupTitle.Text = "Intrusion detected!";
            lblPopupTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPopupTitle.ForeColor = Color.White;
            lblPopupTitle.Location = new Point(74, 20);
            lblPopupTitle.Name = "lblPopupTitle";
            lblPopupMessage.Text = "Source:";
            lblPopupMessage.Font = new Font("Segoe UI", 10F);
            lblPopupMessage.ForeColor = Color.FromArgb(169, 166, 201);
            lblPopupMessage.Location = new Point(76, 56);
            lblPopupMessage.Size = new Size(280, 50);
            lblPopupMessage.Name = "lblPopupMessage";
            btnDismiss.Text = "Dismiss";
            btnDismiss.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDismiss.ForeColor = Color.White;
            btnDismiss.BackColor = Color.FromArgb(124, 77, 255);
            btnDismiss.FlatStyle = FlatStyle.Flat;
            btnDismiss.FlatAppearance.BorderSize = 0;
            btnDismiss.Location = new Point(22, 120);
            btnDismiss.Size = new Size(336, 44);
            btnDismiss.Name = "btnDismiss";
            btnDismiss.Click += btnDismiss_Click;
            AutoScaleMode = AutoScaleMode.None;
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterParent;
            ShowInTaskbar = false;
            KeyPreview = true;
            BackColor = Color.FromArgb(26, 22, 62);
            ClientSize = new Size(380, 190);
            Name = "SecurityAlarmPopup";
            Controls.Add(lblPopupIcon);
            Controls.Add(lblPopupTitle);
            Controls.Add(lblPopupMessage);
            Controls.Add(btnDismiss);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
