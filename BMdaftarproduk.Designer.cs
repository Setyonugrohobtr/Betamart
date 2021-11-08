namespace Betamart
{
    partial class BMdaftarproduk
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
            this.DTGLIST = new System.Windows.Forms.DataGridView();
            this.TXTSEARCH = new System.Windows.Forms.TextBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DTGLIST)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DTGLIST
            // 
            this.DTGLIST.AllowUserToAddRows = false;
            this.DTGLIST.AllowUserToDeleteRows = false;
            this.DTGLIST.AllowUserToResizeColumns = false;
            this.DTGLIST.AllowUserToResizeRows = false;
            this.DTGLIST.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DTGLIST.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DTGLIST.BackgroundColor = System.Drawing.Color.DarkRed;
            this.DTGLIST.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DTGLIST.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DTGLIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGLIST.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DTGLIST.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTGLIST.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DTGLIST.Location = new System.Drawing.Point(0, 0);
            this.DTGLIST.Margin = new System.Windows.Forms.Padding(2);
            this.DTGLIST.Name = "DTGLIST";
            this.DTGLIST.RowHeadersVisible = false;
            this.DTGLIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTGLIST.Size = new System.Drawing.Size(861, 410);
            this.DTGLIST.TabIndex = 0;
            // 
            // TXTSEARCH
            // 
            this.TXTSEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTSEARCH.Location = new System.Drawing.Point(510, 11);
            this.TXTSEARCH.Margin = new System.Windows.Forms.Padding(2);
            this.TXTSEARCH.Name = "TXTSEARCH";
            this.TXTSEARCH.Size = new System.Drawing.Size(364, 26);
            this.TXTSEARCH.TabIndex = 0;
            this.TXTSEARCH.TextChanged += new System.EventHandler(this.pencarian);
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.DTGLIST);
            this.Panel1.Location = new System.Drawing.Point(12, 59);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(863, 412);
            this.Panel1.TabIndex = 21;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Image = global::Betamart.Properties.Resources.segarkan;
            this.btnRefresh.Location = new System.Drawing.Point(13, 519);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(145, 35);
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.segarkandata);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Rawhide Raw 2016", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(337, 20);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(168, 12);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Cari (Nama produk)";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Label3.Click += new System.EventHandler(this.pencarianteks);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Transparent;
            this.Button1.Image = global::Betamart.Properties.Resources.tutup;
            this.Button1.Location = new System.Drawing.Point(164, 519);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(145, 35);
            this.Button1.TabIndex = 19;
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Functional);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.Image = global::Betamart.Properties.Resources.tambahbaru;
            this.btnNew.Location = new System.Drawing.Point(732, 519);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(145, 35);
            this.btnNew.TabIndex = 16;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.tambahproduk);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.Image = global::Betamart.Properties.Resources.ubah;
            this.btnEdit.Location = new System.Drawing.Point(548, 519);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 35);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.ubah);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Image = global::Betamart.Properties.Resources.HAPUS;
            this.btnDelete.Location = new System.Drawing.Point(640, 519);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 35);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.hapusdata);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(13, 484);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(353, 16);
            this.Label4.TabIndex = 67;
            this.Label4.Text = "*Setelah melakukan perubahan, segarkan segera.";
            this.Label4.Click += new System.EventHandler(this.Catatan);
            // 
            // BMdaftarproduk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Betamart.Properties.Resources.BGAll;
            this.ClientSize = new System.Drawing.Size(887, 566);
            this.ControlBox = false;
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.TXTSEARCH);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.MinimizeBox = false;
            this.Name = "BMdaftarproduk";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daftar produk";
            this.Load += new System.EventHandler(this.ubahproses);
            ((System.ComponentModel.ISupportInitialize)(this.DTGLIST)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView DTGLIST;
        internal System.Windows.Forms.TextBox TXTSEARCH;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button btnRefresh;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button btnNew;
        internal System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Label Label4;
    }
}