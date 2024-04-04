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
    public partial class Hesabim : Form
    {
        public Hesabim()
        {
            InitializeComponent();
        }
        VerilerEntities veriler = new VerilerEntities();
        string kimlik;
        public static string yeniAd;
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbAd.Text != "" && txbSifre.Text != "" && txbSoyad.Text != "" && txbKullanici.Text != "")
                {
                    var kisi = veriler.Kullanici.Where(x => x.Kimlik == kimlik).FirstOrDefault();
                    kisi.Ad = txbAd.Text;
                    kisi.Soyad = txbSoyad.Text;
                    kisi.Sifre = txbSifre.Text;
                    kisi.KullaniciAd = txbKullanici.Text;
                    veriler.SaveChanges();
                    yeniAd = kisi.Ad + " " + kisi.Soyad;
                    XtraMessageBox.Show("Hesabınız Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Kutucukları Doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            Anasayfa a = new Anasayfa();

            a.Show();
            this.Close();
        }

        private void Hesabim_Load(object sender, EventArgs e)
        {
            kimlik = Form1.KullaniciKimlik;
            var kisi = veriler.Kullanici.Where(x => x.Kimlik == kimlik).FirstOrDefault();
            txbAd.Text = kisi.Ad;
            txbSifre.Text = kisi.Sifre;
            txbSoyad.Text = kisi.Soyad;
            txbKullanici.Text = kisi.KullaniciAd;
        }
    }
}
