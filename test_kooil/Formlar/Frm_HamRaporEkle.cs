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
            try
            {
                var siparisler = (from x in db.TBL_SIPARIS
                                  select new
                                  {
                                      SiparişNo = x.SIPARISNOID,
                                      PartiNo = x.PARTINO,
                                      Müşteri = x.MUSTERI,
                                      Tür = x.TBL_IGNELER.TUR,
                                      ÜrünKodu = x.TBL_IGNELER.IGNEKOD,
                                      Preslenen = x.PRESSAYI,
                                      x.AKTIF,


                                  }).ToList().Where(x => x.AKTIF == true);

                gridControl1.DataSource = siparisler;
                gridView1.Columns[6].Visible = false;
            }
            catch (Exception) { }
        }


        void hamListele() {
            try
            {
                var hammadde = (from x in db.TBL_HAMMADDE
                                select new
                                {
                                    x.ID,
                                    Kalınlık = x.KALINLIK,
                                    Genişlik = x.GENISLIK,
                                    Özellik = x.OZELLIK,
                                    Menşei = x.MENSEI,
                                    Stok = x.MIKTAR,
                                    x.AKTIF
                                }).ToList().OrderBy(x => x.Kalınlık).Where(x => x.AKTIF == true);

                gridControl2.DataSource = hammadde;
                gridView2.Columns[0].Visible = false;
                gridView2.Columns[6].Visible = false;
            }
            catch (Exception) { }
        }


        private void Frm_HamRaporEkle_Load(object sender, EventArgs e)
        {
            sipListele();
            hamListele();
            txt_raporlayan.Text = Frm_Login.user.AdSoyad;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            gridControl2.Enabled = true;
            //siparis
            txt_secilenSip.Text = gridView1.GetFocusedRowCellValue("Tür").ToString() + " - " + gridView1.GetFocusedRowCellValue("ÜrünKodu").ToString();
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //hammadde 
            Btn_Ekle.Enabled = true;
            txt_secilenHam.Text = gridView2.GetFocusedRowCellValue("Kalınlık").ToString() + " x " + gridView2.GetFocusedRowCellValue("Genişlik") + " " +
                                   gridView2.GetFocusedRowCellValue("Menşei").ToString() +" " + gridView2.GetFocusedRowCellValue("Özellik").ToString();
        }

        private void Btn_Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                var maddeID = int.Parse(gridView2.GetFocusedRowCellValue("ID").ToString());
                var eksilenMadde = db.TBL_HAMMADDE.Find(maddeID);

                DateTime today = DateTime.Today;
                TBL_HAMRAPOR rapor = new TBL_HAMRAPOR();


                if (int.Parse(num_Miktar.Value.ToString()) < eksilenMadde.MIKTAR)
                {
                    rapor.HAMKALINLIK = Convert.ToDecimal(gridView2.GetFocusedRowCellValue("Kalınlık").ToString());
                    rapor.HAMGENISLIK = Convert.ToDecimal(gridView2.GetFocusedRowCellValue("Genişlik").ToString());
                    rapor.MENSEI = gridView2.GetFocusedRowCellValue("Menşei").ToString();
                    rapor.PARTINO = (int)gridView1.GetFocusedRowCellValue("PartiNo");
                    rapor.MUSTERI = gridView1.GetFocusedRowCellValue("Müşteri").ToString();
                    rapor.SIPARISNO = int.Parse(gridView1.GetFocusedRowCellValue("SiparişNo").ToString());
                    rapor.URUNTIPI = gridView1.GetFocusedRowCellValue("Tür").ToString();
                    rapor.URUNKODU = gridView1.GetFocusedRowCellValue("ÜrünKodu").ToString();
                    rapor.PRESSAYI = (int)num_PresAdet.Value;
                    rapor.HAMHARCANAN = int.Parse(num_Miktar.Value.ToString());
                    rapor.TARIH = today;
                    rapor.RAPORLAYAN = txt_raporlayan.Text;
                    rapor.OZELLIK = gridView2.GetFocusedRowCellValue("Özellik").ToString();
                    db.TBL_HAMRAPOR.Add(rapor);
                    eksilenMadde.MIKTAR -= int.Parse(num_Miktar.Value.ToString());
                    db.SaveChanges();
                    XtraMessageBox.Show("Hammadde Kullanım Raporu Sisteme Eklendi. ", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("Girdiğiniz Bilgileri Kontrol Ediniz. Stokta bulunandan fazla hammadde kullanamazsınız !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception) { }


        }

        private void Btn_Iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
