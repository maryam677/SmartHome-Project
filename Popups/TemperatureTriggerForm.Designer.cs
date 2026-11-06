namespace WinFormsApp2.Popups
{
    partial class TriggerDetailsForm
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
            lblCondition = new Label();
            lblTemperature = new Label();
            cmbTriggerType = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            btnCancel = new Button();
            btnsave = new Button();
            cmbCondition = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(25, 17);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(183, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Time Trigger";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = Color.LightGray;
            lblSubtitle.Location = new Point(25, 55);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(235, 23);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Configure automation trigger";
            // 
            // lblCondition
            // 
            lblCondition.AutoSize = true;
            lblCondition.Location = new Point(25, 99);
            lblCondition.Name = "lblCondition";
            lblCondition.Size = new Size(140, 23);
            lblCondition.TabIndex = 2;
            lblCondition.Text = "Trigger TypeTime";
            // 
            // lblTemperature
            // 
            lblTemperature.AutoSize = true;
            lblTemperature.Location = new Point(25, 247);
            lblTemperature.Name = "lblTemperature";
            lblTemperature.Size = new Size(138, 23);
            lblTemperature.TabIndex = 3;
            lblTemperature.Text = "Temperature (°C)";
            // 
            // cmbTriggerType
            // 
            cmbTriggerType.BackColor = Color.FromArgb(48, 54, 93);
            cmbTriggerType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTriggerType.ForeColor = Color.White;
            cmbTriggerType.FormattingEnabled = true;
            cmbTriggerType.Items.AddRange(new object[] { "Time", "Location", "Motion", "Door", "Temperature", "Humidity", "Light Level", "More" });
            cmbTriggerType.Location = new Point(25, 125);
            cmbTriggerType.Name = "cmbTriggerType";
            cmbTriggerType.Size = new Size(370, 31);
            cmbTriggerType.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.FromArgb(48, 54, 93);
            numericUpDown1.ForeColor = Color.White;
            numericUpDown1.Location = new Point(25, 273);
            numericUpDown1.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 20, 0, 0, int.MinValue });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(370, 30);
            numericUpDown1.TabIndex = 5;
            numericUpDown1.Value = new decimal(new int[] { 28, 0, 0, 0 });
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(150, 326);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 38);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.DarkSlateBlue;
            btnsave.Cursor = Cursors.Hand;
            btnsave.FlatAppearance.BorderSize = 0;
            btnsave.FlatStyle = FlatStyle.Flat;
            btnsave.ForeColor = Color.White;
            btnsave.Location = new Point(286, 326);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(160, 38);
            btnsave.TabIndex = 16;
            btnsave.Text = "Save Trigger";
            btnsave.UseVisualStyleBackColor = false;
            // 
            // cmbCondition
            // 
            cmbCondition.BackColor = Color.FromArgb(48, 54, 93);
            cmbCondition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCondition.ForeColor = Color.White;
            cmbCondition.FormattingEnabled = true;
            cmbCondition.Items.AddRange(new object[] { "At", "Before", "After", "Arrive", "Leave", "Detected", "Not Detected", "Opened", "Closed", "Above", "Below" });
            cmbCondition.Location = new Point(25, 199);
            cmbCondition.Name = "cmbCondition";
            cmbCondition.Size = new Size(370, 31);
            cmbCondition.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 173);
            label1.Name = "label1";
            label1.Size = new Size(85, 23);
            label1.TabIndex = 19;
            label1.Text = "Condition";
            // 
            // TriggerDetailsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 32, 70);
            ClientSize = new Size(479, 392);
            Controls.Add(label1);
            Controls.Add(cmbCondition);
            Controls.Add(btnCancel);
            Controls.Add(btnsave);
            Controls.Add(numericUpDown1);
            Controls.Add(cmbTriggerType);
            Controls.Add(lblTemperature);
            Controls.Add(lblCondition);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TriggerDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configure Trigger";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblCondition;
        private Label lblTemperature;
        private ComboBox cmbTriggerType;
        private NumericUpDown numericUpDown1;
        private Button btnCancel;
        private Button btnsave;
        private ComboBox cmbCondition;
        private Label label1;
    }
}