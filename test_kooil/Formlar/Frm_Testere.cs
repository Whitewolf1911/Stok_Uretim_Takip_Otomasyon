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
    public partial class Frm_Testere : Form
    {
        public Frm_Testere()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();
        Frm_YeniTestere frmYeniTestere;
        Frm_testereTanimla frmTestereTanimla;

        void listele()
        {
            try
            {
                var veriler = (from x in db.TBL_TESTERE
                               select new
                               {

                                   x.ID,
                                   Testere = x.TESTEREKOD,
                                   Adet= x.ADET,
                               }
                               ).ToList().OrderByDescending(x => x.Adet);
                gridControl1.DataSource = veriler;
                gridView1.Columns[0].Visible = false;

            }
            catch (Exception)
            {

            }


        }
        private void Frm_Testere_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void Btn_adetEkle_Click(object sender, EventArgs e)
        {
            try {
                DialogResult Sorgu = MessageBox.Show("Seçilen Testereye Stok Eklemek İstediğinize Emin Misiniz ? ", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Sorgu == DialogResult.Yes)
                {
                    var testereID = (int)gridView1.GetFocusedRowCellValue("ID");
                    var testere = db.TBL_TESTERE.Find(testereID);
                    testere.ADET += (int)num_adet.Value;
                    
                    db.SaveChanges();
                    MessageBox.Show("Testereye stok eklendi. ", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                }

            }
            catch (Exception)
            {

            }
        }

        private void Btn_adetAzalt_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Sorgu = MessageBox.Show("Seçilen Testereden Stok Azaltmak İstediğinize Emin Misiniz ? ", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Sorgu == DialogResult.Yes)
                {
                    var testereID = (int)gridView1.GetFocusedRowCellValue("ID");
                    var testere = db.TBL_TESTERE.Find(testereID);
                    testere.ADET -= (int)num_adet.Value;
                    if (testere.ADET <= 0)
                    {
                        testere.ADET = 0;
                    }
                    db.SaveChanges();
                    MessageBox.Show("Testereden stok azaltıldı. ", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                }
                }
            catch
            {

            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(gridView1.GetFocusedRowCellValue("Testere")!= null)
            {
                txt_testere.Text = gridView1.GetFocusedRowCellValue("Testere").ToString();
            }
        }

        private void Btn_yeniTestere_Click(object sender, EventArgs e)
        {
            frmYeniTestere = new Frm_YeniTestere();
            frmYeniTestere.Show();
        }

        private void Btn_testereTanimla_Click(object sender, EventArgs e)
        {
            frmTestereTanimla = new Frm_testereTanimla();
            frmTestereTanimla.Show();
        }

        private void Btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Sorgu = MessageBox.Show("Seçilen Testereyi Silmek İstediğinize Emin Misiniz ? ", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Sorgu == DialogResult.Yes)
                {
                    var testereID = (int)gridView1.GetFocusedRowCellValue("ID");
                    var testere = db.TBL_TESTERE.Find(testereID);
                    db.TBL_TESTERE.Remove(testere);
                    db.SaveChanges();
                    MessageBox.Show("Testere sistemden silindi. ", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                }
            }
            catch (Exception)
            {

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void Btn_urunListele_Click(object sender, EventArgs e)
        {
            try
            {
                string testere = gridView1.GetFocusedRowCellValue("Testere").ToString();

                var count = (from x in db.TBL_IGNELER
                               select new
                               {
                                   Tür = x.TUR,
                                   Ürün = x.IGNEKOD,
                                   Testere1 = x.TESTERE1,
                                   Testere2 = x.TESTERE2,

                               }).ToList().Where(x => x.Testere1 == testere || x.Testere2 == testere).Count();

                if (count > 0)
                {
                    var veriler = (from x in db.TBL_IGNELER
                                   select new
                                   {
                                       Tür = x.TUR,
                                       Ürün = x.IGNEKOD,
                                       Testere1 = x.TESTERE1,
                                       Testere2 = x.TESTERE2,

                                   }).ToList().Where(x => x.Testere1 == testere || x.Testere2 == testere);

                    gridControl2.DataSource = veriler;
                }
                else
                {
                    gridControl2.DataSource = null;
                    gridView2.Columns.Clear();
                }
                
               
            }
            catch
            {

            }

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
        private void Btn_yazdir_Click(object sender, EventArgs e)
        {
            ShowGridPreview(gridControl1);
            PrintGrid(gridControl1);
        }
    }
}
