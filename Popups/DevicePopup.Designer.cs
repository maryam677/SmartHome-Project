namespace Smarthome_net9
{
    partial class DevicePopup
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
            lblname = new Label();
            lblroom = new Label();
            btnon = new Button();
            btnoff = new Button();
            btnclose = new Button();
            process1 = new System.Diagnostics.Process();
            SuspendLayout();
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.ForeColor = Color.White;
            lblname.Location = new Point(32, 9);
            lblname.Name = "lblname";
            lblname.Size = new Size(50, 20);
            lblname.TabIndex = 0;
            lblname.Text = "label1";
            // 
            // lblroom
            // 
            lblroom.AutoSize = true;
            lblroom.ForeColor = Color.White;
            lblroom.Location = new Point(32, 41);
            lblroom.Name = "lblroom";
            lblroom.Size = new Size(50, 20);
            lblroom.TabIndex = 1;
            lblroom.Text = "label2";
            // 
            // btnon
            // 
            btnon.FlatStyle = FlatStyle.Flat;
            btnon.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnon.ForeColor = Color.White;
            btnon.Location = new Point(16, 64);
            btnon.Name = "btnon";
            btnon.Size = new Size(94, 29);
            btnon.TabIndex = 2;
            btnon.Text = "ON";
            btnon.UseVisualStyleBackColor = true;
            // 
            // btnoff
            // 
            btnoff.FlatStyle = FlatStyle.Flat;
            btnoff.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnoff.ForeColor = Color.White;
            btnoff.Location = new Point(16, 99);
            btnoff.Name = "btnoff";
            btnoff.Size = new Size(94, 29);
            btnoff.TabIndex = 3;
            btnoff.Text = "OFF";
            btnoff.UseVisualStyleBackColor = true;
            // 
            // btnclose
            // 
            btnclose.DialogResult = DialogResult.Cancel;
            btnclose.FlatStyle = FlatStyle.Flat;
            btnclose.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclose.ForeColor = Color.White;
            btnclose.Location = new Point(16, 143);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(94, 29);
            btnclose.TabIndex = 4;
            btnclose.Text = "Close";
            btnclose.UseVisualStyleBackColor = true;
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UseCredentialsForNetworkingOnly = false;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // DevicePopup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 15, 38);
            ClientSize = new Size(320, 200);
            Controls.Add(btnclose);
            Controls.Add(btnoff);
            Controls.Add(btnon);
            Controls.Add(lblroom);
            Controls.Add(lblname);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DevicePopup";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Devicepopup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblname;
        private Label lblroom;
        private Button btnon;
        private Button btnoff;
        private Button btnclose;
        private System.Diagnostics.Process process1;
    }
}