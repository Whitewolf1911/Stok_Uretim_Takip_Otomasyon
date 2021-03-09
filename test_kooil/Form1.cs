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
        public Form1()
        {
            InitializeComponent();
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

        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {   //IgneTurleri Butonu
            
           // if (frmIgneTur == null || frmIgneTur.IsDisposed) {

                frmIgneTur = new Frm_IgneTurleri();
                frmIgneTur.MdiParent = this;
                DisposeAllButThis(frmIgneTur);
                frmIgneTur.Show();
          //  }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {   
            if(frmYeniSiparis == null || frmYeniSiparis.IsDisposed)
            {
                frmYeniSiparis = new Frm_YeniSiparis();
                frmYeniSiparis.Show();
            }
            
        }

        private void Btn_pres_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          //  if (frmPres == null || frmPres.IsDisposed)
           // {

                frmPres = new Frm_Pres();
                frmPres.MdiParent = this;
                DisposeAllButThis(frmPres);
                frmPres.Show();
           // }
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
        {
            
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
    }
}
