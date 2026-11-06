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
            btnCameraDetails = new Button();
            lblCameraStatus = new Label();
            lblCameraRoom = new Label();
            lblCameraName = new Label();
            pnlCurtains = new Panel();
            btnview4 = new Button();
            lblonline4 = new Label();
            lblliving4 = new Label();
            lblSmartCurtains = new Label();
            pnlBackyardCamera = new Panel();
            btnview6 = new Button();
            lblOffline = new Label();
            lblGarden = new Label();
            lblBackyardCamera = new Label();
            pnlSmartLock = new Panel();
            btnview = new Button();
            lblonline = new Label();
            lblenterence2 = new Label();
            lblsmartdoor = new Label();
            pnlSmartPlug = new Panel();
            btnview5 = new Button();
            lblonline5 = new Label();
            lblsamrtplug = new Label();
            lblSmartPlug = new Label();
            pnlGarage = new Panel();
            btnview3 = new Button();
            lblonline3 = new Label();
            lblGarage = new Label();
            lblGarageDoor = new Label();
            pnlOfflineDevices.SuspendLayout();
            pnlTotalDevices.SuspendLayout();
            pnlOnlineDevices.SuspendLayout();
            pnlCamera.SuspendLayout();
            pnlCurtains.SuspendLayout();
            pnlBackyardCamera.SuspendLayout();
            pnlSmartLock.SuspendLayout();
            pnlSmartPlug.SuspendLayout();
            pnlGarage.SuspendLayout();
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
            btnAddDevice.FlatStyle = FlatStyle.Flat;
            btnAddDevice.Location = new Point(850, 25);
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
            pnlOfflineDevices.Location = new Point(725, 110);
            pnlOfflineDevices.Name = "pnlOfflineDevices";
            pnlOfflineDevices.Size = new Size(325, 100);
            pnlOfflineDevices.TabIndex = 5;
            // 
            // lblOfflineText
            // 
            lblOfflineText.AutoSize = true;
            lblOfflineText.Location = new Point(136, 67);
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
            lblOfflineCount.Location = new Point(136, 14);
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
            pnlTotalDevices.Size = new Size(325, 100);
            pnlTotalDevices.TabIndex = 6;
            // 
            // lblTotalText
            // 
            lblTotalText.AutoSize = true;
            lblTotalText.Location = new Point(110, 66);
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
            lblTotalCount.Location = new Point(135, 11);
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
            pnlOnlineDevices.Location = new Point(375, 110);
            pnlOnlineDevices.Name = "pnlOnlineDevices";
            pnlOnlineDevices.Size = new Size(325, 100);
            pnlOnlineDevices.TabIndex = 7;
            // 
            // lblOnlineText
            // 
            lblOnlineText.AutoSize = true;
            lblOnlineText.Location = new Point(139, 66);
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
            lblOnlineCount.Location = new Point(139, 13);
            lblOnlineCount.Name = "lblOnlineCount";
            lblOnlineCount.Size = new Size(35, 41);
            lblOnlineCount.TabIndex = 3;
            lblOnlineCount.Text = "5";
            lblOnlineCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCamera
            // 
            pnlCamera.BackColor = Color.FromArgb(32, 38, 77);
            pnlCamera.Controls.Add(btnCameraDetails);
            pnlCamera.Controls.Add(lblCameraStatus);
            pnlCamera.Controls.Add(lblCameraRoom);
            pnlCamera.Controls.Add(lblCameraName);
            pnlCamera.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlCamera.Location = new Point(25, 263);
            pnlCamera.Name = "pnlCamera";
            pnlCamera.Size = new Size(500, 155);
            pnlCamera.TabIndex = 8;
            // 
            // btnCameraDetails
            // 
            btnCameraDetails.BackColor = Color.FromArgb(112, 72, 220);
            btnCameraDetails.Cursor = Cursors.Hand;
            btnCameraDetails.FlatAppearance.BorderSize = 0;
            btnCameraDetails.FlatStyle = FlatStyle.Flat;
            btnCameraDetails.Location = new Point(360, 99);
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
            lblCameraStatus.Location = new Point(26, 95);
            lblCameraStatus.Name = "lblCameraStatus";
            lblCameraStatus.Size = new Size(75, 23);
            lblCameraStatus.TabIndex = 2;
            lblCameraStatus.Text = "● Online";
            // 
            // lblCameraRoom
            // 
            lblCameraRoom.AutoSize = true;
            lblCameraRoom.Location = new Point(26, 55);
            lblCameraRoom.Name = "lblCameraRoom";
            lblCameraRoom.Size = new Size(77, 23);
            lblCameraRoom.TabIndex = 1;
            lblCameraRoom.Text = "Entrance";
            // 
            // lblCameraName
            // 
            lblCameraName.AutoSize = true;
            lblCameraName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCameraName.Location = new Point(26, 20);
            lblCameraName.Name = "lblCameraName";
            lblCameraName.Size = new Size(192, 28);
            lblCameraName.TabIndex = 0;
            lblCameraName.Text = "Front Door Camera";
            // 
            // pnlCurtains
            // 
            pnlCurtains.BackColor = Color.FromArgb(32, 38, 77);
            pnlCurtains.Controls.Add(btnview4);
            pnlCurtains.Controls.Add(lblonline4);
            pnlCurtains.Controls.Add(lblliving4);
            pnlCurtains.Controls.Add(lblSmartCurtains);
            pnlCurtains.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlCurtains.Location = new Point(550, 434);
            pnlCurtains.Name = "pnlCurtains";
            pnlCurtains.Size = new Size(500, 155);
            pnlCurtains.TabIndex = 9;
            // 
            // btnview4
            // 
            btnview4.BackColor = Color.FromArgb(112, 72, 220);
            btnview4.Cursor = Cursors.Hand;
            btnview4.FlatAppearance.BorderSize = 0;
            btnview4.FlatStyle = FlatStyle.Flat;
            btnview4.Location = new Point(360, 100);
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
            lblonline4.Location = new Point(46, 100);
            lblonline4.Name = "lblonline4";
            lblonline4.Size = new Size(75, 23);
            lblonline4.TabIndex = 6;
            lblonline4.Text = "● Online";
            // 
            // lblliving4
            // 
            lblliving4.AutoSize = true;
            lblliving4.Location = new Point(46, 60);
            lblliving4.Name = "lblliving4";
            lblliving4.Size = new Size(104, 23);
            lblliving4.TabIndex = 5;
            lblliving4.Text = "Living Room";
            // 
            // lblSmartCurtains
            // 
            lblSmartCurtains.AutoSize = true;
            lblSmartCurtains.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSmartCurtains.Location = new Point(46, 25);
            lblSmartCurtains.Name = "lblSmartCurtains";
            lblSmartCurtains.Size = new Size(154, 28);
            lblSmartCurtains.TabIndex = 4;
            lblSmartCurtains.Text = "Smart Curtains";
            // 
            // pnlBackyardCamera
            // 
            pnlBackyardCamera.BackColor = Color.FromArgb(32, 38, 77);
            pnlBackyardCamera.Controls.Add(btnview6);
            pnlBackyardCamera.Controls.Add(lblOffline);
            pnlBackyardCamera.Controls.Add(lblGarden);
            pnlBackyardCamera.Controls.Add(lblBackyardCamera);
            pnlBackyardCamera.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlBackyardCamera.Location = new Point(550, 611);
            pnlBackyardCamera.Name = "pnlBackyardCamera";
            pnlBackyardCamera.Size = new Size(500, 155);
            pnlBackyardCamera.TabIndex = 9;
            // 
            // btnview6
            // 
            btnview6.BackColor = Color.FromArgb(112, 72, 220);
            btnview6.Cursor = Cursors.Hand;
            btnview6.FlatAppearance.BorderSize = 0;
            btnview6.FlatStyle = FlatStyle.Flat;
            btnview6.Location = new Point(360, 100);
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
            lblOffline.Location = new Point(46, 100);
            lblOffline.Name = "lblOffline";
            lblOffline.Size = new Size(75, 23);
            lblOffline.TabIndex = 6;
            lblOffline.Text = "● Offline";
            // 
            // lblGarden
            // 
            lblGarden.AutoSize = true;
            lblGarden.Location = new Point(46, 60);
            lblGarden.Name = "lblGarden";
            lblGarden.Size = new Size(66, 23);
            lblGarden.TabIndex = 5;
            lblGarden.Text = "Garden";
            // 
            // lblBackyardCamera
            // 
            lblBackyardCamera.AutoSize = true;
            lblBackyardCamera.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBackyardCamera.Location = new Point(46, 25);
            lblBackyardCamera.Name = "lblBackyardCamera";
            lblBackyardCamera.Size = new Size(176, 28);
            lblBackyardCamera.TabIndex = 4;
            lblBackyardCamera.Text = "Backyard Camera";
            // 
            // pnlSmartLock
            // 
            pnlSmartLock.BackColor = Color.FromArgb(32, 38, 77);
            pnlSmartLock.Controls.Add(btnview);
            pnlSmartLock.Controls.Add(lblonline);
            pnlSmartLock.Controls.Add(lblenterence2);
            pnlSmartLock.Controls.Add(lblsmartdoor);
            pnlSmartLock.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlSmartLock.Location = new Point(550, 263);
            pnlSmartLock.Name = "pnlSmartLock";
            pnlSmartLock.Size = new Size(500, 155);
            pnlSmartLock.TabIndex = 9;
            // 
            // btnview
            // 
            btnview.BackColor = Color.FromArgb(112, 72, 220);
            btnview.Cursor = Cursors.Hand;
            btnview.FlatAppearance.BorderSize = 0;
            btnview.FlatStyle = FlatStyle.Flat;
            btnview.Location = new Point(360, 100);
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
            lblonline.Location = new Point(46, 100);
            lblonline.Name = "lblonline";
            lblonline.Size = new Size(65, 20);
            lblonline.TabIndex = 6;
            lblonline.Text = "● Online";
            // 
            // lblenterence2
            // 
            lblenterence2.AutoSize = true;
            lblenterence2.Location = new Point(46, 60);
            lblenterence2.Name = "lblenterence2";
            lblenterence2.Size = new Size(66, 20);
            lblenterence2.TabIndex = 5;
            lblenterence2.Text = "Entrance";
            // 
            // lblsmartdoor
            // 
            lblsmartdoor.AutoSize = true;
            lblsmartdoor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblsmartdoor.Location = new Point(46, 25);
            lblsmartdoor.Name = "lblsmartdoor";
            lblsmartdoor.Size = new Size(171, 28);
            lblsmartdoor.TabIndex = 4;
            lblsmartdoor.Text = "Smart Door Lock";
            // 
            // pnlSmartPlug
            // 
            pnlSmartPlug.BackColor = Color.FromArgb(32, 38, 77);
            pnlSmartPlug.Controls.Add(btnview5);
            pnlSmartPlug.Controls.Add(lblonline5);
            pnlSmartPlug.Controls.Add(lblsamrtplug);
            pnlSmartPlug.Controls.Add(lblSmartPlug);
            pnlSmartPlug.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlSmartPlug.Location = new Point(25, 611);
            pnlSmartPlug.Name = "pnlSmartPlug";
            pnlSmartPlug.Size = new Size(500, 155);
            pnlSmartPlug.TabIndex = 9;
            // 
            // btnview5
            // 
            btnview5.BackColor = Color.FromArgb(112, 72, 220);
            btnview5.Cursor = Cursors.Hand;
            btnview5.FlatAppearance.BorderSize = 0;
            btnview5.FlatStyle = FlatStyle.Flat;
            btnview5.Location = new Point(360, 100);
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
            lblonline5.Location = new Point(46, 100);
            lblonline5.Name = "lblonline5";
            lblonline5.Size = new Size(75, 23);
            lblonline5.TabIndex = 6;
            lblonline5.Text = "● Online";
            // 
            // lblsamrtplug
            // 
            lblsamrtplug.AutoSize = true;
            lblsamrtplug.Location = new Point(46, 60);
            lblsamrtplug.Name = "lblsamrtplug";
            lblsamrtplug.Size = new Size(80, 23);
            lblsamrtplug.TabIndex = 5;
            lblsamrtplug.Text = "Bedroom";
            // 
            // lblSmartPlug
            // 
            lblSmartPlug.AutoSize = true;
            lblSmartPlug.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSmartPlug.Location = new Point(26, 25);
            lblSmartPlug.Name = "lblSmartPlug";
            lblSmartPlug.Size = new Size(117, 28);
            lblSmartPlug.TabIndex = 4;
            lblSmartPlug.Text = "Smart Plug";
            // 
            // pnlGarage
            // 
            pnlGarage.BackColor = Color.FromArgb(32, 38, 77);
            pnlGarage.Controls.Add(btnview3);
            pnlGarage.Controls.Add(lblonline3);
            pnlGarage.Controls.Add(lblGarage);
            pnlGarage.Controls.Add(lblGarageDoor);
            pnlGarage.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlGarage.Location = new Point(25, 434);
            pnlGarage.Name = "pnlGarage";
            pnlGarage.Size = new Size(500, 155);
            pnlGarage.TabIndex = 9;
            // 
            // btnview3
            // 
            btnview3.BackColor = Color.FromArgb(112, 72, 220);
            btnview3.Cursor = Cursors.Hand;
            btnview3.FlatAppearance.BorderSize = 0;
            btnview3.FlatStyle = FlatStyle.Flat;
            btnview3.Location = new Point(360, 100);
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
            lblonline3.Location = new Point(46, 100);
            lblonline3.Name = "lblonline3";
            lblonline3.Size = new Size(75, 23);
            lblonline3.TabIndex = 6;
            lblonline3.Text = "● Online";
            // 
            // lblGarage
            // 
            lblGarage.AutoSize = true;
            lblGarage.Location = new Point(46, 60);
            lblGarage.Name = "lblGarage";
            lblGarage.Size = new Size(65, 23);
            lblGarage.TabIndex = 5;
            lblGarage.Text = "Garage";
            // 
            // lblGarageDoor
            // 
            lblGarageDoor.AutoSize = true;
            lblGarageDoor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGarageDoor.Location = new Point(26, 25);
            lblGarageDoor.Name = "lblGarageDoor";
            lblGarageDoor.Size = new Size(132, 28);
            lblGarageDoor.TabIndex = 4;
            lblGarageDoor.Text = "Garage Door";
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
            pnlCurtains.ResumeLayout(false);
            pnlCurtains.PerformLayout();
            pnlBackyardCamera.ResumeLayout(false);
            pnlBackyardCamera.PerformLayout();
            pnlSmartLock.ResumeLayout(false);
            pnlSmartLock.PerformLayout();
            pnlSmartPlug.ResumeLayout(false);
            pnlSmartPlug.PerformLayout();
            pnlGarage.ResumeLayout(false);
            pnlGarage.PerformLayout();
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
    }
}
