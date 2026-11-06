namespace WinFormsApp2.Popups
{
    partial class ScheduleForm
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
            cmbRoutine = new ComboBox();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            chkSun = new CheckBox();
            chkEnabled = new CheckBox();
            btnCancel = new Button();
            btnSave = new Button();
            chkThu = new CheckBox();
            chkFri = new CheckBox();
            chkWed = new CheckBox();
            chkTue = new CheckBox();
            chkMon = new CheckBox();
            lblSelelblRoutineMorning = new Label();
            chkSat = new CheckBox();
            lblstarttime = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(25, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(302, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Schedule Automation";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = Color.LightGray;
            lblSubtitle.Location = new Point(25, 55);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(333, 23);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Choose when your automation should run";
            // 
            // cmbRoutine
            // 
            cmbRoutine.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoutine.FormattingEnabled = true;
            cmbRoutine.Items.AddRange(new object[] { "Morning Routine", "Away Mode", "Night Mode", "Vacation Mode" });
            cmbRoutine.Location = new Point(25, 125);
            cmbRoutine.Name = "cmbRoutine";
            cmbRoutine.Size = new Size(440, 31);
            cmbRoutine.TabIndex = 2;
            // 
            // dtpStart
            // 
            dtpStart.Format = DateTimePickerFormat.Time;
            dtpStart.Location = new Point(25, 205);
            dtpStart.Name = "dtpStart";
            dtpStart.ShowUpDown = true;
            dtpStart.Size = new Size(205, 30);
            dtpStart.TabIndex = 3;
            // 
            // dtpEnd
            // 
            dtpEnd.Format = DateTimePickerFormat.Time;
            dtpEnd.Location = new Point(255, 205);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.ShowUpDown = true;
            dtpEnd.Size = new Size(210, 30);
            dtpEnd.TabIndex = 4;
            // 
            // chkSun
            // 
            chkSun.AutoSize = true;
            chkSun.BackColor = Color.DarkSlateBlue;
            chkSun.ForeColor = Color.White;
            chkSun.Location = new Point(25, 301);
            chkSun.Name = "chkSun";
            chkSun.Size = new Size(61, 27);
            chkSun.TabIndex = 5;
            chkSun.Text = "Sun";
            chkSun.UseVisualStyleBackColor = false;
            // 
            // chkEnabled
            // 
            chkEnabled.AutoSize = true;
            chkEnabled.ForeColor = Color.White;
            chkEnabled.Location = new Point(25, 362);
            chkEnabled.Name = "chkEnabled";
            chkEnabled.Size = new Size(157, 27);
            chkEnabled.TabIndex = 6;
            chkEnabled.Text = "Enable Schedule";
            chkEnabled.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(217, 420);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 38);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SlateBlue;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(335, 420);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(177, 38);
            btnSave.TabIndex = 15;
            btnSave.Text = " Save Schedule";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // chkThu
            // 
            chkThu.AutoSize = true;
            chkThu.BackColor = Color.DarkSlateBlue;
            chkThu.ForeColor = Color.White;
            chkThu.Location = new Point(323, 301);
            chkThu.Name = "chkThu";
            chkThu.Size = new Size(61, 27);
            chkThu.TabIndex = 17;
            chkThu.Text = "Thu";
            chkThu.UseVisualStyleBackColor = false;
            // 
            // chkFri
            // 
            chkFri.AutoSize = true;
            chkFri.BackColor = Color.DarkSlateBlue;
            chkFri.ForeColor = Color.White;
            chkFri.Location = new Point(395, 301);
            chkFri.Name = "chkFri";
            chkFri.Size = new Size(50, 27);
            chkFri.TabIndex = 18;
            chkFri.Text = "Fri";
            chkFri.UseVisualStyleBackColor = false;
            // 
            // chkWed
            // 
            chkWed.AutoSize = true;
            chkWed.BackColor = Color.DarkSlateBlue;
            chkWed.ForeColor = Color.White;
            chkWed.Location = new Point(246, 301);
            chkWed.Name = "chkWed";
            chkWed.Size = new Size(66, 27);
            chkWed.TabIndex = 20;
            chkWed.Text = "Wed";
            chkWed.UseVisualStyleBackColor = false;
            // 
            // chkTue
            // 
            chkTue.AutoSize = true;
            chkTue.BackColor = Color.DarkSlateBlue;
            chkTue.ForeColor = Color.White;
            chkTue.Location = new Point(175, 301);
            chkTue.Name = "chkTue";
            chkTue.Size = new Size(60, 27);
            chkTue.TabIndex = 21;
            chkTue.Text = "Tue";
            chkTue.UseVisualStyleBackColor = false;
            // 
            // chkMon
            // 
            chkMon.AutoSize = true;
            chkMon.BackColor = Color.DarkSlateBlue;
            chkMon.ForeColor = Color.White;
            chkMon.Location = new Point(97, 301);
            chkMon.Name = "chkMon";
            chkMon.Size = new Size(67, 27);
            chkMon.TabIndex = 22;
            chkMon.Text = "Mon";
            chkMon.UseVisualStyleBackColor = false;
            // 
            // lblSelelblRoutineMorning
            // 
            lblSelelblRoutineMorning.AutoSize = true;
            lblSelelblRoutineMorning.ForeColor = Color.White;
            lblSelelblRoutineMorning.Location = new Point(29, 93);
            lblSelelblRoutineMorning.Name = "lblSelelblRoutineMorning";
            lblSelelblRoutineMorning.Size = new Size(119, 23);
            lblSelelblRoutineMorning.TabIndex = 23;
            lblSelelblRoutineMorning.Text = "Select Routine";
            // 
            // chkSat
            // 
            chkSat.AutoSize = true;
            chkSat.BackColor = Color.DarkSlateBlue;
            chkSat.ForeColor = Color.White;
            chkSat.Location = new Point(456, 301);
            chkSat.Name = "chkSat";
            chkSat.Size = new Size(56, 27);
            chkSat.TabIndex = 24;
            chkSat.Text = "Sat";
            chkSat.UseVisualStyleBackColor = false;
            // 
            // lblstarttime
            // 
            lblstarttime.AutoSize = true;
            lblstarttime.ForeColor = Color.White;
            lblstarttime.Location = new Point(25, 179);
            lblstarttime.Name = "lblstarttime";
            lblstarttime.Size = new Size(87, 23);
            lblstarttime.TabIndex = 25;
            lblstarttime.Text = "Start Time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(255, 179);
            label2.Name = "label2";
            label2.Size = new Size(81, 23);
            label2.TabIndex = 26;
            label2.Text = "End Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(29, 259);
            label3.Name = "label3";
            label3.Size = new Size(91, 23);
            label3.TabIndex = 27;
            label3.Text = "Repeat On";
            // 
            // ScheduleForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 32, 70);
            ClientSize = new Size(542, 544);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblstarttime);
            Controls.Add(chkSat);
            Controls.Add(lblSelelblRoutineMorning);
            Controls.Add(chkMon);
            Controls.Add(chkTue);
            Controls.Add(chkWed);
            Controls.Add(chkFri);
            Controls.Add(chkThu);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(chkEnabled);
            Controls.Add(chkSun);
            Controls.Add(dtpEnd);
            Controls.Add(dtpStart);
            Controls.Add(cmbRoutine);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ScheduleForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Schedule Automation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private ComboBox cmbRoutine;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private CheckBox chkSun;
        private CheckBox chkEnabled;
        private Button btnCancel;
        private Button btnSave;
        private CheckBox chkThu;
        private CheckBox chkFri;
        private CheckBox chkWed;
        private CheckBox chkTue;
        private CheckBox chkMon;
        private Label lblSelelblRoutineMorning;
        private CheckBox chkSat;
        private Label lblstarttime;
        private Label label2;
        private Label label3;
    }
}