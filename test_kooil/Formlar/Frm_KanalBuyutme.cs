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
    public partial class Frm_KanalBuyutme : Form
    {
        public Frm_KanalBuyutme()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();
        Frm_KanalBuyutmeEkle frmkekle;
        Frm_KanalBuyutmeRapor frm_kbRapor;
        void listele()
        {
            var islenecekUrunler = (from x in db.TBL_SIPARIS
                                    select new
                                    {
                                        SiparisNo = x.SIPARISNOID,
                                        x.TBL_IGNELER.IGNEKOD,
                                        IstenilenMiktar = x.URUNADETI,
                                        x.NOTLAR,
                                        x.SIPARISASAMASI,
                                        x.AKTIF

                                    }).ToList().OrderByDescending(x => x.SiparisNo);

            gridControl1.DataSource = islenecekUrunler.Where(x => x.AKTIF == true);

            gridView1.Columns[4].Visible = false; //siparis asamasi sutunu gozukmeyecek.
            gridView1.Columns[5].Visible = false;

        }
        private void Frm_KanalBuyutme_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void Btn_SiyirmaEkle_Click(object sender, EventArgs e)
        {
            frmkekle = new Frm_KanalBuyutmeEkle();
            frmkekle.Show();
        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void Btn_Raporlar_Click(object sender, EventArgs e)
        {
            if (frm_kbRapor == null || frm_kbRapor.IsDisposed)
            {
                frm_kbRapor = new Frm_KanalBuyutmeRapor();
                frm_kbRapor.MdiParent = this.ParentForm;
                frm_kbRapor.Show();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("IGNEKOD") != null &&
             gridView1.GetFocusedRowCellValue("NOTLAR") != null)
            {

                txt_sipIgneTur.Text = gridView1.GetFocusedRowCellValue("IGNEKOD").ToString();
                txt_sipNot.Text = gridView1.GetFocusedRowCellValue("NOTLAR").ToString();
            }
        }
    }
}
