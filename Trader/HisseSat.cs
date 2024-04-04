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
    public partial class HisseSat : Form
    {
        public HisseSat()
        {
            InitializeComponent();
        }
        decimal alısFiyat;
        int alısAdet;

        VerilerEntities veriler = new VerilerEntities();
        void listele()
        {
            var hisseler = veriler.Hisse.ToList();
            gridControl1.DataSource = hisseler;
        }
        void HisseyiSil()
        {
            Hisse sil = new Hisse();
            var x = int.Parse(txbId.Text);
            var silinecek = veriler.Hisse.Find(x);
            veriler.Hisse.Remove(silinecek);
            veriler.SaveChanges();
        }
        void HisseyiGuncelle()
        {
            Hisse guncelle = new Hisse();
            var x = int.Parse(txbId.Text);
            var guncellenecek = veriler.Hisse.Find(x);
            guncellenecek.Adet = alısAdet - int.Parse(txbAdet.Text);
            guncellenecek.Toplam = (alısAdet - int.Parse(txbAdet.Text)) * alısFiyat;
            veriler.SaveChanges();
        }

        private void HisseSat_Load(object sender, EventArgs e)
        {
            listele();
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txbAd.Text = gridView1.GetFocusedRowCellValue("HisseAd").ToString();
            txbAdet.Text = gridView1.GetFocusedRowCellValue("Adet").ToString();
            txbFiyat.Text = gridView1.GetFocusedRowCellValue("Fiyat").ToString();
            txbId.Text = gridView1.GetFocusedRowCellValue("HisseId").ToString();
            alısAdet = int.Parse(gridView1.GetFocusedRowCellValue("Adet").ToString());
            alısFiyat = decimal.Parse(gridView1.GetFocusedRowCellValue("Fiyat").ToString());
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbTarih.Text != "" && txbAdet.Text != "" && txbFiyat.Text != "" && txbId.Text != "")
                {
                    if (alısAdet == double.Parse(txbAdet.Text))
                    {
                        HisseSonuc sonuc = new HisseSonuc();
                        sonuc.Adet = int.Parse(txbAdet.Text);
                        sonuc.Fiyat = decimal.Parse(txbFiyat.Text);
                        sonuc.SatilanHisseAdi = txbAd.Text;
                        sonuc.SatilanTarih = txbTarih.DateTime;
                        sonuc.Kazanc = (decimal.Parse(txbFiyat.Text) * int.Parse(txbAdet.Text)) - alısFiyat * int.Parse(txbAdet.Text);
                        veriler.HisseSonuc.Add(sonuc);
                        veriler.SaveChanges();
                        HisseyiSil();

                        XtraMessageBox.Show("satildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.None);

                        listele();
                    }
                    else if (alısAdet > double.Parse(txbAdet.Text))
                    {

                        HisseSonuc sonuc = new HisseSonuc();
                        sonuc.Adet = int.Parse(txbAdet.Text);
                        sonuc.Fiyat = decimal.Parse(txbFiyat.Text);
                        sonuc.SatilanHisseAdi = txbAd.Text;
                        sonuc.SatilanTarih = txbTarih.DateTime;
                        sonuc.Kazanc = (decimal.Parse(txbFiyat.Text) * int.Parse(txbAdet.Text)) - alısFiyat * int.Parse(txbAdet.Text);
                        veriler.HisseSonuc.Add(sonuc);
                        veriler.SaveChanges();
                        HisseyiGuncelle();
                        XtraMessageBox.Show("satildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.None);

                        listele();
                    }
                    else
                    {
                        XtraMessageBox.Show("fazla adet girdiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Kutuları Doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {

            }
        }
    }
}
