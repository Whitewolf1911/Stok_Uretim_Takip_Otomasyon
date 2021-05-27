
namespace test_kooil.Formlar
{
    partial class Frm_YeniTestere
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_YeniTestere));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Btn_ekle = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_iptal = new DevExpress.XtraEditors.SimpleButton();
            this.txt_testereKod = new DevExpress.XtraEditors.TextEdit();
            this.num_adet = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txt_testereKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_adet)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(36, 58);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(85, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Testere Kodu :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(36, 115);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Adet :";
            // 
            // Btn_ekle
            // 
            this.Btn_ekle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.Btn_ekle.Location = new System.Drawing.Point(12, 243);
            this.Btn_ekle.Name = "Btn_ekle";
            this.Btn_ekle.Size = new System.Drawing.Size(134, 63);
            this.Btn_ekle.TabIndex = 2;
            this.Btn_ekle.Text = "Ekle";
            this.Btn_ekle.Click += new System.EventHandler(this.Btn_ekle_Click);
            // 
            // Btn_iptal
            // 
            this.Btn_iptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.Btn_iptal.Location = new System.Drawing.Point(269, 243);
            this.Btn_iptal.Name = "Btn_iptal";
            this.Btn_iptal.Size = new System.Drawing.Size(134, 63);
            this.Btn_iptal.TabIndex = 3;
            this.Btn_iptal.Text = "İptal";
            this.Btn_iptal.Click += new System.EventHandler(this.Btn_iptal_Click);
            // 
            // txt_testereKod
            // 
            this.txt_testereKod.Location = new System.Drawing.Point(153, 55);
            this.txt_testereKod.Name = "txt_testereKod";
            this.txt_testereKod.Properties.MaxLength = 25;
            this.txt_testereKod.Size = new System.Drawing.Size(203, 22);
            this.txt_testereKod.TabIndex = 4;
            // 
            // num_adet
            // 
            this.num_adet.Location = new System.Drawing.Point(153, 115);
            this.num_adet.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_adet.Name = "num_adet";
            this.num_adet.Size = new System.Drawing.Size(203, 22);
            this.num_adet.TabIndex = 5;
            // 
            // Frm_YeniTestere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 318);
            this.Controls.Add(this.num_adet);
            this.Controls.Add(this.txt_testereKod);
            this.Controls.Add(this.Btn_iptal);
            this.Controls.Add(this.Btn_ekle);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "Frm_YeniTestere";
            this.Text = "Yeni Testere";
            ((System.ComponentModel.ISupportInitialize)(this.txt_testereKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_adet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton Btn_ekle;
        private DevExpress.XtraEditors.SimpleButton Btn_iptal;
        private DevExpress.XtraEditors.TextEdit txt_testereKod;
        private System.Windows.Forms.NumericUpDown num_adet;
    }
}