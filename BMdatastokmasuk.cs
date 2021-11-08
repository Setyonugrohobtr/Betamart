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
    public partial class BMdatastokmasuk : Form
    {
        public BMdatastokmasuk()
        {
            InitializeComponent();
        }
        konfigurasi config = new konfigurasi();
        helper func = new helper();
        string sql;
        int maxrow;
        private void TutupJendela(object sender, EventArgs e)
        {
            this.Close();
        }

        private void segarkan(object sender, EventArgs e)
        {
            sql = "SELECT TRANSNUM AS [Transaction#], P.PROCODE as [Kode produk],PRONAME AS [Produk],  PROPRICE  as Harga, (PRODESC + ' [' + CATEGORY + ']') AS [Description],DATERECEIVED AS [Waktu data masuk],RECEIVEDQTY AS [Stok], RECEIVEDTOTPRICE AS [Total harga]  FROM tblStockIn as S, tblProductInfo AS P WHERE S.PROCODE=P.PROCODE";
            config.Load_DTG(sql, DTGLIST);
        }

        private void frmListStockin_Load(object sender, EventArgs e)
        {
            segarkan(sender, e);
        }

        private void hapusdata(object sender, EventArgs e)
        {
            string numtrans = DTGLIST.CurrentRow.Cells[0].Value.ToString(); 
           int transnum = int.Parse(numtrans);
            sql = "UPDATE tblProductInfo AS P, tblStockIn AS S SET PROQTY = PROQTY - RECEIVEDQTY  WHERE P.PROCODE=S.PROCODE AND TRANSNUM =" + transnum ;
            config.Execute_Query(sql);

            sql = "DELETE * FROM tblStockIn WHERE TRANSNUM = " + transnum ; 
            config.Execute_CUD(sql,"Gagal menjalankan perintah.","Histori transaksi telah dihapus.");

            segarkan(sender, e);
        }

        private void pencarian(object sender, EventArgs e)
        { 
                sql = "SELECT TRANSNUM AS [Transaction#], P.PROCODE as [Kode produk], PRONAME  AS [Produk],(PRODESC + ' [' + CATEGORY + ']') AS [Deskripsi],PROPRICE as [Harga],DATERECEIVED AS [TransactionDate],RECEIVEDQTY AS [Jumlah stok], RECEIVEDTOTPRICE AS [Total harga]  FROM tblStockIn as S, tblProductInfo AS P  WHERE S.PROCODE=P.PROCODE AND " +
                      " (P.PROCODE   + ' '  + PRONAME + ' '  + PRODESC + ' '  + CATEGORY  ) LIKE '%" + TXTSEARCH.Text + "%'";
                config.Load_DTG(sql, DTGLIST); 
        }
    }
}
