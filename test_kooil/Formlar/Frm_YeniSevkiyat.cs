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
            try
            {
                var firmalar = (from x in db.TBL_FIRMALAR
                                select new
                                {
                                    Firma = x.FIRMAAD,
                                    FirmaAd = x.FIRMATAMAD,
                                    VergiNo = x.VERGINO,
                                    VergiDairesi = x.VERGIDAIRESI


                                }).ToList().OrderBy(x => x.Firma);

                gridControl2.DataSource = firmalar;
                gridView2.Columns[2].Visible = false;
                gridView2.Columns[3].Visible = false;
                gridView2.Columns[1].Visible = false;
            }
            catch (Exception) { }

        }
        void urunleriListele() {
            try
            {
                var urunler = (from x in db.TBL_IGNELER
                               select new
                               {

                                   Tür = x.TUR,
                                   ÜrünKodu = x.IGNEKOD,
                                   Stok = x.STOK,
                                   x.FOTO,
                                   x.ID
                               }
                               ).ToList().OrderByDescending(x => x.Stok);

                gridControl1.DataSource = urunler;
                gridView1.Columns[3].Visible = false;
                gridView1.Columns[4].Visible = false;

                gridView1.Columns[0].AppearanceCell.BackColor = Color.LightGreen;
                gridView1.Columns[1].AppearanceCell.BackColor = Color.Cyan;
                gridView1.Columns[2].AppearanceCell.BackColor = Color.Yellow;
            }
            catch (Exception) { }

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
            listView1.Columns.Add("Adet");
            listView1.Columns.Add("Kod");
            listView1.Columns.Add("Tür");
            listView1.View = View.Details;
        }
        string vergiNo = "";
        string vergiDaire = "";
        string tarih = "";
        private void Btn_SepeteEkle_Click(object sender, EventArgs e)
        {
            try
            {
                string urunTuru = gridView1.GetFocusedRowCellValue("Tür").ToString();
                string urunKodu = gridView1.GetFocusedRowCellValue("ÜrünKodu").ToString();
                int urunID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                vergiNo = gridView2.GetFocusedRowCellValue("VergiNo").ToString();
                vergiDaire = gridView2.GetFocusedRowCellValue("VergiDairesi").ToString();

                var igne = db.TBL_IGNELER.Find(urunID);
                int igneStok = (int)igne.STOK;
                int adet = (int)num_Adet.Value;
                var anyActive = db.TBL_SIPARIS.Where(x => x.AKTIF == true).Where(y => y.TBL_IGNELER.IGNEKOD == urunKodu).Count();

                tarih = date_Tarih.DateTime.ToString("dd/MM/yyyy");
                if (date_Tarih.EditValue != null)
                {
                    date_Tarih.Enabled = false;

                }
                //ADD TO TBL_SEVKIYAT
                if (date_Tarih.EditValue != null && adet <= igneStok)
                {
                    if (anyActive > 0)
                    {

                        DialogResult siradakiAsamaSorgu = MessageBox.Show("Seçtiğiniz Üründen Sevkiyat Bekleyen Aktif Sipariş Var. Devam Etmek İstediğinize Emin misiniz ? ", "Uyarı !", MessageBoxButtons.YesNo);
                        if (siradakiAsamaSorgu == DialogResult.Yes)
                        {

                            TBL_SEVKIYAT yeniSevk = new TBL_SEVKIYAT();
                            yeniSevk.URUNTUR = urunTuru;
                            yeniSevk.URUNKOD = urunKodu;
                            yeniSevk.ADET = adet;
                            yeniSevk.TARIH = date_Tarih.DateTime;
                            yeniSevk.MUSTERI = gridView2.GetFocusedRowCellValue("Firma").ToString();
                            yeniSevk.SEVKIYATTUR = "PERAKENDE";
                            yeniSevk.PARTINO = num_partiNo.Value.ToString();
                            yeniSevk.BARKOD = txt_barkod.Text;
                            db.TBL_SEVKIYAT.Add(yeniSevk);

                            //add to listview
                            string[] row = { adet.ToString(), urunTuru, urunKodu };
                            var listViewItem = new ListViewItem(row);
                            listView1.Items.Add(listViewItem).SubItems.AddRange(row);

                            //Stoktan dusup urunleri tekrar listeleme
                            igne.STOK -= adet;
                            //urunleriListele();
                            Btn_Tamamla.Enabled = true;

                        }

                    }
                    else
                    {
                        TBL_SEVKIYAT yeniSevk = new TBL_SEVKIYAT();
                        yeniSevk.URUNTUR = urunTuru;
                        yeniSevk.URUNKOD = urunKodu;
                        yeniSevk.ADET = adet;
                        yeniSevk.TARIH = date_Tarih.DateTime;
                        yeniSevk.MUSTERI = gridView2.GetFocusedRowCellValue("Firma").ToString();
                        yeniSevk.SEVKIYATTUR = "PERAKENDE";
                        yeniSevk.BARKOD = txt_barkod.Text;

                        yeniSevk.PARTINO = num_partiNo.Value.ToString();

                        db.TBL_SEVKIYAT.Add(yeniSevk);

                        //add to listview
                        string[] row = { adet.ToString(), urunTuru, urunKodu };
                        var listViewItem = new ListViewItem(row);
                        listView1.Items.Add(listViewItem).SubItems.AddRange(row);

                        //Stoktan dusup urunleri tekrar listeleme
                        igne.STOK -= adet;
                        //urunleriListele();
                        Btn_Tamamla.Enabled = true;


                    }


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
            catch (Exception) { }
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
            Btn_firmaSec.Enabled = true;
            if (gridView2.GetFocusedRowCellValue("Firma") != null) { txt_firma.Text = gridView2.GetFocusedRowCellValue("Firma").ToString(); }
        }

        private void Btn_Iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Tamamla_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult siradakiAsamaSorgu = MessageBox.Show("Sevkiyatı Tamamlamak İstediğinize Emin Misiniz ? ", "Sevkiyat Onay", MessageBoxButtons.YesNo);
                if (siradakiAsamaSorgu == DialogResult.Yes)
                {
                    db.SaveChanges();
                    urunleriListele();
                    XtraMessageBox.Show("Sevkiyat Tamamlandı", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Btn_Yazdir.PerformClick();

                }
            }
            catch (Exception) { }
        }
        Font header = new Font("Verdana", 24, FontStyle.Bold);
        Font subHeader = new Font("Verdana", 14, FontStyle.Bold);
        Font content = new Font("Verdana", 12, FontStyle.Bold);
        Font arial = new Font("Arial", 12, FontStyle.Regular);
        SolidBrush sb = new SolidBrush(Color.Black);


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {   //PAGE
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

            e.Graphics.DrawString("ADET         ÜRÜN TİPİ        ÜRÜN KODU         FİYATI         TUTARI", subHeader, sb, 50, 325, st);
            e.Graphics.DrawString("__________________________________________________________________", subHeader, sb, 5, 330, st);

            e.Graphics.DrawString(vergiNo + "       " + vergiDaire, arial, sb, 325, 288, st);
            e.Graphics.DrawString(tarih, arial, sb, 620, 103, st);


            for (int i =0; i< listView1.Items.Count; i++)
            {
                e.Graphics.DrawString(listView1.Items[i].SubItems[0].Text, arial, sb, 55, 360 + i * 35, st);
                e.Graphics.DrawString(listView1.Items[i].SubItems[1].Text, arial, sb, 200, 360 + i * 35, st);
                e.Graphics.DrawString(listView1.Items[i].SubItems[2].Text, arial, sb, 350, 360 + i * 35, st);
                e.Graphics.DrawString("_____________________________________________________________________", content, sb, 5, 362 + i*35, st);
            }




        }

        private void Btn_Yazdir_Click(object sender, EventArgs e)
        {

            //if (printDialog1.ShowDialog() == DialogResult.OK) {

            //    printDocument1.Print();
            //}

            printPreviewDialog1.ShowDialog();
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {
        }

        private void Btn_firmaSec_Click(object sender, EventArgs e)
        {
            gridControl2.Enabled = false;
            Btn_SepeteEkle.Enabled = true;
            Btn_firmaSec.Enabled = false;
        }

        private void pic_Urun_DoubleClick(object sender, EventArgs e)
        {
            if (pic_Urun.Image != null)
            {
                Form frm = new Form();
                PictureBox pb = new PictureBox();
                pb.Image = pic_Urun.Image;
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Dock = DockStyle.Fill;
                frm.Controls.Add(pb);
                frm.WindowState = FormWindowState.Maximized;
                frm.ShowDialog();
            }
        }
    }
}
