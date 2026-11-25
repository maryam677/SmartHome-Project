using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using WinFormsApp2.Data;

namespace WinFormsApp2.Controls;

static class RoomsTheme
{
    public static readonly Color Page = Color.FromArgb(10, 15, 38);
    public static readonly Color Card = Color.FromArgb(16, 26, 54);
    public static readonly Color CardBorder = Color.FromArgb(38, 54, 96);
    public static readonly Color CardHover = Color.FromArgb(72, 118, 196);
    public static readonly Color Muted = Color.FromArgb(154, 168, 196);
    public static readonly Color Green = Color.FromArgb(46, 214, 132);
    public static readonly Color RingTrack = Color.FromArgb(28, 42, 74);
    public static readonly Color Red = Color.FromArgb(255, 84, 104);
    public static readonly Color Pink = Color.FromArgb(255, 112, 140);
    public static readonly Color Blue = Color.FromArgb(41, 104, 242);
    public static readonly Color BlueHover = Color.FromArgb(64, 128, 255);
    public static readonly Color Bar = Color.FromArgb(47, 116, 255);
    public static readonly Color Grid = Color.FromArgb(42, 56, 92);
    public static readonly Color Icon = Color.FromArgb(196, 208, 226);

    public static readonly Font Title = new("Segoe UI", 18f, FontStyle.Bold);
    public static readonly Font Subtitle = new("Segoe UI", 9f);
    public static readonly Font CardName = new("Segoe UI", 11f, FontStyle.Bold);
    public static readonly Font Small = new("Segoe UI", 8.25f);
    public static readonly Font Status = new("Segoe UI", 9f);
    public static readonly Font Percent = new("Segoe UI", 11f, FontStyle.Bold);
    public static readonly Font ActiveLabel = new("Segoe UI", 7f);
    public static readonly Font ChartTitle = new("Segoe UI", 11.5f, FontStyle.Bold);
    public static readonly Font Axis = new("Segoe UI", 8f);
    public static readonly Font DonutNumber = new("Segoe UI", 20f, FontStyle.Bold);
    public static readonly Font ButtonFont = new("Segoe UI", 10.5f, FontStyle.Bold);

    public static void Prepare(Graphics g)
    {
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.PixelOffsetMode = PixelOffsetMode.HighQuality;
        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
        g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
    }
}

public sealed class AddRoomButton : Control
{
    private bool hovered;

    public AddRoomButton()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                 ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        Size = new Size(148, 40);
        Cursor = Cursors.Hand;
        AccessibleName = "Add Room";
    }

    protected override void OnMouseEnter(EventArgs e)
    {
        hovered = true;
        Invalidate();
        base.OnMouseEnter(e);
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        hovered = false;
        Invalidate();
        base.OnMouseLeave(e);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        RoomsTheme.Prepare(e.Graphics);
        Rectangle bounds = new Rectangle(0, 0, Width - 1, Height - 1);
        using GraphicsPath path = RoundedPanel.GetRoundedRectPath(bounds, 8);
        using SolidBrush fill = new SolidBrush(hovered ? RoomsTheme.BlueHover : RoomsTheme.Blue);
        e.Graphics.FillPath(fill, path);
        TextRenderer.DrawText(
            e.Graphics,
            "+  Add Room",
            RoomsTheme.ButtonFont,
            bounds,
            Color.White,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
    }
}

public sealed class RoomCardControl : Control
{
    private bool hovered;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string RoomName { get; set; } = "Room";
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int DeviceCount { get; set; }
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int ActivePercent { get; set; }
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool IsOn { get; set; } = true;
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public RoomPhotoKind Photo { get; set; }
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public RoomDevice[] Marks { get; set; } = Array.Empty<RoomDevice>();

    public event EventHandler? DevicesChanged;
    public event EventHandler? DeleteRequested;

    private readonly List<Rectangle> markHits = new();
    private Rectangle deleteHit;

