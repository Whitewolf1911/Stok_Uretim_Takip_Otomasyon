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
    public partial class Frm_PresRaporSil : Form
    {
        public Frm_PresRaporSil()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();

        void listele()
        {
            try
            {
                var veriler = (from x in db.TBL_PRES
                               select new
                               {
                                   x.RAPORID,
                                   SiparişNo = x.SIPARISNO,
                                   PartiNo = x.PARTINO,
                                   Tür = x.URUNTUR,
                                   Hammadde = x.HAMMADDE,
                                   Adet = x.ISLENENMIKTAR,
                                   Tarih = x.TARIH
                               }).ToList().OrderByDescending(x => x.Tarih);
                gridControl1.DataSource = veriler;
                gridView1.Columns[0].Visible = false;
            }
            catch(Exception) { }

        }
        private void Frm_PresRaporSil_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void Btn_yenile_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void Btn_sil_Click(object sender, EventArgs e)
        {
            if(gridView1.GetFocusedRowCellValue("RAPORID") != null)
            {

                try
                {
                    DialogResult Sorgu = MessageBox.Show("Seçilen Raporu Silmek İstediğinize Emin Misiniz ? .", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Sorgu == DialogResult.Yes)
                    {
                        var rapID = (int)gridView1.GetFocusedRowCellValue("RAPORID");

                        var rap = db.TBL_PRES.Find(rapID);
                        db.TBL_PRES.Remove(rap);
                        db.SaveChanges();
                        MessageBox.Show("Rapor Sistemden Kaldırıldı. ", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listele();
                    }
                }
                catch (Exception) { }
            }
        }
    }
}
