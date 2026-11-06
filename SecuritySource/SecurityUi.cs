using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace WinFormsApp2.SmartHomeSecurity;

// Shared colors, fonts and drawing helpers for the Security Center page.
internal static class SecTheme
{
    public static readonly Color Page = Color.FromArgb(14, 12, 38);
    public static readonly Color Card = Color.FromArgb(26, 22, 62);
    public static readonly Color CardBorder = Color.FromArgb(58, 51, 128);
    public static readonly Color Tile = Color.FromArgb(40, 36, 86);
    public static readonly Color Accent = Color.FromArgb(124, 77, 255);
    public static readonly Color AccentSoft = Color.FromArgb(179, 157, 255);
    public static readonly Color Muted = Color.FromArgb(169, 166, 201);
    public static readonly Color Good = Color.FromArgb(111, 227, 160);
    public static readonly Color Warn = Color.FromArgb(255, 167, 38);
    public static readonly Color Bad = Color.FromArgb(255, 107, 107);

    public const string IconFontName = "Segoe MDL2 Assets";
    public static readonly Font Icon14 = new(IconFontName, 14F);
    public static readonly Font Icon30 = new(IconFontName, 30F);
    public static readonly Font Body = new("Segoe UI", 9F);
    public static readonly Font Small = new("Segoe UI", 8F);
    public static readonly Font Bold = new("Segoe UI", 12F, FontStyle.Bold);
    public static readonly Font SemiBold = new("Segoe UI", 9.5F, FontStyle.Bold);

    private const TextFormatFlags Base =
        TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine |
        TextFormatFlags.NoPadding | TextFormatFlags.NoPrefix | TextFormatFlags.EndEllipsis;

    public const TextFormatFlags Center = Base | TextFormatFlags.HorizontalCenter;
    public const TextFormatFlags Left = Base | TextFormatFlags.Left;
    public const TextFormatFlags Right = Base | TextFormatFlags.Right;

    public static void Text(Graphics g, string text, Font font, Color color, Rectangle bounds, TextFormatFlags flags)
        => TextRenderer.DrawText(g, text, font, bounds, color, flags);

    public static GraphicsPath RoundRect(Rectangle r, int radius)
    {
        int d = radius * 2;
        d = Math.Max(1, Math.Min(d, Math.Min(r.Width, r.Height)));
        var p = new GraphicsPath();
        p.AddArc(r.X, r.Y, d, d, 180, 90);
        p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
        p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
        p.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
        p.CloseFigure();
        return p;
    }

    public static void FillRound(Graphics g, Rectangle r, int radius, Color fill, Color? border)
    {
        using var path = RoundRect(r, radius);
        using var brush = new SolidBrush(fill);
        g.FillPath(brush, path);
        if (border.HasValue)
        {
            using var pen = new Pen(border.Value, 1f);
            g.DrawPath(pen, path);
        }
    }
}

// Rounded dark card (used for the stat boxes and the alarm panel).
public class SecCard : Panel
{
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public int Radius { get; set; } = 16;

    public SecCard()
    {
        SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                 ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        BackColor = SecTheme.Page;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        SecTheme.FillRound(e.Graphics, new Rectangle(0, 0, Width - 1, Height - 1),
            Radius, SecTheme.Card, SecTheme.CardBorder);
    }
}

// Rounded flat button.
public class SecRoundButton : Control
{
    private bool _hover;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Color FillColor { get; set; } = SecTheme.Accent;
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Color HoverColor { get; set; } = Color.FromArgb(150, 110, 255);
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public int Radius { get; set; } = 10;

    public SecRoundButton()
    {
        SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                 ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw |
                 ControlStyles.Selectable, true);
        BackColor = SecTheme.Card;
        ForeColor = Color.White;
        Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        Cursor = Cursors.Hand;
    }

    protected override void OnMouseEnter(EventArgs e) { base.OnMouseEnter(e); _hover = true; Invalidate(); }
    protected override void OnMouseLeave(EventArgs e) { base.OnMouseLeave(e); _hover = false; Invalidate(); }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;
        SecTheme.FillRound(g, new Rectangle(0, 0, Width - 1, Height - 1), Radius,
            _hover ? HoverColor : FillColor, null);
        SecTheme.Text(g, Text, Font, ForeColor, ClientRectangle, SecTheme.Center);
    }
}

// One security zone (room) card, styled like the Rooms Overview cards.
public class SecZoneCard : Control
{
    private bool _motion, _door, _alert;
    private bool _camera = true;
    private readonly Rectangle[] _tiles = new Rectangle[4];

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public string ZoneName { get; set; } = "";
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public string Subtitle { get; set; } = "";

