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
    public partial class Frm_ArkaSiyirma : Form
    {
        public Frm_ArkaSiyirma()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();
        Frm_SiyirmaRaporlari frmSiyirmaRapor;
        Frm_SiyirmaEkle frmSiyirEkle;
        void listele()
        {
            var siyirilcakUrunler = (from x in db.TBL_SIPARIS
                                     select new
                                     {
                                         SiparisNo = x.SIPARISNOID,
                                         x.TBL_IGNELER.TUR,
                                         x.TBL_IGNELER.IGNEKOD,
                                         IstenilenMiktar = x.URUNADETI,                                    
                                         x.NOTLAR,                                       
                                         x.AKTIF

                                     }).ToList().OrderByDescending(x => x.SiparisNo);

            gridControl1.DataSource = siyirilcakUrunler.Where(x => x.AKTIF == true) ;
            gridView1.Columns[1].AppearanceCell.BackColor = Color.LightGreen;
            gridView1.Columns[2].AppearanceCell.BackColor = Color.Aquamarine;
            gridView1.Columns[3].AppearanceCell.BackColor = Color.Orange;
            gridView1.Columns[4].AppearanceCell.BackColor = Color.Cyan;
            gridView1.Columns[5].Visible = false;

        }
        private void Frm_ArkaSiyirma_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void Btn_SiyirmaEkle_Click(object sender, EventArgs e)
        {
            if (frmSiyirEkle == null || frmSiyirEkle.IsDisposed)
            {
                frmSiyirEkle = new Frm_SiyirmaEkle();

                frmSiyirEkle.Show();
            }
        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void Btn_SiyirmaRapor_Click(object sender, EventArgs e)
        {
            if (frmSiyirmaRapor == null || frmSiyirmaRapor.IsDisposed)
            {
                frmSiyirmaRapor = new Frm_SiyirmaRaporlari();
                frmSiyirmaRapor.MdiParent = this.ParentForm;
                frmSiyirmaRapor.Show();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("IGNEKOD") != null &&
                gridView1.GetFocusedRowCellValue("NOTLAR") != null) {

                     txt_sipIgneTur.Text = gridView1.GetFocusedRowCellValue("IGNEKOD").ToString();
                     txt_sipNot.Text = gridView1.GetFocusedRowCellValue("NOTLAR").ToString();
            }
            

        }
    }
}
