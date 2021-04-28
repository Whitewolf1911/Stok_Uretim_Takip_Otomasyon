using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_kooil.Entity;


namespace test_kooil.Formlar
{
    public partial class Frm_IgneTurleri : Form
    {
        public Frm_IgneTurleri()
        {
            InitializeComponent();
        }
        
        DB_kooil_testEntities db = new DB_kooil_testEntities();
        void listele() {
            var igneler = (from x in db.TBL_IGNELER
                           select new
                           { 
                               Tür=x.TUR,
                               ÜrünKodu=x.IGNEKOD,
                               x.GRAMAJ,
                               SarfiyatGr = x.SARFIYATORAN,
                               x.HAMMADDETIPI,
                               x.ISILISLEMFORMUL,
                               x.NOT,
                               x.FOTO
                           }
                           );
            gridControl1.DataSource = igneler.ToList();
            gridView1.Columns[0].AppearanceCell.BackColor = Color.Cyan;

            gridView1.Columns[1].AppearanceCell.BackColor = Color.Yellow;

            gridView1.Columns[2].AppearanceCell.BackColor = Color.LightGreen;
            gridView1.Columns[2].Visible = false;
            //gridView1.Columns[3].Visible = false;
            gridView1.Columns[4].Visible = false;
            gridView1.Columns[5].Visible = false;
            gridView1.Columns[6].Visible = false;
            gridView1.Columns[7].Visible = false;
        }
        private void labelControl1_Click(object sender, EventArgs e)
        {
            
        }
        public static Image ImageFromByteArray(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            using (Image image = Image.FromStream(ms, true, true))
            {
                return (Image)image.Clone();
            }
        }
        private void Btn_Yenile_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if(gridView1.GetFocusedRowCellValue("HAMMADDETIPI") != null)
                {
                    var maddeID = int.Parse(gridView1.GetFocusedRowCellValue("HAMMADDETIPI").ToString());
                    var madde = db.TBL_HAMMADDE.Find(maddeID);

                    string hammaddeAd = madde.KALINLIK.ToString() + " x " + madde.GENISLIK.ToString() + " " + madde.OZELLIK + " " + madde.MENSEI;

                    txt_hammadde.Text = hammaddeAd;
                }
                
                if (gridView1.GetFocusedRowCellValue("ÜrünKodu") != null)
                {
                    txt_IgneKod.Text = gridView1.GetFocusedRowCellValue("ÜrünKodu").ToString();
                }

                if (gridView1.GetFocusedRowCellValue("GRAMAJ") != null)
                {
                    txt_Gramaj.Text = gridView1.GetFocusedRowCellValue("GRAMAJ").ToString();
                }

                if (gridView1.GetFocusedRowCellValue("ISILISLEMFORMUL") != null)
                {
                    txt_IsilIslem.Text = gridView1.GetFocusedRowCellValue("ISILISLEMFORMUL").ToString();
                }
                if (gridView1.GetFocusedRowCellValue("NOT") != null)
                {
                    txt_Not.Text = gridView1.GetFocusedRowCellValue("NOT").ToString();
                }
                if (gridView1.GetFocusedRowCellValue("FOTO") != null)
                {
                    pic_IgneFoto.Image = ImageFromByteArray((byte[])gridView1.GetFocusedRowCellValue("FOTO"));
                }
                if (gridView1.GetFocusedRowCellValue("FOTO") == null)
                {
                    pic_IgneFoto.Image = null;
                }

                if (gridView1.GetFocusedRowCellValue("SarfiyatGr") != null)
                {
                    txt_sarfiyat.Text = gridView1.GetFocusedRowCellValue("SarfiyatGr").ToString();
                }
            }
            catch (Exception) { 
                            XtraMessageBox.Show("Bir Hata Oluştu !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Frm_IgneTurleri_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void pic_IgneFoto_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }
    }
}