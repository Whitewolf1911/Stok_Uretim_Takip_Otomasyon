﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_kooil.Entity;
using test_kooil.Formlar;


namespace test_kooil.Formlar
{
    public partial class Frm_Pres : Form
    {
        public Frm_Pres()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();
        Frm_PresEkle ekleEkrani;
        Frm_PresRaporlari presRapor;
        void listele() {
            try
            {
                var preslencekUrunler = (from x in db.TBL_SIPARIS
                                         select new
                                         {
                                             SiparişNo = x.SIPARISNOID,
                                             PartiNo = x.PARTINO,
                                             Tür = x.TBL_IGNELER.TUR,
                                             ÜrünKodu = x.TBL_IGNELER.IGNEKOD,
                                             SiparişMiktarı = x.URUNADETI,
                                             Preslenen = x.PRESSAYI,
                                             Not = x.NOTLAR,
                                             x.AKTIF

                                         }).ToList().OrderByDescending(x => x.SiparişNo);

                gridControl1.DataSource = preslencekUrunler.Where(x => x.AKTIF == true);

                gridView1.Columns[1].AppearanceCell.BackColor = Color.LightGreen;
                gridView1.Columns[2].AppearanceCell.BackColor = Color.Aquamarine;
                gridView1.Columns[3].AppearanceCell.BackColor = Color.Orange;
                gridView1.Columns[4].AppearanceCell.BackColor = Color.Cyan;
                gridView1.Columns[7].Visible = false;
                gridView1.BestFitColumns();

            }
            catch (Exception) { }

        }
        private void Frm_Pres_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void Btn_PresEkle_Click(object sender, EventArgs e)
        {
            if(ekleEkrani == null || ekleEkrani.IsDisposed)
            {
                ekleEkrani = new Frm_PresEkle();
                ekleEkrani.Show();
            }

        }

        private void Btn_PresRapor_Click(object sender, EventArgs e)
        {
            if (presRapor == null || presRapor.IsDisposed)
            {
                presRapor = new Frm_PresRaporlari();
                presRapor.MdiParent = this.ParentForm;
                presRapor.Show();
            }
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("ÜrünKodu") != null &&
           gridView1.GetFocusedRowCellValue("Not") != null)
            {

                txt_sipIgneTur.Text = gridView1.GetFocusedRowCellValue("ÜrünKodu").ToString();
                txt_sipNot.Text = gridView1.GetFocusedRowCellValue("Not").ToString();
            }
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
