using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL
{
    public partial class frmSalesManagement : Form
    {

        public static SqlConnection con = new SqlConnection(DBConnection.con);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader reader;
        public static SqlDataAdapter adapter;
        public static DataTable dt = new DataTable();
        public static DialogResult result;
        public static string QueryInsert;
        public static string QuerySelect;
        public static string QueryUpdate;
        public static string QueryDelete;

        public frmSalesManagement()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Logout from the System?", "Log-out", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                frmLogin login = new frmLogin();
                this.Close();
                login.Show();
            }
            else if (dialog == DialogResult.No)
            {

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Exit the Application?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {

            }
        }

        private void pbLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Logout from the System?", "Log-out", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                frmLogin login = new frmLogin();
                this.Close();
                login.Show();
            }
            else if (dialog == DialogResult.No)
            {

            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Exit the Application?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            lblTime.Text = time.ToString("h:mm:ss tt");

            DateTime date = DateTime.Now;
            lblDayDate.Text = string.Format("{0:D}", date);
        }

        private void frmSalesManagement_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            lblUserName.Text = frmLogin.GetUserName.ToString();
            lblUserRole.Text = frmLogin.GetUserRole.ToString();
        }

        private void pbPay_Click(object sender, EventArgs e)
        {
            frmPayment payment = new frmPayment();
            payment.Show();
        }

        private void dvgOrderList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row;
                row = dvgOrderList.Rows[e.RowIndex];

                txtProductCode.Text = row.Cells["Product Code"].Value.ToString();
                txtProdDesc.Text = row.Cells["Product Description"].Value.ToString();
                txtProdVariety.Text = row.Cells["Product Variety"].Value.ToString();
                txtProdPrice.Text = row.Cells["Price"].Value.ToString();
            }

            try
            {
                con.Open();
                QuerySelect = "SELECT Quantity FROM tblInventory WHERE ProductCode='" + txtProductCode.Text + "'";
                cmd = new SqlCommand(QuerySelect, con);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    txtStock.Text = reader["Quantity"].ToString();
                    reader.Close();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dvgOrderList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int qty = Convert.ToInt32(dvgOrderList[e.ColumnIndex, e.RowIndex].Value.ToString());
            double instock = Convert.ToInt32(txtStock.Text);

            if (qty > instock)
            {

                MessageBox.Show("You reached the limit of quantity of this product, Try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dvgOrderList[e.ColumnIndex, e.RowIndex].Value = 1;

                if (e.RowIndex > -1)
                {
                    DataGridViewRow row = dvgOrderList.Rows[e.RowIndex];
                    int quantity = int.Parse(row.Cells[4].Value.ToString());
                    double price = double.Parse(row.Cells[5].Value.ToString());
                    double result;
                    row.Cells[4].Value = quantity * price;
                    row.Cells[5].Value = instock;
                }

                int totalamount = 0;
                for (int i = 0; i < dvgOrderList.Rows.Count; ++i)
                {
                    totalamount += Convert.ToInt32(dvgOrderList.Rows[i].Cells[4].Value);
                }

                lblTotal.Text = "P" + totalamount.ToString("#,0.00");
                txtAmount.Text = totalamount.ToString("0.00");
            }
            else
            {
                if (e.RowIndex > -1)
                {
                    DataGridViewRow row = dvgOrderList.Rows[e.RowIndex];
                    int quantity = int.Parse(row.Cells[2].Value.ToString());
                    double price = double.Parse(row.Cells[3].Value.ToString());
                    double result;
                    row.Cells[4].Value = quantity * price;
                    row.Cells[5].Value = instock - qty;
                }

                int totalamount = 0;
                for (int i = 0; i < dvgOrderList.Rows.Count; ++i)
                {
                    totalamount += Convert.ToInt32(dvgOrderList.Rows[i].Cells[4].Value);
                }

                lblTotal.Text = "P" + totalamount.ToString("#,0.00");
                txtAmount.Text = totalamount.ToString("0.00");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                if (txtProductCode.Text == "")
                {
                    MessageBox.Show("Please Search Product First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSearch.Focus();
                }
                else if (txtProdDesc.Text == "")
                {
                    MessageBox.Show("Please Seacrh Product First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSearch.Focus();
                }
                else if (txtProdVariety.Text == "")
                {
                    MessageBox.Show("Please Seacrh Product First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSearch.Focus();
                }
                else if (txtQuantity.Text == "")
                {
                    txtQuantity.Text = "1";
                    MessageBox.Show("Invalid Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtProdPrice.Text == "")
                {
                    MessageBox.Show("Please Seacrh Product First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSearch.Focus();
                }
                else if (System.Text.RegularExpressions.Regex.IsMatch(txtQuantity.Text, "[^0-9]"))
                {
                    txtQuantity.Text = "1";
                    MessageBox.Show("Invalid Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    DataRow[] rows = dt.Select(string.Format("[item code]='{0}'", txtDisplayItemCode.Text));
                    DataRow item;

                    int qty = Convert.ToInt32(txtDisplayQuantity.Text);
                    double price = Convert.ToDouble(txtDisplayPrice.Text);
                    double instock = Convert.ToInt32(lblInStocks.Text);
                    int result = 0;
                    double remainingqty = 0;

                    if (rows.Count() > 0)
                    {
                        item = rows[0];
                        int orderqty = Convert.ToInt32(item["quantity"]);
                        result = orderqty + qty;
                    }

                    if (result > instock)
                    {
                        MessageBox.Show("You reached the limit of quantity of this product, Try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtAmountPay.Text = "";
                        txtChanged.Text = "";
                    }
                    else if (qty > instock)
                    {
                        MessageBox.Show("You reached the limit of quantity of this product, Try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtAmountPay.Text = "";
                        txtChanged.Text = "";
                    }
                    else
                    {
                        if (rows.Count() > 0)
                        {
                            item = rows[0];
                            int eqty = Convert.ToInt32(item["quantity"]);
                            double remaining = Convert.ToInt32(item["remaining quantity"]);
                            eqty = eqty + qty;
                            remaining = instock - eqty;
                            item["quantity"] = eqty;
                            item["sub total"] = eqty * price;
                            item["remaining quantity"] = remaining;
                            dt.AcceptChanges();
                        }
                        else
                        {
                            if (txtDisplayItemDescription.Text.Length > 13)
                            {
                                item = dt.NewRow();
                                item["item code"] = txtDisplayItemCode.Text;
                                item["item description"] = txtDisplayItemDescription.Text.Substring(0, 13);
                                item["quantity"] = txtDisplayQuantity.Text;
                                item["price"] = price.ToString("#,0.00");
                                item["sub total"] = qty * price;
                                item["remaining quantity"] = instock - qty;
                                dt.Rows.Add(item);
                            }
                            else
                            {
                                item = dt.NewRow();
                                item["item code"] = txtDisplayItemCode.Text;
                                item["item description"] = txtDisplayItemDescription.Text;
                                item["quantity"] = txtDisplayQuantity.Text;
                                item["price"] = price.ToString("#,0.00");
                                item["sub total"] = qty * price;
                                item["remaining quantity"] = instock - qty;
                                dt.Rows.Add(item);
                            }
                        }

                        double totalamount = 0;
                        totalamount = Convert.ToDouble(dt.Compute("sum([sub total])", ""));
                        lblTotalAmount.Text = "P" + totalamount.ToString("#,0.00");
                        lblOverAllPayment.Text = totalamount.ToString("0.00");
                    }

                    txtSearchProduct.Focus();
                    txtDisplayItemCode.Text = "";
                    txtDisplayItemDescription.Text = "";
                    txtDisplayQuantity.Text = "1";
                    lblInStocks.Text = "0";
                    txtDisplayPrice.Text = "";

                    lblCountItems.Text = listOfOrders.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }
    }
}
