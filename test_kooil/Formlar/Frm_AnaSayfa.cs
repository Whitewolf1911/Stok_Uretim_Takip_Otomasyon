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
    public partial class Frm_AnaSayfa : Form
    {
        public Frm_AnaSayfa()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();
        
        void hamListele()
        {
            var veriler = (from x in db.TBL_HAMMADDE
                           select new
                           {
                               Kalınlık = x.KALINLIK,
                               Genişlik = x.GENISLIK,
                               Özellik = x.OZELLIK,
                               Menşei = x.MENSEI,
                               Kilogram = x.MIKTAR
                           }).ToList().OrderBy(x => x.Kilogram).Take(15);

            gridControl_ham.DataSource = veriler;
        }

        void islemListele()
        {
            var veriler = (from x in db.TBL_RAPOR
                           select new
                           {
                               İşlem = x.ISLEM,
                               ÜrünKodu = x.IGNEKODU,
                               Miktar = x.ISLENENMIKTAR,
                               Tarih = x.TARIH
                           }).ToList().OrderByDescending(x => x.Tarih).Take(15);

            gridControl_hareket.DataSource = veriler;
        }

        void sevkListele()
        {
            var veriler = (from x in db.TBL_SEVKIYAT
                           select new
                           {                            
                               Müşteri = x.MUSTERI,
                               Tür = x.URUNTUR,
                               ÜrünKod = x.URUNKOD,
                               Adet = x.ADET,
                               Tarih = x.TARIH
                           }).ToList().OrderByDescending(x => x.Tarih).Take(15);

            gridControl_sevk.DataSource = veriler;
            
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_AnaSayfa_Load(object sender, EventArgs e)
        {
            hamListele();
            sevkListele();
            islemListele();
        }
    }
}
