﻿
namespace test_kooil.Formlar
{
    partial class Frm_HataliRaporSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HataliRaporSil));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Btn_RaporSil = new DevExpress.XtraEditors.SimpleButton();
            this.txt_islem = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_urunKod = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_raporlayan = new DevExpress.XtraEditors.TextEdit();
            this.btn_guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.num_miktar = new System.Windows.Forms.NumericUpDown();
            this.txt_not = new System.Windows.Forms.RichTextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_islem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_urunKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_raporlayan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_miktar)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControl1.Location = new System.Drawing.Point(241, 10);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(648, 464);
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
            // Btn_RaporSil
            // 
            this.Btn_RaporSil.Enabled = false;
            this.Btn_RaporSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_RaporSil.ImageOptions.Image")));
            this.Btn_RaporSil.Location = new System.Drawing.Point(6, 427);
            this.Btn_RaporSil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_RaporSil.Name = "Btn_RaporSil";
            this.Btn_RaporSil.Size = new System.Drawing.Size(158, 46);
            this.Btn_RaporSil.TabIndex = 3;
            this.Btn_RaporSil.Text = "Seçili Raporu Sil";
            this.Btn_RaporSil.Click += new System.EventHandler(this.Btn_RaporSil_Click);
            // 
            // txt_islem
            // 
            this.txt_islem.Enabled = false;
            this.txt_islem.Location = new System.Drawing.Point(101, 38);
            this.txt_islem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_islem.Name = "txt_islem";
            this.txt_islem.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_islem.Properties.Appearance.Options.UseBackColor = true;
            this.txt_islem.Size = new System.Drawing.Size(118, 20);
            this.txt_islem.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 41);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(32, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "İşlem :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 86);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Ürün Kodu :";
            // 
            // txt_urunKod
            // 
            this.txt_urunKod.Enabled = false;
            this.txt_urunKod.Location = new System.Drawing.Point(101, 84);
            this.txt_urunKod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_urunKod.Name = "txt_urunKod";
            this.txt_urunKod.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_urunKod.Properties.Appearance.Options.UseBackColor = true;
            this.txt_urunKod.Size = new System.Drawing.Size(118, 20);
            this.txt_urunKod.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(3, 192);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Miktar: ";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(3, 137);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 13);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Raporlayan :";
            // 
            // txt_raporlayan
            // 
            this.txt_raporlayan.Enabled = false;
            this.txt_raporlayan.Location = new System.Drawing.Point(101, 134);
            this.txt_raporlayan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_raporlayan.Name = "txt_raporlayan";
            this.txt_raporlayan.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_raporlayan.Properties.Appearance.Options.UseBackColor = true;
            this.txt_raporlayan.Size = new System.Drawing.Size(118, 20);
            this.txt_raporlayan.TabIndex = 10;
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Enabled = false;
            this.btn_guncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_guncelle.ImageOptions.Image")));
            this.btn_guncelle.Location = new System.Drawing.Point(6, 365);
            this.btn_guncelle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(158, 46);
            this.btn_guncelle.TabIndex = 12;
            this.btn_guncelle.Text = "Raporu Güncelle";
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // num_miktar
            // 
            this.num_miktar.BackColor = System.Drawing.SystemColors.Info;
            this.num_miktar.Location = new System.Drawing.Point(101, 192);
            this.num_miktar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.num_miktar.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.num_miktar.Name = "num_miktar";
            this.num_miktar.Size = new System.Drawing.Size(118, 20);
            this.num_miktar.TabIndex = 13;
            // 
            // txt_not
            // 
            this.txt_not.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_not.Location = new System.Drawing.Point(101, 235);
            this.txt_not.MaxLength = 100;
            this.txt_not.Name = "txt_not";
            this.txt_not.Size = new System.Drawing.Size(118, 80);
            this.txt_not.TabIndex = 14;
            this.txt_not.Text = "";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(3, 235);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(27, 13);
            this.labelControl5.TabIndex = 15;
            this.labelControl5.Text = "Not : ";
            // 
            // Frm_HataliRaporSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 483);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txt_not);
            this.Controls.Add(this.num_miktar);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txt_raporlayan);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_urunKod);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_islem);
            this.Controls.Add(this.Btn_RaporSil);
            this.Controls.Add(this.gridControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Frm_HataliRaporSil";
            this.Text = "Hatalı Rapor Sil";
            this.Load += new System.EventHandler(this.Frm_HataliRaporSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_islem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_urunKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_raporlayan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_miktar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton Btn_RaporSil;
        private DevExpress.XtraEditors.TextEdit txt_islem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_urunKod;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_raporlayan;
        private DevExpress.XtraEditors.SimpleButton btn_guncelle;
        private System.Windows.Forms.NumericUpDown num_miktar;
        private System.Windows.Forms.RichTextBox txt_not;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}