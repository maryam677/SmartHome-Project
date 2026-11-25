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
    /// GDI+ panel that draws a real-time line graph of brightness history
    /// and a bar chart comparing room brightness side by side.
    /// </summary>
    public class LightingGraphPanel : Control
    {
        private readonly List<int[]> brightnessHistory = new List<int[]>();
        private const int MaxHistoryPoints = 40;

        private int highlightedRoom = -1;
        private int hoveredBar = -1;

        /// <summary>Raised when the user clicks a bar in the bar chart.</summary>
        public event EventHandler<int>? BarClicked;

        public LightingGraphPanel()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);

            BackColor = Color.Transparent;
        }

        /// <summary>Gets or sets the room index highlighted on the line graph. -1 shows all.</summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public int HighlightedRoom
        {
            get => highlightedRoom;
            set { highlightedRoom = value; Invalidate(); }
        }

        public void RecordSnapshot()
        {
            int[] snapshot = new int[AppData.Rooms.Count];
            for (int i = 0; i < AppData.Rooms.Count; i++)
            {
                snapshot[i] = AppData.Rooms[i].Brightness;
            }
            brightnessHistory.Add(snapshot);
            if (brightnessHistory.Count > MaxHistoryPoints)
            {
                brightnessHistory.RemoveAt(0);
            }
            Invalidate();
        }

        private static readonly Color[] Palette = {
            Color.FromArgb(168, 85, 247),   // Purple  - Living Room
            Color.FromArgb(59, 130, 246),   // Blue    - Bedroom
            Color.FromArgb(34, 211, 238),   // Cyan    - Kitchen
            Color.FromArgb(34, 197, 94)     // Green   - Bathroom
        };

        private Color RoomColor(int index)
        {
            if (index >= 0 && index < Palette.Length) return Palette[index];
            return AppColors.NeonViolet;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int midX = Width / 2 - 6;

            DrawLineGraph(g, new Rectangle(0, 0, midX, Height));
            DrawBarChart(g, new Rectangle(midX + 12, 0, Width - midX - 12, Height));
        }

        private void DrawLineGraph(Graphics g, Rectangle area)
        {
            using (GraphicsPath bgPath = RoundedPanel.GetRoundedRectPath(area, 16))
            using (SolidBrush bgBrush = new SolidBrush(AppColors.CardBackground))
            {
                g.FillPath(bgBrush, bgPath);
            }
            using (GraphicsPath bgPath = RoundedPanel.GetRoundedRectPath(area, 16))
            using (Pen borderPen = new Pen(AppColors.Border, 1f))
            {
                g.DrawPath(borderPen, bgPath);
            }

            using (Font titleFont = new Font("Segoe UI", 11f, FontStyle.Bold))
            using (SolidBrush titleBrush = new SolidBrush(AppColors.PrimaryText))
            {
                g.DrawString("Brightness History", titleFont, titleBrush, area.X + 14, area.Y + 10);
            }

            int pad = 14;
            Rectangle graphRect = new Rectangle(area.X + pad + 30, area.Y + 42, area.Width - pad * 2 - 30, area.Height - 72);
            if (graphRect.Width <= 0 || graphRect.Height <= 0) return;

            using (Pen gridPen = new Pen(Color.FromArgb(40, AppColors.SecondaryText), 1f))
            using (Font labelFont = new Font("Segoe UI", 7.5f))
            using (SolidBrush labelBrush = new SolidBrush(AppColors.SecondaryText))
            {
                for (int v = 0; v <= 100; v += 25)
                {
                    float y = graphRect.Bottom - (v / 100f) * graphRect.Height;
                    g.DrawLine(gridPen, graphRect.Left, y, graphRect.Right, y);
                    g.DrawString(v.ToString(), labelFont, labelBrush, area.X + pad, y - 7);
                }
            }

            if (brightnessHistory.Count < 2) 
            {
                using (Font msgFont = new Font("Segoe UI", 9f))
                using (SolidBrush msgBrush = new SolidBrush(AppColors.SecondaryText))
                using (StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                {
                    g.DrawString("Change lighting values\nto see the history graph", msgFont, msgBrush,
                        graphRect, sf);
                }
                return;
            }

            int roomCount = AppData.Rooms.Count;
            float stepX = (float)graphRect.Width / (brightnessHistory.Count - 1);

            for (int r = 0; r < roomCount; r++)
            {
                if (highlightedRoom >= 0 && highlightedRoom != r) continue;

                Color lineColor = RoomColor(r);
                int alpha = (highlightedRoom >= 0 && highlightedRoom == r) ? 255 : 180;

                using (Pen linePen = new Pen(Color.FromArgb(alpha, lineColor), 2.5f))
                {
                    linePen.LineJoin = LineJoin.Round;
                    PointF[] points = new PointF[brightnessHistory.Count];
                    for (int p = 0; p < brightnessHistory.Count; p++)
                    {
                        int val = (r < brightnessHistory[p].Length) ? brightnessHistory[p][r] : 0;
                        float px = graphRect.Left + p * stepX;
                        float py = graphRect.Bottom - (val / 100f) * graphRect.Height;
                        points[p] = new PointF(px, py);
                    }
                    if (points.Length >= 2)
                    {
                        g.DrawLines(linePen, points);
                    }

                    foreach (PointF pt in points)
                    {
                        using (SolidBrush dotBrush = new SolidBrush(lineColor))
                        {
                            g.FillEllipse(dotBrush, pt.X - 3, pt.Y - 3, 6, 6);
                        }
                    }
                }
            }

            float legendX = graphRect.Left;
            float legendY = graphRect.Bottom + 8;
            using (Font legendFont = new Font("Segoe UI", 7.5f))
            {
                for (int r = 0; r < roomCount; r++)
                {
                    Color c = RoomColor(r);
                    using (SolidBrush dot = new SolidBrush(c))
                    using (SolidBrush txt = new SolidBrush(AppColors.SecondaryText))
                    {
                        g.FillEllipse(dot, legendX, legendY + 2, 8, 8);
                        g.DrawString(AppData.Rooms[r].Name, legendFont, txt, legendX + 12, legendY);
                        legendX += g.MeasureString(AppData.Rooms[r].Name, legendFont).Width + 20;
                    }
                }
            }
        }

        private void DrawBarChart(Graphics g, Rectangle area)
        {
            using (GraphicsPath bgPath = RoundedPanel.GetRoundedRectPath(area, 16))
            using (SolidBrush bgBrush = new SolidBrush(AppColors.CardBackground))
            {
                g.FillPath(bgBrush, bgPath);
            }
            using (GraphicsPath bgPath = RoundedPanel.GetRoundedRectPath(area, 16))
            using (Pen borderPen = new Pen(AppColors.Border, 1f))
            {
                g.DrawPath(borderPen, bgPath);
            }

            using (Font titleFont = new Font("Segoe UI", 11f, FontStyle.Bold))
            using (SolidBrush titleBrush = new SolidBrush(AppColors.PrimaryText))
            {
                g.DrawString("Room Comparison", titleFont, titleBrush, area.X + 14, area.Y + 10);
            }

            int count = AppData.Rooms.Count;
            if (count == 0) return;

            int pad = 18;
            Rectangle chartRect = new Rectangle(area.X + pad, area.Y + 44, area.Width - pad * 2, area.Height - 76);
            if (chartRect.Width <= 0 || chartRect.Height <= 0) return;

            float barWidth = (float)chartRect.Width / count * 0.6f;
            float gap = (float)chartRect.Width / count;

            using (Pen gridPen = new Pen(Color.FromArgb(30, AppColors.SecondaryText), 1f))
            {
                for (int v = 0; v <= 100; v += 25)
                {
                    float y = chartRect.Bottom - (v / 100f) * chartRect.Height;
                    g.DrawLine(gridPen, chartRect.Left, y, chartRect.Right, y);
                }
            }

            barRects.Clear();

            for (int i = 0; i < count; i++)
            {
                RoomData room = AppData.Rooms[i];
                Color barColor = RoomColor(i);
                float barHeight = (room.Brightness / 100f) * chartRect.Height;
                float bx = chartRect.Left + gap * i + (gap - barWidth) / 2;
                float by = chartRect.Bottom - barHeight;

                RectangleF barRect = new RectangleF(bx, by, barWidth, barHeight);
                barRects.Add(barRect);

                if (barHeight > 1)
                {
                    RectangleF gradientRect = new RectangleF(bx, by, barWidth, Math.Max(barHeight, 2));
                    using (LinearGradientBrush grad = new LinearGradientBrush(
                        gradientRect,
                        Color.FromArgb(i == hoveredBar ? 255 : 200, barColor),
                        Color.FromArgb(i == hoveredBar ? 200 : 100, barColor),
                        LinearGradientMode.Vertical))
                    {
                        using (GraphicsPath barPath = new GraphicsPath())
                        {
                            float r = Math.Min(6, barWidth / 2);
                            barPath.AddArc(bx, by, r * 2, r * 2, 180, 90);
                            barPath.AddArc(bx + barWidth - r * 2, by, r * 2, r * 2, 270, 90);
                            barPath.AddLine(bx + barWidth, by + r, bx + barWidth, chartRect.Bottom);
                            barPath.AddLine(bx + barWidth, chartRect.Bottom, bx, chartRect.Bottom);
                            barPath.CloseFigure();
                            g.FillPath(grad, barPath);
                        }
                    }
                }

                string valText = room.Brightness + "%";
                using (Font valFont = new Font("Segoe UI", 8.5f, FontStyle.Bold))
                using (SolidBrush valBrush = new SolidBrush(AppColors.PrimaryText))
                using (StringFormat sf = new StringFormat { Alignment = StringAlignment.Center })
                {
                    g.DrawString(valText, valFont, valBrush, bx + barWidth / 2, by - 18, sf);
                }

                string wattText = room.GetWatts().ToString("F1") + "W";
                using (Font wattFont = new Font("Segoe UI", 7f))
                using (SolidBrush wattBrush = new SolidBrush(AppColors.SecondaryText))
                using (StringFormat sf = new StringFormat { Alignment = StringAlignment.Center })
                {
                    g.DrawString(wattText, wattFont, wattBrush, bx + barWidth / 2, by - 6, sf);
                }

                using (Font nameFont = new Font("Segoe UI", 8f))
                using (SolidBrush nameBrush = new SolidBrush(AppColors.SecondaryText))
                using (StringFormat sf = new StringFormat { Alignment = StringAlignment.Center })
                {
                    g.DrawString(room.Name, nameFont, nameBrush, bx + barWidth / 2, chartRect.Bottom + 6, sf);
                }

                Color dotColor = room.IsOn ? AppColors.OnlineGreen : Color.FromArgb(107, 102, 144);
                using (SolidBrush dotBrush = new SolidBrush(dotColor))
                {
                    float dotX = bx + barWidth / 2 - 4;
                    float dotY = chartRect.Bottom + 24;
                    g.FillEllipse(dotBrush, dotX, dotY, 8, 8);
                }
            }
        }

        private readonly List<RectangleF> barRects = new List<RectangleF>();

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            int newHover = BarHitTest(e.Location);
            if (newHover != hoveredBar)
            {
                hoveredBar = newHover;
                Cursor = hoveredBar >= 0 ? Cursors.Hand : Cursors.Default;
                Invalidate();
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            if (hoveredBar >= 0)
            {
                hoveredBar = -1;
                Cursor = Cursors.Default;
                Invalidate();
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            int clicked = BarHitTest(e.Location);
            if (clicked >= 0)
            {
                BarClicked?.Invoke(this, clicked);
            }
        }

        private int BarHitTest(Point pt)
        {
            for (int i = 0; i < barRects.Count; i++)
            {
                RectangleF r = barRects[i];
                RectangleF hitArea = new RectangleF(r.X - 4, 0, r.Width + 8, Height);
                if (hitArea.Contains(pt)) return i;
            }
            return -1;
        }
    }
}
