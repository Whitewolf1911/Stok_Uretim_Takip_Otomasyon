
namespace test_kooil.Formlar
{
    partial class Frm_SevkiyatSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SevkiyatSil));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Btn_sil = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Yenile = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(73, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(958, 534);
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
            // Btn_sil
            // 
            this.Btn_sil.Enabled = false;
            this.Btn_sil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_sil.ImageOptions.Image")));
            this.Btn_sil.Location = new System.Drawing.Point(12, 12);
            this.Btn_sil.Name = "Btn_sil";
            this.Btn_sil.Size = new System.Drawing.Size(55, 54);
            this.Btn_sil.TabIndex = 1;
            this.Btn_sil.Click += new System.EventHandler(this.Btn_sil_Click);
            // 
            // Btn_Yenile
            // 
            this.Btn_Yenile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Yenile.ImageOptions.Image")));
            this.Btn_Yenile.Location = new System.Drawing.Point(12, 84);
            this.Btn_Yenile.Name = "Btn_Yenile";
            this.Btn_Yenile.Size = new System.Drawing.Size(55, 54);
            this.Btn_Yenile.TabIndex = 2;
            this.Btn_Yenile.Click += new System.EventHandler(this.Btn_Yenile_Click);
            // 
            // Frm_SevkiyatSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 558);
            this.Controls.Add(this.Btn_Yenile);
            this.Controls.Add(this.Btn_sil);
            this.Controls.Add(this.gridControl1);
            this.Name = "Frm_SevkiyatSil";
            this.Text = "Sevkiyat Sil";
            this.Load += new System.EventHandler(this.Frm_SevkiyatSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton Btn_sil;
        private DevExpress.XtraEditors.SimpleButton Btn_Yenile;
    }
}