    [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    internal bool MotionActive { get => _motion; set { if (_motion != value) { _motion = value; Invalidate(); } } }
    [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    internal bool DoorOpen { get => _door; set { if (_door != value) { _door = value; Invalidate(); } } }
    [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    internal bool CameraOn { get => _camera; set { if (_camera != value) { _camera = value; Invalidate(); } } }
    [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    internal bool Alert { get => _alert; set { if (_alert != value) { _alert = value; Invalidate(); } } }

    // tile index: 0 = motion, 1 = door, 2 = camera, 3 = more
    public event Action<SecZoneCard, int>? TileClicked;

    public SecZoneCard()
    {
        SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                 ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        BackColor = SecTheme.Page;
    }

    private int S(int v) => (int)Math.Round(v * DeviceDpi / 96.0);

    private void ComputeTiles()
    {
        int pad = S(14), gap = S(8);
        int tw = (Width - pad * 2 - gap * 3) / 4;
        for (int i = 0; i < 4; i++)
            _tiles[i] = new Rectangle(pad + i * (tw + gap), S(206), tw, S(58));
    }

    protected override void OnMouseClick(MouseEventArgs e)
    {
        base.OnMouseClick(e);
        ComputeTiles();
        for (int i = 0; i < 4; i++)
        {
            if (_tiles[i].Contains(e.Location)) { TileClicked?.Invoke(this, i); break; }
        }
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
        base.OnMouseMove(e);
        ComputeTiles();
        Cursor = _tiles.Any(t => t.Contains(e.Location)) ? Cursors.Hand : Cursors.Default;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;
        int w = Width, pad = S(14);

        SecTheme.FillRound(g, new Rectangle(0, 0, w - 1, Height - 1), S(16),
            SecTheme.Card, _alert ? SecTheme.Bad : SecTheme.CardBorder);

        // header band (stands in for the room photo)
        var head = new Rectangle(S(8), S(8), w - S(16), S(80));
        using (var path = SecTheme.RoundRect(head, S(12)))
        using (var br = new LinearGradientBrush(head, Color.FromArgb(78, 52, 168), Color.FromArgb(32, 27, 78), 20f))
            g.FillPath(br, path);
        SecTheme.Text(g, "\uE80F", SecTheme.Icon30, Color.FromArgb(150, 125, 235),
            new Rectangle(head.Right - S(80), head.Y, S(70), head.Height), SecTheme.Center);

        // status pill
        var pill = new Rectangle(head.X + S(10), head.Y + S(10), S(84), S(24));
        SecTheme.FillRound(g, pill, pill.Height / 2, Color.FromArgb(20, 17, 47), null);
        Color pc = _alert ? SecTheme.Bad : SecTheme.Good;
        using (var dot = new SolidBrush(pc))
            g.FillEllipse(dot, pill.X + S(10), pill.Y + (pill.Height - S(8)) / 2, S(8), S(8));
        SecTheme.Text(g, _alert ? "Alert" : "Online", SecTheme.Small, Color.White,
            new Rectangle(pill.X + S(22), pill.Y, pill.Width - S(26), pill.Height), SecTheme.Left);

        // name, status, subtitle
        int nameTop = S(98);
        SecTheme.Text(g, ZoneName, SecTheme.Bold, Color.White,
            new Rectangle(pad, nameTop, w - pad * 2 - S(110), S(24)), SecTheme.Left);
        string st = _motion ? "Motion" : _door ? "Door open" : "Secure";
        Color sc = _motion || _door ? SecTheme.Warn : SecTheme.Good;
        SecTheme.Text(g, st, SecTheme.SemiBold, sc,
            new Rectangle(w - pad - S(110), nameTop, S(110), S(24)), SecTheme.Right);
        SecTheme.Text(g, Subtitle, SecTheme.Body, SecTheme.Muted,
            new Rectangle(pad, S(122), w - pad * 2, S(18)), SecTheme.Left);

        // info strip
        var strip = new Rectangle(pad, S(146), w - pad * 2, S(30));
        SecTheme.FillRound(g, strip, S(8), Color.FromArgb(32, 28, 72), SecTheme.CardBorder);
        int mid = strip.X + strip.Width / 2;
        SecTheme.Text(g, "1 Camera", SecTheme.Body, SecTheme.Muted,
            new Rectangle(strip.X, strip.Y, strip.Width / 2, strip.Height), SecTheme.Center);
        SecTheme.Text(g, "2 Sensors", SecTheme.Body, SecTheme.Muted,
            new Rectangle(mid, strip.Y, strip.Width / 2, strip.Height), SecTheme.Center);
        using (var pen = new Pen(SecTheme.CardBorder))
            g.DrawLine(pen, mid, strip.Y + S(6), mid, strip.Bottom - S(6));

        SecTheme.Text(g, "Quick Controls", SecTheme.SemiBold, Color.White,
            new Rectangle(pad, S(184), S(200), S(18)), SecTheme.Left);

        // quick control tiles
        ComputeTiles();
        string[] glyph = { "\uE7B3", _door ? "\uE785" : "\uE72E", "\uE722", "\uE712" };
        string[] label = { "Motion", "Door", "Camera", "More" };
        string[] state = { _motion ? "Detected" : "Clear", _door ? "Open" : "Closed", _camera ? "Active" : "Off", "Reset" };
        bool[] on = { _motion, _door, _camera, false };
        Color warnFill = Color.FromArgb(150, 92, 20);
        Color[] fill =
        {
            _motion ? warnFill : SecTheme.Tile,
            _door ? warnFill : SecTheme.Tile,
            _camera ? SecTheme.Accent : SecTheme.Tile,
            SecTheme.Tile
        };

        for (int i = 0; i < 4; i++)
        {
            var t = _tiles[i];
            SecTheme.FillRound(g, t, S(10), fill[i], null);
            SecTheme.Text(g, glyph[i], SecTheme.Icon14, on[i] ? Color.White : SecTheme.AccentSoft,
                new Rectangle(t.X, t.Y + S(4), t.Width, S(22)), SecTheme.Center);
            SecTheme.Text(g, label[i], SecTheme.Small, Color.White,
                new Rectangle(t.X, t.Y + S(25), t.Width, S(15)), SecTheme.Center);
            SecTheme.Text(g, state[i], SecTheme.Small, on[i] ? Color.FromArgb(235, 225, 255) : SecTheme.Muted,
                new Rectangle(t.X, t.Y + S(40), t.Width, S(14)), SecTheme.Center);
        }
    }
}
