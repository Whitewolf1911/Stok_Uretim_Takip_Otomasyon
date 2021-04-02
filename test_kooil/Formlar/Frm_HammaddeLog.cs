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
    public partial class Frm_HammaddeLog : Form
    {
        public Frm_HammaddeLog()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();

        void logListele() {

            var veriler = (from x in db.TBL_HAMLOG
                           select new
                           {
                               İşlem = x.ISLEM,
                               Kilogram = x.MIKTAR,
                               Neden = x.SEBEP,
                               Kalınlık = x.KALINLIK,
                               Genişlik = x.GENISLIK,
                               Özellik = x.OZELLIK,
                               Menşei = x.MENSEI,
                               Tarih = x.TARIH,
                               Raporlayan = x.RAPORLAYAN

                           }).ToList().OrderByDescending(x => x.Tarih);
            gridControl1.DataSource = veriler;
        
        }
        private void Frm_HammaddeLog_Load(object sender, EventArgs e)
        {
            logListele();
        }
    }
}
