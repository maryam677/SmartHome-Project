namespace WinFormsApp2.Popups
{
    partial class DeviceDetailsForm
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
            lblDeviceName = new Label();
            lblDeviceStatus = new Label();
            lblType = new Label();
            lblRoom = new Label();
            lblConnection = new Label();
            btnClose = new Button();
            pnlPreview = new Panel();
            lblcontrol = new Label();
            pnlPreview.SuspendLayout();
            SuspendLayout();
            // 
            // lblDeviceName
            // 
            lblDeviceName.AutoSize = true;
            lblDeviceName.Location = new Point(25, 25);
            lblDeviceName.Name = "lblDeviceName";
            lblDeviceName.Size = new Size(136, 20);
            lblDeviceName.TabIndex = 0;
            lblDeviceName.Text = "Front Door Camera";
            // 
            // lblDeviceStatus
            // 
            lblDeviceStatus.AutoSize = true;
            lblDeviceStatus.Location = new Point(25, 65);
            lblDeviceStatus.Name = "lblDeviceStatus";
            lblDeviceStatus.Size = new Size(65, 20);
            lblDeviceStatus.TabIndex = 1;
            lblDeviceStatus.Text = "● Online";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(25, 120);
            lblType.Name = "lblType";
            lblType.Size = new Size(203, 20);
            lblType.TabIndex = 2;
            lblType.Text = "Device Type: Security Camera";
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Location = new Point(25, 160);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(113, 20);
            lblRoom.TabIndex = 3;
            lblRoom.Text = "Room: Entrance";
            // 
            // lblConnection
            // 
            lblConnection.AutoSize = true;
            lblConnection.Location = new Point(25, 200);
            lblConnection.Name = "lblConnection";
            lblConnection.Size = new Size(126, 20);
            lblConnection.TabIndex = 4;
            lblConnection.Text = "Connection: Wi-Fi";
            // 
            // btnClose
            // 
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(345, 420);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // pnlPreview
            // 
            pnlPreview.BackColor = Color.FromArgb(16, 21, 47);
            pnlPreview.Controls.Add(lblcontrol);
            pnlPreview.Location = new Point(25, 250);
            pnlPreview.Name = "pnlPreview";
            pnlPreview.Size = new Size(430, 140);
            pnlPreview.TabIndex = 6;
            // 
            // lblcontrol
            // 
            lblcontrol.AutoSize = true;
            lblcontrol.Location = new Point(58, 24);
            lblcontrol.Name = "lblcontrol";
            lblcontrol.Size = new Size(228, 20);
            lblcontrol.TabIndex = 0;
            lblcontrol.Text = "preview unavailable in GUI demo";
            // 
            // DeviceDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 32, 70);
            ClientSize = new Size(462, 480);
            Controls.Add(pnlPreview);
            Controls.Add(btnClose);
            Controls.Add(lblConnection);
            Controls.Add(lblRoom);
            Controls.Add(lblType);
            Controls.Add(lblDeviceStatus);
            Controls.Add(lblDeviceName);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DeviceDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Device Details";
            pnlPreview.ResumeLayout(false);
            pnlPreview.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDeviceName;
        private Label lblDeviceStatus;
        private Label lblType;
        private Label lblRoom;
        private Label lblConnection;
        private Button btnClose;
        private Panel pnlPreview;
        private Label lblcontrol;
    }
}