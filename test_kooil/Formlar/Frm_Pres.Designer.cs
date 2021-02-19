
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
            this.Btn_PresEkle = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_PresRapor = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Guncelle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(955, 521);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.Btn_PresEkle);
            this.groupControl1.Controls.Add(this.Btn_PresRapor);
            this.groupControl1.Controls.Add(this.Btn_Guncelle);
            this.groupControl1.Location = new System.Drawing.Point(973, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(211, 521);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Pres Kontrol Paneli";
            // 
            // Btn_PresEkle
            // 
            this.Btn_PresEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_PresEkle.ImageOptions.Image")));
            this.Btn_PresEkle.Location = new System.Drawing.Point(14, 44);
            this.Btn_PresEkle.Name = "Btn_PresEkle";
            this.Btn_PresEkle.Size = new System.Drawing.Size(174, 48);
            this.Btn_PresEkle.TabIndex = 2;
            this.Btn_PresEkle.Text = "Islenen Urun Ekle";
            this.Btn_PresEkle.Click += new System.EventHandler(this.Btn_PresEkle_Click);
            // 
            // Btn_PresRapor
            // 
            this.Btn_PresRapor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_PresRapor.ImageOptions.Image")));
            this.Btn_PresRapor.Location = new System.Drawing.Point(14, 175);
            this.Btn_PresRapor.Name = "Btn_PresRapor";
            this.Btn_PresRapor.Size = new System.Drawing.Size(174, 48);
            this.Btn_PresRapor.TabIndex = 1;
            this.Btn_PresRapor.Text = "Pres Raporlari";
            this.Btn_PresRapor.Click += new System.EventHandler(this.Btn_PresRapor_Click);
            // 
            // Btn_Guncelle
            // 
            this.Btn_Guncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guncelle.ImageOptions.Image")));
            this.Btn_Guncelle.Location = new System.Drawing.Point(14, 109);
            this.Btn_Guncelle.Name = "Btn_Guncelle";
            this.Btn_Guncelle.Size = new System.Drawing.Size(174, 48);
            this.Btn_Guncelle.TabIndex = 0;
            this.Btn_Guncelle.Text = "Listeyi Yenile";
            this.Btn_Guncelle.Click += new System.EventHandler(this.Btn_Guncelle_Click);
            // 
            // Frm_Pres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 545);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Frm_Pres";
            this.Text = "Pres";
            this.Load += new System.EventHandler(this.Frm_Pres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton Btn_Guncelle;
        private DevExpress.XtraEditors.SimpleButton Btn_PresEkle;
        private DevExpress.XtraEditors.SimpleButton Btn_PresRapor;
    }
}