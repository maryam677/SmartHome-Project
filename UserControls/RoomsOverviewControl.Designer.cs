namespace WinFormsApp2;

partial class RoomsOverviewControl
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        SuspendLayout();
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(10, 15, 38);
        Name = "RoomsOverviewControl";
        Size = new Size(1180, 760);
        ResumeLayout(false);
    }
}
