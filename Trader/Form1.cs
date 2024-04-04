using DevExpress.XtraEditors;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        VerilerEntities veriler = new VerilerEntities();
        public static string KullaniciAd;
        public static string KullaniciKimlik;


        private void btnGiris_Click(object sender, EventArgs e)
        {
            Kullanici giris = veriler.Kullanici.Where(x => x.KullaniciAd == txbKullanici.Text && x.Sifre == txbSifre.Text).FirstOrDefault();
            if (giris !=null)
            {

                KullaniciAd = giris.Ad + " " + giris.Soyad;
                KullaniciKimlik = giris.Kimlik;
                Anasayfa ana = new Anasayfa();
                ana.Show();
                this.Hide();

            }
            else
                XtraMessageBox.Show("kullanıcı adı veya sifre yanlıs", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            Kaydol k = new Kaydol();
            k.ShowDialog();
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
