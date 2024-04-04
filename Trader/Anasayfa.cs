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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Izle i = new Izle();
            i.ShowDialog();
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            this.Hide();
            string yeni = Hesabim.yeniAd;
            if (yeni != null)
            {
                lblAd.Text = yeni;
            }
            else
                lblAd.Text = Form1.KullaniciAd;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hesabim h = new Hesabim();
            h.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Hisseler h = new Hisseler();
            h.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            FonAnasayfa a = new FonAnasayfa();
            a.ShowDialog();
        }
    }
}
