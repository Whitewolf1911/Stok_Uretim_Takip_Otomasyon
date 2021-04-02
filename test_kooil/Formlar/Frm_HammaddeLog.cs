using DevExpress.XtraGrid;
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
        private void ShowGridPreview(GridControl grid)
        {
            // Check whether the GridControl can be previewed.
            if (!grid.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                return;
            }
            // Open the Preview window.
            grid.ShowPrintPreview();
        }
        private void PrintGrid(GridControl grid)
        {
            // Check whether the GridControl can be printed.
            if (!grid.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                return;
            }
            // Print.
            grid.Print();
        }
        private void Frm_HammaddeLog_Load(object sender, EventArgs e)
        {
            logListele();
        }

        private void Btn_refresh_Click(object sender, EventArgs e)
        {
            logListele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ShowGridPreview(gridControl1);
            PrintGrid(gridControl1);
        }
    }
}
