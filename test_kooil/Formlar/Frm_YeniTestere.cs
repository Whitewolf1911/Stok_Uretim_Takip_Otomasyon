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
    public partial class Frm_YeniTestere : Form
    {
        public Frm_YeniTestere()
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
                if (string.IsNullOrWhiteSpace(txt_testereKod.Text))
                {
                    MessageBox.Show("Lütfen testere kodunu giriniz. ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    TBL_TESTERE testere = new TBL_TESTERE();

                    testere.ADET = (int)num_adet.Value;
                    testere.TESTEREKOD = txt_testereKod.Text;
                    db.TBL_TESTERE.Add(testere);
                    db.SaveChanges();
                    MessageBox.Show("Testere sisteme eklendi. ", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }

            }

            catch (Exception) { }
        }
    }
}
