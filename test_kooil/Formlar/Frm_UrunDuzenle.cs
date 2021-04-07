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
    public partial class Frm_UrunDuzenle : Form
    {
        public Frm_UrunDuzenle()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();

        void hamListele()
        {

            var hammaddeler = (from x in db.TBL_HAMMADDE
                               select new
                               {
                                   x.KALINLIK,
                                   x.GENISLIK,
                                   x.MENSEI,
                                   x.OZELLIK,
                                   x.ID

                               }).ToList().OrderBy(x => x.KALINLIK);

            gridControl2.DataSource = hammaddeler;
            gridView2.Columns[4].Visible = false;
            gridView2.Columns[0].AppearanceCell.BackColor = Color.LightBlue;
        }

        void urunListele()
        {
            var igneler = (from x in db.TBL_IGNELER
                           select new
                           {
                               x.TUR,
                               x.IGNEKOD,
                               x.GRAMAJ,
                               x.SARFIYATORAN,
                               x.ISILISLEMFORMUL,
                               x.NOT,
                               x.FOTO,
                               x.HAMMADDETIPI,
                               x.ID
                           }
                           ).ToList() ;
            gridControl1.DataSource = igneler;
            gridView1.Columns[0].AppearanceCell.BackColor = Color.Cyan;

            gridView1.Columns[1].AppearanceCell.BackColor = Color.Yellow;

            gridView1.Columns[2].AppearanceCell.BackColor = Color.LightGreen;
            gridView1.Columns[4].Visible = false;
            gridView1.Columns[5].Visible = false;
            gridView1.Columns[6].Visible = false;
            gridView1.Columns[7].Visible = false;
            gridView1.Columns[8].Visible = false;



        }
        bool fotoSwitch = false; // declared this to prevent exception and crash the program
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        private void btn_fotoEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            DialogResult res = dialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                picBox_Igne.Image = Image.FromFile(dialog.FileName);
                fotoSwitch = true;
            }
            
        }

        private void Frm_UrunDuzenle_Load(object sender, EventArgs e)
        {
            hamListele();
            urunListele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        { //igneler
            if (gridView1.GetFocusedRowCellValue("HAMMADDETIPI") != null) {

                int id = int.Parse(gridView1.GetFocusedRowCellValue("HAMMADDETIPI").ToString());
                var hammadde = db.TBL_HAMMADDE.Find(id);
                string hammaddeAd = hammadde.KALINLIK.ToString() + " x " + hammadde.GENISLIK.ToString() + " " + hammadde.OZELLIK.ToString() + " " + hammadde.MENSEI.ToString();

                txt_eskiHam.Text = hammaddeAd;

            }
            
            if (gridView1.GetFocusedRowCellValue("IGNEKOD") != null)
            {
                txt_IgneKod.Text = gridView1.GetFocusedRowCellValue("IGNEKOD").ToString();
            }
            if (gridView1.GetFocusedRowCellValue("TUR") != null)
            {
                comboBoxEdit1.Text = gridView1.GetFocusedRowCellValue("TUR").ToString();
            }

            if (gridView1.GetFocusedRowCellValue("GRAMAJ") != null)
            {
                num_Gramaj.Value = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("GRAMAJ").ToString());
            }

            if (gridView1.GetFocusedRowCellValue("SARFIYATORAN") != null)
            {
                num_Gramaj.Value = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("SARFIYATORAN").ToString());
            }

            if (gridView1.GetFocusedRowCellValue("ISILISLEMFORMUL") != null)
            {
                txt_IsilIslem.Text = gridView1.GetFocusedRowCellValue("ISILISLEMFORMUL").ToString();
            }
            if (gridView1.GetFocusedRowCellValue("NOT") != null)
            {
                txt_Not.Text = gridView1.GetFocusedRowCellValue("NOT").ToString();
            }
            if (gridView1.GetFocusedRowCellValue("FOTO") != null  )
            {
                picBox_Igne.Image = Frm_IgneTurleri.ImageFromByteArray((byte[])gridView1.GetFocusedRowCellValue("FOTO"));
            }
            if (gridView1.GetFocusedRowCellValue("FOTO") == null)
            {
                picBox_Igne.Image = null;
            }
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            DialogResult siradakiAsamaSorgu = MessageBox.Show("Seçilen Ürünü Güncellemek İstediğinize Emin Misiniz ? ", " Güncelleme Onay", MessageBoxButtons.YesNo);
            if (siradakiAsamaSorgu == DialogResult.Yes)
            {
                int id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                var igne = db.TBL_IGNELER.Find(id);

                igne.IGNEKOD = txt_IgneKod.Text;
                igne.ISILISLEMFORMUL = txt_IsilIslem.Text;
                igne.GRAMAJ = num_Gramaj.Value;
                igne.HAMMADDETIPI = int.Parse(gridView2.GetFocusedRowCellValue("ID").ToString());
                igne.SARFIYATORAN = num_SarfiyatOrani.Value;
                igne.NOT = txt_Not.Text;

                igne.TUR = comboBoxEdit1.SelectedItem.ToString();

                if (picBox_Igne.Image != null && fotoSwitch)
                {
                    var foto = ImageToByteArray(picBox_Igne.Image);
                    igne.FOTO = foto;
                }

                db.SaveChanges();
                XtraMessageBox.Show("Ürün Güncellendi .", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                urunListele();
            }
            
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            string hammaddeAd = gridView2.GetFocusedRowCellValue("KALINLIK").ToString() + " x " + gridView2.GetFocusedRowCellValue("GENISLIK").ToString() +
                " " + gridView2.GetFocusedRowCellValue("OZELLIK").ToString() + " " + gridView2.GetFocusedRowCellValue("MENSEI").ToString();
            txt_secilenHam.Text = hammaddeAd;
            Btn_Kaydet.Enabled = false;
        }

        private void Btn_hamSec_Click(object sender, EventArgs e)
        {
            Btn_Kaydet.Enabled = true;

        }
    }
}
