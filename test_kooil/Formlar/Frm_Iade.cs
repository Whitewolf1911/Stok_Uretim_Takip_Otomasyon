using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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
    public partial class Frm_Iade : Form
    {
        public Frm_Iade()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();
        Frm_YeniIade frmYeniIade;

        void listele() {
            var veriler = (from x in db.TBL_IADE
                           select new
                           {
                               x.ID,
                               Firma = x.FIRMA,
                               Tür = x.URUNTUR,
                               ÜrünKod = x.URUNKOD,
                               Adet = x.ADET,
                               SiparişNo = x.SIPNO,
                               Tarih = x.TARIH,
                               Neden = x.NEDEN,
                               Sonuç = x.SONUC,
                               Raporlayan = x.RAPORLAYAN

                           }).ToList().OrderByDescending(x => x.Tarih);
            gridControl1.DataSource = veriler;
            gridView1.Columns[0].Visible = false;
            
        }
        private void Frm_Iade_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void Btn_yenile_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txt_sonuc.Clear();
            txt_neden.Clear();
            if (gridView1.GetFocusedRowCellValue("Firma") != null) { txt_firma.Text = gridView1.GetFocusedRowCellValue("Firma").ToString(); }
            if (gridView1.GetFocusedRowCellValue("ÜrünKod") != null) { txt_UrunKod.Text = gridView1.GetFocusedRowCellValue("ÜrünKod").ToString(); }
            if (gridView1.GetFocusedRowCellValue("SiparişNo") != null) { txt_sipNo.Text = gridView1.GetFocusedRowCellValue("SiparişNo").ToString(); }
            if (gridView1.GetFocusedRowCellValue("Adet") != null) { txt_adet.Text = gridView1.GetFocusedRowCellValue("Adet").ToString(); }
            if (gridView1.GetFocusedRowCellValue("Neden") != null) { txt_neden.Text = gridView1.GetFocusedRowCellValue("Neden").ToString(); }
            if (gridView1.GetFocusedRowCellValue("Sonuç") != null) { txt_sonuc.Text = gridView1.GetFocusedRowCellValue("Sonuç").ToString(); }
        }

        private void Btn_IadeKaldir_Click(object sender, EventArgs e)
        {
            DialogResult siradakiAsamaSorgu = MessageBox.Show("Seçilen Raporu Silmek İstediğinize Emin Misiniz ? ", " Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (siradakiAsamaSorgu == DialogResult.Yes)
            {
                int rapID = (int)gridView1.GetFocusedRowCellValue("ID");
                var rap = db.TBL_IADE.Find(rapID);
                db.TBL_IADE.Remove(rap);
                db.SaveChanges();
                XtraMessageBox.Show("Rapor Sistemden Silindi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }


        }

        private void Btn_YeniIade_Click(object sender, EventArgs e)
        {
            if (frmYeniIade == null || frmYeniIade.IsDisposed) {

                frmYeniIade = new Frm_YeniIade();
                frmYeniIade.Show();
            }
        }

        private void Btn_SonucGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult siradakiAsamaSorgu = MessageBox.Show("Seçilen Raporu Sonuçlandırmak İstediğinize Emin Misiniz ? ", " Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (siradakiAsamaSorgu == DialogResult.Yes)
            {
                int rapID = (int)gridView1.GetFocusedRowCellValue("ID");
                var rap = db.TBL_IADE.Find(rapID);
                rap.SONUC = txt_sonuc.Text;
                db.SaveChanges();
                XtraMessageBox.Show("İade Sonuçlandırıldı.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();

            }

        }

        private void ShowGridPreview(GridControl grid)
        {
            // Check whether the GridControl can be previewed.
            if (!grid.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                return;
            }

            // Open the Preview window.
            grid.ShowPrintPreview();
        }

        private void PrintGrid(GridControl grid)
        {
            // Check whether the GridControl can be printed.
            if (!grid.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                return;
            }

            // Print.
            grid.Print();
        }

        private void Btn_yazdir_Click(object sender, EventArgs e)
        {
            ShowGridPreview(gridControl1);
            PrintGrid(gridControl1);
        }
    }
}
