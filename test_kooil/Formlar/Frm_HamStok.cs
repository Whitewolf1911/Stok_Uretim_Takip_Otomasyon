﻿using DevExpress.XtraEditors;
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
    public partial class Frm_HamStok : Form
    {
        public Frm_HamStok()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();
        Frm_YeniHamEkle frmYeniHam;

        void listele() {

            var degerler = (from x in db.TBL_HAMMADDE
                            select new
                            {
                                x.ID,
                                Kalınlık = x.KALINLIK,
                                Genişlik = x.GENISLIK,
                                Özellik = x.OZELLIK,
                                Menşei  = x.MENSEI,
                                Kilogram = x.MIKTAR,
                                Konum = x.KONUM

                            }).ToList().OrderBy(x => x.Kalınlık);
            gridControl1.DataSource = degerler;
            gridView1.Columns[0].Visible = false;
            gridView1.Columns[1].AppearanceCell.BackColor = Color.LightGreen;
            gridView1.Columns[2].AppearanceCell.BackColor = Color.Aquamarine;
            gridView1.Columns[3].AppearanceCell.BackColor = Color.Orange;
            gridView1.Columns[4].AppearanceCell.BackColor = Color.Cyan;
            gridView1.Columns[5].AppearanceCell.BackColor = Color.Yellow;

        }
        private void Btn_yeniHamEkle_Click(object sender, EventArgs e)
        {
            frmYeniHam = new Frm_YeniHamEkle();
            frmYeniHam.Show();
        }

        private void Btn_hamSil_Click(object sender, EventArgs e)
        {
            DialogResult siradakiAsamaSorgu = MessageBox.Show("Bu işlem seçilen hammaddeyi sistemden tamamen silecek. Devam etmek istediğinize emin misiniz ? ", "Hammadde Silme", MessageBoxButtons.YesNo);
            if (siradakiAsamaSorgu == DialogResult.Yes)
            {
                int silinecekMadde = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                var deger = db.TBL_HAMMADDE.Find(silinecekMadde);
                db.TBL_HAMMADDE.Remove(deger);
                db.SaveChanges();
                XtraMessageBox.Show("Hammadde Sistemden Silindi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            else { }
        }

        private void Btn_Yenile_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void Frm_HamStok_Load(object sender, EventArgs e)
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
        private void Btn_yazdir_Click(object sender, EventArgs e)
        {
            ShowGridPreview(gridControl1);
            PrintGrid(gridControl1);
        }
    }
}
