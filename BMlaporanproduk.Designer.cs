namespace Betamart
{
    partial class BMlaporanproduk
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
            this.cboCateg = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.dtglist = new System.Windows.Forms.DataGridView();
            this.LBLLIST = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rdoWeekly = new System.Windows.Forms.RadioButton();
            this.Label2 = new System.Windows.Forms.Label();
            this.rdoMonthly = new System.Windows.Forms.RadioButton();
            this.Label3 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.BTNSEARCHGRID = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rdoToday = new System.Windows.Forms.RadioButton();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.rdoProduct = new System.Windows.Forms.RadioButton();
            this.rdoStockIn = new System.Windows.Forms.RadioButton();
            this.rdoStockOut = new System.Windows.Forms.RadioButton();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtglist)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboCateg
            // 
            this.cboCateg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCateg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCateg.Items.AddRange(new object[] {
            "WWEShop",
            "Makanan",
            "Minuman",
            "AEW Collections",
            "NJPW"});
            this.cboCateg.Location = new System.Drawing.Point(9, 65);
            this.cboCateg.Name = "cboCateg";
            this.cboCateg.Size = new System.Drawing.Size(174, 24);
            this.cboCateg.TabIndex = 6;
            this.cboCateg.Text = "Kategori";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::Betamart.Properties.Resources.tutup;
            this.btnClose.Location = new System.Drawing.Point(13, 522);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(145, 34);
            this.btnClose.TabIndex = 37;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.tutupjendelalaporan);
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.dtglist);
            this.Panel3.Controls.Add(this.LBLLIST);
            this.Panel3.Location = new System.Drawing.Point(9, 125);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(793, 325);
            this.Panel3.TabIndex = 40;
            // 
            // dtglist
            // 
            this.dtglist.AllowUserToAddRows = false;
            this.dtglist.AllowUserToDeleteRows = false;
            this.dtglist.AllowUserToResizeColumns = false;
            this.dtglist.AllowUserToResizeRows = false;
            this.dtglist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtglist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtglist.Location = new System.Drawing.Point(0, 28);
            this.dtglist.Name = "dtglist";
            this.dtglist.ReadOnly = true;
            this.dtglist.RowHeadersVisible = false;
            this.dtglist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtglist.Size = new System.Drawing.Size(793, 297);
            this.dtglist.TabIndex = 1;
            // 
            // LBLLIST
            // 
            this.LBLLIST.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LBLLIST.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBLLIST.Font = new System.Drawing.Font("Rawhide Raw 2016", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLLIST.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LBLLIST.Location = new System.Drawing.Point(0, 0);
            this.LBLLIST.Name = "LBLLIST";
            this.LBLLIST.Size = new System.Drawing.Size(793, 28);
            this.LBLLIST.TabIndex = 2;
            this.LBLLIST.Text = "Laporan produk";
            this.LBLLIST.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(189, 67);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 29);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.tombolpencarian);
            // 
            // rdoWeekly
            // 
            this.rdoWeekly.AutoSize = true;
            this.rdoWeekly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoWeekly.Location = new System.Drawing.Point(255, 21);
            this.rdoWeekly.Name = "rdoWeekly";
            this.rdoWeekly.Size = new System.Drawing.Size(80, 17);
            this.rdoWeekly.TabIndex = 2;
            this.rdoWeekly.TabStop = true;
            this.rdoWeekly.Text = "Mingguan";
            this.rdoWeekly.UseVisualStyleBackColor = true;
            this.rdoWeekly.CheckedChanged += new System.EventHandler(this.cekperubahanmingguan);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(6, 35);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(30, 13);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Dari";
            // 
            // rdoMonthly
            // 
            this.rdoMonthly.AutoSize = true;
            this.rdoMonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMonthly.Location = new System.Drawing.Point(189, 44);
            this.rdoMonthly.Name = "rdoMonthly";
            this.rdoMonthly.Size = new System.Drawing.Size(71, 17);
            this.rdoMonthly.TabIndex = 2;
            this.rdoMonthly.TabStop = true;
            this.rdoMonthly.Text = "Bulanan";
            this.rdoMonthly.UseVisualStyleBackColor = true;
            this.rdoMonthly.CheckedChanged += new System.EventHandler(this.cekperubahanbulanan);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(5, 69);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(48, 13);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "Sampai";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(61, 35);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(122, 20);
            this.dtpFrom.TabIndex = 0;
            // 
            // BTNSEARCHGRID
            // 
            this.BTNSEARCHGRID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSEARCHGRID.Location = new System.Drawing.Point(189, 33);
            this.BTNSEARCHGRID.Name = "BTNSEARCHGRID";
            this.BTNSEARCHGRID.Size = new System.Drawing.Size(68, 26);
            this.BTNSEARCHGRID.TabIndex = 41;
            this.BTNSEARCHGRID.Text = "Search";
            this.BTNSEARCHGRID.UseVisualStyleBackColor = true;
            this.BTNSEARCHGRID.Click += new System.EventHandler(this.gridpencarian);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(9, 33);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(174, 26);
            this.txtSearch.TabIndex = 39;
            // 
            // rdoToday
            // 
            this.rdoToday.AutoSize = true;
            this.rdoToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoToday.Location = new System.Drawing.Point(189, 19);
            this.rdoToday.Name = "rdoToday";
            this.rdoToday.Size = new System.Drawing.Size(65, 17);
            this.rdoToday.TabIndex = 2;
            this.rdoToday.TabStop = true;
            this.rdoToday.Text = "Hari ini";
            this.rdoToday.UseVisualStyleBackColor = true;
            this.rdoToday.CheckedChanged += new System.EventHandler(this.cekperubahanhariini);
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(61, 66);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(122, 20);
            this.dtpTo.TabIndex = 0;
            // 
            // rdoProduct
            // 
            this.rdoProduct.AutoSize = true;
            this.rdoProduct.BackColor = System.Drawing.Color.Transparent;
            this.rdoProduct.Checked = true;
            this.rdoProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoProduct.Location = new System.Drawing.Point(9, 95);
            this.rdoProduct.Name = "rdoProduct";
            this.rdoProduct.Size = new System.Drawing.Size(63, 17);
            this.rdoProduct.TabIndex = 14;
            this.rdoProduct.TabStop = true;
            this.rdoProduct.Text = "Semua";
            this.rdoProduct.UseVisualStyleBackColor = false;
            this.rdoProduct.CheckedChanged += new System.EventHandler(this.cekproduk);
            // 
            // rdoStockIn
            // 
            this.rdoStockIn.AutoSize = true;
            this.rdoStockIn.BackColor = System.Drawing.Color.Transparent;
            this.rdoStockIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoStockIn.Location = new System.Drawing.Point(72, 95);
            this.rdoStockIn.Name = "rdoStockIn";
            this.rdoStockIn.Size = new System.Drawing.Size(74, 17);
            this.rdoStockIn.TabIndex = 0;
            this.rdoStockIn.TabStop = true;
            this.rdoStockIn.Text = "Tersedia";
            this.rdoStockIn.UseVisualStyleBackColor = false;
            this.rdoStockIn.CheckedChanged += new System.EventHandler(this.cekprodukmasuk);
            // 
            // rdoStockOut
            // 
            this.rdoStockOut.AutoSize = true;
            this.rdoStockOut.BackColor = System.Drawing.Color.Transparent;
            this.rdoStockOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoStockOut.Location = new System.Drawing.Point(149, 95);
            this.rdoStockOut.Name = "rdoStockOut";
            this.rdoStockOut.Size = new System.Drawing.Size(64, 17);
            this.rdoStockOut.TabIndex = 0;
            this.rdoStockOut.TabStop = true;
            this.rdoStockOut.Text = "Terjual";
            this.rdoStockOut.UseVisualStyleBackColor = false;
            this.rdoStockOut.CheckedChanged += new System.EventHandler(this.cekprodukterjual);
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox2.Controls.Add(this.btnSearch);
            this.GroupBox2.Controls.Add(this.rdoWeekly);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Controls.Add(this.rdoMonthly);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Controls.Add(this.dtpFrom);
            this.GroupBox2.Controls.Add(this.rdoToday);
            this.GroupBox2.Controls.Add(this.dtpTo);
            this.GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(473, 12);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(333, 107);
            this.GroupBox2.TabIndex = 25;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Filter bedasarkan waktu";
            // 
            // BMlaporanproduk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Betamart.Properties.Resources.BGAll;
            this.ClientSize = new System.Drawing.Size(818, 562);
            this.ControlBox = false;
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.rdoStockOut);
            this.Controls.Add(this.rdoStockIn);
            this.Controls.Add(this.rdoProduct);
            this.Controls.Add(this.cboCateg);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.BTNSEARCHGRID);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BMlaporanproduk";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan";
            this.Load += new System.EventHandler(this.ceklaporan);
            this.Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtglist)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.ComboBox cboCateg;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.DataGridView dtglist;
        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.RadioButton rdoWeekly;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.RadioButton rdoMonthly;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.DateTimePicker dtpFrom;
        internal System.Windows.Forms.Button BTNSEARCHGRID;
        internal System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.RadioButton rdoToday;
        internal System.Windows.Forms.DateTimePicker dtpTo;
        internal System.Windows.Forms.RadioButton rdoProduct;
        internal System.Windows.Forms.RadioButton rdoStockIn;
        internal System.Windows.Forms.RadioButton rdoStockOut;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label LBLLIST;
    }
}