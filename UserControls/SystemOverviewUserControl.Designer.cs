namespace WinFormsApp2.UserControls
{
    partial class SystemOverviewUserControl
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
            this.pnlOverview = new WinFormsApp2.Controls.RoundedPanel();
            this.lblIcon = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.gaugeBrightness = new WinFormsApp2.Controls.CircularGauge();
            this.lblOverallTitle = new System.Windows.Forms.Label();
            this.lblOverallValue = new System.Windows.Forms.Label();
            this.lblOnDot = new System.Windows.Forms.Label();
            this.lblOnRooms = new System.Windows.Forms.Label();
            this.lblOnRoomsValue = new System.Windows.Forms.Label();
            this.lblOffDot = new System.Windows.Forms.Label();
            this.lblOffRooms = new System.Windows.Forms.Label();
            this.lblOffRoomsValue = new System.Windows.Forms.Label();
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.lblTotalRooms = new System.Windows.Forms.Label();
            this.lblTotalRoomsValue = new System.Windows.Forms.Label();
            this.pnlOverview.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOverview
            // 
            this.pnlOverview.Controls.Add(this.lblIcon);
            this.pnlOverview.Controls.Add(this.lblTitle);
            this.pnlOverview.Controls.Add(this.lblSubtitle);
            this.pnlOverview.Controls.Add(this.gaugeBrightness);
            this.pnlOverview.Controls.Add(this.lblOverallTitle);
            this.pnlOverview.Controls.Add(this.lblOverallValue);
            this.pnlOverview.Controls.Add(this.lblOnDot);
            this.pnlOverview.Controls.Add(this.lblOnRooms);
            this.pnlOverview.Controls.Add(this.lblOnRoomsValue);
            this.pnlOverview.Controls.Add(this.lblOffDot);
            this.pnlOverview.Controls.Add(this.lblOffRooms);
            this.pnlOverview.Controls.Add(this.lblOffRoomsValue);
            this.pnlOverview.Controls.Add(this.pnlDivider);
            this.pnlOverview.Controls.Add(this.lblTotalRooms);
            this.pnlOverview.Controls.Add(this.lblTotalRoomsValue);
            this.pnlOverview.BackColor = System.Drawing.Color.Transparent;
            this.pnlOverview.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.pnlOverview.BorderRadius = 16;
            this.pnlOverview.BorderThickness = 1F;
            this.pnlOverview.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(21)))), ((int)(((byte)(56)))));
            this.pnlOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOverview.Location = new System.Drawing.Point(0, 0);
            this.pnlOverview.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.pnlOverview.Size = new System.Drawing.Size(332, 210);
            this.pnlOverview.Name = "pnlOverview";
            this.pnlOverview.TabIndex = 0;
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.lblIcon.Location = new System.Drawing.Point(18, 18);
            this.lblIcon.Size = new System.Drawing.Size(30, 34);
            this.lblIcon.Text = "\uE9D2";
            this.lblIcon.UseMnemonic = false;
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblTitle.Location = new System.Drawing.Point(46, 12);
            this.lblTitle.Size = new System.Drawing.Size(146, 26);
            this.lblTitle.Text = "System Overview";
            this.lblTitle.UseMnemonic = false;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.TabIndex = 1;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(161)))), ((int)(((byte)(194)))));
            this.lblSubtitle.Location = new System.Drawing.Point(47, 37);
            this.lblSubtitle.Size = new System.Drawing.Size(163, 21);
            this.lblSubtitle.Text = "Your home lighting status";
            this.lblSubtitle.UseMnemonic = false;
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.TabIndex = 2;
            // 
            // gaugeBrightness
            // 
            this.gaugeBrightness.BackColor = System.Drawing.Color.Transparent;
            this.gaugeBrightness.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.gaugeBrightness.Location = new System.Drawing.Point(18, 72);
            this.gaugeBrightness.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.gaugeBrightness.Size = new System.Drawing.Size(118, 118);
            this.gaugeBrightness.Thickness = 10;
            this.gaugeBrightness.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.gaugeBrightness.Value = 54;
            this.gaugeBrightness.Name = "gaugeBrightness";
            this.gaugeBrightness.TabIndex = 3;
            // 
            // lblOverallTitle
            // 
            this.lblOverallTitle.AutoSize = true;
            this.lblOverallTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblOverallTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOverallTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(161)))), ((int)(((byte)(194)))));
            this.lblOverallTitle.Location = new System.Drawing.Point(152, 74);
            this.lblOverallTitle.Size = new System.Drawing.Size(119, 21);
            this.lblOverallTitle.Text = "Overall Brightness";
            this.lblOverallTitle.UseMnemonic = false;
            this.lblOverallTitle.Name = "lblOverallTitle";
            this.lblOverallTitle.TabIndex = 4;
            // 
            // lblOverallValue
            // 
            this.lblOverallValue.AutoSize = false;
            this.lblOverallValue.BackColor = System.Drawing.Color.Transparent;
            this.lblOverallValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOverallValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblOverallValue.Location = new System.Drawing.Point(262, 72);
            this.lblOverallValue.Size = new System.Drawing.Size(52, 22);
            this.lblOverallValue.Text = "54%";
            this.lblOverallValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblOverallValue.UseMnemonic = false;
            this.lblOverallValue.Name = "lblOverallValue";
            this.lblOverallValue.TabIndex = 5;
            // 
            // lblOnDot
            // 
            this.lblOnDot.AutoSize = true;
            this.lblOnDot.BackColor = System.Drawing.Color.Transparent;
            this.lblOnDot.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOnDot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(230)))), ((int)(((byte)(168)))));
            this.lblOnDot.Location = new System.Drawing.Point(152, 106);
            this.lblOnDot.Size = new System.Drawing.Size(11, 19);
            this.lblOnDot.Text = "\u25CF";
            this.lblOnDot.UseMnemonic = false;
            this.lblOnDot.Name = "lblOnDot";
            this.lblOnDot.TabIndex = 6;
            // 
            // lblOnRooms
            // 
            this.lblOnRooms.AutoSize = true;
            this.lblOnRooms.BackColor = System.Drawing.Color.Transparent;
            this.lblOnRooms.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOnRooms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(161)))), ((int)(((byte)(194)))));
            this.lblOnRooms.Location = new System.Drawing.Point(170, 106);
            this.lblOnRooms.Size = new System.Drawing.Size(59, 22);
            this.lblOnRooms.Text = "On Rooms";
            this.lblOnRooms.UseMnemonic = false;
            this.lblOnRooms.Name = "lblOnRooms";
            this.lblOnRooms.TabIndex = 7;
            // 
            // lblOnRoomsValue
            // 
            this.lblOnRoomsValue.AutoSize = false;
            this.lblOnRoomsValue.BackColor = System.Drawing.Color.Transparent;
            this.lblOnRoomsValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOnRoomsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblOnRoomsValue.Location = new System.Drawing.Point(262, 104);
            this.lblOnRoomsValue.Size = new System.Drawing.Size(52, 22);
            this.lblOnRoomsValue.Text = "3";
            this.lblOnRoomsValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblOnRoomsValue.UseMnemonic = false;
            this.lblOnRoomsValue.Name = "lblOnRoomsValue";
            this.lblOnRoomsValue.TabIndex = 8;
            // 
            // lblOffDot
            // 
            this.lblOffDot.AutoSize = true;
            this.lblOffDot.BackColor = System.Drawing.Color.Transparent;
            this.lblOffDot.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOffDot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(102)))), ((int)(((byte)(144)))));
            this.lblOffDot.Location = new System.Drawing.Point(152, 134);
            this.lblOffDot.Size = new System.Drawing.Size(11, 19);
            this.lblOffDot.Text = "\u25CF";
            this.lblOffDot.UseMnemonic = false;
            this.lblOffDot.Name = "lblOffDot";
            this.lblOffDot.TabIndex = 9;
            // 
            // lblOffRooms
            // 
            this.lblOffRooms.AutoSize = true;
            this.lblOffRooms.BackColor = System.Drawing.Color.Transparent;
            this.lblOffRooms.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOffRooms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(161)))), ((int)(((byte)(194)))));
            this.lblOffRooms.Location = new System.Drawing.Point(170, 134);
            this.lblOffRooms.Size = new System.Drawing.Size(65, 22);
            this.lblOffRooms.Text = "Off Rooms";
            this.lblOffRooms.UseMnemonic = false;
            this.lblOffRooms.Name = "lblOffRooms";
            this.lblOffRooms.TabIndex = 10;
            // 
            // lblOffRoomsValue
            // 
            this.lblOffRoomsValue.AutoSize = false;
            this.lblOffRoomsValue.BackColor = System.Drawing.Color.Transparent;
            this.lblOffRoomsValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOffRoomsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblOffRoomsValue.Location = new System.Drawing.Point(262, 132);
            this.lblOffRoomsValue.Size = new System.Drawing.Size(52, 22);
            this.lblOffRoomsValue.Text = "1";
            this.lblOffRoomsValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblOffRoomsValue.UseMnemonic = false;
            this.lblOffRoomsValue.Name = "lblOffRoomsValue";
            this.lblOffRoomsValue.TabIndex = 11;
            // 
            // pnlDivider
            // 
            this.pnlDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.pnlDivider.Location = new System.Drawing.Point(152, 164);
            this.pnlDivider.Size = new System.Drawing.Size(162, 1);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.TabIndex = 12;
            // 
            // lblTotalRooms
            // 
            this.lblTotalRooms.AutoSize = true;
            this.lblTotalRooms.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalRooms.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalRooms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(161)))), ((int)(((byte)(194)))));
            this.lblTotalRooms.Location = new System.Drawing.Point(152, 174);
            this.lblTotalRooms.Size = new System.Drawing.Size(79, 22);
            this.lblTotalRooms.Text = "Total Rooms";
            this.lblTotalRooms.UseMnemonic = false;
            this.lblTotalRooms.Name = "lblTotalRooms";
            this.lblTotalRooms.TabIndex = 13;
            // 
            // lblTotalRoomsValue
            // 
            this.lblTotalRoomsValue.AutoSize = false;
            this.lblTotalRoomsValue.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalRoomsValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalRoomsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblTotalRoomsValue.Location = new System.Drawing.Point(262, 172);
            this.lblTotalRoomsValue.Size = new System.Drawing.Size(52, 22);
            this.lblTotalRoomsValue.Text = "4";
            this.lblTotalRoomsValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotalRoomsValue.UseMnemonic = false;
            this.lblTotalRoomsValue.Name = "lblTotalRoomsValue";
            this.lblTotalRoomsValue.TabIndex = 14;
            // 
            // SystemOverviewUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.pnlOverview);
            this.Size = new System.Drawing.Size(332, 210);
            this.Name = "SystemOverviewUserControl";
            this.pnlOverview.ResumeLayout(false);
            this.pnlOverview.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private WinFormsApp2.Controls.RoundedPanel pnlOverview;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private WinFormsApp2.Controls.CircularGauge gaugeBrightness;
        private System.Windows.Forms.Label lblOverallTitle;
        private System.Windows.Forms.Label lblOverallValue;
        private System.Windows.Forms.Label lblOnDot;
        private System.Windows.Forms.Label lblOnRooms;
        private System.Windows.Forms.Label lblOnRoomsValue;
        private System.Windows.Forms.Label lblOffDot;
        private System.Windows.Forms.Label lblOffRooms;
        private System.Windows.Forms.Label lblOffRoomsValue;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.Label lblTotalRooms;
        private System.Windows.Forms.Label lblTotalRoomsValue;
    }
}
