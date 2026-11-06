using WinFormsApp2.SmartHomeSecurity;

namespace WinFormsApp2.SmartHomeSecurity.Popups;

// Small borderless alert window in the Security Center theme.
// Show it with:  new AlarmPopup("Garage").Show(FindForm());
public class AlarmPopup : Form
{
    private readonly System.Windows.Forms.Timer _autoClose = new() { Interval = 8000 };

    public AlarmPopup(string source, string title = "Intrusion detected!")
    {
        FormBorderStyle = FormBorderStyle.None;
        StartPosition = FormStartPosition.CenterParent;
        ShowInTaskbar = false;
        KeyPreview = true;
        BackColor = SecTheme.Card;
        Size = new Size(380, 190);

        var lblIcon = new Label
        {
            AutoSize = true,
            Text = "\uE7BA", // warning icon (Segoe MDL2 Assets)
            Font = new Font(SecTheme.IconFontName, 26F),
            ForeColor = SecTheme.Bad,
            BackColor = SecTheme.Card,
            Location = new Point(22, 20)
        };
        var lblTitle = new Label
        {
            AutoSize = true,
            Text = title,
            Font = new Font("Segoe UI", 14F, FontStyle.Bold),
            ForeColor = Color.White,
            BackColor = SecTheme.Card,
            Location = new Point(74, 20)
        };
        var lblMsg = new Label
        {
            AutoSize = false,
            Text = $"Source: {source}\r\n{DateTime.Now:HH:mm:ss}",
            Font = new Font("Segoe UI", 10F),
            ForeColor = SecTheme.Muted,
            BackColor = SecTheme.Card,
            Location = new Point(76, 56),
            Size = new Size(280, 50)
        };
        var btnClose = new SecRoundButton
        {
            Text = "Dismiss",
            FillColor = SecTheme.Accent,
            BackColor = SecTheme.Card,
            Location = new Point(22, 120),
            Size = new Size(336, 44)
        };
        btnClose.Click += (_, _) => Close();

        Controls.Add(lblIcon);
        Controls.Add(lblTitle);
        Controls.Add(lblMsg);
        Controls.Add(btnClose);

        // Close itself after a few seconds so alerts never pile up.
        _autoClose.Tick += (_, _) => Close();
        Shown += (_, _) => _autoClose.Start();
        FormClosed += (_, _) => { _autoClose.Stop(); _autoClose.Dispose(); };
    }

    // Don't steal focus from whatever the user is doing.
    protected override bool ShowWithoutActivation => true;

    protected override void OnKeyDown(KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Escape) Close();
        base.OnKeyDown(e);
    }

    // Red border, since the form has no title bar.
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        using var pen = new Pen(SecTheme.Bad, 2);
        e.Graphics.DrawRectangle(pen, 1, 1, Width - 3, Height - 3);
    }
}
