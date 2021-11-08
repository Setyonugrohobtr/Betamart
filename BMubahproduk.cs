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
    public partial class BMubahproduk : Form
    {
        konfigurasi config = new konfigurasi();
        helper func = new helper();
        string sql;
        int maxrow;
        BMdaftarproduk frm;

        public BMubahproduk(string id,BMdaftarproduk frm)
        {
            InitializeComponent();

            ambildata(id);
            this.frm = frm;
        }

        private void ambildata(string id)
        {

            sql = "SELECT PROCODE,PRONAME,PRODESC,CATEGORY, PROPRICE FROM tblProductInfo  WHERE PROCODE='" + id + "'";
            maxrow = config.maxrow(sql);

            if(maxrow > 0)
            {
                foreach(DataRow r in config.dt.Rows)
                {
                    txtPROCODE.Text = r.Field<string>(0);
                    TXTPRONAME.Text = r.Field<string>(1);
                    TXTDESC.Text = r.Field<string>(2);
                    cboCateg.Text = r.Field<string>(3);
                    TXTPRICE.Text = r.Field<decimal>(4).ToString();
                }

            }
             
        }
        private void ProsesEdit(object sender, EventArgs e)
        {

        }

        private void simpanperubahan(object sender, EventArgs e)
        { 
            sql = "UPDATE  tblProductInfo  SET PRONAME='" + TXTPRONAME.Text +
                        "' ,PRODESC='" + TXTDESC.Text +
                        "',CATEGORY='" + cboCateg.Text +
                        "',PROPRICE=" + TXTPRICE.Text + "  WHERE PROCODE='" + txtPROCODE.Text + "'";
            config.Execute_CUD(sql, "Terjadi kesalahan saat memperbarui produk.", "Produk telah diperbarui.");
        }

        private void tampilkandaftar(object sender, EventArgs e)
        {
            frm.segarkanfungsi();
            this.Close();
        }

        private void catatan(object sender, EventArgs e)
        {

        }

        private void tulisanharga(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
