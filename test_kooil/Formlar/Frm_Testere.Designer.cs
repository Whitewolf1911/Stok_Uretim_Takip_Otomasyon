
namespace test_kooil.Formlar
{
    partial class Frm_Testere
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Testere));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.Btn_yenile = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_urunListele = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_sil = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_testereTanimla = new DevExpress.XtraEditors.SimpleButton();
            this.txt_testere = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.num_adet = new System.Windows.Forms.NumericUpDown();
            this.Btn_adetAzalt = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_adetEkle = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_yeniTestere = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Btn_yazdir = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_testere.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_adet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.Btn_yazdir);
            this.groupControl1.Controls.Add(this.Btn_yenile);
            this.groupControl1.Controls.Add(this.Btn_urunListele);
            this.groupControl1.Controls.Add(this.Btn_sil);
            this.groupControl1.Controls.Add(this.Btn_testereTanimla);
            this.groupControl1.Controls.Add(this.txt_testere);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.num_adet);
            this.groupControl1.Controls.Add(this.Btn_adetAzalt);
            this.groupControl1.Controls.Add(this.Btn_adetEkle);
            this.groupControl1.Controls.Add(this.Btn_yeniTestere);
            this.groupControl1.Location = new System.Drawing.Point(9, 10);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(246, 491);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Kontroller";
            // 
            // Btn_yenile
            // 
            this.Btn_yenile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_yenile.ImageOptions.Image")));
            this.Btn_yenile.Location = new System.Drawing.Point(4, 435);
            this.Btn_yenile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_yenile.Name = "Btn_yenile";
            this.Btn_yenile.Size = new System.Drawing.Size(97, 41);
            this.Btn_yenile.TabIndex = 10;
            this.Btn_yenile.Text = "Yenile";
            this.Btn_yenile.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Btn_urunListele
            // 
            this.Btn_urunListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_urunListele.ImageOptions.Image")));
            this.Btn_urunListele.Location = new System.Drawing.Point(4, 182);
            this.Btn_urunListele.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_urunListele.Name = "Btn_urunListele";
            this.Btn_urunListele.Size = new System.Drawing.Size(134, 41);
            this.Btn_urunListele.TabIndex = 9;
            this.Btn_urunListele.Text = "Ürün Listele";
            this.Btn_urunListele.Click += new System.EventHandler(this.Btn_urunListele_Click);
            // 
            // Btn_sil
            // 
            this.Btn_sil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_sil.ImageOptions.Image")));
            this.Btn_sil.Location = new System.Drawing.Point(4, 124);
            this.Btn_sil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_sil.Name = "Btn_sil";
            this.Btn_sil.Size = new System.Drawing.Size(134, 41);
            this.Btn_sil.TabIndex = 8;
            this.Btn_sil.Text = "Seçili Testereyi Sil";
            this.Btn_sil.Click += new System.EventHandler(this.Btn_sil_Click);
            // 
            // Btn_testereTanimla
            // 
            this.Btn_testereTanimla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_testereTanimla.ImageOptions.Image")));
            this.Btn_testereTanimla.Location = new System.Drawing.Point(4, 71);
            this.Btn_testereTanimla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_testereTanimla.Name = "Btn_testereTanimla";
            this.Btn_testereTanimla.Size = new System.Drawing.Size(134, 41);
            this.Btn_testereTanimla.TabIndex = 7;
            this.Btn_testereTanimla.Text = "Testere Tanımlama";
            this.Btn_testereTanimla.Click += new System.EventHandler(this.Btn_testereTanimla_Click);
            // 
            // txt_testere
            // 
            this.txt_testere.Location = new System.Drawing.Point(97, 263);
            this.txt_testere.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_testere.Name = "txt_testere";
            this.txt_testere.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_testere.Properties.Appearance.Options.UseBackColor = true;
            this.txt_testere.Properties.ReadOnly = true;
            this.txt_testere.Size = new System.Drawing.Size(134, 20);
            this.txt_testere.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 266);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(80, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Seçilen Testere :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(62, 344);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Adet Giriniz :";
            // 
            // num_adet
            // 
            this.num_adet.Location = new System.Drawing.Point(134, 342);
            this.num_adet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.num_adet.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_adet.Name = "num_adet";
            this.num_adet.Size = new System.Drawing.Size(109, 21);
            this.num_adet.TabIndex = 3;
            // 
            // Btn_adetAzalt
            // 
            this.Btn_adetAzalt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_adetAzalt.ImageOptions.Image")));
            this.Btn_adetAzalt.Location = new System.Drawing.Point(134, 435);
            this.Btn_adetAzalt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_adetAzalt.Name = "Btn_adetAzalt";
            this.Btn_adetAzalt.Size = new System.Drawing.Size(109, 41);
            this.Btn_adetAzalt.TabIndex = 2;
            this.Btn_adetAzalt.Text = "Adet Azalt";
            this.Btn_adetAzalt.Click += new System.EventHandler(this.Btn_adetAzalt_Click);
            // 
            // Btn_adetEkle
            // 
            this.Btn_adetEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_adetEkle.ImageOptions.Image")));
            this.Btn_adetEkle.Location = new System.Drawing.Point(134, 379);
            this.Btn_adetEkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_adetEkle.Name = "Btn_adetEkle";
            this.Btn_adetEkle.Size = new System.Drawing.Size(109, 41);
            this.Btn_adetEkle.TabIndex = 1;
            this.Btn_adetEkle.Text = "Adet Ekle";
            this.Btn_adetEkle.Click += new System.EventHandler(this.Btn_adetEkle_Click);
            // 
            // Btn_yeniTestere
            // 
            this.Btn_yeniTestere.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_yeniTestere.ImageOptions.Image")));
            this.Btn_yeniTestere.Location = new System.Drawing.Point(4, 25);
            this.Btn_yeniTestere.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_yeniTestere.Name = "Btn_yeniTestere";
            this.Btn_yeniTestere.Size = new System.Drawing.Size(134, 41);
            this.Btn_yeniTestere.TabIndex = 0;
            this.Btn_yeniTestere.Text = "Yeni Testere";
            this.Btn_yeniTestere.Click += new System.EventHandler(this.Btn_yeniTestere_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControl1.Location = new System.Drawing.Point(260, 10);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(409, 491);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControl2
            // 
            this.gridControl2.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControl2.Location = new System.Drawing.Point(680, 10);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(409, 491);
            this.gridControl2.TabIndex = 2;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.DetailHeight = 284;
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // Btn_yazdir
            // 
            this.Btn_yazdir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.Btn_yazdir.Location = new System.Drawing.Point(4, 379);
            this.Btn_yazdir.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_yazdir.Name = "Btn_yazdir";
            this.Btn_yazdir.Size = new System.Drawing.Size(97, 41);
            this.Btn_yazdir.TabIndex = 11;
            this.Btn_yazdir.Text = "Yazdır";
            this.Btn_yazdir.Click += new System.EventHandler(this.Btn_yazdir_Click);
            // 
            // Frm_Testere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 510);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_Testere";
            this.Text = "Testere";
            this.Load += new System.EventHandler(this.Frm_Testere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_testere.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_adet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton Btn_yeniTestere;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton Btn_adetAzalt;
        private DevExpress.XtraEditors.SimpleButton Btn_adetEkle;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.NumericUpDown num_adet;
        private DevExpress.XtraEditors.TextEdit txt_testere;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton Btn_testereTanimla;
        private DevExpress.XtraEditors.SimpleButton Btn_sil;
        private DevExpress.XtraEditors.SimpleButton Btn_yenile;
        private DevExpress.XtraEditors.SimpleButton Btn_urunListele;
        private DevExpress.XtraEditors.SimpleButton Btn_yazdir;
    }
}