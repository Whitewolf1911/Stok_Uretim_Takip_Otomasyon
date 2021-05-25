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
    public partial class Frm_YeniIade : Form
    {
        public Frm_YeniIade()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();

        void urunListele() {
            try
            {
                var veriler = (from x in db.TBL_IGNELER
                               select new
                               {
                                   Tür = x.TUR,
                                   ÜrünKodu = x.IGNEKOD,

                               }).ToList().OrderBy(x => x.ÜrünKodu);
                gridControl1.DataSource = veriler;
            }
            catch (Exception) { }
        }
        void musteriListele()
        {
            try
            {
                var musteri = (from x in db.TBL_FIRMALAR
                               select new
                               {
                                   Firmalar = x.FIRMAAD


                               }).ToList().OrderBy(x => x.Firmalar);

                lookUp_firma.Properties.ValueMember = "Firmalar";
                lookUp_firma.Properties.DisplayMember = "Firmalar";
                lookUp_firma.Properties.DataSource = musteri;
            }
            catch (Exception) { }

        }
        private void Frm_YeniIade_Load(object sender, EventArgs e)
        {
            urunListele();
            musteriListele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Btn_Kaydet.Enabled = true;
            if (gridView1.GetFocusedRowCellValue("ÜrünKodu") != null) { txt_UrunKod.Text = gridView1.GetFocusedRowCellValue("ÜrünKodu").ToString();  }
        }

        private void Btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (lookUp_firma.EditValue != null && date_tarih.EditValue != null)
                {
                    TBL_IADE yeniIade = new TBL_IADE();
                    yeniIade.FIRMA = lookUp_firma.EditValue.ToString();
                    yeniIade.URUNTUR = gridView1.GetFocusedRowCellValue("Tür").ToString();
                    yeniIade.URUNKOD = gridView1.GetFocusedRowCellValue("ÜrünKodu").ToString();
                    yeniIade.ADET = (int)num_adet.Value;
                    yeniIade.BARKOD = txt_barkod.Text;
                    yeniIade.SIPNO = (int)num_sipNo.Value;
                    yeniIade.TARIH = date_tarih.DateTime;
                    yeniIade.RAPORLAYAN = Frm_Login.user.AdSoyad;
                    yeniIade.NEDEN = txt_neden.Text;
                    db.TBL_IADE.Add(yeniIade);
                    db.SaveChanges();
                    XtraMessageBox.Show("İade Eklendi .", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    if (lookUp_firma.EditValue == null)
                    {
                        XtraMessageBox.Show("Firma Seçiniz ! ", "Dikkat !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (date_tarih.EditValue == null)
                    {
                        XtraMessageBox.Show("Tarih Seçiniz ! ", "Dikkat !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            catch (Exception)
            {
                   XtraMessageBox.Show("Bir Hata Oluştu ! Daha Sonra Tekrar Deneyiniz. ", "Dikkat !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
