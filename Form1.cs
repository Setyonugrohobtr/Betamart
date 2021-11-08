using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Betamart.Properties;

namespace Betamart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void tampilkan( Form frm)
        { 
            frm.ShowDialog();
        }

        public void sesudahlogin()
        {
            tsBread.Enabled = true;
            tsListofProducts.Enabled = true;
            Keamanan.Text = "Keluar";
            tsReport.Enabled = true;
            tsStockin.Enabled = true;
            tsStockout.Enabled = true;
            tsUser.Enabled = true;

        }

        private void sebelumlogin()
        {
            tsBread.Enabled = false;
            tsListofProducts.Enabled = false;
            Keamanan.Text = "Masuk";
      
            tsReport.Enabled = false;
            tsStockin.Enabled = false;
            tsStockout.Enabled = false;
            tsUser.Enabled = false;

        }
        private void pergantian(object sender, EventArgs e)
        {
            sebelumlogin();
        }

        private void tambahproduk(object sender, EventArgs e)
        {
            tampilkan(new BMtambahproduk());
        }

        private void daftarproduk(object sender, EventArgs e)
        {
            tampilkan(new BMdaftarproduk());
        }

        private void tambahstok(object sender, EventArgs e)
        {
            tampilkan(new BMmasukgudangtoko());
        }

        private void terbeli(object sender, EventArgs e)
        {
            tampilkan(new BMmasukdataterjual());
        }

        private void akun(object sender, EventArgs e)
        {
            tampilkan(new BMManjemenakun());
        }

        private void laporan(object sender, EventArgs e)
        {
            tampilkan(new BMlaporanproduk());
        }

        private void ModulMasuk(object sender, EventArgs e)
        {
            if(Keamanan.Text == "Masuk")
            {
                tampilkan(new BMpanelmasuk(this));
            }
            else
            {
                sebelumlogin();
            }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TutupJendelaForm1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
