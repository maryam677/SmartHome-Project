namespace WinFormsApp2.Popups
{
    partial class AddDeviceForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblName = new Label();
            lblType = new Label();
            txtDeviceName = new TextBox();
            cmbDeviceType = new ComboBox();
            lblRoom = new Label();
            cmbRoom = new ComboBox();
            lblConnection = new Label();
            cmbConnection = new ComboBox();
            btnCancel = new Button();
            btnAddDevice = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(25, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(233, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add New Device";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Location = new Point(25, 55);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(334, 23);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Connect a new device to your smart home";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(25, 105);
            lblName.Name = "lblName";
            lblName.Size = new Size(111, 23);
            lblName.TabIndex = 2;
            lblName.Text = "Device Name";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(25, 180);
            lblType.Name = "lblType";
            lblType.Size = new Size(100, 23);
            lblType.TabIndex = 3;
            lblType.Text = "Device Type";
            // 
            // txtDeviceName
            // 
            txtDeviceName.Location = new Point(25, 130);
            txtDeviceName.Name = "txtDeviceName";
            txtDeviceName.Size = new Size(425, 30);
            txtDeviceName.TabIndex = 4;
            // 
            // cmbDeviceType
            // 
            cmbDeviceType.FormattingEnabled = true;
            cmbDeviceType.Items.AddRange(new object[] { "Security Camera", "Smart Door Lock", "Garage Door", "Smart Curtains", "Smart Plug", "Smart TV", "Motion Sensor", "Smoke Detector", "Smart Speaker", "Other" });
            cmbDeviceType.Location = new Point(25, 205);
            cmbDeviceType.Name = "cmbDeviceType";
            cmbDeviceType.Size = new Size(425, 31);
            cmbDeviceType.TabIndex = 5;
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Location = new Point(25, 255);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(137, 23);
            lblRoom.TabIndex = 6;
            lblRoom.Text = "Room / Location";
            // 
            // cmbRoom
            // 
            cmbRoom.FormattingEnabled = true;
            cmbRoom.Items.AddRange(new object[] { "Living Room", "Bedroom", "Master Bedroom", "Kitchen", "Bathroom", "Entrance", "Garage", "Garden", "Backyard", "Hallway", "Home Office", "Balcony", "Other" });
            cmbRoom.Location = new Point(25, 280);
            cmbRoom.Name = "cmbRoom";
            cmbRoom.Size = new Size(425, 31);
            cmbRoom.TabIndex = 7;
            // 
            // lblConnection
            // 
            lblConnection.AutoSize = true;
            lblConnection.Location = new Point(25, 329);
            lblConnection.Name = "lblConnection";
            lblConnection.Size = new Size(138, 23);
            lblConnection.TabIndex = 8;
            lblConnection.Text = "Connection Type";
            // 
            // cmbConnection
            // 
            cmbConnection.FormattingEnabled = true;
            cmbConnection.Items.AddRange(new object[] { "Wi-Fi", "Bluetooth", "Zigbee", "Z-Wave", "Ethernet", "Other" });
            cmbConnection.Location = new Point(25, 355);
            cmbConnection.Name = "cmbConnection";
            cmbConnection.Size = new Size(425, 31);
            cmbConnection.TabIndex = 9;
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(97, 431);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 38);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddDevice
            // 
            btnAddDevice.BackColor = Color.DarkSlateBlue;
            btnAddDevice.Cursor = Cursors.Hand;
            btnAddDevice.FlatAppearance.BorderSize = 0;
            btnAddDevice.FlatStyle = FlatStyle.Flat;
            btnAddDevice.ForeColor = Color.White;
            btnAddDevice.Location = new Point(261, 431);
            btnAddDevice.Name = "btnAddDevice";
            btnAddDevice.Size = new Size(160, 38);
            btnAddDevice.TabIndex = 16;
            btnAddDevice.Text = "Add Device";
            btnAddDevice.UseVisualStyleBackColor = false;
            // 
            // AddDeviceForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 32, 70);
            ClientSize = new Size(497, 544);
            Controls.Add(btnCancel);
            Controls.Add(btnAddDevice);
            Controls.Add(cmbConnection);
            Controls.Add(lblConnection);
            Controls.Add(cmbRoom);
            Controls.Add(lblRoom);
            Controls.Add(cmbDeviceType);
            Controls.Add(txtDeviceName);
            Controls.Add(lblType);
            Controls.Add(lblName);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddDeviceForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Device";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblName;
        private Label lblType;
        private TextBox txtDeviceName;
        private ComboBox cmbDeviceType;
        private Label lblRoom;
        private ComboBox cmbRoom;
        private Label lblConnection;
        private ComboBox cmbConnection;
        private Button btnCancel;
        private Button btnAddDevice;
    }
}