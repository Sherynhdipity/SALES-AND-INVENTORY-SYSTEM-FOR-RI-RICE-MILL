using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
        public static string adminPass;



        public frmSalesManagement()
        {
            InitializeComponent();
        }
        

        //Generate TransNo
        void GetTransNo()
        {
            try
            {
                string sdate = DateTime.Now.ToString("yyyyMMdd");
                string transNo;
                int count;

                con.Open();
                cmd = new SqlCommand("SELECT TOP 1 TransactionNo FROM tblTransactions WHERE TransactionNo LIKE '%" + sdate + "'", con);
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    transNo = reader[0].ToString();
                    count = int.Parse(transNo.Substring(8, 4));
                    lblTransNo.Text = sdate + (count + 1);
                }
                else
                {
                    transNo = sdate + "0001";
                    lblTransNo.Text = transNo;
                    lblTransDate.Text = DateTime.Now.ToString("MMMMddyyyy");
                }

                reader.Close();
                con.Close();
            }

            catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Load Columns DataGrid(Table)
        public void ColumnsLoader()
        {
            dt.Rows.Clear();
            dt.Columns.Add("Product Code", typeof(string)).ReadOnly = true;
            dt.Columns.Add("Product Description", typeof(string)).ReadOnly = true;
            dt.Columns.Add("Product Variety", typeof(string)).ReadOnly = true;
            dt.Columns.Add("Quantity", typeof(int));
            dt.Columns.Add("Price", typeof(float)).ReadOnly = true;
            dt.Columns.Add("SubTotal", typeof(float));
            dt.Columns.Add("Remaining Quantity", typeof(int));
            dvgOrderList.DataSource = dt;
        }

        public void ClearAll()
        {

            //textbox controls
            txtSearch.Text = "";
            txtProductCode.Text = "";
            txtProdDesc.Text = "";
            txtProdVariety.Text = "";
            txtQuantity.Text = "1";
            txtProdPrice.Text = "";
            txtStock.Text = "0";
            txtAmount.Text = "";
            txtQuantityCount.Text = "";

            //label controls
            lblTransNo.Text = "0000000000";
            lblTotal.Text = "P0.00";
            lblTransDate.Text = "Month, Day, Year";
            dt.Clear();
        }


        //Remove Product from List
        void VoidProduct()
        {

            if (String.IsNullOrEmpty(adminPass))
            {
                frmvoidauth voidauth = new frmvoidauth();
                voidauth.ShowDialog();
                adminPass = voidauth.adminPassword;
            }

            con.Open();
            QuerySelect = "SELECT Password FROM tblUsers WHERE RoleID = 1 AND Password = '" + adminPass + "'";
            cmd = new SqlCommand(QuerySelect, con);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();

                foreach (DataGridViewRow row in dvgOrderList.SelectedRows)
                {

                    if (dvgOrderList.SelectedRows.Count > 0)
                    {
                        dvgOrderList.Rows.RemoveAt(row.Index);
                    }

                }

                int totalamount = 0;
                for (int i = 0; i < dvgOrderList.Rows.Count; ++i)
                {
                    totalamount += Convert.ToInt32(dvgOrderList.Rows[i].Cells[5].Value);
                }

                lblTotal.Text = "P " + totalamount.ToString() + "." + "00";

                txtAmount.Text = totalamount.ToString();
                txtSearch.Focus();
                //lblCountItems.Text = dvgOrderList.Rows.Count.ToString();
                dvgOrderList.Refresh();


                reader.Close();
            }
            else
            {
                MessageBox.Show("Wrong Password! Try Again", "Authorization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            adminPass = null;

        }


        // update Inventory
        private void UpdateInventoryStocks()
        {

            try
            {
                for (int i = 0; i < dvgOrderList.Rows.Count; i++)
                {

                    QueryUpdate = "UPDATE tblStockin SET QtyStockedIn ='" + dvgOrderList.Rows[i].Cells["Remaining Quantity"].Value + "' WHERE ProductID='" + dvgOrderList.Rows[i].Cells["Product Code"].Value + "'";
                    con.Open();
                    cmd = new SqlCommand(QueryUpdate, con);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Logout from the System?", "Log-out", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                dt.Clear();
                dt.Columns.Clear();
                Hide();

                frmLogin l = new frmLogin();
                l.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Exit the Application?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pbLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Logout from the System?", "Log-out", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                dt.Clear();
                dt.Columns.Clear();
                Hide();

                frmLogin l = new frmLogin();
                l.Show();
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Exit the Application?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
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
            //DatetimeTimer
            timer1.Enabled = true;

            //Username and Role
            lblUserName.Text = frmLogin.GetUserName.ToString();
            lblUserRole.Text = frmLogin.GetUserRole.ToString();

            //Datatable
            ColumnsLoader();

        }

        private void pbPay_Click(object sender, EventArgs e)
        {
            frmPayment payment = new frmPayment();
            payment.Show();
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
                    int quantity = int.Parse(row.Cells[3].Value.ToString());
                    double price = double.Parse(row.Cells[4].Value.ToString());
                    double result;
                    row.Cells[5].Value = quantity * price;
                    row.Cells[6].Value = instock;
                }

                int totalamount = 0;
                for (int i = 0; i < dvgOrderList.Rows.Count; ++i)
                {
                    totalamount += Convert.ToInt32(dvgOrderList.Rows[i].Cells[5].Value);
                }

                lblTotal.Text = "P " + totalamount.ToString("#,0.00");
                txtAmount.Text = totalamount.ToString("0.00");
            }
            else
            {
                if (e.RowIndex > -1)
                {
                    DataGridViewRow row = dvgOrderList.Rows[e.RowIndex];
                    int quantity = int.Parse(row.Cells[3].Value.ToString());
                    double price = double.Parse(row.Cells[4].Value.ToString());
                    double result;
                    row.Cells[5].Value = quantity * price;
                    row.Cells[6].Value = instock - qty;
                }

                int totalamount = 0;
                for (int i = 0; i < dvgOrderList.Rows.Count; ++i)
                {
                    totalamount += Convert.ToInt32(dvgOrderList.Rows[i].Cells[5].Value);
                }

                lblTotal.Text = "P " + totalamount.ToString("#,0.00");
                txtAmount.Text = totalamount.ToString("0.00");
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductCode.Text == "")
                {
                    MessageBox.Show("Please Search Product First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSearch.Focus();
                }
                else if (txtProdDesc.Text == "")
                {
                    MessageBox.Show("Please Search Product First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSearch.Focus();
                }
                else if (txtProdVariety.Text == "")
                {
                    MessageBox.Show("Please Search Product First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSearch.Focus();
                }
                else if (txtQuantity.Text == "")
                {
                    txtQuantity.Text = "1";
                    MessageBox.Show("Invalid Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtProdPrice.Text == "")
                {
                    MessageBox.Show("Please Search Product First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSearch.Focus();
                }
                else if (System.Text.RegularExpressions.Regex.IsMatch(txtQuantity.Text, "[^0-9]"))
                {
                    txtQuantity.Text = "1";
                    MessageBox.Show("Invalid Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    DataRow[] rows = dt.Select(string.Format("[product code]='{0}'", txtProductCode.Text));
                    DataRow item;

                    int qty = Convert.ToInt32(txtQuantity.Text);
                    double price = Convert.ToDouble(txtProdPrice.Text);
                    double instock = Convert.ToInt32(txtStock.Text);
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
                        txtQuantityCount.Text = "";
                        txtAmount.Text = "";
                    }
                    else if (qty > instock)
                    {
                        MessageBox.Show("You reached the limit of quantity of this product, Try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtQuantityCount.Text = "";
                        txtAmount.Text = "";
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
                            item["subtotal"] = eqty * price;
                            item["remaining quantity"] = remaining;
                            dt.AcceptChanges();
                        }
                        else
                        {
                            if (txtProdDesc.Text.Length > 13)
                            {
                                item = dt.NewRow();
                                item["product code"] = txtProductCode.Text;
                                item["product description"] = txtProdDesc.Text.Substring(0, 13);
                                item["product variety"] = txtProdVariety.Text;
                                item["quantity"] = txtQuantity.Text;
                                item["price"] = price.ToString("#,0.00");
                                item["subtotal"] = qty * price;
                                item["remaining quantity"] = instock - qty;
                                dt.Rows.Add(item);
                            }
                            else
                            {
                                item = dt.NewRow();
                                item["product code"] = txtProductCode.Text;
                                item["product description"] = txtProdDesc.Text;
                                item["product variety"] = txtProdVariety.Text;
                                item["quantity"] = txtQuantity.Text;
                                item["price"] = price.ToString("#,0.00");
                                item["subtotal"] = qty * price;
                                item["remaining quantity"] = instock - qty;
                                dt.Rows.Add(item);
                            }
                        }

                        double totalamount = 0;
                        totalamount = Convert.ToDouble(dt.Compute("sum([subtotal])", ""));
                        lblTotal.Text = "P " + totalamount.ToString("#,0.00");
                        txtAmount.Text = totalamount.ToString("0.00");
                    }

                    txtSearch.Focus();
                    txtProductCode.Text = "";
                    txtProdDesc.Text = "";
                    txtProdVariety.Text = "";
                    txtQuantity.Text = "1";
                    txtStock.Text = "0";
                    txtProdPrice.Text = "";

                    txtQuantityCount.Text = dvgOrderList.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChange(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtProductCode.Text = "";
                txtProdDesc.Text = "";
                txtProdVariety.Text = "";
                txtStock.Text = "0";
                txtProdPrice.Text = "";
            }
            else
            {
                try
                {
                    con.Close();
                    con.Open();
                    QuerySelect = "SELECT p.ProductCode AS 'Product Code', p.ProductDesc AS 'Product Description', p.ProductVariety AS 'Product Variety', s.QtyStockedIn AS 'Stock', p.Price AS 'Price' FROM tblStockin s INNER JOIN tblProducts p ON s.ProductID = p.ProductID WHERE p.ProductCode ='" + txtSearch.Text + "'";
                    cmd = new SqlCommand(QuerySelect, con);
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        txtProductCode.Text = reader["Product Code"].ToString();
                        txtProdDesc.Text = reader["Product Description"].ToString();
                        txtProdVariety.Text = reader["Product Variety"].ToString();
                        txtStock.Text = reader["Stock"].ToString();
                        txtProdPrice.Text = reader["Price"].ToString();

                        reader.Close();
                    }
                    else
                    {
                        txtProductCode.Text = "";
                        txtProdDesc.Text = "";
                        txtProdVariety.Text = "";
                        txtStock.Text = "0";
                        txtProdPrice.Text = "";
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSearch.Text == "")
                {
                    MessageBox.Show("Search Product First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtProductCode.Text = "";
                    txtProdDesc.Text = "";
                    txtStock.Text = "0";
                    txtProdPrice.Text = "";
                }
                else
                {
                    btnAdd_Click((object)sender, (EventArgs)e);
                    txtSearch.Text = ""; 
                    txtProductCode.Text = "";
                    txtProdDesc.Text = "";
                    txtStock.Text = "0";
                    txtProdPrice.Text = "";
                }
            }
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click((object)sender, (EventArgs)e);
            }
        }

        private void pbVoid_Click(object sender, EventArgs e)
        {
            VoidProduct();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            frmPayment payment = new frmPayment();
            payment.Show();
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            VoidProduct();
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            //con.Open();
            //QuerySelect = "SELECT Password FROM tblUsers WHERE RoleID = 1 AND Password = '" + adminPass + "'";
            //cmd = new SqlCommand(QuerySelect, con);
            //reader = cmd.ExecuteReader();
            //if (reader.HasRows)
            //{

            //}

            frmProductLookup productLookup = new frmProductLookup();
            productLookup.ShowDialog();
            txtProductCode.Text = productLookup.productCode;
            txtProdDesc.Text = productLookup.productDesc;
            txtProdVariety.Text = productLookup.productVariety;
            txtProdPrice.Text = productLookup.productPrice;
             txtQuantity.Text = productLookup.quantity.ToString();
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            frmProductLookup productLookup = new frmProductLookup();
            productLookup.Show();
        }

        private void txtProductCode_TextChange(object sender, EventArgs e)
        {
            try
            {
                con.Close();
                con.Open();
                QuerySelect = "SELECT s.QtyStockedIn AS 'Stock' FROM tblStockin s INNER JOIN tblProducts p ON s.ProductID = p.ProductID WHERE p.ProductCode ='" + txtProductCode.Text + "'";
                cmd = new SqlCommand(QuerySelect, con);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    txtProductCode.Text = txtProductCode.Text;
                    txtStock.Text = reader["Stock"].ToString();
                    reader.Close();
                }
                else
                {
                    //txtProductCode.Text = "";
                    txtProdDesc.Text = "";
                    txtProdVariety.Text = "";
                    txtStock.Text = "0";
                    txtProdPrice.Text = "";
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNewTrans_Click(object sender, EventArgs e)
        {
            GetTransNo();
            txtSearch.Enabled = true;
            btnSearchProduct.Enabled = true;
            pbSearch.Enabled = true;
        }

        private void pbNewTrans_Click(object sender, EventArgs e)
        {
            GetTransNo();
            txtSearch.Enabled = true;
            btnSearchProduct.Enabled = true;
            pbSearch.Enabled = true;
        }

        private void pbCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to cancel the Transaction?", "Cancel Transaction", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                ClearAll();
                txtSearch.Enabled = false;
                btnSearchProduct.Enabled = false;
                pbSearch.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to cancel the Transaction?", "Cancel Transaction", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                ClearAll();
                txtSearch.Enabled = false;
                btnSearchProduct.Enabled = false;
                pbSearch.Enabled = false;
            }
        }
    }
}
