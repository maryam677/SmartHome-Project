namespace SmartHomeRooms;

partial class RoomControlDialog
{
    private System.ComponentModel.IContainer components = null;
    private Label lblTitle;
    private Label lblAction;
    private ComboBox cmbAction;
    private Button btnCancel;
    private Button btnSave;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitle = new Label();
        lblAction = new Label();
        cmbAction = new ComboBox();
        btnCancel = new Button();
        btnSave = new Button();
        SuspendLayout();

        BackColor = Color.FromArgb(26, 26, 46);
        ClientSize = new Size(420, 280);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Smart Home";

        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblTitle.ForeColor = Color.White;
        lblTitle.Location = new Point(24, 20);
        lblTitle.Text = "More controls";

        lblAction.AutoSize = true;
        lblAction.ForeColor = Color.FromArgb(180, 180, 200);
        lblAction.Location = new Point(24, 64);
        lblAction.Text = "Choose action:";

        cmbAction.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbAction.FormattingEnabled = true;
        cmbAction.Items.AddRange(new object[]
        {
            "Turn all lights ON",
            "Turn all lights OFF",
            "Set temperature 22°C",
            "Night mode"
        });
        cmbAction.Location = new Point(24, 88);
        cmbAction.Size = new Size(360, 23);
        cmbAction.SelectedIndex = 0;

        btnCancel.DialogResult = DialogResult.Cancel;
        btnCancel.FlatStyle = FlatStyle.Flat;
        btnCancel.ForeColor = Color.White;
        btnCancel.BackColor = Color.FromArgb(55, 55, 85);
        btnCancel.FlatAppearance.BorderSize = 0;
        btnCancel.Location = new Point(24, 220);
        btnCancel.Size = new Size(100, 36);
        btnCancel.Text = "Cancel";

        btnSave.DialogResult = DialogResult.OK;
        btnSave.FlatStyle = FlatStyle.Flat;
        btnSave.ForeColor = Color.White;
        btnSave.BackColor = Color.FromArgb(108, 92, 231);
        btnSave.FlatAppearance.BorderSize = 0;
        btnSave.Location = new Point(284, 220);
        btnSave.Size = new Size(100, 36);
        btnSave.Text = "Save";

        AcceptButton = btnSave;
        CancelButton = btnCancel;
        Controls.Add(lblTitle);
        Controls.Add(lblAction);
        Controls.Add(cmbAction);
        Controls.Add(btnCancel);
        Controls.Add(btnSave);
        ResumeLayout(false);
        PerformLayout();
    }
}
