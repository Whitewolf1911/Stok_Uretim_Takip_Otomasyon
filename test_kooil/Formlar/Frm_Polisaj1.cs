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
    public partial class Frm_Polisaj1 : Form
    {
        public Frm_Polisaj1()
        {
            InitializeComponent();
        }
        FrmPolisaj1Rapor frmpoli1Rapor;
        Frm_Polisaj1Ekle frmPoli1ekle;
        DB_kooil_testEntities db = new DB_kooil_testEntities();

        void listele()
        {
            try
            {
                var islenecekUrunler = (from x in db.TBL_SIPARIS
                                        select new
                                        {
                                            SiparişNo = x.SIPARISNOID,
                                            Tür = x.TBL_IGNELER.TUR,
                                            ÜrünKodu = x.TBL_IGNELER.IGNEKOD,
                                            SiparişMiktarı = x.URUNADETI,
                                            Not = x.NOTLAR,
                                            x.AKTIF

                                        }).ToList().OrderByDescending(x => x.SiparişNo);

                gridControl1.DataSource = islenecekUrunler.Where(x => x.AKTIF == true);
                gridView1.Columns[1].AppearanceCell.BackColor = Color.LightGreen;
                gridView1.Columns[2].AppearanceCell.BackColor = Color.Aquamarine;
                gridView1.Columns[3].AppearanceCell.BackColor = Color.Orange;
                gridView1.Columns[4].AppearanceCell.BackColor = Color.Cyan;
                gridView1.Columns[5].Visible = false;
            }
            catch (Exception) { }
        }

        private void Frm_Polisaj1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void Btn_SiyirmaEkle_Click(object sender, EventArgs e)
        {
            frmPoli1ekle = new Frm_Polisaj1Ekle();
            frmPoli1ekle.Show();
        }

        private void Btn_Raporlar_Click(object sender, EventArgs e)
        {
            if (frmpoli1Rapor == null || frmpoli1Rapor.IsDisposed)
            {
                frmpoli1Rapor = new FrmPolisaj1Rapor();
                frmpoli1Rapor.MdiParent = this.ParentForm;
                frmpoli1Rapor.Show();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("ÜrünKodu") != null &&
              gridView1.GetFocusedRowCellValue("Not") != null)
            {

                txt_sipIgneTur.Text = gridView1.GetFocusedRowCellValue("ÜrünKodu").ToString();
                txt_sipNot.Text = gridView1.GetFocusedRowCellValue("Not").ToString();
            }
        }
    }
}
