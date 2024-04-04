using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trader
{
    public partial class FonAnasayfa : Form
    {
        public FonAnasayfa()
        {
            InitializeComponent();
        }

        private void btnPortfoy_Click(object sender, EventArgs e)
        {
            FonPortfoy p = new FonPortfoy();
            p.ShowDialog();
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFonAl_Click(object sender, EventArgs e)
        {
            FonAl f = new FonAl();
            f.ShowDialog();
        }

        private void btnFonSat_Click(object sender, EventArgs e)
        {
            FonSat f = new FonSat();
            f.ShowDialog();
        }

        private void btnGecmis_Click(object sender, EventArgs e)
        {
            FonGecmis f = new FonGecmis();
            f.ShowDialog();
        }
    }
}
