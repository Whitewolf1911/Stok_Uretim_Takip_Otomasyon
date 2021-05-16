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
    public partial class Frm_KanalAcma : Form
    {
        public Frm_KanalAcma()
        {
            InitializeComponent();
        }
        Frm_KanalAcmaEkle frmEkle;
        Frm_KanalAcmaRapor frmKanalAcRapor;
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
                                            KanalAçma = x.KANALACMASAYI,
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

        private void Frm_KanalAcma_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void Btn_SiyirmaEkle_Click(object sender, EventArgs e)
        {//KanalAcma Ekle
            frmEkle = new Frm_KanalAcmaEkle();
            frmEkle.Show();
        }

        private void Btn_Raporlar_Click(object sender, EventArgs e)
        {
            if (frmKanalAcRapor == null || frmKanalAcRapor.IsDisposed)
            {
                frmKanalAcRapor = new Frm_KanalAcmaRapor();
                frmKanalAcRapor.MdiParent = this.ParentForm;
                frmKanalAcRapor.Show();
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
