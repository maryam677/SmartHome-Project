using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SmartHomeLightingSystem.Controls
{
    // Circular brightness indicator used in the System Overview card.
    // It can be dragged from the Toolbox and edited in the Properties window.
    public class CircularGauge : Control
    {
        private int value = 54;

        public int Value
        {
            get { return value; }
            set
            {
                this.value = Math.Max(0, Math.Min(100, value));
                Invalidate();
            }
        }

        public Color TrackColor { get; set; } = Color.FromArgb(37, 28, 73);
        public Color ProgressColor { get; set; } = Color.FromArgb(124, 58, 237);
        public int Thickness { get; set; } = 10;

        public CircularGauge()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);

            BackColor = Color.Transparent;
            ForeColor = Color.FromArgb(248, 250, 252);
            Size = new Size(110, 110);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int margin = Thickness / 2 + 2;
            Rectangle rect = new Rectangle(margin, margin, Width - margin * 2 - 1, Height - margin * 2 - 1);
            if (rect.Width <= 0 || rect.Height <= 0) return;

            // Background ring
            using (Pen trackPen = new Pen(TrackColor, Thickness))
            {
                g.DrawEllipse(trackPen, rect);
            }

            // Progress ring (starts at the top)
            float sweep = value / 100f * 360f;
            if (sweep > 0)
            {
                using (Pen progressPen = new Pen(ProgressColor, Thickness))
                {
                    progressPen.StartCap = LineCap.Round;
                    progressPen.EndCap = LineCap.Round;
                    g.DrawArc(progressPen, rect, -90, sweep);
                }
            }

            // Light bulb icon + percentage in the middle
            using (Font iconFont = new Font("Segoe MDL2 Assets", 13f))
            using (Font textFont = new Font("Segoe UI", 13f, FontStyle.Bold))
            using (SolidBrush iconBrush = new SolidBrush(Color.FromArgb(192, 132, 252)))
            using (SolidBrush textBrush = new SolidBrush(ForeColor))
            using (StringFormat center = new StringFormat())
            {
                center.Alignment = StringAlignment.Center;
                center.LineAlignment = StringAlignment.Center;
                g.DrawString("\uEA80", iconFont, iconBrush, new RectangleF(0, Height / 2f - 30, Width, 26), center);
                g.DrawString(value + "%", textFont, textBrush, new RectangleF(0, Height / 2f - 4, Width, 28), center);
            }
        }
    }
}
