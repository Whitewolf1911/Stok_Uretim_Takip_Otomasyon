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
    public partial class Frm_GerilimGiderme : Form
    {
        public Frm_GerilimGiderme()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();
        Frm_GerilimGiderEkle frmEkle;
        Frm_GerilimGiderRapor frmRapor;
        void listele()
        {
            try
            {
                var islenecekUrunler = (from x in db.TBL_SIPARIS
                                        select new
                                        {
                                            SiparişNo = x.SIPARISNOID,
                                            PartiNo = x.PARTINO,
                                            Tür = x.TBL_IGNELER.TUR,
                                            ÜrünKodu = x.TBL_IGNELER.IGNEKOD,
                                            SiparişMiktarı = x.URUNADETI,
                                            GerilimGiderme = x.GERILIMGIDERMESAYI,
                                            Not = x.NOTLAR,
                                            x.AKTIF

                                        }).ToList().OrderByDescending(x => x.SiparişNo);

                gridControl1.DataSource = islenecekUrunler.Where(x => x.AKTIF == true);
                gridView1.Columns[1].AppearanceCell.BackColor = Color.LightGreen;
                gridView1.Columns[2].AppearanceCell.BackColor = Color.Aquamarine;
                gridView1.Columns[3].AppearanceCell.BackColor = Color.Orange;
                gridView1.Columns[4].AppearanceCell.BackColor = Color.Cyan;
                gridView1.Columns[7].Visible = false;
                gridView1.BestFitColumns();


            }
            catch (Exception) { }
        }
        private void Frm_GerilimGiderme_Load(object sender, EventArgs e)
        {
            listele();
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

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void Btn_SiyirmaEkle_Click(object sender, EventArgs e)
        {
            frmEkle = new Frm_GerilimGiderEkle();
            frmEkle.Show();
        }

        private void Btn_Raporlar_Click(object sender, EventArgs e)
        {
            if (frmRapor == null || frmRapor.IsDisposed)
            {
                frmRapor = new Frm_GerilimGiderRapor();
                frmRapor.MdiParent = this.ParentForm;
                frmRapor.Show();
            }
        }
    }
}
