using System.Drawing.Drawing2D;
using System.Globalization;

namespace WinFormsApp2.classes
{
    public class AutomationTimeline : Control
    {
        private static readonly int[] SegmentHours = { 0, 6, 9, 17, 21, 24 };
        private static readonly (string Name, Color Color)[] Segments =
        {
            ("Night Mode", Color.FromArgb(96, 58, 190)),
            ("Morning", Color.FromArgb(255, 190, 30)),
            ("Away Mode", Color.FromArgb(45, 119, 230)),
            ("Evening", Color.FromArgb(200, 65, 185)),
            ("Night Mode", Color.FromArgb(96, 58, 190))
        };

        private readonly System.Windows.Forms.Timer clock;

        public AutomationTimeline()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
            BackColor = Color.FromArgb(22, 29, 63);
            Size = new Size(800, 202);

            clock = new System.Windows.Forms.Timer { Interval = 30000 };
            clock.Tick += (_, _) => Invalidate();
            clock.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            float scale = Math.Min(DeviceDpi / 96f, ClientSize.Height / 202f);
            if (scale <= 0)
                return;
            graphics.ScaleTransform(scale, scale);

            float width = ClientSize.Width / scale;
            if (width < 120)
                return;

            using Font labelFont = new Font("Segoe UI", 14, GraphicsUnit.Pixel);
            using Font badgeFont = new Font("Segoe UI", 14, FontStyle.Bold, GraphicsUnit.Pixel);
            using SolidBrush white = new SolidBrush(Color.White);
            using SolidBrush secondaryText = new SolidBrush(Color.FromArgb(220, 225, 245));
            using StringFormat centered = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center,
                FormatFlags = StringFormatFlags.NoWrap
            };

            const float barTop = 68;
            const float barHeight = 56;
            float tickWidth = (float)Math.Ceiling(graphics.MeasureString("12 AM", labelFont).Width) + 4;
            float inset = tickWidth / 2 + 8;
            float trackWidth = width - 2 * inset;
            float HourX(float hour) => inset + trackWidth * hour / 24f;

            for (int i = 0; i < Segments.Length; i++)
            {
                float start = HourX(SegmentHours[i]);
                float end = HourX(SegmentHours[i + 1]);
                var bounds = new RectangleF(start + 1, barTop, end - start - 2, barHeight);
                Color color = Segments[i].Color;
                using GraphicsPath path = RoundedRect(bounds, 10);
                using LinearGradientBrush gradient = new LinearGradientBrush(
                    bounds, ControlPaint.Light(color, 0.25f), color, LinearGradientMode.Vertical);
                graphics.FillPath(gradient, path);
            }

            using Pen tickPen = new Pen(Color.FromArgb(107, 120, 164));
            int hourStep = trackWidth >= 8 * (tickWidth + 8) ? 3
                : trackWidth >= 4 * (tickWidth + 8) ? 6
                : trackWidth >= 2 * (tickWidth + 8) ? 12 : 24;
            for (int hour = 0; hour <= 24; hour += 3)
            {
                float x = HourX(hour);
                graphics.DrawLine(tickPen, x, barTop - 7, x, barTop - 3);
                if (hour % hourStep == 0)
                {
                    string label = DateTime.Today.AddHours(hour).ToString("h tt", CultureInfo.InvariantCulture);
                    graphics.DrawString(label, labelFont, secondaryText,
                        new RectangleF(x - tickWidth / 2, 34, tickWidth, 22), centered);
                }
            }

            DateTime now = DateTime.Now;
            float currentX = HourX((float)now.TimeOfDay.TotalHours);
            using Pen indicator = new Pen(Color.White, 2) { DashStyle = DashStyle.Dash };
            graphics.DrawLine(indicator, currentX, barTop - 3, currentX, barTop + barHeight + 4);
            graphics.FillEllipse(white, currentX - 4, barTop + barHeight, 8, 8);

            string currentTime = now.ToString("h:mm tt", CultureInfo.InvariantCulture);
            float badgeWidth = (float)Math.Ceiling(graphics.MeasureString(currentTime, badgeFont).Width) + 24;
            float badgeX = Math.Clamp(currentX - badgeWidth / 2, 4, width - badgeWidth - 4);
            var badge = new RectangleF(badgeX, 3, badgeWidth, 25);
            using GraphicsPath badgePath = RoundedRect(badge, 8);
            using SolidBrush purple = new SolidBrush(Color.FromArgb(103, 60, 213));
            graphics.FillPath(purple, badgePath);
            graphics.DrawString(currentTime, badgeFont, white, badge, centered);

            float legendWidth = width - 16;
            float itemWidth = graphics.MeasureString("Night Mode", labelFont).Width + 28;
            int columns = Math.Clamp((int)(legendWidth / itemWidth), 1, Segments.Length);
            float columnWidth = legendWidth / columns;
            for (int i = 0; i < Segments.Length; i++)
            {
                float x = 8 + i % columns * columnWidth;
                float y = 143 + i / columns * 19;
                using SolidBrush swatch = new SolidBrush(Segments[i].Color);
                using GraphicsPath swatchPath = RoundedRect(new RectangleF(x, y + 3, 12, 12), 3);
                graphics.FillPath(swatch, swatchPath);
                graphics.DrawString(Segments[i].Name, labelFont, secondaryText, x + 18, y);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                clock.Dispose();

            base.Dispose(disposing);
        }

        private static GraphicsPath RoundedRect(RectangleF rect, float radius)
        {
            var path = new GraphicsPath();
            float diameter = Math.Min(radius * 2, Math.Min(rect.Width, rect.Height));

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
