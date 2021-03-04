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
    public partial class Frm_TamamlananSiparisler : Form
    {
        public Frm_TamamlananSiparisler()
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
                               x.URUNADETI,
                               x.SIPARISTARIHI,
                               x.ISTENILENTARIH,
                               x.TOPLAMTUTAR,
                               x.AKTIF,
                               x.NOTLAR,
                               x.SIPARISASAMASI

                           }).ToList().OrderByDescending(x => x.SiparisNo);

            gridControl1.DataSource = veriler.Where(x => x.AKTIF == false);

            //renklendirmeler ve sutun gizlemeler
            gridView1.Columns[1].AppearanceCell.BackColor = Color.LightGreen;
            gridView1.Columns[2].AppearanceCell.BackColor = Color.Aquamarine;
            gridView1.Columns[3].AppearanceCell.BackColor = Color.Orange;
            gridView1.Columns[4].AppearanceCell.BackColor = Color.Cyan;
            gridView1.Columns[5].AppearanceCell.BackColor = Color.Yellow;


            gridView1.Columns[7].Visible = false;
            gridView1.Columns[9].Visible = false;


        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void Frm_TamamlananSiparisler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("URUNADETI") != null) { txt_adet.Text = gridView1.GetFocusedRowCellValue("URUNADETI").ToString(); }
            if (gridView1.GetFocusedRowCellValue("MUSTERI") != null) { txt_musteri.Text = gridView1.GetFocusedRowCellValue("MUSTERI").ToString(); }
            if (gridView1.GetFocusedRowCellValue("IGNEKOD") != null) { txt_sipIgneTur.Text = gridView1.GetFocusedRowCellValue("IGNEKOD").ToString(); }
            if (gridView1.GetFocusedRowCellValue("SiparisNo") != null) { txt_sipNo.Text = gridView1.GetFocusedRowCellValue("SiparisNo").ToString(); }
            if (gridView1.GetFocusedRowCellValue("NOTLAR") != null) { txt_sipNot.Text = gridView1.GetFocusedRowCellValue("NOTLAR").ToString(); }
            if (gridView1.GetFocusedRowCellValue("TOPLAMTUTAR") != null) { txt_tutar.Text = gridView1.GetFocusedRowCellValue("TOPLAMTUTAR").ToString(); }

        }
    }
}
