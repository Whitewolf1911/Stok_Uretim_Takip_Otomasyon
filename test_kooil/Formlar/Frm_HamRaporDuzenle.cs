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
    public partial class Frm_HamRaporDuzenle : Form
    {
        public Frm_HamRaporDuzenle()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();

        void raporListele() {

            var veriler = (from x in db.TBL_HAMRAPOR
                           select new
                           {
                               x.RAPORID,
                               Kalınlık = x.HAMKALINLIK,
                               Genişlik = x.HAMGENISLIK,
                               Özellik =x.OZELLIK,
                               Menşei = x.MENSEI,
                               HarcananKG = x.HAMHARCANAN,
                               Preslenen = x.PRESSAYI,
                               Tarih = x.TARIH,
                               Raporlayan = x.RAPORLAYAN

                           }).ToList().OrderByDescending(x => x.Tarih);

            gridControl1.DataSource = veriler;
            gridView1.Columns[0].Visible = false;
        
        }
        private void Frm_HamRaporDuzenle_Load(object sender, EventArgs e)
        {
            raporListele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txt_secilenHam.Text = gridView1.GetFocusedRowCellValue("Kalınlık").ToString() + " x " + gridView1.GetFocusedRowCellValue("Genişlik") + " " +
                                  gridView1.GetFocusedRowCellValue("Özellik").ToString() + " " + gridView1.GetFocusedRowCellValue("Menşei").ToString();

            dateEdit1.DateTime = (DateTime)gridView1.GetFocusedRowCellValue("Tarih");
            num_HamMiktar.Value = (int)gridView1.GetFocusedRowCellValue("HarcananKG");
            num_presAdet.Value = (int)gridView1.GetFocusedRowCellValue("Preslenen");


        }

        private void Btn_SiparisSil_Click(object sender, EventArgs e)
        {
            DialogResult Sorgu = MessageBox.Show("Seçilen Raporu Silmek İstediğinize Emin Misiniz ? Bu İşlem Geri Alınamaz !", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Sorgu == DialogResult.Yes)
            {
                int raporID = (int)gridView1.GetFocusedRowCellValue("RAPORID");
                var delRapor = db.TBL_HAMRAPOR.Find(raporID);
                db.TBL_HAMRAPOR.Remove(delRapor);
                db.SaveChanges();
                XtraMessageBox.Show("Rapor Silindi. ", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                raporListele();
            }

        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            DialogResult Sorgu = MessageBox.Show("Seçilen Raporu Güncellemek İstediğinize Emin Misiniz ? ", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Sorgu == DialogResult.Yes)
            {
                int raporID = (int)gridView1.GetFocusedRowCellValue("RAPORID");
                var rapor = db.TBL_HAMRAPOR.Find(raporID);
                rapor.PRESSAYI = (int)num_presAdet.Value;
                rapor.HAMHARCANAN = (int)num_HamMiktar.Value;
                db.SaveChanges();
                XtraMessageBox.Show("Rapor Güncellendi. ", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
