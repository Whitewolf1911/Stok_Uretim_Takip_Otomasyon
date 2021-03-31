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
    public partial class Frm_Ayarlar : Form
    {
        public Frm_Ayarlar()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();
        Frm_YeniKullanici frmYeniKullanici;

        void userListele() {

            var veriler = (from x in db.TBL_USERS
                           select new
                           {

                               x.AdSoyad,
                               x.userName,
                               x.password,
                               x.ID

                           }).ToList().OrderBy(x => x.AdSoyad);
            gridControl1.DataSource = veriler;
            gridView1.Columns[3].Visible = false;
            gridView1.Columns[2].Visible = false;
        }

        private void Frm_Ayarlar_Load(object sender, EventArgs e)
        {
            userListele();
        }

        private void Btn_YeniKullanici_Click(object sender, EventArgs e)
        {
            if (frmYeniKullanici == null || frmYeniKullanici.IsDisposed)
            {
                frmYeniKullanici = new Frm_YeniKullanici();
                frmYeniKullanici.Show();
            }
        }
    }
}
