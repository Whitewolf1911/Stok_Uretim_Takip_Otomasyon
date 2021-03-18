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
    public partial class Frm_KontrolEkle : Form
    {
        public Frm_KontrolEkle()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();
        private void Frm_KontrolEkle_Load(object sender, EventArgs e)
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

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            TBL_KONTROL islenenUrun = new TBL_KONTROL();
            islenenUrun.SIPARISNO = int.Parse(lookUp_Siparis.EditValue.ToString());
            var igneKodu = db.TBL_SIPARIS.Where(x => x.SIPARISNOID == islenenUrun.SIPARISNO).Select(x => x.TBL_IGNELER.IGNEKOD).FirstOrDefault().ToString();
            islenenUrun.IGNEKODU = igneKodu;
            islenenUrun.ISLENENMIKTAR = int.Parse(num_IslenenAdet.Value.ToString());
            islenenUrun.TARIH = date_BasimTarihi.DateTime;
            islenenUrun.NOT = text_Not.Text;
            islenenUrun.RAPORLAYAN = text_Raporlayan.Text;
            db.TBL_KONTROL.Add(islenenUrun);

            var deger = db.TBL_SIPARIS.Find(islenenUrun.SIPARISNO);
            deger.KONTROLSAYI += int.Parse(num_IslenenAdet.Value.ToString());

            var igneID = db.TBL_SIPARIS.Where(x => x.SIPARISNOID == islenenUrun.SIPARISNO).Select(x => x.TBL_IGNELER.ID).FirstOrDefault();
            var urunStok = db.TBL_IGNELER.Find(igneID);


            urunStok.STOK += int.Parse(num_IslenenAdet.Value.ToString());

            if (deger.SIPARISASAMASI < 14)
            {  // bu asamadan bir kere rapor ciktiysa tekrar sayiyi yukseltmesin.
                deger.SIPARISASAMASI = 14; //siparis asamasini guncelle 


                // siparis asamasina eklemek yerine direk deger atarsan karisikligin onune geceriz
            }
            db.SaveChanges();

            // ADDING TO TBL_RAPORLAR

            TBL_RAPOR rapor = new TBL_RAPOR();
            rapor.SIPARISNO = int.Parse(lookUp_Siparis.EditValue.ToString());
            rapor.IGNEKODU = igneKodu.ToString();
            rapor.ISLENENMIKTAR = int.Parse(num_IslenenAdet.Value.ToString());
            rapor.TARIH = date_BasimTarihi.DateTime;
            rapor.NOT = text_Not.Text;
            rapor.RAPORLAYAN = text_Raporlayan.Text;
            rapor.ISLEM = "Kontrol";
            db.TBL_RAPOR.Add(rapor);
            db.SaveChanges();

            XtraMessageBox.Show("Kontrol Raporu Eklendi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            this.Close();

        }

        private void Btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
