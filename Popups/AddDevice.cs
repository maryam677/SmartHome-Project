using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartHome
{
    public partial class frmAddDevice : Form
    {
        public frmAddDevice()
        {
            InitializeComponent();
        }

        private void txtEnergyUsage_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnCancel_Click_1(object sender, EventArgs e)
        {

            this.Close();
        }

        
       
private void btnSave_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = DialogResult.OK; 
            this.Close();
        }
    }
    }

