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
    public partial class FonPortfoy : Form
    {
        public FonPortfoy()
        {
            InitializeComponent();
        }
        VerilerEntities veriler = new VerilerEntities();
        private void FonPortfoy_Load(object sender, EventArgs e)
        {
            var portfoy = veriler.Fon.ToList();
            gridControl1.DataSource = portfoy;
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
