using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace WinFormsApp2.Controls
{
    // A small round color button used in the Color Control section.
    // When Selected is true a white ring is drawn around it.
    public class ColorSwatchButton : Control
    {
        private Color swatchColor = Color.FromArgb(124, 58, 237);
        private bool selected = false;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color SwatchColor
        {
            get { return swatchColor; }
            set { swatchColor = value; Invalidate(); }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool Selected
        {
            get { return selected; }
            set { selected = value; Invalidate(); }
        }

        public ColorSwatchButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);

            BackColor = Color.Transparent;
            Size = new Size(32, 32);
            Cursor = Cursors.Hand;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Always draw a perfect circle, even if the control is not square
            int size = Math.Min(Width, Height) - 1;
            int x = (Width - size) / 2;
            int y = (Height - size) / 2;

            if (selected)
            {
                using (Pen ring = new Pen(Color.FromArgb(248, 250, 252), 2f))
                {
                    g.DrawEllipse(ring, x + 1, y + 1, size - 2, size - 2);
                }
                using (SolidBrush brush = new SolidBrush(swatchColor))
                {
                    g.FillEllipse(brush, x + 5, y + 5, size - 10, size - 10);
                }
            }
            else
            {
                using (SolidBrush brush = new SolidBrush(swatchColor))
                {
                    g.FillEllipse(brush, x + 3, y + 3, size - 6, size - 6);
                }
            }
        }
    }
}
