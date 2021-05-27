
namespace test_kooil.Formlar
{
    partial class Frm_testereTanimla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_testereTanimla));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridTestere1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridTestere2 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_urun = new DevExpress.XtraEditors.TextEdit();
            this.txt_test1 = new DevExpress.XtraEditors.TextEdit();
            this.txt_test2 = new DevExpress.XtraEditors.TextEdit();
            this.Btn_sifirla = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTestere1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTestere2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_urun.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_test1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_test2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControl1.Location = new System.Drawing.Point(9, 10);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(364, 443);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridTestere1
            // 
            this.gridTestere1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridTestere1.Location = new System.Drawing.Point(443, 10);
            this.gridTestere1.MainView = this.gridView2;
            this.gridTestere1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridTestere1.Name = "gridTestere1";
            this.gridTestere1.Size = new System.Drawing.Size(190, 366);
            this.gridTestere1.TabIndex = 1;
            this.gridTestere1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.DetailHeight = 284;
            this.gridView2.GridControl = this.gridTestere1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            // 
            // gridTestere2
            // 
            this.gridTestere2.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridTestere2.Location = new System.Drawing.Point(691, 10);
            this.gridTestere2.MainView = this.gridView3;
            this.gridTestere2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridTestere2.Name = "gridTestere2";
            this.gridTestere2.Size = new System.Drawing.Size(190, 366);
            this.gridTestere2.TabIndex = 2;
            this.gridTestere2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.DetailHeight = 284;
            this.gridView3.GridControl = this.gridTestere2;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView3_FocusedRowChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(391, 10);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Testere 1 :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(638, 10);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Testere 2 :";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_kaydet.ImageOptions.Image")));
            this.btn_kaydet.Location = new System.Drawing.Point(638, 460);
            this.btn_kaydet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(112, 45);
            this.btn_kaydet.TabIndex = 5;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(771, 458);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(110, 46);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "İptal";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(401, 406);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Seçilen Ürün :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(401, 451);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(53, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Testere 1 :";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(401, 492);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(53, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Testere 2 :";
            // 
            // txt_urun
            // 
            this.txt_urun.Location = new System.Drawing.Point(476, 406);
            this.txt_urun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_urun.Name = "txt_urun";
            this.txt_urun.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_urun.Properties.Appearance.Options.UseBackColor = true;
            this.txt_urun.Properties.ReadOnly = true;
            this.txt_urun.Size = new System.Drawing.Size(158, 20);
            this.txt_urun.TabIndex = 10;
            // 
            // txt_test1
            // 
            this.txt_test1.Location = new System.Drawing.Point(476, 448);
            this.txt_test1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_test1.Name = "txt_test1";
            this.txt_test1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_test1.Properties.Appearance.Options.UseBackColor = true;
            this.txt_test1.Properties.ReadOnly = true;
            this.txt_test1.Size = new System.Drawing.Size(142, 20);
            this.txt_test1.TabIndex = 11;
            // 
            // txt_test2
            // 
            this.txt_test2.Location = new System.Drawing.Point(476, 489);
            this.txt_test2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_test2.Name = "txt_test2";
            this.txt_test2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_test2.Properties.Appearance.Options.UseBackColor = true;
            this.txt_test2.Properties.ReadOnly = true;
            this.txt_test2.Size = new System.Drawing.Size(142, 20);
            this.txt_test2.TabIndex = 12;
            // 
            // Btn_sifirla
            // 
            this.Btn_sifirla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.Btn_sifirla.Location = new System.Drawing.Point(771, 393);
            this.Btn_sifirla.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_sifirla.Name = "Btn_sifirla";
            this.Btn_sifirla.Size = new System.Drawing.Size(110, 46);
            this.Btn_sifirla.TabIndex = 13;
            this.Btn_sifirla.Text = "Sıfırla";
            this.Btn_sifirla.Click += new System.EventHandler(this.Btn_sifirla_Click);
            // 
            // Frm_testereTanimla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 514);
            this.Controls.Add(this.Btn_sifirla);
            this.Controls.Add(this.txt_test2);
            this.Controls.Add(this.txt_test1);
            this.Controls.Add(this.txt_urun);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridTestere2);
            this.Controls.Add(this.gridTestere1);
            this.Controls.Add(this.gridControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_testereTanimla";
            this.Text = "Testere Tanımla";
            this.Load += new System.EventHandler(this.Frm_testereTanimla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTestere1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTestere2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_urun.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_test1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_test2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridTestere1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gridTestere2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_kaydet;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_urun;
        private DevExpress.XtraEditors.TextEdit txt_test1;
        private DevExpress.XtraEditors.TextEdit txt_test2;
        private DevExpress.XtraEditors.SimpleButton Btn_sifirla;
    }
}