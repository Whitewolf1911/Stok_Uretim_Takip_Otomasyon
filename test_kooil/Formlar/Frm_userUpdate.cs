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
    public partial class Frm_userUpdate : Form
    {
        public Frm_userUpdate()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();

        void userListele() {
            try
            {
                var veriler = (from x in db.TBL_USERS
                               select new
                               {
                                   x.AdSoyad,
                                   x.password,
                                   x.userName,
                                   x.akfifSiparis,
                                   x.anasayfa,
                                   x.arkaSiyir,
                                   x.ayarlar,
                                   x.bileme,
                                   x.dilCakma,
                                   x.firmaEkle,
                                   x.firmalar,
                                   x.gecmisSevkiyat,
                                   x.hamRapor,
                                   x.hamRaporEkle,
                                   x.hamSil,
                                   x.hamStok,
                                   x.hamStokGuncelle,
                                   x.ID,
                                   x.isilIslem,
                                   x.islemRaporlari,
                                   x.kanalAcma,
                                   x.kanalBuyut,
                                   x.kontrol,
                                   x.polisaj1,
                                   x.polisaj2,
                                   x.pres,
                                   x.siparisDurumKontrol,
                                   x.tamamlananSiparis,
                                   x.temper,
                                   x.ucSiyirma,
                                   x.urunDuzenle,
                                   x.urunStok,
                                   x.urunTurleri,
                                   x.yeniHam,
                                   x.yeniPSevkiyat,
                                   x.yeniSiparis,
                                   x.yeniSipSevkiyat,
                                   x.yeniUrunEkle,
                                   x.yikama,
                                   x.yolKopyala,
                                   x.hataduzelt,
                                   x.iade,
                                   x.gerilimGiderme,
                                   x.ayakKesme,
                                   x.testere

                               }).ToList();

                gridControl1.DataSource = veriler;
                gridView1.Columns[0].AppearanceCell.BackColor = Color.LightGreen;
                gridView1.Columns[1].Visible = false;
                gridView1.Columns[2].Visible = false;
                gridView1.Columns[3].Visible = false;
                gridView1.Columns[4].Visible = false;
                gridView1.Columns[5].Visible = false;
                gridView1.Columns[6].Visible = false;
                gridView1.Columns[7].Visible = false;
                gridView1.Columns[8].Visible = false;
                gridView1.Columns[9].Visible = false;
                gridView1.Columns[10].Visible = false;
                gridView1.Columns[11].Visible = false;
                gridView1.Columns[12].Visible = false;
                gridView1.Columns[13].Visible = false;
                gridView1.Columns[14].Visible = false;
                gridView1.Columns[15].Visible = false;
                gridView1.Columns[16].Visible = false;
                gridView1.Columns[17].Visible = false;
                gridView1.Columns[18].Visible = false;
                gridView1.Columns[19].Visible = false;
                gridView1.Columns[20].Visible = false;
                gridView1.Columns[21].Visible = false;
                gridView1.Columns[22].Visible = false;
                gridView1.Columns[23].Visible = false;
                gridView1.Columns[24].Visible = false;
                gridView1.Columns[25].Visible = false;
                gridView1.Columns[26].Visible = false;
                gridView1.Columns[27].Visible = false;
                gridView1.Columns[28].Visible = false;
                gridView1.Columns[29].Visible = false;
                gridView1.Columns[30].Visible = false;
                gridView1.Columns[31].Visible = false;
                gridView1.Columns[32].Visible = false;
                gridView1.Columns[33].Visible = false;
                gridView1.Columns[34].Visible = false;
                gridView1.Columns[35].Visible = false;
                gridView1.Columns[36].Visible = false;
                gridView1.Columns[37].Visible = false;
                gridView1.Columns[38].Visible = false;
                gridView1.Columns[39].Visible = false;
                gridView1.Columns[40].Visible = false;
                gridView1.Columns[41].Visible = false;
                gridView1.Columns[42].Visible = false;
                gridView1.Columns[43].Visible = false;
                gridView1.Columns[44].Visible = false;
            }
            catch (Exception) { }


        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {      
            if (gridView1.GetFocusedRowCellValue("userName").ToString() == "admin")
            {
                txt_password.Properties.UseSystemPasswordChar = true;
            }
            else { 
                txt_password.Properties.UseSystemPasswordChar = false;
            }

            txt_AdSoyad.Text = gridView1.GetFocusedRowCellValue("AdSoyad").ToString();
            txt_password.Text = gridView1.GetFocusedRowCellValue("password").ToString();
            txt_userName.Text = gridView1.GetFocusedRowCellValue("userName").ToString();
            chAktifSiparisler.Checked = (bool)gridView1.GetFocusedRowCellValue("akfifSiparis");
            chAnasayfa.Checked = (bool)gridView1.GetFocusedRowCellValue("anasayfa");
            chArkaSiyirma.Checked = (bool)gridView1.GetFocusedRowCellValue("arkaSiyir");
            chAyarlar.Checked = (bool)gridView1.GetFocusedRowCellValue("ayarlar");
            chBileme.Checked = (bool)gridView1.GetFocusedRowCellValue("bileme");
            chDilCakma.Checked = (bool)gridView1.GetFocusedRowCellValue("dilCakma");
            chFirmaEkle.Checked = (bool)gridView1.GetFocusedRowCellValue("firmaEkle");
            chFirmalar.Checked = (bool)gridView1.GetFocusedRowCellValue("firmalar");
            chGecmisSevkiyat.Checked = (bool)gridView1.GetFocusedRowCellValue("gecmisSevkiyat");
            chHamKullanimRap.Checked = (bool)gridView1.GetFocusedRowCellValue("hamRapor");
            chHammaddeStok.Checked = (bool)gridView1.GetFocusedRowCellValue("hamStok");
            chHamRaporEkle.Checked = (bool)gridView1.GetFocusedRowCellValue("hamRaporEkle");
            chHamSil.Checked = (bool)gridView1.GetFocusedRowCellValue("hamSil");
            chHamStokGuncelle.Checked = (bool)gridView1.GetFocusedRowCellValue("hamStokGuncelle");
            chIsilIslem.Checked = (bool)gridView1.GetFocusedRowCellValue("isilIslem");
            chIslemRapor.Checked = (bool)gridView1.GetFocusedRowCellValue("islemRaporlari");
            chKanalAcma.Checked = (bool)gridView1.GetFocusedRowCellValue("kanalAcma");
            chKanalBuyutme.Checked = (bool)gridView1.GetFocusedRowCellValue("kanalBuyut");
            chKontrol.Checked = (bool)gridView1.GetFocusedRowCellValue("kontrol");
            chPeraSevkiyat.Checked = (bool)gridView1.GetFocusedRowCellValue("yeniPSevkiyat");
            chPolisaj1.Checked = (bool)gridView1.GetFocusedRowCellValue("polisaj1");
            chPolisaj2.Checked = (bool)gridView1.GetFocusedRowCellValue("polisaj2");
            chPres.Checked = (bool)gridView1.GetFocusedRowCellValue("pres");
            chSipDurumKontrol.Checked = (bool)gridView1.GetFocusedRowCellValue("siparisDurumKontrol");
            chSipSevkiyat.Checked = (bool)gridView1.GetFocusedRowCellValue("yeniSipSevkiyat");
            chTamamlananSip.Checked = (bool)gridView1.GetFocusedRowCellValue("tamamlananSiparis");
            chTemper.Checked = (bool)gridView1.GetFocusedRowCellValue("temper");
            chUcSiyirma.Checked = (bool)gridView1.GetFocusedRowCellValue("ucSiyirma");
            chUrunDuzenle.Checked = (bool)gridView1.GetFocusedRowCellValue("urunDuzenle");
            chUrunStok.Checked = (bool)gridView1.GetFocusedRowCellValue("urunStok");
            chUrunTur.Checked = (bool)gridView1.GetFocusedRowCellValue("urunTurleri");
            chYeniHamEkle.Checked = (bool)gridView1.GetFocusedRowCellValue("yeniHam");
            chYeniSiparis.Checked = (bool)gridView1.GetFocusedRowCellValue("yeniSiparis");
            chYeniUrunEkle.Checked = (bool)gridView1.GetFocusedRowCellValue("yeniUrunEkle");
            chYikama.Checked = (bool)gridView1.GetFocusedRowCellValue("yikama");
            chYolKopyala.Checked = (bool)gridView1.GetFocusedRowCellValue("yolKopyala");
            ch_iade.Checked = (bool)gridView1.GetFocusedRowCellValue("iade");
            chHataDuzelt.Checked = (bool)gridView1.GetFocusedRowCellValue("hataduzelt");
            ch_gerilim.Checked = (bool)gridView1.GetFocusedRowCellValue("gerilimGiderme");
            ch_ayakKesme.Checked = (bool)gridView1.GetFocusedRowCellValue("ayakKesme");
            ch_testere.Checked = (bool)gridView1.GetFocusedRowCellValue("testere");


        }

        private void Frm_userUpdate_Load(object sender, EventArgs e)
        {
            userListele();
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            { if (gridView1.GetFocusedRowCellValue("userName").ToString() != "admin")
                {
                    if (string.IsNullOrWhiteSpace(txt_userName.Text) || string.IsNullOrWhiteSpace(txt_AdSoyad.Text) || string.IsNullOrWhiteSpace(txt_password.Text))
                    {

                        XtraMessageBox.Show("Boş Alan Bırakmayınız. ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    else
                    {
                        int anyUser = db.TBL_USERS.Count(x => x.userName == txt_userName.Text);
                        

                            var userID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                            var new_user = db.TBL_USERS.Find(userID);

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
                            if (ch_gerilim.Checked) { new_user.gerilimGiderme = true; } else { new_user.gerilimGiderme = false; }
                            if (ch_ayakKesme.Checked) { new_user.ayakKesme = true; } else { new_user.ayakKesme = false; }
                            if (ch_testere.Checked) { new_user.testere = true; } else { new_user.testere = false; }





                        db.SaveChanges();
                            XtraMessageBox.Show("Kullanıcı Güncellendi. ", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        
                    }

                }
                else { 
                            XtraMessageBox.Show("Seçilen Kullanıda Değişiklik Yapamazsınız !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }

            catch (Exception)
            {
                XtraMessageBox.Show("Bir Hata Oluştu. Girdiğiniz Bilgileri Kontrol Edip Tekrar Deneyiniz. ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
