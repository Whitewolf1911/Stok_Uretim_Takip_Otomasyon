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
    public partial class Frm_RaporOzet : Form
    {
        public Frm_RaporOzet()
        {
            InitializeComponent();
        }

        DB_kooil_testEntities db = new DB_kooil_testEntities();

        void listele() {

            var veriler = (from x in db.TBL_RAPOR
                           select new
                           {
                               x.SIPARISNO,
                               x.ISLEM,
                               x.IGNEKODU,
                               x.ISLENENMIKTAR,
                               x.TARIH,
                               x.RAPORLAYAN,
                               x.NOT,


                           });
            gridControl1.DataSource = veriler.ToList().OrderByDescending(x => x.TARIH);

        
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

            if (    gridView1.GetFocusedRowCellValue("NOT") != null &&
                    gridView1.GetFocusedRowCellValue("RAPORLAYAN") != null &&
                    gridView1.GetFocusedRowCellValue("ISLEM") != null &&
                    gridView1.GetFocusedRowCellValue("ISLENENMIKTAR") != null &&
                    gridView1.GetFocusedRowCellValue("SIPARISNO") != null &&
                    gridView1.GetFocusedRowCellValue("IGNEKODU") != null &&
                    gridView1.GetFocusedRowCellValue("TARIH") != null 



                ) {

                txt_sipNot.Text = gridView1.GetFocusedRowCellValue("NOT").ToString();
                txt_Raporlayan.Text = gridView1.GetFocusedRowCellValue("RAPORLAYAN").ToString();
                txt_islem.Text = gridView1.GetFocusedRowCellValue("ISLEM").ToString();
                txt_adet.Text = gridView1.GetFocusedRowCellValue("ISLENENMIKTAR").ToString();
                txt_sipNo.Text = gridView1.GetFocusedRowCellValue("SIPARISNO").ToString();
                txt_sipIgneTur.Text = gridView1.GetFocusedRowCellValue("IGNEKODU").ToString();
                date_tarih.EditValue = gridView1.GetFocusedRowCellValue("TARIH");


            }
           



        }
    }
}
