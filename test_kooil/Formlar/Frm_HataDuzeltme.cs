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
    public partial class Frm_HataDuzeltme : Form
    {
        public Frm_HataDuzeltme()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();

        void sipListele() {

            var veriler = (from x in db.TBL_SIPARIS
                           select new
                           {

                               SiparişNo = x.SIPARISNOID,
                               Müşteri = x.MUSTERI,
                               Tür = x.TBL_IGNELER.TUR,
                               ÜrünKodu = x.TBL_IGNELER.IGNEKOD,
                               SiparişTarih = x.SIPARISTARIHI,
                               İstenilenTarih = x.ISTENILENTARIH,
                               x.ARKASIYIRSAYI, //6
                               x.BILEMESAYI,
                               x.DILCAKMASAYI,
                               x.ISILISLEMSAYI,
                               x.KANALACMASAYI,
                               x.KANALBUYUTSAYI,
                               x.KONTROLSAYI,
                               x.NOTLAR,
                               x.POLI1SAYI,
                               x.POLI2SAYI,
                               x.PRESSAYI,
                               x.SEVKIYATSAYI,
                               x.TEMPERSAYI,
                               x.UCSIYIRMASAYI,
                               x.URUNADETI,
                               x.YIKAMASAYI,
                               x.YOLKOPYASAYI

                           }).ToList().OrderByDescending(x => x.SiparişNo);

            gridControl1.DataSource = veriler;
            gridView1.Columns[6].Visible = false;
            gridView1.Columns[7].Visible = false;
            gridView1.Columns[8].Visible = false;
            gridView1.Columns[9].Visible = false;
            gridView1.Columns[10].Visible = false;
            gridView1.Columns[11].Visible = false;
            gridView1.Columns[12].Visible = false;
            gridView1.Columns[13].Visible = false;
            gridView1.Columns[14].Visible = false;
            gridView1.Columns[15].Visible = false;
            gridView1.Columns[16].Visible = false;
            gridView1.Columns[17].Visible = false;
            gridView1.Columns[18].Visible = false;
            gridView1.Columns[19].Visible = false;
            gridView1.Columns[20].Visible = false;
            gridView1.Columns[22].Visible = false;
            gridView1.Columns[21].Visible = false;

            gridView1.Columns[0].AppearanceCell.BackColor = Color.Cyan;
            gridView1.Columns[1].AppearanceCell.BackColor = Color.Yellow;
            gridView1.Columns[4].AppearanceCell.BackColor = Color.LightGreen;
            gridView1.Columns[5].AppearanceCell.BackColor = Color.Orange;

        }

        private void Frm_HataDuzeltme_Load(object sender, EventArgs e)
        {
            sipListele();
        }
    }
}
