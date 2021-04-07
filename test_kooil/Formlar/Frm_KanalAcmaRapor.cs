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
    public partial class Frm_KanalAcmaRapor : Form
    {
        public Frm_KanalAcmaRapor()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();
        void listele()
        {
            var veriler = (from x in db.TBL_KANALACMA
                           select new
                           {
                               x.SIPARISNO,
                               x.RAPORLAYAN,
                               x.IGNEKODU,
                               x.ISLENENMIKTAR,
                               x.TARIH,
                               x.NOT

                           }).ToList().OrderByDescending(x => x.TARIH);

            gridControl1.DataSource = veriler;

        }
        private void Btn_Yenile_Click(object sender, EventArgs e)
        {
            listele();       
        }

        private void Frm_KanalAcmaRapor_Load(object sender, EventArgs e)
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
        
    }
}
