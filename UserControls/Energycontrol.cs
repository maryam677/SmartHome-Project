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
using WinFormsApp2;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SmartHome
{
    public partial class Energycontrol : UserControl
    {
        public Energycontrol()
        {
            InitializeComponent();

            

            Action updateClock = () =>
            {
                lbldate.Text = DateTime.Now.ToString("ddd, MMM d, yyyy"); 
                lbltime.Text = DateTime.Now.ToString("hh:mm tt");        
            };

           
            updateClock();

            System.Windows.Forms.Timer clockTimer = new System.Windows.Forms.Timer();

            clockTimer.Interval = 1000; // 1000 مللي ثانية = ثانية واحدة
            clockTimer.Tick += (s, e) => updateClock();
            clockTimer.Start();


            this.DoubleBuffered = true; 

            LoadRoomsGrid();

            AddPanelHoverEffect(pnluse);
            AddPanelHoverEffect(pnlTotalEnergy);
            AddPanelHoverEffect(pnlcost);
            AddPanelHoverEffect(pnlmain);
            AddPanelHoverEffect(pnlpeak);
            AddPanelHoverEffect(pnleco);
            AddPanelHoverEffect(pnlback);

           

            Color borderCol = Color.FromArgb(65, 90, 160);

            AddCustomBorder(pnltop, borderCol);         
            AddCustomBorder(pnlenergysum, borderCol); 
            AddCustomBorder(pnlwea, borderCol);
            AddCustomBorder(pnleco, borderCol);
            AddCustomBorder(pnlmydev, borderCol);


            
            AddRoundedBorder(pnluse, borderCol);
            pnluse.Paint -= pnluse_Paint;
            pnluse.Paint += pnluse_Paint;
            AddRoundedBorder(pnlTotalEnergy, borderCol);
            AddRoundedBorder(pnlcost, borderCol);
            AddRoundedBorder(pnlmain, borderCol);
            AddRoundedBorder(pnlpeak, borderCol);
            AddRoundedBorder(pnlenergysum, borderCol);
            AddRoundedBorder(pnlwea, borderCol);
            AddRoundedBorder(pnlback, borderCol);
            pnlback.Paint -= pnlback_Paint;
            pnlback.Paint += pnlback_Paint;
            AddRoundedBorder(pnltop,borderCol);
            AddRoundedBorder(pnleco, borderCol);

        }

        private void AddRoundedBorder(Panel pnl, Color borderColor, int radius = 15)
        {
            pnl.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                // مسح الزوايا الحادة بلون خلفية الشاشة
                Color parentBg = pnl.Parent != null ? pnl.Parent.BackColor : Color.FromArgb(10, 15, 38);
                using (SolidBrush bgBrush = new SolidBrush(parentBg))
                {
                    e.Graphics.FillRectangle(bgBrush, pnl.ClientRectangle);
                }

                RectangleF rect = new RectangleF(0.5f, 0.5f, pnl.Width - 1.5f, pnl.Height - 1.5f);
                float d = radius * 2f;

                using (var path = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    path.AddArc(rect.X, rect.Y, d, d, 180, 90);
                    path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
                    path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
                    path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
                    path.CloseFigure();

                    // تلوين الكارت من جوه بحواف ناعمة
                    using (SolidBrush cardBrush = new SolidBrush(pnl.BackColor))
                    {
                        e.Graphics.FillPath(cardBrush, path);
                    }

                    // رسم البرواز الناعم
                    using (Pen pen = new Pen(borderColor, 1.5f))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            };
        }
        private void LoadRoomsGrid()
        {
            
            dgvRooms.Columns.Clear();
            dgvRooms.RowTemplate.Height = 40;

            dgvRooms.Columns.Add("Room", "Room");
            dgvRooms.Columns.Add("Energy", "Energy");
            dgvRooms.Columns.Add("Cost", "Cost");
            dgvRooms.Columns.Add("Devices", "Devices");

         
            dgvRooms.Rows.Add("Living room", "114.2 KWh", "$15.58", "4");
            dgvRooms.Rows.Add("Kitchen", "64.8 KWh", "$8.84", "3");
            dgvRooms.Rows.Add("Bedroom", "53.7 KWh", "$7.32", "3");
            dgvRooms.Rows.Add("Study", "42.1 KWh", "$5.74", "2");
            dgvRooms.Rows.Add("Bathroom", "28.3 KWh", "$3.86", "1");
            dgvRooms.Rows.Add("Other", "53.7 KWh", "$7.32", "1");
            dgvRooms.Rows.Add("Total", "356.8 KWh", "$48.67", "12");

           
            dgvRooms.BackgroundColor = Color.FromArgb(16, 24, 56);
            dgvRooms.BorderStyle = BorderStyle.None;
            dgvRooms.GridColor = Color.FromArgb(35, 48, 95);
            dgvRooms.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRooms.EnableHeadersVisualStyles = false;

           
            dgvRooms.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(24, 34, 75);
            dgvRooms.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(130, 170, 255);
            dgvRooms.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            dgvRooms.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            
            dgvRooms.DefaultCellStyle.BackColor = Color.FromArgb(16, 24, 56);
            dgvRooms.DefaultCellStyle.ForeColor = Color.White;
            dgvRooms.DefaultCellStyle.Font = new Font("Segoe UI", 9.5f);
            dgvRooms.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 65, 135);
            dgvRooms.DefaultCellStyle.SelectionForeColor = Color.White;
           

            
            DataGridViewRow totalRow = dgvRooms.Rows[dgvRooms.Rows.Count - 1];
            totalRow.DefaultCellStyle.BackColor = Color.FromArgb(26, 38, 84);
            totalRow.DefaultCellStyle.ForeColor = Color.FromArgb(56, 217, 245);
            totalRow.DefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
        }

       

        private void AddCustomBorder(Panel pnl, Color borderColor)
        {
            pnl.Paint += (s, e) =>
            {
                using (Pen pen = new Pen(borderColor, 1))
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, pnl.Width - 1, pnl.Height - 1);
                }
            };
        }
        

        private void lblsticker_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblnov_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblsep_Click(object sender, EventArgs e)
        {

        }

        private void lbljul_Click(object sender, EventArgs e)
        {

        }

        private void lbl360_Click(object sender, EventArgs e)
        {

        }

        private void lbl600_Click(object sender, EventArgs e)
        {

        }

        private void lbl240_Click(object sender, EventArgs e)
        {

        }

        private void lbl0_Click(object sender, EventArgs e)
        {

        }

        private void lbl480_Click(object sender, EventArgs e)
        {

        }

        private void lbl120_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lblstick_Click(object sender, EventArgs e)
        {

        }

        private void lbldate_Click(object sender, EventArgs e)
        {

        }

        private void lbltime_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblast_Click(object sender, EventArgs e)
        {

        }

        private void lblnum_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Energycontrol_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void lblactive_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (chkeco.Checked)
            {
                chkeco.Text = "ON";
                chkeco.BackColor = Color.FromArgb(46, 204, 113); // أخضر
                lblactive.Text = "Active";
                lblactive.ForeColor = Color.FromArgb(46, 204, 113);
            }
            else
            {
                chkeco.Text = "OFF";
                chkeco.BackColor = Color.FromArgb(231, 76, 60); // أحمر هادي
                lblactive.Text = "Inactive";
                lblactive.ForeColor = Color.FromArgb(231, 76, 60);
            }
        }


        private void lblpeak_Click(object sender, EventArgs e)
        {

        }

        private void lblcost_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void lblsave_Click(object sender, EventArgs e)
        {

        }

        private void lbl45_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblgo_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void lblener_Click(object sender, EventArgs e)
        {

        }


        private void btnAddDevice_Click(object sender, EventArgs e)
        {

            using (frmAddDevice popup = new frmAddDevice())
            {

                if (popup.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            using (frmAddDevice popup = new frmAddDevice())
            {
                if (popup.ShowDialog() == DialogResult.OK)
                {
                }
            }
        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            main parentForm = (main)this.FindForm();


            if (parentForm != null)
            {
                parentForm.OpenDevicesPage();
            }
        }

        private void pnlchart_Paint(object sender, PaintEventArgs e)
        {


            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (Font titleFont = new Font("Segoe UI", 10f, FontStyle.Bold))
            using (SolidBrush titleBrush = new SolidBrush(Color.White))
            {
                g.DrawString("Monthly Usage (kWh)", titleFont, titleBrush, 15, 10);
            }
            // 1. بيانات الاستهلاك (تقدري تغيري الأرقام أو تربطيها بمتغيرات عندك)
            string[] months = { "Jun", "Jul", "Aug", "Sep", "Oct", "Nov" };
            float[] values = { 600f, 550f, 530f, 360f, 330f, 320 };
            float maxValue = 600f;

            // 2. أبعاد مساحة الرسم جوه pnlchart
            int leftMargin = 45;
            int bottomMargin = 35;
            int topMargin = 40;
            int rightMargin = 20;

            int chartWidth = pnlchart.Width - leftMargin - rightMargin;
            int chartHeight = pnlchart.Height - topMargin - bottomMargin;

            if (chartWidth <= 0 || chartHeight <= 0) return;

            // 3. رسم المحاور (X و Y) وخطوط الشبكة
            using (Pen axisPen = new Pen(Color.FromArgb(90, 110, 160), 1.5f))
            using (Pen gridPen = new Pen(Color.FromArgb(35, 48, 90), 1f))
            using (Font labelFont = new Font("Segoe UI", 8.5f, FontStyle.Regular))
            using (SolidBrush textBrush = new SolidBrush(Color.LightGray))
            {
                g.DrawLine(axisPen, leftMargin, topMargin, leftMargin, topMargin + chartHeight);
                g.DrawLine(axisPen, leftMargin, topMargin + chartHeight, leftMargin + chartWidth, topMargin + chartHeight);

                for (int i = 0; i <= 5; i++)
                {
                    int y = topMargin + chartHeight - (i * chartHeight / 5);
                    if (i > 0)
                        g.DrawLine(gridPen, leftMargin + 1, y, leftMargin + chartWidth, y);

                    string yLabel = (i * 100).ToString();
                    g.DrawString(yLabel, labelFont, textBrush, 12, y - 7);
                }

                // 4. رسم الأعمدة (Bars) بتدرج لوني مناسب للخلفية الغامقة
                int slotWidth = chartWidth / values.Length;
                int barWidth = Math.Max(14, slotWidth / 2);

                for (int i = 0; i < values.Length; i++)
                {
                    int barHeight = (int)((values[i] / maxValue) * chartHeight);
                    int x = leftMargin + (i * slotWidth) + (slotWidth - barWidth) / 2;
                    int y = topMargin + chartHeight - barHeight;

                    Rectangle barRect = new Rectangle(x, y, barWidth, barHeight);

                    using (LinearGradientBrush barBrush = new LinearGradientBrush(
                        barRect,
                        Color.FromArgb(0, 210, 255),   // أزرق نيوني فوق
                        Color.FromArgb(110, 65, 226),  // بنفسجي تحت
                        LinearGradientMode.Vertical))
                    {
                        g.FillRectangle(barBrush, barRect);
                    }

                    // كتابة اسم اليوم تحت كل عمود
                    g.DrawString(months[i], labelFont, textBrush, x - 2, topMargin + chartHeight + 8);
                }
            }
        }

        private void chkeco_Click(object sender, EventArgs e)
        {
            if (lblactive.Text == "Active")
            {
                chkeco.Text = "OFF";
                chkeco.BackColor = Color.FromArgb(95, 35, 45);      // أحمر غامق هادي
                chkeco.FlatAppearance.CheckedBackColor = Color.FromArgb(95, 35, 45);
                chkeco.ForeColor = Color.FromArgb(255, 160, 160);   // نص واضح ومريح
                lblactive.Text = "Inactive";
                lblactive.ForeColor = Color.FromArgb(231, 76, 60);
            }
            else
            {
                chkeco.Text = "ON";
                chkeco.BackColor = Color.FromArgb(20, 83, 60);      // أخضر غامق هادي
                chkeco.FlatAppearance.CheckedBackColor = Color.FromArgb(20, 83, 60);
                chkeco.ForeColor = Color.FromArgb(110, 231, 183);   // نص واضح ومريح
                lblactive.Text = "Active";
                lblactive.ForeColor = Color.FromArgb(46, 204, 113);
            }
        }
        private void AddPanelHoverEffect(Panel pnl)
        {
            Color normalColor = pnl.BackColor;
            Color hoverColor = Color.FromArgb(48, 68, 145);

            
            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic,
                null, pnl, new object[] { true });

            EventHandler onEnter = (s, e) =>
            {
                if (pnl.BackColor != hoverColor)
                {
                    pnl.BackColor = hoverColor;
                    pnl.Refresh();
                }
            };

            EventHandler onLeave = (s, e) =>
            {
                if (!pnl.ClientRectangle.Contains(pnl.PointToClient(Control.MousePosition)))
                {
                    pnl.BackColor = normalColor;
                    pnl.Refresh();
                }
            };

            pnl.MouseEnter += onEnter;
            pnl.MouseLeave += onLeave;
            foreach (Control c in pnl.Controls)
            {
                c.MouseEnter += onEnter;
                c.MouseLeave += onLeave;
            }
        }

        private void lbl11_Click(object sender, EventArgs e)
        {
            Control statusCtrl = (Control)sender; // يشتغل على أي جهاز تدوسي عليه

            if (statusCtrl.Text.ToLower() == "on")
            {
                statusCtrl.Text = "OFF";
                statusCtrl.ForeColor = Color.FromArgb(255, 0, 0);
            }
            else
            {
                statusCtrl.Text = "ON";
                statusCtrl.ForeColor = Color.FromArgb(46, 204, 113); // أخضر
            }
        }

        private void lblnoo_Click(object sender, EventArgs e)
        {
            Control statusCtrl = (Control)sender; // يشتغل على أي جهاز تدوسي عليه

            if (statusCtrl.Text.ToLower() == "on")
            {
                statusCtrl.Text = "OFF";
                statusCtrl.ForeColor = Color.FromArgb(255, 0, 0); 
            }
            else
            {
                statusCtrl.Text = "ON";
                statusCtrl.ForeColor = Color.FromArgb(46, 204, 113); // أخضر
            }
        }

        private void lblof_Click(object sender, EventArgs e)
        {
            Control statusCtrl = (Control)sender; // يشتغل على أي جهاز تدوسي عليه

            if (statusCtrl.Text.ToLower() == "on")
            {
                statusCtrl.Text = "OFF";
                statusCtrl.ForeColor = Color.FromArgb(231, 76, 60); // أحمر هادي
            }
            else
            {
                statusCtrl.Text = "ON";
                statusCtrl.ForeColor = Color.FromArgb(46, 204, 113); // أخضر
            }
        }

        private void lbloof_Click(object sender, EventArgs e)
        {
            Control statusCtrl = (Control)sender; // يشتغل على أي جهاز تدوسي عليه

            if (statusCtrl.Text.ToLower() == "on")
            {
                statusCtrl.Text = "OFF";
                statusCtrl.ForeColor = Color.FromArgb(231, 76, 60); // أحمر هادي
            }
            else
            {
                statusCtrl.Text = "ON";
                statusCtrl.ForeColor = Color.FromArgb(46, 204, 113); // أخضر
            }
        }

        private void lblnooo_Click(object sender, EventArgs e)
        {
            Control statusCtrl = (Control)sender; // يشتغل على أي جهاز تدوسي عليه

            if (statusCtrl.Text.ToLower() == "on")
            {
                statusCtrl.Text = "OFF";
                statusCtrl.ForeColor = Color.FromArgb(231, 76, 60); // أحمر هادي
            }
            else
            {
                statusCtrl.Text = "ON";
                statusCtrl.ForeColor = Color.FromArgb(46, 204, 113); // أخضر
            }
        }


        private void pnlback_Paint(object sender, PaintEventArgs e)
        {
            Control target = sender as Control;
            if (target == null) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int percentage = 82;
            int diameter = 150;
            int thickness = 15;

            // رسمها في أول البانل مؤقتاً عشان نتأكد إنها ظاهرة
            int x = (pnlback.Width - diameter) / 2;
            int y = pnlback.Height - diameter - 20;

            Rectangle rect = new Rectangle(x, y, diameter, diameter);

            using (Pen bgPen = new Pen(Color.FromArgb(35, 48, 95), thickness))
            {
                g.DrawArc(bgPen, rect, 0, 360);
            }

            float sweepAngle = (percentage / 100f) * 360f;
            using (Pen progressPen = new Pen(Color.FromArgb(46, 204, 113), thickness))
            {
                progressPen.StartCap = LineCap.Round;
                progressPen.EndCap = LineCap.Round;
                g.DrawArc(progressPen, rect, -90, sweepAngle);
            }

            string text = percentage + "%";
            using (Font font = new Font("Segoe UI", 14, FontStyle.Bold))
            using (Brush textBrush = new SolidBrush(Color.White))
            {
                StringFormat sf = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                g.DrawString(text, font, textBrush, rect, sf);
            }
        }

        private void pnluse_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; // تنعيم المنحنى

            int w = pnluse.Width;
            int h = pnluse.Height;

            
            PointF[] curvePoints = new PointF[]
            {
        new PointF(10, h - 18),
        new PointF(w * 0.25f, h - 38),
        new PointF(w * 0.50f, h - 22),
        new PointF(w * 0.75f, h - 32),
        new PointF(w - 10, h - 26)
            };

            // 1. رسم المنحنى باللون السماوي المضيء
            using (Pen wavePen = new Pen(Color.FromArgb(56, 217, 245), 3f))
            {
                wavePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                wavePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                g.DrawCurve(wavePen, curvePoints, 0.5f); // 0.5f بتخلي الانحناء ناعم
            }

            // 2. رسم نقطة مضيئة عند أعلى قمة في المنحنى
            PointF peakPoint = curvePoints[3];
            using (Brush dotBrush = new SolidBrush(Color.White))
            {
                g.FillEllipse(dotBrush, peakPoint.X - 4, peakPoint.Y - 4, 8, 8);
            }
        }
    }

}
