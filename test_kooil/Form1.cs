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
using test_kooil.Formlar;
namespace test_kooil
{
    public partial class Form1 : Form
    {
        private Frm_Login _login;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(Frm_Login login)
        {
            InitializeComponent();
            _login = login;
        }

        Frm_IgneTurleri frmIgneTur;
        Frm_YeniSiparis frmYeniSiparis;
        Frm_YeniIgneEkle frmIgneEkle;
        Frm_Pres frmPres;
        Frm_ArkaSiyirma frmArkaSiyir;
        Frm_SiparisKontrol frmSiparisKontrol;
        Frm_RaporOzet frmRapor;
        Frm_YolKopyala frmKopyala;
        Frm_UcSiyirma frmUcSiyir;
        Frm_KanalAcma frmKanalAcma;
        Frm_KanalBuyutme frmkanalbuyut;
        Frm_Polisaj1 frmpoli1;
        Frm_DilCakma frmDilCak;
        Frm_Polisaj2 frmPolisaj2;
        Frm_IsilIslem frmIsilIslem;
        Frm_Temper frmTemper;
        Frm_Yikama frmYikama;
        Frm_Bileme frmBileme;
        Frm_Kontrol frmKontrol;
        Frm_TamamlananSiparisler frmTamamSiparis;
        Frm_SiparisDurumKontrol frmSipDkntrol;
        Frm_HamStok frmHamStok;
        Frm_HamRaporEkle frmHamRaporEkle;
        Frm_HamRaporlari frmHamRapor;
        Frm_HamStokGuncelle frmHamstokGuncelle;
        Frm_UrunStok frmUrunStok;
        Frm_FirmaEkle frmFirmaEkle;
        Frm_Firmalar frmFirmalar;
        Frm_YeniSevkiyat frmYeniSevkiyat;
        Frm_SiparisSevkiyat frmSipSevkiyat;
        Frm_GecmisSevkiyat frmGecmisSevk;
        Frm_UrunDuzenle frmUrunDuzenle;
        Frm_AnaSayfa frmAnaSayfa;
        Frm_Ayarlar frmAyarlar;
        Frm_HataDuzeltme frmHataDuzelt;
        Frm_Iade frmIade;


