using Smarthome_net9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Linq;

namespace Smarthome_.net9
{
    public partial class dashboard : UserControl
    {
        public dashboard()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            climatePanelPaint.Paint += climatePanel_Paint;
            typeof(Panel).InvokeMember("DoubleBuffered",
    System.Reflection.BindingFlags.SetProperty |
    System.Reflection.BindingFlags.Instance |
    System.Reflection.BindingFlags.NonPublic,
    null, pnlChart, new object[] { true });


            pnlChart.Paint += PnlChart_Paint;
            ApplyRoundedCorners(pnlChart);
            ApplyRoundedCorners(climatePanelPaint);
            ApplyRoundedCorners(panel3);
            ApplyRoundedCorners(RoundPanel);
            ApplyRoundedCorners(pnlsecurity);
            ApplyRoundedCorners(piclivingroom);
        }

        private void ApplyRoundedCorners(Control p, int radius = 15)
        {
            Action apply = () =>
            {
                if (p.Width <= 0 || p.Height <= 0) return;
                var path = new GraphicsPath();
                int d = radius * 2;
                path.AddArc(0, 0, d, d, 180, 90);
                path.AddArc(p.Width - d, 0, d, d, 270, 90);
                path.AddArc(p.Width - d, p.Height - d, d, d, 0, 90);
                path.AddArc(0, p.Height - d, d, d, 90, 90);
                path.CloseFigure();
                p.Region = new Region(path);
            };

            apply();
            p.SizeChanged += (s, e) => apply();
        }



        private bool floorLampOn = true;
        private float[] values = { 3, 5, 4, 7, 6, 9, 8, 12, 10, 14, 13, 15 };
        float currentTemp = 22f;
        private void climatePanel_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int size = 90;
            var rect = new Rectangle(25, 40, size, size);
            float sweep = 270f * (currentTemp - 10) / 25;

            using (var track = new Pen(Color.FromArgb(45, 40, 100), 9) { StartCap = LineCap.Round, EndCap = LineCap.Round })
            using (var value = new Pen(Color.FromArgb(139, 92, 246), 9) { StartCap = LineCap.Round, EndCap = LineCap.Round })
            {
                g.DrawArc(track, rect, 135, 270);
                g.DrawArc(value, rect, 135, sweep);
            }

            var center = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            float cx = rect.X + size / 2f, cy = rect.Y + size / 2f;

            using (var f1 = new Font("Segoe UI", 14, FontStyle.Bold))
                g.DrawString($"{currentTemp:0}°C", f1, Brushes.White, cx, cy, center);
            using (var f2 = new Font("Segoe UI", 8))
                g.DrawString("Comfortable", f2, Brushes.LimeGreen, cx, rect.Bottom + 8, center);
        }

        private void PnlChart_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int w = pnlChart.Width - 10;
            int h = pnlChart.Height - 10;
            float max = values.Max();
            float stepX = (float)w / (values.Length - 1);

            var pts = new PointF[values.Length];
            for (int i = 0; i < values.Length; i++)
                pts[i] = new PointF(5 + i * stepX, 5 + h - (values[i] / max) * h);

            var area = pts.ToList();
            area.Add(new PointF(pts[pts.Length - 1].X, 5 + h));
            area.Add(new PointF(pts[0].X, 5 + h));

            using (var br = new LinearGradientBrush(
                new Rectangle(0, 0, pnlChart.Width, pnlChart.Height),
                Color.FromArgb(90, 139, 92, 246),
                Color.FromArgb(0, 139, 92, 246),
                90f))
            {
                g.FillPolygon(br, area.ToArray());
            }

            using (var pen = new Pen(Color.FromArgb(167, 139, 250), 2.5f))
            {
                g.DrawCurve(pen, pts, 0.4f);
            }

            g.FillEllipse(Brushes.White, pts[pts.Length - 1].X - 4, pts[pts.Length - 1].Y - 4, 8, 8);
        }

        private void lblwelcome_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void piclivingroom_Click(object sender, EventArgs e)
        {

        }

        private void lblRooms_Click(object sender, EventArgs e)
        {

        }



        private void lblPower_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void lbllamp_Click(object sender, EventArgs e)
        {

        }

        private void pnlDeviceOverview_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblindoorclimate_Click(object sender, EventArgs e)
        {

        }

        private void btnon2_Click(object sender, EventArgs e)
        {

        }

        private void lblquick_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void cmbperiod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label2_Click_3(object sender, EventArgs e)
        {

        }





        private void btnon1_Click_1(object sender, EventArgs e)
        {
            using (var popup = new DevicePopup("Floor lamp", "Living Room", floorLampOn))
            {
                if (popup.ShowDialog(this.FindForm()) == DialogResult.OK)
                {
                    floorLampOn = popup.IsOn;
                    btnon1.Text = floorLampOn ? "ON" : "OFF";
                }
            }
        }

        private void lblusage4_Click(object sender, EventArgs e)
        {

        }

        private void lbllivingroom_Click(object sender, EventArgs e)
        {

        }

        private void lblenergychange_Click(object sender, EventArgs e)
        {

        }

        private void pictemp_Click(object sender, EventArgs e)
        {

        }

        private void lblhumid_Click(object sender, EventArgs e)
        {

        }

        private void RoundPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

