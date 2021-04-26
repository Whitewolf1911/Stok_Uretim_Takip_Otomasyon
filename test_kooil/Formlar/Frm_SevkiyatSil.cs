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
    public partial class Frm_SevkiyatSil : Form
    {
        public Frm_SevkiyatSil()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();
        
        void listele()
        {
            var veriler = (from x in db.TBL_SEVKIYAT
                           select new
                           {
                               x.ID,
                               Müşteri = x.MUSTERI,
                               Tür = x.URUNTUR,
                               ÜrünKodu = x.URUNKOD,
                               Adet = x.ADET,
                               SevkiyatTürü = x.SEVKIYATTUR,
                               Tarih = x.TARIH,
                               SiparişNo = x.SIPARISNO

                           }).ToList().OrderByDescending(x => x.Tarih);
            gridControl1.DataSource = veriler;
            gridView1.Columns[0].Visible = false;

        }
        private void Frm_SevkiyatSil_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void Btn_Yenile_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void Btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Sorgu = MessageBox.Show("Seçilen Sevkiyatı Silmek İstediğinize Emin Misiniz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Sorgu == DialogResult.Yes)
                {
                    int sevkID = (int)gridView1.GetFocusedRowCellValue("ID");
                    var sevk = db.TBL_SEVKIYAT.Find(sevkID);
                    db.TBL_SEVKIYAT.Remove(sevk);
                    db.SaveChanges();
                    XtraMessageBox.Show("Sevkiyat Silindi . Stok Durumunu Düzeltmeyi Unutmayınız ! ", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    listele();
                }
            }
            catch(Exception) { 
                    XtraMessageBox.Show("Bir Hata Oluştu ! ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
