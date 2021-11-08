using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Betamart
{
    public partial class BMpanelmasuk : Form
    {
        Form1 frm;
        public BMpanelmasuk(Form1 frm)
        {
            InitializeComponent();
            this.frm = frm;
        }
        konfigurasi config = new konfigurasi();
        helper func = new helper();
        string query;
        int maxrow;

        private void pergantianuntuklogin(object sender, EventArgs e)
        {

        }

        private void AuthMasuk(object sender, EventArgs e)
        {
            query = "SELECT * FROM tblUser WHERE U_UNAME ='" + UsernameTextBox.Text + "' AND U_PASS = '" + PasswordTextBox.Text + "'";
            maxrow = config.maxrow(query);

            if(maxrow > 0)
            {
                MessageBox.Show("Berhasil masuk ke akun, tutup saja jendela ini.");
                frm.sesudahlogin();
                this.Close();
            }
            else
            {
                MessageBox.Show("Pastikan mengisi nama akun dan kata sandi dengan benar!","Pengingat",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);               
            }
        }

        private void TutupJendelaMasuk(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NamaAkun(object sender, EventArgs e)
        {

        }
    }
}
