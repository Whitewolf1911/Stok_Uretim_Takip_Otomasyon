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
    public partial class Frm_RaporOzet : Form
    {
        public Frm_RaporOzet()
        {
            InitializeComponent();
        }

        DB_kooil_testEntities db = new DB_kooil_testEntities();

        void listele() {
            try
            {
                var veriler = (from x in db.TBL_RAPOR
                               select new
                               {
                                   SiparişNo = x.SIPARISNO,
                                   İşlem = x.ISLEM,
                                   Tür = x.URUNTUR,
                                   ÜrünKodu = x.IGNEKODU,
                                   İşlenen = x.ISLENENMIKTAR,
                                   Tarih = x.TARIH,
                                   Raporlayan = x.RAPORLAYAN,
                                   Not = x.NOT,


                               });
                gridControl1.DataSource = veriler.ToList().OrderByDescending(x => x.Tarih);

            }
            catch (Exception) { }
        }

        private void Frm_RaporOzet_Load(object sender, EventArgs e)
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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(gridView1.GetFocusedRowCellValue("Not") != null) { txt_sipNot.Text = gridView1.GetFocusedRowCellValue("Not").ToString(); }
            if(gridView1.GetFocusedRowCellValue("Raporlayan") != null) { txt_Raporlayan.Text = gridView1.GetFocusedRowCellValue("Raporlayan").ToString(); }
            if(gridView1.GetFocusedRowCellValue("İşlem") != null) { txt_islem.Text = gridView1.GetFocusedRowCellValue("İşlem").ToString(); }
            if (gridView1.GetFocusedRowCellValue("İşlenen") != null) { txt_adet.Text = gridView1.GetFocusedRowCellValue("İşlenen").ToString(); }
            if (gridView1.GetFocusedRowCellValue("SiparişNo") != null) { txt_sipNo.Text = gridView1.GetFocusedRowCellValue("SiparişNo").ToString(); }
            if (gridView1.GetFocusedRowCellValue("ÜrünKodu") != null) { txt_sipIgneTur.Text = gridView1.GetFocusedRowCellValue("ÜrünKodu").ToString(); }
            if(gridView1.GetFocusedRowCellValue("Tarih") != null) { date_tarih.EditValue = gridView1.GetFocusedRowCellValue("Tarih"); }

        }
    }
}
