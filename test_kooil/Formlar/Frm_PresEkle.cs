using DevExpress.XtraEditors;
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

                TBL_PRES preslenenUrun = new TBL_PRES();
                preslenenUrun.SIPARISNO = int.Parse(lookUp_Siparis.EditValue.ToString());
                var igneKodu = db.TBL_SIPARIS.Where(x => x.SIPARISNOID == preslenenUrun.SIPARISNO).Select(x => x.TBL_IGNELER.IGNEKOD).FirstOrDefault();
                preslenenUrun.IGNEKODU = igneKodu.ToString();
                preslenenUrun.ISLENENMIKTAR = int.Parse(num_IslenenAdet.Value.ToString());
                preslenenUrun.TARIH = date_BasimTarihi.DateTime;
                preslenenUrun.NOT = text_Not.Text;
                preslenenUrun.RAPORLAYAN = text_Raporlayan.Text;
                db.TBL_PRES.Add(preslenenUrun);
                db.SaveChanges();

            // ADDING TO TBL_RAPORLAR

            TBL_RAPOR rapor = new TBL_RAPOR();
            rapor.SIPARISNO = int.Parse(lookUp_Siparis.EditValue.ToString());
            rapor.IGNEKODU = igneKodu.ToString();
            rapor.ISLENENMIKTAR = int.Parse(num_IslenenAdet.Value.ToString());
            rapor.TARIH = date_BasimTarihi.DateTime;
            rapor.NOT = text_Not.Text;
            rapor.RAPORLAYAN = text_Raporlayan.Text;
            rapor.ISLEM = "Pres";
            db.TBL_RAPOR.Add(rapor);
            db.SaveChanges();


            XtraMessageBox.Show("Pres Raporu Eklendi", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var deger = db.TBL_SIPARIS.Find(preslenenUrun.SIPARISNO);
                deger.PRESSAYI += int.Parse(num_IslenenAdet.Value.ToString());

                if (deger.SIPARISASAMASI < 1) {  
                    deger.SIPARISASAMASI = 1; //siparis asamasina 1 ekle mevcut bolumden bir sonrakine gitsin.

                }
                db.SaveChanges();
             
                this.Close();
            
            

        }

        private void Frm_PresEkle_Load(object sender, EventArgs e)
        {
            var preslencekUrunler = (from x in db.TBL_SIPARIS
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
            lookUp_Siparis.Properties.DataSource = preslencekUrunler;
            lookUp_Siparis.Properties.PopulateColumns(); // to hide unwanted columns you need to populate columns manually first.

            lookUp_Siparis.Properties.Columns[3].Visible = false;
            lookUp_Siparis.Properties.Columns[4].Visible = false;


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
