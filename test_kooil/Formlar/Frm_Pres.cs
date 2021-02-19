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
using test_kooil.Formlar;


namespace test_kooil.Formlar
{
    public partial class Frm_Pres : Form
    {
        public Frm_Pres()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();
        Frm_PresEkle ekleEkrani;
        Frm_PresRaporlari presRapor;
        void listele() {
            var preslencekUrunler = (from x in db.TBL_SIPARIS
                                     select new
                                     {   x.SIPARISNOID,   
                                         x.TBL_IGNELER.IGNEKOD,
                                         IstenilenMiktar = x.URUNADETI,
                                         x.SIPARISASAMASI

                                     }).ToList().OrderByDescending(x => x.SIPARISNOID);
            
            gridControl1.DataSource = preslencekUrunler.Where(x => x.SIPARISASAMASI == 1);
        }
        private void Frm_Pres_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void Btn_PresEkle_Click(object sender, EventArgs e)
        {
            if(ekleEkrani == null || ekleEkrani.IsDisposed)
            {
                ekleEkrani = new Frm_PresEkle();
                ekleEkrani.Show();
            }

        }

        private void Btn_PresRapor_Click(object sender, EventArgs e)
        {
            if (presRapor == null || presRapor.IsDisposed)
            {
                presRapor = new Frm_PresRaporlari();
                presRapor.MdiParent = this.ParentForm;
                presRapor.Show();
            }
        }
    }
}
