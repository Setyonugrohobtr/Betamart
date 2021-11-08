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
    public partial class BMdaftarproduk : Form
    {
        public BMdaftarproduk()
        {
            InitializeComponent();
        }
        konfigurasi config = new konfigurasi();
        helper func = new helper();
        string sql;
        int maxrow;
        private void tambahproduk(object sender, EventArgs e)
        {
            Form frm = new BMtambahproduk();
            frm.ShowDialog();
        }

        public void segarkanfungsi()
        {
            sql = "SELECT PROCODE as [Kode Produk], (PRONAME + ' ' + PRODESC) AS [Produk],CATEGORY AS [Kategori], (PROPRICE) AS [Harga],PROQTY AS [Jumlah Stok] FROM  tblProductInfo";
            config.Load_DTG(sql, DTGLIST);
        }

        private void segarkandata(object sender, EventArgs e)
        {
            sql = "SELECT PROCODE as [Kode Produk], (PRONAME + ' ' + PRODESC) AS [Produk],CATEGORY AS [Kategori], (PROPRICE) AS [Harga],PROQTY AS [Jumlah Stok] FROM  tblProductInfo";
            config.Load_DTG(sql, DTGLIST);
        }

        private void Functional(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hapusdata(object sender, EventArgs e)
        {
            sql = "DELETE * FROM tblStockIn WHERE PROCODE = '" + DTGLIST.CurrentRow.Cells[0].Value + "'";
            config.Execute_Query(sql); 

            sql = "DELETE * FROM tblStockOut WHERE PROCODE = '" + DTGLIST.CurrentRow.Cells[0].Value + "'";
            config.Execute_Query(sql);
              
            sql = "DELETE * FROM tblProductInfo WHERE PROCODE = '" + DTGLIST.CurrentRow.Cells[0].Value + "'";
            config.Execute_CUD(sql, "Gagal terhapus", "Produk berhasil dihapus.");
        }

        private void ubah(object sender, EventArgs e)
        {
            Form frm = new BMubahproduk(DTGLIST.CurrentRow.Cells[0].Value.ToString(),this);
            frm.ShowDialog();
        }

        private void ubahproses(object sender, EventArgs e)
        {
            segarkandata(sender, e);
        }

        private void pencarian(object sender, EventArgs e)
        {
             
            DTGLIST.Columns.Clear();
             
            sql = "SELECT PROCODE as [Kode Produk], (PRONAME + ' ' + PRODESC) AS [Produk],CATEGORY AS [Kategori], (PROPRICE) AS [Harga],PROQTY  AS [Jumlah Stock] FROM  tblProductInfo WHERE  (PROCODE + ' ' + PRONAME + ' ' + PRODESC  + ' ' + CATEGORY)  LIKE '%" + TXTSEARCH.Text + "%'";
            config.Load_DTG(sql, DTGLIST);


        }

        private void pencarianteks(object sender, EventArgs e)
        {

        }

        private void Catatan(object sender, EventArgs e)
        {

        }
    }
}
