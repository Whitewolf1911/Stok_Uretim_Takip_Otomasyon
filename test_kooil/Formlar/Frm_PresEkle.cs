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
    public partial class Frm_PresEkle : Form
    {
        public Frm_PresEkle()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();        
        private void simpleButton1_Click(object sender, EventArgs e)
        { // EKLE BUTONU

            //ADDING TO TBL_PRES
            try
            {
                if (lookUp_Siparis.EditValue != null && combo_ham.EditValue != null && date_BasimTarihi.EditValue != null)
                {
                    TBL_PRES preslenenUrun = new TBL_PRES();
                    preslenenUrun.SIPARISNO = int.Parse(lookUp_Siparis.EditValue.ToString());
                    var igneKodu = db.TBL_SIPARIS.Where(x => x.SIPARISNOID == preslenenUrun.SIPARISNO).Select(x => x.TBL_IGNELER.IGNEKOD).FirstOrDefault();
                    preslenenUrun.IGNEKODU = igneKodu.ToString();
                    preslenenUrun.PARTINO = int.Parse(lookUp_Siparis.GetColumnValue("PartiNo").ToString());
                    preslenenUrun.ISLENENMIKTAR = int.Parse(num_IslenenAdet.Value.ToString());
                    preslenenUrun.HAMMADDE = combo_ham.EditValue.ToString();
                    preslenenUrun.TARIH = date_BasimTarihi.DateTime;
                    preslenenUrun.NOT = text_Not.Text;
                    preslenenUrun.RAPORLAYAN = text_Raporlayan.Text;
                    preslenenUrun.URUNTUR = lookUp_Siparis.GetColumnValue("Tur").ToString();
                    db.TBL_PRES.Add(preslenenUrun);
                    db.SaveChanges();

                    // ADDING TO TBL_RAPORLAR

                    TBL_RAPOR rapor = new TBL_RAPOR();
                    rapor.SIPARISNO = int.Parse(lookUp_Siparis.EditValue.ToString());
                    rapor.PARTINO = int.Parse(lookUp_Siparis.GetColumnValue("PartiNo").ToString());
                    rapor.IGNEKODU = igneKodu.ToString();
                    rapor.ISLENENMIKTAR = int.Parse(num_IslenenAdet.Value.ToString());
                    rapor.TARIH = date_BasimTarihi.DateTime;
                    rapor.NOT = text_Not.Text;
                    rapor.RAPORLAYAN = text_Raporlayan.Text;
                    rapor.URUNTUR = lookUp_Siparis.GetColumnValue("Tur").ToString();
                    rapor.ISLEM = "Pres";
                    db.TBL_RAPOR.Add(rapor);
                    db.SaveChanges();


                    XtraMessageBox.Show("Pres Raporu Eklendi", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var deger = db.TBL_SIPARIS.Find(preslenenUrun.SIPARISNO);
                    deger.PRESSAYI += int.Parse(num_IslenenAdet.Value.ToString());

                    if (deger.SIPARISASAMASI < 1)
                    {
                        deger.SIPARISASAMASI = 1; //siparis asamasina 1 ekle mevcut bolumden bir sonrakine gitsin.

                    }
                    db.SaveChanges();

                    this.Close();

                }
                else
                {
                    if (lookUp_Siparis.EditValue == null)
                    {
                        XtraMessageBox.Show("Sipariş Seçiniz ! ", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (combo_ham.EditValue == null)
                    {
                        XtraMessageBox.Show("Hammadde Seçiniz ! ", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (date_BasimTarihi.EditValue == null)
                    {
                        XtraMessageBox.Show("Tarih Seçiniz ! ", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }
            }
            catch (Exception) { 
                        XtraMessageBox.Show("Bir Hata Oluştu. Girdiğiniz Bilgileri Kontrol Ediniz Ve Tekrar Deneyiniz ! ", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            

        }

        private void Frm_PresEkle_Load(object sender, EventArgs e)
        {
            try
            {
                var preslencekUrunler = (from x in db.TBL_SIPARIS
                                         select new
                                         {
                                             SiparişNo = x.SIPARISNOID,
                                             PartiNo = x.PARTINO,
                                             Tur = x.TBL_IGNELER.TUR,
                                             ÜrünKodu = x.TBL_IGNELER.IGNEKOD,
                                             IstenilenMiktar = x.URUNADETI,
                                             x.SIPARISASAMASI,
                                             x.AKTIF

                                         }).ToList().OrderByDescending(x => x.SiparişNo).Where(x => x.AKTIF == true);

                lookUp_Siparis.Properties.ValueMember = "SiparişNo";
                lookUp_Siparis.Properties.DisplayMember = "ÜrünKodu";
                lookUp_Siparis.Properties.DataSource = preslencekUrunler;
                lookUp_Siparis.Properties.PopulateColumns(); // to hide unwanted columns you need to populate columns manually first.
                lookUp_Siparis.Properties.BestFit();
                //lookUp_Siparis.Properties.Columns[1].Visible = false;
                lookUp_Siparis.Properties.Columns[5].Visible = false;
                lookUp_Siparis.Properties.Columns[6].Visible = false;
                text_Raporlayan.Text = Frm_Login.user.AdSoyad;
            }
            catch (Exception) { }


        }

        private void Btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureEdit5_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void date_BasimTarihi_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit4_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void text_Not_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void text_Raporlayan_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void num_IslenenAdet_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void lookUp_Siparis_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
