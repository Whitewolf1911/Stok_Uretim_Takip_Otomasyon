
namespace test_kooil.Formlar
{
    partial class Frm_ArkaSiyirma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ArkaSiyirma));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_sipIgneTur = new DevExpress.XtraEditors.TextEdit();
            this.txt_sipNot = new System.Windows.Forms.RichTextBox();
            this.Btn_SiyirmaEkle = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_SiyirmaRapor = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sipIgneTur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txt_sipIgneTur);
            this.groupControl1.Controls.Add(this.txt_sipNot);
            this.groupControl1.Controls.Add(this.Btn_SiyirmaEkle);
            this.groupControl1.Controls.Add(this.Btn_SiyirmaRapor);
            this.groupControl1.Controls.Add(this.Btn_Guncelle);
            this.groupControl1.Location = new System.Drawing.Point(1133, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(328, 604);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Arka Sıyırma Paneli";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 413);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 16);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Sipariş Notu :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 345);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 16);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "İğne :";
            // 
            // txt_sipIgneTur
            // 
            this.txt_sipIgneTur.Location = new System.Drawing.Point(113, 342);
            this.txt_sipIgneTur.Name = "txt_sipIgneTur";
            this.txt_sipIgneTur.Size = new System.Drawing.Size(143, 22);
            this.txt_sipIgneTur.TabIndex = 8;
            // 
            // txt_sipNot
            // 
            this.txt_sipNot.Location = new System.Drawing.Point(113, 413);
            this.txt_sipNot.Name = "txt_sipNot";
            this.txt_sipNot.Size = new System.Drawing.Size(143, 124);
            this.txt_sipNot.TabIndex = 7;
            this.txt_sipNot.Text = "";
            // 
            // Btn_SiyirmaEkle
            // 
            this.Btn_SiyirmaEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_SiyirmaEkle.ImageOptions.Image")));
            this.Btn_SiyirmaEkle.Location = new System.Drawing.Point(12, 43);
            this.Btn_SiyirmaEkle.Name = "Btn_SiyirmaEkle";
            this.Btn_SiyirmaEkle.Size = new System.Drawing.Size(174, 48);
            this.Btn_SiyirmaEkle.TabIndex = 2;
            this.Btn_SiyirmaEkle.Text = "İşlenen Ürün Ekle";
            this.Btn_SiyirmaEkle.Click += new System.EventHandler(this.Btn_SiyirmaEkle_Click);
            // 
            // Btn_SiyirmaRapor
            // 
            this.Btn_SiyirmaRapor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_SiyirmaRapor.ImageOptions.Image")));
            this.Btn_SiyirmaRapor.Location = new System.Drawing.Point(12, 174);
            this.Btn_SiyirmaRapor.Name = "Btn_SiyirmaRapor";
            this.Btn_SiyirmaRapor.Size = new System.Drawing.Size(174, 48);
            this.Btn_SiyirmaRapor.TabIndex = 1;
            this.Btn_SiyirmaRapor.Text = "Sıyırma Raporları";
            this.Btn_SiyirmaRapor.Click += new System.EventHandler(this.Btn_SiyirmaRapor_Click);
            // 
            // Btn_Guncelle
            // 
            this.Btn_Guncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guncelle.ImageOptions.Image")));
            this.Btn_Guncelle.Location = new System.Drawing.Point(12, 108);
            this.Btn_Guncelle.Name = "Btn_Guncelle";
            this.Btn_Guncelle.Size = new System.Drawing.Size(174, 48);
            this.Btn_Guncelle.TabIndex = 0;
            this.Btn_Guncelle.Text = "Listeyi Yenile";
            this.Btn_Guncelle.Click += new System.EventHandler(this.Btn_Guncelle_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(4, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1123, 604);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // Frm_ArkaSiyirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 628);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Frm_ArkaSiyirma";
            this.Text = "Arka Sıyırma";
            this.Load += new System.EventHandler(this.Frm_ArkaSiyirma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sipIgneTur.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton Btn_SiyirmaEkle;
        private DevExpress.XtraEditors.SimpleButton Btn_SiyirmaRapor;
        private DevExpress.XtraEditors.SimpleButton Btn_Guncelle;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_sipIgneTur;
        private System.Windows.Forms.RichTextBox txt_sipNot;
    }
}