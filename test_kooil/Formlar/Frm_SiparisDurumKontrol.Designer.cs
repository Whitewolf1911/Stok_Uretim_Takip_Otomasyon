﻿
namespace test_kooil.Formlar
{
    partial class Frm_SiparisDurumKontrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SiparisDurumKontrol));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.Btn_Yazdir = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.date_Ist_tarih = new DevExpress.XtraEditors.DateEdit();
            this.date_sipTarih = new DevExpress.XtraEditors.DateEdit();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_sipUrunKod = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit6 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit8 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit9 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit10 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txt_paketlenen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txt_musteri = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txt_sipNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txt_sipUrunTip = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Ist_tarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Ist_tarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_sipTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_sipTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sipUrunKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit9.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit10.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_paketlenen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_musteri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sipNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sipUrunTip.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.date_Ist_tarih);
            this.groupControl1.Controls.Add(this.Btn_Yazdir);
            this.groupControl1.Controls.Add(this.date_sipTarih);
            this.groupControl1.Controls.Add(this.Btn_Guncelle);
            this.groupControl1.Controls.Add(this.pictureEdit3);
            this.groupControl1.Controls.Add(this.pictureEdit10);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txt_sipUrunTip);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.txt_sipUrunKod);
            this.groupControl1.Controls.Add(this.txt_sipNo);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.txt_musteri);
            this.groupControl1.Controls.Add(this.pictureEdit6);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.pictureEdit8);
            this.groupControl1.Controls.Add(this.txt_paketlenen);
            this.groupControl1.Controls.Add(this.pictureEdit9);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Location = new System.Drawing.Point(3, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1536, 150);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Sipariş Kontrol";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // Btn_Yazdir
            // 
            this.Btn_Yazdir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Yazdir.ImageOptions.Image")));
            this.Btn_Yazdir.Location = new System.Drawing.Point(5, 92);
            this.Btn_Yazdir.Name = "Btn_Yazdir";
            this.Btn_Yazdir.Size = new System.Drawing.Size(174, 47);
            this.Btn_Yazdir.TabIndex = 29;
            this.Btn_Yazdir.Text = "Yazdır";
            this.Btn_Yazdir.Click += new System.EventHandler(this.Btn_Yazdir_Click);
            // 
            // Btn_Guncelle
            // 
            this.Btn_Guncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guncelle.ImageOptions.Image")));
            this.Btn_Guncelle.Location = new System.Drawing.Point(5, 37);
            this.Btn_Guncelle.Name = "Btn_Guncelle";
            this.Btn_Guncelle.Size = new System.Drawing.Size(174, 48);
            this.Btn_Guncelle.TabIndex = 0;
            this.Btn_Guncelle.Text = "Listeyi Yenile";
            this.Btn_Guncelle.Click += new System.EventHandler(this.Btn_Guncelle_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(3, 168);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1536, 604);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridView1_CustomUnboundColumnData_1);
            // 
            // date_Ist_tarih
            // 
            this.date_Ist_tarih.EditValue = null;
            this.date_Ist_tarih.Location = new System.Drawing.Point(693, 123);
            this.date_Ist_tarih.Name = "date_Ist_tarih";
            this.date_Ist_tarih.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.date_Ist_tarih.Properties.Appearance.Options.UseBackColor = true;
            this.date_Ist_tarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_Ist_tarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_Ist_tarih.Properties.ReadOnly = true;
            this.date_Ist_tarih.Size = new System.Drawing.Size(125, 22);
            this.date_Ist_tarih.TabIndex = 38;
            // 
            // date_sipTarih
            // 
            this.date_sipTarih.EditValue = null;
            this.date_sipTarih.Location = new System.Drawing.Point(694, 89);
            this.date_sipTarih.Name = "date_sipTarih";
            this.date_sipTarih.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.date_sipTarih.Properties.Appearance.Options.UseBackColor = true;
            this.date_sipTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_sipTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_sipTarih.Properties.ReadOnly = true;
            this.date_sipTarih.Size = new System.Drawing.Size(125, 22);
            this.date_sipTarih.TabIndex = 37;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(540, 101);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Size = new System.Drawing.Size(40, 34);
            this.pictureEdit3.TabIndex = 36;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(596, 126);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(91, 16);
            this.labelControl8.TabIndex = 35;
            this.labelControl8.Text = "İstenilen Tarih :";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(602, 89);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(85, 16);
            this.labelControl7.TabIndex = 33;
            this.labelControl7.Text = "Sipariş Tarihi :";
            // 
            // txt_sipUrunKod
            // 
            this.txt_sipUrunKod.Location = new System.Drawing.Point(341, 123);
            this.txt_sipUrunKod.Name = "txt_sipUrunKod";
            this.txt_sipUrunKod.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_sipUrunKod.Properties.Appearance.Options.UseBackColor = true;
            this.txt_sipUrunKod.Properties.ReadOnly = true;
            this.txt_sipUrunKod.Size = new System.Drawing.Size(143, 22);
            this.txt_sipUrunKod.TabIndex = 31;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(260, 126);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 16);
            this.labelControl2.TabIndex = 30;
            this.labelControl2.Text = "Ürün Kodu :";
            // 
            // pictureEdit6
            // 
            this.pictureEdit6.EditValue = ((object)(resources.GetObject("pictureEdit6.EditValue")));
            this.pictureEdit6.Location = new System.Drawing.Point(208, 91);
            this.pictureEdit6.Name = "pictureEdit6";
            this.pictureEdit6.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit6.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit6.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit6.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit6.Size = new System.Drawing.Size(36, 44);
            this.pictureEdit6.TabIndex = 28;
            // 
            // pictureEdit8
            // 
            this.pictureEdit8.EditValue = ((object)(resources.GetObject("pictureEdit8.EditValue")));
            this.pictureEdit8.Location = new System.Drawing.Point(989, 101);
            this.pictureEdit8.Name = "pictureEdit8";
            this.pictureEdit8.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit8.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit8.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit8.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit8.Size = new System.Drawing.Size(40, 34);
            this.pictureEdit8.TabIndex = 23;
            // 
            // pictureEdit9
            // 
            this.pictureEdit9.EditValue = ((object)(resources.GetObject("pictureEdit9.EditValue")));
            this.pictureEdit9.Location = new System.Drawing.Point(590, 44);
            this.pictureEdit9.Name = "pictureEdit9";
            this.pictureEdit9.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit9.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit9.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit9.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit9.Size = new System.Drawing.Size(40, 34);
            this.pictureEdit9.TabIndex = 20;
            // 
            // pictureEdit10
            // 
            this.pictureEdit10.EditValue = ((object)(resources.GetObject("pictureEdit10.EditValue")));
            this.pictureEdit10.Location = new System.Drawing.Point(208, 37);
            this.pictureEdit10.Name = "pictureEdit10";
            this.pictureEdit10.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit10.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit10.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit10.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit10.Size = new System.Drawing.Size(40, 34);
            this.pictureEdit10.TabIndex = 19;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(1045, 114);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(71, 16);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "Paketlenen :";
            // 
            // txt_paketlenen
            // 
            this.txt_paketlenen.Location = new System.Drawing.Point(1139, 111);
            this.txt_paketlenen.Name = "txt_paketlenen";
            this.txt_paketlenen.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_paketlenen.Properties.Appearance.Options.UseBackColor = true;
            this.txt_paketlenen.Properties.ReadOnly = true;
            this.txt_paketlenen.Size = new System.Drawing.Size(143, 22);
            this.txt_paketlenen.TabIndex = 17;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(636, 56);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(51, 16);
            this.labelControl10.TabIndex = 16;
            this.labelControl10.Text = "Müşteri :";
            // 
            // txt_musteri
            // 
            this.txt_musteri.Location = new System.Drawing.Point(693, 53);
            this.txt_musteri.Name = "txt_musteri";
            this.txt_musteri.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_musteri.Properties.Appearance.Options.UseBackColor = true;
            this.txt_musteri.Properties.ReadOnly = true;
            this.txt_musteri.Size = new System.Drawing.Size(143, 22);
            this.txt_musteri.TabIndex = 15;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(268, 52);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(67, 16);
            this.labelControl11.TabIndex = 12;
            this.labelControl11.Text = "Sipariş No :";
            // 
            // txt_sipNo
            // 
            this.txt_sipNo.Location = new System.Drawing.Point(341, 49);
            this.txt_sipNo.Name = "txt_sipNo";
            this.txt_sipNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_sipNo.Properties.Appearance.Options.UseBackColor = true;
            this.txt_sipNo.Properties.ReadOnly = true;
            this.txt_sipNo.Size = new System.Drawing.Size(143, 22);
            this.txt_sipNo.TabIndex = 11;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(267, 89);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(61, 16);
            this.labelControl12.TabIndex = 9;
            this.labelControl12.Text = "Ürün Tipi :";
            // 
            // txt_sipUrunTip
            // 
            this.txt_sipUrunTip.Location = new System.Drawing.Point(341, 86);
            this.txt_sipUrunTip.Name = "txt_sipUrunTip";
            this.txt_sipUrunTip.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_sipUrunTip.Properties.Appearance.Options.UseBackColor = true;
            this.txt_sipUrunTip.Properties.ReadOnly = true;
            this.txt_sipUrunTip.Size = new System.Drawing.Size(143, 22);
            this.txt_sipUrunTip.TabIndex = 8;
            // 
            // Frm_SiparisDurumKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1554, 775);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Frm_SiparisDurumKontrol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş Durum Kontrol";
            this.Load += new System.EventHandler(this.Frm_SiparisDurumKontrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Ist_tarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Ist_tarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_sipTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_sipTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sipUrunKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit9.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit10.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_paketlenen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_musteri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sipNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sipUrunTip.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton Btn_Yazdir;
        private DevExpress.XtraEditors.SimpleButton Btn_Guncelle;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.DateEdit date_Ist_tarih;
        private DevExpress.XtraEditors.DateEdit date_sipTarih;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit10;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txt_sipUrunTip;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txt_sipUrunKod;
        private DevExpress.XtraEditors.TextEdit txt_sipNo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txt_musteri;
        private DevExpress.XtraEditors.PictureEdit pictureEdit6;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.PictureEdit pictureEdit8;
        private DevExpress.XtraEditors.TextEdit txt_paketlenen;
        private DevExpress.XtraEditors.PictureEdit pictureEdit9;
        private DevExpress.XtraEditors.LabelControl labelControl9;
    }
}