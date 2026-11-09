using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2;

namespace SmartHome
{
    public partial class Energycontrol : UserControl
    {
        public Energycontrol()
        {
            InitializeComponent();
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
   
    

    }
}
