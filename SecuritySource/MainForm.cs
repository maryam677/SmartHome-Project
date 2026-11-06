using SmartHome;

namespace WinFormsApp2.SmartHomeSecurity;

// Main window: side menu + pnlContent where each page (UserControl) is shown.
public class MainForm : Form
{
    // One shared service for the whole app so alarm/door/camera state survives page changes.
    private readonly SecurityService _security = new(new JsonSecurityRepository());

    private readonly Panel pnlSide = new();
    private readonly Panel pnlContent = new();
    private UserControl? _current;

    public MainForm()
    {
        Text = "Smart Home";
        Size = new Size(1400, 900);
        MinimumSize = new Size(1000, 700);
        StartPosition = FormStartPosition.CenterScreen;
        BackColor = SecTheme.Page;

        pnlContent.Dock = DockStyle.Fill;
        pnlContent.BackColor = SecTheme.Page;

        pnlSide.Dock = DockStyle.Left;
        pnlSide.Width = 210;
        pnlSide.BackColor = SecTheme.Card;

        var lblBrand = new Label
        {
            AutoSize = true,
            Text = "Smart Home",
            Font = new Font("Segoe UI", 16F, FontStyle.Bold),
            ForeColor = Color.White,
            BackColor = SecTheme.Card,
            Location = new Point(20, 24)
        };

        // Add other pages' buttons here (each teammate adds theirs).
        var btnSecurity = new SecRoundButton
        {
            Text = "Security Center",
            FillColor = SecTheme.Accent,
            BackColor = SecTheme.Card,
            Location = new Point(14, 90),
            Size = new Size(182, 44)
        };
        btnSecurity.Click += (_, _) => ShowSecurityPage();

        pnlSide.Controls.Add(lblBrand);
        pnlSide.Controls.Add(btnSecurity);

        // Fill control first, then the edge-docked one.
        Controls.Add(pnlContent);
        Controls.Add(pnlSide);

        ShowSecurityPage();
    }

    private void ShowPage(UserControl page)
    {
        pnlContent.SuspendLayout();
        pnlContent.Controls.Clear();
        _current?.Dispose(); // pages unsubscribe from the service in Disposed
        _current = page;
        page.Dock = DockStyle.Fill;
        pnlContent.Controls.Add(page);
        pnlContent.ResumeLayout();
    }

    private void ShowSecurityPage() => ShowPage(new SecurityCenterControl(_security));
}
