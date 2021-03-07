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

namespace test_kooil.Formlar
{
    public partial class Frm_Kontrol : Form
    {
        public Frm_Kontrol()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();
        Frm_KontrolEkle frmEkle;
        Frm_KontrolRapor frmRapor;
        void listele()
        {
            var islenecekUrunler = (from x in db.TBL_SIPARIS
                                    select new
                                    {
                                        SiparisNo = x.SIPARISNOID,
                                        x.TBL_IGNELER.TUR,
                                        x.TBL_IGNELER.IGNEKOD,
                                        IstenilenMiktar = x.URUNADETI,
                                        x.NOTLAR,
                                        x.AKTIF

                                    }).ToList().OrderByDescending(x => x.SiparisNo);

            gridControl1.DataSource = islenecekUrunler.Where(x => x.AKTIF == true);
            gridView1.Columns[1].AppearanceCell.BackColor = Color.LightGreen;
            gridView1.Columns[2].AppearanceCell.BackColor = Color.Aquamarine;
            gridView1.Columns[3].AppearanceCell.BackColor = Color.Orange;
            gridView1.Columns[4].AppearanceCell.BackColor = Color.Cyan;
            gridView1.Columns[5].Visible = false;

        }
        private void Btn_SiyirmaEkle_Click(object sender, EventArgs e)
        {
            frmEkle = new Frm_KontrolEkle();
            frmEkle.Show();
        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void Btn_Raporlar_Click(object sender, EventArgs e)
        {
            if (frmRapor == null || frmRapor.IsDisposed)
            {
                frmRapor = new Frm_KontrolRapor();
                frmRapor.MdiParent = this.ParentForm;
                frmRapor.Show();
            }
        }

        private void Frm_Kontrol_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("IGNEKOD") != null &&
               gridView1.GetFocusedRowCellValue("NOTLAR") != null)
            {

                txt_sipIgneTur.Text = gridView1.GetFocusedRowCellValue("IGNEKOD").ToString();
                txt_sipNot.Text = gridView1.GetFocusedRowCellValue("NOTLAR").ToString();
            }
        }
    }
}
