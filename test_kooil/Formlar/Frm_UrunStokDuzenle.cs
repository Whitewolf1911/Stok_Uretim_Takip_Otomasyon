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
using test_kooil.Entity;

namespace test_kooil.Formlar
{
    public partial class Frm_UrunStokDuzenle : Form
    {
        public Frm_UrunStokDuzenle()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();
        private void Btn_Iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void listele()
        {
            try
            {
                var veriler = (from x in db.TBL_IGNELER
                               select new
                               {
                                   x.ID,
                                   Tür = x.TUR,
                                   ÜrünKodu = x.IGNEKOD,
                                   Stok = x.STOK
                               }).ToList().OrderByDescending(x => x.Stok);

                gridControl1.DataSource = veriler;
                gridView1.Columns[0].Visible = false;
            }
            catch (Exception) { }
        }

        private void Frm_UrunStokDuzenle_Load(object sender, EventArgs e)
        {
            listele();
            txt_raporlayan.Text = Frm_Login.user.AdSoyad;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Btn_Ekle.Enabled = true;
            Btn_azalt.Enabled = true;
            if (gridView1.GetFocusedRowCellValue("ÜrünKodu") != null)
            {
                txt_secilenUrun.Text = gridView1.GetFocusedRowCellValue("ÜrünKodu").ToString();
            }


        }

        private void Btn_Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult siradakiAsamaSorgu = MessageBox.Show("Seçilen ürüne stok eklemek istediğinize emin misiniz ? ", "Stok Ekleme", MessageBoxButtons.YesNo);

                if (siradakiAsamaSorgu == DialogResult.Yes)
                {
                    int id = (int)gridView1.GetFocusedRowCellValue("ID");
                    var urun = db.TBL_IGNELER.Find(id);
                    urun.STOK += (int)num_Miktar.Value;

                    TBL_URUNSTOKLOG log = new TBL_URUNSTOKLOG();
                    log.RAPORLAYAN = txt_raporlayan.Text;
                    log.TARIH = DateTime.Today;
                    log.MIKTAR = (int)num_Miktar.Value;
                    log.ISLEM = "EKLEME";
                    log.URUN = gridView1.GetFocusedRowCellValue("ÜrünKodu").ToString();
                    db.TBL_URUNSTOKLOG.Add(log);

                    db.SaveChanges();
                    XtraMessageBox.Show("Ürün Stoğu Sisteme Eklendi. ", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Bir Hata Oluştu !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_azalt_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)gridView1.GetFocusedRowCellValue("ID");
                var urun = db.TBL_IGNELER.Find(id);
                DialogResult siradakiAsamaSorgu = MessageBox.Show("Seçilen ürünün stoğunu azaltmak istediğinize emin misiniz ? ", "Stok Azaltma", MessageBoxButtons.YesNo);
                if (urun.STOK >= num_Miktar.Value)
                {
                    if (siradakiAsamaSorgu == DialogResult.Yes)
                    {
                        urun.STOK -= (int)num_Miktar.Value;
                        TBL_URUNSTOKLOG log = new TBL_URUNSTOKLOG();
                        log.RAPORLAYAN = txt_raporlayan.Text;
                        log.TARIH = DateTime.Today;
                        log.MIKTAR = (int)num_Miktar.Value;
                        log.ISLEM = "AZALTMA";
                        log.URUN = gridView1.GetFocusedRowCellValue("ÜrünKodu").ToString();
                        db.TBL_URUNSTOKLOG.Add(log);
                        db.SaveChanges();
                        XtraMessageBox.Show("Ürün Stoğu Sistemden Azaltıldı. ", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listele();

                    }

                }
                else
                {
                    XtraMessageBox.Show("Ürün Stoğu Negatif Olamaz. Eksiltceğiniz Değeri Tam Olarak Giriniz ! ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception) { 
                XtraMessageBox.Show("Bir Hata Oluştu !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
