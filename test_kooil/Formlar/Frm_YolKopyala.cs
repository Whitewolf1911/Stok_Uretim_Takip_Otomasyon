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
    public partial class Frm_YolKopyala : Form
    {
        public Frm_YolKopyala()
        {
            InitializeComponent();
        }

        DB_kooil_testEntities db = new DB_kooil_testEntities();
        Frm_YKopyalaEkle frmYKekle;
        Frm_YKopyalamaRapor frmYKrepor;
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
                                            YolKopyalama = x.YOLKOPYASAYI,
                                            Not = x.NOTLAR,
                                            x.AKTIF

                                        }).ToList().OrderByDescending(x => x.SiparişNo);

                gridControl1.DataSource = islenecekUrunler.Where(x => x.AKTIF == true);
                gridView1.Columns[1].AppearanceCell.BackColor = Color.LightGreen;
                gridView1.Columns[2].AppearanceCell.BackColor = Color.Aquamarine;
                gridView1.Columns[3].AppearanceCell.BackColor = Color.Orange;
                gridView1.Columns[4].AppearanceCell.BackColor = Color.Cyan;
                gridView1.Columns[6].Visible = false;
            }
            catch (Exception) { }

        }
        private void Frm_YolKopyala_Load(object sender, EventArgs e)
        {
            listele();
        }
        

        private void Btn_SiyirmaEkle_Click(object sender, EventArgs e)
        {
            frmYKekle = new Frm_YKopyalaEkle();
            frmYKekle.Show();
        }

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("ÜrünKodu") != null &&
               gridView1.GetFocusedRowCellValue("Not") != null)
            {

                txt_sipIgneTur.Text = gridView1.GetFocusedRowCellValue("ÜrünKodu").ToString();
                txt_sipNot.Text = gridView1.GetFocusedRowCellValue("Not").ToString();
            }
        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void Btn_Raporlar_Click(object sender, EventArgs e)
        {
            if (frmYKrepor == null || frmYKrepor.IsDisposed)
            {
                frmYKrepor = new Frm_YKopyalamaRapor();
                frmYKrepor.MdiParent = this.ParentForm;
                frmYKrepor.Show();
            }
        }
    }
}
