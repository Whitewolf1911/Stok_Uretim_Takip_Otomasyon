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
    public partial class Frm_SiparisDurumKontrol : Form
    {
        public Frm_SiparisDurumKontrol()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();
        void listele()
        {
            var veriler = (from x in db.TBL_SIPARIS
                           select new
                           {
                               SiparisNo = x.SIPARISNOID,
                               x.MUSTERI,
                               x.TBL_IGNELER.IGNEKOD,
                               İstenilenAdet = x.URUNADETI,
                               SiparişTarihi = x.SIPARISTARIHI,
                               İstenilenTarih =x.ISTENILENTARIH,
                               x.TOPLAMTUTAR,
                               Pres = x.PRESSAYI,
                               ArkaSıyırma = x.ARKASIYIRSAYI,
                               YolKopyalama=x.YOLKOPYASAYI,
                               UçSıyırma =x.UCSIYIRMASAYI,
                               KanalAçma = x.KANALACMASAYI,
                               KanalBüyütme = x.KANALBUYUTSAYI,
                               Polisaj1 = x.POLI1SAYI,
                               DilÇakma = x.DILCAKMASAYI,
                               Polisaj2 = x.POLI2SAYI,
                               Isılİşlem = x.ISILISLEMSAYI,
                               Temper = x.TEMPERSAYI,
                               Yıkama = x.YIKAMASAYI,
                               Bileme = x.BILEMESAYI,
                               Paketlenen = x.KONTROLSAYI,
                               x.AKTIF,
                               x.NOTLAR,
                               x.SIPARISASAMASI

                           }).ToList().OrderByDescending(x => x.SiparisNo);

            gridControl1.DataSource = veriler.Where(x => x.AKTIF == true);

            //renklendirmeler ve sutun gizlemeler
            gridView1.Columns[1].AppearanceCell.BackColor = Color.Green;
            gridView1.Columns[2].AppearanceCell.BackColor = Color.Aquamarine;
            gridView1.Columns[3].AppearanceCell.BackColor = Color.Orange;
            gridView1.Columns[4].AppearanceCell.BackColor = Color.Cyan;
            gridView1.Columns[5].AppearanceCell.BackColor = Color.OrangeRed;
            gridView1.Columns[20].AppearanceCell.BackColor = Color.LightGreen;

            gridView1.Columns[0].Visible = false;
            gridView1.Columns[4].Visible = false;
            gridView1.Columns[5].Visible = false;
            gridView1.Columns[6].Visible = false;
            gridView1.Columns[21].Visible = false;
            gridView1.Columns[22].Visible = false;
            gridView1.Columns[23].Visible = false;
            //
            





        }
        int getTotalValue(GridView view, int listSourceRowIndex)
        {
            int pressayi = Convert.ToInt32(view.GetListSourceRowCellValue(listSourceRowIndex, "Pres"));
            int kontrolsayi = Convert.ToInt32(view.GetListSourceRowCellValue(listSourceRowIndex, "Paketlenen"));

            return pressayi - kontrolsayi;
        }

        private void gridView1_CustomUnboundColumnData_1(object sender, CustomColumnDataEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Column.FieldName == "AraUrun" && e.IsGetData) e.Value =
              getTotalValue(view, e.ListSourceRowIndex);
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void Frm_SiparisDurumKontrol_Load(object sender, EventArgs e)
        {
            
            listele();
            GridColumn unbColumn = gridView1.Columns.AddField("AraUrun");
            unbColumn.VisibleIndex = gridView1.Columns.Count;
            unbColumn.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            unbColumn.OptionsColumn.AllowEdit = false;
            unbColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            unbColumn.AppearanceCell.BackColor = Color.LemonChiffon;
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

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
