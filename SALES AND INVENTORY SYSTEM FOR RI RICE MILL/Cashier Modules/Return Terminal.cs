using SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Cashier_Modules;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL
{
    public partial class frmReturnTerminal : Form
    {
        frmReturnItem returnItem = new frmReturnItem();
        frmSearchTransNo transNum = new frmSearchTransNo();
        frmDisplaySKU sku = new frmDisplaySKU();
        public static SqlConnection con = new SqlConnection(DBConnection.con);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader reader;
        public static SqlDataAdapter adapter;
        public static DataTable dt = new DataTable();
        public static DataTable dt1 = new DataTable();
        public static DialogResult result;
        public static string QueryInsert;
        public static string QuerySelect;
        public static string QueryUpdate;
        public static string QueryDelete;
        public static string adminPass;
        public static string transaction_number;

        public string transCount;
        public string transTotal;
        public Boolean isRowUpdated = false;
        public bool isReturn;
        public string[] SKU;
        public string price;
        public string CustomerId;
        public List<string> SKU_LIST { get; set; }

        public frmReturnTerminal()
        {
            InitializeComponent();
            transNum.FormClosed += new FormClosedEventHandler(Form_Closed);
            sku.FormClosed += new FormClosedEventHandler(Form_Closed1);
        }
        
        void Form_Closed(object sender, FormClosedEventArgs e)
        {
            frmSearchTransNo frm = (frmSearchTransNo)sender;
            // dvgOrderList.Rows.Clear();
            DisplayReturn();
           
            btnSearchProduct.Enabled = false;
            
            btnPay.Enabled = false;
            btnExit.Enabled = false;
            btnLogout.Enabled = false;
            btnCancel.Enabled = true;
            // btnNewTrans_Click((object)sender, (EventArgs)e);
            //btnSearchProduct_Click((object)sender, (EventArgs)e);
        }

        void Form_Closed1(object sender, FormClosedEventArgs e)
        {
            DisplayReturnDetails();
            //dvgOrderList.DataSource = null;
            btnSearchProduct.Enabled = true;

            btnPay.Enabled = true;
            lblTotal.Text = "0.00";
            lblTransDate.Text = "";

            price = sku.Price;
            if(price.Equals("0.00"))
            {
                txtReturnAmount.Text = Convert.ToDouble(price).ToString("N2");
            }
            else
            {
                txtReturnAmount.Text = Convert.ToDouble(price).ToString("N2");
            }
            
            GetTransNo();
            //btnSearchProduct_Click((object)sender, (EventArgs)e);
            //QuerySelect = "SELECT";


            //frmReturnProductLookup productLookup = new frmReturnProductLookup();
            // productLookup.productPrice = ??

        }

        public void DisplayReturnDetails()
        {
            //datagrid
            try
            {
                con.Close();
                con.Open();
                //QuerySelect = "SELECT SKU FROM OrderDetailsView WHERE Transaction_number = @trans";
                QuerySelect = "SELECT * FROM vwTempReturn";
                cmd = new SqlCommand(QuerySelect, con);
               

                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dgvShowReturn.DataSource = dt;


            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
        }

        public void DisplayReturn()
        {
            dvgOrderList.Update();
            dvgOrderList.Refresh();
            transaction_number = transNum.Transaction_Number;
            //datagrid
            try
            {
                con.Close();
                con.Open();
                QuerySelect = "SELECT Description, Price, Quantity, Subtotal FROM ReturnTransactionView WHERE Transaction_number = @trans";
                //QuerySelect = "SELECT Order_id as 'ID', Transaction_number as 'Transaction Number', Quantity, Total_cost as 'Total' FROM tblOrders WHERE Transaction_number = @trans";
                cmd = new SqlCommand(QuerySelect, con);
                cmd.Parameters.AddWithValue("@trans", transaction_number);

                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dvgOrderList.DataSource = dt;

                
            }
            catch(Exception ex)
            {

            }finally
            {
                con.Close();
            }
            //labels
            try
            {
                con.Close();
                con.Open();
                QuerySelect = "SELECT * FROM ReturnTransactionView WHERE Transaction_number = @trans";
                cmd = new SqlCommand(QuerySelect, con);
                cmd.Parameters.AddWithValue("@trans", transaction_number);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                       
                        lblTotal.Text = Convert.ToDouble(reader["Total_cost"]).ToString("N2");
                        string total = String.Format(reader["Transaction_number"].ToString());
                        lblTransNo.Text = total;

                        DateTime orderDate = Convert.ToDateTime(reader["Order_date"].ToString());
                        lblTransDate.Text = orderDate.ToString("MMMM dd, yyyy");
                        CustomerId = reader["Customer_id"].ToString();
                    }
                }
                reader.Close();

            }catch (Exception ex)
            {

            }finally
            {
                //con.Close();
            }


        }

        //Generate TransNo
        void GetTransNo()
        {
            try
            {
                string sdate = DateTime.Now.ToString("yyyyMMdd");
                string transNo;
                int count;
                con.Close();
                con.Open();
                cmd = new SqlCommand("SELECT count(Transaction_number) as id FROM tblOrders WHERE Transaction_number LIKE '" + sdate + "%'", con);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        transNo = reader["id"].ToString();
                        count = int.Parse(transNo);
                        lblTransNo.Text = sdate + "0" + (count + 1);
                        lblTransDate.Text = DateTime.Now.ToString("MMMM dd,yyyy");
                    }
                }
                else
                {
                    transNo = sdate + "01";
                    lblTransNo.Text = transNo;
                    lblTransDate.Text = DateTime.Now.ToString("MMMM dd,yyyy");
                }

                reader.Close();
                con.Close();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                con.Close();
            }
        }

        // Load Columns DataGrid(Table)
        public void ColumnsLoader()
        {
            try
            {

                dt1.Rows.Clear();
                dt1.Columns.Clear();
                //dt.Columns.Add("Product Code", typeof(string)).ReadOnly = true;
                dt1.Columns.Add("Product Description", typeof(string)).ReadOnly = true;
                //dt.Columns.Add("Product Variety", typeof(string)).ReadOnly = true;
                dt1.Columns.Add("Quantity", typeof(int));
                dt1.Columns.Add("Price", typeof(float)).ReadOnly = true;
                dt1.Columns.Add("SubTotal", typeof(float));
                dgvItemReplaced.DataSource = dt1;
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

        public void ClearAll()
        {

            //textbox controls
            dvgOrderList.DataSource = null;
            txtReturnAmount.Text = "0.00";
            txtSearch.Text = "";
            txtProdDesc.Text = "";
            txtQuantity.Text = "1";
            txtProdPrice.Text = "";
            txtStock.Text = "0";
            txtAmount.Text = "";
            txtQuantityCount.Text = "";
            txtVatAmount.Text = "";
            txtVatable.Text = "";
            dgvShowReturn.DataSource = null;

            //label controls
            lblTransNo.Text = "0000000000";
            lblTotal.Text = "0.00";
            lblTransDate.Text = "Date";
            dt1.Clear();
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
            try
            {
                con.Open();
                QuerySelect = "SELECT * FROM tblUsers WHERE Password = '" + adminPass + "'";
                cmd = new SqlCommand(QuerySelect, con);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    //if (reader[4].ToString() == "Inactive")
                    //{
                    //    MessageBox.Show("Can't log-in into the system. Admin has deactivated your account", "User Deactivated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                    //else
                        foreach (DataGridViewRow row in dgvItemReplaced.SelectedRows)
                        {

                            if (dgvItemReplaced.SelectedRows.Count > 0)
                            {
                                dgvItemReplaced.Rows.RemoveAt(row.Index);
                            }
                        }

                    int totalamount = 0;
                    for (int i = 0; i < dgvItemReplaced.Rows.Count; ++i)
                    {
                        totalamount += Convert.ToInt32(dgvItemReplaced.Rows[i].Cells[2].Value);
                    }

                    //lblTotal.Text = totalamount.ToString() + "." + "00";

                    txtAmount.Text = totalamount.ToString("N2");
                    lblTotal.Text = Convert.ToDouble(txtAmount.Text).ToString("N2");

                    recompute(totalamount);
                    txtSearch.Focus();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        //Cancel Transaction
        void VoidTransaction()
        {
            DialogResult dialog = MessageBox.Show("Do you want to cancel the Transaction?", "Cancel Transaction", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (String.IsNullOrEmpty(adminPass))
                {
                    frmvoidauth voidauth = new frmvoidauth();
                    voidauth.ShowDialog();
                    adminPass = voidauth.adminPassword;
                }
                try
                {
                    con.Open();
                    QuerySelect = "SELECT * FROM tblUsers WHERE Password = '" + adminPass + "'";
                    cmd = new SqlCommand(QuerySelect, con);
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();

                        ClearAll();
                        txtSearch.Enabled = false;

                        //buttons
                        btnSearchProduct.Enabled = false;
                        btnAdd.Enabled = false;
                        btnVoid.Enabled = false;
                        btnPay.Enabled = false;
                        //btnCancel.Enabled = false;

                        reader.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password! Try Again", "Authorization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    con.Close();
                    adminPass = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
                
            }     

        }


        //ButtonKey Shortcuts
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            switch (keyData)
            {
                case Keys.F1:
                    btnNewTrans.Click += btnNewTrans_Click;
                    return true;

                case Keys.F2:
                    btnSearchProduct.Click += btnSearchProduct_Click;
                    return true;

                case Keys.F3:
                    btnVoid.Click += btnVoid_Click; ;
                    return true;

                case Keys.F4:
                    btnPay.Click += btnPay_Click;
                    return true;

                //case Keys.F6:
                //    btnCancel.Click += btnCancel_Click;
                //    return true;

                //case Keys.F7:
                //    btnSet.Click += btnRecords_Click;
                //    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            lblTime.Text = time.ToString("h:mm:ss tt");

            DateTime date = DateTime.Now;
            lblDayDate.Text = string.Format("{0:D}", date);
        }

        private void frmReturnTerminal_Load(object sender, EventArgs e)
        {
            //DatetimeTimer
            timer1.Enabled = true;

            //Username and Role
            lblUserName.Text = frmLogin.GetUserName.ToString();
            lblUserRole.Text = frmLogin.GetUserRole.ToString();

            btnVoid.LabelText = "[F3] Void" + Environment.NewLine + "Item" + Environment.NewLine;
            //btnCancel.LabelText = "[F5] Void" + Environment.NewLine + "Transaction" + Environment.NewLine;

            //Datatable
            txtReturnAmount.Text = "0.00";
            ColumnsLoader();

        }

        private void dvgOrderList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int qty = Convert.ToInt32(dgvItemReplaced[e.ColumnIndex, e.RowIndex].Value.ToString());
            double instock = Convert.ToInt32(txtStock.Text);
                
            if (qty > instock)
            {

                MessageBox.Show("You reached the limit of quantity of this product, Try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvItemReplaced[e.ColumnIndex, e.RowIndex].Value = 1;

                if (e.RowIndex > -1)
                {
                    DataGridViewRow row = dgvItemReplaced.Rows[e.RowIndex];
                    int quantity = int.Parse(row.Cells[1].Value.ToString());
                    double price = double.Parse(row.Cells[2].Value.ToString());
                    double result;
                    row.Cells[5].Value = quantity * price;
                    row.Cells[6].Value = instock;
                }

                int totalamount = 0;
                for (int i = 0; i < dgvItemReplaced.Rows.Count; ++i)
                {
                    totalamount += Convert.ToInt32(dgvItemReplaced.Rows[i].Cells[5].Value);
                }

               
                txtAmount.Text = /*"P " +*/ totalamount.ToString("#,0.00");
                lblTotal.Text = Convert.ToDouble(txtAmount.Text).ToString("N2");
                //lblTotal.Text = totalamount.ToString("#,0.00");
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

                txtAmount.Text = /*"P " +*/ totalamount.ToString("#,0.00");
                lblTotal.Text = txtAmount.Text;
                //txtAmount.Text = totalamount.ToString("0.00");
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //if (txtProdDesc.Text == "")
                //{
                //    MessageBox.Show("Please Search Product First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    txtSearch.Focus();
                //}
                //else 
                if (txtQuantity.Text == "")
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

                    DataRow[] rows = dt1.Select(string.Format("[product description]='{0}'", txtProdDesc.Text));
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
                            eqty = eqty + qty;
                            item["quantity"] = eqty;
                            item["subtotal"] = eqty * price;
                            dt1.AcceptChanges();
                        }
                        else
                        {
                                item = dt1.NewRow();
                                item["product description"] = txtProdDesc.Text;
                                item["quantity"] = txtQuantity.Text;
                                item["price"] = price.ToString("#,0.00");
                                item["subtotal"] = qty * price;
                                dt1.Rows.Add(item);
                        }

                        double totalamount = 0;
                        totalamount = Convert.ToDouble(dt1.Compute("sum([subtotal])", ""));
                        
                        txtAmount.Text = /*"P " +*/ totalamount.ToString("#,0.00");
                        double minus_price = Convert.ToDouble(txtAmount.Text) - Convert.ToDouble(price);
                        lblTotal.Text = minus_price.ToString("N2");
                        //lblTotal.Text = txtAmount.Text;
                        //lblTotal.Text = totalamount.ToString("#,0.00");
                        //compute here lols
                        recompute(totalamount);
                        //asta lng di
                    }


                    txtSearch.Text = "";
                    txtSearch.Focus();
                    txtProdDesc.Text = "";
                    txtQuantity.Text = "1";
                    txtStock.Text = "0";
                    txtProdPrice.Text = "";

                    txtQuantityCount.Text = dgvItemReplaced.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            isRowUpdated = true;
        }
        private void recompute(double totalamount)
        {

            //txtVatable.Text = (totalamount / 1.12).ToString("#,0.00");
            //txtVatAmount.Text = (totalamount * 0.12).ToString("#,0.00");
            //totalamount = totalamount + (totalamount * 0.12);
            double minus_price = totalamount - Convert.ToDouble(price);
            lblTotal.Text = minus_price.ToString("N2");
            //lblTotal.Text = txtAmount.Text;
            //lblTotal.Text = totalamount.ToString("#,0.00");
        }


        public void DisplayItemDesc()
        {
            if (txtSearch.Text == "")
            {
                txtProdDesc.Text = "";
            }
            else
            {
                try
                {
                    con.Close();
                    con.Open();
                    QuerySelect = "SELECT tblItems.[Description] FROM tblInventories INNER JOIN tblItems ON tblInventories.Item_id = tblItems.Item_id WHERE SKU = @sku";

                    cmd = new SqlCommand(QuerySelect, con);
                    cmd.Parameters.AddWithValue("@sku", txtSearch.Text);

                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        txtProdDesc.Text = reader["Description"].ToString();

                        reader.Close();
                    }
                    else
                    {
                        txtProdDesc.Text = "";

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
                con.Close();
            }
        }

        public void DisplayItemDetails()
        {
            if (txtProdDesc.Text == "")
            {
                txtStock.Text = "0";
                txtProdPrice.Text = "";
            }
            else
            {
                try
                {
                    con.Close();
                    con.Open();
                    QuerySelect = "SELECT * FROM ItemInfo WHERE Description = @desc";

                    cmd = new SqlCommand(QuerySelect, con);
                    cmd.Parameters.AddWithValue("@desc", txtProdDesc.Text);
                    
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        txtStock.Text = reader["Stock"].ToString();
                        txtProdPrice.Text = reader["Price"].ToString();

                        reader.Close();
                    }
                    else
                    {
                        txtStock.Text = "0";
                        txtProdPrice.Text = "";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
                con.Close();
            }
        }

        private void txtSearch_TextChange(object sender, EventArgs e)
        {
            DisplayItemDesc();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSearch.Text == "")
                {
                    MessageBox.Show("Search Product First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);  
                    txtProdDesc.Text = "";
                    txtStock.Text = "0";
                    txtProdPrice.Text = "";
                }
                else
                {
                    btnAdd_Click((object)sender, (EventArgs)e);
                    txtSearch.Text = ""; 
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

        //mod start
        //vars xD
        public  DataTable dtfromdvg= new DataTable();
        private  void setdt()
        {
            dtfromdvg.Rows.Clear();
            dtfromdvg.Columns.Clear();
            dtfromdvg.Columns.Add("Product Description", typeof(string)).ReadOnly = true;
            dtfromdvg.Columns.Add("Product Variety", typeof(string)).ReadOnly = true;
            dtfromdvg.Columns.Add("Quantity", typeof(Double));
            dtfromdvg.Columns.Add("Price", typeof(float)).ReadOnly = true;
            dtfromdvg.Columns.Add("SubTotal", typeof(float));
            try
            {
                for (int row = 0; row < dgvItemReplaced.Rows.Count; row++)
                {

                   string[] tempArr = new string[dgvItemReplaced.Columns.Count];
                    for (int col = 0; col < dgvItemReplaced.Columns.Count; col++)
                    {
                        tempArr[col] = dgvItemReplaced.Rows[row].Cells[col].Value.ToString();
                    }
                    dtfromdvg.Rows.Add(tempArr);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNewTrans_Click(object sender, EventArgs e)
        {
            transNum.ShowDialog();
            btnPay.Enabled = false;
            btnSearchProduct.Enabled = false;
            
            
            
            //GetTransNo();
            //txtSearch.Enabled = true;
            //txtSearch.Focus();

            ////buttons
            //btnSearchProduct.Enabled = true;
            //btnAdd.Enabled = true;
            //btnVoid.Enabled = true;
            //btnReturn.Enabled = true;
            //btnPay.Enabled = true;
            //btnCancel.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            VoidTransaction();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            frmSalesHistory history = new frmSalesHistory();
            history.Show();
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            VoidProduct();
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            btnVoid.Enabled = true;
            btnPay.Enabled = false;

            //if(isComplete)
            //{
            //    MessageBox.Show("Cannot add another item!");
            //}
            //else
            //{
                frmReturnProductLookup productLookup = new frmReturnProductLookup(this);
                productLookup.skuList = SKU_LIST;
                productLookup.ShowDialog();
               

        
            if (productLookup.quantity.ToString() != "")
            {
                txtProdDesc.Text = productLookup.productDesc;
                txtProdPrice.Text = productLookup.productPrice;
                txtQuantity.Text = productLookup.quantity.ToString();
                txtStock.Text = productLookup.stock;
                SKU = productLookup.sku;
                SKU_LIST = productLookup.skuList;

                btnAdd_Click((object)sender, (EventArgs)e);
                btnPay.Enabled = true;
            }
            //}



        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (!isRowUpdated)
            {
                MessageBox.Show("Input Item First!");
            }
            else if(Convert.ToDouble(lblTotal.Text) < 0)
            {
                MessageBox.Show("It must be greater than the price that change", "Exit", MessageBoxButtons.OK);
            }
            else
            {
                //Returned
                string[] ReturneditemDesc = new string[dgvShowReturn.Rows.Count];
                int[] Returnedqty = new int[dgvShowReturn.Rows.Count];
                double[] Returnedprice = new double[dgvShowReturn.Rows.Count];
                string[] Remarks = new string[dgvShowReturn.Rows.Count];

                //Replaced
                string[] ReplaceditemDesc = new string[dgvItemReplaced.Rows.Count];
                int[] Replacedqty = new int[dgvItemReplaced.Rows.Count];
                double[] Replacedprice = new double[dgvItemReplaced.Rows.Count];

                try
                {
                    //Returned Itemdeets to pass on payment
                    for (int i = 0; i < dgvShowReturn.Rows.Count; i++)
                    {
                        ReturneditemDesc[i] = dgvShowReturn.Rows[i].Cells[0].Value.ToString();
                        Returnedqty[i] = Convert.ToInt32(dgvShowReturn.Rows[i].Cells[2].Value.ToString());
                        Returnedprice[i] = Convert.ToDouble(dgvShowReturn.Rows[i].Cells[3].Value.ToString());
                        Remarks[i] = dgvShowReturn.Rows[i].Cells[4].Value.ToString();
                    }


                    //Replaced Itemdeets to pass on payment
                    for (int i = 0; i < dgvItemReplaced.Rows.Count; i++)
                    {
                        ReplaceditemDesc[i] = dgvItemReplaced.Rows[i].Cells[0].Value.ToString();
                        Replacedqty[i] = Convert.ToInt32(dgvItemReplaced.Rows[i].Cells[1].Value.ToString());
                        Replacedprice[i] = Convert.ToDouble(dgvItemReplaced.Rows[i].Cells[2].Value.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                setdt();
                frmReturnPayment payment = new frmReturnPayment();
                payment.isReturn = isReturn;
                payment.txtAmount.Text = lblTotal.Text;
                payment.transNo = lblTransNo.Text;
                payment.storeDt(dtfromdvg);
                payment.tax = txtVatAmount.Text;
                payment.vatable = txtVatable.Text;
                payment.SKU = SKU;
                payment.cust = CustomerId;
                payment.sku_list = SKU_LIST;


                //ReturnedItems
                payment.ReturnedItemDesc = ReturneditemDesc;
                payment.ReturnedQty = Returnedqty;
                payment.ReturnedPrice = Returnedprice;
                payment.Remarks = Remarks;

                //Replaced Items
                payment.ReplacedItemDesc = ReplaceditemDesc;
                payment.ReplacedQty = Replacedqty;
                payment.ReplacedPrice = Replacedprice;



                DialogResult res = payment.ShowDialog();

                if (res == DialogResult.OK)
                {
                    ClearAll();

                    //buttons
                    btnSearchProduct.Enabled = false;
                    btnAdd.Enabled = false;
                    btnVoid.Enabled = false;
                    btnPay.Enabled = false;
                    btnExit.Enabled = true;
                    btnLogout.Enabled = true;
                    btnCancel.Enabled = false;
                    
                }
            }
               
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to return to Dashboard?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                frmMainSales main = new frmMainSales();
                
                this.DialogResult = DialogResult.OK;
               
                this.Close();
                main.Show();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Logout from the System?", "Log-out", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                dt1.Clear();
                dt1.Columns.Clear();
                Hide();

                frmLogin l = new frmLogin();
                l.Show();
            }
        }

        private void frmSalesManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void txtProdDesc_TextChange(object sender, EventArgs e)
        {
            DisplayItemDetails();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            isReturn = true;
            //returnMngt.ShowDialog();
            //returnItem.ShowDialog();
        
                //txtProdDesc.Text = returnItem.productDesc;
                //txtProdPrice.Text = returnItem.productPrice;
                //txtQuantity.Text = returnItem.quantity.ToString();
                //txtStock.Text = returnItem.stock;
                //btnAdd_Click((object)sender, (EventArgs)e);
        }

        private void dvgOrderList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            sku.Description = dvgOrderList.CurrentRow.Cells["Description"].Value.ToString();
            sku.Price = Convert.ToDouble(txtReturnAmount.Text).ToString("N2");
            //sku.Transaction_Number = dvgOrderList.CurrentRow.Cells["Transaction Number"].Value.ToString();
            sku.Transaction_Number = transaction_number;
            sku.ShowDialog();            
        }

        private void dvgOrderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvgOrderList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1 || e.ColumnIndex == 3)
            {
                e.CellStyle.Format = "N2";
            }
        }

        private void dgvItemReplaced_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 3)
            {
                e.CellStyle.Format = "N2";
            }
        }

        private void txtReturnAmount_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            string[] sku_return;
            result = MessageBox.Show("Do you want to cancel this transaction?", "Cancel Transaction", MessageBoxButtons.YesNo);
            
            if (result == DialogResult.Yes)
            {
                try
                {
                    con.Close();
                    con.Open();
                    QuerySelect = "SELECT SKU FROM tblTemp_return";
                    cmd = new SqlCommand(QuerySelect, con);
                    adapter = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    adapter.Fill(dt);

                    if(dt.Rows.Count > 0)
                    {
                        //sku_return = new string[dt.Rows.Count];
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            con.Close();
                            con.Open();
                            QueryUpdate = "Update tblInventories SET Status = 'Stock Out' WHERE SKU = @sku";
                            cmd = new SqlCommand(QueryUpdate, con);
                            cmd.Parameters.AddWithValue("@sku", dt.Rows[i][0].ToString());
                            cmd.ExecuteNonQuery();
                        }
                    }
                    //reader = cmd.ExecuteReader();

                    //if (reader.HasRows)
                    //{
                    //    while (reader.Read())
                    //    {

                    //        count++;
                    //        //sku_return = new string[reader.]
                    //        //con.Close();
                    //        //QueryUpdate = "Update tblInventories SET Status = 'Stock Out' WHERE SKU = @sku";
                    //        //cmd = new SqlCommand(QueryUpdate, con);
                    //        //cmd.Parameters.AddWithValue("@sku", reader["SKU"].ToString());
                    //        //cmd.ExecuteNonQuery();
                    //    }
                    //}
                    //sku_return = new string[count];
                    //for(int i = 0; i < sku_return.Length; i++)
                    //{
                    //    sku
                    //}
                    con.Close();
                    con.Open();
                    QueryDelete = "TRUNCATE TABLE tblTemp_return";
                    cmd = new SqlCommand(QueryDelete, con);
                    cmd.ExecuteNonQuery();

                    btnExit.Enabled = true;
                    btnLogout.Enabled = true;
                    btnSearchProduct.Enabled = false;
                    btnPay.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                
                finally
                {
                    con.Close();
                    MessageBox.Show("Transaction is canceled!");
                    DisplayReturnDetails();
                    ClearAll();
                }
            }
            
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
            
        }

        private void dvgOrderList_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            sku.Description = dvgOrderList.CurrentRow.Cells["Description"].Value.ToString();
            sku.Price = Convert.ToDouble(txtReturnAmount.Text).ToString("N2");
            //sku.Transaction_Number = dvgOrderList.CurrentRow.Cells["Transaction Number"].Value.ToString();
            sku.Transaction_Number = transaction_number;
            sku.ShowDialog();
        }

        private void dvgOrderList_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1 || e.ColumnIndex == 3)
            {
                e.CellStyle.Format = "N2";
            }
        }

        private void dgvShowReturn_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                e.CellStyle.Format = "N2";
            }
        }

        //mod end

    }
}
