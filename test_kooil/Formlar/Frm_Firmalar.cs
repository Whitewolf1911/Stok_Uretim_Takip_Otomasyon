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
    public partial class Frm_Firmalar : Form
    {
        public Frm_Firmalar()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();

        void listele()
        {
            var veriler = (from x in db.TBL_FIRMALAR
                           select new
                           {

                               x.ID,
                               FirmaAd = x.FIRMAAD,
                               FirmaTamAd = x.FIRMATAMAD,
                               x.ADRES,
                               x.KONUM,
                               x.MAIL,
                               x.TELEFON1,
                               x.TELEFON2,
                               x.VERGIDAIRESI,
                               x.VERGINO


                           }).ToList();

            gridControl1.DataSource = veriler;

            gridView1.Columns[0].Visible = false;
            gridView1.Columns[3].Visible = false;
            gridView1.Columns[4].Visible = false;
            gridView1.Columns[7].Visible = false;
            gridView1.Columns[8].Visible = false;
            gridView1.Columns[9].Visible = false;

            gridView1.Columns[1].AppearanceCell.BackColor = Color.LightGreen;
            gridView1.Columns[2].AppearanceCell.BackColor = Color.Cyan;
            gridView1.Columns[5].AppearanceCell.BackColor = Color.Yellow;
            gridView1.Columns[6].AppearanceCell.BackColor = Color.Lime;






        }
        private void Frm_Firmalar_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
