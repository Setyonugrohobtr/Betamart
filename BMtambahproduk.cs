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
    public partial class BMtambahproduk : Form
    {
        public BMtambahproduk()
        {
            InitializeComponent();
        }
        konfigurasi config = new konfigurasi();
        helper func = new helper();
        string sql;
        int maxrow;

        private void Button1_Click(object sender, EventArgs e)
        {
            func.clearTxt(this);
            cboCateg.Text = "Pilih";
            config.autonumber(2, txtPROCODE);
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            Button1_Click(sender, e);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNSAVE_Click(object sender, EventArgs e)
        {


            if (TXTPRONAME.Text == "" || TXTDESC.Text == "" || cboCateg.Text == "Pilih" || TXTPRICE.Text == "")
            {
                func.messagerequired();
            }


            sql = "SELECT * FROM tblProductInfo WHERE PROCODE='" + txtPROCODE.Text + "'";
            maxrow = config.maxrow(sql);

            if (maxrow > 0)
            {
                sql = "UPDATE  tblProductInfo  SET PRONAME='" + TXTPRONAME.Text +
                    "' ,PRODESC='" + TXTDESC.Text +
                    "',CATEGORY='" + cboCateg.Text +
                    "',PROPRICE=" + TXTPRICE.Text + "  WHERE PROCODE='" + txtPROCODE.Text + "'";
                config.Execute_CUD(sql, "Gagal saat memperbarui data produk.", "Produk telah diperbarui.");
            }
            else
            {
                sql = "INSERT INTO tblProductInfo (PROCODE,PRONAME,PRODESC,CATEGORY,PROPRICE,PROQTY)"
                      + " VALUES ( '" + txtPROCODE.Text + "', '" + TXTPRONAME.Text + "','" + TXTDESC.Text + "','" + cboCateg.Text + "','" + TXTPRICE.Text + "',0)";
                config.Execute_CUD(sql, "Gagal saat menambahkan produk.", "Produk telah tersimpan.");

                config.update_Autonumber(2);
            }

            Button1_Click(sender, e);
          
        }
    }
}
