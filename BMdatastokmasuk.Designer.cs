namespace Betamart
{
    partial class BMdatastokmasuk
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
            this.btnNew = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.DTPFROM = new System.Windows.Forms.DateTimePicker();
            this.DTPTO = new System.Windows.Forms.DateTimePicker();
            this.Button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.TXTSEARCH = new System.Windows.Forms.TextBox();
            this.DTGLIST = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DTGLIST)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.Image = global::Betamart.Properties.Resources.tambahbaru;
            this.btnNew.Location = new System.Drawing.Point(541, 516);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(134, 34);
            this.btnNew.TabIndex = 62;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.TutupJendela);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Image = global::Betamart.Properties.Resources.segarkan;
            this.btnRefresh.Location = new System.Drawing.Point(6, 517);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(145, 34);
            this.btnRefresh.TabIndex = 60;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.segarkan);
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.BackColor = System.Drawing.Color.Transparent;
            this.Label17.Location = new System.Drawing.Point(633, 35);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(42, 13);
            this.Label17.TabIndex = 59;
            this.Label17.Text = "Sampai";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.BackColor = System.Drawing.Color.Transparent;
            this.Label16.Location = new System.Drawing.Point(633, 13);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(26, 13);
            this.Label16.TabIndex = 58;
            this.Label16.Text = "Dari";
            // 
            // DTPFROM
            // 
            this.DTPFROM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFROM.Location = new System.Drawing.Point(681, 7);
            this.DTPFROM.Name = "DTPFROM";
            this.DTPFROM.Size = new System.Drawing.Size(132, 20);
            this.DTPFROM.TabIndex = 56;
            // 
            // DTPTO
            // 
            this.DTPTO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPTO.Location = new System.Drawing.Point(681, 33);
            this.DTPTO.Name = "DTPTO";
            this.DTPTO.Size = new System.Drawing.Size(132, 20);
            this.DTPTO.TabIndex = 57;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Transparent;
            this.Button1.Image = global::Betamart.Properties.Resources.tutup;
            this.Button1.Location = new System.Drawing.Point(675, 516);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(145, 34);
            this.Button1.TabIndex = 54;
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.TutupJendela);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Image = global::Betamart.Properties.Resources.HAPUS;
            this.btnDelete.Location = new System.Drawing.Point(157, 516);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 35);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.hapusdata);
            // 
            // TXTSEARCH
            // 
            this.TXTSEARCH.BackColor = System.Drawing.Color.White;
            this.TXTSEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTSEARCH.Location = new System.Drawing.Point(11, 12);
            this.TXTSEARCH.Margin = new System.Windows.Forms.Padding(2);
            this.TXTSEARCH.Name = "TXTSEARCH";
            this.TXTSEARCH.Size = new System.Drawing.Size(392, 26);
            this.TXTSEARCH.TabIndex = 51;
            this.TXTSEARCH.Text = "Cari";
            this.TXTSEARCH.TextChanged += new System.EventHandler(this.pencarian);
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
            this.DTGLIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGLIST.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DTGLIST.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DTGLIST.Location = new System.Drawing.Point(6, 57);
            this.DTGLIST.Margin = new System.Windows.Forms.Padding(2);
            this.DTGLIST.Name = "DTGLIST";
            this.DTGLIST.RowHeadersVisible = false;
            this.DTGLIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTGLIST.Size = new System.Drawing.Size(814, 442);
            this.DTGLIST.TabIndex = 52;
            // 
            // BMdatastokmasuk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Betamart.Properties.Resources.BGAll;
            this.ClientSize = new System.Drawing.Size(825, 558);
            this.ControlBox = false;
            this.Controls.Add(this.DTGLIST);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.Label17);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.DTPFROM);
            this.Controls.Add(this.DTPTO);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.TXTSEARCH);
            this.MinimizeBox = false;
            this.Name = "BMdatastokmasuk";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daftar produk yang masuk";
            this.Load += new System.EventHandler(this.frmListStockin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGLIST)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnNew;
        internal System.Windows.Forms.Button btnRefresh;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.DateTimePicker DTPFROM;
        internal System.Windows.Forms.DateTimePicker DTPTO;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.TextBox TXTSEARCH;
        internal System.Windows.Forms.DataGridView DTGLIST;
    }
}