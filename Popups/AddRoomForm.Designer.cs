namespace WinFormsApp2.Popups;

partial class AddRoomForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code
    private void InitializeComponent()
    {
        lblTitle = new Label();
        lblRoomName = new Label();
        txtRoomName = new TextBox();
        lblRoomType = new Label();
        cmbRoomType = new ComboBox();
        btnAdd = new Button();
        btnCancel = new Button();
        SuspendLayout();
        lblTitle.Name = "lblTitle";
        lblTitle.Text = "Add New Room";
        lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblTitle.AutoSize = true;
        lblTitle.Location = new Point(25, 20);
        lblRoomName.Name = "lblRoomName";
        lblRoomName.Text = "Room Name";
        lblRoomName.AutoSize = true;
        lblRoomName.Location = new Point(25, 85);
        txtRoomName.Name = "txtRoomName";
        txtRoomName.Location = new Point(25, 115);
        txtRoomName.Size = new Size(370, 30);
        txtRoomName.TabIndex = 0;
        lblRoomType.Name = "lblRoomType";
        lblRoomType.Text = "Room Type";
        lblRoomType.AutoSize = true;
        lblRoomType.Location = new Point(25, 165);
        cmbRoomType.Name = "cmbRoomType";
        cmbRoomType.Location = new Point(25, 195);
        cmbRoomType.Size = new Size(370, 30);
        cmbRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbRoomType.Items.AddRange(new object[] { "Living Room", "Bedroom", "Kitchen", "Bathroom", "Garage", "Office", "Other" });
        cmbRoomType.TabIndex = 1;
        btnAdd.Name = "btnAdd";
        btnAdd.Text = "Add";
        btnAdd.Location = new Point(185, 265);
        btnAdd.Size = new Size(100, 38);
        btnAdd.BackColor = Color.FromArgb(108, 92, 231);
        btnAdd.ForeColor = Color.White;
        btnAdd.FlatStyle = FlatStyle.Flat;
        btnAdd.FlatAppearance.BorderSize = 0;
        btnAdd.UseVisualStyleBackColor = false;
        btnAdd.TabIndex = 2;
        btnAdd.Click += Add_Click;
        btnCancel.Name = "btnCancel";
        btnCancel.Text = "Cancel";
        btnCancel.Location = new Point(295, 265);
        btnCancel.Size = new Size(100, 38);
        btnCancel.BackColor = Color.FromArgb(55, 55, 85);
        btnCancel.ForeColor = Color.White;
        btnCancel.FlatStyle = FlatStyle.Flat;
        btnCancel.FlatAppearance.BorderSize = 0;
        btnCancel.UseVisualStyleBackColor = false;
        btnCancel.DialogResult = DialogResult.Cancel;
        btnCancel.TabIndex = 3;
        AcceptButton = btnAdd;
        CancelButton = btnCancel;
        AutoScaleDimensions = new SizeF(9F, 23F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(27, 32, 70);
        ForeColor = Color.White;
        Font = new Font("Segoe UI", 10.2F);
        ClientSize = new Size(420, 330);
        Controls.Add(lblTitle);
        Controls.Add(lblRoomName);
        Controls.Add(txtRoomName);
        Controls.Add(lblRoomType);
        Controls.Add(cmbRoomType);
        Controls.Add(btnAdd);
        Controls.Add(btnCancel);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Name = "AddRoomForm";
        Text = "Add Room";
        ResumeLayout(false);
        PerformLayout();
    }
    #endregion

    private Label lblTitle;
    private Label lblRoomName;
    private TextBox txtRoomName;
    private Label lblRoomType;
    private ComboBox cmbRoomType;
    private Button btnAdd;
    private Button btnCancel;
}
