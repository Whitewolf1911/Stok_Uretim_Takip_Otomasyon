
namespace test_kooil.Formlar
{
    partial class Frm_UrunStokDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_UrunStokDuzenle));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pictureEdit4 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.txt_raporlayan = new DevExpress.XtraEditors.TextEdit();
            this.txt_secilenUrun = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.num_Miktar = new System.Windows.Forms.NumericUpDown();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.Btn_azalt = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Ekle = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Iptal = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_raporlayan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_secilenUrun.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Miktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(367, 8);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(472, 469);
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
            // pictureEdit4
            // 
            this.pictureEdit4.EditValue = ((object)(resources.GetObject("pictureEdit4.EditValue")));
            this.pictureEdit4.Location = new System.Drawing.Point(11, 189);
            this.pictureEdit4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureEdit4.Name = "pictureEdit4";
            this.pictureEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit4.Size = new System.Drawing.Size(32, 37);
            this.pictureEdit4.TabIndex = 53;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(11, 102);
            this.pictureEdit3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Size = new System.Drawing.Size(32, 37);
            this.pictureEdit3.TabIndex = 52;
            // 
            // txt_raporlayan
            // 
            this.txt_raporlayan.Enabled = false;
            this.txt_raporlayan.Location = new System.Drawing.Point(167, 115);
            this.txt_raporlayan.Margin = new System.Windows.Forms.Padding(2);
            this.txt_raporlayan.Name = "txt_raporlayan";
            this.txt_raporlayan.Size = new System.Drawing.Size(183, 20);
            this.txt_raporlayan.TabIndex = 50;
            // 
            // txt_secilenUrun
            // 
            this.txt_secilenUrun.Location = new System.Drawing.Point(167, 33);
            this.txt_secilenUrun.Margin = new System.Windows.Forms.Padding(2);
            this.txt_secilenUrun.Name = "txt_secilenUrun";
            this.txt_secilenUrun.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_secilenUrun.Properties.Appearance.Options.UseBackColor = true;
            this.txt_secilenUrun.Properties.ReadOnly = true;
            this.txt_secilenUrun.Size = new System.Drawing.Size(183, 20);
            this.txt_secilenUrun.TabIndex = 49;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(55, 200);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(99, 13);
            this.labelControl4.TabIndex = 48;
            this.labelControl4.Text = "Miktarı Giriniz ( KG ) :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(53, 118);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 13);
            this.labelControl3.TabIndex = 47;
            this.labelControl3.Text = "İşlem Yapan :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(53, 35);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 13);
            this.labelControl2.TabIndex = 46;
            this.labelControl2.Text = "Seçilen Ürün :";
            // 
            // num_Miktar
            // 
            this.num_Miktar.Location = new System.Drawing.Point(167, 200);
            this.num_Miktar.Margin = new System.Windows.Forms.Padding(2);
            this.num_Miktar.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.num_Miktar.Name = "num_Miktar";
            this.num_Miktar.Size = new System.Drawing.Size(116, 20);
            this.num_Miktar.TabIndex = 45;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(2, 20);
            this.pictureEdit2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Size = new System.Drawing.Size(47, 48);
            this.pictureEdit2.TabIndex = 57;
            // 
            // Btn_azalt
            // 
            this.Btn_azalt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_azalt.ImageOptions.Image")));
            this.Btn_azalt.Location = new System.Drawing.Point(11, 431);
            this.Btn_azalt.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_azalt.Name = "Btn_azalt";
            this.Btn_azalt.Size = new System.Drawing.Size(120, 46);
            this.Btn_azalt.TabIndex = 59;
            this.Btn_azalt.Text = "Azalt";
            this.Btn_azalt.Click += new System.EventHandler(this.Btn_azalt_Click);
            // 
            // Btn_Ekle
            // 
            this.Btn_Ekle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ekle.ImageOptions.Image")));
            this.Btn_Ekle.Location = new System.Drawing.Point(11, 354);
            this.Btn_Ekle.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Ekle.Name = "Btn_Ekle";
            this.Btn_Ekle.Size = new System.Drawing.Size(120, 46);
            this.Btn_Ekle.TabIndex = 58;
            this.Btn_Ekle.Text = "Ekle";
            this.Btn_Ekle.Click += new System.EventHandler(this.Btn_Ekle_Click);
            // 
            // Btn_Iptal
            // 
            this.Btn_Iptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Iptal.ImageOptions.Image")));
            this.Btn_Iptal.Location = new System.Drawing.Point(230, 431);
            this.Btn_Iptal.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Iptal.Name = "Btn_Iptal";
            this.Btn_Iptal.Size = new System.Drawing.Size(120, 46);
            this.Btn_Iptal.TabIndex = 60;
            this.Btn_Iptal.Text = "İptal";
            this.Btn_Iptal.Click += new System.EventHandler(this.Btn_Iptal_Click);
            // 
            // Frm_UrunStokDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 493);
            this.Controls.Add(this.Btn_Iptal);
            this.Controls.Add(this.Btn_azalt);
            this.Controls.Add(this.Btn_Ekle);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.pictureEdit4);
            this.Controls.Add(this.pictureEdit3);
            this.Controls.Add(this.txt_raporlayan);
            this.Controls.Add(this.txt_secilenUrun);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.num_Miktar);
            this.Controls.Add(this.gridControl1);
            this.Name = "Frm_UrunStokDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Stok Düzenle";
            this.Load += new System.EventHandler(this.Frm_UrunStokDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_raporlayan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_secilenUrun.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Miktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit4;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.TextEdit txt_raporlayan;
        private DevExpress.XtraEditors.TextEdit txt_secilenUrun;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.NumericUpDown num_Miktar;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.SimpleButton Btn_azalt;
        private DevExpress.XtraEditors.SimpleButton Btn_Ekle;
        private DevExpress.XtraEditors.SimpleButton Btn_Iptal;
    }
}