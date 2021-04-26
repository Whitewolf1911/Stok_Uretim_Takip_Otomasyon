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
                                SiparişNo=x.SIPARISNO,
                                Müşteri=x.MUSTERI,
                                Tür=x.URUNTIPI,
                                ÜrünKodu=x.URUNKODU,
                                Kalınlık = x.HAMKALINLIK,
                                Genişlik = x.HAMGENISLIK,
                                Menşei = x.MENSEI,
                                Özellik = x.OZELLIK,
                                Pres = x.PRESSAYI,
                                HarcananMiktarKg = x.HAMHARCANAN,
                                Tarih  =x.TARIH,
                                Raporlayan =x.RAPORLAYAN



                            }).ToList().OrderByDescending(x => x.Tarih);
            gridControl1.DataSource = degerler;

            gridView1.Columns[3].AppearanceCell.BackColor = Color.Cyan;
            gridView1.Columns[4].AppearanceCell.BackColor = Color.LightGreen;
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
            if (gridView1.GetFocusedRowCellValue("Müşteri") != null) { txt_musteri.Text = gridView1.GetFocusedRowCellValue("Müşteri").ToString(); }
            if (gridView1.GetFocusedRowCellValue("ÜrünKodu") != null) { txt_urunKodu.Text = gridView1.GetFocusedRowCellValue("ÜrünKodu").ToString(); }
            if (gridView1.GetFocusedRowCellValue("Kalınlık ") != null && gridView1.GetFocusedRowCellValue("Genişlik") != null)
            { txt_secilenHam.Text = gridView1.GetFocusedRowCellValue("Kalınlık").ToString() + " x " + gridView1.GetFocusedRowCellValue("Genişlik"); }
            if (gridView1.GetFocusedRowCellValue("Menşei") != null) { txt_mensei.Text = gridView1.GetFocusedRowCellValue("Menşei").ToString(); }
            if (gridView1.GetFocusedRowCellValue("HarcananMiktarKg") != null) { txt_Miktar.Text = gridView1.GetFocusedRowCellValue("HarcananMiktarKg").ToString(); }
            if (gridView1.GetFocusedRowCellValue("Pres") != null) { txt_pres.Text = gridView1.GetFocusedRowCellValue("Pres").ToString(); }

        }
    }
}
