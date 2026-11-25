namespace WinFormsApp2.UserControls
{
    partial class DevicesControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevicesControl));
            lblDevicesTitle = new Label();
            lblDevicesSubtitle = new Label();
            btnAddDevice = new Button();
            pnlOfflineDevices = new Panel();
            lblOfflineText = new Label();
            lblOfflineCount = new Label();
            pnlTotalDevices = new Panel();
            lblTotalText = new Label();
            lblTotalCount = new Label();
            pnlOnlineDevices = new Panel();
            lblOnlineText = new Label();
            lblOnlineCount = new Label();
            pnlCamera = new Panel();
            piccamera1 = new PictureBox();
            btnCameraDetails = new Button();
            lblCameraStatus = new Label();
            lblCameraRoom = new Label();
            lblCameraName = new Label();
            btnDeleteDevice0 = new Button();
            pnlCurtains = new Panel();
            picsmartcurtins = new PictureBox();
            btnview4 = new Button();
            lblonline4 = new Label();
            lblliving4 = new Label();
            lblSmartCurtains = new Label();
            btnDeleteDevice3 = new Button();
            pnlBackyardCamera = new Panel();
            picbackyard = new PictureBox();
            btnview6 = new Button();
            lblOffline = new Label();
            lblGarden = new Label();
            lblBackyardCamera = new Label();
            btnDeleteDevice5 = new Button();
            pnlSmartLock = new Panel();
            picdoorlock = new PictureBox();
            btnview = new Button();
            lblonline = new Label();
            lblenterence2 = new Label();
            lblsmartdoor = new Label();
            btnDeleteDevice1 = new Button();
            pnlSmartPlug = new Panel();
            picsmartplug1 = new PictureBox();
            btnview5 = new Button();
            lblonline5 = new Label();
            lblsamrtplug = new Label();
            lblSmartPlug = new Label();
            btnDeleteDevice4 = new Button();
            pnlGarage = new Panel();
            picphoto3 = new PictureBox();
            btnview3 = new Button();
            lblonline3 = new Label();
            lblGarage = new Label();
            lblGarageDoor = new Label();
            btnDeleteDevice2 = new Button();
            pnlOfflineDevices.SuspendLayout();
            pnlTotalDevices.SuspendLayout();
            pnlOnlineDevices.SuspendLayout();
            pnlCamera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)piccamera1).BeginInit();
            pnlCurtains.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picsmartcurtins).BeginInit();
            pnlBackyardCamera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picbackyard).BeginInit();
            pnlSmartLock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picdoorlock).BeginInit();
            pnlSmartPlug.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picsmartplug1).BeginInit();
            pnlGarage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picphoto3).BeginInit();
            SuspendLayout();
            // 
            // lblDevicesTitle
            // 
            lblDevicesTitle.AutoSize = true;
            lblDevicesTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDevicesTitle.Location = new Point(25, 20);
            lblDevicesTitle.Name = "lblDevicesTitle";
            lblDevicesTitle.Size = new Size(177, 41);
            lblDevicesTitle.TabIndex = 1;
            lblDevicesTitle.Text = "My Devices";
            // 
            // lblDevicesSubtitle
            // 
            lblDevicesSubtitle.AutoSize = true;
            lblDevicesSubtitle.Location = new Point(25, 60);
            lblDevicesSubtitle.Name = "lblDevicesSubtitle";
            lblDevicesSubtitle.Size = new Size(349, 20);
            lblDevicesSubtitle.TabIndex = 2;
            lblDevicesSubtitle.Text = "Monitor and manage your connected smart devices";
            // 
            // btnAddDevice
            // 
            btnAddDevice.BackColor = Color.FromArgb(112, 72, 220);
            btnAddDevice.FlatAppearance.BorderSize = 0;
            btnAddDevice.FlatStyle = FlatStyle.Flat;
            btnAddDevice.Location = new Point(1401, 42);
            btnAddDevice.Name = "btnAddDevice";
            btnAddDevice.Size = new Size(150, 38);
            btnAddDevice.TabIndex = 3;
            btnAddDevice.Text = "+ Add Device";
            btnAddDevice.UseVisualStyleBackColor = false;
            btnAddDevice.Click += btnAddDevice_Click;
            // 
            // pnlOfflineDevices
            // 
            pnlOfflineDevices.BackColor = Color.FromArgb(36, 43, 86);
            pnlOfflineDevices.Controls.Add(lblOfflineText);
            pnlOfflineDevices.Controls.Add(lblOfflineCount);
            pnlOfflineDevices.Location = new Point(1085, 110);
            pnlOfflineDevices.Name = "pnlOfflineDevices";
            pnlOfflineDevices.Size = new Size(465, 100);
            pnlOfflineDevices.TabIndex = 5;
            // 
            // lblOfflineText
            // 
            lblOfflineText.AutoSize = true;
            lblOfflineText.Location = new Point(213, 67);
            lblOfflineText.Name = "lblOfflineText";
            lblOfflineText.Size = new Size(54, 20);
            lblOfflineText.TabIndex = 6;
            lblOfflineText.Text = "Offline";
            lblOfflineText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOfflineCount
            // 
            lblOfflineCount.AutoSize = true;
            lblOfflineCount.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOfflineCount.Location = new Point(222, 13);
            lblOfflineCount.Name = "lblOfflineCount";
            lblOfflineCount.Size = new Size(35, 41);
            lblOfflineCount.TabIndex = 5;
            lblOfflineCount.Text = "1";
            lblOfflineCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTotalDevices
            // 
            pnlTotalDevices.BackColor = Color.FromArgb(36, 43, 86);
            pnlTotalDevices.Controls.Add(lblTotalText);
            pnlTotalDevices.Controls.Add(lblTotalCount);
            pnlTotalDevices.Location = new Point(25, 110);
            pnlTotalDevices.Name = "pnlTotalDevices";
            pnlTotalDevices.Size = new Size(465, 100);
            pnlTotalDevices.TabIndex = 6;
            // 
            // lblTotalText
            // 
            lblTotalText.AutoSize = true;
            lblTotalText.Location = new Point(183, 67);
            lblTotalText.Name = "lblTotalText";
            lblTotalText.Size = new Size(97, 20);
            lblTotalText.TabIndex = 2;
            lblTotalText.Text = "Total Devices";
            lblTotalText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalCount
            // 
            lblTotalCount.AutoSize = true;
            lblTotalCount.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCount.Location = new Point(213, 13);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(35, 41);
            lblTotalCount.TabIndex = 0;
            lblTotalCount.Text = "6";
            lblTotalCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlOnlineDevices
            // 
            pnlOnlineDevices.BackColor = Color.FromArgb(36, 43, 86);
            pnlOnlineDevices.Controls.Add(lblOnlineText);
            pnlOnlineDevices.Controls.Add(lblOnlineCount);
            pnlOnlineDevices.Location = new Point(555, 110);
            pnlOnlineDevices.Name = "pnlOnlineDevices";
            pnlOnlineDevices.Size = new Size(465, 100);
            pnlOnlineDevices.TabIndex = 7;
            // 
            // lblOnlineText
            // 
            lblOnlineText.AutoSize = true;
            lblOnlineText.Location = new Point(175, 67);
            lblOnlineText.Name = "lblOnlineText";
            lblOnlineText.Size = new Size(52, 20);
            lblOnlineText.TabIndex = 4;
            lblOnlineText.Text = "Online";
            lblOnlineText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOnlineCount
            // 
            lblOnlineCount.AutoSize = true;
            lblOnlineCount.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOnlineCount.Location = new Point(192, 13);
            lblOnlineCount.Name = "lblOnlineCount";
            lblOnlineCount.Size = new Size(35, 41);
            lblOnlineCount.TabIndex = 3;
            lblOnlineCount.Text = "5";
            lblOnlineCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCamera
            // 
            pnlCamera.BackColor = Color.FromArgb(32, 38, 77);
            pnlCamera.Controls.Add(piccamera1);
            pnlCamera.Controls.Add(btnCameraDetails);
            pnlCamera.Controls.Add(lblCameraStatus);
            pnlCamera.Controls.Add(lblCameraRoom);
            pnlCamera.Controls.Add(lblCameraName);
            pnlCamera.Controls.Add(btnDeleteDevice0);
            pnlCamera.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlCamera.Location = new Point(25, 263);
            pnlCamera.Name = "pnlCamera";
            pnlCamera.Size = new Size(714, 155);
            pnlCamera.TabIndex = 8;
            // 
            // piccamera1
            // 
            piccamera1.Image = (Image)resources.GetObject("piccamera1.Image");
            piccamera1.Location = new Point(13, 14);
            piccamera1.Name = "piccamera1";
            piccamera1.Size = new Size(183, 138);
            piccamera1.SizeMode = PictureBoxSizeMode.Zoom;
            piccamera1.TabIndex = 4;
            piccamera1.TabStop = false;
            // 
            // btnCameraDetails
            // 
            btnCameraDetails.BackColor = Color.FromArgb(112, 72, 220);
            btnCameraDetails.Cursor = Cursors.Hand;
            btnCameraDetails.FlatAppearance.BorderSize = 0;
            btnCameraDetails.FlatStyle = FlatStyle.Flat;
            btnCameraDetails.Location = new Point(484, 103);
            btnCameraDetails.Name = "btnCameraDetails";
            btnCameraDetails.Size = new Size(94, 29);
            btnCameraDetails.TabIndex = 3;
            btnCameraDetails.Tag = "Camera";
            btnCameraDetails.Text = "View Details";
            btnCameraDetails.UseVisualStyleBackColor = false;
            btnCameraDetails.Click += btnViewDevice_Click;
            // 
            // lblCameraStatus
            // 
            lblCameraStatus.AutoSize = true;
            lblCameraStatus.ForeColor = Color.FromArgb(90, 220, 150);
            lblCameraStatus.Location = new Point(247, 101);
            lblCameraStatus.Name = "lblCameraStatus";
            lblCameraStatus.Size = new Size(75, 23);
            lblCameraStatus.TabIndex = 2;
            lblCameraStatus.Text = "● Online";
            // 
            // lblCameraRoom
            // 
            lblCameraRoom.AutoSize = true;
            lblCameraRoom.Location = new Point(247, 47);
            lblCameraRoom.Name = "lblCameraRoom";
            lblCameraRoom.Size = new Size(77, 23);
            lblCameraRoom.TabIndex = 1;
            lblCameraRoom.Text = "Entrance";
            // 
            // lblCameraName
            // 
            lblCameraName.AutoSize = true;
            lblCameraName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCameraName.Location = new Point(247, 16);
            lblCameraName.Name = "lblCameraName";
            lblCameraName.Size = new Size(192, 28);
            lblCameraName.TabIndex = 0;
            lblCameraName.Text = "Front Door Camera";
            // 
            // btnDeleteDevice0
            // 
            btnDeleteDevice0.BackColor = Color.FromArgb(192, 45, 55);
            btnDeleteDevice0.FlatAppearance.BorderSize = 0;
            btnDeleteDevice0.FlatStyle = FlatStyle.Flat;
            btnDeleteDevice0.ForeColor = Color.White;
            btnDeleteDevice0.Location = new Point(612, 100);
            btnDeleteDevice0.Name = "btnDeleteDevice0";
            btnDeleteDevice0.Size = new Size(70, 29);
            btnDeleteDevice0.TabIndex = 20;
            btnDeleteDevice0.Text = "Delete";
            btnDeleteDevice0.UseVisualStyleBackColor = false;
            btnDeleteDevice0.Click += DeleteDevice_Click;
            // 
            // pnlCurtains
            // 
            pnlCurtains.BackColor = Color.FromArgb(32, 38, 77);
            pnlCurtains.Controls.Add(picsmartcurtins);
            pnlCurtains.Controls.Add(btnview4);
            pnlCurtains.Controls.Add(lblonline4);
            pnlCurtains.Controls.Add(lblliving4);
            pnlCurtains.Controls.Add(lblSmartCurtains);
            pnlCurtains.Controls.Add(btnDeleteDevice3);
            pnlCurtains.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlCurtains.Location = new Point(837, 434);
            pnlCurtains.Name = "pnlCurtains";
            pnlCurtains.Size = new Size(714, 155);
            pnlCurtains.TabIndex = 9;
            // 
            // picsmartcurtins
            // 
            picsmartcurtins.Image = (Image)resources.GetObject("picsmartcurtins.Image");
            picsmartcurtins.Location = new Point(19, 12);
            picsmartcurtins.Name = "picsmartcurtins";
            picsmartcurtins.Size = new Size(164, 143);
            picsmartcurtins.SizeMode = PictureBoxSizeMode.Zoom;
            picsmartcurtins.TabIndex = 10;
            picsmartcurtins.TabStop = false;
            // 
            // btnview4
            // 
            btnview4.BackColor = Color.FromArgb(112, 72, 220);
            btnview4.Cursor = Cursors.Hand;
            btnview4.FlatAppearance.BorderSize = 0;
            btnview4.FlatStyle = FlatStyle.Flat;
            btnview4.Location = new Point(485, 103);
            btnview4.Name = "btnview4";
            btnview4.Size = new Size(94, 29);
            btnview4.TabIndex = 7;
            btnview4.Tag = "Curtains";
            btnview4.Text = "View Details";
            btnview4.UseVisualStyleBackColor = false;
            btnview4.Click += btnViewDevice_Click;
            // 
            // lblonline4
            // 
            lblonline4.AutoSize = true;
            lblonline4.ForeColor = Color.FromArgb(90, 220, 150);
            lblonline4.Location = new Point(239, 109);
            lblonline4.Name = "lblonline4";
            lblonline4.Size = new Size(75, 23);
            lblonline4.TabIndex = 6;
            lblonline4.Text = "● Online";
            // 
            // lblliving4
            // 
            lblliving4.AutoSize = true;
            lblliving4.Location = new Point(239, 49);
            lblliving4.Name = "lblliving4";
            lblliving4.Size = new Size(104, 23);
            lblliving4.TabIndex = 5;
            lblliving4.Text = "Living Room";
            // 
            // lblSmartCurtains
            // 
            lblSmartCurtains.AutoSize = true;
            lblSmartCurtains.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSmartCurtains.Location = new Point(239, 21);
            lblSmartCurtains.Name = "lblSmartCurtains";
            lblSmartCurtains.Size = new Size(154, 28);
            lblSmartCurtains.TabIndex = 4;
            lblSmartCurtains.Text = "Smart Curtains";
            // 
            // btnDeleteDevice3
            // 
            btnDeleteDevice3.BackColor = Color.FromArgb(192, 45, 55);
            btnDeleteDevice3.FlatAppearance.BorderSize = 0;
            btnDeleteDevice3.FlatStyle = FlatStyle.Flat;
            btnDeleteDevice3.ForeColor = Color.White;
            btnDeleteDevice3.Location = new Point(610, 100);
            btnDeleteDevice3.Name = "btnDeleteDevice3";
            btnDeleteDevice3.Size = new Size(70, 29);
            btnDeleteDevice3.TabIndex = 20;
            btnDeleteDevice3.Text = "Delete";
            btnDeleteDevice3.UseVisualStyleBackColor = false;
            btnDeleteDevice3.Click += DeleteDevice_Click;
            // 
            // pnlBackyardCamera
            // 
            pnlBackyardCamera.BackColor = Color.FromArgb(32, 38, 77);
            pnlBackyardCamera.Controls.Add(picbackyard);
            pnlBackyardCamera.Controls.Add(btnview6);
            pnlBackyardCamera.Controls.Add(lblOffline);
            pnlBackyardCamera.Controls.Add(lblGarden);
            pnlBackyardCamera.Controls.Add(lblBackyardCamera);
            pnlBackyardCamera.Controls.Add(btnDeleteDevice5);
            pnlBackyardCamera.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlBackyardCamera.Location = new Point(837, 611);
            pnlBackyardCamera.Name = "pnlBackyardCamera";
            pnlBackyardCamera.Size = new Size(714, 155);
            pnlBackyardCamera.TabIndex = 9;
            // 
            // picbackyard
            // 
            picbackyard.Image = (Image)resources.GetObject("picbackyard.Image");
            picbackyard.Location = new Point(19, 13);
            picbackyard.Name = "picbackyard";
            picbackyard.Size = new Size(164, 139);
            picbackyard.SizeMode = PictureBoxSizeMode.Zoom;
            picbackyard.TabIndex = 8;
            picbackyard.TabStop = false;
            // 
            // btnview6
            // 
            btnview6.BackColor = Color.FromArgb(112, 72, 220);
            btnview6.Cursor = Cursors.Hand;
            btnview6.FlatAppearance.BorderSize = 0;
            btnview6.FlatStyle = FlatStyle.Flat;
            btnview6.Location = new Point(485, 100);
            btnview6.Name = "btnview6";
            btnview6.Size = new Size(94, 29);
            btnview6.TabIndex = 7;
            btnview6.Tag = "Backyard";
            btnview6.Text = "View Details";
            btnview6.UseVisualStyleBackColor = false;
            btnview6.Click += btnViewDevice_Click;
            // 
            // lblOffline
            // 
            lblOffline.AutoSize = true;
            lblOffline.ForeColor = Color.FromArgb(240, 120, 120);
            lblOffline.Location = new Point(239, 112);
            lblOffline.Name = "lblOffline";
            lblOffline.Size = new Size(75, 23);
            lblOffline.TabIndex = 6;
            lblOffline.Text = "● Offline";
            // 
            // lblGarden
            // 
            lblGarden.AutoSize = true;
            lblGarden.Location = new Point(239, 52);
            lblGarden.Name = "lblGarden";
            lblGarden.Size = new Size(66, 23);
            lblGarden.TabIndex = 5;
            lblGarden.Text = "Garden";
            // 
            // lblBackyardCamera
            // 
            lblBackyardCamera.AutoSize = true;
            lblBackyardCamera.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBackyardCamera.Location = new Point(239, 24);
            lblBackyardCamera.Name = "lblBackyardCamera";
            lblBackyardCamera.Size = new Size(176, 28);
            lblBackyardCamera.TabIndex = 4;
            lblBackyardCamera.Text = "Backyard Camera";
            // 
            // btnDeleteDevice5
            // 
            btnDeleteDevice5.BackColor = Color.FromArgb(192, 45, 55);
            btnDeleteDevice5.FlatAppearance.BorderSize = 0;
            btnDeleteDevice5.FlatStyle = FlatStyle.Flat;
            btnDeleteDevice5.ForeColor = Color.White;
            btnDeleteDevice5.Location = new Point(610, 100);
            btnDeleteDevice5.Name = "btnDeleteDevice5";
            btnDeleteDevice5.Size = new Size(70, 29);
            btnDeleteDevice5.TabIndex = 20;
            btnDeleteDevice5.Text = "Delete";
            btnDeleteDevice5.UseVisualStyleBackColor = false;
            btnDeleteDevice5.Click += DeleteDevice_Click;
            // 
            // pnlSmartLock
            // 
            pnlSmartLock.BackColor = Color.FromArgb(32, 38, 77);
            pnlSmartLock.Controls.Add(picdoorlock);
            pnlSmartLock.Controls.Add(btnview);
            pnlSmartLock.Controls.Add(lblonline);
            pnlSmartLock.Controls.Add(lblenterence2);
            pnlSmartLock.Controls.Add(lblsmartdoor);
            pnlSmartLock.Controls.Add(btnDeleteDevice1);
            pnlSmartLock.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlSmartLock.Location = new Point(837, 263);
            pnlSmartLock.Name = "pnlSmartLock";
            pnlSmartLock.Size = new Size(714, 155);
            pnlSmartLock.TabIndex = 9;
            // 
            // picdoorlock
            // 
            picdoorlock.Image = (Image)resources.GetObject("picdoorlock.Image");
            picdoorlock.Location = new Point(19, 7);
            picdoorlock.Name = "picdoorlock";
            picdoorlock.Size = new Size(164, 145);
            picdoorlock.SizeMode = PictureBoxSizeMode.Zoom;
            picdoorlock.TabIndex = 10;
            picdoorlock.TabStop = false;
            // 
            // btnview
            // 
            btnview.BackColor = Color.FromArgb(112, 72, 220);
            btnview.Cursor = Cursors.Hand;
            btnview.FlatAppearance.BorderSize = 0;
            btnview.FlatStyle = FlatStyle.Flat;
            btnview.Location = new Point(485, 104);
            btnview.Name = "btnview";
            btnview.Size = new Size(94, 29);
            btnview.TabIndex = 7;
            btnview.Tag = "Lock";
            btnview.Text = "View Details";
            btnview.UseVisualStyleBackColor = false;
            btnview.Click += btnViewDevice_Click;
            // 
            // lblonline
            // 
            lblonline.AutoSize = true;
            lblonline.ForeColor = Color.FromArgb(90, 220, 150);
            lblonline.Location = new Point(248, 110);
            lblonline.Name = "lblonline";
            lblonline.Size = new Size(65, 20);
            lblonline.TabIndex = 6;
            lblonline.Text = "● Online";
            // 
            // lblenterence2
            // 
            lblenterence2.AutoSize = true;
            lblenterence2.Location = new Point(239, 55);
            lblenterence2.Name = "lblenterence2";
            lblenterence2.Size = new Size(66, 20);
            lblenterence2.TabIndex = 5;
            lblenterence2.Text = "Entrance";
            // 
            // lblsmartdoor
            // 
            lblsmartdoor.AutoSize = true;
            lblsmartdoor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblsmartdoor.Location = new Point(239, 27);
            lblsmartdoor.Name = "lblsmartdoor";
            lblsmartdoor.Size = new Size(171, 28);
            lblsmartdoor.TabIndex = 4;
            lblsmartdoor.Text = "Smart Door Lock";
            // 
            // btnDeleteDevice1
            // 
            btnDeleteDevice1.BackColor = Color.FromArgb(192, 45, 55);
            btnDeleteDevice1.FlatAppearance.BorderSize = 0;
            btnDeleteDevice1.FlatStyle = FlatStyle.Flat;
            btnDeleteDevice1.ForeColor = Color.White;
            btnDeleteDevice1.Location = new Point(610, 101);
            btnDeleteDevice1.Name = "btnDeleteDevice1";
            btnDeleteDevice1.Size = new Size(70, 29);
            btnDeleteDevice1.TabIndex = 20;
            btnDeleteDevice1.Text = "Delete";
            btnDeleteDevice1.UseVisualStyleBackColor = false;
            btnDeleteDevice1.Click += DeleteDevice_Click;
            // 
            // pnlSmartPlug
            // 
            pnlSmartPlug.BackColor = Color.FromArgb(32, 38, 77);
            pnlSmartPlug.Controls.Add(picsmartplug1);
            pnlSmartPlug.Controls.Add(btnview5);
            pnlSmartPlug.Controls.Add(lblonline5);
            pnlSmartPlug.Controls.Add(lblsamrtplug);
            pnlSmartPlug.Controls.Add(lblSmartPlug);
            pnlSmartPlug.Controls.Add(btnDeleteDevice4);
            pnlSmartPlug.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlSmartPlug.Location = new Point(25, 611);
            pnlSmartPlug.Name = "pnlSmartPlug";
            pnlSmartPlug.Size = new Size(714, 155);
            pnlSmartPlug.TabIndex = 9;
            // 
            // picsmartplug1
            // 
            picsmartplug1.Image = (Image)resources.GetObject("picsmartplug1.Image");
            picsmartplug1.Location = new Point(13, 13);
            picsmartplug1.Name = "picsmartplug1";
            picsmartplug1.Size = new Size(183, 122);
            picsmartplug1.SizeMode = PictureBoxSizeMode.Zoom;
            picsmartplug1.TabIndex = 9;
            picsmartplug1.TabStop = false;
            // 
            // btnview5
            // 
            btnview5.BackColor = Color.FromArgb(112, 72, 220);
            btnview5.Cursor = Cursors.Hand;
            btnview5.FlatAppearance.BorderSize = 0;
            btnview5.FlatStyle = FlatStyle.Flat;
            btnview5.Location = new Point(484, 106);
            btnview5.Name = "btnview5";
            btnview5.Size = new Size(94, 29);
            btnview5.TabIndex = 7;
            btnview5.Tag = "Plug";
            btnview5.Text = "View Details";
            btnview5.UseVisualStyleBackColor = false;
            btnview5.Click += btnViewDevice_Click;
            // 
            // lblonline5
            // 
            lblonline5.AutoSize = true;
            lblonline5.ForeColor = Color.FromArgb(90, 220, 150);
            lblonline5.Location = new Point(247, 106);
            lblonline5.Name = "lblonline5";
            lblonline5.Size = new Size(75, 23);
            lblonline5.TabIndex = 6;
            lblonline5.Text = "● Online";
            // 
            // lblsamrtplug
            // 
            lblsamrtplug.AutoSize = true;
            lblsamrtplug.Location = new Point(247, 44);
            lblsamrtplug.Name = "lblsamrtplug";
            lblsamrtplug.Size = new Size(80, 23);
            lblsamrtplug.TabIndex = 5;
            lblsamrtplug.Text = "Bedroom";
            // 
            // lblSmartPlug
            // 
            lblSmartPlug.AutoSize = true;
            lblSmartPlug.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSmartPlug.Location = new Point(247, 13);
            lblSmartPlug.Name = "lblSmartPlug";
            lblSmartPlug.Size = new Size(117, 28);
            lblSmartPlug.TabIndex = 4;
            lblSmartPlug.Text = "Smart Plug";
            // 
            // btnDeleteDevice4
            // 
            btnDeleteDevice4.BackColor = Color.FromArgb(192, 45, 55);
            btnDeleteDevice4.FlatAppearance.BorderSize = 0;
            btnDeleteDevice4.FlatStyle = FlatStyle.Flat;
            btnDeleteDevice4.ForeColor = Color.White;
            btnDeleteDevice4.Location = new Point(612, 106);
            btnDeleteDevice4.Name = "btnDeleteDevice4";
            btnDeleteDevice4.Size = new Size(70, 29);
            btnDeleteDevice4.TabIndex = 20;
            btnDeleteDevice4.Text = "Delete";
            btnDeleteDevice4.UseVisualStyleBackColor = false;
            btnDeleteDevice4.Click += DeleteDevice_Click;
            // 
            // pnlGarage
            // 
            pnlGarage.BackColor = Color.FromArgb(32, 38, 77);
            pnlGarage.Controls.Add(picphoto3);
            pnlGarage.Controls.Add(btnview3);
            pnlGarage.Controls.Add(lblonline3);
            pnlGarage.Controls.Add(lblGarage);
            pnlGarage.Controls.Add(lblGarageDoor);
            pnlGarage.Controls.Add(btnDeleteDevice2);
            pnlGarage.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlGarage.Location = new Point(25, 434);
            pnlGarage.Name = "pnlGarage";
            pnlGarage.Size = new Size(714, 155);
            pnlGarage.TabIndex = 9;
            // 
            // picphoto3
            // 
            picphoto3.Image = (Image)resources.GetObject("picphoto3.Image");
            picphoto3.Location = new Point(13, 12);
            picphoto3.Name = "picphoto3";
            picphoto3.Size = new Size(183, 131);
            picphoto3.SizeMode = PictureBoxSizeMode.Zoom;
            picphoto3.TabIndex = 8;
            picphoto3.TabStop = false;
            // 
            // btnview3
            // 
            btnview3.BackColor = Color.FromArgb(112, 72, 220);
            btnview3.Cursor = Cursors.Hand;
            btnview3.FlatAppearance.BorderSize = 0;
            btnview3.FlatStyle = FlatStyle.Flat;
            btnview3.Location = new Point(484, 100);
            btnview3.Name = "btnview3";
            btnview3.Size = new Size(94, 29);
            btnview3.TabIndex = 7;
            btnview3.Tag = "Garage";
            btnview3.Text = "View Details";
            btnview3.UseVisualStyleBackColor = false;
            btnview3.Click += btnViewDevice_Click;
            // 
            // lblonline3
            // 
            lblonline3.AutoSize = true;
            lblonline3.ForeColor = Color.FromArgb(90, 220, 150);
            lblonline3.Location = new Point(247, 106);
            lblonline3.Name = "lblonline3";
            lblonline3.Size = new Size(75, 23);
            lblonline3.TabIndex = 6;
            lblonline3.Text = "● Online";
            // 
            // lblGarage
            // 
            lblGarage.AutoSize = true;
            lblGarage.Location = new Point(247, 49);
            lblGarage.Name = "lblGarage";
            lblGarage.Size = new Size(65, 23);
            lblGarage.TabIndex = 5;
            lblGarage.Text = "Garage";
            // 
            // lblGarageDoor
            // 
            lblGarageDoor.AutoSize = true;
            lblGarageDoor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGarageDoor.Location = new Point(247, 21);
            lblGarageDoor.Name = "lblGarageDoor";
            lblGarageDoor.Size = new Size(132, 28);
            lblGarageDoor.TabIndex = 4;
            lblGarageDoor.Text = "Garage Door";
            // 
            // btnDeleteDevice2
            // 
            btnDeleteDevice2.BackColor = Color.FromArgb(192, 45, 55);
            btnDeleteDevice2.FlatAppearance.BorderSize = 0;
            btnDeleteDevice2.FlatStyle = FlatStyle.Flat;
            btnDeleteDevice2.ForeColor = Color.White;
            btnDeleteDevice2.Location = new Point(612, 100);
            btnDeleteDevice2.Name = "btnDeleteDevice2";
            btnDeleteDevice2.Size = new Size(70, 29);
            btnDeleteDevice2.TabIndex = 20;
            btnDeleteDevice2.Text = "Delete";
            btnDeleteDevice2.UseVisualStyleBackColor = false;
            btnDeleteDevice2.Click += DeleteDevice_Click;
            // 
            // DevicesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(10, 15, 38);
            Controls.Add(pnlBackyardCamera);
            Controls.Add(pnlSmartLock);
            Controls.Add(pnlSmartPlug);
            Controls.Add(pnlGarage);
            Controls.Add(pnlCurtains);
            Controls.Add(pnlCamera);
            Controls.Add(pnlOnlineDevices);
            Controls.Add(pnlTotalDevices);
            Controls.Add(pnlOfflineDevices);
            Controls.Add(btnAddDevice);
            Controls.Add(lblDevicesSubtitle);
            Controls.Add(lblDevicesTitle);
            ForeColor = Color.White;
            Name = "DevicesControl";
            Size = new Size(1603, 1056);
            pnlOfflineDevices.ResumeLayout(false);
            pnlOfflineDevices.PerformLayout();
            pnlTotalDevices.ResumeLayout(false);
            pnlTotalDevices.PerformLayout();
            pnlOnlineDevices.ResumeLayout(false);
            pnlOnlineDevices.PerformLayout();
            pnlCamera.ResumeLayout(false);
            pnlCamera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)piccamera1).EndInit();
            pnlCurtains.ResumeLayout(false);
            pnlCurtains.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picsmartcurtins).EndInit();
            pnlBackyardCamera.ResumeLayout(false);
            pnlBackyardCamera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picbackyard).EndInit();
            pnlSmartLock.ResumeLayout(false);
            pnlSmartLock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picdoorlock).EndInit();
            pnlSmartPlug.ResumeLayout(false);
            pnlSmartPlug.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picsmartplug1).EndInit();
            pnlGarage.ResumeLayout(false);
            pnlGarage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picphoto3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDevicesTitle;
        private Label lblDevicesSubtitle;
        private Button btnAddDevice;
        private Panel pnlOfflineDevices;
        private Panel pnlTotalDevices;
        private Panel pnlOnlineDevices;
        private Label lblTotalText;
        private Label lblTotalCount;
        private Label lblOnlineText;
        private Label lblOnlineCount;
        private Label lblOfflineText;
        private Label lblOfflineCount;
        private Panel pnlCamera;
        private Panel pnlCurtains;
        private Panel pnlBackyardCamera;
        private Panel pnlSmartLock;
        private Panel pnlSmartPlug;
        private Panel pnlGarage;
        private Button btnCameraDetails;
        private Label lblCameraStatus;
        private Label lblCameraRoom;
        private Label lblCameraName;
        private Button btnview4;
        private Label lblonline4;
        private Label lblliving4;
        private Label lblSmartCurtains;
        private Button btnview6;
        private Label lblOffline;
        private Label lblGarden;
        private Label lblBackyardCamera;
        private Button btnview;
        private Label lblonline;
        private Label lblenterence2;
        private Label lblsmartdoor;
        private Button btnview5;
        private Label lblonline5;
        private Label lblsamrtplug;
        private Label lblSmartPlug;
        private Button btnview3;
        private Label lblonline3;
        private Label lblGarage;
        private Label lblGarageDoor;
        private Button btnDeleteDevice0;
        private Button btnDeleteDevice1;
        private Button btnDeleteDevice2;
        private Button btnDeleteDevice3;
        private Button btnDeleteDevice4;
        private Button btnDeleteDevice5;
        private PictureBox piccamera1;
        private PictureBox picdoorlock;
        private PictureBox picphoto3;
        private PictureBox picsmartcurtins;
        private PictureBox pictureBox1;
        private PictureBox picsmartplug1;
        private PictureBox picbackyard;
    }
}
