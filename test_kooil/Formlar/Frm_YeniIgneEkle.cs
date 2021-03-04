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
                TBL_IGNELER yeniIgne = new TBL_IGNELER();

                yeniIgne.IGNEKOD = txt_IgneKodu.Text;
                yeniIgne.ISILISLEMFORMUL = txt_IsilIslem.Text;
                yeniIgne.ADETFIYATI = num_AdetFiyat.Value;
                yeniIgne.NOT = txt_Not.Text;
                yeniIgne.EBAT = txt_ebat.Text;
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
            catch { 
                XtraMessageBox.Show("Lütfen İğne Kodunu Giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
    }
}
