
namespace test_kooil.Formlar
{
    partial class Frm_YeniIade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_YeniIade));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.num_adet = new System.Windows.Forms.NumericUpDown();
            this.lookUp_firma = new DevExpress.XtraEditors.LookUpEdit();
            this.num_sipNo = new System.Windows.Forms.NumericUpDown();
            this.pictureEdit6 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.date_tarih = new DevExpress.XtraEditors.DateEdit();
            this.Btn_iptal = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txt_neden = new System.Windows.Forms.RichTextBox();
            this.pictureEdit5 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit4 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_UrunKod = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_adet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUp_firma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_sipNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_tarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_tarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_UrunKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.num_adet);
            this.groupControl1.Controls.Add(this.lookUp_firma);
            this.groupControl1.Controls.Add(this.num_sipNo);
            this.groupControl1.Controls.Add(this.pictureEdit6);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.date_tarih);
            this.groupControl1.Controls.Add(this.Btn_iptal);
            this.groupControl1.Controls.Add(this.Btn_Kaydet);
            this.groupControl1.Controls.Add(this.txt_neden);
            this.groupControl1.Controls.Add(this.pictureEdit5);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.pictureEdit4);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.pictureEdit3);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.pictureEdit2);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txt_UrunKod);
            this.groupControl1.Controls.Add(this.pictureEdit1);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(429, 533);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "İade";
            // 
            // num_adet
            // 
            this.num_adet.Location = new System.Drawing.Point(171, 105);
            this.num_adet.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.num_adet.Name = "num_adet";
            this.num_adet.Size = new System.Drawing.Size(185, 23);
            this.num_adet.TabIndex = 113;
            // 
            // lookUp_firma
            // 
            this.lookUp_firma.Location = new System.Drawing.Point(171, 161);
            this.lookUp_firma.Name = "lookUp_firma";
            this.lookUp_firma.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUp_firma.Properties.NullText = "Firma Seçiniz";
            this.lookUp_firma.Size = new System.Drawing.Size(185, 22);
            this.lookUp_firma.TabIndex = 112;
            // 
            // num_sipNo
            // 
            this.num_sipNo.Location = new System.Drawing.Point(171, 217);
            this.num_sipNo.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.num_sipNo.Name = "num_sipNo";
            this.num_sipNo.Size = new System.Drawing.Size(185, 23);
            this.num_sipNo.TabIndex = 111;
            // 
            // pictureEdit6
            // 
            this.pictureEdit6.EditValue = ((object)(resources.GetObject("pictureEdit6.EditValue")));
            this.pictureEdit6.Location = new System.Drawing.Point(5, 256);
            this.pictureEdit6.Name = "pictureEdit6";
            this.pictureEdit6.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit6.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit6.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit6.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit6.Size = new System.Drawing.Size(63, 59);
            this.pictureEdit6.TabIndex = 110;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(81, 275);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(39, 16);
            this.labelControl6.TabIndex = 109;
            this.labelControl6.Text = "Tarih :";
            // 
            // date_tarih
            // 
            this.date_tarih.EditValue = null;
            this.date_tarih.Location = new System.Drawing.Point(171, 274);
            this.date_tarih.Name = "date_tarih";
            this.date_tarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_tarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_tarih.Size = new System.Drawing.Size(125, 22);
            this.date_tarih.TabIndex = 108;
            // 
            // Btn_iptal
            // 
            this.Btn_iptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_iptal.ImageOptions.Image")));
            this.Btn_iptal.Location = new System.Drawing.Point(276, 467);
            this.Btn_iptal.Name = "Btn_iptal";
            this.Btn_iptal.Size = new System.Drawing.Size(148, 61);
            this.Btn_iptal.TabIndex = 107;
            this.Btn_iptal.Text = "İptal";
            this.Btn_iptal.Click += new System.EventHandler(this.Btn_iptal_Click);
            // 
            // Btn_Kaydet
            // 
            this.Btn_Kaydet.Enabled = false;
            this.Btn_Kaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Kaydet.ImageOptions.Image")));
            this.Btn_Kaydet.Location = new System.Drawing.Point(5, 467);
            this.Btn_Kaydet.Name = "Btn_Kaydet";
            this.Btn_Kaydet.Size = new System.Drawing.Size(144, 61);
            this.Btn_Kaydet.TabIndex = 106;
            this.Btn_Kaydet.Text = "Ekle";
            this.Btn_Kaydet.Click += new System.EventHandler(this.Btn_Kaydet_Click);
            // 
            // txt_neden
            // 
            this.txt_neden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_neden.Location = new System.Drawing.Point(171, 331);
            this.txt_neden.MaxLength = 99;
            this.txt_neden.Name = "txt_neden";
            this.txt_neden.Size = new System.Drawing.Size(185, 100);
            this.txt_neden.TabIndex = 105;
            this.txt_neden.Text = "";
            // 
            // pictureEdit5
            // 
            this.pictureEdit5.EditValue = ((object)(resources.GetObject("pictureEdit5.EditValue")));
            this.pictureEdit5.Location = new System.Drawing.Point(5, 312);
            this.pictureEdit5.Name = "pictureEdit5";
            this.pictureEdit5.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit5.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit5.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit5.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit5.Size = new System.Drawing.Size(63, 59);
            this.pictureEdit5.TabIndex = 104;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(81, 331);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(45, 16);
            this.labelControl5.TabIndex = 103;
            this.labelControl5.Text = "Neden :";
            // 
            // pictureEdit4
            // 
            this.pictureEdit4.EditValue = ((object)(resources.GetObject("pictureEdit4.EditValue")));
            this.pictureEdit4.Location = new System.Drawing.Point(5, 198);
            this.pictureEdit4.Name = "pictureEdit4";
            this.pictureEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit4.Size = new System.Drawing.Size(63, 59);
            this.pictureEdit4.TabIndex = 101;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(81, 217);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 16);
            this.labelControl4.TabIndex = 100;
            this.labelControl4.Text = "Sipariş No :";
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(5, 88);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Size = new System.Drawing.Size(63, 59);
            this.pictureEdit3.TabIndex = 98;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(81, 107);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 16);
            this.labelControl3.TabIndex = 97;
            this.labelControl3.Text = "Adet :";
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(5, 142);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Size = new System.Drawing.Size(63, 59);
            this.pictureEdit2.TabIndex = 95;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(81, 161);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 16);
            this.labelControl2.TabIndex = 94;
            this.labelControl2.Text = "Firma :";
            // 
            // txt_UrunKod
            // 
            this.txt_UrunKod.Location = new System.Drawing.Point(171, 56);
            this.txt_UrunKod.Name = "txt_UrunKod";
            this.txt_UrunKod.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txt_UrunKod.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_UrunKod.Properties.Appearance.Options.UseBackColor = true;
            this.txt_UrunKod.Properties.ReadOnly = true;
            this.txt_UrunKod.Size = new System.Drawing.Size(185, 22);
            this.txt_UrunKod.TabIndex = 93;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(5, 40);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(63, 59);
            this.pictureEdit1.TabIndex = 92;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(81, 59);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 16);
            this.labelControl1.TabIndex = 91;
            this.labelControl1.Text = "Ürün Kodu :";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(456, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(443, 533);
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
            // Frm_YeniIade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 557);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "Frm_YeniIade";
            this.Text = "Yeni İade";
            this.Load += new System.EventHandler(this.Frm_YeniIade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_adet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUp_firma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_sipNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_tarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_tarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_UrunKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RichTextBox txt_neden;
        private DevExpress.XtraEditors.PictureEdit pictureEdit5;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.PictureEdit pictureEdit4;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_UrunKod;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.NumericUpDown num_adet;
        private DevExpress.XtraEditors.LookUpEdit lookUp_firma;
        private System.Windows.Forms.NumericUpDown num_sipNo;
        private DevExpress.XtraEditors.PictureEdit pictureEdit6;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit date_tarih;
        private DevExpress.XtraEditors.SimpleButton Btn_iptal;
        private DevExpress.XtraEditors.SimpleButton Btn_Kaydet;
    }
}