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
    public partial class Frm_HamRaporEkle : Form
    {
        public Frm_HamRaporEkle()
        {
            InitializeComponent();
        }
        DB_kooil_testEntities db = new DB_kooil_testEntities();
        void sipListele() {

            var siparisler = (from x in db.TBL_SIPARIS
                              select new
                              {
                                  x.SIPARISNOID,
                                  x.MUSTERI,
                                  x.TBL_IGNELER.TUR,
                                  x.TBL_IGNELER.IGNEKOD,
                                  x.PRESSAYI,
                                  x.AKTIF,


                              }).ToList().Where(x => x.AKTIF == true);

            gridControl1.DataSource = siparisler;
            gridView1.Columns[5].Visible = false;
        }


        void hamListele() {

            var hammadde = (from x in db.TBL_HAMMADDE
                            select new
                            {   x.ID,
                                x.KALINLIK,
                                x.GENISLIK,
                                x.OZELLIK,
                                x.MENSEI,
                                STOK = x.MIKTAR,
                                x.AKTIF
                            }).ToList().OrderBy(x => x.KALINLIK).Where(x => x.AKTIF ==true);

            gridControl2.DataSource = hammadde;
            gridView2.Columns[0].Visible = false;
            gridView2.Columns[6].Visible = false;
        }


        private void Frm_HamRaporEkle_Load(object sender, EventArgs e)
        {
            sipListele();
            hamListele();
            txt_raporlayan.Text = Frm_Login.user.AdSoyad;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //siparis
            txt_secilenSip.Text = gridView1.GetFocusedRowCellValue("TUR").ToString() + " - " + gridView1.GetFocusedRowCellValue("IGNEKOD").ToString();
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //hammadde 
            txt_secilenHam.Text = gridView2.GetFocusedRowCellValue("KALINLIK").ToString() + " x " + gridView2.GetFocusedRowCellValue("GENISLIK") + " " +
                                   gridView2.GetFocusedRowCellValue("MENSEI").ToString() +" " + gridView2.GetFocusedRowCellValue("OZELLIK").ToString();
        }

        private void Btn_Ekle_Click(object sender, EventArgs e)
        { 
            var maddeID = int.Parse(gridView2.GetFocusedRowCellValue("ID").ToString());
            var eksilenMadde = db.TBL_HAMMADDE.Find(maddeID);

            DateTime today = DateTime.Today;
            TBL_HAMRAPOR rapor = new TBL_HAMRAPOR();

            
            if (int.Parse(num_Miktar.Value.ToString()) < eksilenMadde.MIKTAR) {
                rapor.HAMKALINLIK = Convert.ToDecimal(gridView2.GetFocusedRowCellValue("KALINLIK").ToString());
                rapor.HAMGENISLIK = Convert.ToDecimal(gridView2.GetFocusedRowCellValue("GENISLIK").ToString());
                rapor.MENSEI = gridView2.GetFocusedRowCellValue("MENSEI").ToString();
                rapor.MUSTERI = gridView1.GetFocusedRowCellValue("MUSTERI").ToString();
                rapor.SIPARISNO = int.Parse(gridView1.GetFocusedRowCellValue("SIPARISNOID").ToString());
                rapor.URUNTIPI = gridView1.GetFocusedRowCellValue("TUR").ToString();
                rapor.URUNKODU = gridView1.GetFocusedRowCellValue("IGNEKOD").ToString();
                rapor.PRESSAYI = (int)num_PresAdet.Value;
                rapor.HAMHARCANAN = int.Parse(num_Miktar.Value.ToString());
                rapor.TARIH = today;
                rapor.RAPORLAYAN = txt_raporlayan.Text;
                rapor.OZELLIK = gridView2.GetFocusedRowCellValue("OZELLIK").ToString();
                db.TBL_HAMRAPOR.Add(rapor);
                eksilenMadde.MIKTAR -= int.Parse(num_Miktar.Value.ToString());
                db.SaveChanges();
                XtraMessageBox.Show("Hammadde Kullanım Raporu Sisteme Eklendi. ", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else { 
                XtraMessageBox.Show("Girdiğiniz Bilgileri Kontrol Ediniz. Stokta bulunandan fazla hammadde kullanamazsınız !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void Btn_Iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
