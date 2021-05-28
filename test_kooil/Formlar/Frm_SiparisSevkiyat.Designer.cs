
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
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Btn_FirmaSec = new DevExpress.XtraEditors.SimpleButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_firma = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_barkod = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Adet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Tarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Tarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Urun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_firma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_barkod.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(1125, 98);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(324, 392);
            this.listView1.TabIndex = 36;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // num_Adet
            // 
            this.num_Adet.Location = new System.Drawing.Point(977, 169);
            this.num_Adet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num_Adet.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.num_Adet.Name = "num_Adet";
            this.num_Adet.Size = new System.Drawing.Size(133, 22);
            this.num_Adet.TabIndex = 35;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(1125, 76);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(71, 16);
            this.labelControl5.TabIndex = 34;
            this.labelControl5.Text = "Sevkiyatlar :";
            // 
            // Btn_Iptal
            // 
            this.Btn_Iptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Iptal.ImageOptions.Image")));
            this.Btn_Iptal.Location = new System.Drawing.Point(1132, 558);
            this.Btn_Iptal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Iptal.Name = "Btn_Iptal";
            this.Btn_Iptal.Size = new System.Drawing.Size(184, 63);
            this.Btn_Iptal.TabIndex = 30;
            this.Btn_Iptal.Text = "İptal";
            this.Btn_Iptal.Click += new System.EventHandler(this.Btn_Iptal_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(927, 113);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 16);
            this.labelControl3.TabIndex = 29;
            this.labelControl3.Text = "Tarih :";
            // 
            // date_Tarih
            // 
            this.date_Tarih.EditValue = null;
            this.date_Tarih.Location = new System.Drawing.Point(977, 110);
            this.date_Tarih.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_Tarih.Name = "date_Tarih";
            this.date_Tarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_Tarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_Tarih.Properties.NullText = "Tarih Seçiniz";
            this.date_Tarih.Size = new System.Drawing.Size(133, 22);
            this.date_Tarih.TabIndex = 28;
            // 
            // Btn_Yazdir
            // 
            this.Btn_Yazdir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Yazdir.ImageOptions.Image")));
            this.Btn_Yazdir.Location = new System.Drawing.Point(524, 458);
            this.Btn_Yazdir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Yazdir.Name = "Btn_Yazdir";
            this.Btn_Yazdir.Size = new System.Drawing.Size(184, 63);
            this.Btn_Yazdir.TabIndex = 26;
            this.Btn_Yazdir.Text = "Yazdır";
            this.Btn_Yazdir.Click += new System.EventHandler(this.Btn_Yazdir_Click);
            // 
            // Btn_Tamamla
            // 
            this.Btn_Tamamla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Tamamla.ImageOptions.Image")));
            this.Btn_Tamamla.Location = new System.Drawing.Point(524, 542);
            this.Btn_Tamamla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Tamamla.Name = "Btn_Tamamla";
            this.Btn_Tamamla.Size = new System.Drawing.Size(184, 63);
            this.Btn_Tamamla.TabIndex = 25;
            this.Btn_Tamamla.Text = "Sevkiyatı Tamamla";
            this.Btn_Tamamla.Click += new System.EventHandler(this.Btn_Tamamla_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(927, 169);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 16);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "Adet :";
            // 
            // Btn_SepeteEkle
            // 
            this.Btn_SepeteEkle.Enabled = false;
            this.Btn_SepeteEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_SepeteEkle.ImageOptions.Image")));
            this.Btn_SepeteEkle.Location = new System.Drawing.Point(927, 306);
            this.Btn_SepeteEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.pic_Urun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_Urun.Name = "pic_Urun";
            this.pic_Urun.Size = new System.Drawing.Size(492, 234);
            this.pic_Urun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Urun.TabIndex = 22;
            this.pic_Urun.TabStop = false;
            this.pic_Urun.DoubleClick += new System.EventHandler(this.pic_Urun_DoubleClick);
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(293, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(627, 364);
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
            // gridControl2
            // 
            this.gridControl2.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl2.Location = new System.Drawing.Point(27, 2);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(261, 293);
            this.gridControl2.TabIndex = 37;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            // 
            // Btn_FirmaSec
            // 
            this.Btn_FirmaSec.Enabled = false;
            this.Btn_FirmaSec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_FirmaSec.ImageOptions.Image")));
            this.Btn_FirmaSec.Location = new System.Drawing.Point(60, 311);
            this.Btn_FirmaSec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_FirmaSec.Name = "Btn_FirmaSec";
            this.Btn_FirmaSec.Size = new System.Drawing.Size(184, 59);
            this.Btn_FirmaSec.TabIndex = 38;
            this.Btn_FirmaSec.Text = "Firma Seç";
            this.Btn_FirmaSec.Click += new System.EventHandler(this.Btn_FirmaSec_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(927, 58);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 16);
            this.labelControl2.TabIndex = 39;
            this.labelControl2.Text = "Firma :";
            // 
            // txt_firma
            // 
            this.txt_firma.Location = new System.Drawing.Point(977, 58);
            this.txt_firma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_firma.Name = "txt_firma";
            this.txt_firma.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_firma.Properties.Appearance.Options.UseBackColor = true;
            this.txt_firma.Properties.ReadOnly = true;
            this.txt_firma.Size = new System.Drawing.Size(133, 22);
            this.txt_firma.TabIndex = 40;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(851, 396);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 16);
            this.labelControl4.TabIndex = 41;
            this.labelControl4.Text = "Barkod :";
            // 
            // txt_barkod
            // 
            this.txt_barkod.Location = new System.Drawing.Point(927, 393);
            this.txt_barkod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_barkod.Name = "txt_barkod";
            this.txt_barkod.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_barkod.Properties.Appearance.Options.UseBackColor = true;
            this.txt_barkod.Properties.MaxLength = 25;
            this.txt_barkod.Size = new System.Drawing.Size(166, 22);
            this.txt_barkod.TabIndex = 42;
            // 
            // Frm_SiparisSevkiyat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 633);
            this.Controls.Add(this.txt_barkod);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txt_firma);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.Btn_FirmaSec);
            this.Controls.Add(this.gridControl2);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Frm_SiparisSevkiyat";
            this.Text = "Yeni Sipariş Sevkiyat";
            this.Load += new System.EventHandler(this.Frm_SiparisSevkiyat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_Adet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Tarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Tarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Urun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_firma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_barkod.Properties)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton Btn_FirmaSec;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_firma;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_barkod;
    }
}