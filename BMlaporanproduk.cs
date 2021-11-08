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
    public partial class BMlaporanproduk : Form
    {
        public BMlaporanproduk()
        {
            InitializeComponent();
        }
        konfigurasi config = new konfigurasi();
        helper func = new helper();
        string query;
        int maxrow;

        private void ceklist(RadioButton RDO)
        {
            if (RDO.Checked)
            {
                switch (RDO.Text)
                {
                     case "Semua" :
                        query = "SELECT P.PROCODE AS [Kode produk], (PRONAME + ' ' + PRODESC) AS [Product],CATEGORY AS [Kategori], PROPRICE   AS [Harga],PROQTY  AS [Jumlah Stok] " +
                                " FROM  tblProductInfo AS P WHERE   CATEGORY ='" + cboCateg.Text + "' AND PRONAME LIKE '%" + txtSearch.Text + "%'";

                        break;
                    case "Tersedia":
                        query = "SELECT P.PROCODE AS [Kode produk],DATEVALUE(DATERECEIVED) AS [Waktu data masuk], (PRONAME + ' ' + PRODESC) AS [Produk], PROPRICE AS [Harga],RECEIVEDQTY   AS [Jumlah Stok],(ROUND(RECEIVEDQTY * PROPRICE)) AS [Total Harga] " +
                                " FROM tblStockIn AS S,  tblProductInfo AS P WHERE S.PROCODE=P.PROCODE AND CATEGORY ='" + cboCateg.Text + "' AND PRONAME LIKE '%" + txtSearch.Text + "%'";

                        break;
                    case "Terjual" :
                        query = "SELECT P.PROCODE AS [Kode produk],DATEVALUE(DATEOUT) AS [Waktu data masuk], (PRONAME + ' ' + PRODESC) AS [Produk], PROPRICE  AS [Harga],OUTQTY  AS [Jumlah stok],(ROUND(OUTQTY * PROPRICE)) AS [Total harga] " +
                               " FROM tblStockOut AS S,  tblProductInfo AS P WHERE S.PROCODE=P.PROCODE  AND CATEGORY ='" + cboCateg.Text + "' AND PRONAME LIKE '%" + txtSearch.Text + "%'";
                        break;
                    case "Hari ini":

                        if( RDO.Text == "Tersedia")
                        {
                            query = "SELECT P.PROCODE AS [Kode produk],DATEVALUE(DATERECEIVED) AS [Waktu data masuk], (PRONAME + ' ' + PRODESC) AS [Produk], PROPRICE  AS [Harga],RECEIVEDQTY  AS [Jumlah stok],(ROUND(RECEIVEDQTY * PROPRICE)) AS [Total harga] " +
                           " FROM tblStockIn AS S,  tblProductInfo AS P " +
                           " WHERE S.PROCODE=P.PROCODE AND DATEVALUE(DATERECEIVED) = NOW() AND PRODESC LIKE '%" + txtSearch.Text + "%' AND PRONAME LIKE '%" + txtSearch.Text + "%'";

                        }
                        else if (RDO.Text == "Terjual")
                        {
                            query = "SELECT P.PROCODE AS [Kode produk],DATEVALUE(DATEOUT) AS [Waktu data masuk], (PRONAME + ' ' + PRODESC) AS [Produk],('Net/VolWt:' + PRONETWT )  AS [Deskripsi],PROPRICE as Harga,(OUTQTY + PROUNIT) AS [Jumlah stok],(ROUND(OUTQTY * PROPRICE)) AS [Total harga] " +
                          " FROM tblStockOut AS S,  tblProductInfo AS P  WHERE S.PROCODE=P.PROCODE  AND  DATEVALUE(DATERECEIVED) = NOW()  AND CATEGORY ='" + cboCateg.Text + "' AND PRONAME LIKE '%" + txtSearch.Text + "%'";

                        } 
                        break;
                    case "Weekly":
                        if (RDO.Text == "Stock-In") {
                            query = "SELECT P.PROCODE AS [ProductCode],DATEVALUE(DATERECEIVED) AS [Waktu data masuk], (PRONAME + ' ' + PRODESC) AS [Product],PROPRICE  AS [Price],RECEIVEDQTY  AS [Quantity],(ROUND(RECEIVEDQTY * PROPRICE)) AS [TotalPrice] " +
                              " FROM tblStockIn AS S,  tblProductInfo AS P " +
                              " WHERE S.PROCODE=P.PROCODE AND MONTH(DATERECEIVED) = MONTH(NOW()) AND DATEVALUE(DATEPART(ww,DATEOUT)) =  DATEVALUE(DATEPART(ww,NOW())) AND PRODESC LIKE '%" + txtSearch.Text + "%' AND PRONAME LIKE '%" + txtSearch.Text + "%'";

                          } else if (RDO.Text == "Terjual") {
                                query = "SELECT P.PROCODE AS [Kode produk],DATEVALUE(DATEOUT) AS [Waktu terjual], (PRONAME + ' ' + PRODESC) AS [Produk],('Net/VolWt:' + PRONETWT ) AS [Deskripsi],PROPRICE as Harga,(OUTQTY + PROUNIT) AS [Jumlah stok],(ROUND(OUTQTY * PROPRICE)) AS [Total harga] " +
                                " FROM tblStockOut AS S,  tblProductInfo AS P " +
                                " WHERE S.PROCODE=P.PROCODE  AND  MONTH(DATERECEIVED) = MONTH(NOW()) AND DATEVALUE(DATEPART(ww,DATEOUT)) =  DATEVALUE(DATEPART(ww,NOW()))  AND CATEGORY ='" + cboCateg.Text + "' AND PRONAME LIKE '%" + txtSearch.Text + "%'";
                          }   
                            break;
                    case "Monthly":
                        if( RDO.Text == "Tersedia")
                        {
                            query = "SELECT P.PROCODE AS [Kode produk],DATEVALUE(DATERECEIVED) AS [Waktu data masuk], (PRONAME + ' ' + PRODESC) AS [Produk],PROPRICE AS [Harga],RECEIVEDQTY  AS [Jumlah stok],(ROUND(RECEIVEDQTY * PROPRICE)) AS [Total harga] " +
                            " FROM tblStockIn AS S,  tblProductInfo AS P " +
                            " WHERE S.PROCODE=P.PROCODE AND MONTH(DATERECEIVED) = MONTH(NOW()) AND PRODESC LIKE '%" + txtSearch.Text + "%' AND PRONAME LIKE '%" + txtSearch.Text + "%'";

                        }
                        else if (RDO.Text == "Terjual")
                        {
                            query = "SELECT P.PROCODE AS [Kode produk],DATEVALUE(DATEOUT) AS [Waktu terjual], (PRONAME + ' ' + PRODESC) AS [Produk],('Net/VolWt:' + PRONETWT) AS [Deskripsi],PROPRICE as [Harga],(OUTQTY + PROUNIT) AS [Jumlah stok],(ROUND(OUTQTY * PROPRICE)) AS [Total harga] " +
                         " FROM tblStockOut AS S,  tblProductInfo AS P  " +
                         " WHERE S.PROCODE=P.PROCODE  AND MONTH(DATERECEIVED) = MONTH(NOW())  AND CATEGORY ='" + cboCateg.Text + "' AND PRONAME LIKE '%" + txtSearch.Text + "%'";

                        }
                        break;
            
                }

                config.Load_DTG(query, dtglist);
            } 
        }

        private void ceklistkondisi(string ACTIONS,RadioButton rdo)
        {
            if (rdo.Checked)
            {
                switch (ACTIONS)
                {
                    case "Produk":
                        rdoProduct.Checked = false;
                        break;
                    case "Transaksi":
                        rdoStockIn.Checked = false;
                    rdoStockOut.Checked = false;
                        rdoMonthly.Checked = false;
                        rdoWeekly.Checked = false;
                        rdoToday.Checked = false;
                        break;
                }

                if( rdo.Text != "Hari ini" && rdo.Text != "21 hari" && rdo.Text != "Mingguan" && rdo.Text != "Bulanan")
                {
                    LBLLIST.Text = "Daftar " + rdo.Text + " (" + cboCateg.Text + ")";
                }
                

            }
        }
        private void ceklistdate()
        {
            rdoMonthly.Checked = false;
            rdoWeekly.Checked = false;
            rdoToday.Checked = false;
        }
     


        private void ceklaporan(object sender, EventArgs e)
        {
            ceklistkondisi("Transaksi", rdoProduct);
            LBLLIST.Text = "Daftar Produk (" + cboCateg.Text + ")";

            ceklist(rdoProduct);
        }

        private void cekproduk(object sender, EventArgs e)
        {
            ceklistkondisi("Transaksi", rdoProduct);

            LBLLIST.Text = "Daftar Produk (" + cboCateg.Text + ")";

            ceklist(rdoProduct);
        }

        private void cekprodukmasuk(object sender, EventArgs e)
        {
            ceklistkondisi("Produk", rdoStockIn);
            ceklistdate();
            ceklist(rdoStockIn);
        }

        private void cekprodukterjual(object sender, EventArgs e)
        {
            ceklistkondisi("Produk", rdoStockOut);
            ceklistdate();
            ceklist(rdoStockOut);
        }

        private void cekperubahanhariini(object sender, EventArgs e)
        {
 
            if(rdoStockIn.Checked)
            {
                ceklistkondisi("Produk", rdoStockIn);
                query = "SELECT P.PROCODE AS [Kode produk],DATEVALUE(DATERECEIVED) AS [Waktu data masuk], (PRONAME + ' ' + PRODESC) AS [Produk],PROPRICE AS [Harga],RECEIVEDQTY  AS [Jumlah stok],(ROUND(RECEIVEDQTY * PROPRICE)) AS  [Total harga] " +
                      " FROM tblStockIn AS S,  tblProductInfo AS P " +
                      " WHERE S.PROCODE=P.PROCODE AND DATEVALUE(DATERECEIVED) = DATEVALUE(NOW())  AND PRODESC LIKE '%" + txtSearch.Text + "%' AND PRONAME LIKE '%" + txtSearch.Text + "%'";
                config.Load_DTG(query, dtglist);
            }
            else if (rdoStockOut.Checked)
            {
                ceklistkondisi("Produk", rdoStockOut);
                query = "SELECT P.PROCODE AS [Kode produk],DATEVALUE(DATEOUT) AS [Waktu data masuk], (PRONAME + ' ' + PRODESC) AS [Produk],PROPRICE  AS [Harga],OUTQTY AS [Jumlah stok],(ROUND(OUTQTY * PROPRICE)) AS [Total harga] " +
                " FROM tblStockOut AS S,  tblProductInfo AS P  WHERE S.PROCODE=P.PROCODE  AND  DATEVALUE(DATEOUT) =DATEVALUE(NOW())  AND CATEGORY ='" + cboCateg.Text + "' AND PRONAME LIKE '%" + txtSearch.Text + "%'";
                config.Load_DTG(query, dtglist);
            } 

          
       
        }

        private void cekperubahanmingguan(object sender, EventArgs e)
        {
 

            if (rdoStockIn.Checked)
            {
                ceklistkondisi("Produk", rdoStockIn);
                query = "SELECT P.PROCODE AS [Kode produk],DATEVALUE(DATERECEIVED) AS [Waktu data masuk], (PRONAME + ' ' + PRODESC) AS [Product],PROPRICE AS [Price],RECEIVEDQTY  AS [Jumlah stok],(ROUND(RECEIVEDQTY * PROPRICE)) AS [Total harga] " +
                " FROM tblStockIn AS S,  tblProductInfo AS P " +
                " WHERE S.PROCODE=P.PROCODE AND MONTH(DATERECEIVED) = MONTH(NOW()) AND PRODESC LIKE '%" + txtSearch.Text + "%' AND PRONAME LIKE '%" + txtSearch.Text + "%'";
                config.Load_DTG(query, dtglist);
            }
            else if (rdoStockOut.Checked)
            {
                ceklistkondisi("Produk", rdoStockOut);
                query = "SELECT P.PROCODE AS [Kode produk],DATEVALUE(DATEOUT) AS [Waktu data masuk], (PRONAME + ' ' + PRODESC) AS [Produk],PROPRICE AS [Harga],OUTQTY AS [Jumlah stok],(ROUND(OUTQTY * PROPRICE)) AS [Total harga] " +
               " FROM tblStockOut AS S,  tblProductInfo AS P " +
               " WHERE S.PROCODE=P.PROCODE  AND  MONTH(DATEOUT) = MONTH(NOW()) AND DatePart('ww',DATEVALUE(DATEOUT))= DatePart('ww',DATEVALUE(NOW()))  AND CATEGORY ='" + cboCateg.Text + "' AND PRONAME LIKE '%" + txtSearch.Text + "%'";

                config.Load_DTG(query, dtglist);
            }
    
        }

        private void cekperubahanbulanan(object sender, EventArgs e)
        {
 
            if (rdoStockIn.Checked)
            {
                ceklistkondisi("Produk", rdoStockIn);
                query = "SELECT P.PROCODE AS [Kode produk],DATEVALUE(DATERECEIVED) AS [Waktu data masuk], (PRONAME + ' ' + PRODESC) AS [Product],PROPRICE  AS [harga],RECEIVEDQTY  AS [Jumlah stok],(ROUND(RECEIVEDQTY * PROPRICE)) AS [Total harga] " +
                " FROM tblStockIn AS S,  tblProductInfo AS P " +
                " WHERE S.PROCODE=P.PROCODE AND MONTH(DATERECEIVED) = MONTH(NOW()) AND PRODESC LIKE '%" + txtSearch.Text + "%' AND PRONAME LIKE '%" + txtSearch.Text + "%'";
                config.Load_DTG(query, dtglist);
            }
            else if (rdoStockOut.Checked)
            {
                ceklistkondisi("Produk", rdoStockOut);
                query = "SELECT P.PROCODE AS [Kode produk],DATEVALUE(DATEOUT) AS [Waktu data masuk], (PRONAME + ' ' + PRODESC) AS [Product],PROPRICE  AS [Harga],OUTQTY AS [Jumlah stok],(ROUND(OUTQTY * PROPRICE))   AS  [Total harga] " +
             " FROM tblStockOut AS S,  tblProductInfo AS P  " +
             " WHERE S.PROCODE=P.PROCODE  AND MONTH(DATEOUT) = MONTH(NOW())  AND CATEGORY ='" + cboCateg.Text + "' AND PRONAME LIKE '%" + txtSearch.Text + "%'";
                config.Load_DTG(query, dtglist);
            } 
        }

        private void tombolpencarian(object sender, EventArgs e)
        {
            if( rdoProduct.Checked)
            {
                rdoStockOut.Checked = true;
            }


            DateTime dfrom = DateTime.Parse(dtpFrom.Text);
            DateTime dto = DateTime.Parse(dtpTo.Text);

            if( rdoStockIn.Checked)
            {
                LBLLIST.Text = "Stok " + cboCateg.Text + " dari " + dfrom + " sampai " + dto;
                query = "SELECT P.PROCODE AS [Kode produk],DATEVALUE(DATERECEIVED) AS [Waktu data masuk], (PRONAME + ' ' + PRODESC) AS [Produk],PROPRICE AS [Harga],RECEIVEDQTY  AS [Jumlah stok],(ROUND(RECEIVEDQTY * PROPRICE)) AS [Total harga] " +
                  " FROM tblStockIn AS S,  tblProductInfo AS P " +
                  " WHERE S.PROCODE=P.PROCODE AND DATEVALUE(DATERECEIVED) BETWEEN #" + dfrom + "# AND #" + dto + "#  AND PRODESC LIKE '%" + txtSearch.Text + "%' AND PRONAME LIKE '%" + txtSearch.Text + "%'";
                config.Load_DTG(query, dtglist);
            }
            else if (rdoStockOut.Checked)
            {
                LBLLIST.Text = "Terjual " + cboCateg.Text + " dari " + dfrom + " sampai " + dto;
                query = "SELECT P.PROCODE AS [Kode Produk],DATEVALUE(DATEOUT) AS [Waktu data terjual], (PRONAME + ' ' + PRODESC) AS [Product],PROPRICE AS [Harga],OUTQTY   AS [Jumlah stok],(ROUND(OUTQTY * PROPRICE)) AS [Total harga] " +
                " FROM tblStockOut AS S,  tblProductInfo AS P  " +
                " WHERE S.PROCODE=P.PROCODE  AND  DATEVALUE(DATEOUT) BETWEEN #" + dfrom + "# AND #" + dto + "#  AND CATEGORY ='" + cboCateg.Text + "' AND PRONAME LIKE '%" + txtSearch.Text + "%'";
                config.Load_DTG(query, dtglist);
            }
             
             
        }

        private void gridpencarian(object sender, EventArgs e)
        {
            ceklistkondisi("Transaksi", rdoProduct);

            LBLLIST.Text = "Daftar produk (" + cboCateg.Text + ")";

            ceklist(rdoProduct);
        }

        private void tutupjendelalaporan(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
