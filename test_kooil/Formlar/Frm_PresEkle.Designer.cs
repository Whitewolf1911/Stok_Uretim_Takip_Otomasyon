
namespace test_kooil.Formlar
{
    partial class Frm_PresEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PresEkle));
            this.lookUp_Siparis = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.num_IslenenAdet = new System.Windows.Forms.NumericUpDown();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.text_Raporlayan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.text_Not = new System.Windows.Forms.RichTextBox();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit4 = new DevExpress.XtraEditors.PictureEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_iptal = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit5 = new DevExpress.XtraEditors.PictureEdit();
            this.date_BasimTarihi = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit6 = new DevExpress.XtraEditors.PictureEdit();
            this.combo_ham = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUp_Siparis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_IslenenAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_Raporlayan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_BasimTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_BasimTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_ham.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lookUp_Siparis
            // 
            this.lookUp_Siparis.Location = new System.Drawing.Point(223, 34);
            this.lookUp_Siparis.Name = "lookUp_Siparis";
            this.lookUp_Siparis.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUp_Siparis.Properties.NullText = "Sipariş Seçiniz";
            this.lookUp_Siparis.Size = new System.Drawing.Size(336, 22);
            this.lookUp_Siparis.TabIndex = 0;
            this.lookUp_Siparis.EditValueChanged += new System.EventHandler(this.lookUp_Siparis_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(110, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Sipariş :";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // num_IslenenAdet
            // 
            this.num_IslenenAdet.Location = new System.Drawing.Point(223, 87);
            this.num_IslenenAdet.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.num_IslenenAdet.Name = "num_IslenenAdet";
            this.num_IslenenAdet.Size = new System.Drawing.Size(180, 22);
            this.num_IslenenAdet.TabIndex = 2;
            this.num_IslenenAdet.ValueChanged += new System.EventHandler(this.num_IslenenAdet_ValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(110, 93);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(80, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "İşlenen Adet :";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(110, 193);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 16);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Raporlayan :";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // text_Raporlayan
            // 
            this.text_Raporlayan.Enabled = false;
            this.text_Raporlayan.Location = new System.Drawing.Point(223, 190);
            this.text_Raporlayan.Name = "text_Raporlayan";
            this.text_Raporlayan.Size = new System.Drawing.Size(180, 22);
            this.text_Raporlayan.TabIndex = 5;
            this.text_Raporlayan.EditValueChanged += new System.EventHandler(this.text_Raporlayan_EditValueChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(155, 314);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(28, 16);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Not :";
            this.labelControl5.Click += new System.EventHandler(this.labelControl5_Click);
            // 
            // text_Not
            // 
            this.text_Not.Location = new System.Drawing.Point(223, 314);
            this.text_Not.Name = "text_Not";
            this.text_Not.Size = new System.Drawing.Size(204, 168);
            this.text_Not.TabIndex = 9;
            this.text_Not.Text = "";
            this.text_Not.TextChanged += new System.EventHandler(this.text_Not_TextChanged);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(28, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(63, 59);
            this.pictureEdit1.TabIndex = 10;
            this.pictureEdit1.EditValueChanged += new System.EventHandler(this.pictureEdit1_EditValueChanged);
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(39, 177);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Size = new System.Drawing.Size(52, 52);
            this.pictureEdit2.TabIndex = 11;
            this.pictureEdit2.EditValueChanged += new System.EventHandler(this.pictureEdit2_EditValueChanged);
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(39, 305);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Size = new System.Drawing.Size(52, 52);
            this.pictureEdit3.TabIndex = 12;
            this.pictureEdit3.EditValueChanged += new System.EventHandler(this.pictureEdit3_EditValueChanged);
            // 
            // pictureEdit4
            // 
            this.pictureEdit4.EditValue = ((object)(resources.GetObject("pictureEdit4.EditValue")));
            this.pictureEdit4.Location = new System.Drawing.Point(39, 66);
            this.pictureEdit4.Name = "pictureEdit4";
            this.pictureEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit4.Size = new System.Drawing.Size(52, 52);
            this.pictureEdit4.TabIndex = 13;
            this.pictureEdit4.EditValueChanged += new System.EventHandler(this.pictureEdit4_EditValueChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(39, 511);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(172, 61);
            this.simpleButton1.TabIndex = 14;
            this.simpleButton1.Text = "Kaydet";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Btn_iptal
            // 
            this.Btn_iptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_iptal.ImageOptions.Image")));
            this.Btn_iptal.Location = new System.Drawing.Point(387, 511);
            this.Btn_iptal.Name = "Btn_iptal";
            this.Btn_iptal.Size = new System.Drawing.Size(172, 61);
            this.Btn_iptal.TabIndex = 15;
            this.Btn_iptal.Text = "İptal";
            this.Btn_iptal.Click += new System.EventHandler(this.Btn_iptal_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(144, 251);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 16);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Tarih :";
            this.labelControl4.Click += new System.EventHandler(this.labelControl4_Click);
            // 
            // pictureEdit5
            // 
            this.pictureEdit5.EditValue = ((object)(resources.GetObject("pictureEdit5.EditValue")));
            this.pictureEdit5.Location = new System.Drawing.Point(39, 235);
            this.pictureEdit5.Name = "pictureEdit5";
            this.pictureEdit5.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit5.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit5.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit5.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit5.Size = new System.Drawing.Size(52, 52);
            this.pictureEdit5.TabIndex = 17;
            this.pictureEdit5.EditValueChanged += new System.EventHandler(this.pictureEdit5_EditValueChanged);
            // 
            // date_BasimTarihi
            // 
            this.date_BasimTarihi.EditValue = null;
            this.date_BasimTarihi.Location = new System.Drawing.Point(223, 251);
            this.date_BasimTarihi.Name = "date_BasimTarihi";
            this.date_BasimTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_BasimTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_BasimTarihi.Size = new System.Drawing.Size(180, 22);
            this.date_BasimTarihi.TabIndex = 18;
            this.date_BasimTarihi.EditValueChanged += new System.EventHandler(this.date_BasimTarihi_EditValueChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(110, 143);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(74, 16);
            this.labelControl6.TabIndex = 19;
            this.labelControl6.Text = "Hammadde :";
            // 
            // pictureEdit6
            // 
            this.pictureEdit6.EditValue = ((object)(resources.GetObject("pictureEdit6.EditValue")));
            this.pictureEdit6.Location = new System.Drawing.Point(39, 119);
            this.pictureEdit6.Name = "pictureEdit6";
            this.pictureEdit6.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit6.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit6.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit6.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit6.Size = new System.Drawing.Size(52, 52);
            this.pictureEdit6.TabIndex = 20;
            // 
            // combo_ham
            // 
            this.combo_ham.Location = new System.Drawing.Point(223, 143);
            this.combo_ham.Name = "combo_ham";
            this.combo_ham.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.combo_ham.Properties.Appearance.Options.UseBackColor = true;
            this.combo_ham.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.combo_ham.Properties.Items.AddRange(new object[] {
            "KORE",
            "ALMAN",
            "TURK"});
            this.combo_ham.Size = new System.Drawing.Size(180, 22);
            this.combo_ham.TabIndex = 21;
            // 
            // Frm_PresEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 584);
            this.Controls.Add(this.combo_ham);
            this.Controls.Add(this.pictureEdit6);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.date_BasimTarihi);
            this.Controls.Add(this.pictureEdit5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.Btn_iptal);
            this.Controls.Add(this.simpleButton1);
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
            this.Name = "Frm_PresEkle";
            this.Text = "Pres Adet";
            this.Load += new System.EventHandler(this.Frm_PresEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookUp_Siparis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_IslenenAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_Raporlayan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_BasimTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_BasimTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_ham.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lookUp_Siparis;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.NumericUpDown num_IslenenAdet;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit text_Raporlayan;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.RichTextBox text_Not;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton Btn_iptal;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.PictureEdit pictureEdit5;
        private DevExpress.XtraEditors.DateEdit date_BasimTarihi;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.PictureEdit pictureEdit6;
        private DevExpress.XtraEditors.ComboBoxEdit combo_ham;
    }
}