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
    public partial class Frm_TemperEkle : Form
    {
        public Frm_TemperEkle()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();
        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            TBL_TEMPER islenenUrun = new TBL_TEMPER();
            islenenUrun.SIPARISNO = int.Parse(lookUp_Siparis.EditValue.ToString());
            var igneKodu = db.TBL_SIPARIS.Where(x => x.SIPARISNOID == islenenUrun.SIPARISNO).Select(x => x.TBL_IGNELER.IGNEKOD).FirstOrDefault();
            islenenUrun.IGNEKODU = igneKodu.ToString();
            islenenUrun.ISLENENMIKTAR = int.Parse(num_IslenenAdet.Value.ToString());
            islenenUrun.TARIH = date_BasimTarihi.DateTime;
            islenenUrun.NOT = text_Not.Text;
            islenenUrun.RAPORLAYAN = text_Raporlayan.Text;
            db.TBL_TEMPER.Add(islenenUrun);
            db.SaveChanges();

            // ADDING TO TBL_RAPORLAR

            TBL_RAPOR rapor = new TBL_RAPOR();
            rapor.SIPARISNO = int.Parse(lookUp_Siparis.EditValue.ToString());
            rapor.IGNEKODU = igneKodu.ToString();
            rapor.ISLENENMIKTAR = int.Parse(num_IslenenAdet.Value.ToString());
            rapor.TARIH = date_BasimTarihi.DateTime;
            rapor.NOT = text_Not.Text;
            rapor.RAPORLAYAN = text_Raporlayan.Text;
            rapor.ISLEM = "Temper";
            db.TBL_RAPOR.Add(rapor);
            db.SaveChanges();

            XtraMessageBox.Show("Temper Raporu Eklendi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //TODO bu sorguya gerek kaldi mi ???
            DialogResult siradakiAsamaSorgu = MessageBox.Show("Urunler Sonraki Asamaya Hazir mi ? ", "Asama Kontrol", MessageBoxButtons.YesNo);
            if (siradakiAsamaSorgu == DialogResult.Yes)
            {

                //pres islemi tamamlandiysa siradaki asamaya gecsin
                //TODO igne bicak platine gore eklencek degeri degistirmek lazim . 

                var deger = db.TBL_SIPARIS.Find(islenenUrun.SIPARISNO);
                if (deger.SIPARISASAMASI < 11)
                {  // bu asamadan bir kere rapor ciktiysa tekrar sayiyi yukseltmesin.
                    deger.SIPARISASAMASI =11; //siparis asamasini guncelle 


                    // siparis asamasina eklemek yerine direk deger atarsan karisikligin onune geceriz
                }
                db.SaveChanges();

            }
            else
            {
                // do nothing
            }
            this.Close();
        }

        private void Btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_TemperEkle_Load(object sender, EventArgs e)
        {
            var islenecekUrunler = (from x in db.TBL_SIPARIS
                                    select new
                                    {
                                        x.SIPARISNOID,
                                        IgneKodu = x.TBL_IGNELER.IGNEKOD,
                                        IstenilenMiktar = x.URUNADETI,
                                        x.SIPARISASAMASI,
                                        x.AKTIF

                                    }).ToList().OrderByDescending(x => x.SIPARISNOID).Where(x => x.AKTIF == true);

            lookUp_Siparis.Properties.ValueMember = "SIPARISNOID";
            lookUp_Siparis.Properties.DisplayMember = "IgneKodu";
            lookUp_Siparis.Properties.DataSource = islenecekUrunler;

            lookUp_Siparis.Properties.PopulateColumns(); // to hide unwanted columns you need to populate columns manually first.

            lookUp_Siparis.Properties.Columns[3].Visible = false;
            lookUp_Siparis.Properties.Columns[4].Visible = false;
        }
    }
}
