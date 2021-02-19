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
//using System.Data.SqlClient;

namespace test_kooil.Formlar
{
    public partial class Frm_IgneTurleri : Form
    {
        public Frm_IgneTurleri()
        {
            InitializeComponent();
        }
        // sqlBaglanti bgl = new sqlBaglanti();
        DB_kooil_testEntities db = new DB_kooil_testEntities();
        void listele() {
            var igneler = (from x in db.TBL_IGNELER
                           select new
                           {
                               x.IGNEKOD,
                               x.EBAT,
                               x.ADETFIYATI,
                               x.ISILISLEMFORMUL,
                               x.NOT
                           }
                           );
            gridControl1.DataSource = igneler.ToList();
        }
        private void labelControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_Yenile_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txt_IgneKod.Text = gridView1.GetFocusedRowCellValue("IGNEKOD").ToString();
            txt_BirimFiyat.Text = gridView1.GetFocusedRowCellValue("ADETFIYATI").ToString();
            txt_Ebat.Text = gridView1.GetFocusedRowCellValue("EBAT").ToString();
            txt_IsilIslem.Text = gridView1.GetFocusedRowCellValue("ISILISLEMFORMUL").ToString();
            txt_Not.Text = gridView1.GetFocusedRowCellValue("NOT").ToString();

        }

        private void Frm_IgneTurleri_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}