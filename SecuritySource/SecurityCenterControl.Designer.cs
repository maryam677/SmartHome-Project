using WinFormsApp2.SmartHomeSecurity;

namespace SmartHome
{
    partial class SecurityCenterControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tmrAuto = new System.Windows.Forms.Timer(components);
            tmrUi = new System.Windows.Forms.Timer(components);
            lblPageIcon = new Label();
            lblTitle = new Label();
            lblSubtitle = new Label();
            cardStatAlarm = new SecCard();
            lblStatAlarm = new Label();
            lblStatAlarmCaption = new Label();
            cardStatZones = new SecCard();
            lblStatZones = new Label();
            lblStatZonesCaption = new Label();
            cardStatEvents = new SecCard();
            lblStatEvents = new Label();
            lblStatEventsCaption = new Label();
            zoneLiving = new SecZoneCard();
            zoneBedroom = new SecZoneCard();
            zoneKitchen = new SecZoneCard();
            zoneBathroom = new SecZoneCard();
            zoneGarage = new SecZoneCard();
            cardAlarm = new SecCard();
            lblAlarmCaption = new Label();
            lblAlarmState = new Label();
            lblAlarmHint = new Label();
            btnArm = new SecRoundButton();
            btnDisarm = new SecRoundButton();
            chkAutoSim = new CheckBox();
            lblLog = new Label();
            btnClearLog = new SecRoundButton();
            dgvLog = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colTime = new DataGridViewTextBoxColumn();
            colType = new DataGridViewTextBoxColumn();
            colLocation = new DataGridViewTextBoxColumn();
            colDetails = new DataGridViewTextBoxColumn();
            cardStatAlarm.SuspendLayout();
            cardStatZones.SuspendLayout();
            cardStatEvents.SuspendLayout();
            cardAlarm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLog).BeginInit();
            SuspendLayout();
            //
            // tmrAuto
            //
            tmrAuto.Interval = 4000;
            tmrAuto.Tick += tmrAuto_Tick;
            //
            // tmrUi
            //
            tmrUi.Enabled = true;
            tmrUi.Interval = 1000;
            tmrUi.Tick += tmrUi_Tick;
            //
            // lblPageIcon
            //
            lblPageIcon.AutoSize = true;
            lblPageIcon.BackColor = Color.FromArgb(14, 12, 38);
            lblPageIcon.Font = new Font("Segoe MDL2 Assets", 26F, FontStyle.Regular, GraphicsUnit.Point);
            lblPageIcon.ForeColor = Color.FromArgb(179, 157, 255);
            lblPageIcon.Location = new Point(24, 18);
            lblPageIcon.Name = "lblPageIcon";
            lblPageIcon.Size = new Size(44, 35);
            lblPageIcon.Text = "\uE72E";
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.FromArgb(14, 12, 38);
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(76, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(190, 37);
            lblTitle.Text = "Security Center";
            //
            // lblSubtitle
            //
            lblSubtitle.AutoSize = true;
            lblSubtitle.BackColor = Color.FromArgb(14, 12, 38);
            lblSubtitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubtitle.ForeColor = Color.FromArgb(169, 166, 201);
            lblSubtitle.Location = new Point(79, 52);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(350, 19);
            lblSubtitle.Text = "Monitor sensors and control the alarm in your smart home.";
            //
            // cardStatAlarm
            //
            cardStatAlarm.BackColor = Color.FromArgb(14, 12, 38);
            cardStatAlarm.Controls.Add(lblStatAlarm);
            cardStatAlarm.Controls.Add(lblStatAlarmCaption);
            cardStatAlarm.Location = new Point(560, 12);
            cardStatAlarm.Name = "cardStatAlarm";
            cardStatAlarm.Radius = 12;
            cardStatAlarm.Size = new Size(132, 64);
            //
            // lblStatAlarm
            //
            lblStatAlarm.AutoSize = true;
            lblStatAlarm.BackColor = Color.FromArgb(26, 22, 62);
            lblStatAlarm.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatAlarm.ForeColor = Color.White;
            lblStatAlarm.Location = new Point(14, 8);
            lblStatAlarm.Name = "lblStatAlarm";
            lblStatAlarm.Size = new Size(76, 25);
            lblStatAlarm.Text = "Disarmed";
            //
            // lblStatAlarmCaption
            //
            lblStatAlarmCaption.AutoSize = true;
            lblStatAlarmCaption.BackColor = Color.FromArgb(26, 22, 62);
            lblStatAlarmCaption.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatAlarmCaption.ForeColor = Color.FromArgb(169, 166, 201);
            lblStatAlarmCaption.Location = new Point(14, 38);
            lblStatAlarmCaption.Name = "lblStatAlarmCaption";
            lblStatAlarmCaption.Size = new Size(36, 15);
            lblStatAlarmCaption.Text = "Alarm";
            //
            // cardStatZones
            //
            cardStatZones.BackColor = Color.FromArgb(14, 12, 38);
            cardStatZones.Controls.Add(lblStatZones);
            cardStatZones.Controls.Add(lblStatZonesCaption);
            cardStatZones.Location = new Point(702, 12);
            cardStatZones.Name = "cardStatZones";
            cardStatZones.Radius = 12;
            cardStatZones.Size = new Size(132, 64);
            //
            // lblStatZones
            //
            lblStatZones.AutoSize = true;
            lblStatZones.BackColor = Color.FromArgb(26, 22, 62);
            lblStatZones.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatZones.ForeColor = Color.White;
            lblStatZones.Location = new Point(14, 8);
            lblStatZones.Name = "lblStatZones";
            lblStatZones.Size = new Size(18, 25);
            lblStatZones.Text = "5";
            //
            // lblStatZonesCaption
            //
            lblStatZonesCaption.AutoSize = true;
            lblStatZonesCaption.BackColor = Color.FromArgb(26, 22, 62);
            lblStatZonesCaption.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatZonesCaption.ForeColor = Color.FromArgb(169, 166, 201);
            lblStatZonesCaption.Location = new Point(14, 38);
            lblStatZonesCaption.Name = "lblStatZonesCaption";
            lblStatZonesCaption.Size = new Size(77, 15);
            lblStatZonesCaption.Text = "Zones online";
            //
            // cardStatEvents
            //
            cardStatEvents.BackColor = Color.FromArgb(14, 12, 38);
            cardStatEvents.Controls.Add(lblStatEvents);
            cardStatEvents.Controls.Add(lblStatEventsCaption);
            cardStatEvents.Location = new Point(844, 12);
            cardStatEvents.Name = "cardStatEvents";
            cardStatEvents.Radius = 12;
            cardStatEvents.Size = new Size(132, 64);
            //
            // lblStatEvents
            //
            lblStatEvents.AutoSize = true;
            lblStatEvents.BackColor = Color.FromArgb(26, 22, 62);
            lblStatEvents.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatEvents.ForeColor = Color.White;
            lblStatEvents.Location = new Point(14, 8);
            lblStatEvents.Name = "lblStatEvents";
            lblStatEvents.Size = new Size(18, 25);
            lblStatEvents.Text = "0";
            //
            // lblStatEventsCaption
            //
            lblStatEventsCaption.AutoSize = true;
            lblStatEventsCaption.BackColor = Color.FromArgb(26, 22, 62);
            lblStatEventsCaption.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatEventsCaption.ForeColor = Color.FromArgb(169, 166, 201);
            lblStatEventsCaption.Location = new Point(14, 38);
            lblStatEventsCaption.Name = "lblStatEventsCaption";
            lblStatEventsCaption.Size = new Size(78, 15);
            lblStatEventsCaption.Text = "Events logged";
            //
            // zoneLiving
            //
            zoneLiving.BackColor = Color.FromArgb(14, 12, 38);
            zoneLiving.Location = new Point(24, 104);
            zoneLiving.Name = "zoneLiving";
            zoneLiving.Size = new Size(308, 276);
            zoneLiving.Subtitle = "Main entertainment area";
            zoneLiving.ZoneName = "Living Room";
            //
            // zoneBedroom
            //
            zoneBedroom.BackColor = Color.FromArgb(14, 12, 38);
            zoneBedroom.Location = new Point(346, 104);
            zoneBedroom.Name = "zoneBedroom";
            zoneBedroom.Size = new Size(308, 276);
            zoneBedroom.Subtitle = "Rest and sleep zone";
            zoneBedroom.ZoneName = "Bedroom";
            //
            // zoneKitchen
            //
            zoneKitchen.BackColor = Color.FromArgb(14, 12, 38);
            zoneKitchen.Location = new Point(668, 104);
            zoneKitchen.Name = "zoneKitchen";
            zoneKitchen.Size = new Size(308, 276);
            zoneKitchen.Subtitle = "Cooking and dining area";
            zoneKitchen.ZoneName = "Kitchen";
            //
            // zoneBathroom
            //
            zoneBathroom.BackColor = Color.FromArgb(14, 12, 38);
            zoneBathroom.Location = new Point(24, 394);
            zoneBathroom.Name = "zoneBathroom";
            zoneBathroom.Size = new Size(308, 276);
            zoneBathroom.Subtitle = "Personal care area";
            zoneBathroom.ZoneName = "Bathroom";
            //
            // zoneGarage
            //
            zoneGarage.BackColor = Color.FromArgb(14, 12, 38);
            zoneGarage.Location = new Point(346, 394);
            zoneGarage.Name = "zoneGarage";
            zoneGarage.Size = new Size(308, 276);
            zoneGarage.Subtitle = "Parking and storage area";
            zoneGarage.ZoneName = "Garage";
            //
            // cardAlarm
            //
            cardAlarm.BackColor = Color.FromArgb(14, 12, 38);
            cardAlarm.Controls.Add(lblAlarmCaption);
            cardAlarm.Controls.Add(lblAlarmState);
            cardAlarm.Controls.Add(lblAlarmHint);
            cardAlarm.Controls.Add(btnArm);
            cardAlarm.Controls.Add(btnDisarm);
            cardAlarm.Controls.Add(chkAutoSim);
            cardAlarm.Location = new Point(668, 394);
            cardAlarm.Name = "cardAlarm";
            cardAlarm.Radius = 16;
            cardAlarm.Size = new Size(308, 276);
            //
            // lblAlarmCaption
            //
            lblAlarmCaption.AutoSize = true;
            lblAlarmCaption.BackColor = Color.FromArgb(26, 22, 62);
            lblAlarmCaption.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblAlarmCaption.ForeColor = Color.FromArgb(169, 166, 201);
            lblAlarmCaption.Location = new Point(18, 14);
            lblAlarmCaption.Name = "lblAlarmCaption";
            lblAlarmCaption.Size = new Size(74, 19);
            lblAlarmCaption.Text = "Alarm status";
            //
            // lblAlarmState
            //
            lblAlarmState.AutoSize = true;
            lblAlarmState.BackColor = Color.FromArgb(26, 22, 62);
            lblAlarmState.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
            lblAlarmState.ForeColor = Color.FromArgb(111, 227, 160);
            lblAlarmState.Location = new Point(14, 36);
            lblAlarmState.Name = "lblAlarmState";
            lblAlarmState.Size = new Size(160, 47);
            lblAlarmState.Text = "Disarmed";
            //
            // lblAlarmHint
            //
            lblAlarmHint.AutoSize = true;
            lblAlarmHint.BackColor = Color.FromArgb(26, 22, 62);
            lblAlarmHint.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblAlarmHint.ForeColor = Color.FromArgb(169, 166, 201);
            lblAlarmHint.Location = new Point(18, 100);
            lblAlarmHint.Name = "lblAlarmHint";
            lblAlarmHint.Size = new Size(240, 17);
            lblAlarmHint.Text = "System is not monitoring. Press Arm to start.";
            //
            // btnArm
            //
            btnArm.BackColor = Color.FromArgb(26, 22, 62);
            btnArm.FillColor = Color.FromArgb(124, 77, 255);
            btnArm.Location = new Point(18, 166);
            btnArm.Name = "btnArm";
            btnArm.Size = new Size(131, 44);
            btnArm.Text = "Arm";
            btnArm.Click += btnArm_Click;
            //
            // btnDisarm
            //
            btnDisarm.BackColor = Color.FromArgb(26, 22, 62);
            btnDisarm.FillColor = Color.FromArgb(40, 36, 86);
            btnDisarm.HoverColor = Color.FromArgb(62, 56, 124);
            btnDisarm.Location = new Point(159, 166);
            btnDisarm.Name = "btnDisarm";
            btnDisarm.Size = new Size(131, 44);
            btnDisarm.Text = "Disarm";
            btnDisarm.Click += btnDisarm_Click;
            //
            // chkAutoSim
            //
            chkAutoSim.AutoSize = true;
            chkAutoSim.BackColor = Color.FromArgb(26, 22, 62);
            chkAutoSim.ForeColor = Color.White;
            chkAutoSim.Location = new Point(18, 226);
            chkAutoSim.Name = "chkAutoSim";
            chkAutoSim.Size = new Size(170, 19);
            chkAutoSim.Text = "Auto simulate (every 4s)";
            chkAutoSim.UseVisualStyleBackColor = false;
            chkAutoSim.CheckedChanged += chkAutoSim_CheckedChanged;
            //
            // lblLog
            //
            lblLog.AutoSize = true;
            lblLog.BackColor = Color.FromArgb(14, 12, 38);
            lblLog.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblLog.ForeColor = Color.White;
            lblLog.Location = new Point(24, 690);
            lblLog.Name = "lblLog";
            lblLog.Size = new Size(110, 25);
            lblLog.Text = "Security log";
            //
            // btnClearLog
            //
            btnClearLog.BackColor = Color.FromArgb(14, 12, 38);
            btnClearLog.FillColor = Color.FromArgb(40, 36, 86);
            btnClearLog.HoverColor = Color.FromArgb(62, 56, 124);
            btnClearLog.Location = new Point(866, 688);
            btnClearLog.Name = "btnClearLog";
            btnClearLog.Size = new Size(110, 34);
            btnClearLog.Text = "Clear log";
            btnClearLog.Click += btnClearLog_Click;
            //
            // dgvLog
            //
            dgvLog.AllowUserToAddRows = false;
            dgvLog.AllowUserToDeleteRows = false;
            dgvLog.BackgroundColor = Color.FromArgb(26, 22, 62);
            dgvLog.BorderStyle = BorderStyle.None;
            dgvLog.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(26, 22, 62);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(169, 166, 201);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(26, 22, 62);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(169, 166, 201);
            dgvLog.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLog.Columns.AddRange(new DataGridViewColumn[] { colId, colTime, colType, colLocation, colDetails });
            dataGridViewCellStyle2.BackColor = Color.FromArgb(26, 22, 62);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(60, 52, 128);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvLog.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLog.EnableHeadersVisualStyles = false;
            dgvLog.GridColor = Color.FromArgb(44, 39, 96);
            dgvLog.Location = new Point(24, 734);
            dgvLog.Name = "dgvLog";
            dgvLog.ReadOnly = true;
            dgvLog.RowHeadersVisible = false;
            dgvLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLog.Size = new Size(952, 180);
            //
            // colId
            //
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Id";
            colId.Name = "Id";
            colId.ReadOnly = true;
            colId.Width = 50;
            //
            // colTime
            //
            dataGridViewCellStyle3.Format = "HH:mm:ss";
            colTime.DataPropertyName = "Time";
            colTime.DefaultCellStyle = dataGridViewCellStyle3;
            colTime.HeaderText = "Time";
            colTime.Name = "Time";
            colTime.ReadOnly = true;
            //
            // colType
            //
            colType.DataPropertyName = "Type";
            colType.HeaderText = "Type";
            colType.Name = "Type";
            colType.ReadOnly = true;
            //
            // colLocation
            //
            colLocation.DataPropertyName = "Location";
            colLocation.HeaderText = "Location";
            colLocation.Name = "Location";
            colLocation.ReadOnly = true;
            //
            // colDetails
            //
            colDetails.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDetails.DataPropertyName = "Details";
            colDetails.HeaderText = "Details";
            colDetails.Name = "Details";
            colDetails.ReadOnly = true;
            //
            // SecurityCenterControl
            //
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            BackColor = Color.FromArgb(14, 12, 38);
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
            Controls.Add(lblLog);
            Controls.Add(btnClearLog);
            Controls.Add(dgvLog);
            Name = "SecurityCenterControl";
            Size = new Size(1000, 940);
            cardStatAlarm.ResumeLayout(false);
            cardStatAlarm.PerformLayout();
            cardStatZones.ResumeLayout(false);
            cardStatZones.PerformLayout();
            cardStatEvents.ResumeLayout(false);
            cardStatEvents.PerformLayout();
            cardAlarm.ResumeLayout(false);
            cardAlarm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLog).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer tmrAuto;
        private System.Windows.Forms.Timer tmrUi;
        private Label lblPageIcon;
        private Label lblTitle;
        private Label lblSubtitle;
        private SecCard cardStatAlarm;
        private Label lblStatAlarm;
        private Label lblStatAlarmCaption;
        private SecCard cardStatZones;
        private Label lblStatZones;
        private Label lblStatZonesCaption;
        private SecCard cardStatEvents;
        private Label lblStatEvents;
        private Label lblStatEventsCaption;
        private SecZoneCard zoneLiving;
        private SecZoneCard zoneBedroom;
        private SecZoneCard zoneKitchen;
        private SecZoneCard zoneBathroom;
        private SecZoneCard zoneGarage;
        private SecCard cardAlarm;
        private Label lblAlarmCaption;
        private Label lblAlarmState;
        private Label lblAlarmHint;
        private SecRoundButton btnArm;
        private SecRoundButton btnDisarm;
        private CheckBox chkAutoSim;
        private Label lblLog;
        private SecRoundButton btnClearLog;
        private DataGridView dgvLog;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colTime;
        private DataGridViewTextBoxColumn colType;
        private DataGridViewTextBoxColumn colLocation;
        private DataGridViewTextBoxColumn colDetails;
    }
}
