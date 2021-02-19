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

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            TBL_IGNELER yeniIgne = new TBL_IGNELER();

            yeniIgne.IGNEKOD = txt_IgneKodu.Text;
            yeniIgne.ISILISLEMFORMUL = txt_IsilIslem.Text;
            yeniIgne.ADETFIYATI = num_AdetFiyat.Value;
            yeniIgne.NOT = txt_Not.Text;
            yeniIgne.EBAT = txt_ebat.Text;
            db.TBL_IGNELER.Add(yeniIgne);
            db.SaveChanges();
            XtraMessageBox.Show("Igne Sisteme Eklendi.", "Islem Basarili", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }
    }
}
