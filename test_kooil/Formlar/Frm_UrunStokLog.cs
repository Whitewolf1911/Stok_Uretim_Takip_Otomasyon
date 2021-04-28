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
    public partial class Frm_UrunStokLog : Form
    {
        public Frm_UrunStokLog()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();

        void listele() {
            try
            {
                var veriler = (from x in db.TBL_URUNSTOKLOG
                               select new
                               {
                                   İşlem = x.ISLEM,
                                   Adet = x.MIKTAR,
                                   Ürün = x.URUN,
                                   Tarih = x.TARIH,
                                   İşlemiYapan = x.RAPORLAYAN

                               }).ToList().OrderByDescending(x => x.Tarih);
                gridControl1.DataSource = veriler;
                gridView1.Columns[0].AppearanceCell.BackColor = Color.Yellow;
                gridView1.Columns[1].AppearanceCell.BackColor = Color.LightGreen;
                gridView1.Columns[2].AppearanceCell.BackColor = Color.Cyan;
            }
            catch (Exception) { }
        }
        private void Frm_UrunStokLog_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
