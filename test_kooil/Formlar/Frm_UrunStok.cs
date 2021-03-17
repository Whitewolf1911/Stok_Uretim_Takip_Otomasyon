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
        void listele()
        {
            var igneler = (from x in db.TBL_IGNELER
                           select new
                           {
                               x.TUR,
                               x.IGNEKOD,
                               x.STOK,         
                               x.FOTO
                           }
                           );
            gridControl1.DataSource = igneler.ToList().OrderByDescending(x => x.STOK);

            gridView1.Columns[0].AppearanceCell.BackColor = Color.Cyan;
            gridView1.Columns[1].AppearanceCell.BackColor = Color.Yellow;
            gridView1.Columns[2].AppearanceCell.BackColor = Color.LightGreen;
            gridView1.Columns[3].Visible = false;

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

            if (gridView1.GetFocusedRowCellValue("TUR") != null)
            {
                  txt_urunTip.Text = gridView1.GetFocusedRowCellValue("TUR").ToString();
            }
            if (gridView1.GetFocusedRowCellValue("IGNEKOD") != null)
            {
                txt_urunKod.Text = gridView1.GetFocusedRowCellValue("IGNEKOD").ToString();
            }
            if (gridView1.GetFocusedRowCellValue("STOK") != null)
            {
                txt_stokAdet.Text = gridView1.GetFocusedRowCellValue("STOK").ToString();
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
    }
}
