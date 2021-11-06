using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL
{
    public partial class frmPLQuant : Form
    {
        public frmPLQuant()
        {
            InitializeComponent();
        }

        public static SqlConnection con = new SqlConnection(DBConnection.con);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader reader;
        public static SqlDataAdapter adapter;
        public static DataTable dt = new DataTable();
        frmProductLookup productLookup = new frmProductLookup();
        public static DialogResult result;
        public static string QueryInsert;
        public static string QuerySelect;
        public static string QueryUpdate;
        public string temp_code;
        public string product_Code { get; set; }
        public string product_Desc { get; set; }
        public string product_Variety { get; set; }
        public string product_Price { get; set; }

        public int Product_Quantity { get; set; }
        public string Product_Stock { get; set; }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                Product_Quantity = Convert.ToInt32(txtQty.Text);
                this.Close();
            }


            //{
            //    try
            //    {
            //        if (txtQty.Text == "")
            //        {
            //            MessageBox.Show("Please Search Product First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            txtQty.Focus();
            //        }
            //        else if (System.Text.RegularExpressions.Regex.IsMatch(txtQty.Text, "[^0-9]"))
            //        {
            //            txtQty.Text = "1";
            //            MessageBox.Show("Invalid Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        }
            //        else
            //        {

            //            DataRow[] rows = dt.Select(string.Format("[product code]='{0}'", txtProductCode.Text));
            //            DataRow item;
                        
            //            int qty = Convert.ToInt32(txtQuantity.Text);
            //            double price = Convert.ToDouble(txtProdPrice.Text);
            //            double instock = Convert.ToInt32(txtStock.Text);
            //            int result = 0;
            //            double remainingqty = 0;

            //            if (rows.Count() > 0)
            //            {
            //                item = rows[0];
            //                int orderqty = Convert.ToInt32(item["quantity"]);
            //                result = orderqty + qty;
            //            }

            //            if (result > instock)
            //            {
            //                MessageBox.Show("You reached the limit of quantity of this product, Try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //                txtQuantityCount.Text = "";
            //                txtAmount.Text = "";
            //            }
            //            else if (qty > instock)
            //            {
            //                MessageBox.Show("You reached the limit of quantity of this product, Try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //                txtQuantityCount.Text = "";
            //                txtAmount.Text = "";
            //            }
            //            else
            //            {
            //                if (rows.Count() > 0)
            //                {
            //                    item = rows[0];
            //                    int eqty = Convert.ToInt32(item["quantity"]);
            //                    double remaining = Convert.ToInt32(item["remaining quantity"]);
            //                    eqty = eqty + qty;
            //                    remaining = instock - eqty;
            //                    item["quantity"] = eqty;
            //                    item["subtotal"] = eqty * price;
            //                    item["remaining quantity"] = remaining;
            //                    dt.AcceptChanges();
            //                }
            //                else
            //                {
            //                    if (txtProdDesc.Text.Length > 13)
            //                    {
            //                        item = dt.NewRow();
            //                        item["product code"] = txtProductCode.Text;
            //                        item["product description"] = txtProdDesc.Text.Substring(0, 13);
            //                        item["product variety"] = txtProdVariety.Text;
            //                        item["quantity"] = txtQuantity.Text;
            //                        item["price"] = price.ToString("#,0.00");
            //                        item["subtotal"] = qty * price;
            //                        item["remaining quantity"] = instock - qty;
            //                        dt.Rows.Add(item);
            //                    }
            //                    else
            //                    {
            //                        item = dt.NewRow();
            //                        item["product code"] = txtProductCode.Text;
            //                        item["product description"] = txtProdDesc.Text;
            //                        item["product variety"] = txtProdVariety.Text;
            //                        item["quantity"] = txtQuantity.Text;
            //                        item["price"] = price.ToString("#,0.00");
            //                        item["subtotal"] = qty * price;
            //                        item["remaining quantity"] = instock - qty;
            //                        dt.Rows.Add(item);
            //                    }
            //                }

            //                double totalamount = 0;
            //                totalamount = Convert.ToDouble(dt.Compute("sum([subtotal])", ""));
            //                lblTotal.Text = "P " + totalamount.ToString("#,0.00");
            //                txtAmount.Text = totalamount.ToString("0.00");
            //            }

            //            txtSearch.Focus();
            //            txtProductCode.Text = "";
            //            txtProdDesc.Text = "";
            //            txtProdVariety.Text = "";
            //            txtQuantity.Text = "1";
            //            txtStock.Text = "0";
            //            txtProdPrice.Text = "";

            //            txtQuantityCount.Text = dvgOrderList.Rows.Count.ToString();
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
        }
    }
}
