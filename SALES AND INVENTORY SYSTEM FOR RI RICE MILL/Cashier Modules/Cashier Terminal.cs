using SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Cashier_Modules;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL
{
    public partial class frmSalesManagement : Form
    {
        frmReturnItem returnItem = new frmReturnItem();
        //frmReturns returnMngt = new frmReturns();
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

        public string transCount;
        public string transTotal;
        public Boolean isRowUpdated = false;
        public bool isReturn;
        public string[] SKU;
        public List<string> SKU_LIST { get; set; }

        frmProductLookup productLookup = new frmProductLookup();
        public frmSalesManagement()
        {
            InitializeComponent();
            returnItem.FormClosed += new FormClosedEventHandler(Form_Closed);
        }

        void Form_Closed(object sender, FormClosedEventArgs e)
        {
            frmReturnItem frm = (frmReturnItem)sender;
            btnNewTrans_Click((object)sender, (EventArgs)e);
            btnSearchProduct_Click((object)sender, (EventArgs)e);
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
            dt.Rows.Clear();
            dt.Columns.Clear();
            //dt.Columns.Add("Product Code", typeof(string)).ReadOnly = true;
            dt.Columns.Add("Product Description", typeof(string)).ReadOnly = true;
            //dt.Columns.Add("Product Variety", typeof(string)).ReadOnly = true;
            dt.Columns.Add("Quantity", typeof(int));
            dt.Columns.Add("Price", typeof(float)).ReadOnly = true;
            dt.Columns.Add("SubTotal", typeof(float));
            dvgOrderList.DataSource = dt;
        }

        public void ClearAll()
        {

            //textbox controls
            txtSearch.Text = "";
            txtProdDesc.Text = "";
            txtQuantity.Text = "1";
            txtProdPrice.Text = "";
            txtStock.Text = "0";
            txtAmount.Text = "";
            txtQuantityCount.Text = "";
            txtVatAmount.Text = "";
            txtVatable.Text = "";

            //label controls
            lblTransNo.Text = "0000000000";
            lblTotal.Text = "0.00";
            lblTransDate.Text = "Date";
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
                        foreach (DataGridViewRow row in dvgOrderList.SelectedRows)
                        {

                            if (dvgOrderList.SelectedRows.Count > 0)
                            {
                            //insert into tblVoid
                                con.Close();
                                con.Open();
                                string list_sku = String.Join("','", SKU_LIST.Select(i => i.Replace("'", "''")));
                                int quants = Convert.ToInt32(dvgOrderList.Rows[row.Index].Cells[1].Value);
                                string description = dvgOrderList.Rows[row.Index].Cells[0].Value.ToString();
                                DataTable tempDT = new DataTable();
                                //for (int i = 0; i < quants; i++)
                               // {
                                
                                    QuerySelect = "SELECT Item_id, SKU FROM tblInventories WHERE SKU IN ('"+ list_sku + "') " +
                                    "AND Item_id = (SELECT Item_id FROM tblItems WHERE Description = '"+description+"')";
                                    cmd = new SqlCommand(QuerySelect, con);
                                    adapter = new SqlDataAdapter(cmd);
                                    adapter.Fill(tempDT);
                                    cmd.ExecuteNonQuery();
                                
                                
                               // }
                                con.Close();
                                con.Open();
                                for(int i = 0; i < tempDT.Rows.Count; i++)
                                {
                                     QueryInsert = "INSERT INTO tblVoid(description, SKU, quantity, void_date)" +
                                     "VALUES((SELECT Description FROM tblItems WHERE Item_id = '"+tempDT.Rows[i][0].ToString()+"')" +
                                     ",'"+ tempDT.Rows[i][1].ToString() + "', 1, (SELECT GETDATE()))";
                                    cmd = new SqlCommand(QueryInsert, con);
                                    cmd.ExecuteNonQuery();
                                }
                               
                                con.Close();


                        MessageBox.Show("Product is voided!");
                            dvgOrderList.Rows.RemoveAt(row.Index);
                            }
                        }

                    int totalamount = 0;
                    for (int i = 0; i < dvgOrderList.Rows.Count; ++i)
                    {
                        totalamount += Convert.ToInt32(dvgOrderList.Rows[i].Cells[3].Value);
                    }

                    //lblTotal.Text = totalamount.ToString() + "." + "00";
                    
                    //QueryInsert = "INSERT INTO tblVoid(description, SKU, quantity, void_date)" +
                    // "VALUES((SELECT MAX(Order_id) FROM tblOrders),@description, @sku)";
                    //cmd = new SqlCommand(QueryInsert, con);

                    //cmd.Parameters.AddWithValue("@description", DESCRIPTION[i]);
                    //cmd.Parameters.AddWithValue("@sku", NEW_SKU[i]);
                    //cmd.ExecuteNonQuery();


                    txtAmount.Text = totalamount.ToString();
                    lblTotal.Text = txtAmount.Text;

                    recompute(totalamount);
                    txtSearch.Focus();
                    dvgOrderList.Refresh();
                    dvgOrderList.ClearSelection();


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
                        btnCancel.Enabled = false;

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

                case Keys.F6:
                    btnCancel.Click += btnCancel_Click;
                    return true;

                case Keys.F7:
                    btnSet.Click += btnRecords_Click;
                    return true;
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

        private void frmSalesManagement_Load(object sender, EventArgs e)
        {
            //DatetimeTimer
            timer1.Enabled = true;

            //Username and Role
            lblUserName.Text = frmLogin.GetUserName.ToString();
            lblUserRole.Text = frmLogin.GetUserRole.ToString();

            btnVoid.LabelText = "[F3] Void" + Environment.NewLine + "Item" + Environment.NewLine;
            btnCancel.LabelText = "[F5] Void" + Environment.NewLine + "Transaction" + Environment.NewLine;

            //Datatable
            ColumnsLoader();

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

               
                txtAmount.Text = /*"P " +*/ totalamount.ToString("#,0.00");
                lblTotal.Text = txtAmount.Text;
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
                    txtQuantity.Text = "0";
                    MessageBox.Show("Invalid Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtProdPrice.Text == "")
                {
                    MessageBox.Show("Please Search Product First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSearch.Focus();
                }
                else if (System.Text.RegularExpressions.Regex.IsMatch(txtQuantity.Text, "[^0-9]"))
                {
                    txtQuantity.Text = "0";
                    MessageBox.Show("Invalid Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    DataRow[] rows = dt.Select(string.Format("[product description]='{0}'", txtProdDesc.Text));
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
                    else if (rows.Count() == 0)
                    {
                        
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
                            dt.AcceptChanges();
                        }
                        else
                        {
                                item = dt.NewRow();
                                item["product description"] = txtProdDesc.Text;
                                item["quantity"] = txtQuantity.Text;
                                item["price"] = price.ToString("#,0.00");
                                item["subtotal"] = qty * price;
                                dt.Rows.Add(item);
                        }

                        double totalamount = 0;
                        totalamount = Convert.ToDouble(dt.Compute("sum([subtotal])", ""));
                        
                        txtAmount.Text = /*"P " +*/ totalamount.ToString("#,0.00");
                        lblTotal.Text = txtAmount.Text;
                        //lblTotal.Text = totalamount.ToString("#,0.00");
                        //compute here lols
                        recompute(totalamount);
                        //asta lng di
                    }


                    txtSearch.Text = "";
                    txtSearch.Focus();
                    txtProdDesc.Text = "";
                    txtQuantity.Text = "0";
                    txtStock.Text = "0";
                    txtProdPrice.Text = "";

                    txtQuantityCount.Text = dvgOrderList.Rows.Count.ToString();
                    dvgOrderList.ClearSelection();
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
            

            
            txtVatAmount.Text = (totalamount * 0.12).ToString("#,0.00");
            txtVatable.Text = (totalamount - float.Parse(txtVatAmount.Text)).ToString("#,0.00");
            totalamount = totalamount + (totalamount * 0.12);
            lblTotal.Text = txtAmount.Text;
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
            dtfromdvg.Columns.Add("Quantity", typeof(int));
            dtfromdvg.Columns.Add("Price", typeof(float)).ReadOnly = true;
            dtfromdvg.Columns.Add("SubTotal", typeof(float));
            try
            {
                for (int row = 0; row < dvgOrderList.Rows.Count; row++)
                {

                   string[] tempArr = new string[dvgOrderList.Columns.Count];
                    for (int col = 0; col < dvgOrderList.Columns.Count; col++)
                    {
                        tempArr[col] = dvgOrderList.Rows[row].Cells[col].Value.ToString();
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
            GetTransNo();
            txtSearch.Enabled = true;
            txtSearch.Focus();

            //buttons
            //btnLogout.Enabled = false;
            //btnExit.Enabled = false;
            btnSearchProduct.Enabled = true;
            btnAdd.Enabled = true;
            btnVoid.Enabled = true;
            btnReturn.Enabled = true;
            btnPay.Enabled = true;
            btnCancel.Enabled = true;
            btnLogout.Enabled = false;
            btnExit.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            VoidTransaction();
            btnLogout.Enabled = true;
            btnExit.Enabled = true;
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            frmSalesHistory history = new frmSalesHistory();
            history.Show();
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            if(dvgOrderList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select product first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
            else
            {
                VoidProduct();
            }
            
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            
            productLookup.skuList = SKU_LIST;
            productLookup.ShowDialog();
            if(isReturn)
            {
                isReturn = true;
            }
            else
            {
                isReturn = false;
            }
            if(productLookup.quantity.ToString() != "")
            {
                txtProdDesc.Text = productLookup.productDesc;
                txtProdPrice.Text = productLookup.productPrice;
                txtQuantity.Text = productLookup.quantity.ToString();
                txtStock.Text = productLookup.stock;
                SKU = productLookup.sku;
                SKU_LIST = productLookup.skuList;
               
                btnAdd_Click((object)sender, (EventArgs)e);
            }
          
          
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (!isRowUpdated)
            {
                MessageBox.Show("Input Item First!");
            }
            else
            {

                string[] itemDesc = new string[dvgOrderList.Rows.Count];
                int[] qty = new int[dvgOrderList.Rows.Count];
                double[] price = new double[dvgOrderList.Rows.Count];


                //itemdeets to pass on payment
                for (int i = 0; i < dvgOrderList.Rows.Count; i++)
                {
                    itemDesc[i] = dvgOrderList.Rows[i].Cells[0].Value.ToString();
                    qty[i] = Convert.ToInt32(dvgOrderList.Rows[i].Cells[1].Value.ToString());
                    price[i] = Convert.ToDouble(dvgOrderList.Rows[i].Cells[3].Value.ToString());
                }



                setdt();
                frmPayment payment = new frmPayment();
                payment.isReturn = isReturn;
                payment.txtAmount.Text = lblTotal.Text;
                payment.transNo = lblTransNo.Text;
                payment.storeDt(dtfromdvg);
                payment.ItemDesc = itemDesc;
                payment.Qty = qty;
                payment.Price = price;
                payment.tax = txtVatAmount.Text;
                payment.vatable = txtVatable.Text;
                payment.SKU = SKU;
                payment.sku_list = SKU_LIST;


                DialogResult res = payment.ShowDialog();

                if (res == DialogResult.OK)
                {
                    ClearAll();

                    //buttons
                    btnSearchProduct.Enabled = false;
                    btnAdd.Enabled = false;
                    btnVoid.Enabled = false;
                    btnPay.Enabled = false;
                    btnCancel.Enabled = false;
                    btnLogout.Enabled = true;
                    btnExit.Enabled = true;
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
                dt.Clear();
                dt.Columns.Clear();
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        //mod end

    }
}
