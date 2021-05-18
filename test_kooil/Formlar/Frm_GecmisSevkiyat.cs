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
    public partial class Frm_GecmisSevkiyat : Form
    {
        public Frm_GecmisSevkiyat()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();

        void listele() {
            try
            {
                var veriler = (from x in db.TBL_SEVKIYAT
                               select new
                               {
                                   Sevkiyat = x.SEVKIYATTUR,
                                   Firma = x.MUSTERI,
                                   Tür = x.URUNTUR,
                                   ÜrünKodu = x.URUNKOD,
                                   Adet = x.ADET,
                                   Tarih = x.TARIH,
                                   SiparişNo = x.SIPARISNO,
                                   PartiNo = x.PARTINO


                               }).ToList().OrderByDescending(x => x.Tarih);

                gridControl1.DataSource = veriler;
                gridView1.Columns[0].AppearanceCell.BackColor = Color.Cyan;
                gridView1.Columns[1].AppearanceCell.BackColor = Color.LightGreen;
                gridView1.Columns[2].AppearanceCell.BackColor = Color.LightYellow;
                gridView1.Columns[3].AppearanceCell.BackColor = Color.Aquamarine;
            }
            catch (Exception) { }




        }
        private void Frm_GecmisSevkiyat_Load(object sender, EventArgs e)
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
            if(gridView1.GetFocusedRowCellValue("Sevkiyat")!= null) { txt_Sevkiyat.Text = gridView1.GetFocusedRowCellValue("Sevkiyat").ToString(); }
            if(gridView1.GetFocusedRowCellValue("Firma") != null) { txt_firma.Text = gridView1.GetFocusedRowCellValue("Firma").ToString(); }
            if (gridView1.GetFocusedRowCellValue("Tür") != null) { txt_urunTur.Text = gridView1.GetFocusedRowCellValue("Tür").ToString(); }
            if (gridView1.GetFocusedRowCellValue("ÜrünKodu") != null) { txt_urunKodu.Text = gridView1.GetFocusedRowCellValue("ÜrünKodu").ToString(); }
            if (gridView1.GetFocusedRowCellValue("Adet") != null) { txt_adet.Text = gridView1.GetFocusedRowCellValue("Adet").ToString(); }
            if (gridView1.GetFocusedRowCellValue("Tarih") != null) { date_edit.DateTime = (DateTime)gridView1.GetFocusedRowCellValue("Tarih"); }
            if (gridView1.GetFocusedRowCellValue("SiparişNo") != null) { txt_sipNo.Text = gridView1.GetFocusedRowCellValue("SiparişNo").ToString(); }
            if (gridView1.GetFocusedRowCellValue("SiparişNo") == null) { txt_sipNo.Text = null; }
        }
    }
}
