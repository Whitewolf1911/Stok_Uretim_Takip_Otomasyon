﻿using DevExpress.XtraEditors;
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

        void firmaListele() {

            var firmalar = (from x in db.TBL_FIRMALAR
                            select new
                            {

                                Firma = x.FIRMAAD,
                                x.VERGIDAIRESI,
                                x.VERGINO

                            }).ToList().OrderBy(x => x.Firma);


            gridControl2.DataSource = firmalar;
            gridView2.Columns[1].Visible = false;
            gridView2.Columns[2].Visible = false;
            gridView2.Columns[0].AppearanceCell.BackColor = Color.Yellow;

        }
        bool isFound = false;
        void siparisListele()
        {
            int anyActive = db.TBL_SIPARIS.Where(x => x.AKTIF == true).Where(x => x.MUSTERI == secilenFirma).Count();


            if (anyActive > 0)
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

                                  }).ToList().Where(x => x.AKTIF == true).Where(x => x.Firma == secilenFirma).OrderBy(x => x.STOK);

                gridControl1.DataSource = siparisler;

                gridView1.Columns[1].Visible = false;
                gridView1.Columns[5].Visible = false;
                gridView1.Columns[7].Visible = false;
                gridView1.Columns[10].Visible = false;

                gridView1.Columns[0].AppearanceCell.BackColor = Color.LightGreen;
                gridView1.Columns[1].AppearanceCell.BackColor = Color.Cyan;
                gridView1.Columns[3].AppearanceCell.BackColor = Color.Turquoise;


                isFound = true;
                gridView1.BestFitColumns();


            }
            else { 
            
                    XtraMessageBox.Show("Seçtiğiniz Firmaya Ait Aktif Sipariş Bulunamadı . ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isFound = false;

            }


        }
        private void Frm_SiparisSevkiyat_Load(object sender, EventArgs e)
        {
            initListView();
            firmaListele();

            //siparisListele();
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
        string vergiNo = "";
        string vergiDaire = "";
        string tarih = "";
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
            vergiNo = gridView2.GetFocusedRowCellValue("VERGINO").ToString();
            vergiDaire = gridView2.GetFocusedRowCellValue("VERGIDAIRESI").ToString();
            tarih = date_Tarih.DateTime.ToString("dd/MM/yyyy");
            
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

                date_Tarih.Enabled = false;

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
            printPreviewDialog1.ShowDialog();
        }

        private void Btn_Tamamla_Click(object sender, EventArgs e)
        {
            DialogResult siradakiAsamaSorgu = MessageBox.Show("Sevkiyatı Tamamlamak İstediğinize Emin Misiniz ? ", "Sevkiyat Onay", MessageBoxButtons.YesNo);
            if (siradakiAsamaSorgu == DialogResult.Yes)
            {
                db.SaveChanges();
                siparisListele();
                XtraMessageBox.Show("Sevkiyat Tamamlandı", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Btn_Yazdir.PerformClick();
            }
        }

        private void Btn_Iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string secilenFirma;
        private void Btn_FirmaSec_Click(object sender, EventArgs e)
        {
            secilenFirma = gridView2.GetFocusedRowCellValue("Firma").ToString();
            siparisListele();
            if (isFound) { 

                Btn_FirmaSec.Enabled = false;
                Btn_SepeteEkle.Enabled = true;
                gridControl2.Enabled = false;

            }

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
        Font header = new Font("Verdana", 24, FontStyle.Bold);
        Font subHeader = new Font("Verdana", 14, FontStyle.Bold);
        Font content = new Font("Verdana", 12, FontStyle.Bold);
        Font arial = new Font("Arial", 12, FontStyle.Regular);
        SolidBrush sb = new SolidBrush(Color.Black);
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //PAGE
            StringFormat st = new StringFormat();
            st.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("SEVK İRSALİYESİ", header, sb, 450, 20, st);

            e.Graphics.DrawString("İrsaliye No              : _________________", content, sb, 420, 80, st);
            e.Graphics.DrawString("Düzenleme Tarihi    : _________________", content, sb, 420, 105, st);
            e.Graphics.DrawString("Fiili Sevk Tarihi       : _________________", content, sb, 420, 130, st);
            e.Graphics.DrawString("Fatura No                : _________________", content, sb, 420, 155, st);

            e.Graphics.DrawString("Sayın, ________________________________", content, sb, 10, 190, st);
            e.Graphics.DrawString("___________________________________", content, sb, 10, 220, st);
            e.Graphics.DrawString("T.C. Kimlik No: _____________________________", content, sb, 10, 255, st);
            e.Graphics.DrawString("Müşteri Vergi D. ve Hesap No.: _______________________________________", content, sb, 10, 290, st);

            e.Graphics.DrawString("Şehir  : _____________", content, sb, 600, 200, st);
            e.Graphics.DrawString("Ambar: _____________", content, sb, 600, 240, st);

            e.Graphics.DrawString("Sipariş No       ADET       ÜRÜN TİPİ      ÜRÜN KODU       FİYATI       TUTARI", subHeader, sb, 5, 325, st);
            e.Graphics.DrawString("__________________________________________________________________", subHeader, sb, 5, 330, st);

            e.Graphics.DrawString(vergiNo + "       " + vergiDaire, arial, sb, 325, 288, st);
            e.Graphics.DrawString(tarih, arial, sb, 620, 103, st);


            for (int i = 0; i < listView1.Items.Count; i++)
            {
                e.Graphics.DrawString(listView1.Items[i].SubItems[0].Text, arial, sb, 5, 360 + i * 35, st);
                e.Graphics.DrawString(listView1.Items[i].SubItems[3].Text, arial, sb, 170, 360 + i * 35, st);
                e.Graphics.DrawString(listView1.Items[i].SubItems[1].Text, arial, sb, 305, 360 + i * 35, st);
                e.Graphics.DrawString(listView1.Items[i].SubItems[2].Text, arial, sb, 440, 360 + i * 35, st);

                e.Graphics.DrawString("_____________________________________________________________________", content, sb, 5, 362 + i * 35, st);
            }
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(gridView2.GetFocusedRowCellValue("Firma") != null) { txt_firma.Text = gridView2.GetFocusedRowCellValue("Firma").ToString(); }
        }
    }
}
