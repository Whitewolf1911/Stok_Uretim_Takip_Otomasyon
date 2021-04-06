
namespace test_kooil.Formlar
{
    partial class Frm_YeniSiparis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_YeniSiparis));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.date_IstenilenTarih = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.num_Adet = new System.Windows.Forms.NumericUpDown();
            this.date_SiparisTarih = new DevExpress.XtraEditors.DateEdit();
            this.Btn_Vazgec = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Not = new System.Windows.Forms.RichTextBox();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit4 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit5 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit6 = new DevExpress.XtraEditors.PictureEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.picBoxUrun = new System.Windows.Forms.PictureBox();
            this.txt_urunCesit = new System.Windows.Forms.TextBox();
            this.lookUp_Musteri = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.date_IstenilenTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_IstenilenTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Adet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_SiparisTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_SiparisTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUrun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUp_Musteri.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(114, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Müşteri :";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(44, 572);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(140, 46);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Ekle";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // date_IstenilenTarih
            // 
            this.date_IstenilenTarih.EditValue = null;
            this.date_IstenilenTarih.Location = new System.Drawing.Point(234, 295);
            this.date_IstenilenTarih.Name = "date_IstenilenTarih";
            this.date_IstenilenTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_IstenilenTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_IstenilenTarih.Size = new System.Drawing.Size(159, 22);
            this.date_IstenilenTarih.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(114, 102);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 16);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Ürün Çeşidi :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(114, 224);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(85, 16);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Sipariş Tarihi :";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(114, 160);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 16);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Adet :";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(114, 298);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(91, 16);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "İstenilen Tarih :";
            // 
            // num_Adet
            // 
            this.num_Adet.Location = new System.Drawing.Point(234, 158);
            this.num_Adet.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.num_Adet.Name = "num_Adet";
            this.num_Adet.Size = new System.Drawing.Size(159, 22);
            this.num_Adet.TabIndex = 9;
            // 
            // date_SiparisTarih
            // 
            this.date_SiparisTarih.EditValue = null;
            this.date_SiparisTarih.Location = new System.Drawing.Point(234, 221);
            this.date_SiparisTarih.Name = "date_SiparisTarih";
            this.date_SiparisTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_SiparisTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_SiparisTarih.Size = new System.Drawing.Size(159, 22);
            this.date_SiparisTarih.TabIndex = 10;
            // 
            // Btn_Vazgec
            // 
            this.Btn_Vazgec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Vazgec.ImageOptions.Image")));
            this.Btn_Vazgec.Location = new System.Drawing.Point(253, 572);
            this.Btn_Vazgec.Name = "Btn_Vazgec";
            this.Btn_Vazgec.Size = new System.Drawing.Size(140, 46);
            this.Btn_Vazgec.TabIndex = 11;
            this.Btn_Vazgec.Text = "İptal";
            this.Btn_Vazgec.Click += new System.EventHandler(this.Btn_Vazgec_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(177, 371);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(28, 16);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Not :";
            // 
            // txt_Not
            // 
            this.txt_Not.Location = new System.Drawing.Point(234, 368);
            this.txt_Not.Name = "txt_Not";
            this.txt_Not.Size = new System.Drawing.Size(159, 143);
            this.txt_Not.TabIndex = 13;
            this.txt_Not.Text = "";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(44, 92);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(45, 40);
            this.pictureEdit1.TabIndex = 28;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(44, 151);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Size = new System.Drawing.Size(45, 40);
            this.pictureEdit2.TabIndex = 29;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(44, 28);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Size = new System.Drawing.Size(45, 40);
            this.pictureEdit3.TabIndex = 30;
            // 
            // pictureEdit4
            // 
            this.pictureEdit4.EditValue = ((object)(resources.GetObject("pictureEdit4.EditValue")));
            this.pictureEdit4.Location = new System.Drawing.Point(44, 215);
            this.pictureEdit4.Name = "pictureEdit4";
            this.pictureEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit4.Size = new System.Drawing.Size(45, 40);
            this.pictureEdit4.TabIndex = 31;
            // 
            // pictureEdit5
            // 
            this.pictureEdit5.EditValue = ((object)(resources.GetObject("pictureEdit5.EditValue")));
            this.pictureEdit5.Location = new System.Drawing.Point(44, 287);
            this.pictureEdit5.Name = "pictureEdit5";
            this.pictureEdit5.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit5.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit5.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit5.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit5.Size = new System.Drawing.Size(45, 40);
            this.pictureEdit5.TabIndex = 32;
            // 
            // pictureEdit6
            // 
            this.pictureEdit6.EditValue = ((object)(resources.GetObject("pictureEdit6.EditValue")));
            this.pictureEdit6.Location = new System.Drawing.Point(44, 368);
            this.pictureEdit6.Name = "pictureEdit6";
            this.pictureEdit6.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit6.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit6.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit6.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit6.Size = new System.Drawing.Size(45, 40);
            this.pictureEdit6.TabIndex = 33;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(455, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(553, 301);
            this.gridControl1.TabIndex = 34;
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
            // picBoxUrun
            // 
            this.picBoxUrun.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxUrun.Location = new System.Drawing.Point(455, 333);
            this.picBoxUrun.Name = "picBoxUrun";
            this.picBoxUrun.Size = new System.Drawing.Size(553, 285);
            this.picBoxUrun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxUrun.TabIndex = 35;
            this.picBoxUrun.TabStop = false;
            // 
            // txt_urunCesit
            // 
            this.txt_urunCesit.BackColor = System.Drawing.SystemColors.Info;
            this.txt_urunCesit.Location = new System.Drawing.Point(234, 99);
            this.txt_urunCesit.Name = "txt_urunCesit";
            this.txt_urunCesit.ReadOnly = true;
            this.txt_urunCesit.Size = new System.Drawing.Size(159, 22);
            this.txt_urunCesit.TabIndex = 36;
            // 
            // lookUp_Musteri
            // 
            this.lookUp_Musteri.Location = new System.Drawing.Point(234, 49);
            this.lookUp_Musteri.Name = "lookUp_Musteri";
            this.lookUp_Musteri.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUp_Musteri.Properties.NullText = "";
            this.lookUp_Musteri.Size = new System.Drawing.Size(159, 22);
            this.lookUp_Musteri.TabIndex = 37;
            // 
            // Frm_YeniSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 646);
            this.Controls.Add(this.lookUp_Musteri);
            this.Controls.Add(this.txt_urunCesit);
            this.Controls.Add(this.picBoxUrun);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.pictureEdit6);
            this.Controls.Add(this.pictureEdit5);
            this.Controls.Add(this.pictureEdit4);
            this.Controls.Add(this.pictureEdit3);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.txt_Not);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.Btn_Vazgec);
            this.Controls.Add(this.date_SiparisTarih);
            this.Controls.Add(this.num_Adet);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.date_IstenilenTarih);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.Name = "Frm_YeniSiparis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Sipariş Oluştur";
            this.Load += new System.EventHandler(this.Frm_YeniSiparis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.date_IstenilenTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_IstenilenTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Adet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_SiparisTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_SiparisTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUrun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUp_Musteri.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.DateEdit date_IstenilenTarih;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.NumericUpDown num_Adet;
        private DevExpress.XtraEditors.DateEdit date_SiparisTarih;
        private DevExpress.XtraEditors.SimpleButton Btn_Vazgec;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.RichTextBox txt_Not;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit4;
        private DevExpress.XtraEditors.PictureEdit pictureEdit5;
        private DevExpress.XtraEditors.PictureEdit pictureEdit6;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.PictureBox picBoxUrun;
        private System.Windows.Forms.TextBox txt_urunCesit;
        private DevExpress.XtraEditors.LookUpEdit lookUp_Musteri;
    }
}