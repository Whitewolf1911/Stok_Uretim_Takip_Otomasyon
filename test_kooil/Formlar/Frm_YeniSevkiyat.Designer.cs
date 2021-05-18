
namespace test_kooil.Formlar
{
    partial class Frm_YeniSevkiyat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_YeniSevkiyat));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pic_Urun = new System.Windows.Forms.PictureBox();
            this.Btn_SepeteEkle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Btn_Tamamla = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Yazdir = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.date_Tarih = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.Btn_Iptal = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txt_firma = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.num_Adet = new System.Windows.Forms.NumericUpDown();
            this.listView1 = new System.Windows.Forms.ListView();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.Btn_firmaSec = new DevExpress.XtraEditors.SimpleButton();
            this.num_partiNo = new System.Windows.Forms.NumericUpDown();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Urun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Tarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Tarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_firma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Adet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_partiNo)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Location = new System.Drawing.Point(9, 10);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(369, 296);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // pic_Urun
            // 
            this.pic_Urun.BackColor = System.Drawing.SystemColors.Highlight;
            this.pic_Urun.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_Urun.Location = new System.Drawing.Point(9, 310);
            this.pic_Urun.Margin = new System.Windows.Forms.Padding(2);
            this.pic_Urun.Name = "pic_Urun";
            this.pic_Urun.Size = new System.Drawing.Size(370, 191);
            this.pic_Urun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Urun.TabIndex = 2;
            this.pic_Urun.TabStop = false;
            this.pic_Urun.DoubleClick += new System.EventHandler(this.pic_Urun_DoubleClick);
            // 
            // Btn_SepeteEkle
            // 
            this.Btn_SepeteEkle.Enabled = false;
            this.Btn_SepeteEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_SepeteEkle.ImageOptions.Image")));
            this.Btn_SepeteEkle.Location = new System.Drawing.Point(389, 320);
            this.Btn_SepeteEkle.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_SepeteEkle.Name = "Btn_SepeteEkle";
            this.Btn_SepeteEkle.Size = new System.Drawing.Size(138, 48);
            this.Btn_SepeteEkle.TabIndex = 3;
            this.Btn_SepeteEkle.Text = "Sepete Ekle";
            this.Btn_SepeteEkle.Click += new System.EventHandler(this.Btn_SepeteEkle_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(396, 243);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Adet :";
            // 
            // Btn_Tamamla
            // 
            this.Btn_Tamamla.Enabled = false;
            this.Btn_Tamamla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Tamamla.ImageOptions.Image")));
            this.Btn_Tamamla.Location = new System.Drawing.Point(389, 450);
            this.Btn_Tamamla.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Tamamla.Name = "Btn_Tamamla";
            this.Btn_Tamamla.Size = new System.Drawing.Size(138, 51);
            this.Btn_Tamamla.TabIndex = 6;
            this.Btn_Tamamla.Text = "Sevkiyatı Tamamla";
            this.Btn_Tamamla.Click += new System.EventHandler(this.Btn_Tamamla_Click);
            // 
            // Btn_Yazdir
            // 
            this.Btn_Yazdir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Yazdir.ImageOptions.Image")));
            this.Btn_Yazdir.Location = new System.Drawing.Point(389, 383);
            this.Btn_Yazdir.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Yazdir.Name = "Btn_Yazdir";
            this.Btn_Yazdir.Size = new System.Drawing.Size(138, 51);
            this.Btn_Yazdir.TabIndex = 7;
            this.Btn_Yazdir.Text = "Yazdır";
            this.Btn_Yazdir.Click += new System.EventHandler(this.Btn_Yazdir_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(396, 18);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Firma :";
            // 
            // date_Tarih
            // 
            this.date_Tarih.EditValue = null;
            this.date_Tarih.Location = new System.Drawing.Point(441, 194);
            this.date_Tarih.Margin = new System.Windows.Forms.Padding(2);
            this.date_Tarih.Name = "date_Tarih";
            this.date_Tarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_Tarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_Tarih.Properties.NullText = "Tarih Seçiniz";
            this.date_Tarih.Size = new System.Drawing.Size(108, 20);
            this.date_Tarih.TabIndex = 10;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(396, 197);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 13);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Tarih :";
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(992, 10);
            this.pictureEdit2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(46, 48);
            this.pictureEdit2.TabIndex = 13;
            // 
            // Btn_Iptal
            // 
            this.Btn_Iptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Iptal.ImageOptions.Image")));
            this.Btn_Iptal.Location = new System.Drawing.Point(900, 449);
            this.Btn_Iptal.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Iptal.Name = "Btn_Iptal";
            this.Btn_Iptal.Size = new System.Drawing.Size(138, 51);
            this.Btn_Iptal.TabIndex = 14;
            this.Btn_Iptal.Text = "İptal";
            this.Btn_Iptal.Click += new System.EventHandler(this.Btn_Iptal_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl2.Location = new System.Drawing.Point(436, 10);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(316, 164);
            this.gridControl2.TabIndex = 15;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl2.Click += new System.EventHandler(this.gridControl2_Click);
            // 
            // gridView2
            // 
            this.gridView2.DetailHeight = 284;
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            // 
            // txt_firma
            // 
            this.txt_firma.Location = new System.Drawing.Point(838, 15);
            this.txt_firma.Margin = new System.Windows.Forms.Padding(2);
            this.txt_firma.Name = "txt_firma";
            this.txt_firma.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_firma.Properties.Appearance.Options.UseBackColor = true;
            this.txt_firma.Properties.ReadOnly = true;
            this.txt_firma.Size = new System.Drawing.Size(116, 20);
            this.txt_firma.TabIndex = 16;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(766, 18);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(69, 13);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "Seçilen Firma :";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(766, 72);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(35, 13);
            this.labelControl5.TabIndex = 18;
            this.labelControl5.Text = "Sepet :";
            // 
            // num_Adet
            // 
            this.num_Adet.Location = new System.Drawing.Point(441, 242);
            this.num_Adet.Margin = new System.Windows.Forms.Padding(2);
            this.num_Adet.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.num_Adet.Name = "num_Adet";
            this.num_Adet.Size = new System.Drawing.Size(108, 20);
            this.num_Adet.TabIndex = 19;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(766, 105);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(266, 319);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
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
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // Btn_firmaSec
            // 
            this.Btn_firmaSec.Enabled = false;
            this.Btn_firmaSec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_firmaSec.ImageOptions.Image")));
            this.Btn_firmaSec.Location = new System.Drawing.Point(615, 187);
            this.Btn_firmaSec.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_firmaSec.Name = "Btn_firmaSec";
            this.Btn_firmaSec.Size = new System.Drawing.Size(138, 48);
            this.Btn_firmaSec.TabIndex = 21;
            this.Btn_firmaSec.Text = "Firma Seç";
            this.Btn_firmaSec.Click += new System.EventHandler(this.Btn_firmaSec_Click);
            // 
            // num_partiNo
            // 
            this.num_partiNo.Location = new System.Drawing.Point(441, 286);
            this.num_partiNo.Margin = new System.Windows.Forms.Padding(2);
            this.num_partiNo.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.num_partiNo.Name = "num_partiNo";
            this.num_partiNo.Size = new System.Drawing.Size(108, 20);
            this.num_partiNo.TabIndex = 23;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(395, 286);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(42, 13);
            this.labelControl6.TabIndex = 22;
            this.labelControl6.Text = "PartiNo :";
            // 
            // Frm_YeniSevkiyat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 514);
            this.Controls.Add(this.num_partiNo);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.Btn_firmaSec);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.num_Adet);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txt_firma);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.Btn_Iptal);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.date_Tarih);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.Btn_Yazdir);
            this.Controls.Add(this.Btn_Tamamla);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.Btn_SepeteEkle);
            this.Controls.Add(this.pic_Urun);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Frm_YeniSevkiyat";
            this.Text = "Yeni Perakende Sevkiyat";
            this.Load += new System.EventHandler(this.Frm_YeniSevkiyat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Urun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Tarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Tarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_firma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Adet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_partiNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.PictureBox pic_Urun;
        private DevExpress.XtraEditors.SimpleButton Btn_SepeteEkle;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton Btn_Tamamla;
        private DevExpress.XtraEditors.SimpleButton Btn_Yazdir;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit date_Tarih;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.SimpleButton Btn_Iptal;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.TextEdit txt_firma;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.NumericUpDown num_Adet;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private DevExpress.XtraEditors.SimpleButton Btn_firmaSec;
        private System.Windows.Forms.NumericUpDown num_partiNo;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}