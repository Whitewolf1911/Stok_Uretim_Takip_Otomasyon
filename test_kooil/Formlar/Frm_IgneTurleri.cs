using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
                               x.NOT,
                               x.FOTO
                           }
                           );
            gridControl1.DataSource = igneler.ToList();
          //  gridView1.Columns[5].Visible = false;

        }
        private void labelControl1_Click(object sender, EventArgs e)
        {
            
        }
        public static Image ImageFromByteArray(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            using (Image image = Image.FromStream(ms, true, true))
            {
                return (Image)image.Clone();
            }
        }
        private void Btn_Yenile_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("IGNEKOD") != null) {
                txt_IgneKod.Text = gridView1.GetFocusedRowCellValue("IGNEKOD").ToString();
            }

            if (gridView1.GetFocusedRowCellValue("ADETFIYATI") != null) {
                txt_BirimFiyat.Text = gridView1.GetFocusedRowCellValue("ADETFIYATI").ToString();
            }
            if (gridView1.GetFocusedRowCellValue("EBAT") != null) {
                txt_Ebat.Text = gridView1.GetFocusedRowCellValue("EBAT").ToString();
            }
            if (gridView1.GetFocusedRowCellValue("ISILISLEMFORMUL") != null) {
                txt_IsilIslem.Text = gridView1.GetFocusedRowCellValue("ISILISLEMFORMUL").ToString(); }
            if (gridView1.GetFocusedRowCellValue("NOT") != null) {
                txt_Not.Text = gridView1.GetFocusedRowCellValue("NOT").ToString();
            } 
             if(gridView1.GetFocusedRowCellValue("FOTO") != null) {
                pic_IgneFoto.Image = ImageFromByteArray((byte[])gridView1.GetFocusedRowCellValue("FOTO"));
            }
            if (gridView1.GetFocusedRowCellValue("FOTO") == null) {
                pic_IgneFoto.Image = null;
            }

                 
                
                
               
               
                

            
            

        }

        private void Frm_IgneTurleri_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}