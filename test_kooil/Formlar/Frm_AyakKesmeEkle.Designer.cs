
namespace test_kooil.Formlar
{
    partial class Frm_AyakKesmeEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AyakKesmeEkle));
            this.date_BasimTarihi = new DevExpress.XtraEditors.DateEdit();
            this.pictureEdit5 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.Btn_iptal = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit4 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.text_Not = new System.Windows.Forms.RichTextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.text_Raporlayan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.num_IslenenAdet = new System.Windows.Forms.NumericUpDown();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lookUp_Siparis = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.date_BasimTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_BasimTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_Raporlayan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_IslenenAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUp_Siparis.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // date_BasimTarihi
            // 
            this.date_BasimTarihi.EditValue = null;
            this.date_BasimTarihi.Location = new System.Drawing.Point(176, 190);
            this.date_BasimTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.date_BasimTarihi.Name = "date_BasimTarihi";
            this.date_BasimTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_BasimTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_BasimTarihi.Size = new System.Drawing.Size(135, 20);
            this.date_BasimTarihi.TabIndex = 70;
            // 
            // pictureEdit5
            // 
            this.pictureEdit5.EditValue = ((object)(resources.GetObject("pictureEdit5.EditValue")));
            this.pictureEdit5.Location = new System.Drawing.Point(38, 177);
            this.pictureEdit5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureEdit5.Name = "pictureEdit5";
            this.pictureEdit5.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit5.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit5.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit5.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit5.Size = new System.Drawing.Size(39, 42);
            this.pictureEdit5.TabIndex = 69;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(116, 190);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(31, 13);
            this.labelControl4.TabIndex = 68;
            this.labelControl4.Text = "Tarih :";
            // 
            // Btn_iptal
            // 
            this.Btn_iptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_iptal.ImageOptions.Image")));
            this.Btn_iptal.Location = new System.Drawing.Point(298, 405);
            this.Btn_iptal.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_iptal.Name = "Btn_iptal";
            this.Btn_iptal.Size = new System.Drawing.Size(129, 50);
            this.Btn_iptal.TabIndex = 67;
            this.Btn_iptal.Text = "İptal";
            this.Btn_iptal.Click += new System.EventHandler(this.Btn_iptal_Click);
            // 
            // Btn_Kaydet
            // 
            this.Btn_Kaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Kaydet.ImageOptions.Image")));
            this.Btn_Kaydet.Location = new System.Drawing.Point(38, 405);
            this.Btn_Kaydet.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Kaydet.Name = "Btn_Kaydet";
            this.Btn_Kaydet.Size = new System.Drawing.Size(129, 50);
            this.Btn_Kaydet.TabIndex = 66;
            this.Btn_Kaydet.Text = "Kaydet";
            this.Btn_Kaydet.Click += new System.EventHandler(this.Btn_Kaydet_Click);
            // 
            // pictureEdit4
            // 
            this.pictureEdit4.EditValue = ((object)(resources.GetObject("pictureEdit4.EditValue")));
            this.pictureEdit4.Location = new System.Drawing.Point(38, 80);
            this.pictureEdit4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureEdit4.Name = "pictureEdit4";
            this.pictureEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit4.Size = new System.Drawing.Size(39, 42);
            this.pictureEdit4.TabIndex = 65;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(38, 229);
            this.pictureEdit3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Size = new System.Drawing.Size(39, 42);
            this.pictureEdit3.TabIndex = 64;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(38, 130);
            this.pictureEdit2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Size = new System.Drawing.Size(39, 42);
            this.pictureEdit2.TabIndex = 63;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(29, 28);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(47, 48);
            this.pictureEdit1.TabIndex = 62;
            // 
            // text_Not
            // 
            this.text_Not.Location = new System.Drawing.Point(176, 236);
            this.text_Not.Margin = new System.Windows.Forms.Padding(2);
            this.text_Not.MaxLength = 99;
            this.text_Not.Name = "text_Not";
            this.text_Not.Size = new System.Drawing.Size(154, 137);
            this.text_Not.TabIndex = 61;
            this.text_Not.Text = "";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(124, 236);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 13);
            this.labelControl5.TabIndex = 60;
            this.labelControl5.Text = "Not :";
            // 
            // text_Raporlayan
            // 
            this.text_Raporlayan.Enabled = false;
            this.text_Raporlayan.Location = new System.Drawing.Point(176, 141);
            this.text_Raporlayan.Margin = new System.Windows.Forms.Padding(2);
            this.text_Raporlayan.Name = "text_Raporlayan";
            this.text_Raporlayan.Size = new System.Drawing.Size(135, 20);
            this.text_Raporlayan.TabIndex = 59;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(91, 143);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 13);
            this.labelControl3.TabIndex = 58;
            this.labelControl3.Text = "Raporlayan :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(91, 93);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 13);
            this.labelControl2.TabIndex = 57;
            this.labelControl2.Text = "İşlenen Adet :";
            // 
            // num_IslenenAdet
            // 
            this.num_IslenenAdet.Location = new System.Drawing.Point(176, 89);
            this.num_IslenenAdet.Margin = new System.Windows.Forms.Padding(2);
            this.num_IslenenAdet.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.num_IslenenAdet.Name = "num_IslenenAdet";
            this.num_IslenenAdet.Size = new System.Drawing.Size(135, 20);
            this.num_IslenenAdet.TabIndex = 56;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(91, 48);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 13);
            this.labelControl1.TabIndex = 55;
            this.labelControl1.Text = "Sipariş :";
            // 
            // lookUp_Siparis
            // 
            this.lookUp_Siparis.Location = new System.Drawing.Point(176, 46);
            this.lookUp_Siparis.Margin = new System.Windows.Forms.Padding(2);
            this.lookUp_Siparis.Name = "lookUp_Siparis";
            this.lookUp_Siparis.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUp_Siparis.Properties.NullText = "Sipariş Seçiniz";
            this.lookUp_Siparis.Size = new System.Drawing.Size(252, 20);
            this.lookUp_Siparis.TabIndex = 54;
            // 
            // Frm_AyakKesmeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 483);
            this.Controls.Add(this.date_BasimTarihi);
            this.Controls.Add(this.pictureEdit5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.Btn_iptal);
            this.Controls.Add(this.Btn_Kaydet);
            this.Controls.Add(this.pictureEdit4);
            this.Controls.Add(this.pictureEdit3);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.text_Not);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.text_Raporlayan);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.num_IslenenAdet);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lookUp_Siparis);
            this.Name = "Frm_AyakKesmeEkle";
            this.Text = "Ayak Kesme Ekle";
            this.Load += new System.EventHandler(this.Frm_AyakKesmeEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.date_BasimTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_BasimTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_Raporlayan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_IslenenAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUp_Siparis.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.DateEdit date_BasimTarihi;
        private DevExpress.XtraEditors.PictureEdit pictureEdit5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton Btn_iptal;
        private DevExpress.XtraEditors.SimpleButton Btn_Kaydet;
        private DevExpress.XtraEditors.PictureEdit pictureEdit4;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.RichTextBox text_Not;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit text_Raporlayan;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.NumericUpDown num_IslenenAdet;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUp_Siparis;
    }
}