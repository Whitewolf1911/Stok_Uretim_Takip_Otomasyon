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
    }
}
