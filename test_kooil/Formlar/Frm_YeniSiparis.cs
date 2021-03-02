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
    public partial class Frm_YeniSiparis : Form
    {
        public Frm_YeniSiparis()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void Frm_YeniSiparis_Load(object sender, EventArgs e)
        {
            var igneler = (from x in db.TBL_IGNELER
                           select new
                           {
                               x.ID,
                               x.IGNEKOD

                           });
            lookUpEdit_IgneCesit.Properties.ValueMember = "ID";
            lookUpEdit_IgneCesit.Properties.DisplayMember = "IGNEKOD";
            lookUpEdit_IgneCesit.Properties.DataSource = igneler.ToList();
            lookUpEdit_IgneCesit.Properties.PopulateColumns();
            lookUpEdit_IgneCesit.Properties.Columns[0].Visible = false;



        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //EKLE BUTONU
            try
            {
                TBL_SIPARIS yeniSiparis = new TBL_SIPARIS();
                yeniSiparis.AKTIF = true;
                int ignetipi = int.Parse(lookUpEdit_IgneCesit.EditValue.ToString());
                yeniSiparis.IGNETIPI = ignetipi;
                yeniSiparis.MUSTERI = txt_Musteri.Text;
                yeniSiparis.URUNADETI = int.Parse(num_Adet.Value.ToString());
                yeniSiparis.NOTLAR = txt_Not.Text;
                yeniSiparis.SIPARISTARIHI = (DateTime?)date_SiparisTarih.EditValue;
                yeniSiparis.ISTENILENTARIH = (DateTime?)date_IstenilenTarih.EditValue;
                yeniSiparis.SIPARISASAMASI = 1;
                var igneFiyati = db.TBL_IGNELER.Where(x => x.ID == ignetipi).Select(x => x.ADETFIYATI).FirstOrDefault();
                igneFiyati.ToString();
                yeniSiparis.TOPLAMTUTAR = int.Parse(num_Adet.Value.ToString()) * Convert.ToDecimal(igneFiyati);
                db.TBL_SIPARIS.Add(yeniSiparis);
                db.SaveChanges();
                XtraMessageBox.Show("Yeni Siparis Sisteme Eklendi. ", "Yeni Siparis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch {
                XtraMessageBox.Show("Lutfen Bos Alan birakmayiniz. ", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Btn_Vazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
