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
    public partial class Frm_kontrolDuzenle : Form
    {
        public Frm_kontrolDuzenle()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();

        void listele()
        {
            try
            {
                var veriler = (from x in db.TBL_KONTROL
                               select new
                               {
                                   x.RAPORID,
                                   SiparişNo = x.SIPARISNO,
                                   PartiNo = x.PARTINO,
                                   Barkod = x.BARKODKOD,
                                   Tür = x.URUNTUR,
                                   ÜrünKodu = x.IGNEKODU,
                                   Tarih = x.TARIH,
                                   Adet = x.ISLENENMIKTAR,
                                   Raporlayan = x.RAPORLAYAN,
                                   Not = x.NOT,



                               }).ToList().OrderByDescending(x => x.Tarih);

                gridControl1.DataSource = veriler;
                gridView1.Columns[0].Visible = false;
            }
            catch (Exception) { }

        }
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Sorgu = MessageBox.Show("Seçilen Raporu Güncellemek İstediğinize Emin Misiniz ? .", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Sorgu == DialogResult.Yes)
                {
                    var rapID = (int)gridView1.GetFocusedRowCellValue("RAPORID");

                    var rap = db.TBL_KONTROL.Find(rapID);
                    rap.NOT = txt_not.Text;
                    rap.BARKODKOD = txt_barkod.Text;
                    rap.ISLENENMIKTAR = (int)num_miktar.Value;
                    db.SaveChanges();
                    MessageBox.Show("Rapor Güncellendi ","İşlem Başarılı" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                }
            }
            catch (Exception) { }
            }

        private void Frm_kontrolDuzenle_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void Btn_RaporSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Sorgu = MessageBox.Show("Seçilen Raporu Silmek İstediğinize Emin Misiniz ? .", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Sorgu == DialogResult.Yes)
                {
                    var rapID = (int)gridView1.GetFocusedRowCellValue("RAPORID");

                    var rap = db.TBL_KONTROL.Find(rapID);
                    db.TBL_KONTROL.Remove(rap);
                    db.SaveChanges();
                    MessageBox.Show("Rapor Sistemden Kaldırıldı. ", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                }
            }
            catch (Exception) { }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(gridView1.GetFocusedRowCellValue("Barkod")!= null)
            {
                txt_barkod.Text = gridView1.GetFocusedRowCellValue("Barkod").ToString();
            }
            if (gridView1.GetFocusedRowCellValue("Not") != null)
            {
                txt_not.Text = gridView1.GetFocusedRowCellValue("Not").ToString();
            }
            if (gridView1.GetFocusedRowCellValue("Adet") != null)
            {
                num_miktar.Value = (int)gridView1.GetFocusedRowCellValue("Adet");
            }
            if (gridView1.GetFocusedRowCellValue("Raporlayan") != null)
            {
                txt_raporlayan.Text = gridView1.GetFocusedRowCellValue("Raporlayan").ToString();
            }
            if (gridView1.GetFocusedRowCellValue("ÜrünKodu") != null)
            {
                txt_urunKod.Text = gridView1.GetFocusedRowCellValue("ÜrünKodu").ToString();
            }

        }
    }
}
