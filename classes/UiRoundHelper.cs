using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WinFormsApp2.classes
{
    public static class UiRoundHelper
    {
        public static GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            int d = radius * 2;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            return path;
        }

        public static void ApplyRoundedRegion(Control control, int radius)
        {
            void UpdateRegion(object? sender, EventArgs e)
            {
                if (control.Width <= 0 || control.Height <= 0) return;

                using GraphicsPath path = GetRoundedPath(
                    new Rectangle(0, 0, control.Width, control.Height),
                    radius);

                control.Region = new Region(path);
            }

            UpdateRegion(null, EventArgs.Empty);
            control.SizeChanged += UpdateRegion;
        }
    }
}