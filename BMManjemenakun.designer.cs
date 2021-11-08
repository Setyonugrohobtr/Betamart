namespace Betamart
{
    partial class BMManjemenakun
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
            this.dtglist = new System.Windows.Forms.DataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.cbotype = new System.Windows.Forms.ComboBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.LBLUSERID = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtglist)).BeginInit();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtglist
            // 
            this.dtglist.AllowUserToAddRows = false;
            this.dtglist.AllowUserToDeleteRows = false;
            this.dtglist.AllowUserToResizeColumns = false;
            this.dtglist.AllowUserToResizeRows = false;
            this.dtglist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtglist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtglist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtglist.Location = new System.Drawing.Point(0, 30);
            this.dtglist.Name = "dtglist";
            this.dtglist.RowHeadersVisible = false;
            this.dtglist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtglist.Size = new System.Drawing.Size(594, 208);
            this.dtglist.TabIndex = 6;
            this.dtglist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtglist_CellClick);
            // 
            // btndelete
            // 
            this.btndelete.Image = global::Betamart.Properties.Resources.HAPUS;
            this.btndelete.Location = new System.Drawing.Point(18, 518);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(86, 34);
            this.btndelete.TabIndex = 26;
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnclose
            // 
            this.btnclose.Image = global::Betamart.Properties.Resources.tutup;
            this.btnclose.Location = new System.Drawing.Point(143, 518);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(145, 34);
            this.btnclose.TabIndex = 27;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.dtglist);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Location = new System.Drawing.Point(13, 233);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(596, 240);
            this.Panel1.TabIndex = 28;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.White;
            this.Label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(0, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(594, 30);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "List of User";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.Color.White;
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(279, 201);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(329, 26);
            this.txtsearch.TabIndex = 25;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(3, 45);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(99, 17);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "Nama lengkap";
            // 
            // cbotype
            // 
            this.cbotype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotype.FormattingEnabled = true;
            this.cbotype.Items.AddRange(new object[] {
            "Administrator",
            "Staff"});
            this.cbotype.Location = new System.Drawing.Point(116, 134);
            this.cbotype.Name = "cbotype";
            this.cbotype.Size = new System.Drawing.Size(214, 28);
            this.cbotype.TabIndex = 3;
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(116, 102);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(214, 26);
            this.txtpass.TabIndex = 2;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(22, 76);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(80, 17);
            this.Label5.TabIndex = 9;
            this.Label5.Text = "Nama akun";
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(116, 70);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(214, 26);
            this.txtusername.TabIndex = 1;
            // 
            // LBLUSERID
            // 
            this.LBLUSERID.AutoSize = true;
            this.LBLUSERID.Location = new System.Drawing.Point(178, 39);
            this.LBLUSERID.Name = "LBLUSERID";
            this.LBLUSERID.Size = new System.Drawing.Size(48, 13);
            this.LBLUSERID.TabIndex = 12;
            this.LBLUSERID.Text = "USERID";
            this.LBLUSERID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnsave
            // 
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.ForeColor = System.Drawing.Color.Transparent;
            this.btnsave.Image = global::Betamart.Properties.Resources.simpan;
            this.btnsave.Location = new System.Drawing.Point(367, 39);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(91, 38);
            this.btnsave.TabIndex = 22;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnnew
            // 
            this.btnnew.ForeColor = System.Drawing.Color.Transparent;
            this.btnnew.Image = global::Betamart.Properties.Resources.tambahbaru;
            this.btnnew.Location = new System.Drawing.Point(350, 83);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(128, 42);
            this.btnnew.TabIndex = 23;
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(22, 108);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(75, 17);
            this.Label6.TabIndex = 10;
            this.Label6.Text = "Kata sandi";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(116, 38);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(214, 26);
            this.txtname.TabIndex = 0;
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.Black;
            this.Label8.Location = new System.Drawing.Point(0, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(597, 30);
            this.Label8.TabIndex = 6;
            this.Label8.Text = "Menambah/mengubah akun";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(65, 140);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(45, 17);
            this.Label7.TabIndex = 11;
            this.Label7.Text = "Role :";
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.Panel2.Controls.Add(this.Label7);
            this.Panel2.Controls.Add(this.Label8);
            this.Panel2.Controls.Add(this.txtname);
            this.Panel2.Controls.Add(this.Label6);
            this.Panel2.Controls.Add(this.btnnew);
            this.Panel2.Controls.Add(this.btnsave);
            this.Panel2.Controls.Add(this.LBLUSERID);
            this.Panel2.Controls.Add(this.txtusername);
            this.Panel2.Controls.Add(this.Label5);
            this.Panel2.Controls.Add(this.txtpass);
            this.Panel2.Controls.Add(this.cbotype);
            this.Panel2.Controls.Add(this.Label4);
            this.Panel2.Location = new System.Drawing.Point(12, 12);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(597, 181);
            this.Panel2.TabIndex = 29;
            // 
            // BMManjemenakun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Betamart.Properties.Resources.BGAll;
            this.ClientSize = new System.Drawing.Size(621, 559);
            this.ControlBox = false;
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.txtsearch);
            this.Name = "BMManjemenakun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.frmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtglist)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.DataGridView dtglist;
        internal System.Windows.Forms.Button btndelete;
        internal System.Windows.Forms.Button btnclose;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtsearch;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ComboBox cbotype;
        internal System.Windows.Forms.TextBox txtpass;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtusername;
        internal System.Windows.Forms.Label LBLUSERID;
        internal System.Windows.Forms.Button btnsave;
        internal System.Windows.Forms.Button btnnew;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtname;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Panel Panel2;
    }
}