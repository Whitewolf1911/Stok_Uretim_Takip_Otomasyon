
namespace test_kooil.Formlar
{
    partial class Frm_kontrolDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_kontrolDuzenle));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_not = new System.Windows.Forms.RichTextBox();
            this.num_miktar = new System.Windows.Forms.NumericUpDown();
            this.btn_guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_raporlayan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_urunKod = new DevExpress.XtraEditors.TextEdit();
            this.Btn_RaporSil = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_barkod = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_miktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_raporlayan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_urunKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_barkod.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Location = new System.Drawing.Point(296, 11);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(655, 551);
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
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(26, 293);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(27, 13);
            this.labelControl5.TabIndex = 25;
            this.labelControl5.Text = "Not : ";
            // 
            // txt_not
            // 
            this.txt_not.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_not.Location = new System.Drawing.Point(99, 293);
            this.txt_not.MaxLength = 100;
            this.txt_not.Name = "txt_not";
            this.txt_not.Size = new System.Drawing.Size(154, 80);
            this.txt_not.TabIndex = 24;
            this.txt_not.Text = "";
            // 
            // num_miktar
            // 
            this.num_miktar.BackColor = System.Drawing.SystemColors.Info;
            this.num_miktar.Location = new System.Drawing.Point(99, 189);
            this.num_miktar.Margin = new System.Windows.Forms.Padding(2);
            this.num_miktar.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.num_miktar.Name = "num_miktar";
            this.num_miktar.Size = new System.Drawing.Size(154, 20);
            this.num_miktar.TabIndex = 23;
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_guncelle.ImageOptions.Image")));
            this.btn_guncelle.Location = new System.Drawing.Point(11, 454);
            this.btn_guncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(158, 46);
            this.btn_guncelle.TabIndex = 22;
            this.btn_guncelle.Text = "Raporu Güncelle";
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(29, 107);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 13);
            this.labelControl4.TabIndex = 21;
            this.labelControl4.Text = "Raporlayan :";
            // 
            // txt_raporlayan
            // 
            this.txt_raporlayan.Enabled = false;
            this.txt_raporlayan.Location = new System.Drawing.Point(99, 104);
            this.txt_raporlayan.Margin = new System.Windows.Forms.Padding(2);
            this.txt_raporlayan.Name = "txt_raporlayan";
            this.txt_raporlayan.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_raporlayan.Properties.Appearance.Options.UseBackColor = true;
            this.txt_raporlayan.Size = new System.Drawing.Size(154, 20);
            this.txt_raporlayan.TabIndex = 20;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(26, 189);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 13);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "Miktar: ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(29, 52);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 13);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "Ürün Kodu :";
            // 
            // txt_urunKod
            // 
            this.txt_urunKod.Enabled = false;
            this.txt_urunKod.Location = new System.Drawing.Point(99, 49);
            this.txt_urunKod.Margin = new System.Windows.Forms.Padding(2);
            this.txt_urunKod.Name = "txt_urunKod";
            this.txt_urunKod.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_urunKod.Properties.Appearance.Options.UseBackColor = true;
            this.txt_urunKod.Size = new System.Drawing.Size(154, 20);
            this.txt_urunKod.TabIndex = 17;
            // 
            // Btn_RaporSil
            // 
            this.Btn_RaporSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_RaporSil.ImageOptions.Image")));
            this.Btn_RaporSil.Location = new System.Drawing.Point(11, 518);
            this.Btn_RaporSil.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_RaporSil.Name = "Btn_RaporSil";
            this.Btn_RaporSil.Size = new System.Drawing.Size(158, 46);
            this.Btn_RaporSil.TabIndex = 16;
            this.Btn_RaporSil.Text = "Seçili Raporu Sil";
            this.Btn_RaporSil.Click += new System.EventHandler(this.Btn_RaporSil_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 246);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 13);
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "Barkod  :";
            // 
            // txt_barkod
            // 
            this.txt_barkod.Location = new System.Drawing.Point(99, 243);
            this.txt_barkod.Margin = new System.Windows.Forms.Padding(2);
            this.txt_barkod.Name = "txt_barkod";
            this.txt_barkod.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_barkod.Properties.Appearance.Options.UseBackColor = true;
            this.txt_barkod.Properties.MaxLength = 20;
            this.txt_barkod.Size = new System.Drawing.Size(154, 20);
            this.txt_barkod.TabIndex = 26;
            // 
            // Frm_kontrolDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 574);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_barkod);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txt_not);
            this.Controls.Add(this.num_miktar);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txt_raporlayan);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_urunKod);
            this.Controls.Add(this.Btn_RaporSil);
            this.Controls.Add(this.gridControl1);
            this.Name = "Frm_kontrolDuzenle";
            this.Text = "Paketleme Düzenle";
            this.Load += new System.EventHandler(this.Frm_kontrolDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_miktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_raporlayan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_urunKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_barkod.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.RichTextBox txt_not;
        private System.Windows.Forms.NumericUpDown num_miktar;
        private DevExpress.XtraEditors.SimpleButton btn_guncelle;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_raporlayan;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_urunKod;
        private DevExpress.XtraEditors.SimpleButton Btn_RaporSil;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_barkod;
    }
}