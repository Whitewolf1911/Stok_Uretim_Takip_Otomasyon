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
    public partial class Frm_YeniSiparis : Form
    {
        public Frm_YeniSiparis()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();

        void musteriListele()
        {
            var musteri = (from x in db.TBL_FIRMALAR
                           select new
                           {
                              Firmalar = x.FIRMAAD


                           }).ToList().OrderBy(x => x.Firmalar);

            lookUp_Musteri.Properties.ValueMember = "Firmalar";
            lookUp_Musteri.Properties.DisplayMember = "Firmalar";
            lookUp_Musteri.Properties.DataSource = musteri;


        }
        void urunListele()
        {
            var igneler = (from x in db.TBL_IGNELER
                           select new
                           {
                               x.ID,
                               x.TUR,
                               x.IGNEKOD,                                                                                          
                               x.FOTO
                           }
                           );
            gridControl1.DataSource = igneler.ToList();
            
            gridView1.Columns[1].AppearanceCell.BackColor = Color.Yellow;
            gridView1.Columns[2].AppearanceCell.BackColor = Color.LightGreen;

            gridView1.Columns[0].Visible = false;
            gridView1.Columns[3].Visible = false;

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void Frm_YeniSiparis_Load(object sender, EventArgs e)
        {
            urunListele();
            musteriListele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //EKLE BUTONU
            try
            {
                TBL_SIPARIS yeniSiparis = new TBL_SIPARIS();
                yeniSiparis.AKTIF = true;
                int ignetipi = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                yeniSiparis.IGNETIPI = ignetipi;
                yeniSiparis.MUSTERI = lookUp_Musteri.EditValue.ToString();
                yeniSiparis.URUNADETI = int.Parse(num_Adet.Value.ToString());
                yeniSiparis.NOTLAR = txt_Not.Text;
                yeniSiparis.SIPARISTARIHI = (DateTime?)date_SiparisTarih.EditValue;
                yeniSiparis.ISTENILENTARIH = (DateTime?)date_IstenilenTarih.EditValue;
                yeniSiparis.SIPARISASAMASI = 0;
                yeniSiparis.ARKASIYIRSAYI = 0;
                yeniSiparis.BILEMESAYI = 0;
                yeniSiparis.DILCAKMASAYI = 0;
                yeniSiparis.ISILISLEMSAYI = 0;
                yeniSiparis.KANALACMASAYI = 0;
                yeniSiparis.KANALBUYUTSAYI = 0;
                yeniSiparis.KONTROLSAYI = 0;
                yeniSiparis.POLI1SAYI = 0;
                yeniSiparis.POLI2SAYI = 0;
                yeniSiparis.PRESSAYI = 0;
                yeniSiparis.TEMPERSAYI = 0;
                yeniSiparis.UCSIYIRMASAYI = 0;
                yeniSiparis.YIKAMASAYI = 0;
                yeniSiparis.YOLKOPYASAYI = 0;

                //var igneFiyati = db.TBL_IGNELER.Where(x => x.ID == ignetipi).Select(x => x.ADETFIYATI).FirstOrDefault();
                //igneFiyati.ToString();
                //yeniSiparis.TOPLAMTUTAR = int.Parse(num_Adet.Value.ToString()) * Convert.ToDecimal(igneFiyati);
                db.TBL_SIPARIS.Add(yeniSiparis);
                db.SaveChanges();
                XtraMessageBox.Show("Yeni Sipariş Sisteme Eklendi. ", "Yeni Sipariş", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Hammadde Stok Kontrol 

                var igne = db.TBL_IGNELER.Find(ignetipi);
                int igneMadde = (int)igne.HAMMADDETIPI;
                var igneSarfiyat = igne.SARFIYATORAN;

                int sipMiktari = int.Parse(num_Adet.Value.ToString());

                var hammadde = db.TBL_HAMMADDE.Find(igneMadde);
                string hamMaddeAd = hammadde.KALINLIK.ToString() + " x " + hammadde.GENISLIK.ToString() + " " + hammadde.OZELLIK + " " + hammadde.MENSEI; 
                int hamStok = (int)hammadde.MIKTAR - 10; // 10 kg azaltim.

                var gerekliMiktar = igneSarfiyat * sipMiktari / 1000; // 1000 -> grami kgye cevirme 

                if (gerekliMiktar > hamStok) {

                    int eksikMiktar = (int)(gerekliMiktar - hamStok);
                    int bonusMiktar = eksikMiktar / 100 * 10; // %10 fazlalik
                    int gereken = eksikMiktar + bonusMiktar;

                    XtraMessageBox.Show("Seçtiğiniz Sipariş İçin Yeterli Hammaddeniz Bulunmamaktadır. " + hamMaddeAd + " Hammaddesinden En Az " + gereken +" KG Sipariş Ediniz !" , "Dikkat !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                this.Close();
            }
            catch {
                XtraMessageBox.Show("Lütfen Boş Alan Bırakmayınız. ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Btn_Vazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("IGNEKOD") != null) {

                txt_urunCesit.Text = gridView1.GetFocusedRowCellValue("IGNEKOD").ToString();
            }


            if (gridView1.GetFocusedRowCellValue("FOTO") != null)
            {
                picBoxUrun.Image = Frm_IgneTurleri.ImageFromByteArray((byte[])gridView1.GetFocusedRowCellValue("FOTO"));
            }
            if (gridView1.GetFocusedRowCellValue("FOTO") == null)
            {
                picBoxUrun.Image = null;
            }
        }
    }
}
