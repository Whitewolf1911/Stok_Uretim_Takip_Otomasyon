
namespace test_kooil.Formlar
{
    partial class Frm_HamRaporEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HamRaporEkle));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.num_Miktar = new System.Windows.Forms.NumericUpDown();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_secilenSip = new DevExpress.XtraEditors.TextEdit();
            this.txt_secilenHam = new DevExpress.XtraEditors.TextEdit();
            this.txt_raporlayan = new DevExpress.XtraEditors.TextEdit();
            this.Btn_Ekle = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Iptal = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit4 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit5 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.num_PresAdet = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Miktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_secilenSip.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_secilenHam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_raporlayan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_PresAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(554, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(704, 292);
            this.gridControl1.TabIndex = 0;
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
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(554, 310);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(704, 291);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            // 
            // num_Miktar
            // 
            this.num_Miktar.Location = new System.Drawing.Point(331, 283);
            this.num_Miktar.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.num_Miktar.Name = "num_Miktar";
            this.num_Miktar.Size = new System.Drawing.Size(138, 22);
            this.num_Miktar.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(116, 94);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(93, 16);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Seçilen Sipariş :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(117, 157);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(119, 16);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Seçilen Hammadde :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(119, 228);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 16);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Raporlayan :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(119, 285);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(197, 16);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Kullandığınız Miktarı Giriniz ( KG ) :";
            // 
            // txt_secilenSip
            // 
            this.txt_secilenSip.Location = new System.Drawing.Point(262, 91);
            this.txt_secilenSip.Name = "txt_secilenSip";
            this.txt_secilenSip.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_secilenSip.Properties.Appearance.Options.UseBackColor = true;
            this.txt_secilenSip.Properties.ReadOnly = true;
            this.txt_secilenSip.Size = new System.Drawing.Size(244, 22);
            this.txt_secilenSip.TabIndex = 7;
            // 
            // txt_secilenHam
            // 
            this.txt_secilenHam.Location = new System.Drawing.Point(262, 151);
            this.txt_secilenHam.Name = "txt_secilenHam";
            this.txt_secilenHam.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_secilenHam.Properties.Appearance.Options.UseBackColor = true;
            this.txt_secilenHam.Properties.ReadOnly = true;
            this.txt_secilenHam.Size = new System.Drawing.Size(244, 22);
            this.txt_secilenHam.TabIndex = 8;
            // 
            // txt_raporlayan
            // 
            this.txt_raporlayan.Enabled = false;
            this.txt_raporlayan.Location = new System.Drawing.Point(331, 225);
            this.txt_raporlayan.Name = "txt_raporlayan";
            this.txt_raporlayan.Size = new System.Drawing.Size(141, 22);
            this.txt_raporlayan.TabIndex = 9;
            // 
            // Btn_Ekle
            // 
            this.Btn_Ekle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ekle.ImageOptions.Image")));
            this.Btn_Ekle.Location = new System.Drawing.Point(12, 544);
            this.Btn_Ekle.Name = "Btn_Ekle";
            this.Btn_Ekle.Size = new System.Drawing.Size(160, 57);
            this.Btn_Ekle.TabIndex = 10;
            this.Btn_Ekle.Text = "Ekle";
            this.Btn_Ekle.Click += new System.EventHandler(this.Btn_Ekle_Click);
            // 
            // Btn_Iptal
            // 
            this.Btn_Iptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Iptal.ImageOptions.Image")));
            this.Btn_Iptal.Location = new System.Drawing.Point(346, 544);
            this.Btn_Iptal.Name = "Btn_Iptal";
            this.Btn_Iptal.Size = new System.Drawing.Size(160, 57);
            this.Btn_Iptal.TabIndex = 11;
            this.Btn_Iptal.Text = "İptal";
            this.Btn_Iptal.Click += new System.EventHandler(this.Btn_Iptal_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(39, 80);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(43, 45);
            this.pictureEdit1.TabIndex = 12;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(39, 144);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Size = new System.Drawing.Size(43, 45);
            this.pictureEdit2.TabIndex = 13;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(39, 211);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Size = new System.Drawing.Size(43, 45);
            this.pictureEdit3.TabIndex = 14;
            // 
            // pictureEdit4
            // 
            this.pictureEdit4.EditValue = ((object)(resources.GetObject("pictureEdit4.EditValue")));
            this.pictureEdit4.Location = new System.Drawing.Point(39, 277);
            this.pictureEdit4.Name = "pictureEdit4";
            this.pictureEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit4.Size = new System.Drawing.Size(43, 45);
            this.pictureEdit4.TabIndex = 15;
            // 
            // pictureEdit5
            // 
            this.pictureEdit5.EditValue = ((object)(resources.GetObject("pictureEdit5.EditValue")));
            this.pictureEdit5.Location = new System.Drawing.Point(40, 350);
            this.pictureEdit5.Name = "pictureEdit5";
            this.pictureEdit5.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit5.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit5.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit5.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit5.Size = new System.Drawing.Size(43, 45);
            this.pictureEdit5.TabIndex = 18;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(120, 358);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(116, 16);
            this.labelControl5.TabIndex = 17;
            this.labelControl5.Text = "Pres Adetini Giriniz :";
            // 
            // num_PresAdet
            // 
            this.num_PresAdet.Location = new System.Drawing.Point(332, 356);
            this.num_PresAdet.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.num_PresAdet.Name = "num_PresAdet";
            this.num_PresAdet.Size = new System.Drawing.Size(138, 22);
            this.num_PresAdet.TabIndex = 16;
            // 
            // Frm_HamRaporEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 613);
            this.Controls.Add(this.pictureEdit5);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.num_PresAdet);
            this.Controls.Add(this.pictureEdit4);
            this.Controls.Add(this.pictureEdit3);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.Btn_Iptal);
            this.Controls.Add(this.Btn_Ekle);
            this.Controls.Add(this.txt_raporlayan);
            this.Controls.Add(this.txt_secilenHam);
            this.Controls.Add(this.txt_secilenSip);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.num_Miktar);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Name = "Frm_HamRaporEkle";
            this.Text = "Hammadde Rapor Ekle";
            this.Load += new System.EventHandler(this.Frm_HamRaporEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Miktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_secilenSip.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_secilenHam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_raporlayan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_PresAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.NumericUpDown num_Miktar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_secilenSip;
        private DevExpress.XtraEditors.TextEdit txt_secilenHam;
        private DevExpress.XtraEditors.TextEdit txt_raporlayan;
        private DevExpress.XtraEditors.SimpleButton Btn_Ekle;
        private DevExpress.XtraEditors.SimpleButton Btn_Iptal;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit4;
        private DevExpress.XtraEditors.PictureEdit pictureEdit5;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.NumericUpDown num_PresAdet;
    }
}