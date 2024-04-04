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
    public partial class Kaydol : Form
    {
        public Kaydol()
        {
            InitializeComponent();
        }
        VerilerEntities veriler = new VerilerEntities();

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            if (txbAd.Text != "" && txbKimlik.Text != "" && txbKullanici.Text != "" && txbSifre.Text != "" && txbSoyad.Text != "")
            {
                if (txbKimlik.Text.Length == 11)
                {
                    try
                    {
                        Kullanici yeni = new Kullanici();
                        yeni.Kimlik = txbKimlik.Text;
                        yeni.KullaniciAd = txbKullanici.Text;
                        yeni.Sifre = txbSifre.Text;
                        yeni.Soyad = txbSoyad.Text;
                        yeni.Ad = txbAd.Text;
                        veriler.Kullanici.Add(yeni);
                        veriler.SaveChanges();
                        XtraMessageBox.Show("Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    catch (Exception)
                    {

                        XtraMessageBox.Show("Aynı Kimlik Mevcut!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else
                {

                    XtraMessageBox.Show("Kimlik bilgilerinizi dogru giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("Boş kutucuk bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Kaydol_Load(object sender, EventArgs e)
        {

        }
    }
}
