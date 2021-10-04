using Fluid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiquidHelper
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            try
            {
                string temp = txtLiquid.Text.Trim();
                var parser = new FluidParser();
                string big_json = txtJson.Text.Trim();
                string sm = temp;
                string cres = FluidHelper.FluidMapper(big_json, sm);
                txtResult.Text = cres;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.ResetText();
            txtJson.ResetText();
            txtLiquid.ResetText();
        }
    }
}
