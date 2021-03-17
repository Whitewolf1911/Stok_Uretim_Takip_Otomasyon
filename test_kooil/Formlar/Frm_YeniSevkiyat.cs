using DevExpress.XtraEditors;
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
                                Firma = x.FIRMAAD,
                                FirmaAd = x.FIRMATAMAD,
                                x.VERGINO,

                            }).ToList().OrderBy(x => x.Firma);

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
                               x.FOTO,
                               x.ID
                           }
                           ).ToList().OrderByDescending(x => x.STOK);

            gridControl1.DataSource = urunler;
            gridView1.Columns[3].Visible = false;
            gridView1.Columns[4].Visible = false;

            gridView1.Columns[0].AppearanceCell.BackColor = Color.LightGreen;
            gridView1.Columns[1].AppearanceCell.BackColor = Color.Cyan;
            gridView1.Columns[2].AppearanceCell.BackColor = Color.Yellow;


        }
        private void Frm_YeniSevkiyat_Load(object sender, EventArgs e)
        {
            urunleriListele();
            firmaListele();
            initListView();
        }
        private void initListView()
        {
            // Add columns
            listView1.Columns.Add("Tür");
            listView1.Columns.Add("Kod");
            listView1.Columns.Add("Adet");
            listView1.View = View.Details;
        }

        private void Btn_SepeteEkle_Click(object sender, EventArgs e)
        {
            string urunTuru = gridView1.GetFocusedRowCellValue("TUR").ToString();
            string urunKodu = gridView1.GetFocusedRowCellValue("IGNEKOD").ToString();
            int urunID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            var igne = db.TBL_IGNELER.Find(urunID);
            int igneStok = (int)igne.STOK;
            int adet = (int)num_Adet.Value;

            //ADD TO TBL_SEVKIYAT
            if (date_Tarih.EditValue != null &&  adet < igneStok )
            {

                
                TBL_SEVKIYAT yeniSevk = new TBL_SEVKIYAT();
                yeniSevk.URUNTUR = urunTuru;
                yeniSevk.URUNKOD = urunKodu;
                yeniSevk.ADET = adet;
                yeniSevk.TARIH = date_Tarih.DateTime;
                yeniSevk.MUSTERI = gridView2.GetFocusedRowCellValue("Firma").ToString();

                db.TBL_SEVKIYAT.Add(yeniSevk);

                //add to listview
                string[] row = { urunTuru, urunKodu, adet.ToString() };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem).SubItems.AddRange(row);

                //Stoktan dusup urunleri tekrar listeleme
                 igne.STOK -= adet;
                 //urunleriListele();

            }
            else {
                if (date_Tarih.EditValue == null)
                {

                    XtraMessageBox.Show("Lütfen Tarih Seçiniz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (adet > igneStok) { 
                
                    XtraMessageBox.Show("Stokta Bulunandan Daha Fazla Ürün Sevkiyatı Yapamazsınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }


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

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView2.GetFocusedRowCellValue("Firma") != null) { txt_firma.Text = gridView2.GetFocusedRowCellValue("Firma").ToString(); }
        }

        private void Btn_Iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Tamamla_Click(object sender, EventArgs e)
        {
            DialogResult siradakiAsamaSorgu = MessageBox.Show("Sevkiyatı Tamamlamak İstediğinize Emin Misiniz ? ", "Sevkiyat Onay", MessageBoxButtons.YesNo);
            if (siradakiAsamaSorgu == DialogResult.Yes)
            {
                db.SaveChanges();
                urunleriListele();
            }
        }
        Font header = new Font("Verdana", 18, FontStyle.Bold);
        Font subHeader = new Font("Verdana", 15, FontStyle.Bold);
        Font content = new Font("Verdana", 12, FontStyle.Bold);
        SolidBrush sb = new SolidBrush(Color.Black);


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {   //PAGE
            StringFormat st = new StringFormat();
            st.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("SEVK İRSALİYESİ", header, sb, 525, 60, st);

            e.Graphics.DrawString("Ürün Tipi     Ürün Kodu       Adet", header, sb, 120, 150, st);




        }

        private void Btn_Yazdir_Click(object sender, EventArgs e)
        {

            //if (printDialog1.ShowDialog() == DialogResult.OK) {

            //    printDocument1.Print();
            //}

            printPreviewDialog1.ShowDialog();
        }
    }
}
