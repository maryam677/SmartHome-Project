using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SmartHomeLightingSystem.Controls
{
    // A flat, rounded progress bar. The standard ProgressBar is always green
    // on Windows, so this one lets us use the purple theme color.
    public class SimpleProgressBar : Control
    {
        private int value = 50;
        private int maximum = 100;

        public int Value
        {
            get { return value; }
            set { this.value = Math.Max(0, Math.Min(maximum, value)); Invalidate(); }
        }

        public int Maximum
        {
            get { return maximum; }
            set { maximum = Math.Max(1, value); Invalidate(); }
        }

        public Color BarColor { get; set; } = Color.FromArgb(124, 58, 237);
        public Color TrackColor { get; set; } = Color.FromArgb(40, 32, 78);

        public SimpleProgressBar()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);

            BackColor = Color.Transparent;
            Size = new Size(200, 8);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle track = new Rectangle(0, 0, Width - 1, Height - 1);
            if (track.Width <= 0 || track.Height <= 0) return;

            using (GraphicsPath path = RoundedPanel.GetRoundedRectPath(track, Height / 2))
            using (SolidBrush brush = new SolidBrush(TrackColor))
            {
                g.FillPath(brush, path);
            }

            int fillWidth = (int)(track.Width * (value / (float)maximum));
            if (fillWidth >= Height)
            {
                Rectangle fill = new Rectangle(0, 0, fillWidth, Height - 1);
                using (GraphicsPath path = RoundedPanel.GetRoundedRectPath(fill, Height / 2))
                using (SolidBrush brush = new SolidBrush(BarColor))
                {
                    g.FillPath(brush, path);
                }
            }
        }
    }
}
