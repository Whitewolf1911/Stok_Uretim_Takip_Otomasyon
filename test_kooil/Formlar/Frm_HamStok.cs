using DevExpress.XtraEditors;
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
    public partial class Frm_HamStok : Form
    {
        public Frm_HamStok()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();
        Frm_YeniHamEkle frmYeniHam;
        Frm_HammaddeLog frmHamLog;
        

        void listele() {

            var degerler = (from x in db.TBL_HAMMADDE
                            select new
                            {
                                x.ID,
                                Kalınlık = x.KALINLIK,
                                Genişlik = x.GENISLIK,
                                Özellik = x.OZELLIK,
                                Menşei  = x.MENSEI,
                                Kilogram = x.MIKTAR,
                                Konum = x.KONUM,
                                x.AKTIF

                            }).ToList().OrderBy(x => x.Kalınlık).Where(x => x.AKTIF == true);
            gridControl1.DataSource = degerler;
            gridView1.Columns[0].Visible = false;
            gridView1.Columns[7].Visible = false;
            gridView1.Columns[1].AppearanceCell.BackColor = Color.Aquamarine;
            gridView1.Columns[2].AppearanceCell.BackColor = Color.Aquamarine;
            gridView1.Columns[3].AppearanceCell.BackColor = Color.LightYellow;
            gridView1.Columns[4].AppearanceCell.BackColor = Color.Cyan;
            gridView1.Columns[5].AppearanceCell.BackColor = Color.Yellow;

        }
        private void Btn_yeniHamEkle_Click(object sender, EventArgs e)
        {
            if (Frm_Login.user.yeniHam == true)
            {

                if (frmYeniHam == null || frmYeniHam.IsDisposed)
                {
                    frmYeniHam = new Frm_YeniHamEkle();
                    frmYeniHam.Show();
                }
            }
            else { 
               XtraMessageBox.Show("Bu İşlemi Gerçekleştirme Yetkiniz Yoktur !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Btn_hamSil_Click(object sender, EventArgs e)
        {
            if (Frm_Login.user.hamSil == true)
            {

                DialogResult siradakiAsamaSorgu = MessageBox.Show("Bu işlem seçilen hammaddeyi sistemden tamamen silecek. Devam etmek istediğinize emin misiniz ? ", "Hammadde Silme", MessageBoxButtons.YesNo);
                if (siradakiAsamaSorgu == DialogResult.Yes)
                {
                    int silinecekMadde = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                    var deger = db.TBL_HAMMADDE.Find(silinecekMadde);
                    deger.AKTIF = false;
                    db.SaveChanges();
                    XtraMessageBox.Show("Hammadde Sistemden Silindi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                }
                else { }

            }
            else { 
               XtraMessageBox.Show("Bu İşlemi Gerçekleştirme Yetkiniz Yoktur !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Btn_Yenile_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void Frm_HamStok_Load(object sender, EventArgs e)
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
        private void Btn_yazdir_Click(object sender, EventArgs e)
        {
            ShowGridPreview(gridControl1);
            PrintGrid(gridControl1);
        }

        private void Btn_hamLog_Click(object sender, EventArgs e)
        {
            if (frmHamLog == null || frmHamLog.IsDisposed)
            {
                frmHamLog = new Frm_HammaddeLog();
                frmHamLog.Show();
            }
        }
    }
}
