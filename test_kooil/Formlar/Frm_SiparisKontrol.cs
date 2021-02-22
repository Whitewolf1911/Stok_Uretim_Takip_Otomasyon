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
        void listele() {
            gridControl1.ForceInitialize();
            var veriler = (from x in db.TBL_SIPARIS
                           select new
                           {
                               SiparisNo = x.SIPARISNOID,
                               x.MUSTERI,
                               x.TBL_IGNELER.IGNEKOD,
                               x.URUNADETI,
                               x.SIPARISTARIHI,
                               x.ISTENILENTARIH,
                               x.TOPLAMTUTAR,
                               x.AKTIF,
                               x.NOTLAR,
                               x.SIPARISASAMASI


                           }).ToList().OrderByDescending(x => x.SiparisNo);

            gridControl1.DataSource = veriler.Where(x => x.AKTIF == true);
            //GridColumn unbColumn = gridView1.Columns.AddField("Siparis Asamasi");
            //unbColumn.VisibleIndex = gridView1.Columns.Count;
            //unbColumn.OptionsColumn.AllowEdit = false;
            //unbColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            //unbColumn.DisplayFormat.FormatString = "c";
            //unbColumn.AppearanceCell.BackColor = Color.LemonChiffon;

            // Returns the total amount for a specific row.
           



        }
        // Provides data for the Total column.
        //string durumuYazdir(GridView view, int listSourceRowIndex)
        //{
        //    var asamaDurumu = Convert.ToInt32(view.GetListSourceRowCellValue(listSourceRowIndex, "SIPARISASAMASI"));
        //    if (asamaDurumu == 1)
        //    {
        //        return "Urunler Preste";
        //    }
        //    else
        //    {
        //        return "x";
        //    }
        //}
        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {

        }
        private void Frm_SiparisKontrol_Load(object sender, EventArgs e)
        {
            listele();
            
            //GridColumn unbColumn = gridView1.Columns.AddField("Siparis Asamasi");
            //unbColumn.VisibleIndex = gridView1.Columns.Count;
            //unbColumn.OptionsColumn.AllowEdit = false;
            //unbColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            //unbColumn.DisplayFormat.FormatString = "c";
            //unbColumn.AppearanceCell.BackColor = Color.LemonChiffon;
        }
        //private void gridView1_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        //{
        //    GridView view = sender as GridView;
        //    if (e.Column.FieldName == "Siparis Asamasi" && e.IsGetData) e.Value =
        //      durumuYazdir(view, e.ListSourceRowIndex);
        //}
    }
}
