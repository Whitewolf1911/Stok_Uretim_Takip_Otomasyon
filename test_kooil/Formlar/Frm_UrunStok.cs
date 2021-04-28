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
    public partial class Frm_UrunStok : Form
    {
        public Frm_UrunStok()
        {
            InitializeComponent();
        }

        DB_kooil_testEntities db = new DB_kooil_testEntities();
        Frm_UrunStokLog frmStokLog;
        void listele()
        {
            try
            {
                var igneler = (from x in db.TBL_IGNELER
                               select new
                               {
                                   Tür = x.TUR,
                                   ÜrünKodu = x.IGNEKOD,
                                   Stok = x.STOK,
                                   x.FOTO
                               }
                               );
                gridControl1.DataSource = igneler.ToList().OrderByDescending(x => x.Stok);

                gridView1.Columns[0].AppearanceCell.BackColor = Color.Cyan;
                gridView1.Columns[1].AppearanceCell.BackColor = Color.Yellow;
                gridView1.Columns[2].AppearanceCell.BackColor = Color.LightGreen;
                gridView1.Columns[3].Visible = false;
            }
            catch (Exception) { }

        }

        private void Frm_UrunStok_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
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

            if (gridView1.GetFocusedRowCellValue("Tür") != null)
            {
                  txt_urunTip.Text = gridView1.GetFocusedRowCellValue("Tür").ToString();
            }
            if (gridView1.GetFocusedRowCellValue("ÜrünKodu") != null)
            {
                txt_urunKod.Text = gridView1.GetFocusedRowCellValue("ÜrünKodu").ToString();
            }
            if (gridView1.GetFocusedRowCellValue("Stok") != null)
            {
                txt_stokAdet.Text = gridView1.GetFocusedRowCellValue("Stok").ToString();
            }

            if (gridView1.GetFocusedRowCellValue("FOTO") != null)
            {
                pic_IgneFoto.Image = Frm_IgneTurleri.ImageFromByteArray((byte[])gridView1.GetFocusedRowCellValue("FOTO"));
            }
            if (gridView1.GetFocusedRowCellValue("FOTO") == null)
            {
                pic_IgneFoto.Image = null;
            }
        }

        private void Btn_Log_Click(object sender, EventArgs e)
        {
            if (frmStokLog == null || frmStokLog.IsDisposed)
            {
                frmStokLog = new Frm_UrunStokLog();
                frmStokLog.Show();
            }
        }
    }
}
