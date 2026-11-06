namespace WinFormsApp2.Popups
{
    partial class CreateRoutineForm
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
            lblTrigger = new Label();
            lblTime = new Label();
            lblRepeat = new Label();
            lblAction = new Label();
            txtRoutineName = new TextBox();
            cmbRepeat = new ComboBox();
            cmbTrigger = new ComboBox();
            cmbAction = new ComboBox();
            dtpStartTime = new DateTimePicker();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(25, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(299, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Create New Routine";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.LightGray;
            lblSubtitle.Location = new Point(25, 55);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(249, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Configure a new automation routine";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(25, 95);
            lblName.Name = "lblName";
            lblName.Size = new Size(120, 23);
            lblName.TabIndex = 2;
            lblName.Text = "Routine Name";
            // 
            // lblTrigger
            // 
            lblTrigger.AutoSize = true;
            lblTrigger.ForeColor = Color.White;
            lblTrigger.Location = new Point(25, 165);
            lblTrigger.Name = "lblTrigger";
            lblTrigger.Size = new Size(103, 23);
            lblTrigger.TabIndex = 3;
            lblTrigger.Text = "Trigger Type";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(25, 235);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(87, 23);
            lblTime.TabIndex = 4;
            lblTime.Text = "Start Time";
            // 
            // lblRepeat
            // 
            lblRepeat.AutoSize = true;
            lblRepeat.ForeColor = Color.White;
            lblRepeat.Location = new Point(245, 235);
            lblRepeat.Name = "lblRepeat";
            lblRepeat.Size = new Size(63, 23);
            lblRepeat.TabIndex = 5;
            lblRepeat.Text = "Repeat";
            // 
            // lblAction
            // 
            lblAction.AutoSize = true;
            lblAction.ForeColor = Color.White;
            lblAction.Location = new Point(25, 315);
            lblAction.Name = "lblAction";
            lblAction.Size = new Size(59, 23);
            lblAction.TabIndex = 6;
            lblAction.Text = "Action";
            // 
            // txtRoutineName
            // 
            txtRoutineName.BackColor = Color.FromArgb(48, 54, 93);
            txtRoutineName.ForeColor = Color.White;
            txtRoutineName.Location = new Point(25, 120);
            txtRoutineName.Name = "txtRoutineName";
            txtRoutineName.Size = new Size(420, 30);
            txtRoutineName.TabIndex = 7;
            // 
            // cmbRepeat
            // 
            cmbRepeat.BackColor = Color.FromArgb(48, 54, 93);
            cmbRepeat.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRepeat.ForeColor = Color.White;
            cmbRepeat.FormattingEnabled = true;
            cmbRepeat.Items.AddRange(new object[] { "Daily", "Weekdays", "Weekends", "Once" });
            cmbRepeat.Location = new Point(245, 260);
            cmbRepeat.Name = "cmbRepeat";
            cmbRepeat.Size = new Size(200, 31);
            cmbRepeat.TabIndex = 8;
            // 
            // cmbTrigger
            // 
            cmbTrigger.BackColor = Color.FromArgb(48, 54, 93);
            cmbTrigger.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTrigger.ForeColor = Color.White;
            cmbTrigger.FormattingEnabled = true;
            cmbTrigger.Items.AddRange(new object[] { "Time / Schedule", "Location", "Motion Detection", "Door / Window", "Temperature" });
            cmbTrigger.Location = new Point(25, 190);
            cmbTrigger.Name = "cmbTrigger";
            cmbTrigger.Size = new Size(420, 31);
            cmbTrigger.TabIndex = 9;
            // 
            // cmbAction
            // 
            cmbAction.BackColor = Color.FromArgb(48, 54, 93);
            cmbAction.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAction.ForeColor = Color.White;
            cmbAction.FormattingEnabled = true;
            cmbAction.Items.AddRange(new object[] { "Turn On Lights", "Turn Off Lights", "Dim Lights", "Activate Security", "Lock Doors", "Set Temperature" });
            cmbAction.Location = new Point(25, 340);
            cmbAction.Name = "cmbAction";
            cmbAction.Size = new Size(420, 31);
            cmbAction.TabIndex = 10;
            // 
            // dtpStartTime
            // 
            dtpStartTime.Format = DateTimePickerFormat.Time;
            dtpStartTime.Location = new Point(25, 260);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.ShowUpDown = true;
            dtpStartTime.Size = new Size(195, 30);
            dtpStartTime.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkSlateBlue;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(285, 415);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(160, 38);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save Routine";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(165, 415);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 38);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // CreateRoutineForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 32, 70);
            CancelButton = btnCancel;
            ClientSize = new Size(520, 544);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(dtpStartTime);
            Controls.Add(cmbAction);
            Controls.Add(cmbTrigger);
            Controls.Add(cmbRepeat);
            Controls.Add(txtRoutineName);
            Controls.Add(lblAction);
            Controls.Add(lblRepeat);
            Controls.Add(lblTime);
            Controls.Add(lblTrigger);
            Controls.Add(lblName);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateRoutineForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create New Routine";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblName;
        private Label lblTrigger;
        private Label lblTime;
        private Label lblRepeat;
        private Label lblAction;
        private TextBox txtRoutineName;
        private ComboBox cmbRepeat;
        private ComboBox cmbTrigger;
        private ComboBox cmbAction;
        private DateTimePicker dtpStartTime;
        private Button btnSave;
        private Button btnCancel;
    }
}