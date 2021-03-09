
namespace test_kooil.Formlar
{
    partial class Frm_YeniHamEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_YeniHamEkle));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.num_kalinlik = new System.Windows.Forms.NumericUpDown();
            this.num_Genislik = new System.Windows.Forms.NumericUpDown();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ham_ozellik = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.ham_mensei = new DevExpress.XtraEditors.ComboBoxEdit();
            this.num_Miktar = new System.Windows.Forms.NumericUpDown();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit4 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit5 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit6 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit7 = new DevExpress.XtraEditors.PictureEdit();
            this.Btn_ekle = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_iptal = new DevExpress.XtraEditors.SimpleButton();
            this.text_Konum = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_kalinlik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Genislik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ham_ozellik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ham_mensei.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Miktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit7.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(156, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kalınlık :";
            // 
            // num_kalinlik
            // 
            this.num_kalinlik.DecimalPlaces = 2;
            this.num_kalinlik.Location = new System.Drawing.Point(237, 38);
            this.num_kalinlik.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_kalinlik.Name = "num_kalinlik";
            this.num_kalinlik.Size = new System.Drawing.Size(125, 20);
            this.num_kalinlik.TabIndex = 1;
            // 
            // num_Genislik
            // 
            this.num_Genislik.DecimalPlaces = 2;
            this.num_Genislik.Location = new System.Drawing.Point(237, 98);
            this.num_Genislik.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_Genislik.Name = "num_Genislik";
            this.num_Genislik.Size = new System.Drawing.Size(125, 20);
            this.num_Genislik.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(156, 98);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Genişlik :";
            // 
            // ham_ozellik
            // 
            this.ham_ozellik.EditValue = "belirlenmedi";
            this.ham_ozellik.Location = new System.Drawing.Point(237, 145);
            this.ham_ozellik.Name = "ham_ozellik";
            this.ham_ozellik.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ham_ozellik.Properties.Items.AddRange(new object[] {
            "NORMAL",
            "SULU"});
            this.ham_ozellik.Properties.NullText = "Özellik Seçiniz";
            this.ham_ozellik.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ham_ozellik.Size = new System.Drawing.Size(125, 20);
            this.ham_ozellik.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(157, 148);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Özellik :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(154, 212);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Menşei :";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(154, 264);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(69, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Miktar ( KG )  :";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(154, 323);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(39, 13);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "Konum :";
            // 
            // ham_mensei
            // 
            this.ham_mensei.EditValue = "belirlenmedi";
            this.ham_mensei.Location = new System.Drawing.Point(237, 209);
            this.ham_mensei.Name = "ham_mensei";
            this.ham_mensei.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ham_mensei.Properties.Items.AddRange(new object[] {
            "KORE",
            "ALMAN",
            "TURK"});
            this.ham_mensei.Properties.NullText = "Menşei Seçiniz";
            this.ham_mensei.Properties.ShowNullValuePrompt = ((DevExpress.XtraEditors.ShowNullValuePromptOptions)(((DevExpress.XtraEditors.ShowNullValuePromptOptions.EmptyValue | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused) 
            | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly)));
            this.ham_mensei.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.ham_mensei.Size = new System.Drawing.Size(125, 20);
            this.ham_mensei.TabIndex = 11;
            // 
            // num_Miktar
            // 
            this.num_Miktar.Location = new System.Drawing.Point(237, 264);
            this.num_Miktar.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.num_Miktar.Name = "num_Miktar";
            this.num_Miktar.Size = new System.Drawing.Size(125, 20);
            this.num_Miktar.TabIndex = 12;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(83, 29);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Size = new System.Drawing.Size(38, 38);
            this.pictureEdit2.TabIndex = 13;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(83, 82);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Size = new System.Drawing.Size(38, 38);
            this.pictureEdit3.TabIndex = 14;
            // 
            // pictureEdit4
            // 
            this.pictureEdit4.EditValue = ((object)(resources.GetObject("pictureEdit4.EditValue")));
            this.pictureEdit4.Location = new System.Drawing.Point(83, 137);
            this.pictureEdit4.Name = "pictureEdit4";
            this.pictureEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit4.Size = new System.Drawing.Size(38, 38);
            this.pictureEdit4.TabIndex = 15;
            // 
            // pictureEdit5
            // 
            this.pictureEdit5.EditValue = ((object)(resources.GetObject("pictureEdit5.EditValue")));
            this.pictureEdit5.Location = new System.Drawing.Point(83, 191);
            this.pictureEdit5.Name = "pictureEdit5";
            this.pictureEdit5.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit5.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit5.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit5.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit5.Size = new System.Drawing.Size(38, 38);
            this.pictureEdit5.TabIndex = 16;
            // 
            // pictureEdit6
            // 
            this.pictureEdit6.EditValue = ((object)(resources.GetObject("pictureEdit6.EditValue")));
            this.pictureEdit6.Location = new System.Drawing.Point(83, 254);
            this.pictureEdit6.Name = "pictureEdit6";
            this.pictureEdit6.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit6.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit6.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit6.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit6.Size = new System.Drawing.Size(38, 38);
            this.pictureEdit6.TabIndex = 17;
            // 
            // pictureEdit7
            // 
            this.pictureEdit7.EditValue = ((object)(resources.GetObject("pictureEdit7.EditValue")));
            this.pictureEdit7.Location = new System.Drawing.Point(83, 310);
            this.pictureEdit7.Name = "pictureEdit7";
            this.pictureEdit7.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit7.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit7.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit7.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit7.Size = new System.Drawing.Size(38, 38);
            this.pictureEdit7.TabIndex = 18;
            // 
            // Btn_ekle
            // 
            this.Btn_ekle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.Btn_ekle.Location = new System.Drawing.Point(26, 412);
            this.Btn_ekle.Name = "Btn_ekle";
            this.Btn_ekle.Size = new System.Drawing.Size(131, 46);
            this.Btn_ekle.TabIndex = 19;
            this.Btn_ekle.Text = "Ekle";
            this.Btn_ekle.Click += new System.EventHandler(this.Btn_ekle_Click);
            // 
            // Btn_iptal
            // 
            this.Btn_iptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.Btn_iptal.Location = new System.Drawing.Point(383, 412);
            this.Btn_iptal.Name = "Btn_iptal";
            this.Btn_iptal.Size = new System.Drawing.Size(131, 46);
            this.Btn_iptal.TabIndex = 20;
            this.Btn_iptal.Text = "İptal";
            this.Btn_iptal.Click += new System.EventHandler(this.Btn_iptal_Click);
            // 
            // text_Konum
            // 
            this.text_Konum.Location = new System.Drawing.Point(237, 323);
            this.text_Konum.Name = "text_Konum";
            this.text_Konum.Size = new System.Drawing.Size(125, 49);
            this.text_Konum.TabIndex = 21;
            this.text_Konum.Text = "";
            // 
            // Frm_YeniHamEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 483);
            this.Controls.Add(this.text_Konum);
            this.Controls.Add(this.Btn_iptal);
            this.Controls.Add(this.Btn_ekle);
            this.Controls.Add(this.pictureEdit7);
            this.Controls.Add(this.pictureEdit6);
            this.Controls.Add(this.pictureEdit5);
            this.Controls.Add(this.pictureEdit4);
            this.Controls.Add(this.pictureEdit3);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.num_Miktar);
            this.Controls.Add(this.ham_mensei);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.ham_ozellik);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.num_Genislik);
            this.Controls.Add(this.num_kalinlik);
            this.Controls.Add(this.labelControl1);
            this.Name = "Frm_YeniHamEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yeni Hammadde Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.num_kalinlik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Genislik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ham_ozellik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ham_mensei.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Miktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit7.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.NumericUpDown num_kalinlik;
        private System.Windows.Forms.NumericUpDown num_Genislik;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit ham_ozellik;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit ham_mensei;
        private System.Windows.Forms.NumericUpDown num_Miktar;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit4;
        private DevExpress.XtraEditors.PictureEdit pictureEdit5;
        private DevExpress.XtraEditors.PictureEdit pictureEdit6;
        private DevExpress.XtraEditors.PictureEdit pictureEdit7;
        private DevExpress.XtraEditors.SimpleButton Btn_ekle;
        private DevExpress.XtraEditors.SimpleButton Btn_iptal;
        private System.Windows.Forms.RichTextBox text_Konum;
    }
}