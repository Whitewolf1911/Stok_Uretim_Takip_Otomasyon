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
        

        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {   //IgneTurleri Butonu
            
            if (frmIgneTur == null || frmIgneTur.IsDisposed) {

                frmIgneTur = new Frm_IgneTurleri();
                frmIgneTur.MdiParent = this;
                frmIgneTur.Show();
            }
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
            if (frmPres == null || frmPres.IsDisposed)
            {

                frmPres = new Frm_Pres();
                frmPres.MdiParent = this;
                frmPres.Show();
            }
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
            if (frmArkaSiyir == null || frmArkaSiyir.IsDisposed) {

                frmArkaSiyir = new Frm_ArkaSiyirma();
                frmArkaSiyir.MdiParent = this;
                frmArkaSiyir.Show();
            }
        }

        private void Btn_SiparisDurum_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmSiparisKontrol == null || frmSiparisKontrol.IsDisposed)
            {

                frmSiparisKontrol = new Frm_SiparisKontrol();
                frmSiparisKontrol.MdiParent = this;
                frmSiparisKontrol.Show();
            }
        }

        private void Btn_GunlukHareketler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmRapor == null || frmRapor.IsDisposed)
            {

                frmRapor = new Frm_RaporOzet();
                frmRapor.MdiParent = this;
                frmRapor.Show();
            }
        }

        private void Btn_YolKopyala_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmKopyala == null || frmKopyala.IsDisposed) {

                frmKopyala = new Frm_YolKopyala();
                frmKopyala.MdiParent = this;
                frmKopyala.Show();

            }
        }

        private void Btn_UcSiyirma_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmUcSiyir == null || frmUcSiyir.IsDisposed)
            {

                frmUcSiyir = new Frm_UcSiyirma();
                frmUcSiyir.MdiParent = this;
                frmUcSiyir.Show();

            }
        }
    }
}
