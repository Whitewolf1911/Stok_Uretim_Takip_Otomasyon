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
    public partial class FrmPolisaj1Rapor : Form
    {
        public FrmPolisaj1Rapor()
        {
            InitializeComponent();
        }

        DB_kooil_testEntities db = new DB_kooil_testEntities();
        void listele()
        {
            var veriler = (from x in db.TBL_RAPOR
                           select new
                           {
                               x.SIPARISNO,
                               x.RAPORLAYAN,
                               x.IGNEKODU,
                               x.ISLENENMIKTAR,
                               x.TARIH,
                               x.NOT,
                               x.ISLEM

                           }).ToList().OrderByDescending(x => x.TARIH).Where(x => x.ISLEM == "Polisaj1");

            gridControl1.DataSource = veriler;

        }

        private void FrmPolisaj1Rapor_Load(object sender, EventArgs e)
        {
            listele();
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
        private void Btn_Yazdir_Click(object sender, EventArgs e)
        {
            ShowGridPreview(gridControl1);
            PrintGrid(gridControl1);
        }

        private void Btn_Yenile_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("SIPARISNO") != null) { txt_SiparisNo.Text = gridView1.GetFocusedRowCellValue("SIPARISNO").ToString(); }

            if (gridView1.GetFocusedRowCellValue("RAPORLAYAN") != null) { txt_Raporlayan.Text = gridView1.GetFocusedRowCellValue("RAPORLAYAN").ToString(); }

            if (gridView1.GetFocusedRowCellValue("IGNEKODU") != null) { txt_IgneKodu.Text = gridView1.GetFocusedRowCellValue("IGNEKODU").ToString(); }

            if (gridView1.GetFocusedRowCellValue("ISLENENMIKTAR") != null) { txt_IslenenAdet.Text = gridView1.GetFocusedRowCellValue("ISLENENMIKTAR").ToString(); }

            if (gridView1.GetFocusedRowCellValue("TARIH") != null) { txt_Tarih.EditValue = (DateTime)gridView1.GetFocusedRowCellValue("TARIH"); }

            if (gridView1.GetFocusedRowCellValue("NOT") != null) { txt_Not.Text = gridView1.GetFocusedRowCellValue("NOT").ToString(); }
        }
    }
}
