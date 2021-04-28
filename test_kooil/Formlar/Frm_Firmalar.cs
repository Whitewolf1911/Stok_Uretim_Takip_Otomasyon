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
    public partial class Frm_Firmalar : Form
    {
        public Frm_Firmalar()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();

        void listele()
        {
            try
            {
                var veriler = (from x in db.TBL_FIRMALAR
                               select new
                               {
                                   x.ID,
                                   FirmaAd = x.FIRMAAD,
                                   FirmaTamAd = x.FIRMATAMAD,
                                   x.ADRES,
                                   x.KONUM,
                                   MailAdresi = x.MAIL,
                                   Telefon1 = x.TELEFON1,
                                   x.TELEFON2,
                                   x.VERGIDAIRESI,
                                   x.VERGINO,
                                   Yetkili = x.YETKILI

                               }).ToList();

                gridControl1.DataSource = veriler;

                gridView1.Columns[0].Visible = false;
                gridView1.Columns[3].Visible = false;
                gridView1.Columns[4].Visible = false;
                gridView1.Columns[7].Visible = false;
                gridView1.Columns[8].Visible = false;
                gridView1.Columns[9].Visible = false;

                gridView1.Columns[1].AppearanceCell.BackColor = Color.LightGreen;
                gridView1.Columns[2].AppearanceCell.BackColor = Color.Cyan;
                gridView1.Columns[5].AppearanceCell.BackColor = Color.Yellow;
                gridView1.Columns[6].AppearanceCell.BackColor = Color.Lime;
            }
            catch (Exception) { }
        }
        private void Frm_Firmalar_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void Btn_Yenile_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void Btn_firmaSil_Click(object sender, EventArgs e)
        {
            DialogResult areYouSure = MessageBox.Show("Seçtiğiniz Firman Sistemden Tamamen Silinecektir .  Devam Etmek İstediğinize Emin Misiniz ? ", "Uyarı", MessageBoxButtons.YesNo);
            if (areYouSure == DialogResult.Yes)
            {
                int firmaID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                var firma = db.TBL_FIRMALAR.Find(firmaID);
                db.TBL_FIRMALAR.Remove(firma);
                db.SaveChanges();
            }
            listele();
            }

        private void Btn_bilgiGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult areYouSure = MessageBox.Show("Seçtiğiniz Firmanın Bilgileri Güncellenecektir. Devam Etmek İstediğinize Emin Misiniz ? ", "Onay", MessageBoxButtons.YesNo);
            if (areYouSure == DialogResult.Yes)
            {

                try
                {
                    int firmaID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                    var firma = db.TBL_FIRMALAR.Find(firmaID);
                    firma.FIRMAAD = txt_ad.Text;
                    firma.FIRMATAMAD = txt_tamAd.Text;
                    firma.ADRES = txt_Adres.Text;
                    firma.KONUM = txt_Konum.Text;
                    firma.MAIL = txt_email.Text;
                    firma.TELEFON1 = txt_Tel1.Text;
                    firma.TELEFON2 = txt_Tel2.Text;
                    firma.VERGIDAIRESI = txt_vergiDaire.Text;
                    firma.VERGINO = txt_vergiNo.Text;
                    firma.YETKILI = txt_Yetkili.Text;
                    db.SaveChanges();
                }

                catch(Exception)
                {
                    XtraMessageBox.Show("Bir Hata Oluştu. Girdiğiniz Bilgileri Kontrol Ediniz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                listele();

            }

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Btn_bilgiGuncelle.Enabled = true;
            Btn_firmaSil.Enabled = true;
            if (gridView1.GetFocusedRowCellValue("FirmaAd") != null) { txt_ad.Text = gridView1.GetFocusedRowCellValue("FirmaAd").ToString(); }
            if (gridView1.GetFocusedRowCellValue("FirmaTamAd") != null) { txt_tamAd.Text = gridView1.GetFocusedRowCellValue("FirmaTamAd").ToString(); }
            if (gridView1.GetFocusedRowCellValue("ADRES") != null) { txt_Adres.Text = gridView1.GetFocusedRowCellValue("ADRES").ToString(); }
            if (gridView1.GetFocusedRowCellValue("KONUM") != null) { txt_Konum.Text = gridView1.GetFocusedRowCellValue("KONUM").ToString(); }
            if (gridView1.GetFocusedRowCellValue("MailAdresi") != null) { txt_email.Text = gridView1.GetFocusedRowCellValue("MailAdresi").ToString(); }
            if (gridView1.GetFocusedRowCellValue("Telefon1") != null) { txt_Tel1.Text = gridView1.GetFocusedRowCellValue("Telefon1").ToString(); }
            if (gridView1.GetFocusedRowCellValue("TELEFON2") != null) { txt_Tel2.Text = gridView1.GetFocusedRowCellValue("TELEFON2").ToString(); }
            if (gridView1.GetFocusedRowCellValue("VERGIDAIRESI") != null) { txt_vergiDaire.Text = gridView1.GetFocusedRowCellValue("VERGIDAIRESI").ToString(); }
            if (gridView1.GetFocusedRowCellValue("VERGINO") != null) { txt_vergiNo.Text = gridView1.GetFocusedRowCellValue("VERGINO").ToString(); }
            if (gridView1.GetFocusedRowCellValue("Yetkili") != null) { txt_Yetkili.Text = gridView1.GetFocusedRowCellValue("Yetkili").ToString(); }
        }
    }
}
