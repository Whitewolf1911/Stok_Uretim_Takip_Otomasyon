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
    public partial class Frm_YeniIgneEkle : Form
    {
        public Frm_YeniIgneEkle()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();

        void hamListele() {

            var hammaddeler = (from x in db.TBL_HAMMADDE
                               select new
                               {
                                   x.KALINLIK,
                                   x.GENISLIK,
                                   x.MENSEI,
                                   x.OZELLIK,
                                   x.ID,
                                   x.AKTIF

                               }).ToList().OrderBy(x => x.KALINLIK).Where(x => x.AKTIF == true);

            gridControl1.DataSource = hammaddeler;
            gridView1.Columns[4].Visible = false;
            gridView1.Columns[5].Visible = false;
            gridView1.Columns[0].AppearanceCell.BackColor = Color.LightBlue;
        }
        
        

        private void Btn_Iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (string.IsNullOrWhiteSpace(txt_IgneKodu.Text) || comboBoxEdit1.SelectedItem == null)
                {
                    if (string.IsNullOrWhiteSpace(txt_IgneKodu.Text) )
                    {
                        XtraMessageBox.Show("Lütfen Ürün Kodunu Giriniz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        XtraMessageBox.Show("Lütfen Ürün Türünü Seçiniz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else {

                    TBL_IGNELER yeniIgne = new TBL_IGNELER();

                    yeniIgne.IGNEKOD = txt_IgneKodu.Text;
                    yeniIgne.ISILISLEMFORMUL = txt_IsilIslem.Text;
                    yeniIgne.GRAMAJ = num_Gramaj.Value;
                    yeniIgne.HAMMADDETIPI = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                    yeniIgne.SARFIYATORAN = num_SarfiyatOrani.Value;
                    yeniIgne.NOT = txt_Not.Text;
                    yeniIgne.STOK = 0;
                    if (comboBoxEdit1.SelectedItem != null)
                    {
                        yeniIgne.TUR = comboBoxEdit1.SelectedItem.ToString();
                    }
                    if (picBox_Igne.Image != null)
                    {
                        var foto = ImageToByteArray(picBox_Igne.Image);
                        yeniIgne.FOTO = foto;
                    }


                    db.TBL_IGNELER.Add(yeniIgne);
                    db.SaveChanges();
                    XtraMessageBox.Show("İğne Sisteme Eklendi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                
            }
            catch(Exception) { 
                XtraMessageBox.Show("Bir Hata Oluştu !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_fotoEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter= "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            DialogResult res = dialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                picBox_Igne.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void Frm_YeniIgneEkle_Load(object sender, EventArgs e)
        {
            hamListele();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(gridView1.GetFocusedRowCellValue("KALINLIK") != null && gridView1.GetFocusedRowCellValue("GENISLIK") != null)
            {
                txt_secilenHam.Text = gridView1.GetFocusedRowCellValue("KALINLIK").ToString() + " x " + gridView1.GetFocusedRowCellValue("GENISLIK");

            }
        }
    }
}
