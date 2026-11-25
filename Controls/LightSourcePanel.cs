using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using WinFormsApp2.Data;

namespace WinFormsApp2.Controls
{
    /// <summary>
    /// GDI+ panel that draws each room as a glowing light-source circle.
    /// Circle size and glow intensity are proportional to the room's brightness.
    /// Clicking a circle raises the <see cref="RoomSelected"/> event.
    /// Hovering shows a tooltip with room details.
    /// </summary>
    public class LightSourcePanel : Control
    {
        // Index of the room currently under the mouse (-1 = none)
        private int hoveredIndex = -1;

        // Index of the room that the user clicked (-1 = none)
        private int selectedIndex = -1;

        /// <summary>Raised when the user clicks one of the room circles.</summary>
        public event EventHandler<int>? RoomSelected;

        public LightSourcePanel()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);

            BackColor = Color.Transparent;
        }

        /// <summary>Gets or sets which room is currently selected (highlighted).</summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public int SelectedIndex
        {
            get => selectedIndex;
            set { selectedIndex = value; Invalidate(); }
        }

        // ---- layout helpers ----

        private List<RectangleF> GetCircleBounds()
        {
            List<RectangleF> list = new List<RectangleF>();
            int count = AppData.Rooms.Count;
            if (count == 0) return list;

            float cellW = (float)Width / count;
            float maxRadius = Math.Min(cellW, Height) * 0.35f;

            for (int i = 0; i < count; i++)
            {
                RoomData room = AppData.Rooms[i];
                float ratio = room.IsOn ? Math.Max(room.Brightness / 100f, 0.15f) : 0.15f;
                float radius = maxRadius * ratio;
                float cx = cellW * i + cellW / 2f;
                float cy = Height / 2f;
                list.Add(new RectangleF(cx - radius, cy - radius, radius * 2, radius * 2));
            }
            return list;
        }

        // ---- painting ----

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Dark card background (rounded rectangle)
            Rectangle bgRect = new Rectangle(0, 0, Width - 1, Height - 1);
            using (GraphicsPath bgPath = RoundedPanel.GetRoundedRectPath(bgRect, 16))
            using (SolidBrush bgBrush = new SolidBrush(AppColors.CardBackground))
            {
                g.FillPath(bgBrush, bgPath);
            }
            using (GraphicsPath bgPath = RoundedPanel.GetRoundedRectPath(bgRect, 16))
            using (Pen borderPen = new Pen(AppColors.Border, 1f))
            {
                g.DrawPath(borderPen, bgPath);
            }

            // Title
            using (Font titleFont = new Font("Segoe UI", 11f, FontStyle.Bold))
            using (SolidBrush titleBrush = new SolidBrush(AppColors.PrimaryText))
            {
                g.DrawString("Light Sources Overview", titleFont, titleBrush, 18, 12);
            }

            List<RectangleF> bounds = GetCircleBounds();
            int count = AppData.Rooms.Count;

            // Per-room color palette
            Color[] palette = {
                Color.FromArgb(168, 85, 247),   // Purple
                Color.FromArgb(59, 130, 246),    // Blue
                Color.FromArgb(34, 211, 238),    // Cyan
                Color.FromArgb(34, 197, 94)      // Green
            };

            for (int i = 0; i < count && i < bounds.Count; i++)
            {
                RoomData room = AppData.Rooms[i];
                RectangleF rect = bounds[i];
                Color baseColor = room.IsOn ? room.LightColor : Color.FromArgb(60, 55, 85);
                if (i < palette.Length && room.IsOn && room.LightColor == AppColors.PrimaryPurple)
                {
                    baseColor = palette[i];
                }

                float cx = rect.X + rect.Width / 2f;
                float cy = rect.Y + rect.Height / 2f;

                // Outer glow (only when on)
                if (room.IsOn && rect.Width > 4)
                {
                    float glowRadius = rect.Width * 0.9f;
                    RectangleF glowRect = new RectangleF(cx - glowRadius, cy - glowRadius, glowRadius * 2, glowRadius * 2);
                    if (glowRect.Width > 0 && glowRect.Height > 0)
                    {
                        using (GraphicsPath glowPath = new GraphicsPath())
                        {
                            glowPath.AddEllipse(glowRect);
                            using (PathGradientBrush glowBrush = new PathGradientBrush(glowPath))
                            {
                                glowBrush.CenterColor = Color.FromArgb(60, baseColor);
                                glowBrush.SurroundColors = new[] { Color.FromArgb(0, baseColor) };
                                g.FillPath(glowBrush, glowPath);
                            }
                        }
                    }
                }

                // Main circle
                if (rect.Width > 0 && rect.Height > 0)
                {
                    int alpha = room.IsOn ? 50 + (int)(room.Brightness * 2.05) : 40;
                    using (SolidBrush fill = new SolidBrush(Color.FromArgb(alpha, baseColor)))
                    {
                        g.FillEllipse(fill, rect);
                    }

                    // Highlight ring for hovered / selected
                    Color ringColor = baseColor;
                    float ringWidth = 2f;
                    if (i == selectedIndex)
                    {
                        ringColor = AppColors.FavoriteYellow;
                        ringWidth = 3f;
                    }
                    else if (i == hoveredIndex)
                    {
                        ringWidth = 2.5f;
                    }
                    using (Pen ringPen = new Pen(Color.FromArgb(180, ringColor), ringWidth))
                    {
                        g.DrawEllipse(ringPen, rect);
                    }
                }

                // Room name below the circle
                using (Font nameFont = new Font("Segoe UI", 9f))
                using (SolidBrush nameBrush = new SolidBrush(AppColors.SecondaryText))
                using (StringFormat sf = new StringFormat { Alignment = StringAlignment.Center })
                {
                    float labelY = rect.Bottom + 8;
                    g.DrawString(room.Name, nameFont, nameBrush, cx, labelY, sf);
                }

                // Brightness % inside the circle
                if (rect.Width > 30)
                {
                    string text = room.IsOn ? room.Brightness + "%" : "OFF";
                    using (Font valFont = new Font("Segoe UI", 9f, FontStyle.Bold))
                    using (SolidBrush valBrush = new SolidBrush(AppColors.PrimaryText))
                    using (StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                    {
                        g.DrawString(text, valFont, valBrush, rect, sf);
                    }
                }
            }

            // Tooltip on hover
            if (hoveredIndex >= 0 && hoveredIndex < count)
            {
                RoomData hRoom = AppData.Rooms[hoveredIndex];
                string tip = $"{hRoom.Name}\nBrightness: {hRoom.Brightness}%\nStatus: {(hRoom.IsOn ? "On" : "Off")}\nPower: {hRoom.GetWatts():F1} W";

                using (Font tipFont = new Font("Segoe UI", 9f))
                {
                    SizeF tipSize = g.MeasureString(tip, tipFont);
                    RectangleF hRect = bounds[hoveredIndex];
                    float tx = hRect.X + hRect.Width / 2f - tipSize.Width / 2f;
                    float ty = hRect.Y - tipSize.Height - 12;
                    if (ty < 0) ty = hRect.Bottom + 30;

                    RectangleF tipBg = new RectangleF(tx - 6, ty - 4, tipSize.Width + 12, tipSize.Height + 8);
                    using (SolidBrush tipBgBr = new SolidBrush(Color.FromArgb(220, 21, 17, 46)))
                    using (Pen tipBorder = new Pen(AppColors.Border))
                    {
                        g.FillRectangle(tipBgBr, tipBg);
                        g.DrawRectangle(tipBorder, tipBg.X, tipBg.Y, tipBg.Width, tipBg.Height);
                    }
                    using (SolidBrush tipTextBr = new SolidBrush(AppColors.PrimaryText))
                    {
                        g.DrawString(tip, tipFont, tipTextBr, tx, ty);
                    }
                }
            }
        }

        // ---- mouse interaction ----

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            int newHover = HitTest(e.Location);
            if (newHover != hoveredIndex)
            {
                hoveredIndex = newHover;
                Cursor = hoveredIndex >= 0 ? Cursors.Hand : Cursors.Default;
                Invalidate();
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            if (hoveredIndex >= 0)
            {
                hoveredIndex = -1;
                Cursor = Cursors.Default;
                Invalidate();
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            int clicked = HitTest(e.Location);
            if (clicked >= 0)
            {
                selectedIndex = clicked;
                Invalidate();
                RoomSelected?.Invoke(this, clicked);
            }
        }

        private int HitTest(Point pt)
        {
            List<RectangleF> bounds = GetCircleBounds();
            for (int i = 0; i < bounds.Count; i++)
            {
                RectangleF r = bounds[i];
                float hitRadius = Math.Max(r.Width / 2f, 15f) + 6;
                float cx = r.X + r.Width / 2f;
                float cy = r.Y + r.Height / 2f;
                float dx = pt.X - cx;
                float dy = pt.Y - cy;
                if (dx * dx + dy * dy <= hitRadius * hitRadius)
                    return i;
            }
            return -1;
        }
    }
}