    public RoomCardControl()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                 ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        BackColor = RoomsTheme.Page;
        Cursor = Cursors.Hand;
    }

    protected override void OnMouseEnter(EventArgs e)
    {
        hovered = true;
        Invalidate();
        base.OnMouseEnter(e);
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        hovered = false;
        Invalidate();
        base.OnMouseLeave(e);
    }

    protected override void OnMouseClick(MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            if (deleteHit.Contains(e.Location))
            {
                DeleteRequested?.Invoke(this, EventArgs.Empty);
                return;
            }

            for (int index = 0; index < markHits.Count && index < Marks.Length; index++)
            {
                if (!markHits[index].Contains(e.Location)) continue;
                Marks[index].IsOn = !Marks[index].IsOn;
                Invalidate();
                DevicesChanged?.Invoke(this, EventArgs.Empty);
                return;
            }
        }
        base.OnMouseClick(e);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        RoomsTheme.Prepare(g);

        Rectangle card = new Rectangle(0, 0, Width - 1, Height - 1);
        using (GraphicsPath path = RoundedPanel.GetRoundedRectPath(card, 12))
        {
            using SolidBrush fill = new SolidBrush(RoomsTheme.Card);
            using Pen border = new Pen(hovered ? RoomsTheme.CardHover : RoomsTheme.CardBorder, 1.2f);
            g.FillPath(fill, path);
            g.DrawPath(border, path);
        }

        int photoH = Math.Min(78, Math.Max(48, Height - 64));
        int photoW = Math.Min(128, (int)(photoH * 1.62));
        Rectangle photo = new Rectangle(14, 16, photoW, photoH);
        DrawPhoto(g, photo);

        int ringSize = Math.Min(78, Math.Max(58, Height - 70));
        Rectangle ring = new Rectangle(Width - 16 - ringSize, 14, ringSize, ringSize);
        int installed = Marks.Sum(mark => Math.Max(0, mark.Count));
        int running = Marks.Where(mark => mark.IsOn).Sum(mark => Math.Max(0, mark.Count));
        int percent = installed == 0 ? 0 : (int)Math.Round(100.0 * running / installed);
        bool roomOn = running > 0;
        ActivePercent = percent;
        DeviceCount = installed;
        IsOn = roomOn;

        int textX = photo.Right + 12;
        int textW = Math.Max(40, ring.Left - textX - 6);
        TextRenderer.DrawText(g, RoomName, RoomsTheme.CardName, new Rectangle(textX, 18, textW, 24),
            Color.White, TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis | TextFormatFlags.NoPadding);
        TextRenderer.DrawText(g, installed + " Devices", RoomsTheme.Small, new Rectangle(textX, 42, textW, 18),
            RoomsTheme.Muted, TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);

        Color dot = roomOn ? RoomsTheme.Green : RoomsTheme.Red;
        using (SolidBrush dotBrush = new SolidBrush(dot))
            g.FillEllipse(dotBrush, textX, 68, 8, 8);
        TextRenderer.DrawText(g, roomOn ? "On" : "Off", RoomsTheme.Status, new Rectangle(textX + 14, 62, 48, 20),
            Color.White, TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);

        DrawRing(g, ring);
        DrawMarks(g, Math.Min(Height - 30, photo.Bottom + 12));
    }

    private void DrawRing(Graphics g, Rectangle ring)
    {
        int thickness = 7;
        Rectangle arc = new Rectangle(
            ring.X + thickness,
            ring.Y + thickness,
            ring.Width - thickness * 2,
            ring.Height - thickness * 2);
        using Pen track = new Pen(RoomsTheme.RingTrack, thickness);
        g.DrawEllipse(track, arc);

        float sweep = Math.Clamp(ActivePercent, 0, 100) / 100f * 360f;
        if (sweep > 0)
        {
            using Pen progress = new Pen(RoomsTheme.Green, thickness)
            {
                StartCap = LineCap.Round,
                EndCap = LineCap.Round
            };
            if (sweep >= 359.5f)
                g.DrawEllipse(progress, arc);
            else
                g.DrawArc(progress, arc, -90, sweep);
        }

        TextRenderer.DrawText(g, ActivePercent + "%", RoomsTheme.Percent,
            new Rectangle(ring.X, ring.Y + ring.Height / 2 - 18, ring.Width, 22),
            Color.White, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
        TextRenderer.DrawText(g, "Active", RoomsTheme.ActiveLabel,
            new Rectangle(ring.X, ring.Y + ring.Height / 2 + 4, ring.Width, 16),
            RoomsTheme.Muted, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
    }

    private void DrawMarks(Graphics g, int y)
    {
        markHits.Clear();
        int x = 14;
        foreach (RoomDevice mark in Marks)
        {
            Rectangle pill = new Rectangle(x, y, 58, 24);
            markHits.Add(pill);
            bool on = mark.IsOn;
            Color color = on ? RoomsTheme.Green : RoomsTheme.Red;
            using GraphicsPath path = RoundedPanel.GetRoundedRectPath(pill, 8);
            using SolidBrush background = new SolidBrush(Color.FromArgb(on ? 46 : 36, color));
            using Pen border = new Pen(color, 1.3f);
            using Pen iconPen = new Pen(color, 1.35f)
            {
                StartCap = LineCap.Round,
                EndCap = LineCap.Round,
                LineJoin = LineJoin.Round
            };
            g.FillPath(background, path);
            g.DrawPath(border, path);
            RoomGlyphs.Draw(g, iconPen, mark.Glyph, new Rectangle(pill.X + 4, pill.Y + 4, 16, 16));
            TextRenderer.DrawText(g, on ? mark.Count.ToString() : "Off", RoomsTheme.Small,
                new Rectangle(pill.X + 22, pill.Y, pill.Width - 24, pill.Height), color,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
            x += 64;
        }

        deleteHit = new Rectangle(Math.Max(14, Width - 74), Math.Max(y, Height - 28), 60, 20);
        using GraphicsPath deletePath = RoundedPanel.GetRoundedRectPath(deleteHit, 6);
        using SolidBrush deleteFill = new SolidBrush(Color.FromArgb(72, 28, 40));
        using Pen deletePen = new Pen(RoomsTheme.Red, 1f);
        g.FillPath(deleteFill, deletePath);
        g.DrawPath(deletePen, deletePath);
        TextRenderer.DrawText(g, "Delete", RoomsTheme.Small, deleteHit, RoomsTheme.Red,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
    }

    private void DrawPhoto(Graphics g, Rectangle photo)
    {
        using GraphicsPath clip = RoundedPanel.GetRoundedRectPath(photo, 8);
        GraphicsState state = g.Save();
        g.SetClip(clip);
        Image? image = PhotoImage();
        if (image != null)
        {
            g.DrawImage(image, photo);
            if (Photo == RoomPhotoKind.Kids)
                DrawKidsMarks(g, photo);
        }
        else
        {
            DrawIllustratedRoom(g, photo);
        }
        g.Restore(state);
        using Pen frame = new Pen(Color.FromArgb(50, 70, 110), 1f);
        g.DrawPath(frame, clip);
    }

    private Image? PhotoImage()
    {
        return Photo switch
        {
            RoomPhotoKind.Living => Properties.Resources.living_room,
            RoomPhotoKind.Bedroom => Properties.Resources.bedroom,
            RoomPhotoKind.Kitchen => Properties.Resources.kitchen,
            RoomPhotoKind.Bathroom => null,
            RoomPhotoKind.Kids => Properties.Resources.bedroom,
            _ => null
        };
    }

    private void DrawIllustratedRoom(Graphics g, Rectangle photo)
    {
        if (Photo == RoomPhotoKind.Office)
        {
            using LinearGradientBrush wall = new LinearGradientBrush(photo, Color.FromArgb(88, 104, 128), Color.FromArgb(46, 58, 78), 90f);
            g.FillRectangle(wall, photo);
            Rectangle window = new Rectangle(photo.X + 14, photo.Y + 10, 36, 28);
            using SolidBrush glass = new SolidBrush(Color.FromArgb(168, 206, 230));
            g.FillRectangle(glass, window);
            g.DrawRectangle(Pens.White, window);
            Rectangle desk = new Rectangle(photo.X + 8, photo.Bottom - 28, photo.Width - 16, 16);
            using SolidBrush wood = new SolidBrush(Color.FromArgb(92, 64, 42));
            g.FillRectangle(wood, desk);
            Rectangle monitor = new Rectangle(photo.X + photo.Width / 2 - 16, photo.Y + 28, 34, 22);
            using SolidBrush screen = new SolidBrush(Color.FromArgb(36, 92, 168));
            g.FillRectangle(Brushes.DimGray, monitor);
            g.FillRectangle(screen, monitor.X + 2, monitor.Y + 2, monitor.Width - 4, monitor.Height - 6);
            return;
        }

        if (Photo == RoomPhotoKind.Bathroom)
        {
            using LinearGradientBrush wall = new LinearGradientBrush(photo, Color.FromArgb(214, 228, 236), Color.FromArgb(150, 176, 194), 90f);
            g.FillRectangle(wall, photo);
            Rectangle mirror = new Rectangle(photo.X + photo.Width / 2 - 22, photo.Y + 8, 44, 28);
            using SolidBrush mirrorFill = new SolidBrush(Color.FromArgb(186, 214, 228));
            g.FillRectangle(mirrorFill, mirror);
            g.DrawRectangle(Pens.White, mirror);
            Rectangle basin = new Rectangle(photo.X + 18, photo.Bottom - 30, photo.Width - 36, 16);
            using SolidBrush basinFill = new SolidBrush(Color.FromArgb(236, 240, 244));
            g.FillEllipse(basinFill, basin);
            g.DrawEllipse(Pens.DimGray, basin);
            g.DrawLine(Pens.DimGray, photo.X + photo.Width / 2, photo.Y + 36, photo.X + photo.Width / 2, photo.Bottom - 26);
            return;
        }

        using LinearGradientBrush fallback = new LinearGradientBrush(photo, Color.FromArgb(48, 64, 104), Color.FromArgb(24, 32, 64), 90f);
        g.FillRectangle(fallback, photo);
    }

    private static void DrawKidsMarks(Graphics g, Rectangle photo)
    {
        using SolidBrush star = new SolidBrush(Color.FromArgb(230, 255, 214, 92));
        Point[] spots =
        {
            new(photo.X + 16, photo.Y + 12),
            new(photo.X + 34, photo.Y + 22),
            new(photo.Right - 22, photo.Y + 14)
        };
        foreach (Point spot in spots)
            g.FillEllipse(star, spot.X, spot.Y, 7, 7);
    }
}

public sealed class RoomEnergyChart : Control
{
    private (string Name, double Kwh)[] rows = Array.Empty<(string, double)>();

    public RoomEnergyChart()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                 ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        BackColor = RoomsTheme.Page;
    }

    public void SetRows(IReadOnlyList<(string Name, double Kwh)> source)
    {
        rows = source.ToArray();
        Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        RoomsTheme.Prepare(g);
        Rectangle card = new Rectangle(0, 0, Width - 1, Height - 1);
        using (GraphicsPath path = RoundedPanel.GetRoundedRectPath(card, 12))
        {
            using SolidBrush fill = new SolidBrush(RoomsTheme.Card);
            using Pen border = new Pen(RoomsTheme.CardBorder, 1.2f);
            g.FillPath(fill, path);
            g.DrawPath(border, path);
        }

        TextRenderer.DrawText(g, "Energy Consumption by Room (kWh)", RoomsTheme.ChartTitle,
            new Rectangle(16, 12, Width - 32, 26), Color.White,
            TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis | TextFormatFlags.NoPadding);

        if (rows.Length == 0) return;

        int left = 118;
        int right = Width - 28;
        int top = 52;
        int bottom = Height - 46;
        if (right <= left || bottom <= top) return;

        double axisMax = 14;
        double peak = rows.Max(row => row.Kwh);
        while (peak > axisMax) axisMax += 2;

        using Pen gridPen = new Pen(RoomsTheme.Grid, 1f);
        int steps = (int)(axisMax / 2);
        for (int step = 0; step <= steps; step++)
        {
            int x = left + (int)Math.Round((right - left) * (step * 2 / axisMax));
            g.DrawLine(gridPen, x, top, x, bottom);
            TextRenderer.DrawText(g, (step * 2).ToString(), RoomsTheme.Axis,
                new Rectangle(x - 14, bottom + 4, 28, 16), RoomsTheme.Muted,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.Top | TextFormatFlags.NoPadding);
        }

        int slot = (bottom - top) / rows.Length;
        int barH = Math.Clamp(slot - 14, 8, 14);
        for (int i = 0; i < rows.Length; i++)
        {
            int y = top + i * slot + (slot - barH) / 2;
            TextRenderer.DrawText(g, rows[i].Name, RoomsTheme.Small,
                new Rectangle(12, y - 2, left - 20, barH + 4), RoomsTheme.Muted,
                TextFormatFlags.Right | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis | TextFormatFlags.NoPadding);

            int barW = (int)Math.Round((right - left) * (rows[i].Kwh / axisMax));
            barW = Math.Max(2, barW);
            Rectangle bar = new Rectangle(left, y, barW, barH);
            using GraphicsPath barPath = RoundedPanel.GetRoundedRectPath(bar, barH / 2);
            using SolidBrush barBrush = new SolidBrush(RoomsTheme.Bar);
            g.FillPath(barBrush, barPath);

            string value = rows[i].Kwh.ToString("0.0", System.Globalization.CultureInfo.InvariantCulture) + " kWh";
            int labelX = left + barW + 6;
            if (labelX + 68 > Width - 10)
                labelX = Math.Max(left + 4, left + barW - 68);
            TextRenderer.DrawText(g, value, RoomsTheme.Small,
                new Rectangle(labelX, y - 2, 72, barH + 4), Color.White,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
        }

        TextRenderer.DrawText(g, "Energy (kWh)", RoomsTheme.Axis,
            new Rectangle(left, Height - 22, right - left, 16), RoomsTheme.Muted,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
    }
}

public sealed class DeviceStatusDonut : Control
{
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int ActiveCount { get; set; } = 20;
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int InactiveCount { get; set; } = 6;

    public DeviceStatusDonut()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                 ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        BackColor = RoomsTheme.Page;
    }

    public void SetCounts(int active, int inactive)
    {
        ActiveCount = Math.Max(0, active);
        InactiveCount = Math.Max(0, inactive);
        Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        RoomsTheme.Prepare(g);
        Rectangle card = new Rectangle(0, 0, Width - 1, Height - 1);
        using (GraphicsPath path = RoundedPanel.GetRoundedRectPath(card, 12))
        {
            using SolidBrush fill = new SolidBrush(RoomsTheme.Card);
            using Pen border = new Pen(RoomsTheme.CardBorder, 1.2f);
            g.FillPath(fill, path);
            g.DrawPath(border, path);
        }

        TextRenderer.DrawText(g, "Devices Status", RoomsTheme.ChartTitle,
            new Rectangle(16, 12, Width - 32, 26), Color.White,
            TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);

        int total = ActiveCount + InactiveCount;
        int diameter = Math.Min(Height - 78, Math.Min(168, Width / 2));
        diameter = Math.Max(90, diameter);
        Rectangle ring = new Rectangle(22, 52 + Math.Max(0, (Height - 70 - diameter) / 2), diameter, diameter);
        int thickness = Math.Max(14, diameter / 8);
        Rectangle arc = new Rectangle(ring.X + thickness / 2, ring.Y + thickness / 2, ring.Width - thickness, ring.Height - thickness);

        using Pen track = new Pen(RoomsTheme.RingTrack, thickness);
        g.DrawEllipse(track, arc);

        if (total > 0)
        {
            float activeSweep = 360f * ActiveCount / total;
            using Pen green = new Pen(RoomsTheme.Green, thickness) { StartCap = LineCap.Flat, EndCap = LineCap.Flat };
            using Pen pink = new Pen(RoomsTheme.Pink, thickness) { StartCap = LineCap.Flat, EndCap = LineCap.Flat };
            // Pink occupies the top-right slice, matching the reference layout.
            float inactiveSweep = 360f - activeSweep;
            g.DrawArc(pink, arc, -90, inactiveSweep);
            g.DrawArc(green, arc, -90 + inactiveSweep, activeSweep);
        }

        int hole = Math.Max(36, arc.Width - thickness - 8);
        Rectangle holeBox = new Rectangle(
            arc.X + (arc.Width - hole) / 2,
            arc.Y + (arc.Height - hole) / 2,
            hole,
            hole);
        using (SolidBrush holeFill = new SolidBrush(RoomsTheme.Card))
            g.FillEllipse(holeFill, holeBox);

        float numberSize = Math.Max(11f, Math.Min(18f, hole / 4.2f));
        using Font numberFont = new Font("Segoe UI", numberSize, FontStyle.Bold, GraphicsUnit.Point);
        using Font captionFont = new Font("Segoe UI", Math.Max(7.5f, numberSize * 0.48f), FontStyle.Regular, GraphicsUnit.Point);
        using SolidBrush numberBrush = new SolidBrush(Color.White);
        using SolidBrush captionBrush = new SolidBrush(RoomsTheme.Muted);
        using StringFormat centered = new StringFormat
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center,
            FormatFlags = StringFormatFlags.NoWrap
        };
        g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
        RectangleF numberRect = new RectangleF(holeBox.X, holeBox.Y + hole * 0.22f, holeBox.Width, hole * 0.40f);
        RectangleF captionRect = new RectangleF(holeBox.X, holeBox.Y + hole * 0.56f, holeBox.Width, hole * 0.24f);
        g.DrawString(total.ToString(), numberFont, numberBrush, numberRect, centered);
        g.DrawString("Devices", captionFont, captionBrush, captionRect, centered);

        int legendX = ring.Right + 18;
        int legendW = Math.Max(40, Width - legendX - 16);
        int activePct = total == 0 ? 0 : (int)Math.Round(100.0 * ActiveCount / total);
        int inactivePct = total == 0 ? 0 : 100 - activePct;
        DrawLegend(g, legendX, ring.Y + ring.Height / 2 - 28, legendW, RoomsTheme.Green,
            "Active (" + ActiveCount + ")", activePct + "%");
        DrawLegend(g, legendX, ring.Y + ring.Height / 2 + 6, legendW, RoomsTheme.Pink,
            "Inactive (" + InactiveCount + ")", inactivePct + "%");
    }

    private static void DrawLegend(Graphics g, int x, int y, int width, Color color, string label, string percent)
    {
        using SolidBrush swatch = new SolidBrush(color);
        g.FillRectangle(swatch, x, y + 4, 12, 12);
        TextRenderer.DrawText(g, label, RoomsTheme.Small, new Rectangle(x + 20, y, width - 52, 20),
            RoomsTheme.Muted, TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis | TextFormatFlags.NoPadding);
        TextRenderer.DrawText(g, percent, RoomsTheme.Status, new Rectangle(x, y, width, 20),
            Color.White, TextFormatFlags.Right | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
    }
}

static class RoomGlyphs
{
    public static void Draw(Graphics g, Pen pen, RoomDeviceGlyph glyph, Rectangle box)
    {
        float l = box.Left;
        float t = box.Top;
        float r = box.Right;
        float b = box.Bottom;
        float cx = box.Left + box.Width / 2f;
        float cy = box.Top + box.Height / 2f;

        switch (glyph)
        {
            case RoomDeviceGlyph.Bulb:
                g.DrawEllipse(pen, l + 3, t + 1, box.Width - 6, box.Height - 8);
                g.DrawLine(pen, cx - 3, b - 3, cx + 3, b - 3);
                g.DrawLine(pen, cx, t + box.Height - 7, cx, b - 3);
                break;
            case RoomDeviceGlyph.Screen:
                g.DrawRectangle(pen, l + 1, t + 2, box.Width - 3, box.Height - 8);
                g.DrawLine(pen, cx, b - 5, cx, b - 2);
                g.DrawLine(pen, cx - 4, b - 2, cx + 4, b - 2);
                break;
            case RoomDeviceGlyph.Thermo:
                g.DrawLine(pen, cx, t + 1, cx, b - 5);
                g.DrawEllipse(pen, cx - 3, b - 7, 6, 6);
                break;
            case RoomDeviceGlyph.Camera:
                g.DrawRectangle(pen, l + 1, t + 4, box.Width - 3, box.Height - 7);
                g.DrawEllipse(pen, cx - 3, cy - 1, 6, 6);
                g.DrawLine(pen, l + 3, t + 4, l + 6, t + 1);
                break;
            case RoomDeviceGlyph.Snowflake:
                g.DrawLine(pen, cx, t + 1, cx, b - 1);
                g.DrawLine(pen, l + 2, cy, r - 2, cy);
                g.DrawLine(pen, l + 3, t + 3, r - 3, b - 3);
                g.DrawLine(pen, r - 3, t + 3, l + 3, b - 3);
                break;
            case RoomDeviceGlyph.Fridge:
                g.DrawRectangle(pen, l + 3, t + 1, box.Width - 6, box.Height - 2);
                g.DrawLine(pen, l + 3, cy, r - 3, cy);
                break;
            case RoomDeviceGlyph.Faucet:
                g.DrawArc(pen, l + 2, t + 2, box.Width - 4, box.Height - 4, 200, 140);
                g.DrawLine(pen, cx, t + 2, cx, t + 6);
                g.DrawLine(pen, cx, b - 2, cx, b - 6);
                break;
            case RoomDeviceGlyph.Drop:
                using (GraphicsPath drop = new GraphicsPath())
                {
                    drop.AddArc(l + 3, cy - 2, box.Width - 6, box.Height / 2f + 2, 0, 180);
                    drop.AddLine(l + 3, cy, cx, t + 1);
                    drop.AddLine(cx, t + 1, r - 3, cy);
                    g.DrawPath(pen, drop);
                }
                break;
            case RoomDeviceGlyph.Fan:
                g.DrawEllipse(pen, cx - 2, cy - 2, 4, 4);
                g.DrawArc(pen, l + 1, t + 1, box.Width - 4, box.Height / 2f, 200, 140);
                g.DrawArc(pen, l + 1, cy - 2, box.Width - 4, box.Height / 2f, 20, 140);
                break;
            case RoomDeviceGlyph.Printer:
                g.DrawRectangle(pen, l + 2, cy - 2, box.Width - 4, box.Height / 2f);
                g.DrawRectangle(pen, l + 4, t + 1, box.Width - 8, 6);
                break;
        }
    }
}
