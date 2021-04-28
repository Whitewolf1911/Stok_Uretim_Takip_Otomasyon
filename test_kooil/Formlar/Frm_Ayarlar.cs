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
    public partial class Frm_Ayarlar : Form
    {
        public Frm_Ayarlar()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();
        Frm_YeniKullanici frmYeniKullanici;
        Frm_userUpdate frmUserUpdate;
        void userListele() {

            var veriler = (from x in db.TBL_USERS
                           select new
                           {

                               x.AdSoyad,
                              
                               x.ID

                           }).ToList().OrderBy(x => x.AdSoyad);
            gridControl1.DataSource = veriler;
            
            gridView1.Columns[1].Visible = false;
            gridView1.Columns[0].AppearanceCell.BackColor = Color.LightGreen;

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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult siradakiAsamaSorgu = MessageBox.Show("Seçilen Kullanıcıyı Sistemden Silmek İstediğinize Emin Misiniz ? Bu İşlem Geri Alınamaz .", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (siradakiAsamaSorgu == DialogResult.Yes)
                {

                    if (gridView1.GetFocusedRowCellValue("AdSoyad").ToString() != "admin" && gridView1.GetFocusedRowCellValue("AdSoyad").ToString() != Frm_Login.user.AdSoyad)
                    {

                        var userID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                        var userRemove = db.TBL_USERS.Find(userID);
                        db.TBL_USERS.Remove(userRemove);
                        db.SaveChanges();
                        userListele();
                    }
                    else
                    {
                        if (gridView1.GetFocusedRowCellValue("AdSoyad").ToString() == "admin")
                        {
                            XtraMessageBox.Show("Bu Kullanıcıyı Sistemden Silemezsiniz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (gridView1.GetFocusedRowCellValue("AdSoyad").ToString() == Frm_Login.user.AdSoyad)
                        {

                            XtraMessageBox.Show("Kendi Hesabınızı Sistemden Silemezsiniz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
            catch (Exception) { 
                            XtraMessageBox.Show("Bir Hata Oluştu !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (frmUserUpdate == null || frmUserUpdate.IsDisposed)
            {
                frmUserUpdate = new Frm_userUpdate();
                frmUserUpdate.Show();
            }
        }
    }
}
