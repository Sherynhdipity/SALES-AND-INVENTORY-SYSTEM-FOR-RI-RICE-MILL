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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL
{
    public partial class frmReturnPayment : Form
    {
        public frmReturnPayment()
        {

            InitializeComponent();
            addNewCustomer.FormClosed += new FormClosedEventHandler(Form_Closed);
        }
        //start mods
        public DataTable dtFromSalesMgt;
        public string transNo = "";
        public void storeDt(DataTable tempDT)
        {
            dtFromSalesMgt = tempDT;
        }
        //end mods

        frmSalesManagement sales = new frmSalesManagement();
        Cashier_Modules.addCustomer addCustomer = new Cashier_Modules.addCustomer();
        frmPrintReceipt receipt = new frmPrintReceipt();
        frmAddNewCustomer addNewCustomer = new frmAddNewCustomer();
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
        public double amount;
        public double discount;
        public string discountCode;
        public double discount_total;
        public double total;
        public int total_quantity = 0;
        public string[] SKU;
        public string[] DESCRIPTION;
        public string tax, vatable;

        public string[] ReplacedItemDesc { get; set; }
        public int[] ReplacedQty { get; set; }
        public double[] ReplacedPrice { get; set; }


        public string[] ReturnedItemDesc { get; set; }
        public int[] ReturnedQty { get; set; }
        public double[] ReturnedPrice { get; set; }
        public string[] Remarks { get; set; }

        public bool isReturn { get; set; }
        public string[] NEW_SKU;

        public List<string> sku_list { get; set; }

        public string cust { get; set; }
        private int customerID;
        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        void Form_Closed(object sender, FormClosedEventArgs e)
        {
            autoCompleteCustomer();
            //this.Close();
            //Cashier_Modules.addCustomer addCustomer = (Cashier_Modules.addCustomer)sender;
            //txtCustomer.Text = CustomerID;
            //this.ShowDialog();
        }

        public void GetCustomer()
        {
            con.Close();

            QuerySelect = "SELECT CONCAT(First_name ,' ',  Last_name) as Name FROM tblCustomers WHERE Customer_id = '" + cust + "'";
            con.Open();
            cmd = new SqlCommand(QuerySelect, con);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    txtViewCustomer.Enabled = false;
                    txtViewCustomer.Text = reader["Name"].ToString();
                }
            }
            con.Close();
        }

        //Generate ORNo
        void GetORNo()
        {
            try
            {

                int count = 0;
                string OR = count.ToString().PadLeft(4, '0');
                string ORNo;

                con.Open();
                QuerySelect = "SELECT MAX(OR_number) as id FROM tblOrders";
                cmd = new SqlCommand(QuerySelect, con);
                cmd.Parameters.AddWithValue("@OR", OR);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (reader["id"].ToString() != "")
                        {
                            ORNo = reader["id"].ToString();
                            count = int.Parse(ORNo) + 1;
                            txtORNumber.Text = count.ToString().PadLeft(4, '0');
                        }
                        else
                        {
                            count = 1;
                            txtORNumber.Text = count.ToString().PadLeft(4, '0');
                        }

                    }
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


        void SettlePayment()
        {
            if (String.IsNullOrEmpty(txtViewCustomer.Text) && String.IsNullOrWhiteSpace(txtViewCustomer.Text))
            {
                MessageBox.Show("Insert Customer!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(txtCash.Text) && String.IsNullOrWhiteSpace(txtCash.Text))
            {
                MessageBox.Show("Invalid Input!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtCash.Text != "")
            {
                result = MessageBox.Show("Confirm Payment?", "Settle Payment", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        //INSERT tblOrders
                        try
                        {

                            if (con.State == ConnectionState.Open)
                            {
                                con.Close();
                            }
                            con.Open();
                            for (int i = 0; i < dtFromSalesMgt.Rows.Count; i++)
                            {
                                total_quantity += Convert.ToInt32(dtFromSalesMgt.Rows[i][1].ToString());
                            }
                            QueryInsert = "INSERT INTO tblOrders(Customer_id, User_id, Transaction_number, OR_number, Order_date, Quantity, Total_discount, Total_cost, Cash, Senior_Citizen_number,PWD_number )" +
                            "VALUES(@cID, @uID, @transNo,@OR, @orderDate, @qty, @discount, @total, @cash, @senior, @PWD)";
                            cmd = new SqlCommand(QueryInsert, con);

                            cmd.Parameters.AddWithValue("@cID", cust);
                            cmd.Parameters.AddWithValue("@uID", frmLogin.GetUserID.ToString());
                            cmd.Parameters.AddWithValue("@transNo", transNo);
                            cmd.Parameters.AddWithValue("@OR", txtORNumber.Text);
                            cmd.Parameters.AddWithValue("@orderDate", DateTime.Now.Date.ToString("yyyy-MM-dd H:mm:ss"));
                            cmd.Parameters.AddWithValue("@qty", total_quantity);
                            cmd.Parameters.AddWithValue("@discount", discount_total);
                            cmd.Parameters.AddWithValue("@total", Convert.ToDouble(txtAmount.Text));
                            cmd.Parameters.AddWithValue("@cash", txtCash.Text.Replace(",", ""));

                            if (txtPWDOSCA.Visible == true && lblPWDORSC.Text == "SC #:")
                            {
                                cmd.Parameters.AddWithValue("@senior", txtPWDOSCA.Text);
                                cmd.Parameters.AddWithValue("@PWD", "");
                            }
                            else if (txtPWDOSCA.Visible == true && lblPWDORSC.Text == "PWD #:")
                            {
                                cmd.Parameters.AddWithValue("@senior", "");
                                cmd.Parameters.AddWithValue("@PWD", txtPWDOSCA.Text);
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@senior", txtPWDOSCA.Text);
                                cmd.Parameters.AddWithValue("@PWD", txtPWDOSCA.Text);
                            }

                            cmd.ExecuteNonQuery();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            con.Close();
                        }

                        //updateInventory
                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }
                        try
                        {
                            //get SKU
                            con.Open();
                            DESCRIPTION = new string[total_quantity];
                            //SKU = new string[total_quantity];
                            //DESCRIPTION = new string[total_quantity];
                            int ctr = 0;
                            for (int i = 0; i < dtFromSalesMgt.Rows.Count; i++)
                            {
                                QuerySelect = "SELECT TOP " + Convert.ToInt32(dtFromSalesMgt.Rows[i][1].ToString()) + " Item_id FROM tblInventories" +
                                    " WHERE Item_id = (SELECT Item_id FROM tblItems WHERE Description = @desc and Status = 'Stock In')";
                                cmd = new SqlCommand(QuerySelect, con);
                                cmd.Parameters.AddWithValue("@desc", dtFromSalesMgt.Rows[i][0].ToString());
                                adapter = new SqlDataAdapter(cmd);
                                DataTable dtNew = new DataTable();
                                adapter.Fill(dtNew);
                                for (int j = 0; j < Convert.ToInt32(dtFromSalesMgt.Rows[i][1].ToString()); j++)
                                {

                                    DESCRIPTION[ctr] = dtNew.Rows[j][0].ToString();

                                    ctr++;

                                }
                            }



                            //insert tblOrderDetails and Delete from inventory
                            NEW_SKU = new string[sku_list.Count];
                            for (int i = 0; i < NEW_SKU.Length; i++)
                            {
                                NEW_SKU[i] = sku_list[i];
                            }
                            for (int i = 0; i < DESCRIPTION.Length; i++)
                            {

                                QueryInsert = "INSERT INTO tblOrderDetails(Order_id, Item_id, SKU)" +
                                "VALUES((SELECT MAX(Order_id) FROM tblOrders),@description, @sku)";
                                cmd = new SqlCommand(QueryInsert, con);

                                cmd.Parameters.AddWithValue("@description", DESCRIPTION[i]);
                                cmd.Parameters.AddWithValue("@sku", NEW_SKU[i]);
                                cmd.ExecuteNonQuery();

                                QueryUpdate = "UPDATE tblInventories SET Status = 'Stock Out' WHERE SKU = @sku";
                                cmd = new SqlCommand(QueryUpdate, con);
                                cmd.Parameters.AddWithValue("@sku", NEW_SKU[i]);
                                cmd.ExecuteNonQuery();

                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                        }
                        finally
                        {
                            con.Close();
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                    }
                    finally
                    {
                        con.Close();
                    }
                    con.Open();
                    QueryInsert = "INSERT INTO tblReturns(Order_details_id, SKU, Return_quantity, Remarks, Return_date)(SELECT Order_details_id, SKU, Return_quantity, Remarks, Return_date FROM tblTemp_return)";
                    cmd = new SqlCommand(QueryInsert, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    con.Open();
                    QueryDelete = "TRUNCATE TABLE tblTemp_return";
                    cmd = new SqlCommand(QueryDelete, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Change: " + (Convert.ToDouble(txtCash.Text) - Convert.ToDouble(txtAmount.Text)).ToString("#,0.0"), "Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Transaction Finished!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GenerateReturnSlip();
                    this.Close();

                }
            }
        }

        public void insertTblReturn()
        {
            try
            {
                int count = 0;
                con.Open();
                QuerySelect = "SELECT COUNT(SKU) as 'count' FROM tblTemp_return";
                cmd = new SqlCommand(QuerySelect, con);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        count = Convert.ToInt32(reader["count"].ToString());
                    }
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
        }


        void GenerateReturnSlip()
        {
            ReturnSlip resibo = new ReturnSlip();

            /*------- Official Receipt Details ------*/

            // PHS1 - TERMINAL DETAILS

            TextObject cashier = (TextObject)resibo.ReportDefinition.Sections["PageHeaderSection1"].ReportObjects["cashierName"];
            cashier.Text = frmLogin.GetUserName.ToString();
            TextObject transNum = (TextObject)resibo.ReportDefinition.Sections["PageHeaderSection1"].ReportObjects["transNo"];
            transNum.Text = transNo;
            TextObject ORNum = (TextObject)resibo.ReportDefinition.Sections["PageHeaderSection1"].ReportObjects["ORNo"];
            ORNum.Text = txtORNumber.Text;


            //RFS1 - RETURNED ITEMS
            TextObject totalqtyreturned = (TextObject)resibo.ReportDefinition.Sections["ReportFooterSection1"].ReportObjects["totalQtyReturned"];
            totalqtyreturned.Text = total_quantity.ToString();        
            TextObject totalamtReturned = (TextObject)resibo.ReportDefinition.Sections["ReportFooterSection1"].ReportObjects["totalAmount"];
            totalamtReturned.Text = txtAmount.Text;


            //RFS1 - CUSTOMER DETAILS
            TextObject customer = (TextObject)resibo.ReportDefinition.Sections["ReportFooterSection1"].ReportObjects["CustomerName"];
            customer.Text = txtViewCustomer.Text;
            TextObject cusNo = (TextObject)resibo.ReportDefinition.Sections["ReportFooterSection1"].ReportObjects["cusNO"];
            cusNo.Text = txtViewCustomer.Text;


            //DETAILS - RETURNED ITEM DETAILS
            string[,] OrderReturntable = new string[ReturnedItemDesc.Length, 4];
            for (int i = 0; i < ReturnedItemDesc.Length; i++)
            {
                OrderReturntable[i, 0] = ReturnedItemDesc[i];
                OrderReturntable[i, 1] = ReturnedQty[i].ToString();
                OrderReturntable[i, 2] = ReturnedPrice[i].ToString();
                OrderReturntable[i, 3] = Remarks[i];
            }

            DataTable OrderReturnDt = new DataTable();

            OrderReturnDt.Columns.Add("ReturnDescription", typeof(string));
            OrderReturnDt.Columns.Add("ReturnQty", typeof(string));
            OrderReturnDt.Columns.Add("ReturnPrice", typeof(string));
            OrderReturnDt.Columns.Add("ReturnRemarks", typeof(string));

            for (int outerIndex = 0; outerIndex < ReturnedItemDesc.Length; outerIndex++)
            {
                DataRow newRow = OrderReturnDt.NewRow();
                for (int innerIndex = 0; innerIndex < 4; innerIndex++)
                {

                    newRow[innerIndex] = OrderReturntable[outerIndex, innerIndex];

                }

                OrderReturnDt.Rows.Add(newRow);
            }

            resibo.Database.Tables["return_details"].SetDataSource(OrderReturnDt);

            frmPrintReceipt.getform.Show();
            frmPrintReceipt.getform.crystalReportViewer1.ReportSource = null;
            frmPrintReceipt.getform.crystalReportViewer1.ReportSource = resibo;

            //GenerateReplaceSlip();
            this.DialogResult = DialogResult.OK;
        }

        void GenerateReplaceSlip()
        {
            ReplacedSlip resibo = new ReplacedSlip();

            /*------- Official Receipt Details ------*/

            // PHS1 - TERMINAL DETAILS

            TextObject cashier = (TextObject)resibo.ReportDefinition.Sections["PageHeaderSection1"].ReportObjects["cashierName"];
            cashier.Text = frmLogin.GetUserName.ToString();
            TextObject transNum = (TextObject)resibo.ReportDefinition.Sections["PageHeaderSection1"].ReportObjects["transNo"];
            transNum.Text = transNo;
            TextObject ORNum = (TextObject)resibo.ReportDefinition.Sections["PageHeaderSection1"].ReportObjects["ORNo"];
            ORNum.Text = txtORNumber.Text;


            //RFS1 - REPLACED ITEMS
            TextObject totalqtyreplaced = (TextObject)resibo.ReportDefinition.Sections["ReportFooterSection1"].ReportObjects["totalQtyReplaced"];
            totalqtyreplaced.Text = total_quantity.ToString();
            TextObject totalamt = (TextObject)resibo.ReportDefinition.Sections["ReportFooterSection1"].ReportObjects["totalAmount"];
            totalamt.Text = txtAmount.Text;
            TextObject amtpaid = (TextObject)resibo.ReportDefinition.Sections["ReportFooterSection1"].ReportObjects["cash"];
            amtpaid.Text = txtCash.Text;
            TextObject change = (TextObject)resibo.ReportDefinition.Sections["ReportFooterSection1"].ReportObjects["change"];
            change.Text = (Convert.ToDouble(txtCash.Text) - Convert.ToDouble(txtAmount.Text)).ToString("#,0.00");


            //RFS1 - CUSTOMER DETAILS
            TextObject customer = (TextObject)resibo.ReportDefinition.Sections["ReportFooterSection1"].ReportObjects["CustomerName"];
            customer.Text = txtViewCustomer.Text;
            TextObject cusNo = (TextObject)resibo.ReportDefinition.Sections["ReportFooterSection1"].ReportObjects["cusNO"];
            cusNo.Text = txtViewCustomer.Text;


            //DETAILS - REPLACED ITEM DETAILS
            string[,] Replacedtable = new string[ReplacedItemDesc.Length, 3];
            for (int i = 0; i < ReplacedItemDesc.Length; i++)
            {
                Replacedtable[i, 0] = ReplacedItemDesc[i];
                Replacedtable[i, 1] = ReplacedQty[i].ToString();
                Replacedtable[i, 2] = ReplacedPrice[i].ToString();
            }

            DataTable ReplaceDt = new DataTable();

            ReplaceDt.Columns.Add("ReplacedDescription", typeof(string));
            ReplaceDt.Columns.Add("ReplacedQty", typeof(string));
            ReplaceDt.Columns.Add("ReplacedPrice", typeof(string));

            for (int outerIndex = 0; outerIndex < ReplacedItemDesc.Length; outerIndex++)
            {
                DataRow newRow = ReplaceDt.NewRow();
                for (int innerIndex = 0; innerIndex < 3; innerIndex++)
                {

                    newRow[innerIndex] = Replacedtable[outerIndex, innerIndex];

                }
                ReplaceDt.Rows.Add(newRow);
            }

            resibo.Database.Tables["replace_details"].SetDataSource(ReplaceDt);

            frmPrintReceipt.getform.Show();
            frmPrintReceipt.getform.crystalReportViewer1.ReportSource = null;
            frmPrintReceipt.getform.crystalReportViewer1.ReportSource = resibo;

            this.DialogResult = DialogResult.OK;

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void autoCompleteCustomer()
        {
            con.Close();
            QuerySelect = "SELECT CONCAT(First_name ,' ',  Last_name) as Name FROM tblCustomers " +
                "WHERE First_name LIKE '" + txtViewCustomer.Text + "%' OR Last_name LIKE '" + txtViewCustomer.Text + "%'";
            cmd = new SqlCommand(QuerySelect, con);
            con.Open();
            reader = cmd.ExecuteReader();
            AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                MyCollection.Add(reader.GetString(0));
            }
            txtViewCustomer.AutoCompleteCustomSource = MyCollection;
            con.Close();
           
        }

        public void frmPayment_Load(object sender, EventArgs e)
        {
            //autoCompleteCustomer();
            GetCustomer();
            btnAddCustomer.Enabled = false;
        }

        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!txtCash.Text.ToString().Equals(string.Empty)) {
                    txtAmount.Text = txtAmount.Text;   
                    double amount = double.Parse(txtAmount.Text.ToString());
                    double cash = double.Parse(txtCash.Text.ToString());
                    if (amount>cash)
                    {
                        btnConfirm.Enabled = false;
                    }
                    else
                    {
                        btnConfirm.Enabled = true;
                    }
                }
                else
                {
                    btnConfirm.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace + "\n" + ex.StackTrace);
            }
        }

        private void frmPayment_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.DialogResult = DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            SettlePayment();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            //this.Close();
            addNewCustomer.FormClosed += new FormClosedEventHandler(Form_Closed);
            addNewCustomer.ShowDialog();      

        }

        private void txtViewCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // With Discount Code
                string phrase = txtViewCustomer.Text;
                string[] words = phrase.Split(' ');
                
                QuerySelect = "SELECT Customer_id From tblCustomers WHERE First_name LIKE '%"+words[0]+"%' OR Last_name LIKE '%"+words[1]+"%'";
                cmd = new SqlCommand(QuerySelect, con);
                con.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    if (isReturn)
                    {
                        amount = Convert.ToDouble(txtAmount.Text);
                        //discount = Convert.ToDouble(dt.Rows[0][2].ToString());
                        //discount_total = amount * discount;
                        total = amount;
                        txtAmount.Text = total.ToString();
                    }
                    else
                    {
                        dt.Clear();
                        customerID = reader.GetInt32(0);
                        QuerySelect = "SELECT * FROM viewDiscount WHERE [Customer ID] = '" + customerID + "'";
                        cmd = new SqlCommand(QuerySelect, con);
                        con.Close();
                        con.Open();
                        adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);
                        cmd.ExecuteNonQuery();
                        con.Close();


                        //DiscountCodeTextbox

                        //if (dt.Rows[0][1].ToString() == "SC01")
                        //{
                        //    lblPWDORSC.Visible = true;
                        //    lblPWDORSC.Text = "SC #:";
                        //    txtPWDOSCA.Visible = true;

                        //    amount = Convert.ToDouble(txtAmount.Text);
                        //    discount = Convert.ToDouble(dt.Rows[0][2].ToString());
                        //    discount_total = amount * discount;
                        //    total = amount - discount_total;
                        //    txtAmount.Text = total.ToString();
                        //    txtDiscountAmount.Text = discount_total.ToString();
                        //    txtDiscountPer.Text = "20%";
                        //}
                        //else if (dt.Rows[0][1].ToString() == "PWD01")
                        //{
                        //    lblPWDORSC.Visible = true;
                        //    lblPWDORSC.Text = "PWD #:";
                        //    txtPWDOSCA.Visible = true;

                        //    amount = Convert.ToDouble(txtAmount.Text);
                        //    discount = Convert.ToDouble(dt.Rows[0][2].ToString());
                        //    discount_total = amount * discount;
                        //    total = amount - discount_total;
                        //    txtAmount.Text = total.ToString();
                        //    txtDiscountAmount.Text = "20%";
                        //}
                        //else if (dt.Rows[0][1].ToString() == "LC01")
                        //{
                        //    lblPWDORSC.Visible = false;
                        //    txtPWDOSCA.Visible = false;

                        //    amount = Convert.ToDouble(txtAmount.Text);
                        //    discount = Convert.ToDouble(dt.Rows[0][2].ToString());
                        //    discount_total = amount * discount;
                        //    total = amount - discount_total;
                        //    txtAmount.Text = total.ToString();
                        //    txtDiscountAmount.Text = "10%";
                        //}
                        //else if (dt.Rows[0][1].ToString() == "NC01")
                        //{
                        //    loyaltyCheck();
                        //}


                        //recompute amount

                        //amount = Convert.ToDouble(txtAmount.Text);
                        //discount = Convert.ToDouble(dt.Rows[0][2].ToString());
                        //discount_total = amount * discount;
                        //total = amount - discount_total;
                        //txtAmount.Text = total.ToString();
                    }

                }



                con.Close();
                txtViewCustomer.Enabled = false;
                txtCash.Focus();
            }
        }

        public void loyaltyCheck()  
        {
            //double totalCost;

            ////check for loyal customer*
            //QuerySelect = "SELECT total_transaction, total_cost FROM tblDiscounts WHERE Discount_code = 'LC01'";
            //cmd = new SqlCommand(QuerySelect, con);
            //con.Open();
            //adapter = new SqlDataAdapter(cmd);
            //adapter.Fill(dt);
            //cmd.ExecuteNonQuery();
            //int trans = Convert.ToInt32(dt.Rows[1][3].ToString());
            //double cost = Convert.ToDouble(dt.Rows[1][4].ToString());
            //con.Close();


            //string QuerySelect1 = "SELECT COUNT(User_id), SUM(Total_cost) as 'Sum' From tblOrders WHERE [Customer_id] = '" + customerID + "'";
            //SqlCommand cmd1 = new SqlCommand(QuerySelect1, con);
            //con.Open();
            //SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
            //DataTable newDt = new DataTable();
            //adapter1.Fill(newDt);
            //cmd1.ExecuteNonQuery();
            //con.Close();
            //int transactionCount = Convert.ToInt32(newDt.Rows[0][0].ToString());
            //if (newDt.Rows[0][1].ToString() == "")
            //{
            //    totalCost = 0;
            //}
            //else
            //{
            //    totalCost = Convert.ToDouble(newDt.Rows[0][1].ToString());
            //}
            
            //if (transactionCount >= trans && totalCost >= cost)
            //{
            //    string QuerySelect2 = "SELECT Discount_Percentage FROM tblDiscounts";
            //    SqlCommand cmd2 = new SqlCommand(QuerySelect2, con);
            //    con.Open();
            //    SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
            //    DataTable newDt1 = new DataTable();
            //    adapter2.Fill(newDt1);
            //    cmd2.ExecuteNonQuery();
            //    con.Close();
            //    double loyal_customer = Convert.ToDouble(newDt1.Rows[0][0].ToString());
            //    double normal_customer = Convert.ToDouble(newDt1.Rows[1][0].ToString());
            //    double pwd = Convert.ToDouble(newDt1.Rows[2][0].ToString());
            //    double senior = Convert.ToDouble(newDt1.Rows[3][0].ToString());

            //    //update discount status of customer
            //    QueryUpdate = "Update tblCustomers SET Discount_code = 'LC01' WHERE Customer_id = '"+customerID+"'";
            //    cmd = new SqlCommand(QueryUpdate, con);
            //    con.Open();
            //    cmd.ExecuteNonQuery();


            //    MessageBox.Show(txtViewCustomer.Text + " is now a loyal customer. Discount is applied.");
            //    amount = Convert.ToDouble(txtAmount.Text);
            //    discount = Convert.ToDouble(loyal_customer);
            //    discount_total = amount * discount;
            //    total = amount - discount_total;
            //    txtAmount.Text = total.ToString();
            //    txtDiscountAmount.Text = discount_total.ToString();
            //}
            //else
            //{
            //    amount = Convert.ToDouble(txtAmount.Text);
            //    //discount = Convert.ToDouble(dt.Rows[0][2].ToString());
            //    //discount_total = amount * discount;
            //    total = amount;
            //    txtAmount.Text = total.ToString();
            //    txtDiscountAmount.Text = discount_total.ToString();
            //}
            //con.Close();
        }

        private void btnGenerateOR_Click(object sender, EventArgs e)
        {
            GetORNo();
        }

        private void txtPWDOSCA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}

