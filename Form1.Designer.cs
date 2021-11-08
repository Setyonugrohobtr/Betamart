namespace Betamart
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Keamanan = new System.Windows.Forms.ToolStripButton();
            this.tsListofProducts = new System.Windows.Forms.ToolStripButton();
            this.tsBread = new System.Windows.Forms.ToolStripButton();
            this.tsStockin = new System.Windows.Forms.ToolStripButton();
            this.tsStockout = new System.Windows.Forms.ToolStripButton();
            this.tsUser = new System.Windows.Forms.ToolStripButton();
            this.tsReport = new System.Windows.Forms.ToolStripButton();
            this.Cancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(60, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Keamanan,
            this.tsListofProducts,
            this.tsBread,
            this.tsStockin,
            this.tsStockout,
            this.tsUser,
            this.tsReport});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 205);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(921, 72);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Keamanan
            // 
            this.Keamanan.Image = global::Betamart.Properties.Resources.user;
            this.Keamanan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Keamanan.Margin = new System.Windows.Forms.Padding(150, 1, 0, 2);
            this.Keamanan.Name = "Keamanan";
            this.Keamanan.Size = new System.Drawing.Size(64, 69);
            this.Keamanan.Text = "Masuk";
            this.Keamanan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Keamanan.Click += new System.EventHandler(this.ModulMasuk);
            // 
            // tsListofProducts
            // 
            this.tsListofProducts.Image = ((System.Drawing.Image)(resources.GetObject("tsListofProducts.Image")));
            this.tsListofProducts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsListofProducts.Name = "tsListofProducts";
            this.tsListofProducts.Size = new System.Drawing.Size(84, 69);
            this.tsListofProducts.Text = "Daftar Produk";
            this.tsListofProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsListofProducts.Click += new System.EventHandler(this.daftarproduk);
            // 
            // tsBread
            // 
            this.tsBread.Image = global::Betamart.Properties.Resources.Produk;
            this.tsBread.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBread.Name = "tsBread";
            this.tsBread.Size = new System.Drawing.Size(94, 69);
            this.tsBread.Text = "Tambah Produk";
            this.tsBread.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBread.Click += new System.EventHandler(this.tambahproduk);
            // 
            // tsStockin
            // 
            this.tsStockin.Image = ((System.Drawing.Image)(resources.GetObject("tsStockin.Image")));
            this.tsStockin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsStockin.Name = "tsStockin";
            this.tsStockin.Size = new System.Drawing.Size(78, 69);
            this.tsStockin.Text = "Stock Masuk";
            this.tsStockin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsStockin.Click += new System.EventHandler(this.tambahstok);
            // 
            // tsStockout
            // 
            this.tsStockout.Image = ((System.Drawing.Image)(resources.GetObject("tsStockout.Image")));
            this.tsStockout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsStockout.Name = "tsStockout";
            this.tsStockout.Size = new System.Drawing.Size(111, 69);
            this.tsStockout.Text = "Stock Habis/Keluar";
            this.tsStockout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsStockout.Click += new System.EventHandler(this.terbeli);
            // 
            // tsUser
            // 
            this.tsUser.Image = ((System.Drawing.Image)(resources.GetObject("tsUser.Image")));
            this.tsUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUser.Name = "tsUser";
            this.tsUser.Size = new System.Drawing.Size(105, 69);
            this.tsUser.Text = "Manajemen Akun";
            this.tsUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsUser.Click += new System.EventHandler(this.akun);
            // 
            // tsReport
            // 
            this.tsReport.Image = ((System.Drawing.Image)(resources.GetObject("tsReport.Image")));
            this.tsReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsReport.Name = "tsReport";
            this.tsReport.Size = new System.Drawing.Size(109, 69);
            this.tsReport.Text = "Laporan Penjualan";
            this.tsReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsReport.Click += new System.EventHandler(this.laporan);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Image = global::Betamart.Properties.Resources.tutup;
            this.Cancel.Location = new System.Drawing.Point(753, 12);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(156, 34);
            this.Cancel.TabIndex = 6;
            this.Cancel.Click += new System.EventHandler(this.TutupJendelaForm1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Betamart.Properties.Resources.Betamart;
            this.pictureBox1.Location = new System.Drawing.Point(325, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 73);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Betamart.Properties.Resources.BetaMartPage1;
            this.ClientSize = new System.Drawing.Size(921, 277);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BetaMart";
            this.Load += new System.EventHandler(this.pergantian);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBread;
        private System.Windows.Forms.ToolStripButton tsStockin;
        private System.Windows.Forms.ToolStripButton tsStockout;
        private System.Windows.Forms.ToolStripButton tsUser;
        private System.Windows.Forms.ToolStripButton tsReport;
        private System.Windows.Forms.ToolStripButton Keamanan;
        private System.Windows.Forms.ToolStripButton tsListofProducts;
        internal System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

