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
    public partial class FonSat : Form
    {
        public FonSat()
        {
            InitializeComponent();
        }
        decimal alısFiyat;
        int alısAdet;
        VerilerEntities veriler = new VerilerEntities();

        void listele()
        {
            var fonlar = veriler.Fon.ToList();
            gridControl1.DataSource = fonlar;
        }
        void FonuSil()
        {
            Fon sil = new Fon();
            var x = int.Parse(txbId.Text);
            var silinecek = veriler.Fon.Find(x);
            veriler.Fon.Remove(silinecek);
            veriler.SaveChanges();
        }
        void FonuGuncelle()
        {
            Fon guncelle = new Fon();
            var x = int.Parse(txbId.Text);
            var guncellenecek = veriler.Fon.Find(x);
            guncellenecek.Adet = alısAdet - int.Parse(txbAdet.Text);
            guncellenecek.Toplam = (alısAdet - int.Parse(txbAdet.Text)) * alısFiyat;
            veriler.SaveChanges();
        }

        private void FonSat_Load(object sender, EventArgs e)
        {
            listele();
        }


        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txbAd.Text = gridView1.GetFocusedRowCellValue("FonAd").ToString();
            txbAdet.Text = gridView1.GetFocusedRowCellValue("Adet").ToString();
            txbFiyat.Text = gridView1.GetFocusedRowCellValue("Fiyat").ToString();
            txbId.Text = gridView1.GetFocusedRowCellValue("FonId").ToString();
            alısAdet = int.Parse(gridView1.GetFocusedRowCellValue("Adet").ToString());
            alısFiyat = decimal.Parse(gridView1.GetFocusedRowCellValue("Fiyat").ToString());
        }

        private void btnSat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbAd.Text != "" && txbAdet.Text != "" && txbFiyat.Text != "" && txbTarih.Text != "" && txbId.Text != "")
                {

                    if (double.Parse(txbAdet.Text) > 0)
                    {
                        if (alısAdet == double.Parse(txbAdet.Text))
                        {
                            FonSonuc sonuc = new FonSonuc();
                            sonuc.Adet = int.Parse(txbAdet.Text);
                            sonuc.Fiyat = decimal.Parse(txbFiyat.Text);
                            sonuc.SatilanFon = txbAd.Text;
                            sonuc.SatilanTarih = txbTarih.DateTime;
                            sonuc.Kazanc = (decimal.Parse(txbFiyat.Text) * int.Parse(txbAdet.Text)) - alısFiyat * int.Parse(txbAdet.Text);
                            veriler.FonSonuc.Add(sonuc);
                            veriler.SaveChanges();
                            FonuSil();
                            XtraMessageBox.Show("Fon satildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            listele();
                        }
                        else if (alısAdet > double.Parse(txbAdet.Text))
                        {

                            FonSonuc sonuc = new FonSonuc();
                            sonuc.Adet = int.Parse(txbAdet.Text);
                            sonuc.Fiyat = decimal.Parse(txbFiyat.Text);
                            sonuc.SatilanFon = txbAd.Text;
                            sonuc.SatilanTarih = txbTarih.DateTime;
                            sonuc.Kazanc = (decimal.Parse(txbFiyat.Text) * int.Parse(txbAdet.Text)) - alısFiyat * int.Parse(txbAdet.Text);
                            veriler.FonSonuc.Add(sonuc);
                            veriler.SaveChanges();
                            FonuGuncelle();
                            XtraMessageBox.Show("Fon satildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            listele();
                        }
                        else
                        {
                            XtraMessageBox.Show("fazla adet girdiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Fon seciniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    XtraMessageBox.Show("İyi Doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {
                XtraMessageBox.Show("Fon seciniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
