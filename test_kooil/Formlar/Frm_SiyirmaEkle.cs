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
    public partial class Frm_SiyirmaEkle : Form
    {
        public Frm_SiyirmaEkle()
        {
            InitializeComponent();
        }

        DB_kooil_testEntities db = new DB_kooil_testEntities();

        private void simpleButton1_Click(object sender, EventArgs e)
        {    //KAYDET BUTONU
            TBL_ARKASIYIR siyrilanUrun = new TBL_ARKASIYIR();

            siyrilanUrun.SIPARISNO = int.Parse(lookUp_Siparis.EditValue.ToString());
            var igneKodu = db.TBL_SIPARIS.Where(x => x.SIPARISNOID == siyrilanUrun.SIPARISNO).Select(x => x.TBL_IGNELER.IGNEKOD).FirstOrDefault();
            siyrilanUrun.IGNEKODU = igneKodu.ToString();
            siyrilanUrun.ISLENENMIKTAR = int.Parse(num_IslenenAdet.Value.ToString());
            siyrilanUrun.TARIH = date_BasimTarihi.DateTime;
            siyrilanUrun.NOT = text_Not.Text;
            siyrilanUrun.RAPORLAYAN = text_Raporlayan.Text;
            db.TBL_ARKASIYIR.Add(siyrilanUrun);
            db.SaveChanges();

            // ADDING TBL_RAPOR

            TBL_RAPOR rapor = new TBL_RAPOR();
            rapor.SIPARISNO = int.Parse(lookUp_Siparis.EditValue.ToString());
            rapor.IGNEKODU = igneKodu.ToString();
            rapor.ISLENENMIKTAR = int.Parse(num_IslenenAdet.Value.ToString());
            rapor.TARIH = date_BasimTarihi.DateTime;
            rapor.NOT = text_Not.Text;
            rapor.RAPORLAYAN = text_Raporlayan.Text;
            rapor.ISLEM = "Arka Sıyırma";

            db.TBL_RAPOR.Add(rapor);
            db.SaveChanges();



            XtraMessageBox.Show("Arka Siyirma Raporu Eklendi", "Islem Basarili", MessageBoxButtons.OK, MessageBoxIcon.Information);




            DialogResult siradakiAsamaSorgu = MessageBox.Show("Urunler Sonraki Asamaya Hazir mi ? ", "Asama Kontrol", MessageBoxButtons.YesNo);
            if (siradakiAsamaSorgu == DialogResult.Yes)
            {

                //pres islemi tamamlandiysa siradaki asamaya gecsin
                //TODO igne bicak platine gore eklencek degeri degistirmek lazim . 

                var deger = db.TBL_SIPARIS.Find(siyrilanUrun.SIPARISNO);
                deger.SIPARISASAMASI += 1; //siparis asamasina 1 ekle mevcut bolumden bir sonrakine gitsin.
                db.SaveChanges();

            }
            else
            {
                // do nothing
            }
            this.Close();

        }

        private void Frm_SiyirmaEkle_Load(object sender, EventArgs e)
        {
            var siyrilcakUrunler = (from x in db.TBL_SIPARIS
                                     select new
                                     {
                                         x.SIPARISNOID,
                                         IgneKodu = x.TBL_IGNELER.IGNEKOD,
                                         IstenilenMiktar = x.URUNADETI,
                                         x.SIPARISASAMASI

                                     }).ToList().OrderByDescending(x => x.SIPARISNOID).Where(x => x.SIPARISASAMASI == 2);

            lookUp_Siparis.Properties.ValueMember = "SIPARISNOID";
            lookUp_Siparis.Properties.DisplayMember = "IgneKodu";
            lookUp_Siparis.Properties.DataSource = siyrilcakUrunler;
        }
    }
}
