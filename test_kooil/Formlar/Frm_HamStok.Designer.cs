
namespace test_kooil.Formlar
{
    partial class Frm_HamStok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HamStok));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.Btn_yazdir = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Yenile = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_hamSil = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_yeniHamEkle = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_hamLog = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(303, 15);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1145, 598);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.Btn_hamLog);
            this.groupControl1.Controls.Add(this.Btn_yazdir);
            this.groupControl1.Controls.Add(this.Btn_Yenile);
            this.groupControl1.Controls.Add(this.Btn_hamSil);
            this.groupControl1.Controls.Add(this.Btn_yeniHamEkle);
            this.groupControl1.Location = new System.Drawing.Point(16, 15);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(279, 598);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Hammadde Stok Paneli";
            // 
            // Btn_yazdir
            // 
            this.Btn_yazdir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_yazdir.ImageOptions.Image")));
            this.Btn_yazdir.Location = new System.Drawing.Point(21, 429);
            this.Btn_yazdir.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_yazdir.Name = "Btn_yazdir";
            this.Btn_yazdir.Size = new System.Drawing.Size(233, 53);
            this.Btn_yazdir.TabIndex = 3;
            this.Btn_yazdir.Text = "Yazdır";
            this.Btn_yazdir.Click += new System.EventHandler(this.Btn_yazdir_Click);
            // 
            // Btn_Yenile
            // 
            this.Btn_Yenile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Yenile.ImageOptions.Image")));
            this.Btn_Yenile.Location = new System.Drawing.Point(21, 191);
            this.Btn_Yenile.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Yenile.Name = "Btn_Yenile";
            this.Btn_Yenile.Size = new System.Drawing.Size(233, 53);
            this.Btn_Yenile.TabIndex = 2;
            this.Btn_Yenile.Text = "Listeyi Yenile";
            this.Btn_Yenile.Click += new System.EventHandler(this.Btn_Yenile_Click);
            // 
            // Btn_hamSil
            // 
            this.Btn_hamSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_hamSil.ImageOptions.Image")));
            this.Btn_hamSil.Location = new System.Drawing.Point(21, 117);
            this.Btn_hamSil.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_hamSil.Name = "Btn_hamSil";
            this.Btn_hamSil.Size = new System.Drawing.Size(233, 53);
            this.Btn_hamSil.TabIndex = 1;
            this.Btn_hamSil.Text = "Hammadde Sil";
            this.Btn_hamSil.Click += new System.EventHandler(this.Btn_hamSil_Click);
            // 
            // Btn_yeniHamEkle
            // 
            this.Btn_yeniHamEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_yeniHamEkle.ImageOptions.Image")));
            this.Btn_yeniHamEkle.Location = new System.Drawing.Point(21, 44);
            this.Btn_yeniHamEkle.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_yeniHamEkle.Name = "Btn_yeniHamEkle";
            this.Btn_yeniHamEkle.Size = new System.Drawing.Size(233, 53);
            this.Btn_yeniHamEkle.TabIndex = 0;
            this.Btn_yeniHamEkle.Text = "Yeni Hammadde Ekle";
            this.Btn_yeniHamEkle.Click += new System.EventHandler(this.Btn_yeniHamEkle_Click);
            // 
            // Btn_hamLog
            // 
            this.Btn_hamLog.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.Btn_hamLog.Location = new System.Drawing.Point(103, 539);
            this.Btn_hamLog.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_hamLog.Name = "Btn_hamLog";
            this.Btn_hamLog.Size = new System.Drawing.Size(170, 53);
            this.Btn_hamLog.TabIndex = 4;
            this.Btn_hamLog.Text = "Hammadde Log";
            this.Btn_hamLog.Click += new System.EventHandler(this.Btn_hamLog_Click);
            // 
            // Frm_HamStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 628);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_HamStok";
            this.Text = "Hammadde Stok";
            this.Load += new System.EventHandler(this.Frm_HamStok_Load);
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
        private DevExpress.XtraEditors.SimpleButton Btn_Yenile;
        private DevExpress.XtraEditors.SimpleButton Btn_hamSil;
        private DevExpress.XtraEditors.SimpleButton Btn_yeniHamEkle;
        private DevExpress.XtraEditors.SimpleButton Btn_yazdir;
        private DevExpress.XtraEditors.SimpleButton Btn_hamLog;
    }
}