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
    public partial class Frm_HamRaporlari : Form
    {
        public Frm_HamRaporlari()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();

        void listele() {

            var degerler = (from x in db.TBL_HAMRAPOR
                            select new
                            {
                                x.SIPARISNO,
                                x.MUSTERI,
                                x.URUNTIPI,
                                x.URUNKODU,
                                KALINLIK = x.HAMKALINLIK,
                                GENISLIK = x.HAMGENISLIK,
                                x.MENSEI,
                                x.OZELLIK,
                                Pres = x.PRESSAYI,
                                HarcananMiktar = x.HAMHARCANAN,
                                x.TARIH,
                                x.RAPORLAYAN



                            }).ToList().OrderByDescending(x => x.TARIH);
            gridControl1.DataSource = degerler;

            gridView1.Columns[3].AppearanceCell.BackColor = Color.Cyan;
            gridView1.Columns[5].AppearanceCell.BackColor = Color.LightGreen;
            gridView1.Columns[6].AppearanceCell.BackColor = Color.LightGreen;
            gridView1.Columns[7].AppearanceCell.BackColor = Color.LightGreen;
            gridView1.Columns[8].AppearanceCell.BackColor = Color.LightGreen;
            gridView1.Columns[9].AppearanceCell.BackColor = Color.Orange;



        }
        private void Frm_HamRaporlari_Load(object sender, EventArgs e)
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
        {   //MUSTERI URUNKODU hammadde mensei miktar
            if (gridView1.GetFocusedRowCellValue("MUSTERI") != null) { txt_musteri.Text = gridView1.GetFocusedRowCellValue("MUSTERI").ToString(); }
            if (gridView1.GetFocusedRowCellValue("URUNKODU") != null) { txt_urunKodu.Text = gridView1.GetFocusedRowCellValue("URUNKODU").ToString(); }
            if (gridView1.GetFocusedRowCellValue("KALINLIK") != null && gridView1.GetFocusedRowCellValue("GENISLIK") != null)
            { txt_secilenHam.Text = gridView1.GetFocusedRowCellValue("KALINLIK").ToString() + " x " + gridView1.GetFocusedRowCellValue("GENISLIK"); }
            if (gridView1.GetFocusedRowCellValue("MENSEI") != null) { txt_mensei.Text = gridView1.GetFocusedRowCellValue("MENSEI").ToString(); }
            if (gridView1.GetFocusedRowCellValue("HarcananMiktar") != null) { txt_Miktar.Text = gridView1.GetFocusedRowCellValue("HarcananMiktar").ToString(); }
            if (gridView1.GetFocusedRowCellValue("Pres") != null) { txt_pres.Text = gridView1.GetFocusedRowCellValue("Pres").ToString(); }

        }
    }
}
