namespace Betamart
{
    partial class BMdatastokterjual
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
            
            this.btnNew.Location = new System.Drawing.Point(700, 519);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(145, 34);
            this.btnNew.TabIndex = 74;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnRefresh
            // 
          
            this.btnRefresh.Location = new System.Drawing.Point(12, 519);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(145, 34);
            this.btnRefresh.TabIndex = 72;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(635, 45);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(20, 13);
            this.Label17.TabIndex = 71;
            this.Label17.Text = "To";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(635, 19);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(30, 13);
            this.Label16.TabIndex = 70;
            this.Label16.Text = "From";
            // 
            // DTPFROM
            // 
            this.DTPFROM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFROM.Location = new System.Drawing.Point(671, 12);
            this.DTPFROM.Name = "DTPFROM";
            this.DTPFROM.Size = new System.Drawing.Size(132, 20);
            this.DTPFROM.TabIndex = 68;
            // 
            // DTPTO
            // 
            this.DTPTO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPTO.Location = new System.Drawing.Point(671, 39);
            this.DTPTO.Name = "DTPTO";
            this.DTPTO.Size = new System.Drawing.Size(132, 20);
            this.DTPTO.TabIndex = 69;
            // 
            // Button1
            // 
      
            this.Button1.Location = new System.Drawing.Point(549, 519);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(145, 34);
            this.Button1.TabIndex = 66;
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnDelete
            // 

            this.btnDelete.Location = new System.Drawing.Point(163, 519);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 34);
            this.btnDelete.TabIndex = 65;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // TXTSEARCH
            // 
            this.TXTSEARCH.BackColor = System.Drawing.Color.White;
            this.TXTSEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTSEARCH.Location = new System.Drawing.Point(12, 33);
            this.TXTSEARCH.Margin = new System.Windows.Forms.Padding(2);
            this.TXTSEARCH.Name = "TXTSEARCH";
            this.TXTSEARCH.Size = new System.Drawing.Size(392, 26);
            this.TXTSEARCH.TabIndex = 63;
            this.TXTSEARCH.Text = "Cari";
            this.TXTSEARCH.TextChanged += new System.EventHandler(this.TXTSEARCH_TextChanged);
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
            this.DTGLIST.Location = new System.Drawing.Point(12, 97);
            this.DTGLIST.Margin = new System.Windows.Forms.Padding(2);
            this.DTGLIST.Name = "DTGLIST";
            this.DTGLIST.RowHeadersVisible = false;
            this.DTGLIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTGLIST.Size = new System.Drawing.Size(834, 397);
            this.DTGLIST.TabIndex = 64;
            // 
            // frmListStockout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        
            this.ClientSize = new System.Drawing.Size(857, 560);
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
            this.Name = "frmListStockout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List of Sold Items";
            this.Load += new System.EventHandler(this.frmListStockout_Load);
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