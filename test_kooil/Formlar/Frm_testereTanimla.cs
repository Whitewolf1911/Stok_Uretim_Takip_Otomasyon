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
    public partial class Frm_testereTanimla : Form
    {
        public Frm_testereTanimla()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();

        void ignelistele()
        {
            try
            {
                var veriler = (from x in db.TBL_IGNELER
                               select new
                               {
                                   x.ID,
                                   Tür = x.TUR,
                                   Ürün = x.IGNEKOD,
                                   Testere1 = x.TESTERE1,
                                   Testere2 = x.TESTERE2,

                               }).ToList();
                gridControl1.DataSource = veriler;
                gridView1.Columns[0].Visible = false;
            }
            catch { }

        }
        void testereListele()
        {
            try
            {
                var veriler = (from x in db.TBL_TESTERE
                               select new
                               {
                                   x.ID,
                                   Testere = x.TESTEREKOD
                               }).ToList().OrderBy(x => x.Testere);
                gridTestere1.DataSource = veriler;
                gridTestere2.DataSource = veriler;
                gridView2.Columns[0].Visible = false;
                gridView3.Columns[0].Visible = false;
            }
            catch (Exception) { }
        }
        private void Frm_testereTanimla_Load(object sender, EventArgs e)
        {
            ignelistele();
            testereListele();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try {
                int igneID = (int)gridView1.GetFocusedRowCellValue("ID");
                var igne = db.TBL_IGNELER.Find(igneID);
                igne.TESTERE1 = gridView2.GetFocusedRowCellValue("Testere").ToString();
                igne.TESTERE2 = gridView3.GetFocusedRowCellValue("Testere").ToString();
                db.SaveChanges();
                MessageBox.Show("Tanımlama Gerçekleşti. ", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            catch (Exception) { }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(gridView1.GetFocusedRowCellValue("Ürün")!= null)
            {
                txt_urun.Text = gridView1.GetFocusedRowCellValue("Ürün").ToString();
            }
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView2.GetFocusedRowCellValue("Testere") != null)
            {
                txt_test1.Text = gridView2.GetFocusedRowCellValue("Testere").ToString();
            }
        }

        private void gridView3_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView3.GetFocusedRowCellValue("Testere") != null)
            {
                txt_test2.Text = gridView3.GetFocusedRowCellValue("Testere").ToString();
            }
        }

        private void Btn_sifirla_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Sorgu = MessageBox.Show("Seçilen Ürünün Testere Bilgisini Sıfırlamak İstediğinize Emin Misiniz ? .", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Sorgu == DialogResult.Yes)
                {
                    int igneID = (int)gridView1.GetFocusedRowCellValue("ID");
                    var igne = db.TBL_IGNELER.Find(igneID);
                    igne.TESTERE1 = null;
                    igne.TESTERE2 = null;
                    db.SaveChanges();
                    MessageBox.Show("Seçilen ürünün testere bilgisi sıfırlandı. ", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ignelistele();
                }
            }

            catch (Exception) { }
        }
    }
}
