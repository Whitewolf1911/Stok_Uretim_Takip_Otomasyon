
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
            this.listVSevkiyat = new System.Windows.Forms.ListView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pic_Urun = new System.Windows.Forms.PictureBox();
            this.Btn_SepeteEkle = new DevExpress.XtraEditors.SimpleButton();
            this.txt_adet = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Btn_Tamamla = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Yazdir = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.date_Tarih = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txt_firma = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Urun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_adet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Tarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Tarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_firma.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // listVSevkiyat
            // 
            this.listVSevkiyat.HideSelection = false;
            this.listVSevkiyat.Location = new System.Drawing.Point(1022, 111);
            this.listVSevkiyat.Name = "listVSevkiyat";
            this.listVSevkiyat.Size = new System.Drawing.Size(350, 327);
            this.listVSevkiyat.TabIndex = 0;
            this.listVSevkiyat.UseCompatibleStateImageBehavior = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(492, 364);
            this.gridControl1.TabIndex = 1;
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
            // pic_Urun
            // 
            this.pic_Urun.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_Urun.Location = new System.Drawing.Point(12, 382);
            this.pic_Urun.Name = "pic_Urun";
            this.pic_Urun.Size = new System.Drawing.Size(492, 234);
            this.pic_Urun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Urun.TabIndex = 2;
            this.pic_Urun.TabStop = false;
            // 
            // Btn_SepeteEkle
            // 
            this.Btn_SepeteEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.Btn_SepeteEkle.Location = new System.Drawing.Point(523, 349);
            this.Btn_SepeteEkle.Name = "Btn_SepeteEkle";
            this.Btn_SepeteEkle.Size = new System.Drawing.Size(180, 49);
            this.Btn_SepeteEkle.TabIndex = 3;
            this.Btn_SepeteEkle.Text = "Sepete Ekle";
            this.Btn_SepeteEkle.Click += new System.EventHandler(this.Btn_SepeteEkle_Click);
            // 
            // txt_adet
            // 
            this.txt_adet.Location = new System.Drawing.Point(578, 296);
            this.txt_adet.Name = "txt_adet";
            this.txt_adet.Size = new System.Drawing.Size(125, 22);
            this.txt_adet.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(528, 299);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 16);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Adet :";
            // 
            // Btn_Tamamla
            // 
            this.Btn_Tamamla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.Btn_Tamamla.Location = new System.Drawing.Point(519, 554);
            this.Btn_Tamamla.Name = "Btn_Tamamla";
            this.Btn_Tamamla.Size = new System.Drawing.Size(184, 63);
            this.Btn_Tamamla.TabIndex = 6;
            this.Btn_Tamamla.Text = "Sevkiyatı Tamamla";
            // 
            // Btn_Yazdir
            // 
            this.Btn_Yazdir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.Btn_Yazdir.Location = new System.Drawing.Point(519, 471);
            this.Btn_Yazdir.Name = "Btn_Yazdir";
            this.Btn_Yazdir.Size = new System.Drawing.Size(184, 63);
            this.Btn_Yazdir.TabIndex = 7;
            this.Btn_Yazdir.Text = "Yazdır";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(528, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 16);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Firma :";
            // 
            // date_Tarih
            // 
            this.date_Tarih.EditValue = null;
            this.date_Tarih.Location = new System.Drawing.Point(578, 240);
            this.date_Tarih.Name = "date_Tarih";
            this.date_Tarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_Tarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_Tarih.Size = new System.Drawing.Size(125, 22);
            this.date_Tarih.TabIndex = 10;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(528, 243);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 16);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Tarih :";
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(1323, 12);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(61, 59);
            this.pictureEdit2.TabIndex = 13;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image1")));
            this.simpleButton1.Location = new System.Drawing.Point(1200, 553);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(184, 63);
            this.simpleButton1.TabIndex = 14;
            this.simpleButton1.Text = "İptal";
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(582, 12);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(422, 202);
            this.gridControl2.TabIndex = 15;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // txt_firma
            // 
            this.txt_firma.Location = new System.Drawing.Point(1118, 19);
            this.txt_firma.Name = "txt_firma";
            this.txt_firma.Size = new System.Drawing.Size(155, 22);
            this.txt_firma.TabIndex = 16;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(1022, 22);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(87, 16);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "Seçilen Firma :";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(1022, 89);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(42, 16);
            this.labelControl5.TabIndex = 18;
            this.labelControl5.Text = "Sepet :";
            // 
            // Frm_YeniSevkiyat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 632);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txt_firma);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.date_Tarih);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.Btn_Yazdir);
            this.Controls.Add(this.Btn_Tamamla);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_adet);
            this.Controls.Add(this.Btn_SepeteEkle);
            this.Controls.Add(this.pic_Urun);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.listVSevkiyat);
            this.Name = "Frm_YeniSevkiyat";
            this.Text = "Yeni Sevkiyat";
            this.Load += new System.EventHandler(this.Frm_YeniSevkiyat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Urun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_adet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Tarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Tarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_firma.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listVSevkiyat;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.PictureBox pic_Urun;
        private DevExpress.XtraEditors.SimpleButton Btn_SepeteEkle;
        private DevExpress.XtraEditors.TextEdit txt_adet;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton Btn_Tamamla;
        private DevExpress.XtraEditors.SimpleButton Btn_Yazdir;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit date_Tarih;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.TextEdit txt_firma;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}