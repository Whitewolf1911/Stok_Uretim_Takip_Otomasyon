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
    public partial class Frm_TamamlananSiparisler : Form
    {
        public Frm_TamamlananSiparisler()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();
        Frm_UretimDetay frmDetay;
        void listele()
        {
            try
            {
                var veriler = (from x in db.TBL_SIPARIS
                               select new
                               {
                                   SiparişNo = x.SIPARISNOID,
                                   Müşteri = x.MUSTERI,
                                   Tür = x.TBL_IGNELER.TUR,
                                   ÜrünKodu = x.TBL_IGNELER.IGNEKOD,
                                   SiparişAdet = x.URUNADETI,
                                   Giden = x.SEVKIYATSAYI,
                                   SiparişTarihi = x.SIPARISTARIHI,
                                   İstenilenTarih = x.ISTENILENTARIH,
                                   x.AKTIF,
                                   Not = x.NOTLAR,
                                   x.SIPARISASAMASI

                               }).ToList().OrderByDescending(x => x.SiparişNo);

                gridControl1.DataSource = veriler.Where(x => x.AKTIF == false);

                //renklendirmeler ve sutun gizlemeler
                gridView1.Columns[1].AppearanceCell.BackColor = Color.LightGreen;
                gridView1.Columns[2].AppearanceCell.BackColor = Color.Aquamarine;
                gridView1.Columns[3].AppearanceCell.BackColor = Color.LightYellow;
                gridView1.Columns[4].AppearanceCell.BackColor = Color.Cyan;
                gridView1.Columns[5].AppearanceCell.BackColor = Color.Yellow;
                gridView1.Columns[8].Visible = false;
                gridView1.Columns[10].Visible = false;
            }
            catch (Exception) { }

        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void Frm_TamamlananSiparisler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("SiparişAdet") != null) { txt_adet.Text = gridView1.GetFocusedRowCellValue("SiparişAdet").ToString(); }
            if (gridView1.GetFocusedRowCellValue("Müşteri") != null) { txt_musteri.Text = gridView1.GetFocusedRowCellValue("Müşteri").ToString(); }
            if (gridView1.GetFocusedRowCellValue("ÜrünKodu") != null) { txt_sipIgneTur.Text = gridView1.GetFocusedRowCellValue("ÜrünKodu").ToString(); }
            if (gridView1.GetFocusedRowCellValue("SiparişNo") != null) { txt_sipNo.Text = gridView1.GetFocusedRowCellValue("SiparişNo").ToString(); }
            if (gridView1.GetFocusedRowCellValue("Not") != null) { txt_sipNot.Text = gridView1.GetFocusedRowCellValue("Not").ToString(); }
            if (gridView1.GetFocusedRowCellValue("Giden") != null) { txt_adet.Text = gridView1.GetFocusedRowCellValue("Giden").ToString(); }
        }

        private void Btn_UretimDetay_Click(object sender, EventArgs e)
        {
            frmDetay = new Frm_UretimDetay();
            frmDetay.Show();
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
