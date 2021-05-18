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
    public partial class Frm_UretimDetay : Form
    {
        public Frm_UretimDetay()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();

        void listele()
        {
            try
            {
                var veriler = (from x in db.TBL_SIPARIS
                               select new
                               {
                                   SiparisNo = x.SIPARISNOID,
                                   PartiNo = x.PARTINO,
                                   Müşteri = x.MUSTERI,
                                   UrunTuru = x.TBL_IGNELER.TUR,
                                   UrunKodu = x.TBL_IGNELER.IGNEKOD,
                                   Siparis = x.URUNADETI,
                                   SiparisTarihi = x.SIPARISTARIHI,
                                   IstenilenTarih = x.ISTENILENTARIH,
                                   Pres = x.PRESSAYI,
                                   ArkaSıyırma = x.ARKASIYIRSAYI,
                                   YolKopyalama = x.YOLKOPYASAYI,
                                   UçSıyırma = x.UCSIYIRMASAYI,
                                   KanalAçma = x.KANALACMASAYI,
                                   KanalBüyütme = x.KANALBUYUTSAYI,
                                   Polisaj1 = x.POLI1SAYI,
                                   DilÇakma = x.DILCAKMASAYI,
                                   Polisaj2 = x.POLI2SAYI,
                                   GerilimGiderme = x.GERILIMGIDERMESAYI,
                                   Isılİşlem = x.ISILISLEMSAYI,
                                   Temper = x.TEMPERSAYI,
                                   Yıkama = x.YIKAMASAYI,
                                   Bileme = x.BILEMESAYI,
                                   Paketlenen = x.KONTROLSAYI,
                                   Giden = x.SEVKIYATSAYI,
                                   x.AKTIF,
                                   x.NOTLAR,
                                   x.SIPARISASAMASI

                               }).ToList().OrderByDescending(x => x.SiparisNo);

                gridControl1.DataSource = veriler.Where(x => x.AKTIF == false);

                //renklendirmeler ve sutun gizlemeler
                gridView1.Columns[1].AppearanceCell.BackColor = Color.Green;
                gridView1.Columns[2].AppearanceCell.BackColor = Color.Aquamarine;
                gridView1.Columns[3].AppearanceCell.BackColor = Color.LightGreen;
                gridView1.Columns[4].AppearanceCell.BackColor = Color.Cyan;
                gridView1.Columns[5].AppearanceCell.BackColor = Color.LightYellow;
                gridView1.Columns[6].AppearanceCell.BackColor = Color.Aquamarine;
                gridView1.Columns[21].AppearanceCell.BackColor = Color.Yellow;
                gridView1.Columns[22].AppearanceCell.BackColor = Color.LightGreen;



                gridView1.Columns[24].Visible = false;
                gridView1.Columns[25].Visible = false;
                gridView1.Columns[26].Visible = false;
            }
            catch (Exception) { }
            //
        }
        private void Frm_UretimDetay_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            listele();
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

        private void Btn_Yazdir_Click(object sender, EventArgs e)
        {
            ShowGridPreview(gridControl1);
            PrintGrid(gridControl1);
        }

        private void txt_musteri_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("SiparisNo") != null) { txt_sipNo.Text = gridView1.GetFocusedRowCellValue("SiparisNo").ToString(); }
            if (gridView1.GetFocusedRowCellValue("UrunTuru") != null) { txt_sipUrunTip.Text = gridView1.GetFocusedRowCellValue("UrunTuru").ToString(); }
            if (gridView1.GetFocusedRowCellValue("UrunKodu") != null) { txt_sipUrunKod.Text = gridView1.GetFocusedRowCellValue("UrunKodu").ToString(); }
            if (gridView1.GetFocusedRowCellValue("Müşteri") != null) { txt_musteri.Text = gridView1.GetFocusedRowCellValue("Müşteri").ToString(); }
            if (gridView1.GetFocusedRowCellValue("SiparisTarihi") != null) { date_sipTarih.EditValue =  gridView1.GetFocusedRowCellValue("SiparisTarihi"); }
            if (gridView1.GetFocusedRowCellValue("IstenilenTarih") != null) { date_Ist_tarih.EditValue = gridView1.GetFocusedRowCellValue("IstenilenTarih"); }
            if (gridView1.GetFocusedRowCellValue("Giden") != null) { txt_paketlenen.Text = gridView1.GetFocusedRowCellValue("Giden").ToString(); }


        }
    }
}
