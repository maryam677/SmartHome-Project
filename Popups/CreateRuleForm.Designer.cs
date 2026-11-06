namespace WinFormsApp2.Popups
{
    partial class CreateRuleForm
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
            lblRuleName = new Label();
            lblTrigger = new Label();
            lblCondition = new Label();
            lblAction = new Label();
            lblEnabled = new Label();
            txtRuleName = new TextBox();
            cmbTrigger = new ComboBox();
            txtCondition = new TextBox();
            cmbAction = new ComboBox();
            chkEnabled = new CheckBox();
            btnCancel = new Button();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(25, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(252, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Create New Rule";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.FromArgb(175, 182, 213);
            lblSubtitle.Location = new Point(25, 55);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(193, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Set up an automated action";
            // 
            // lblRuleName
            // 
            lblRuleName.AutoSize = true;
            lblRuleName.ForeColor = Color.White;
            lblRuleName.Location = new Point(25, 95);
            lblRuleName.Name = "lblRuleName";
            lblRuleName.Size = new Size(94, 23);
            lblRuleName.TabIndex = 2;
            lblRuleName.Text = "Rule Name";
            // 
            // lblTrigger
            // 
            lblTrigger.AutoSize = true;
            lblTrigger.ForeColor = Color.White;
            lblTrigger.Location = new Point(25, 165);
            lblTrigger.Name = "lblTrigger";
            lblTrigger.Size = new Size(190, 23);
            lblTrigger.TabIndex = 3;
            lblTrigger.Text = "When This Happens (IF)";
            // 
            // lblCondition
            // 
            lblCondition.AutoSize = true;
            lblCondition.ForeColor = Color.White;
            lblCondition.Location = new Point(25, 235);
            lblCondition.Name = "lblCondition";
            lblCondition.Size = new Size(85, 23);
            lblCondition.TabIndex = 4;
            lblCondition.Text = "Condition";
            // 
            // lblAction
            // 
            lblAction.AutoSize = true;
            lblAction.ForeColor = Color.White;
            lblAction.Location = new Point(25, 305);
            lblAction.Name = "lblAction";
            lblAction.Size = new Size(168, 23);
            lblAction.TabIndex = 5;
            lblAction.Text = "Then Do This (THEN)";
            // 
            // lblEnabled
            // 
            lblEnabled.AutoSize = true;
            lblEnabled.ForeColor = Color.White;
            lblEnabled.Location = new Point(25, 385);
            lblEnabled.Name = "lblEnabled";
            lblEnabled.Size = new Size(99, 23);
            lblEnabled.TabIndex = 6;
            lblEnabled.Text = "Enable Rule";
            // 
            // txtRuleName
            // 
            txtRuleName.BackColor = Color.FromArgb(48, 54, 93);
            txtRuleName.Location = new Point(25, 120);
            txtRuleName.Name = "txtRuleName";
            txtRuleName.Size = new Size(420, 30);
            txtRuleName.TabIndex = 7;
            // 
            // cmbTrigger
            // 
            cmbTrigger.BackColor = Color.FromArgb(48, 54, 93);
            cmbTrigger.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTrigger.FormattingEnabled = true;
            cmbTrigger.Items.AddRange(new object[] { "Time / Schedule", "Location", "Motion Detection", "Door / Window", "Temperature", "Humidity", "Light Level" });
            cmbTrigger.Location = new Point(25, 190);
            cmbTrigger.Name = "cmbTrigger";
            cmbTrigger.Size = new Size(420, 31);
            cmbTrigger.TabIndex = 8;
            // 
            // txtCondition
            // 
            txtCondition.BackColor = Color.FromArgb(48, 54, 93);
            txtCondition.Location = new Point(25, 260);
            txtCondition.Name = "txtCondition";
            txtCondition.Size = new Size(420, 30);
            txtCondition.TabIndex = 9;
            // 
            // cmbAction
            // 
            cmbAction.BackColor = Color.FromArgb(48, 54, 93);
            cmbAction.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAction.FormattingEnabled = true;
            cmbAction.Items.AddRange(new object[] { "Turn On Lights", "Turn Off Lights", "Dim Lights", "Activate Security", "Lock Doors", "Set Temperature", "Send Notification" });
            cmbAction.Location = new Point(25, 330);
            cmbAction.Name = "cmbAction";
            cmbAction.Size = new Size(420, 31);
            cmbAction.TabIndex = 10;
            // 
            // chkEnabled
            // 
            chkEnabled.AutoSize = true;
            chkEnabled.Checked = true;
            chkEnabled.CheckState = CheckState.Checked;
            chkEnabled.ForeColor = Color.Transparent;
            chkEnabled.Location = new Point(155, 386);
            chkEnabled.Name = "chkEnabled";
            chkEnabled.Size = new Size(93, 27);
            chkEnabled.TabIndex = 11;
            chkEnabled.Text = "Enabled";
            chkEnabled.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(185, 455);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 38);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(305, 455);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(140, 38);
            btnCreate.TabIndex = 14;
            btnCreate.Text = "Create Rule";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // CreateRuleForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 32, 70);
            ClientSize = new Size(520, 601);
            Controls.Add(btnCancel);
            Controls.Add(btnCreate);
            Controls.Add(chkEnabled);
            Controls.Add(cmbAction);
            Controls.Add(txtCondition);
            Controls.Add(cmbTrigger);
            Controls.Add(txtRuleName);
            Controls.Add(lblEnabled);
            Controls.Add(lblAction);
            Controls.Add(lblCondition);
            Controls.Add(lblTrigger);
            Controls.Add(lblRuleName);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateRuleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateRuleForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblRuleName;
        private Label lblTrigger;
        private Label lblCondition;
        private Label lblAction;
        private Label lblEnabled;
        private TextBox txtRuleName;
        private ComboBox cmbTrigger;
        private TextBox txtCondition;
        private ComboBox cmbAction;
        private CheckBox chkEnabled;
        private Button btnCancel;
        private Button btnCreate;
    }
}