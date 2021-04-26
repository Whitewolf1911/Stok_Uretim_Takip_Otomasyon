﻿using DevExpress.XtraGrid;
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
    public partial class Frm_PresRaporlari : Form
    {
        public Frm_PresRaporlari()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();
        
        void listele() {
            var veriler = (from x in db.TBL_PRES
                           select new
                           {
                               SiparişNo = x.SIPARISNO,
                               Raporlayan = x.RAPORLAYAN,
                               Tür = x.URUNTUR,
                               ÜrünKodu = x.IGNEKODU,
                               İşlenenMiktar = x.ISLENENMIKTAR,
                               Tarih = x.TARIH,
                               Not = x.NOT,
                             

                           }).ToList().OrderByDescending(x => x.Tarih);

            gridControl1.DataSource = veriler;

        }
        private void Btn_Yenile_Click(object sender, EventArgs e)
        {
            listele();
        }
        private void Frm_PresRaporlari_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("SiparişNo") != null) { txt_SiparisNo.Text = gridView1.GetFocusedRowCellValue("SiparişNo").ToString(); }

            if (gridView1.GetFocusedRowCellValue("Raporlayan") != null) { txt_Raporlayan.Text = gridView1.GetFocusedRowCellValue("Raporlayan").ToString(); }

            if (gridView1.GetFocusedRowCellValue("ÜrünKodu") != null) { txt_IgneKodu.Text = gridView1.GetFocusedRowCellValue("ÜrünKodu").ToString(); }

            if (gridView1.GetFocusedRowCellValue("İşlenenMiktar") != null) { txt_IslenenAdet.Text = gridView1.GetFocusedRowCellValue("İşlenenMiktar").ToString(); }

            if (gridView1.GetFocusedRowCellValue("Not") != null) { txt_Not.Text = gridView1.GetFocusedRowCellValue("Not").ToString(); }


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
