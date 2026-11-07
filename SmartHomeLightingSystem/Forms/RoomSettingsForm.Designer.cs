namespace SmartHomeLightingSystem.Forms
{
    partial class RoomSettingsForm
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
            this.pnlDialog = new SmartHomeLightingSystem.Controls.RoundedPanel();
            this.lblDialogIcon = new System.Windows.Forms.Label();
            this.lblDialogTitle = new System.Windows.Forms.Label();
            this.lblDialogSubtitle = new System.Windows.Forms.Label();
            this.btnCloseDialog = new System.Windows.Forms.Button();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.lblBrightness = new System.Windows.Forms.Label();
            this.lblBrightnessValue = new System.Windows.Forms.Label();
            this.trackBrightness = new System.Windows.Forms.TrackBar();
            this.lblColor = new System.Windows.Forms.Label();
            this.swatchPurple = new SmartHomeLightingSystem.Controls.ColorSwatchButton();
            this.swatchBlue = new SmartHomeLightingSystem.Controls.ColorSwatchButton();
            this.swatchCyan = new SmartHomeLightingSystem.Controls.ColorSwatchButton();
            this.swatchGreen = new SmartHomeLightingSystem.Controls.ColorSwatchButton();
            this.swatchYellow = new SmartHomeLightingSystem.Controls.ColorSwatchButton();
            this.swatchOrange = new SmartHomeLightingSystem.Controls.ColorSwatchButton();
            this.swatchPink = new SmartHomeLightingSystem.Controls.ColorSwatchButton();
            this.chkAutoOff = new System.Windows.Forms.CheckBox();
            this.numAutoOffMinutes = new System.Windows.Forms.NumericUpDown();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlDialog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAutoOffMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDialog
            // 
            this.pnlDialog.Controls.Add(this.lblDialogIcon);
            this.pnlDialog.Controls.Add(this.lblDialogTitle);
            this.pnlDialog.Controls.Add(this.lblDialogSubtitle);
            this.pnlDialog.Controls.Add(this.btnCloseDialog);
            this.pnlDialog.Controls.Add(this.lblRoomName);
            this.pnlDialog.Controls.Add(this.txtRoomName);
            this.pnlDialog.Controls.Add(this.lblBrightness);
            this.pnlDialog.Controls.Add(this.lblBrightnessValue);
            this.pnlDialog.Controls.Add(this.trackBrightness);
            this.pnlDialog.Controls.Add(this.lblColor);
            this.pnlDialog.Controls.Add(this.swatchPurple);
            this.pnlDialog.Controls.Add(this.swatchBlue);
            this.pnlDialog.Controls.Add(this.swatchCyan);
            this.pnlDialog.Controls.Add(this.swatchGreen);
            this.pnlDialog.Controls.Add(this.swatchYellow);
            this.pnlDialog.Controls.Add(this.swatchOrange);
            this.pnlDialog.Controls.Add(this.swatchPink);
            this.pnlDialog.Controls.Add(this.chkAutoOff);
            this.pnlDialog.Controls.Add(this.numAutoOffMinutes);
            this.pnlDialog.Controls.Add(this.lblMinutes);
            this.pnlDialog.Controls.Add(this.btnSave);
            this.pnlDialog.Controls.Add(this.btnCancel);
            this.pnlDialog.BackColor = System.Drawing.Color.Transparent;
            this.pnlDialog.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.pnlDialog.BorderRadius = 16;
            this.pnlDialog.BorderThickness = 1F;
            this.pnlDialog.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(21)))), ((int)(((byte)(56)))));
            this.pnlDialog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDialog.Location = new System.Drawing.Point(0, 0);
            this.pnlDialog.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.pnlDialog.Size = new System.Drawing.Size(440, 466);
            this.pnlDialog.Name = "pnlDialog";
            this.pnlDialog.TabIndex = 0;
            // 
            // lblDialogIcon
            // 
            this.lblDialogIcon.AutoSize = true;
            this.lblDialogIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblDialogIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDialogIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.lblDialogIcon.Location = new System.Drawing.Point(24, 24);
            this.lblDialogIcon.Size = new System.Drawing.Size(30, 34);
            this.lblDialogIcon.Text = "\uE713";
            this.lblDialogIcon.UseMnemonic = false;
            this.lblDialogIcon.Name = "lblDialogIcon";
            this.lblDialogIcon.TabIndex = 0;
            // 
            // lblDialogTitle
            // 
            this.lblDialogTitle.AutoSize = true;
            this.lblDialogTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblDialogTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDialogTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblDialogTitle.Location = new System.Drawing.Point(54, 17);
            this.lblDialogTitle.Size = new System.Drawing.Size(147, 30);
            this.lblDialogTitle.Text = "Room Settings";
            this.lblDialogTitle.UseMnemonic = false;
            this.lblDialogTitle.Name = "lblDialogTitle";
            this.lblDialogTitle.TabIndex = 1;
            // 
            // lblDialogSubtitle
            // 
            this.lblDialogSubtitle.AutoSize = true;
            this.lblDialogSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblDialogSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDialogSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(161)))), ((int)(((byte)(194)))));
            this.lblDialogSubtitle.Location = new System.Drawing.Point(56, 48);
            this.lblDialogSubtitle.Size = new System.Drawing.Size(207, 21);
            this.lblDialogSubtitle.Text = "Change the settings of this room";
            this.lblDialogSubtitle.UseMnemonic = false;
            this.lblDialogSubtitle.Name = "lblDialogSubtitle";
            this.lblDialogSubtitle.TabIndex = 2;
            // 
            // btnCloseDialog
            // 
            this.btnCloseDialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(21)))), ((int)(((byte)(56)))));
            this.btnCloseDialog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseDialog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(21)))), ((int)(((byte)(56)))));
            this.btnCloseDialog.FlatAppearance.BorderSize = 0;
            this.btnCloseDialog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.btnCloseDialog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(63)))), ((int)(((byte)(94)))));
            this.btnCloseDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseDialog.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCloseDialog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(161)))), ((int)(((byte)(194)))));
            this.btnCloseDialog.Location = new System.Drawing.Point(390, 16);
            this.btnCloseDialog.Size = new System.Drawing.Size(34, 34);
            this.btnCloseDialog.Text = "\uE8BB";
            this.btnCloseDialog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCloseDialog.UseVisualStyleBackColor = false;
            this.btnCloseDialog.Name = "btnCloseDialog";
            this.btnCloseDialog.TabIndex = 3;
            this.btnCloseDialog.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRoomName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(161)))), ((int)(((byte)(194)))));
            this.lblRoomName.Location = new System.Drawing.Point(24, 90);
            this.lblRoomName.Size = new System.Drawing.Size(65, 22);
            this.lblRoomName.Text = "Room Name";
            this.lblRoomName.UseMnemonic = false;
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.TabIndex = 4;
            // 
            // txtRoomName
            // 
            this.txtRoomName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(17)))), ((int)(((byte)(46)))));
            this.txtRoomName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoomName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRoomName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtRoomName.Location = new System.Drawing.Point(24, 114);
            this.txtRoomName.Size = new System.Drawing.Size(392, 27);
            this.txtRoomName.Text = "Living Room";
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.TabIndex = 5;
            // 
            // lblBrightness
            // 
            this.lblBrightness.AutoSize = true;
            this.lblBrightness.BackColor = System.Drawing.Color.Transparent;
            this.lblBrightness.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBrightness.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(161)))), ((int)(((byte)(194)))));
            this.lblBrightness.Location = new System.Drawing.Point(24, 158);
            this.lblBrightness.Size = new System.Drawing.Size(72, 22);
            this.lblBrightness.Text = "Brightness";
            this.lblBrightness.UseMnemonic = false;
            this.lblBrightness.Name = "lblBrightness";
            this.lblBrightness.TabIndex = 6;
            // 
            // lblBrightnessValue
            // 
            this.lblBrightnessValue.AutoSize = false;
            this.lblBrightnessValue.BackColor = System.Drawing.Color.Transparent;
            this.lblBrightnessValue.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBrightnessValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblBrightnessValue.Location = new System.Drawing.Point(346, 156);
            this.lblBrightnessValue.Size = new System.Drawing.Size(70, 24);
            this.lblBrightnessValue.Text = "75%";
            this.lblBrightnessValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBrightnessValue.UseMnemonic = false;
            this.lblBrightnessValue.Name = "lblBrightnessValue";
            this.lblBrightnessValue.TabIndex = 7;
            // 
            // trackBrightness
            // 
            this.trackBrightness.AutoSize = false;
            this.trackBrightness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(21)))), ((int)(((byte)(56)))));
            this.trackBrightness.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBrightness.Location = new System.Drawing.Point(18, 184);
            this.trackBrightness.Maximum = 100;
            this.trackBrightness.Size = new System.Drawing.Size(404, 30);
            this.trackBrightness.TickFrequency = 10;
            this.trackBrightness.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBrightness.Value = 75;
            this.trackBrightness.Name = "trackBrightness";
            this.trackBrightness.TabIndex = 8;
            this.trackBrightness.Scroll += new System.EventHandler(this.trackBrightness_Scroll);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.BackColor = System.Drawing.Color.Transparent;
            this.lblColor.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(161)))), ((int)(((byte)(194)))));
            this.lblColor.Location = new System.Drawing.Point(24, 230);
            this.lblColor.Size = new System.Drawing.Size(79, 22);
            this.lblColor.Text = "Light Color";
            this.lblColor.UseMnemonic = false;
            this.lblColor.Name = "lblColor";
            this.lblColor.TabIndex = 9;
            // 
            // swatchPurple
            // 
            this.swatchPurple.BackColor = System.Drawing.Color.Transparent;
            this.swatchPurple.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swatchPurple.Location = new System.Drawing.Point(24, 258);
            this.swatchPurple.Selected = true;
            this.swatchPurple.Size = new System.Drawing.Size(34, 34);
            this.swatchPurple.SwatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.swatchPurple.Tag = "Purple";
            this.swatchPurple.Name = "swatchPurple";
            this.swatchPurple.TabIndex = 10;
            this.swatchPurple.Click += new System.EventHandler(this.Swatch_Click);
            // 
            // swatchBlue
            // 
            this.swatchBlue.BackColor = System.Drawing.Color.Transparent;
            this.swatchBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swatchBlue.Location = new System.Drawing.Point(70, 258);
            this.swatchBlue.Selected = false;
            this.swatchBlue.Size = new System.Drawing.Size(34, 34);
            this.swatchBlue.SwatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.swatchBlue.Tag = "Blue";
            this.swatchBlue.Name = "swatchBlue";
            this.swatchBlue.TabIndex = 11;
            this.swatchBlue.Click += new System.EventHandler(this.Swatch_Click);
            // 
            // swatchCyan
            // 
            this.swatchCyan.BackColor = System.Drawing.Color.Transparent;
            this.swatchCyan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swatchCyan.Location = new System.Drawing.Point(116, 258);
            this.swatchCyan.Selected = false;
            this.swatchCyan.Size = new System.Drawing.Size(34, 34);
            this.swatchCyan.SwatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.swatchCyan.Tag = "Cyan";
            this.swatchCyan.Name = "swatchCyan";
            this.swatchCyan.TabIndex = 12;
            this.swatchCyan.Click += new System.EventHandler(this.Swatch_Click);
            // 
            // swatchGreen
            // 
            this.swatchGreen.BackColor = System.Drawing.Color.Transparent;
            this.swatchGreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swatchGreen.Location = new System.Drawing.Point(162, 258);
            this.swatchGreen.Selected = false;
            this.swatchGreen.Size = new System.Drawing.Size(34, 34);
            this.swatchGreen.SwatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.swatchGreen.Tag = "Green";
            this.swatchGreen.Name = "swatchGreen";
            this.swatchGreen.TabIndex = 13;
            this.swatchGreen.Click += new System.EventHandler(this.Swatch_Click);
            // 
            // swatchYellow
            // 
            this.swatchYellow.BackColor = System.Drawing.Color.Transparent;
            this.swatchYellow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swatchYellow.Location = new System.Drawing.Point(208, 258);
            this.swatchYellow.Selected = false;
            this.swatchYellow.Size = new System.Drawing.Size(34, 34);
            this.swatchYellow.SwatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.swatchYellow.Tag = "Yellow";
            this.swatchYellow.Name = "swatchYellow";
            this.swatchYellow.TabIndex = 14;
            this.swatchYellow.Click += new System.EventHandler(this.Swatch_Click);
            // 
            // swatchOrange
            // 
            this.swatchOrange.BackColor = System.Drawing.Color.Transparent;
            this.swatchOrange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swatchOrange.Location = new System.Drawing.Point(254, 258);
            this.swatchOrange.Selected = false;
            this.swatchOrange.Size = new System.Drawing.Size(34, 34);
            this.swatchOrange.SwatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(115)))), ((int)(((byte)(22)))));
            this.swatchOrange.Tag = "Orange";
            this.swatchOrange.Name = "swatchOrange";
            this.swatchOrange.TabIndex = 15;
            this.swatchOrange.Click += new System.EventHandler(this.Swatch_Click);
            // 
            // swatchPink
            // 
            this.swatchPink.BackColor = System.Drawing.Color.Transparent;
            this.swatchPink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swatchPink.Location = new System.Drawing.Point(300, 258);
            this.swatchPink.Selected = false;
            this.swatchPink.Size = new System.Drawing.Size(34, 34);
            this.swatchPink.SwatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(72)))), ((int)(((byte)(153)))));
            this.swatchPink.Tag = "Pink";
            this.swatchPink.Name = "swatchPink";
            this.swatchPink.TabIndex = 16;
            this.swatchPink.Click += new System.EventHandler(this.Swatch_Click);
            // 
            // chkAutoOff
            // 
            this.chkAutoOff.AutoSize = true;
            this.chkAutoOff.BackColor = System.Drawing.Color.Transparent;
            this.chkAutoOff.Checked = false;
            this.chkAutoOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAutoOff.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkAutoOff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.chkAutoOff.Location = new System.Drawing.Point(24, 315);
            this.chkAutoOff.Size = new System.Drawing.Size(226, 23);
            this.chkAutoOff.Text = "Turn off automatically after";
            this.chkAutoOff.UseVisualStyleBackColor = true;
            this.chkAutoOff.Name = "chkAutoOff";
            this.chkAutoOff.TabIndex = 17;
            // 
            // numAutoOffMinutes
            // 
            this.numAutoOffMinutes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(17)))), ((int)(((byte)(46)))));
            this.numAutoOffMinutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numAutoOffMinutes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numAutoOffMinutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.numAutoOffMinutes.Location = new System.Drawing.Point(262, 314);
            this.numAutoOffMinutes.Maximum = new decimal(new int[] {

            240,

            0,

            0,

            0});
            this.numAutoOffMinutes.Minimum = new decimal(new int[] {

            1,

            0,

            0,

            0});
            this.numAutoOffMinutes.Size = new System.Drawing.Size(70, 25);
            this.numAutoOffMinutes.Value = new decimal(new int[] {

            30,

            0,

            0,

            0});
            this.numAutoOffMinutes.Name = "numAutoOffMinutes";
            this.numAutoOffMinutes.TabIndex = 18;
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.BackColor = System.Drawing.Color.Transparent;
            this.lblMinutes.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMinutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(161)))), ((int)(((byte)(194)))));
            this.lblMinutes.Location = new System.Drawing.Point(338, 317);
            this.lblMinutes.Size = new System.Drawing.Size(52, 22);
            this.lblMinutes.Text = "minutes";
            this.lblMinutes.UseMnemonic = false;
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.TabIndex = 19;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(40)))), ((int)(((byte)(217)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnSave.Image = global::SmartHomeLightingSystem.Properties.Resources.btn_save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Location = new System.Drawing.Point(24, 398);
            this.btnSave.Size = new System.Drawing.Size(190, 44);
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Name = "btnSave";
            this.btnSave.TabIndex = 20;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(17)))), ((int)(((byte)(46)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.btnCancel.FlatAppearance.BorderSize = 1;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(27)))), ((int)(((byte)(69)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.btnCancel.Location = new System.Drawing.Point(226, 398);
            this.btnCancel.Size = new System.Drawing.Size(190, 44);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // RoomSettingsForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(23)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(440, 466);
            this.Controls.Add(this.pnlDialog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Room Settings";
            this.Name = "RoomSettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.trackBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAutoOffMinutes)).EndInit();
            this.pnlDialog.ResumeLayout(false);
            this.pnlDialog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SmartHomeLightingSystem.Controls.RoundedPanel pnlDialog;
        private System.Windows.Forms.Label lblDialogIcon;
        private System.Windows.Forms.Label lblDialogTitle;
        private System.Windows.Forms.Label lblDialogSubtitle;
        private System.Windows.Forms.Button btnCloseDialog;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.Label lblBrightness;
        private System.Windows.Forms.Label lblBrightnessValue;
        private System.Windows.Forms.TrackBar trackBrightness;
        private System.Windows.Forms.Label lblColor;
        private SmartHomeLightingSystem.Controls.ColorSwatchButton swatchPurple;
        private SmartHomeLightingSystem.Controls.ColorSwatchButton swatchBlue;
        private SmartHomeLightingSystem.Controls.ColorSwatchButton swatchCyan;
        private SmartHomeLightingSystem.Controls.ColorSwatchButton swatchGreen;
        private SmartHomeLightingSystem.Controls.ColorSwatchButton swatchYellow;
        private SmartHomeLightingSystem.Controls.ColorSwatchButton swatchOrange;
        private SmartHomeLightingSystem.Controls.ColorSwatchButton swatchPink;
        private System.Windows.Forms.CheckBox chkAutoOff;
        private System.Windows.Forms.NumericUpDown numAutoOffMinutes;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
