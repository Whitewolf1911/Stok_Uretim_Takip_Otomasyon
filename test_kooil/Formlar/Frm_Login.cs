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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();
        public static TBL_USERS user;
        private void Btn_login_Click(object sender, EventArgs e)
        {
            try { 

                var userName = txt_userName.Text.Trim();
                var password = txt_password.Text.Trim();

                user = db.TBL_USERS.FirstOrDefault(x => x.userName == userName && x.password == password);

                if (user == null)
                {
                    
                    XtraMessageBox.Show("Geçersiz Kullanıcı Adı Veya Şifre !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else {

                    
                    var mainWindow = new Form1(this);
                    mainWindow.Show();
                    this.Hide();
                
                }


            }

            catch (Exception) { 
                
                 XtraMessageBox.Show("Bir Hata Oluştu. Bağlantınızı Kontrol Ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
