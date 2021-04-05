using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
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
                               Kilogram = x.MIKTAR,
                               x.AKTIF
                           }).ToList().OrderBy(x => x.Kilogram).Where(x => x.AKTIF ==true).Take(20);

            gridControl_ham.DataSource = veriler;
            gridView1.Columns[5].Visible = false;
            gridView1.Columns[4].AppearanceCell.BackColor = Color.Orange;
            
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

        void siparisListele()
        {
            var veriler = (from x in db.TBL_SIPARIS
                           select new
                           {

                               Müşteri = x.MUSTERI,
                               Tür = x.TBL_IGNELER.TUR,
                               ÜrünKodu = x.TBL_IGNELER.IGNEKOD,
                               x.SIPARISASAMASI,
                               x.AKTIF
                           }).ToList().Where(x => x.AKTIF == true).OrderBy(x => x.Müşteri);
            gridControl_durum.DataSource = veriler;
            gridView4.Columns[3].Visible = false;
            gridView4.Columns[4].Visible = false;

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_AnaSayfa_Load(object sender, EventArgs e)
        {
            label_user.Text = Frm_Login.user.AdSoyad;
            hamListele();
            sevkListele();
            islemListele();
            siparisListele();
            timer1.Start();
            timer2.Start();

            GridColumn unbColumn = gridView4.Columns.AddField("Durum");
            unbColumn.VisibleIndex = gridView4.Columns.Count;
            unbColumn.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            unbColumn.OptionsColumn.AllowEdit = false;
            unbColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            unbColumn.AppearanceCell.BackColor = Color.LightGreen;
        }

        string getDurum(GridView view, int listSourceRowIndex)
        {

            int durumId = Convert.ToInt32(view.GetListSourceRowCellValue(listSourceRowIndex, "SIPARISASAMASI"));
            string durum = "";
            switch (durumId)
            {
                case 0:
                    durum = "Pres Bekleniyor";
                    break;
                case 1:
                    durum = "Preste";
                    break;
                case 2:
                    durum = "Arka Sıyırmada";
                    break;
                case 3:
                    durum = "Yol Kopyalamada";
                    break;
                case 4:
                    durum = "Uç Sıyırmada";
                    break;
                case 5:
                    durum = "Kanal Açmada";
                    break;
                case 6:
                    durum = "Kanal Büyütmede";
                    break;
                case 7:
                    durum = "Polisaj1 de";
                    break;
                case 8:
                    durum = "Dil Çakmada";
                    break;
                case 9:
                    durum = "Polisaj2 de";
                    break;
                case 10:
                    durum = "Isıl İşlemde";
                    break;
                case 11:
                    durum = "Temperde";
                    break;
                case 12:
                    durum = "Yıkamada";
                    break;
                case 13:
                    durum = "Bilemede";
                    break;
                case 14:
                    durum = "Kontrolde";
                    break;
         }
            return durum;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            digitalClock.Text = DateTime.Now.ToString("d") + "\n" + DateTime.Now.ToString("dddd") + "\n" + DateTime.Now.ToString("HH:mm:ss") ;
        }

        private void gridView4_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Column.FieldName == "Durum" && e.IsGetData) e.Value =
              getDurum(view, e.ListSourceRowIndex);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            hamListele();
            sevkListele();
            islemListele();
            siparisListele();
        }
    }
}
