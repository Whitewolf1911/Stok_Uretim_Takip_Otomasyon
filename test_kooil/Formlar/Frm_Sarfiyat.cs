using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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
    public partial class Frm_Sarfiyat : Form
    {
        public Frm_Sarfiyat()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();

        void listele() {
            try
            {
                var veriler = (from x in db.TBL_SIPARIS
                               select new
                               {
                                   Tür = x.TBL_IGNELER.TUR,
                                   ÜrünKodu = x.TBL_IGNELER.IGNEKOD,
                                   Ham = x.TBL_IGNELER.HAMMADDETIPI,
                                   Sipariş = x.URUNADETI,
                                   Preslenen = x.PRESSAYI,
                                   Sarfiyat = x.TBL_IGNELER.SARFIYATORAN,
                                   x.AKTIF


                               }).ToList().Where(x => x.AKTIF == true).OrderBy(x => x.Tür);

                gridControl1.DataSource = veriler;
                gridView1.Columns[2].Visible = false;
                gridView1.Columns[6].Visible = false;
                gridView1.Columns[5].Visible = false;
            }
            catch (Exception) { }



            gridView1.BestFitColumns();
           // gridView1.Columns[7].GroupIndex = 1;

        }
        private void Frm_Sarfiyat_Load(object sender, EventArgs e)
        {
            try
            {
                XtraMessageBox.Show("En Son Kullanılan Hammaddelerin Sistemden Azaltıldığına Emin Olun !", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listele();
                GridColumn unbColumn = gridView1.Columns.AddField("Hammadde");
                unbColumn.VisibleIndex = gridView1.Columns.Count;
                unbColumn.UnboundType = DevExpress.Data.UnboundColumnType.String;
                unbColumn.OptionsColumn.AllowEdit = false;
                unbColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                unbColumn.AppearanceCell.BackColor = Color.LemonChiffon;

                GridColumn unbColumn2 = gridView1.Columns.AddField("TahminiKalanHarcamaKG");
                unbColumn2.VisibleIndex = gridView1.Columns.Count;
                unbColumn2.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
                unbColumn2.OptionsColumn.AllowEdit = false;
                unbColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                unbColumn2.AppearanceCell.BackColor = Color.Yellow;
                gridView1.BestFitColumns();
                gridView1.Columns[7].GroupIndex = 1;
            }
            catch (Exception) { }

        }

        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            GridView view = sender as GridView;
            GridView view2 = sender as GridView;

            if (e.Column.FieldName == "Hammadde" && e.IsGetData) e.Value =
              getHammadde(view, e.ListSourceRowIndex);

            if (e.Column.FieldName == "TahminiKalanHarcamaKG" && e.IsGetData) e.Value =
              tahminHarcama(view2, e.ListSourceRowIndex);
        }

        string getHammadde(GridView view, int listSourceRowIndex)
        {
            int hamID = Convert.ToInt32(view.GetListSourceRowCellValue(listSourceRowIndex, "Ham"));
            var ham = db.TBL_HAMMADDE.Find(hamID);
            string hamTur = ham.KALINLIK.ToString() + " x " + ham.GENISLIK.ToString() + " " + ham.OZELLIK.ToString() + " " + ham.MENSEI.ToString();
            return hamTur;
        }

        int tahminHarcama(GridView view, int listSourceRowIndex)
        {
            int sarfiyat = Convert.ToInt32(view.GetListSourceRowCellValue(listSourceRowIndex, "Sarfiyat"));
            int siparis = Convert.ToInt32(view.GetListSourceRowCellValue(listSourceRowIndex, "Sipariş"));
            int preslenen = Convert.ToInt32(view.GetListSourceRowCellValue(listSourceRowIndex, "Preslenen"));
            int kalan = siparis - preslenen;
            if(kalan < 0) { kalan = 0; };

            int ihtiyac = (sarfiyat * kalan) / 1000;
            return ihtiyac;

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (gridView1.GetFocusedRowCellValue("Ham") != null && gridView1.GetFocusedRowCellValue("Preslenen") != null &&
                gridView1.GetFocusedRowCellValue("Sipariş") != null && gridView1.GetFocusedRowCellValue("TahminiKalanHarcamaKG") != null)
                {
                    int hamID = int.Parse(gridView1.GetFocusedRowCellValue("Ham").ToString());
                    var ham = db.TBL_HAMMADDE.Find(hamID);
                    string hamTur = ham.KALINLIK.ToString() + " x " + ham.GENISLIK.ToString() + " " + ham.OZELLIK.ToString() + " " + ham.MENSEI.ToString();



                    txt_ham.Text = hamTur;

                    int toplamKalanPres = 0;
                    int ihtiyac = 0;
                    for (int i = 0; i <= gridView1.DataRowCount; i++)
                    {
                        if (gridView1.GetRowCellValue(i, "Ham") != null)
                        {
                            if ((int)gridView1.GetRowCellValue(i, "Ham") == hamID)
                            {
                                if (gridView1.GetRowCellValue(i, "Sipariş") != null && gridView1.GetRowCellValue(i, "Preslenen") != null)
                                {
                                    toplamKalanPres += (int)gridView1.GetRowCellValue(i, "Sipariş") - (int)gridView1.GetRowCellValue(i, "Preslenen");
                                }
                            }
                        }
                    }

                    for (int i = 0; i <= gridView1.DataRowCount; i++)
                    {
                        if (gridView1.GetRowCellValue(i, "Ham") != null)
                        {
                            if ((int)gridView1.GetRowCellValue(i, "Ham") == hamID)
                            {
                                if (gridView1.GetRowCellValue(i, "TahminiKalanHarcamaKG") != null)
                                {
                                    ihtiyac += (int)gridView1.GetRowCellValue(i, "TahminiKalanHarcamaKG");
                                }
                            }
                        }
                    }

                    txt_pres.Text = toplamKalanPres.ToString();
                    txt_ihtiyac.Text = ihtiyac.ToString();
                    txt_stok.Text = ham.MIKTAR.ToString();

                    int fark = (int)ham.MIKTAR - ihtiyac;
                    string durum = "";
                    txt_fark.Text = fark.ToString();

                    if (fark <= 0)
                    {
                        durum = "Yetersiz Hammadde ! Hammadde Siparişi Veriniz.";
                        txt_durum.Text = durum;
                        txt_durum.BackColor = Color.Red;
                    }
                    else if (fark < 80 && fark > 0)
                    {
                        durum = "Hammadde Kritik Seviyede. Hammadde Yetersiz Gelebilir.";
                        txt_durum.Text = durum;
                        txt_durum.BackColor = Color.Orange;
                    }

                    else
                    {
                        durum = "Hammadde Yeterli Seviyede ";
                        txt_durum.Text = durum;
                        txt_durum.BackColor = Color.LightGreen;
                    }
                }
            }
            catch (Exception) { }
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
    }
}
