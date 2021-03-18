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
    public partial class Frm_SiparisSevkiyat : Form
    {
        public Frm_SiparisSevkiyat()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();

        private void initListView()
        {
            // Add columns
            listView1.Columns.Add("Sipariş No");
            listView1.Columns.Add("Tür");
            listView1.Columns.Add("Kod");
            listView1.Columns.Add("Adet");
            listView1.View = View.Details;
        }
        void siparisListele()
        {
            var siparisler = (from x in db.TBL_SIPARIS
                              select new
                              {

                                  SiparisNo = x.SIPARISNOID,
                                  Firma = x.MUSTERI,
                                  x.TBL_IGNELER.TUR,
                                  Sipariş = x.URUNADETI,
                                  x.TBL_IGNELER.IGNEKOD,
                                  x.TBL_IGNELER.FOTO,
                                  x.TBL_IGNELER.STOK,
                                  x.AKTIF,
                                  Tarih = x.SIPARISTARIHI,
                                  Giden = x.SEVKIYATSAYI,
                                  x.TBL_IGNELER.ID


                              }).ToList().Where(x => x.AKTIF == true).OrderByDescending(x => x.STOK);

            gridControl1.DataSource = siparisler;
            gridView1.Columns[5].Visible = false;
            gridView1.Columns[7].Visible = false;
            gridView1.Columns[10].Visible = false;

        }
        private void Frm_SiparisSevkiyat_Load(object sender, EventArgs e)
        {
            initListView();
            siparisListele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("FOTO") != null)
            {
                pic_Urun.Image = Frm_IgneTurleri.ImageFromByteArray((byte[])gridView1.GetFocusedRowCellValue("FOTO"));
            }
            if (gridView1.GetFocusedRowCellValue("FOTO") == null)
            {
                pic_Urun.Image = null;
            }
        }

        private void Btn_SepeteEkle_Click(object sender, EventArgs e)
        {
            string siparisNo = gridView1.GetFocusedRowCellValue("SiparisNo").ToString();
            string urunTuru = gridView1.GetFocusedRowCellValue("TUR").ToString();
            string urunKodu = gridView1.GetFocusedRowCellValue("IGNEKOD").ToString();
            
            int urunID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            var igne = db.TBL_IGNELER.Find(urunID);
            int igneStok = (int)igne.STOK;
            int adet = (int)num_Adet.Value;
            int sipNo = int.Parse(siparisNo);
            var siparis = db.TBL_SIPARIS.Find(sipNo);


            
            if (date_Tarih.EditValue != null && adet <= igneStok)
            {


                TBL_SEVKIYAT yeniSevk = new TBL_SEVKIYAT();
                yeniSevk.URUNTUR = urunTuru;
                yeniSevk.URUNKOD = urunKodu;
                yeniSevk.ADET = adet;
                yeniSevk.SIPARISNO = siparisNo;
                yeniSevk.TARIH = date_Tarih.DateTime;
                yeniSevk.MUSTERI = gridView1.GetFocusedRowCellValue("Firma").ToString();
                yeniSevk.SEVKIYATTUR = "SİPARİŞ";

                db.TBL_SEVKIYAT.Add(yeniSevk);

                //add to listview
                string[] row = { siparisNo, urunTuru, urunKodu, adet.ToString() };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem).SubItems.AddRange(row);

                //Stoktan dusup urunleri tekrar listeleme
                igne.STOK -= adet;
                siparis.SEVKIYATSAYI += adet;
                DialogResult siradakiAsamaSorgu = MessageBox.Show("Seçilen Siparişin Sevkiyatı Bitti Mi ? ", "Sevkiyat Bitti Mi ?", MessageBoxButtons.YesNo);
                if (siradakiAsamaSorgu == DialogResult.Yes)
                {
                    siparis.AKTIF = false;
                }
                    //urunleriListele();

                }
            else
            {
                if (date_Tarih.EditValue == null)
                {

                    XtraMessageBox.Show("Lütfen Tarih Seçiniz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (adet > igneStok)
                {

                    XtraMessageBox.Show("Stokta Bulunandan Daha Fazla Ürün Sevkiyatı Yapamazsınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }

        }

        private void Btn_Yazdir_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Tamamla_Click(object sender, EventArgs e)
        {
            DialogResult siradakiAsamaSorgu = MessageBox.Show("Sevkiyatı Tamamlamak İstediğinize Emin Misiniz ? ", "Sevkiyat Onay", MessageBoxButtons.YesNo);
            if (siradakiAsamaSorgu == DialogResult.Yes)
            {
                db.SaveChanges();
                siparisListele();
            }
        }

        private void Btn_Iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
