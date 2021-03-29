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
    public partial class Frm_YeniHamEkle : Form
    {
        public Frm_YeniHamEkle()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();
        private void Btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ekle_Click(object sender, EventArgs e)
        {
            try {
                TBL_HAMMADDE hammadde = new TBL_HAMMADDE();

                hammadde.KALINLIK = num_kalinlik.Value;
                hammadde.GENISLIK = num_Genislik.Value;
                hammadde.OZELLIK = ham_ozellik.EditValue.ToString();
                hammadde.MENSEI = ham_mensei.EditValue.ToString();
                hammadde.MIKTAR = (int?)num_Miktar.Value;
                hammadde.KONUM = text_Konum.Text;
                hammadde.AKTIF = true;
                db.TBL_HAMMADDE.Add(hammadde);
                db.SaveChanges();
                XtraMessageBox.Show("Hammadde Sisteme Eklendi ", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch {
                XtraMessageBox.Show("Girdiğiniz Bilgileri Kontrol Edip Tekrar Deneyiniz. ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
    }
}
