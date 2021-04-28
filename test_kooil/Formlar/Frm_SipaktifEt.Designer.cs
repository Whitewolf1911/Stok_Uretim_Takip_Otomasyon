
namespace test_kooil.Formlar
{
    partial class Frm_SipaktifEt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SipaktifEt));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Btn_aktifet = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_yenile = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(67, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1027, 504);
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
            // Btn_aktifet
            // 
            this.Btn_aktifet.Enabled = false;
            this.Btn_aktifet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_aktifet.ImageOptions.Image")));
            this.Btn_aktifet.Location = new System.Drawing.Point(12, 12);
            this.Btn_aktifet.Name = "Btn_aktifet";
            this.Btn_aktifet.Size = new System.Drawing.Size(49, 63);
            this.Btn_aktifet.TabIndex = 1;
            this.Btn_aktifet.Click += new System.EventHandler(this.Btn_aktifet_Click);
            // 
            // Btn_yenile
            // 
            this.Btn_yenile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_yenile.ImageOptions.Image")));
            this.Btn_yenile.Location = new System.Drawing.Point(12, 93);
            this.Btn_yenile.Name = "Btn_yenile";
            this.Btn_yenile.Size = new System.Drawing.Size(49, 63);
            this.Btn_yenile.TabIndex = 2;
            this.Btn_yenile.Click += new System.EventHandler(this.Btn_yenile_Click);
            // 
            // Frm_SipaktifEt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 528);
            this.Controls.Add(this.Btn_yenile);
            this.Controls.Add(this.Btn_aktifet);
            this.Controls.Add(this.gridControl1);
            this.Name = "Frm_SipaktifEt";
            this.Text = "Sipariş Aktif Et";
            this.Load += new System.EventHandler(this.Frm_SipaktifEt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton Btn_aktifet;
        private DevExpress.XtraEditors.SimpleButton Btn_yenile;
    }
}