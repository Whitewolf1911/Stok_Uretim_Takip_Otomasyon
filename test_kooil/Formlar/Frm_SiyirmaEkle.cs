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
            rapor.URUNTUR = lookUp_Siparis.GetColumnValue("Tur").ToString();
            rapor.ISLEM = "Arka Sıyırma";

            db.TBL_RAPOR.Add(rapor);
            db.SaveChanges();



            XtraMessageBox.Show("Arka Sıyırma Raporu Eklendi", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);


            var deger = db.TBL_SIPARIS.Find(siyrilanUrun.SIPARISNO);
            deger.ARKASIYIRSAYI += int.Parse(num_IslenenAdet.Value.ToString());

            if (deger.SIPARISASAMASI < 2)
            {
                deger.SIPARISASAMASI = 2; //siparis asamasini ayarla
            }
               
            db.SaveChanges();
  
            this.Close();

        }

        private void Frm_SiyirmaEkle_Load(object sender, EventArgs e)
        {
            var siyrilcakUrunler = (from x in db.TBL_SIPARIS
                                     select new
                                     {
                                         x.SIPARISNOID,
                                         Tur = x.TBL_IGNELER.TUR,
                                         IgneKodu = x.TBL_IGNELER.IGNEKOD,
                                         IstenilenMiktar = x.URUNADETI,
                                         x.SIPARISASAMASI,
                                         x.AKTIF

                                     }).ToList().OrderByDescending(x => x.SIPARISNOID).Where(x => x.AKTIF == true);

            lookUp_Siparis.Properties.ValueMember = "SIPARISNOID";
            lookUp_Siparis.Properties.DisplayMember = "IgneKodu";
            lookUp_Siparis.Properties.DataSource = siyrilcakUrunler;

            lookUp_Siparis.Properties.PopulateColumns(); // to hide unwanted columns you need to populate columns manually first.

            lookUp_Siparis.Properties.Columns[5].Visible = false;
            lookUp_Siparis.Properties.Columns[4].Visible = false;
            text_Raporlayan.Text = Frm_Login.user.AdSoyad;
        }
    }
}
