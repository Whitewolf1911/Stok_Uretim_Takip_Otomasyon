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
    public partial class Frm_SipaktifEt : Form
    {
        public Frm_SipaktifEt()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();

        void listele()
        {
            var veriler = (from x in db.TBL_SIPARIS
                           select new
                           {
                               SiparişNo = x.SIPARISNOID,
                               Müşteri = x.MUSTERI,
                               Tür = x.TBL_IGNELER.TUR,
                               ÜrünKodu = x.TBL_IGNELER.IGNEKOD,
                               SiparişAdet = x.URUNADETI,
                               SiparişTarihi = x.SIPARISTARIHI,
                               İstenilenTarih = x.ISTENILENTARIH,
                               x.AKTIF

                           }).ToList().OrderByDescending(x => x.SiparişNo).Where(x=> x.AKTIF == false);
            gridControl1.DataSource = veriler;
            gridView1.Columns[7].Visible = false;
        }

        private void Frm_SipaktifEt_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void Btn_yenile_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void Btn_aktifet_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Sorgu = MessageBox.Show("Seçilen Siparişi Aktif Etmek İstediğinize Emin Misiniz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Sorgu == DialogResult.Yes)
                {
                    int sipNo = (int)gridView1.GetFocusedRowCellValue("SiparişNo");
                    var sip = db.TBL_SIPARIS.Find(sipNo);
                    sip.AKTIF = true;
                    db.SaveChanges();
                    XtraMessageBox.Show("Sipariş Aktif Edildi. ", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Bir Hata Oluştu !  ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
