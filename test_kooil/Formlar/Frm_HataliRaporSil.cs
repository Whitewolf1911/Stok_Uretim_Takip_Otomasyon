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
    public partial class Frm_HataliRaporSil : Form
    {
        public Frm_HataliRaporSil()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();

        void raporListele() {
            try
            {
                var veriler = (from x in db.TBL_RAPOR
                               select new
                               {
                                   İşlem = x.ISLEM,
                                   Tür = x.URUNTUR,
                                   ÜrünKodu = x.IGNEKODU,
                                   İşlenenMiktar = x.ISLENENMIKTAR,
                                   Tarih = x.TARIH,
                                   Raporlayan = x.RAPORLAYAN,
                                   x.RAPORID,
                                   x.NOT,

                               }).ToList().OrderByDescending(x => x.Tarih);

                gridControl1.DataSource = veriler;
                gridView1.Columns[6].Visible = false;
                gridView1.Columns[7].Visible = false;

            }
            catch (Exception) { }
        }
        private void Frm_HataliRaporSil_Load(object sender, EventArgs e)
        {
            raporListele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            btn_guncelle.Enabled = true;
            Btn_RaporSil.Enabled = true;
            try
            {
                if(gridView1.GetFocusedRowCellValue("İşlem") != null)
                {
                    txt_islem.Text = gridView1.GetFocusedRowCellValue("İşlem").ToString();
                }
                if(gridView1.GetFocusedRowCellValue("ÜrünKodu")!= null)
                {
                    txt_urunKod.Text = gridView1.GetFocusedRowCellValue("ÜrünKodu").ToString();
                }
                if(gridView1.GetFocusedRowCellValue("Raporlayan") != null)
                {
                    txt_raporlayan.Text = gridView1.GetFocusedRowCellValue("Raporlayan").ToString();
                }
                if(gridView1.GetFocusedRowCellValue("İşlenenMiktar")!= null){
                    num_miktar.Value = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("İşlenenMiktar"));

                }
                if(gridView1.GetFocusedRowCellValue("NOT")!= null)
                {
                    txt_not.Text = gridView1.GetFocusedRowCellValue("NOT").ToString();
                }
            }
            catch (Exception) { }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Sorgu = MessageBox.Show("Seçilen Raporu Güncellemek İstediğinize Emin Misiniz ? ", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Sorgu == DialogResult.Yes)
                {
                    int repID = (int)gridView1.GetFocusedRowCellValue("RAPORID");
                    var rep = db.TBL_RAPOR.Find(repID);
                    rep.ISLENENMIKTAR = (int)num_miktar.Value;
                    rep.NOT = txt_not.Text;
                    db.SaveChanges();
                    XtraMessageBox.Show("Rapor Güncellendi. ", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    raporListele();

                }
            }
            catch (Exception) { }
        }

        private void Btn_RaporSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Sorgu = MessageBox.Show("Seçilen Raporu Silmek İstediğinize Emin Misiniz ? ", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Sorgu == DialogResult.Yes)
                {
                    int repID = (int)gridView1.GetFocusedRowCellValue("RAPORID");
                    var rep = db.TBL_RAPOR.Find(repID);
                    db.TBL_RAPOR.Remove(rep);
                    db.SaveChanges();
                    XtraMessageBox.Show("Rapor Silindi. ", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    raporListele();


                }
            }
            catch (Exception) { }
        }
    }
}
