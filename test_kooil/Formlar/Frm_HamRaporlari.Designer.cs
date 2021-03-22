
namespace test_kooil.Formlar
{
    partial class Frm_HamRaporlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HamRaporlari));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_musteri = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Miktar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_mensei = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_secilenHam = new DevExpress.XtraEditors.TextEdit();
            this.txt_urunKodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Btn_Yazdir = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_pres = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_musteri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Miktar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mensei.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_secilenHam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_urunKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pres.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(332, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1120, 604);
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
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txt_pres);
            this.groupControl1.Controls.Add(this.pictureEdit1);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txt_musteri);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txt_Miktar);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txt_mensei);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txt_secilenHam);
            this.groupControl1.Controls.Add(this.txt_urunKodu);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.Btn_Yazdir);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(314, 604);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Hammadde Rapor";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(15, 31);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(59, 59);
            this.pictureEdit1.TabIndex = 18;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(8, 152);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(51, 16);
            this.labelControl5.TabIndex = 17;
            this.labelControl5.Text = "Müşteri :";
            // 
            // txt_musteri
            // 
            this.txt_musteri.Location = new System.Drawing.Point(150, 149);
            this.txt_musteri.Name = "txt_musteri";
            this.txt_musteri.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_musteri.Properties.Appearance.Options.UseBackColor = true;
            this.txt_musteri.Properties.ReadOnly = true;
            this.txt_musteri.Size = new System.Drawing.Size(159, 22);
            this.txt_musteri.TabIndex = 16;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(8, 372);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(127, 16);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Kullanılan Miktar (KG):";
            // 
            // txt_Miktar
            // 
            this.txt_Miktar.Location = new System.Drawing.Point(150, 369);
            this.txt_Miktar.Name = "txt_Miktar";
            this.txt_Miktar.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_Miktar.Properties.Appearance.Options.UseBackColor = true;
            this.txt_Miktar.Properties.ReadOnly = true;
            this.txt_Miktar.Size = new System.Drawing.Size(159, 22);
            this.txt_Miktar.TabIndex = 14;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(8, 319);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 16);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Menşei :";
            // 
            // txt_mensei
            // 
            this.txt_mensei.Location = new System.Drawing.Point(150, 316);
            this.txt_mensei.Name = "txt_mensei";
            this.txt_mensei.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_mensei.Properties.Appearance.Options.UseBackColor = true;
            this.txt_mensei.Properties.ReadOnly = true;
            this.txt_mensei.Size = new System.Drawing.Size(159, 22);
            this.txt_mensei.TabIndex = 12;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(8, 262);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 16);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Hammadde :";
            // 
            // txt_secilenHam
            // 
            this.txt_secilenHam.Location = new System.Drawing.Point(150, 259);
            this.txt_secilenHam.Name = "txt_secilenHam";
            this.txt_secilenHam.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_secilenHam.Properties.Appearance.Options.UseBackColor = true;
            this.txt_secilenHam.Properties.ReadOnly = true;
            this.txt_secilenHam.Size = new System.Drawing.Size(159, 22);
            this.txt_secilenHam.TabIndex = 10;
            // 
            // txt_urunKodu
            // 
            this.txt_urunKodu.Location = new System.Drawing.Point(150, 199);
            this.txt_urunKodu.Name = "txt_urunKodu";
            this.txt_urunKodu.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_urunKodu.Properties.Appearance.Options.UseBackColor = true;
            this.txt_urunKodu.Properties.ReadOnly = true;
            this.txt_urunKodu.Size = new System.Drawing.Size(159, 22);
            this.txt_urunKodu.TabIndex = 9;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 202);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Ürün Kodu :";
            // 
            // Btn_Yazdir
            // 
            this.Btn_Yazdir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Yazdir.ImageOptions.Image")));
            this.Btn_Yazdir.Location = new System.Drawing.Point(128, 546);
            this.Btn_Yazdir.Name = "Btn_Yazdir";
            this.Btn_Yazdir.Size = new System.Drawing.Size(181, 53);
            this.Btn_Yazdir.TabIndex = 0;
            this.Btn_Yazdir.Text = "Yazdır";
            this.Btn_Yazdir.Click += new System.EventHandler(this.Btn_Yazdir_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(8, 426);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(69, 16);
            this.labelControl6.TabIndex = 20;
            this.labelControl6.Text = "Pres Miktar:";
            // 
            // txt_pres
            // 
            this.txt_pres.Location = new System.Drawing.Point(150, 423);
            this.txt_pres.Name = "txt_pres";
            this.txt_pres.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_pres.Properties.Appearance.Options.UseBackColor = true;
            this.txt_pres.Properties.ReadOnly = true;
            this.txt_pres.Size = new System.Drawing.Size(159, 22);
            this.txt_pres.TabIndex = 19;
            // 
            // Frm_HamRaporlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 628);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Frm_HamRaporlari";
            this.Text = "Hammadde Raporları";
            this.Load += new System.EventHandler(this.Frm_HamRaporlari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_musteri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Miktar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mensei.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_secilenHam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_urunKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pres.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton Btn_Yazdir;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_musteri;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_Miktar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_mensei;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_secilenHam;
        private DevExpress.XtraEditors.TextEdit txt_urunKodu;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txt_pres;
    }
}