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
    public partial class Frm_YeniKullanici : Form
    {
        public Frm_YeniKullanici()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            try 
            {
                if (string.IsNullOrWhiteSpace(txt_userName.Text) || string.IsNullOrWhiteSpace(txt_AdSoyad.Text) || string.IsNullOrWhiteSpace(txt_password.Text)) {

                    XtraMessageBox.Show("Boş Alan Bırakmayınız. ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    int anyUser = db.TBL_USERS.Count(x => x.userName == txt_userName.Text);
                    if (anyUser < 1)
                    {


                        TBL_USERS new_user = new TBL_USERS();
                        new_user.AdSoyad = txt_AdSoyad.Text;
                        new_user.userName = txt_userName.Text.Trim();
                        new_user.password = txt_password.Text.Trim();

                        //YETKILER
                        if (chAktifSiparisler.Checked) { new_user.akfifSiparis = true; } else { new_user.akfifSiparis = false; }
                        if (chAnasayfa.Checked) { new_user.anasayfa = true; } else { new_user.anasayfa = false; }
                        if (chYeniSiparis.Checked) { new_user.yeniSiparis = true; } else { new_user.yeniSiparis = false; }
                        if (chSipDurumKontrol.Checked) { new_user.siparisDurumKontrol = true; } else { new_user.siparisDurumKontrol = false; }
                        if (chTamamlananSip.Checked) { new_user.tamamlananSiparis = true; } else { new_user.tamamlananSiparis = false; }
                        if (chIslemRapor.Checked) { new_user.islemRaporlari = true; } else { new_user.islemRaporlari = false; }
                        if (chUrunTur.Checked) { new_user.urunTurleri = true; } else { new_user.urunTurleri = false; }
                        if (chYeniUrunEkle.Checked) { new_user.yeniUrunEkle = true; } else { new_user.yeniUrunEkle = false; }
                        if (chUrunDuzenle.Checked) { new_user.urunDuzenle = true; } else { new_user.urunDuzenle = false; }
                        if (chUrunStok.Checked) { new_user.urunStok = true; } else { new_user.urunStok = false; }
                        if (chHammaddeStok.Checked) { new_user.hamStok = true; } else { new_user.hamStok = false; }
                        if (chYeniHamEkle.Checked) { new_user.yeniHam = true; } else { new_user.yeniHam = false; }
                        if (chHamSil.Checked) { new_user.hamSil = true; } else { new_user.hamSil = false; }
                        if (chHamStokGuncelle.Checked) { new_user.hamStokGuncelle = true; } else { new_user.hamStokGuncelle = false; }
                        if (chHamKullanimRap.Checked) { new_user.hamRapor = true; } else { new_user.hamRapor = false; }
                        if (chHamRaporEkle.Checked) { new_user.hamRaporEkle = true; } else { new_user.hamRaporEkle = false; }
                        if (chFirmalar.Checked) { new_user.firmalar = true; } else { new_user.firmalar = false; }
                        if (chFirmaEkle.Checked) { new_user.firmaEkle = true; } else { new_user.firmaEkle = false; }
                        if (chPeraSevkiyat.Checked) { new_user.yeniPSevkiyat = true; } else { new_user.yeniPSevkiyat = false; }
                        if (chGecmisSevkiyat.Checked) { new_user.gecmisSevkiyat = true; } else { new_user.gecmisSevkiyat = false; }
                        if (chSipSevkiyat.Checked) { new_user.yeniSipSevkiyat = true; } else { new_user.yeniSipSevkiyat = false; }
                        if (chAyarlar.Checked) { new_user.ayarlar = true; } else { new_user.ayarlar = false; }
                        if (chPres.Checked) { new_user.pres = true; } else { new_user.pres = false; }
                        if (chArkaSiyirma.Checked) { new_user.arkaSiyir = true; } else { new_user.arkaSiyir = false; }
                        if (chYolKopyala.Checked) { new_user.yolKopyala = true; } else { new_user.yolKopyala = false; }
                        if (chUcSiyirma.Checked) { new_user.ucSiyirma = true; } else { new_user.ucSiyirma = false; }
                        if (chKanalAcma.Checked) { new_user.kanalAcma = true; } else { new_user.kanalAcma = false; }
                        if (chKanalBuyutme.Checked) { new_user.kanalBuyut = true; } else { new_user.kanalBuyut = false; }
                        if (chPolisaj1.Checked) { new_user.polisaj1 = true; } else { new_user.polisaj1 = false; }
                        if (chPolisaj2.Checked) { new_user.polisaj2 = true; } else { new_user.polisaj2 = false; }
                        if (chDilCakma.Checked) { new_user.dilCakma = true; } else { new_user.dilCakma = false; }
                        if (chIsilIslem.Checked) { new_user.isilIslem = true; } else { new_user.isilIslem = false; }
                        if (chTemper.Checked) { new_user.temper = true; } else { new_user.temper = false; }
                        if (chYikama.Checked) { new_user.yikama = true; } else { new_user.yikama = false; }
                        if (chBileme.Checked) { new_user.bileme = true; } else { new_user.bileme = false; }
                        if (chKontrol.Checked) { new_user.kontrol = true; } else { new_user.kontrol = false; }
                        if (chHataDuzelt.Checked) { new_user.hataduzelt = true; } else { new_user.hataduzelt = false; }
                        if (ch_iade.Checked) { new_user.iade = true; } else { new_user.iade = false; }


                        db.TBL_USERS.Add(new_user);
                        db.SaveChanges();
                        XtraMessageBox.Show("Yeni Kullanıcı Sisteme Eklendi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else { 
                    
                        XtraMessageBox.Show("Girdiğiniz Kullanıcı Adı Kullanılmaktadır. Kullanıcı Adını Değiştiriz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }


            }

            catch (Exception)
            {
                XtraMessageBox.Show("Bir Hata Oluştu. Girdiğiniz Bilgileri Kontrol Edip Tekrar Deneyiniz. ","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error );

            }

        }
    }
}
