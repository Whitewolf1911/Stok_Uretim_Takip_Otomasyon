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
    public partial class Frm_YeniSevkiyat : Form
    {
        public Frm_YeniSevkiyat()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();

        void firmaListele() {

            var firmalar = (from x in db.TBL_FIRMALAR
                            select new
                            {
                                x.FIRMAAD,
                                x.FIRMATAMAD,
                                x.VERGINO,

                            }).ToList().OrderBy(x => x.FIRMAAD);

            gridControl2.DataSource = firmalar;
            gridView2.Columns[2].Visible = false;
        
        }
        void urunleriListele() {

            var urunler = (from x in db.TBL_IGNELER
                           select new
                           {

                               x.TUR,
                               x.IGNEKOD,
                               x.STOK,
                               x.FOTO
                           }
                           ).ToList().OrderBy(x => x.STOK);

            gridControl1.DataSource = urunler;
            gridView1.Columns[3].Visible = false;
            gridView1.Columns[0].AppearanceCell.BackColor = Color.LightGreen;
            gridView1.Columns[1].AppearanceCell.BackColor = Color.Cyan;
            gridView1.Columns[2].AppearanceCell.BackColor = Color.Yellow;


        }
        private void Frm_YeniSevkiyat_Load(object sender, EventArgs e)
        {
            urunleriListele();
            firmaListele();
        }

        private void Btn_SepeteEkle_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {   //Urunler

            if (gridView1.GetFocusedRowCellValue("FOTO") != null)
            {
                pic_Urun.Image = Frm_IgneTurleri.ImageFromByteArray((byte[])gridView1.GetFocusedRowCellValue("FOTO"));
            }
            if (gridView1.GetFocusedRowCellValue("FOTO") == null)
            {
                pic_Urun.Image = null;
            }

        }
    }
}
