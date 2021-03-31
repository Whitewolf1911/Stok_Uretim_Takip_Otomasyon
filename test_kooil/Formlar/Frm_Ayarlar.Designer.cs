
namespace test_kooil.Formlar
{
    partial class Frm_Ayarlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Ayarlar));
            this.Btn_YeniKullanici = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_YeniKullanici
            // 
            this.Btn_YeniKullanici.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_YeniKullanici.ImageOptions.Image")));
            this.Btn_YeniKullanici.Location = new System.Drawing.Point(12, 12);
            this.Btn_YeniKullanici.Name = "Btn_YeniKullanici";
            this.Btn_YeniKullanici.Size = new System.Drawing.Size(200, 46);
            this.Btn_YeniKullanici.TabIndex = 0;
            this.Btn_YeniKullanici.Text = "Yeni Kullanıcı";
            this.Btn_YeniKullanici.Click += new System.EventHandler(this.Btn_YeniKullanici_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(12, 211);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(200, 46);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Kullanıcıyı Sil";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(218, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1234, 604);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Frm_Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 628);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.Btn_YeniKullanici);
            this.Name = "Frm_Ayarlar";
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.Frm_Ayarlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Btn_YeniKullanici;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}