using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace WinFormsApp2.Controls
{
    // A rainbow color bar. Click on it to pick a custom color.
    public class GradientBar : Control
    {
        // The colors of the bar from left to right
        private readonly Color[] colors =
        {
            Color.FromArgb(124, 58, 237),   // purple
            Color.FromArgb(59, 130, 246),   // blue
            Color.FromArgb(6, 182, 212),    // cyan
            Color.FromArgb(16, 185, 129),   // green
            Color.FromArgb(245, 158, 11),   // yellow
            Color.FromArgb(249, 115, 22),   // orange
            Color.FromArgb(236, 72, 153)    // pink
        };

        private float markerPosition = 0f;

        // Raised when the user clicks on the bar
        public event EventHandler ColorPicked;

        public Color PickedColor { get; private set; } = Color.FromArgb(124, 58, 237);

        // Position of the white marker (0 = left, 1 = right)
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        // Position of the white marker (0 = left, 1 = right)
        public float MarkerPosition
        {
            get { return markerPosition; }
            set { markerPosition = Math.Max(0f, Math.Min(1f, value)); Invalidate(); }
        }

        public GradientBar()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);

            BackColor = Color.Transparent;
            Size = new Size(300, 22);
            Cursor = Cursors.Hand;
        }

        // Returns the color at a position between 0 and 1
        public Color GetColorAt(float position)
        {
            float scaled = position * (colors.Length - 1);
            int index = (int)Math.Floor(scaled);
            if (index >= colors.Length - 1) return colors[colors.Length - 1];
            if (index < 0) return colors[0];

            float t = scaled - index;
            Color a = colors[index];
            Color b = colors[index + 1];
            return Color.FromArgb(
                (int)(a.R + (b.R - a.R) * t),
                (int)(a.G + (b.G - a.G) * t),
                (int)(a.B + (b.B - a.B) * t));
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            MarkerPosition = (float)e.X / Width;
            PickedColor = GetColorAt(markerPosition);
            ColorPicked?.Invoke(this, EventArgs.Empty);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int barHeight = Height - 8;
            Rectangle bar = new Rectangle(Height / 2, 4, Width - Height, barHeight);
            if (bar.Width <= 0 || bar.Height <= 0) return;

            using (LinearGradientBrush brush = new LinearGradientBrush(bar, colors[0], colors[colors.Length - 1], 0f))
            using (GraphicsPath path = RoundedPanel.GetRoundedRectPath(bar, barHeight / 2))
            {
                ColorBlend blend = new ColorBlend();
                blend.Colors = colors;
                blend.Positions = new float[] { 0f, 1f / 6, 2f / 6, 3f / 6, 4f / 6, 5f / 6, 1f };
                brush.InterpolationColors = blend;
                g.FillPath(brush, path);
            }

            // White marker circle
            int x = bar.Left + (int)(bar.Width * markerPosition);
            int size = Height - 2;
            using (SolidBrush fill = new SolidBrush(GetColorAt(markerPosition)))
            using (Pen ring = new Pen(Color.White, 2.5f))
            {
                g.FillEllipse(fill, x - size / 2, 1, size - 1, size - 1);
                g.DrawEllipse(ring, x - size / 2, 1, size - 1, size - 1);
            }
        }
    }
}
