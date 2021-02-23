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

            //renklendirmeler ve sutun gizlemeler
            gridView1.Columns[1].AppearanceCell.BackColor = Color.Green;
            gridView1.Columns[2].AppearanceCell.BackColor = Color.Aquamarine;
            gridView1.Columns[3].AppearanceCell.BackColor = Color.Orange;
            gridView1.Columns[4].AppearanceCell.BackColor = Color.Cyan;
            gridView1.Columns[5].AppearanceCell.BackColor = Color.OrangeRed;


            gridView1.Columns[7].Visible = false;
            gridView1.Columns[9].Visible = false;


        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {

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
            if (gridView1.GetFocusedRowCellValue("URUNADETI") != null &&
                 gridView1.GetFocusedRowCellValue("MUSTERI") != null &&
                 gridView1.GetFocusedRowCellValue("IGNEKOD") != null &&
                 gridView1.GetFocusedRowCellValue("SiparisNo") != null &&
                 gridView1.GetFocusedRowCellValue("NOTLAR") != null &&
                 gridView1.GetFocusedRowCellValue("SIPARISASAMASI") != null
            ) {
                    txt_adet.Text = gridView1.GetFocusedRowCellValue("URUNADETI").ToString();
                    txt_musteri.Text = gridView1.GetFocusedRowCellValue("MUSTERI").ToString();
                    txt_sipIgneTur.Text = gridView1.GetFocusedRowCellValue("IGNEKOD").ToString();
                    txt_sipNo.Text = gridView1.GetFocusedRowCellValue("SiparisNo").ToString();
                    txt_sipNot.Text = gridView1.GetFocusedRowCellValue("NOTLAR").ToString();

                int asamaDeger = int.Parse(gridView1.GetFocusedRowCellValue("SIPARISASAMASI").ToString());

                if (asamaDeger == 1)
                {
                    txt_asama.Text = "Preste";
                }
                else
                {
                    txt_asama.Text = "baska iste";
                }

            }
                

            
            
            
            
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }
    }
}


// private void gridView1_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
//{
//    GridView view = sender as GridView;
//    if (e.Column.FieldName == "SiparisAsamasi" && e.IsGetData) 
//    { e.Value = durumuYazdir(view, e.ListSourceRowIndex); }

//}//Provides data for the Total column.

//int durumuYazdir(GridView view, int listSourceRowIndex)
//{
//    var asamaDurumu = Convert.ToInt32(view.GetListSourceRowCellValue(listSourceRowIndex, "SIPARISASAMASI"));
//    if (asamaDurumu == 1)
//    {
//        return 5;
//    }
//    else
//    {
//        return 2;
//    }
//} //GridColumn unbColumn = gridView1.Columns.AddField("SiparisAsamasi");
//unbColumn.VisibleIndex = gridView1.Columns.Count;
//unbColumn.OptionsColumn.AllowEdit = false;
//unbColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
//unbColumn.DisplayFormat.FormatString = "c";
//unbColumn.AppearanceCell.BackColor = Color.LemonChiffon;

// Returns the total amount for a specific row.
