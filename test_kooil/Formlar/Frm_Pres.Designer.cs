﻿
namespace test_kooil.Formlar
{
    partial class Frm_Pres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Pres));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_sipIgneTur = new DevExpress.XtraEditors.TextEdit();
            this.txt_sipNot = new System.Windows.Forms.RichTextBox();
            this.Btn_PresEkle = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_PresRapor = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Guncelle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sipIgneTur.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(4, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1115, 604);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txt_sipIgneTur);
            this.groupControl1.Controls.Add(this.txt_sipNot);
            this.groupControl1.Controls.Add(this.Btn_PresEkle);
            this.groupControl1.Controls.Add(this.Btn_PresRapor);
            this.groupControl1.Controls.Add(this.Btn_Guncelle);
            this.groupControl1.Location = new System.Drawing.Point(1124, 12);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(328, 604);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Pres Kontrol Paneli";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 451);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 16);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Sipariş Notu :";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 383);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 16);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Ürün :";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // txt_sipIgneTur
            // 
            this.txt_sipIgneTur.Location = new System.Drawing.Point(55, 380);
            this.txt_sipIgneTur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_sipIgneTur.Name = "txt_sipIgneTur";
            this.txt_sipIgneTur.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_sipIgneTur.Properties.Appearance.Options.UseBackColor = true;
            this.txt_sipIgneTur.Properties.ReadOnly = true;
            this.txt_sipIgneTur.Size = new System.Drawing.Size(204, 22);
            this.txt_sipIgneTur.TabIndex = 4;
            // 
            // txt_sipNot
            // 
            this.txt_sipNot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_sipNot.Location = new System.Drawing.Point(116, 451);
            this.txt_sipNot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_sipNot.Name = "txt_sipNot";
            this.txt_sipNot.ReadOnly = true;
            this.txt_sipNot.Size = new System.Drawing.Size(143, 125);
            this.txt_sipNot.TabIndex = 3;
            this.txt_sipNot.Text = "";
            // 
            // Btn_PresEkle
            // 
            this.Btn_PresEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_PresEkle.ImageOptions.Image")));
            this.Btn_PresEkle.Location = new System.Drawing.Point(35, 43);
            this.Btn_PresEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_PresEkle.Name = "Btn_PresEkle";
            this.Btn_PresEkle.Size = new System.Drawing.Size(173, 48);
            this.Btn_PresEkle.TabIndex = 2;
            this.Btn_PresEkle.Text = "İşlenen Ürün Ekle";
            this.Btn_PresEkle.Click += new System.EventHandler(this.Btn_PresEkle_Click);
            // 
            // Btn_PresRapor
            // 
            this.Btn_PresRapor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_PresRapor.ImageOptions.Image")));
            this.Btn_PresRapor.Location = new System.Drawing.Point(35, 174);
            this.Btn_PresRapor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_PresRapor.Name = "Btn_PresRapor";
            this.Btn_PresRapor.Size = new System.Drawing.Size(173, 48);
            this.Btn_PresRapor.TabIndex = 1;
            this.Btn_PresRapor.Text = "Raporlar";
            this.Btn_PresRapor.Click += new System.EventHandler(this.Btn_PresRapor_Click);
            // 
            // Btn_Guncelle
            // 
            this.Btn_Guncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guncelle.ImageOptions.Image")));
            this.Btn_Guncelle.Location = new System.Drawing.Point(35, 108);
            this.Btn_Guncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Guncelle.Name = "Btn_Guncelle";
            this.Btn_Guncelle.Size = new System.Drawing.Size(173, 48);
            this.Btn_Guncelle.TabIndex = 0;
            this.Btn_Guncelle.Text = "Listeyi Yenile";
            this.Btn_Guncelle.Click += new System.EventHandler(this.Btn_Guncelle_Click);
            // 
            // Frm_Pres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 628);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Pres";
            this.Text = "Pres";
            this.Load += new System.EventHandler(this.Frm_Pres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sipIgneTur.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton Btn_Guncelle;
        private DevExpress.XtraEditors.SimpleButton Btn_PresEkle;
        private DevExpress.XtraEditors.SimpleButton Btn_PresRapor;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_sipIgneTur;
        private System.Windows.Forms.RichTextBox txt_sipNot;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}