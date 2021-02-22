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
                                     {   SiparisNo = x.SIPARISNOID,   
                                         x.TBL_IGNELER.IGNEKOD,
                                         IstenilenMiktar = x.URUNADETI,
                                         x.NOTLAR,
                                         x.SIPARISASAMASI,
                                         x.AKTIF

                                     }).ToList().OrderByDescending(x => x.SiparisNo);
            
            gridControl1.DataSource = preslencekUrunler.Where(x => x.AKTIF ==true);

            gridView1.Columns[4].Visible = false; //siparis asamasi sutunu gozukmeyecek.
            gridView1.Columns[5].Visible = false;

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

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
                txt_sipIgneTur.Text = gridView1.GetFocusedRowCellValue("IGNEKOD").ToString();             
                txt_sipNot.Text = gridView1.GetFocusedRowCellValue("NOTLAR").ToString();
                
                
           
           

        }
    }
}
