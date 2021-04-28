using DevExpress.XtraEditors;
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
    public partial class Frm_FirmaEkle : Form
    {
        public Frm_FirmaEkle()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //Ekle Butonu
            try
            {
                if (string.IsNullOrWhiteSpace(txt_ad.Text))
                {
                    XtraMessageBox.Show("Lütfen Firma Adını Giriniz !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    TBL_FIRMALAR yeniFirma = new TBL_FIRMALAR();
                    yeniFirma.ADRES = txt_Adres.Text;
                    yeniFirma.FIRMAAD = txt_ad.Text;
                    yeniFirma.FIRMATAMAD = txt_tamAd.Text;
                    yeniFirma.KONUM = txt_Konum.Text;
                    yeniFirma.MAIL = txt_email.Text;
                    yeniFirma.TELEFON1 = txt_Tel1.Text;
                    yeniFirma.TELEFON2 = txt_Tel2.Text;
                    yeniFirma.VERGIDAIRESI = txt_vergiDaire.Text;
                    yeniFirma.VERGINO = txt_vergiNo.Text;
                    yeniFirma.YETKILI = txt_Yetkili.Text;

                    db.TBL_FIRMALAR.Add(yeniFirma);
                    db.SaveChanges();

                    XtraMessageBox.Show("Firma Sisteme Eklendi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                
            }
            catch(Exception)
            {
                XtraMessageBox.Show("Girdiğiniz Bilgileri Kontrol Ediniz.", "İşlem Tamamlanamadı.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
