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
    public partial class Frm_HataDuzeltme : Form
    {
        public Frm_HataDuzeltme()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();
        Frm_HamRaporDuzenle frmHamDuzenle;
        Frm_HataliRaporSil frmRaporDuzenle;
        Frm_UrunStokDuzenle frmUrunStokDuzenle;
        Frm_SevkiyatSil frmSevkSil;
        Frm_SipaktifEt frmSipAktifEt;
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
                               SiparişAdet=x.URUNADETI,
                               x.YIKAMASAYI,
                               x.YOLKOPYASAYI,
                               

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
            //gridView1.Columns[20].Visible = false;
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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            num_ArkaSiyirma.Value = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("ARKASIYIRSAYI"));
            num_bileme.Value = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("BILEMESAYI"));
            num_dilCakma.Value = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("DILCAKMASAYI"));
            num_IsilIslem.Value = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("ISILISLEMSAYI"));
            num_KanalAcma.Value = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("KANALACMASAYI"));
            num_KanalBuyut.Value = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("KANALBUYUTSAYI"));
            num_kontrol.Value = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("KONTROLSAYI"));
            num_Polisaj1.Value = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("POLI1SAYI"));
            num_Polisaj2.Value = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("POLI2SAYI"));
            num_Pres.Value = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("PRESSAYI"));
            num_SevkEdilen.Value = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("SEVKIYATSAYI"));
            num_Siparis.Value = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("SiparişAdet"));
            num_temper.Value = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("TEMPERSAYI"));
            num_ucSiyirma.Value = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("UCSIYIRMASAYI"));
            num_yikama.Value = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("YIKAMASAYI"));
            num_YolKopyala.Value = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("YOLKOPYASAYI"));
            date_siparis.DateTime = (DateTime)gridView1.GetFocusedRowCellValue("SiparişTarih");
            dateEdit2.DateTime = (DateTime)gridView1.GetFocusedRowCellValue("İstenilenTarih");

            if (gridView1.GetFocusedRowCellValue("NOTLAR") != null) {
                txt_not.Text = gridView1.GetFocusedRowCellValue("NOTLAR").ToString();
            }

        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            DialogResult Sorgu = MessageBox.Show("Seçilen Siparişi Güncellemek İstediğinize Emin Misiniz ? .", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Sorgu == DialogResult.Yes)
            {
                var sipID = (int)gridView1.GetFocusedRowCellValue("SiparişNo");

                var sip = db.TBL_SIPARIS.Find(sipID);

                sip.ARKASIYIRSAYI = (int)num_ArkaSiyirma.Value;
                sip.BILEMESAYI = (int)num_bileme.Value;
                sip.DILCAKMASAYI = (int)num_dilCakma.Value;
                sip.ISILISLEMSAYI = (int)num_IsilIslem.Value;
                sip.ISTENILENTARIH = dateEdit2.DateTime;
                sip.KANALACMASAYI = (int)num_KanalAcma.Value;
                sip.KANALBUYUTSAYI = (int)num_KanalBuyut.Value;
                sip.KONTROLSAYI = (int)num_kontrol.Value;
                sip.NOTLAR = txt_not.Text;
                sip.POLI1SAYI = (int)num_Polisaj1.Value;
                sip.POLI2SAYI = (int)num_Polisaj2.Value;
                sip.PRESSAYI = (int)num_Pres.Value;
                sip.SEVKIYATSAYI = (int)num_SevkEdilen.Value;
                sip.SIPARISTARIHI = date_siparis.DateTime;
                sip.TEMPERSAYI = (int)num_temper.Value;
                sip.UCSIYIRMASAYI = (int)num_ucSiyirma.Value;
                sip.URUNADETI = (int)num_Siparis.Value;
                sip.YIKAMASAYI = (int)num_yikama.Value;
                sip.YOLKOPYASAYI = (int)num_YolKopyala.Value;

                db.SaveChanges();
                XtraMessageBox.Show("Seçilen Sipariş Güncellendi", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sipListele();
                
            }

        }

        private void Btn_SiparisSil_Click(object sender, EventArgs e)
        {
            DialogResult Sorgu = MessageBox.Show("Seçilen Siparişi Silmek İstediğinize Emin Misiniz ? Bu İşlem Geri Alınamaz !", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Sorgu == DialogResult.Yes)
            {
                var sipID = (int)gridView1.GetFocusedRowCellValue("SiparişNo");

                var sip = db.TBL_SIPARIS.Find(sipID);
                db.TBL_SIPARIS.Remove(sip);
                db.SaveChanges();
                XtraMessageBox.Show("Seçilen Sipariş Sistemden Silindi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sipListele();

            }
        }

        private void Btn_hamRapSil_Click(object sender, EventArgs e)
        {
            if (frmHamDuzenle == null || frmHamDuzenle.IsDisposed)
            {
                frmHamDuzenle = new Frm_HamRaporDuzenle();
                frmHamDuzenle.Show();
            }
        }

        private void Btn_RaporSil_Click(object sender, EventArgs e)
        {
            if (frmRaporDuzenle == null || frmRaporDuzenle.IsDisposed)
            {
                frmRaporDuzenle = new Frm_HataliRaporSil();
                frmRaporDuzenle.Show();
            }
        }

        private void Btn_urunStokDuzen_Click(object sender, EventArgs e)
        {
            if (frmUrunStokDuzenle == null || frmUrunStokDuzenle.IsDisposed)
            { 
                frmUrunStokDuzenle = new Frm_UrunStokDuzenle();
                frmUrunStokDuzenle.Show();
            }
        }

        private void Btn_SevkiyatSil_Click(object sender, EventArgs e)
        {
            if (frmSevkSil == null || frmSevkSil.IsDisposed)
            {
                frmSevkSil = new Frm_SevkiyatSil();
                frmSevkSil.Show();
            }
        }

        private void Btn_sipAktifEt_Click(object sender, EventArgs e)
        {
            
            if (frmSipAktifEt == null || frmSipAktifEt.IsDisposed)
            {
                frmSipAktifEt = new Frm_SipaktifEt();
                frmSipAktifEt.Show();
            }
        }
    }
}
