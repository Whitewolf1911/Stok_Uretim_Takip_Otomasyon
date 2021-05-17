using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
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
    public partial class Frm_SiparisKontrol : Form
    {
        public Frm_SiparisKontrol()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();
        Frm_Sarfiyat frmSarfiyat; 
        void listele() {
            try
            {
                var veriler = (from x in db.TBL_SIPARIS
                               select new
                               {
                                   SiparişNo = x.SIPARISNOID,
                                   Müşteri = x.MUSTERI,
                                   ÜrünKodu = x.TBL_IGNELER.IGNEKOD,
                                   SiparişAdet = x.URUNADETI,
                                   SiparişTarihi = x.SIPARISTARIHI,
                                   İstenilenTarih = x.ISTENILENTARIH,
                                   x.AKTIF,
                                   Not = x.NOTLAR,
                                   x.SIPARISASAMASI

                               }).ToList().OrderByDescending(x => x.SiparişNo);

                gridControl1.DataSource = veriler.Where(x => x.AKTIF == true);

                //renklendirmeler ve sutun gizlemeler
                gridView1.Columns[1].AppearanceCell.BackColor = Color.LightYellow;
                gridView1.Columns[2].AppearanceCell.BackColor = Color.Aquamarine;
                gridView1.Columns[3].AppearanceCell.BackColor = Color.Yellow;
                gridView1.Columns[4].AppearanceCell.BackColor = Color.Cyan;
                gridView1.Columns[5].AppearanceCell.BackColor = Color.LightYellow;


                gridView1.Columns[6].Visible = false;
                gridView1.Columns[8].Visible = false;
            }
            catch (Exception) { }

        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            listele();
        }
       
        private void Frm_SiparisKontrol_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {
        }

        private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            try {
                if (gridView1.GetFocusedRowCellValue("SiparişAdet") != null) { txt_adet.Text = gridView1.GetFocusedRowCellValue("SiparişAdet").ToString(); }
                if (gridView1.GetFocusedRowCellValue("Müşteri") != null) { txt_musteri.Text = gridView1.GetFocusedRowCellValue("Müşteri").ToString(); }
                if (gridView1.GetFocusedRowCellValue("ÜrünKodu") != null) { txt_sipIgneTur.Text = gridView1.GetFocusedRowCellValue("ÜrünKodu").ToString(); }
                if (gridView1.GetFocusedRowCellValue("SiparişNo") != null) { txt_sipNo.Text = gridView1.GetFocusedRowCellValue("SiparişNo").ToString(); }
                if (gridView1.GetFocusedRowCellValue("Not") != null) { txt_sipNot.Text = gridView1.GetFocusedRowCellValue("Not").ToString(); }
                if (gridView1.GetFocusedRowCellValue("SIPARISASAMASI") != null)
                {

                    int asamaDeger = int.Parse(gridView1.GetFocusedRowCellValue("SIPARISASAMASI").ToString());

                    //if (asamaDeger == 0) { txt_asama.Text = "Pres Bekleniyor"; }
                    //else if (asamaDeger == 1) { txt_asama.Text = "Preste"; }
                    //else if (asamaDeger == 2){ txt_asama.Text = "Arka Sıyırmada";}
                    //else if (asamaDeger == 3) { txt_asama.Text = "Yol Kopyalamada";}
                    //else if (asamaDeger == 4)  { txt_asama.Text = "Uç Sıyırmada"; }
                    //else if (asamaDeger == 5) { txt_asama.Text = "Kanal Açmada"; }
                    //else if (asamaDeger == 6) { txt_asama.Text = "Kanal Büyütmede"; }
                    //else if (asamaDeger == 7) { txt_asama.Text = "Polisaj1 de"; }
                    //else if (asamaDeger == 8) { txt_asama.Text = "Dil Çakmada"; }
                    //else if (asamaDeger == 9) { txt_asama.Text = "Polisaj2 de"; }
                    //else if (asamaDeger == 10) { txt_asama.Text = "Isıl İşlemde"; }
                    //else if (asamaDeger == 11) { txt_asama.Text = "Temperde"; }
                    //else if (asamaDeger == 12) { txt_asama.Text = "Yıkamada"; }
                    //else if (asamaDeger == 13) { txt_asama.Text = "Bilemede"; }
                    //else if (asamaDeger == 14) { txt_asama.Text = "Kontrolde"; }

                    switch (asamaDeger)
                    {
                        case 0:
                            txt_asama.Text = "Pres Bekleniyor";
                            break;
                        case 1:
                            txt_asama.Text = "Preste";
                            break;
                        case 2:
                            txt_asama.Text = "Arka Sıyırmada";
                            break;
                        case 3:
                            txt_asama.Text = "Yol Kopyalamada";
                            break;
                        case 4:
                            txt_asama.Text = "Uç Sıyırmada";
                            break;
                        case 5:
                            txt_asama.Text = "Kanal Açmada";
                            break;
                        case 6:
                            txt_asama.Text = "Kanal Büyütmede";
                            break;
                        case 7:
                            txt_asama.Text = "Polisaj1 de";
                            break;
                        case 8:
                            txt_asama.Text = "Dil Çakmada";
                            break;
                        case 9:
                            txt_asama.Text = "Polisaj2 de";
                            break;
                        case 10:
                            txt_asama.Text = "Gerilim Gidermede";
                            break;
                        case 11:
                            txt_asama.Text = "Isıl İşlemde";
                            break;
                        case 12:
                            txt_asama.Text = "Temperde";
                            break;
                        case 13:
                            txt_asama.Text = "Yıkamada";
                            break;
                        case 14:
                            txt_asama.Text = "Bilemede";
                            break;
                        case 15:
                            txt_asama.Text = "Kontrolde";
                            break;
                    }
                }
            }
            catch (Exception) { }

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {
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

        private void Btn_Sarfiyat_Click(object sender, EventArgs e)
        {
            if (frmSarfiyat == null || frmSarfiyat.IsDisposed)
            {
                frmSarfiyat = new Frm_Sarfiyat();
                frmSarfiyat.Show();
            }
        }
    }
}