        void InitializeButtons() {

            if (Frm_Login.user.akfifSiparis == true)
            {
                Btn_SiparisDurum.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else { Btn_SiparisDurum.Visibility = DevExpress.XtraBars.BarItemVisibility.Never; }

            if (Frm_Login.user.arkaSiyir == true)
            {
                Btn_arkaSiyirma.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else { Btn_arkaSiyirma.Visibility = DevExpress.XtraBars.BarItemVisibility.Never; }

            if (Frm_Login.user.ayarlar == true)
            {
                Btn_ayarlar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else { Btn_ayarlar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never; }

            if (Frm_Login.user.bileme == true)
            {
                Btn_Bileme.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else { Btn_Bileme.Visibility = DevExpress.XtraBars.BarItemVisibility.Never; }

            if (Frm_Login.user.dilCakma == true)
            {
                Btn_DilCakma.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else { Btn_DilCakma.Visibility = DevExpress.XtraBars.BarItemVisibility.Never; }

            if (Frm_Login.user.firmaEkle == true)
            {
                Btn_FirmaEkle.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else { Btn_FirmaEkle.Visibility = DevExpress.XtraBars.BarItemVisibility.Never; }

            if (Frm_Login.user.firmalar == true)
            {
                Btn_Firmalar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else { Btn_Firmalar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never; }

            if (Frm_Login.user.gecmisSevkiyat == true)
            {
                Btn_GecmisSevkiyat.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else { Btn_GecmisSevkiyat.Visibility = DevExpress.XtraBars.BarItemVisibility.Never; }

            if (Frm_Login.user.hamRapor == true)
            {
                Btn_hamKullanim.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else { Btn_hamKullanim.Visibility = DevExpress.XtraBars.BarItemVisibility.Never; }

            if (Frm_Login.user.hamRaporEkle == true)
            {
                Btn_hamRaporEkle.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else { Btn_hamRaporEkle.Visibility = DevExpress.XtraBars.BarItemVisibility.Never; }

            if (Frm_Login.user.hamStok == true)
            {
                Btn_HamStok.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else { Btn_HamStok.Visibility = DevExpress.XtraBars.BarItemVisibility.Never; }

            if (Frm_Login.user.hamStokGuncelle == true)
            {
                Btn_HamStokGuncelle.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else { Btn_HamStokGuncelle.Visibility = DevExpress.XtraBars.BarItemVisibility.Never; }

            if (Frm_Login.user.isilIslem == true)
            {
                Btn_IsilIslem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else { Btn_IsilIslem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never; }

            if (Frm_Login.user.islemRaporlari == true)
            {
                Btn_GunlukHareketler.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else { Btn_GunlukHareketler.Visibility = DevExpress.XtraBars.BarItemVisibility.Never; }

            if (Frm_Login.user.kanalAcma == true)
            {
                Btn_KanalAcma.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else { Btn_KanalAcma.Visibility = DevExpress.XtraBars.BarItemVisibility.Never; }

            if (Frm_Login.user.kanalBuyut == true)
            {
                Btn_kanalBuyutme.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else { Btn_kanalBuyutme.Visibility = DevExpress.XtraBars.BarItemVisibility.Never; }

            if (Frm_Login.user.kontrol == true)
            {
                Btn_Kontrol.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else { Btn_Kontrol.Visibility = DevExpress.XtraBars.BarItemVisibility.Never; }

            if (Frm_Login.user.polisaj1 == true)
            {
                Btn_Polisaj1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else { Btn_Polisaj1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never; }

            if (Frm_Login.user.polisaj2 == true)
            {
                Btn_polisaj2.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else { Btn_polisaj2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never; }

            if (Frm_Login.user.pres == true)
            {
                Btn_pres.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else { Btn_pres.Visibility = DevExpress.XtraBars.BarItemVisibility.Never; }

            if (Frm_Login.user.siparisDurumKontrol == true)
            {
                Btn_sipDurumKontrol.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else { Btn_sipDurumKontrol.Visibility = DevExpress.XtraBars.BarItemVisibility.Never; }

            if (Frm_Login.user.tamamlananSiparis == true)
            {
                Btn_tamamSiparisler.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else { Btn_tamamSiparisler.Visibility = DevExpress.XtraBars.BarItemVisibility.Never; }

            if (Frm_Login.user.temper == true)
            {
                Btn_Temper.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else { Btn_Temper.Visibility = DevExpress.XtraBars.BarItemVisibility.Never; }

            if (Frm_Login.user.ucSiyirma == true)
            {
                Btn_UcSiyirma.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else { Btn_UcSiyirma.Visibility = DevExpress.XtraBars.BarItemVisibility.Never; }

            if (Frm_Login.user.urunDuzenle == true)
            {
                Btn_UrunDuzenle.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else { Btn_UrunDuzenle.Visibility = DevExpress.XtraBars.BarItemVisibility.Never; }

            if (Frm_Login.user.urunStok == true)
            {
                Btn_UrunStok.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else { Btn_UrunStok.Visibility = DevExpress.XtraBars.BarItemVisibility.Never; }

            if (Frm_Login.user.urunTurleri == true)
            {
                barButtonItem27.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else { barButtonItem27.Visibility = DevExpress.XtraBars.BarItemVisibility.Never; }

            if (Frm_Login.user.yeniPSevkiyat == true)
            {
                Btn_YeniSevkiyat.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else { Btn_YeniSevkiyat.Visibility = DevExpress.XtraBars.BarItemVisibility.Never; }

            if (Frm_Login.user.yeniSiparis == true)
            {
                barButtonItem2.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else { barButtonItem2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never; }

            if (Frm_Login.user.yeniSipSevkiyat == true)
            {
                Btn_SipSevkiyat.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else { Btn_SipSevkiyat.Visibility = DevExpress.XtraBars.BarItemVisibility.Never; }

            if (Frm_Login.user.yeniUrunEkle == true)
            {
                Btn_YeniIgneEkle.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else { Btn_YeniIgneEkle.Visibility = DevExpress.XtraBars.BarItemVisibility.Never; }

            if (Frm_Login.user.yikama == true)
            {
                Btn_Yikama.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else { Btn_Yikama.Visibility = DevExpress.XtraBars.BarItemVisibility.Never; }

            if (Frm_Login.user.yolKopyala == true)
            {
                Btn_YolKopyala.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else { Btn_YolKopyala.Visibility = DevExpress.XtraBars.BarItemVisibility.Never; }

            if (Frm_Login.user.hataduzelt == true)
            {
                Btn_hataDuzeltme.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else { Btn_hataDuzeltme.Visibility = DevExpress.XtraBars.BarItemVisibility.Never; }

            if (Frm_Login.user.iade == true)
            {
                Btn_Iadeler.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else { Btn_Iadeler.Visibility = DevExpress.XtraBars.BarItemVisibility.Never; }

        }



        public void DisposeAllButThis(Form form)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == form.GetType()
                    && frm != form)
                {
                    frm.Dispose();
                    frm.Close();
                }
            }
        }
        
        void ErrorMessage()
        {
            XtraMessageBox.Show("Bu Sayfayı Görüntüleme Yetkiniz Yoktur !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {   //IgneTurleri Butonu
           
                frmIgneTur = new Frm_IgneTurleri();
                frmIgneTur.MdiParent = this;
                DisposeAllButThis(frmIgneTur);
                frmIgneTur.Show();
               
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
                if (frmYeniSiparis == null || frmYeniSiparis.IsDisposed)
                {
                    frmYeniSiparis = new Frm_YeniSiparis();
                    frmYeniSiparis.Show();
                }
           
            
        }

        private void Btn_pres_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {      
                frmPres = new Frm_Pres();
                frmPres.MdiParent = this;
                DisposeAllButThis(frmPres);
                frmPres.Show();      
        }

        private void Btn_YeniIgneEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmIgneEkle == null || frmIgneEkle.IsDisposed) {

                frmIgneEkle = new Frm_YeniIgneEkle();
                frmIgneEkle.Show();
            }
        }

        private void Btn_arkaSiyirma_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           // if (frmArkaSiyir == null || frmArkaSiyir.IsDisposed) {

                frmArkaSiyir = new Frm_ArkaSiyirma();
                frmArkaSiyir.MdiParent = this;
                DisposeAllButThis(frmArkaSiyir);
                frmArkaSiyir.Show();
           // }
        }

        private void Btn_SiparisDurum_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          //  if (frmSiparisKontrol == null || frmSiparisKontrol.IsDisposed)
           // {

                frmSiparisKontrol = new Frm_SiparisKontrol();
                frmSiparisKontrol.MdiParent = this;
                DisposeAllButThis(frmSiparisKontrol);
                frmSiparisKontrol.Show();
           // }
        }

        private void Btn_GunlukHareketler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           // if (frmRapor == null || frmRapor.IsDisposed)
           // {

                frmRapor = new Frm_RaporOzet();
                frmRapor.MdiParent = this;
                DisposeAllButThis(frmRapor);
                frmRapor.Show();
           // }
        }

        private void Btn_YolKopyala_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          //  if (frmKopyala == null || frmKopyala.IsDisposed) {

                frmKopyala = new Frm_YolKopyala();
                frmKopyala.MdiParent = this;
                DisposeAllButThis(frmKopyala);
                frmKopyala.Show();

          //  }
        }

        private void Btn_UcSiyirma_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           // if (frmUcSiyir == null || frmUcSiyir.IsDisposed)
           // {

                frmUcSiyir = new Frm_UcSiyirma();
                frmUcSiyir.MdiParent = this;
                DisposeAllButThis(frmUcSiyir);
                frmUcSiyir.Show();

           // }
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //Kanal acma butonu
        {
           // if (frmKanalAcma == null || frmKanalAcma.IsDisposed)
           // {

                frmKanalAcma = new Frm_KanalAcma();
                frmKanalAcma.MdiParent = this;
                DisposeAllButThis(frmKanalAcma);
                frmKanalAcma.Show();

          //  }

        }

        private void Btn_kanalBuyutme_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           // if (frmkanalbuyut == null || frmkanalbuyut.IsDisposed)
          //  {

                frmkanalbuyut = new Frm_KanalBuyutme();
                frmkanalbuyut.MdiParent = this;
                DisposeAllButThis(frmkanalbuyut);
                frmkanalbuyut.Show();

          //  }
        }

        private void Btn_Polisaj1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           // if (frmpoli1 == null || frmpoli1.IsDisposed)
          //  {

                frmpoli1 = new Frm_Polisaj1();
                frmpoli1.MdiParent = this;
                DisposeAllButThis(frmpoli1);
                frmpoli1.Show();

           // }
        }

        private void Btn_DilCakma_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          //  if (frmDilCak == null || frmDilCak.IsDisposed)
          //  {

                frmDilCak = new Frm_DilCakma();
                frmDilCak.MdiParent = this;
                DisposeAllButThis(frmDilCak);
                frmDilCak.Show();

           // }
        }

        private void Btn_polisaj2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
         //   if (frmPolisaj2 == null || frmPolisaj2.IsDisposed)
         //   {

                frmPolisaj2 = new Frm_Polisaj2();
                frmPolisaj2.MdiParent = this;
                DisposeAllButThis(frmPolisaj2);
                frmPolisaj2.Show();

            //}
        }

        private void Btn_IsilIslem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          //  if (frmIsilIslem == null || frmIsilIslem.IsDisposed)
          //  {

                frmIsilIslem = new Frm_IsilIslem();
                frmIsilIslem.MdiParent = this;
                DisposeAllButThis(frmIsilIslem);
                frmIsilIslem.Show();

          //  }
        }

        private void Btn_Temper_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           // if (frmTemper == null || frmTemper.IsDisposed)
          //  {

                frmTemper = new Frm_Temper();
                frmTemper.MdiParent = this;
                DisposeAllButThis(frmTemper);
                frmTemper.Show();



            //  }
        }

        private void barButtonItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        { //Btn_HamStokGuncelle

            if (frmHamstokGuncelle == null || frmHamstokGuncelle.IsDisposed)
            {

                frmHamstokGuncelle = new Frm_HamStokGuncelle();
                frmHamstokGuncelle.Show();

            }

        }

        private void Btn_Yikama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           // if (frmYikama == null || frmYikama.IsDisposed)
           // {

                frmYikama = new Frm_Yikama();
                frmYikama.MdiParent = this;
                DisposeAllButThis(frmYikama);
                frmYikama.Show();


            // }
        }

        private void Btn_Bileme_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           // if (frmBileme == null || frmBileme.IsDisposed)
           // {

                frmBileme = new Frm_Bileme();
                frmBileme.MdiParent = this;
                DisposeAllButThis(frmBileme);
                frmBileme.Show();


            // }
        }

        private void Btn_Kontrol_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           // if (frmKontrol == null || frmKontrol.IsDisposed)
          //  {

                frmKontrol = new Frm_Kontrol();
                frmKontrol.MdiParent = this;
                DisposeAllButThis(frmKontrol);
                frmKontrol.Show();


            // }
        }

        private void Btn_tamamSiparisler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


                frmTamamSiparis = new Frm_TamamlananSiparisler();
                frmTamamSiparis.MdiParent = this;
                DisposeAllButThis(frmTamamSiparis);
                frmTamamSiparis.Show();

            //if (frmTamamSiparis == null || frmTamamSiparis.IsDisposed)
            //{
            //    frmTamamSiparis = new Frm_TamamlananSiparisler();
            //    frmTamamSiparis.MdiParent = this;
            //    frmTamamSiparis.Show();


            //}
        }

        private void Btn_sipDurumKontrol_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmSipDkntrol == null || frmSipDkntrol.IsDisposed)
            {

                frmSipDkntrol = new  Frm_SiparisDurumKontrol();           
                frmSipDkntrol.Show();
               
            }
        }

        private void barButtonItem29_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHamStok = new Frm_HamStok();
            frmHamStok.MdiParent = this;
            DisposeAllButThis(frmHamStok);
            frmHamStok.Show();
        }

        private void Btn_hamRaporEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmHamRaporEkle == null || frmHamRaporEkle.IsDisposed) {

                frmHamRaporEkle = new Frm_HamRaporEkle();
                frmHamRaporEkle.Show();
            }
        }

        private void Btn_hamKullanim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHamRapor = new Frm_HamRaporlari();
            frmHamRapor.MdiParent = this;
            DisposeAllButThis(frmHamRapor);
            frmHamRapor.Show();
        }

        private void Btn_UrunStok_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             frmUrunStok = new Frm_UrunStok();
             frmUrunStok.MdiParent = this;
             DisposeAllButThis(frmUrunStok);
             frmUrunStok.Show();
        }

        private void Btn_FirmaEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmFirmaEkle == null || frmFirmaEkle.IsDisposed)
            {

                frmFirmaEkle = new Frm_FirmaEkle();
                frmFirmaEkle.Show();
            }
        }

        private void Btn_Firmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmFirmalar = new Frm_Firmalar();
            frmFirmalar.MdiParent = this;
            DisposeAllButThis(frmFirmalar);
            frmFirmalar.Show();
        }

        private void Btn_YeniSevkiyat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmYeniSevkiyat == null || frmYeniSevkiyat.IsDisposed)
            {

                frmYeniSevkiyat = new Frm_YeniSevkiyat();
                frmYeniSevkiyat.Show();
            }
        }

        private void Btn_SipSevkiyat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmSipSevkiyat == null || frmSipSevkiyat.IsDisposed)
            {

                frmSipSevkiyat = new Frm_SiparisSevkiyat();
                frmSipSevkiyat.Show();
            }
        }

        private void Btn_GecmisSevkiyat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmGecmisSevk = new Frm_GecmisSevkiyat();
            frmGecmisSevk.MdiParent = this;
            DisposeAllButThis(frmGecmisSevk);
            frmGecmisSevk.Show();
        }

        private void Btn_UrunDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmUrunDuzenle == null || frmUrunDuzenle.IsDisposed)
            {

                frmUrunDuzenle = new Frm_UrunDuzenle();
                frmUrunDuzenle.Show();
            }
        }

        private void Btn_AnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAnaSayfa = new Frm_AnaSayfa();
            frmAnaSayfa.MdiParent = this;
            DisposeAllButThis(frmAnaSayfa);
            frmAnaSayfa.Show();
            
        }

        private void Btn_ayarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmAyarlar == null || frmAyarlar.IsDisposed)
            {

                frmAyarlar = new Frm_Ayarlar();
                frmAyarlar.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeButtons();
            Btn_AnaSayfa.PerformClick();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        

        private void Btn_hataDuzeltme_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHataDuzelt = new Frm_HataDuzeltme();
            frmHataDuzelt.MdiParent = this;
            DisposeAllButThis(frmHataDuzelt);
            frmHataDuzelt.Show();
        }

        private void Btn_Iadeler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmIade = new Frm_Iade();
            frmIade.MdiParent = this;
            DisposeAllButThis(frmIade);
            frmIade.Show();
        }
    }
}
