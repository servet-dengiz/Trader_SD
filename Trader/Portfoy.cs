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
    public partial class Portfoy : Form
    {
        public Portfoy()
        {
            InitializeComponent();
        }
        VerilerEntities veriler = new VerilerEntities();

        private void Portfoy_Load(object sender, EventArgs e)
        {
            var hisseler = veriler.Hisse.ToList();
            gridControl1.DataSource = hisseler;
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
