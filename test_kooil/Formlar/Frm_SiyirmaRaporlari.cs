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
    public partial class Frm_SiyirmaRaporlari : Form
    {
        public Frm_SiyirmaRaporlari()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();
        void listele()
        {
            var veriler = (from x in db.TBL_ARKASIYIR
                           select new
                           {
                               x.SIPARISNO,
                               x.RAPORLAYAN,
                               x.IGNEKODU,
                               x.ISLENENMIKTAR,
                               x.TARIH,
                               x.NOT

                           }).ToList().OrderByDescending(x => x.TARIH);

            gridControl1.DataSource = veriler;

        }
        private void Btn_Yenile_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txt_SiparisNo.Text = gridView1.GetFocusedRowCellValue("SIPARISNO").ToString();
            txt_Raporlayan.Text = gridView1.GetFocusedRowCellValue("RAPORLAYAN").ToString();
            txt_IgneKodu.Text = gridView1.GetFocusedRowCellValue("IGNEKODU").ToString();
            txt_IslenenAdet.Text = gridView1.GetFocusedRowCellValue("ISLENENMIKTAR").ToString();
            txt_Tarih.Text = gridView1.GetFocusedRowCellValue("TARIH").ToString();
            txt_Not.Text = gridView1.GetFocusedRowCellValue("NOT").ToString();
        }

        private void Frm_SiyirmaRaporlari_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
