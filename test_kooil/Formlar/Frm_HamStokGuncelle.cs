﻿using DevExpress.XtraEditors;
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
    public partial class Frm_HamStokGuncelle : Form
    {
        public Frm_HamStokGuncelle()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();
        void hamListele()
        {

            var hammadde = (from x in db.TBL_HAMMADDE
                            select new
                            {
                                x.ID,
                                x.KALINLIK,
                                x.GENISLIK,
                                x.OZELLIK,
                                x.MENSEI,
                                STOK = x.MIKTAR,
                                x.AKTIF
                            }).ToList().OrderBy(x => x.KALINLIK).Where(x => x.AKTIF==true);

            gridControl1.DataSource = hammadde;
            gridView1.Columns[0].Visible = false;
            gridView1.Columns[6].Visible = false;
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txt_secilenHam.Text = gridView1.GetFocusedRowCellValue("KALINLIK").ToString() + " x " + gridView1.GetFocusedRowCellValue("GENISLIK") + " " +
                                   gridView1.GetFocusedRowCellValue("MENSEI").ToString() + " " + gridView1.GetFocusedRowCellValue("OZELLIK").ToString();
        }

        private void Btn_Ekle_Click(object sender, EventArgs e)
        {
            var maddeID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            var madde = db.TBL_HAMMADDE.Find(maddeID);
            DialogResult siradakiAsamaSorgu = MessageBox.Show("Seçilen hammaddeye stok eklemek istediğinize emin misiniz ? ", "Stok Ekleme", MessageBoxButtons.YesNo);
            if (siradakiAsamaSorgu == DialogResult.Yes)
            {
                madde.MIKTAR += int.Parse(num_Miktar.Value.ToString());
                db.SaveChanges();
                XtraMessageBox.Show("Hammadde Stoğu Sisteme Eklendi. ", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hamListele();

            }
        }

        private void Btn_azalt_Click(object sender, EventArgs e)
        {
            var maddeID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            var madde = db.TBL_HAMMADDE.Find(maddeID);
            if (madde.MIKTAR - int.Parse(num_Miktar.Value.ToString()) >= 0)
            {


                DialogResult siradakiAsamaSorgu = MessageBox.Show("Seçilen hammaddeden stok azaltmak istediğinize emin misiniz ? ", "Stok Azaltma", MessageBoxButtons.YesNo);
                if (siradakiAsamaSorgu == DialogResult.Yes)
                {
                    madde.MIKTAR -= int.Parse(num_Miktar.Value.ToString());
                    db.SaveChanges();
                    XtraMessageBox.Show("Hammadde Stoğu Sistemden Azaltıldı. ", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hamListele();

                }
            }
            else {

                XtraMessageBox.Show("Girdiğiniz Sayıyı Kontrol Ediniz ! Stok Sıfırdan Küçük Olamaz.", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void Btn_Iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_HamStokGuncelle_Load(object sender, EventArgs e)
        {
            hamListele();
            txt_raporlayan.Text = Frm_Login.user.AdSoyad;
        }
    }
}
