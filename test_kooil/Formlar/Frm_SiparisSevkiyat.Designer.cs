
namespace test_kooil.Formlar
{
    partial class Frm_SiparisSevkiyat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SiparisSevkiyat));
            this.listView1 = new System.Windows.Forms.ListView();
            this.num_Adet = new System.Windows.Forms.NumericUpDown();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.Btn_Iptal = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.date_Tarih = new DevExpress.XtraEditors.DateEdit();
            this.Btn_Yazdir = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Tamamla = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Btn_SepeteEkle = new DevExpress.XtraEditors.SimpleButton();
            this.pic_Urun = new System.Windows.Forms.PictureBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.num_Adet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Tarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Tarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Urun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(962, 75);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(354, 392);
            this.listView1.TabIndex = 36;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // num_Adet
            // 
            this.num_Adet.Location = new System.Drawing.Point(776, 145);
            this.num_Adet.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.num_Adet.Name = "num_Adet";
            this.num_Adet.Size = new System.Drawing.Size(125, 22);
            this.num_Adet.TabIndex = 35;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(962, 35);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(71, 16);
            this.labelControl5.TabIndex = 34;
            this.labelControl5.Text = "Sevkiyatlar :";
            // 
            // Btn_Iptal
            // 
            this.Btn_Iptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Iptal.ImageOptions.Image")));
            this.Btn_Iptal.Location = new System.Drawing.Point(1132, 557);
            this.Btn_Iptal.Name = "Btn_Iptal";
            this.Btn_Iptal.Size = new System.Drawing.Size(184, 63);
            this.Btn_Iptal.TabIndex = 30;
            this.Btn_Iptal.Text = "İptal";
            this.Btn_Iptal.Click += new System.EventHandler(this.Btn_Iptal_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(726, 89);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 16);
            this.labelControl3.TabIndex = 29;
            this.labelControl3.Text = "Tarih :";
            // 
            // date_Tarih
            // 
            this.date_Tarih.EditValue = null;
            this.date_Tarih.Location = new System.Drawing.Point(776, 86);
            this.date_Tarih.Name = "date_Tarih";
            this.date_Tarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_Tarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_Tarih.Properties.NullText = "Tarih Seçiniz";
            this.date_Tarih.Size = new System.Drawing.Size(125, 22);
            this.date_Tarih.TabIndex = 28;
            // 
            // Btn_Yazdir
            // 
            this.Btn_Yazdir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Yazdir.ImageOptions.Image")));
            this.Btn_Yazdir.Location = new System.Drawing.Point(524, 458);
            this.Btn_Yazdir.Name = "Btn_Yazdir";
            this.Btn_Yazdir.Size = new System.Drawing.Size(184, 63);
            this.Btn_Yazdir.TabIndex = 26;
            this.Btn_Yazdir.Text = "Yazdır";
            this.Btn_Yazdir.Click += new System.EventHandler(this.Btn_Yazdir_Click);
            // 
            // Btn_Tamamla
            // 
            this.Btn_Tamamla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Tamamla.ImageOptions.Image")));
            this.Btn_Tamamla.Location = new System.Drawing.Point(524, 541);
            this.Btn_Tamamla.Name = "Btn_Tamamla";
            this.Btn_Tamamla.Size = new System.Drawing.Size(184, 63);
            this.Btn_Tamamla.TabIndex = 25;
            this.Btn_Tamamla.Text = "Sevkiyatı Tamamla";
            this.Btn_Tamamla.Click += new System.EventHandler(this.Btn_Tamamla_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(726, 145);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 16);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "Adet :";
            // 
            // Btn_SepeteEkle
            // 
            this.Btn_SepeteEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_SepeteEkle.ImageOptions.Image")));
            this.Btn_SepeteEkle.Location = new System.Drawing.Point(726, 227);
            this.Btn_SepeteEkle.Name = "Btn_SepeteEkle";
            this.Btn_SepeteEkle.Size = new System.Drawing.Size(184, 59);
            this.Btn_SepeteEkle.TabIndex = 23;
            this.Btn_SepeteEkle.Text = "Sevkiyat Ekle";
            this.Btn_SepeteEkle.Click += new System.EventHandler(this.Btn_SepeteEkle_Click);
            // 
            // pic_Urun
            // 
            this.pic_Urun.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pic_Urun.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_Urun.Location = new System.Drawing.Point(12, 384);
            this.pic_Urun.Name = "pic_Urun";
            this.pic_Urun.Size = new System.Drawing.Size(492, 234);
            this.pic_Urun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Urun.TabIndex = 22;
            this.pic_Urun.TabStop = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 14);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(696, 364);
            this.gridControl1.TabIndex = 21;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // Frm_SiparisSevkiyat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 632);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.num_Adet);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.Btn_Iptal);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.date_Tarih);
            this.Controls.Add(this.Btn_Yazdir);
            this.Controls.Add(this.Btn_Tamamla);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.Btn_SepeteEkle);
            this.Controls.Add(this.pic_Urun);
            this.Controls.Add(this.gridControl1);
            this.Name = "Frm_SiparisSevkiyat";
            this.Text = "Yeni Sipariş Sevkiyat";
            this.Load += new System.EventHandler(this.Frm_SiparisSevkiyat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_Adet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Tarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Tarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Urun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.NumericUpDown num_Adet;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton Btn_Iptal;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit date_Tarih;
        private DevExpress.XtraEditors.SimpleButton Btn_Yazdir;
        private DevExpress.XtraEditors.SimpleButton Btn_Tamamla;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton Btn_SepeteEkle;
        private System.Windows.Forms.PictureBox pic_Urun;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}