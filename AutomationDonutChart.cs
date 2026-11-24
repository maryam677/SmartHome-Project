
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;
namespace WinFormsApp2
{
    public class AutomationDonutChart : Control
    {
        private int enabledCount = 5;
        private int disabledCount;

        public event EventHandler? CountsChanged;

        [DefaultValue(5)]
        public int EnabledCount
        {
            get => enabledCount;
            set => SetCount(ref enabledCount, value);
        }

        [DefaultValue(0)]
        public int DisabledCount
        {
            get => disabledCount;
            set => SetCount(ref disabledCount, value);
        }

        private void SetCount(ref int count, int value)
        {
            ArgumentOutOfRangeException.ThrowIfNegative(value);
            if (count == value)
                return;

            count = value;
            Invalidate();
            CountsChanged?.Invoke(this, EventArgs.Empty);
        }

        public AutomationDonutChart()
        {
            DoubleBuffered = true;
            BackColor = Color.FromArgb(22, 29, 63);
            Size = new Size(180, 180);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            long total = EnabledCount + (long)DisabledCount;

            int diameter = Math.Min(ClientSize.Width, ClientSize.Height) - 40;
            if (diameter <= 0)
                return;

            Rectangle circle = new Rectangle(
                (ClientSize.Width - diameter) / 2,
                (ClientSize.Height - diameter) / 2, diameter, diameter);

            using Pen backgroundPen =
                new Pen(Color.FromArgb(60, 65, 95), 15);

            using Pen greenPen =
                new Pen(Color.FromArgb(49, 227, 128), 15);

            using Pen redPen =
                new Pen(Color.FromArgb(255, 90, 110), 15);

            g.DrawEllipse(backgroundPen, circle);

            if (total > 0)
            {
                float angle = 360f * EnabledCount / total;

                if (EnabledCount == total)
                {
                    g.DrawEllipse(greenPen, circle);
                }
                else if (DisabledCount == total)
                {
                    g.DrawEllipse(redPen, circle);
                }
                else
                {
                    g.DrawArc(greenPen, circle, -90, angle);
                    g.DrawArc(redPen, circle,
                        -90 + angle, 360f - angle);
                }
            }

            using Font numberFont =
                new Font("Segoe UI", 25, FontStyle.Bold);

            using Font labelFont =
                new Font("Segoe UI", 10);

            using Brush brush = new SolidBrush(Color.White);

            using StringFormat format = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            g.DrawString(total.ToString(), numberFont, brush,
                new Rectangle(0, ClientSize.Height / 2 - 30, ClientSize.Width, 40), format);

            g.DrawString("Total", labelFont, brush,
                new Rectangle(0, ClientSize.Height / 2 + 10, ClientSize.Width, 25), format);
        }
    }
}
