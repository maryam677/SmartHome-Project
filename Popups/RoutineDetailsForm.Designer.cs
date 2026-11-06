namespace WinFormsApp2.Popups
{
    partial class RoutineDetailsForm
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
            lblRoutineName = new Label();
            lblDescription = new Label();
            lblStatus = new Label();
            panel1 = new Panel();
            lblStartTime = new Label();
            lblRepeat = new Label();
            dtpStartTime = new DateTimePicker();
            cmbRepeat = new ComboBox();
            lblActionsTitle = new Label();
            pnlAction1 = new Panel();
            lblbedlight = new Label();
            pnlAction3 = new Panel();
            lblcurt = new Label();
            pnlAction2 = new Panel();
            lbltemp = new Label();
            btnCancel = new Button();
            btnEdit = new Button();
            panel1.SuspendLayout();
            pnlAction1.SuspendLayout();
            pnlAction3.SuspendLayout();
            pnlAction2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(25, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(233, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Routine Details";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.Gainsboro;
            lblSubtitle.Location = new Point(25, 51);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(295, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "View and manage your smart home routine";
            // 
            // lblRoutineName
            // 
            lblRoutineName.AutoSize = true;
            lblRoutineName.BackColor = Color.DarkSlateBlue;
            lblRoutineName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoutineName.Location = new Point(35, 105);
            lblRoutineName.Name = "lblRoutineName";
            lblRoutineName.Size = new Size(173, 28);
            lblRoutineName.TabIndex = 2;
            lblRoutineName.Text = "Morning Routine";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.DarkSlateBlue;
            lblDescription.Location = new Point(35, 134);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(223, 23);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Start your day automatically";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.DarkSlateBlue;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.LimeGreen;
            lblStatus.Location = new Point(370, 18);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(45, 20);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "● ON";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.Controls.Add(lblStatus);
            panel1.Location = new Point(28, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(446, 91);
            panel1.TabIndex = 5;
            // 
            // lblStartTime
            // 
            lblStartTime.AutoSize = true;
            lblStartTime.Location = new Point(25, 190);
            lblStartTime.Name = "lblStartTime";
            lblStartTime.Size = new Size(87, 23);
            lblStartTime.TabIndex = 6;
            lblStartTime.Text = "Start Time";
            // 
            // lblRepeat
            // 
            lblRepeat.AutoSize = true;
            lblRepeat.Location = new Point(250, 190);
            lblRepeat.Name = "lblRepeat";
            lblRepeat.Size = new Size(63, 23);
            lblRepeat.TabIndex = 7;
            lblRepeat.Text = "Repeat";
            // 
            // dtpStartTime
            // 
            dtpStartTime.Format = DateTimePickerFormat.Time;
            dtpStartTime.Location = new Point(25, 215);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.ShowUpDown = true;
            dtpStartTime.Size = new Size(195, 30);
            dtpStartTime.TabIndex = 8;
            // 
            // cmbRepeat
            // 
            cmbRepeat.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRepeat.FormattingEnabled = true;
            cmbRepeat.Items.AddRange(new object[] { "Daily", "Weekdays", "Weekends", "Once" });
            cmbRepeat.Location = new Point(250, 215);
            cmbRepeat.Name = "cmbRepeat";
            cmbRepeat.Size = new Size(195, 31);
            cmbRepeat.TabIndex = 9;
            // 
            // lblActionsTitle
            // 
            lblActionsTitle.AutoSize = true;
            lblActionsTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActionsTitle.Location = new Point(28, 261);
            lblActionsTitle.Name = "lblActionsTitle";
            lblActionsTitle.Size = new Size(136, 23);
            lblActionsTitle.TabIndex = 10;
            lblActionsTitle.Text = "Routine Actions";
            // 
            // pnlAction1
            // 
            pnlAction1.BackColor = Color.FromArgb(41, 47, 89);
            pnlAction1.Controls.Add(lblbedlight);
            pnlAction1.Location = new Point(25, 300);
            pnlAction1.Name = "pnlAction1";
            pnlAction1.Size = new Size(420, 33);
            pnlAction1.TabIndex = 11;
            // 
            // lblbedlight
            // 
            lblbedlight.AutoSize = true;
            lblbedlight.Location = new Point(10, 7);
            lblbedlight.Name = "lblbedlight";
            lblbedlight.Size = new Size(268, 23);
            lblbedlight.TabIndex = 0;
            lblbedlight.Text = "✓ Turn on bedroom lights — 70%";
            // 
            // pnlAction3
            // 
            pnlAction3.BackColor = Color.FromArgb(41, 47, 89);
            pnlAction3.Controls.Add(lblcurt);
            pnlAction3.Location = new Point(25, 412);
            pnlAction3.Name = "pnlAction3";
            pnlAction3.Size = new Size(420, 33);
            pnlAction3.TabIndex = 12;
            // 
            // lblcurt
            // 
            lblcurt.AutoSize = true;
            lblcurt.Location = new Point(10, 7);
            lblcurt.Name = "lblcurt";
            lblcurt.Size = new Size(183, 23);
            lblcurt.TabIndex = 0;
            lblcurt.Text = "✓ Open smart curtains";
            // 
            // pnlAction2
            // 
            pnlAction2.BackColor = Color.FromArgb(41, 47, 89);
            pnlAction2.Controls.Add(lbltemp);
            pnlAction2.Location = new Point(25, 356);
            pnlAction2.Name = "pnlAction2";
            pnlAction2.Size = new Size(420, 33);
            pnlAction2.TabIndex = 12;
            // 
            // lbltemp
            // 
            lbltemp.AutoSize = true;
            lbltemp.Location = new Point(10, 7);
            lbltemp.Name = "lbltemp";
            lbltemp.Size = new Size(241, 23);
            lbltemp.TabIndex = 0;
            lbltemp.Text = "✓ Set AC temperature — 24°C";
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(148, 472);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 38);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DarkSlateBlue;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(268, 472);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(160, 38);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "Edit Routine";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // RoutineDetailsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 32, 70);
            ClientSize = new Size(520, 532);
            Controls.Add(btnCancel);
            Controls.Add(btnEdit);
            Controls.Add(pnlAction2);
            Controls.Add(pnlAction3);
            Controls.Add(pnlAction1);
            Controls.Add(lblActionsTitle);
            Controls.Add(cmbRepeat);
            Controls.Add(dtpStartTime);
            Controls.Add(lblRepeat);
            Controls.Add(lblStartTime);
            Controls.Add(lblDescription);
            Controls.Add(lblRoutineName);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RoutineDetailsForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Routine Details";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlAction1.ResumeLayout(false);
            pnlAction1.PerformLayout();
            pnlAction3.ResumeLayout(false);
            pnlAction3.PerformLayout();
            pnlAction2.ResumeLayout(false);
            pnlAction2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblRoutineName;
        private Label lblDescription;
        private Label lblStatus;
        private Panel panel1;
        private Label lblStartTime;
        private Label lblRepeat;
        private DateTimePicker dtpStartTime;
        private ComboBox cmbRepeat;
        private Label lblActionsTitle;
        private Panel pnlAction1;
        private Label lblbedlight;
        private Panel pnlAction3;
        private Label lblcurt;
        private Panel pnlAction2;
        private Label lbltemp;
        private Button btnCancel;
        private Button btnEdit;
    }
}