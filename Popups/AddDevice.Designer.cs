namespace SmartHome
{
    partial class frmAddDevice
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
            lblav = new Label();
            lbldiv = new Label();
            txtDeviceName = new TextBox();
            lblroom = new Label();
            cmbRoom = new ComboBox();
            lbluse = new Label();
            txtEnergyUsage = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblav
            // 
            lblav.Font = new Font("Segoe UI", 14F);
            lblav.ForeColor = Color.White;
            lblav.Location = new Point(12, 25);
            lblav.Name = "lblav";
            lblav.Size = new Size(204, 36);
            lblav.TabIndex = 0;
            lblav.Text = "Add new device";
            // 
            // lbldiv
            // 
            lbldiv.Font = new Font("Segoe UI", 11F);
            lbldiv.ForeColor = Color.White;
            lbldiv.Location = new Point(12, 73);
            lbldiv.Name = "lbldiv";
            lbldiv.Size = new Size(122, 25);
            lbldiv.TabIndex = 1;
            lbldiv.Text = "Device name";
            // 
            // txtDeviceName
            // 
            txtDeviceName.BackColor = Color.FromArgb(35, 38, 66);
            txtDeviceName.ForeColor = Color.White;
            txtDeviceName.Location = new Point(12, 113);
            txtDeviceName.Name = "txtDeviceName";
            txtDeviceName.Size = new Size(331, 27);
            txtDeviceName.TabIndex = 2;
            // 
            // lblroom
            // 
            lblroom.Font = new Font("Segoe UI", 11F);
            lblroom.ForeColor = Color.White;
            lblroom.Location = new Point(12, 157);
            lblroom.Name = "lblroom";
            lblroom.Size = new Size(122, 25);
            lblroom.TabIndex = 3;
            lblroom.Text = "Room";
            // 
            // cmbRoom
            // 
            cmbRoom.BackColor = Color.FromArgb(35, 38, 66);
            cmbRoom.FlatStyle = FlatStyle.Flat;
            cmbRoom.ForeColor = Color.White;
            cmbRoom.FormattingEnabled = true;
            cmbRoom.Items.AddRange(new object[] { "Living Room", "Bedroom", "Kitchen", "Bathroom" });
            cmbRoom.Location = new Point(12, 195);
            cmbRoom.Name = "cmbRoom";
            cmbRoom.Size = new Size(331, 28);
            cmbRoom.TabIndex = 4;
            // 
            // lbluse
            // 
            lbluse.Font = new Font("Segoe UI", 11F);
            lbluse.ForeColor = Color.White;
            lbluse.Location = new Point(12, 246);
            lbluse.Name = "lbluse";
            lbluse.Size = new Size(204, 25);
            lbluse.TabIndex = 5;
            lbluse.Text = "Energy usage (kWh)";
            // 
            // txtEnergyUsage
            // 
            txtEnergyUsage.BackColor = Color.FromArgb(35, 38, 66);
            txtEnergyUsage.ForeColor = Color.White;
            txtEnergyUsage.Location = new Point(12, 285);
            txtEnergyUsage.Name = "txtEnergyUsage";
            txtEnergyUsage.Size = new Size(331, 27);
            txtEnergyUsage.TabIndex = 6;
            txtEnergyUsage.TextChanged += txtEnergyUsage_TextChanged;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(110, 86, 207);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(65, 329);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(28, 30, 54);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(240, 329);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // frmAddDevice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 19, 43);
            ClientSize = new Size(440, 380);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtEnergyUsage);
            Controls.Add(lbluse);
            Controls.Add(cmbRoom);
            Controls.Add(lblroom);
            Controls.Add(txtDeviceName);
            Controls.Add(lbldiv);
            Controls.Add(lblav);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAddDevice";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblav;
        private Label lbldiv;
        private TextBox txtDeviceName;
        private Label lblroom;
        private ComboBox cmbRoom;
        private Label lbluse;
        private TextBox txtEnergyUsage;
        private Button btnSave;
        private Button btnCancel;
    }
}