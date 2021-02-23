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
                XtraMessageBox.Show("Pres Raporu Eklendi", "Islem Basarili", MessageBoxButtons.OK, MessageBoxIcon.Information);


                DialogResult siradakiAsamaSorgu = MessageBox.Show("Urunler Sonraki Asamaya Hazir mi ? ", "Asama Kontrol", MessageBoxButtons.YesNo);
                if (siradakiAsamaSorgu == DialogResult.Yes)
                {

                    //pres islemi tamamlandiysa siradaki asamaya gecsin
                    //TODO igne bicak platine gore eklencek degeri degistirmek lazim . 

                    var deger = db.TBL_SIPARIS.Find(preslenenUrun.SIPARISNO);
                if (deger.SIPARISASAMASI < 2) {  // bu asamadan bir kere rapor ciktiysa tekrar sayiyi yukseltmesin.
                    deger.SIPARISASAMASI += 1; //siparis asamasina 1 ekle mevcut bolumden bir sonrakine gitsin.


                }
                db.SaveChanges();

                }
                else
                {
                    // do nothing
                }
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
                                         x.SIPARISASAMASI

                                     }).ToList().OrderByDescending(x => x.SIPARISNOID).Where(x => x.SIPARISASAMASI == 1);

            lookUp_Siparis.Properties.ValueMember = "SIPARISNOID";
            lookUp_Siparis.Properties.DisplayMember = "IgneKodu";
            lookUp_Siparis.Properties.DataSource = preslencekUrunler;


        }

        private void Btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
