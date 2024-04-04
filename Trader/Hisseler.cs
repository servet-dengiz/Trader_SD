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
    public partial class Hisseler : Form
    {
        public Hisseler()
        {
            InitializeComponent();
        }

        private void btnPortfoy_Click(object sender, EventArgs e)
        {
            Portfoy p = new Portfoy();
            p.ShowDialog();
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHisseAl_Click(object sender, EventArgs e)
        {
            HisseAl al = new HisseAl();
            al.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            HisseEkleme he = new HisseEkleme();
            he.ShowDialog();
        }

        private void btnHisseSat_Click(object sender, EventArgs e)
        {
            HisseSat sat = new HisseSat();
            sat.ShowDialog();
        }

        private void btnGecmis_Click(object sender, EventArgs e)
        {
            HisseGecmis h = new HisseGecmis();
            h.ShowDialog();
        }

        private void btnAnaliz_Click(object sender, EventArgs e)
        {
            HisseAnaliz h = new HisseAnaliz();
            h.ShowDialog();
        }
    }
}
