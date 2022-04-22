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
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            
            InitializeComponent();
            addNewCustomer.FormClosed += new FormClosedEventHandler(Form_Closed);
        }
        //start mods
        public  DataTable dtFromSalesMgt;
        public string transNo = "";
        public  void storeDt(DataTable tempDT)
        {
            dtFromSalesMgt = tempDT;
        }
        //end mods

        Cashier_Modules.addCustomer addCustomer = new Cashier_Modules.addCustomer();
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
        public double discount_total;
        public double total;
        public int total_quantity = 0;
        public string[] SKU;
        frmSalesManagement sales = new frmSalesManagement();
        
        private int customerID;

        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        void Form_Closed(object sender, FormClosedEventArgs e)
        {
            autoCompleteCustomer();
            //Cashier_Modules.addCustomer addCustomer = (Cashier_Modules.addCustomer)sender;
            //txtCustomer.Text = CustomerID;
            //this.ShowDialog();
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
                            QueryInsert = "INSERT INTO tblOrders(Customer_id, User_id, Order_date, Quantity, Total_discount, Total_cost)" +
                            "VALUES('" + CustomerID + "','" + frmLogin.GetUserID.ToString() + "', '" + DateTime.Now.Date.ToString("yyyy-MM-dd H:mm:ss") + "', '" + total_quantity + "', '" + discount_total + "', '" + total + "')";
                            cmd = new SqlCommand(QueryInsert, con);
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
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
                            SKU = new string[total_quantity];
                            int ctr = 0;
                            for (int i = 0; i < dtFromSalesMgt.Rows.Count; i++)
                            {
                                QuerySelect = "SELECT TOP " + Convert.ToInt32(dtFromSalesMgt.Rows[i][1].ToString()) + " SKU FROM tblInventories" +
                                    " WHERE Item_id = (SELECT Item_id FROM tblItems WHERE Description = '" + dtFromSalesMgt.Rows[i][0].ToString() + "')";
                                cmd = new SqlCommand(QuerySelect, con);
                                adapter = new SqlDataAdapter(cmd);
                                DataTable dtNew = new DataTable();
                                adapter.Fill(dtNew);
                                for (int j =0; j < Convert.ToInt32(dtFromSalesMgt.Rows[i][1].ToString()); j++)
                                {
                                    SKU[ctr] = dtNew.Rows[j][0].ToString();
                                    ctr ++;
                                }
                            }

                            //insert tblOrderDetails and Delete from inventory
                            for (int i = 0; i < SKU.Length; i++)
                            {
                                QueryInsert = "INSERT INTO tblOrderDetails(Inventory_id, Order_id,Transaction_number)" +
                                "VALUES((SELECT Inventory_id FROM tblInventories WHERE SKU = '" + SKU[i] + "'),(SELECT MAX(Order_id) FROM tblOrders), '" + transNo + "')";
                                cmd = new SqlCommand(QueryInsert, con);
                                cmd.ExecuteNonQuery();

                                QueryDelete = "DELETE FROM tblInventories WHERE SKU = '"+SKU[i]+"'";
                                cmd = new SqlCommand(QueryDelete, con);
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
   



                            //try
                            //{

                            //    if (con.State == ConnectionState.Open)
                            //    {
                            //        con.Close();
                            //    }

                            //    con.Open();

                            //    QueryInsert = "insert into tblTransactions values(" + transNo.Trim().ToString() + ",'" + DateTime.Now.Date.ToString("yyyy-MM-dd H:mm:ss") + "'," +
                            //           "(select max(PurchaseID) from tblPurchases),(SELECT UserID from tblUsers where [Name] LIKE('" + frmLogin.GetUserName.ToString() + "')))";
                            //    cmd = new SqlCommand(QueryInsert, con);
                            //    cmd.ExecuteNonQuery();
                            //    Console.WriteLine("transaction inserted");


                            //}
                            //catch (Exception ex)
                            //{

                            //    MessageBox.Show(ex.Message + "\n" + ex.StackTrace);

                            //}
                            //finally
                            //{

                            //    con.Close();

                            //}


                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                        }
                        finally
                        {
                            con.Close();
                        }

                    //for (int i = 0; i < dtFromSalesMgt.Rows.Count; i++)
                    //{
                    //    ////INSERT tblPurchases

                    //    try
                    //    {

                    //        if (con.State == ConnectionState.Open)
                    //        {
                    //            con.Close();
                    //        }

                    //        con.Open();

                    //        QueryInsert = "INSERT INTO [dbo].[tblPurchases]" +
                    //            "([PurchaseDate],[InvoiceNumber],[QuantityBought],[ProductID],[DiscountID],[PaymentID],[VAT])" +
                    //            "VALUES" +
                    //            "('" + DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") +
                    //            "'," + transNo +
                    //            "," + dtFromSalesMgt.Rows[i][3].ToString() +
                    //            ",(SELECT ProductID from tblProducts where ProductCode like('" + dtFromSalesMgt.Rows[i][0].ToString() + "'))," +
                    //            "1," +
                    //            "(SELECT MAX(PaymentID) as pID from tblPayments)," +
                    //            "0.12)";
                    //       // QueryInsert = "INSERT INTO tblPurchases(PurchaseDate ,InvoiceNumber, QuantityBought, ProductID, DiscountID, PaymentID, VAT) VALUES ('" + sales.lblTransDate.Text + "', '" + sales.lblIVno.Text + "','" + sales.txtQuantityCount.Text + "','" + "', (Select ProductID from tblProducts Where ProductCode = '" + dtFromSalesMgt.Rows[0][0].ToString() + "'), '" ) ";
                    //        cmd = new SqlCommand(QueryInsert, con);
                    //        cmd.ExecuteNonQuery();
                    //        Console.WriteLine("Purchases inserted");


                    //    }
                    //    catch (Exception ex)
                    //    {

                    //        MessageBox.Show(ex.Message + "\n" + ex.StackTrace);

                    //    }
                    //    finally
                    //    {

                    //        con.Close();

                    //    }


                    //    //stockout

                    //    try
                    //    {
                    //            string temp = "";
                    //            int tempctr = 0;
                    //            string temp2 = "";
                    //            int temp2ctr = 0;
                    //            string temp3 = "";
                    //            int temp3ctr = 0;
                    //            string query = "select TOP " + dtFromSalesMgt.Rows[i][3].ToString() + " tblBatchProduct.BatchID, tblStockin.ProductID FROM tblBatchProduct" +
                    //            " full join tblStockin on tblBatchProduct.BatchID = tblStockin.BatchID where tblStockin.ProductID =" +
                    //            "  (SELECT ProductID from tblProducts where ProductCode like('" + dtFromSalesMgt.Rows[i][0].ToString() + "')) " +
                    //            "AND UPPER(tblBatchProduct.Status) like('IN')";
                    //            con.Open();
                    //            SqlDataReader reader = new SqlCommand(query, con).ExecuteReader();
                    //            while (reader.Read())
                    //            {
                    //                if (temp.Equals(string.Empty))
                    //                {
                    //                    temp = reader["BatchID"].ToString();
                    //                    tempctr++;
                    //                }
                    //                else
                    //                {
                    //                    if (temp.Equals(reader["BatchID"].ToString()))
                    //                    {
                    //                        tempctr++;
                    //                    }
                    //                    else if (!temp.Equals(reader["BatchID"].ToString()) && temp2.Equals(string.Empty))
                    //                    {
                    //                        temp2 = reader["BatchID"].ToString();
                    //                        temp2ctr++;
                    //                    }
                    //                    else if (!temp.Equals(reader["BatchID"].ToString()) && !temp2.Equals(string.Empty))
                    //                    {
                    //                        if (temp2.Equals(reader["BatchID"].ToString()))
                    //                        {
                    //                            tempctr++;
                    //                        }
                    //                        else if (!temp2.Equals(reader["BatchID"].ToString()) && temp3.Equals(string.Empty))
                    //                        {
                    //                            temp3 = reader["BatchID"].ToString();
                    //                            temp3ctr++;
                    //                        }
                    //                        else if (!temp2.Equals(reader["BatchID"].ToString()) && !temp3.Equals(string.Empty))
                    //                        {

                    //                            temp3ctr++;
                    //                        }
                    //                    }
                    //                }
                    //            }
                                
                    //        try
                    //        {

                    //            if (con.State == ConnectionState.Open)
                    //            {
                    //                con.Close();
                    //            }

                    //            con.Open();

                    //            QueryInsert = "INSERT INTO tblStockout ([ProductID],[QtyStockedOut],[PurchaseID],[StockoutDate],[BatchID])" +
                    //                " VALUES(" + "(SELECT ProductID from tblProducts where ProductCode like('" + dtFromSalesMgt.Rows[i][0].ToString() + "')), " +
                    //                "'" + tempctr.ToString() + "', (select max(PurchaseID) from tblPurchases),'" + DateTime.Now.Date.ToString("yyyy-MM-dd H:mm:ss") + "'" +
                    //                ", " + temp + ")";
                    //            cmd = new SqlCommand(QueryInsert, con);
                    //            cmd.ExecuteNonQuery();


                    //        }
                    //        catch (Exception ex)
                    //        {

                    //            MessageBox.Show(ex.Message);

                    //        }
                    //        finally
                    //        {

                    //            con.Close();

                    //        }

                    //            for (int ctr = 0; ctr < tempctr; ctr++)
                    //            {

                    //            try
                    //            {

                    //                if (con.State == ConnectionState.Open)
                    //                {
                    //                    con.Close();
                    //                }

                    //                con.Open();

                                    
                    //                QueryInsert = "UPDATE tblBatchProduct SET Status = 'OUT'" +
                    //                    " WHERE BatchID = " + temp +
                    //                    " AND ID=(SELECT MIN(ID) FROM tblBatchProduct WHERE BatchID = " + temp + " AND UPPER(Status) = 'IN')";
                    //                cmd = new SqlCommand(QueryInsert, con);
                    //                cmd.ExecuteNonQuery();


                    //            }
                    //            catch (Exception ex)
                    //            {

                    //                MessageBox.Show(ex.Message);

                    //            }
                    //            finally
                    //            {

                    //                con.Close();

                    //            }

                    //        }

                    //            if (!temp2.Equals(string.Empty))
                    //            {

                    //            try
                    //            {

                    //                if (con.State == ConnectionState.Open)
                    //                {
                    //                    con.Close();
                    //                }

                    //                con.Open();

                    //                QueryInsert = "INSERT INTO tblStockout ([ProductID],[QtyStockedOut],[PurchaseID],[StockoutDate],[BatchID])" +
                    //                   " VALUES(" + "(SELECT ProductID from tblProducts where ProductCode like('" + dtFromSalesMgt.Rows[i][0].ToString() + "')), " +
                    //                   "'" + temp2ctr.ToString() + "', (select max(PurchaseID) from tblPurchases),'" + DateTime.Now.Date.ToString("yyyy-MM-dd H:mm:ss") + "'" +
                    //                   ", " + temp2 + ")";
                    //                cmd = new SqlCommand(QueryInsert, con);
                    //                cmd.ExecuteNonQuery();


                    //            }
                    //            catch (Exception ex)
                    //            {

                    //                MessageBox.Show(ex.Message);

                    //            }
                    //            finally
                    //            {

                    //                con.Close();

                    //            }


                    //            for (int ctr = 0; ctr < temp2ctr; ctr++)
                    //                {

                    //                try
                    //                {

                    //                    if (con.State == ConnectionState.Open)
                    //                    {
                    //                        con.Close();
                    //                    }

                    //                    con.Open();

                    //                    QueryInsert = "UPDATE tblBatchProduct SET Status = 'OUT'" +
                    //                         " WHERE BatchID = " + temp2 +
                    //                         " AND ID=(SELECT MIN(ID) FROM tblBatchProduct WHERE BatchID = " + temp2 + " AND UPPER(Status) = 'IN')";
                    //                    cmd = new SqlCommand(QueryInsert, con);
                    //                    cmd.ExecuteNonQuery();


                    //                }
                    //                catch (Exception ex)
                    //                {

                    //                    MessageBox.Show(ex.Message);

                    //                }
                    //                finally
                    //                {

                    //                    con.Close();

                    //                }

                    //            }
                    //            }
                    //            if (!temp3.Equals(string.Empty))
                    //            {

                    //            try
                    //            {

                    //                if (con.State == ConnectionState.Open)
                    //                {
                    //                    con.Close();
                    //                }

                    //                con.Open();

                    //                QueryInsert = "INSERT INTO tblStockout ([ProductID],[QtyStockedOut],[PurchaseID],[StockoutDate],[BatchID])" +
                    //                   " VALUES(" + "(SELECT ProductID from tblProducts where ProductCode like('" + dtFromSalesMgt.Rows[i][0].ToString() + "')), " +
                    //                   "'" + temp3ctr.ToString() + "', (select max(PurchaseID) from tblPurchases),'" + DateTime.Now.Date.ToString("yyyy-MM-dd H:mm:ss") + "'" +
                    //                   ", " + temp3 + ")";
                    //                cmd = new SqlCommand(QueryInsert, con);
                    //                cmd.ExecuteNonQuery();


                    //            }
                    //            catch (Exception ex)
                    //            {

                    //                MessageBox.Show(ex.Message);

                    //            }
                    //            finally
                    //            {

                    //                con.Close();

                    //            }


                    //            for (int ctr = 0; ctr < temp3ctr; ctr++)
                    //                {

                    //                try
                    //                {

                    //                    if (con.State == ConnectionState.Open)
                    //                    {
                    //                        con.Close();
                    //                    }

                    //                    con.Open();


                    //                    QueryInsert = "UPDATE tblBatchProduct SET Status = 'OUT'" +
                    //                        " WHERE BatchID = " + temp3 +
                    //                        " AND ID=(SELECT MIN(ID) FROM tblBatchProduct WHERE BatchID = " + temp3 + " AND UPPER(Status) = 'IN')";
                    //                    cmd = new SqlCommand(QueryInsert, con);
                    //                    cmd.ExecuteNonQuery();


                    //                }
                    //                catch (Exception ex)
                    //                {

                    //                    MessageBox.Show(ex.Message);

                    //                }
                    //                finally
                    //                {

                    //                    con.Close();

                    //                }

                    //            }
                    //            }
                                



                    //        }
                    //        catch (Exception ex)
                    //        {
                    //            MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                    //        }
                    //        finally
                    //        {
                    //            con.Close();
                    //        }
                    //    }//for(int i = 0; i < dtFromSalesMgt.Rows.Count; i++) end
                    MessageBox.Show("Change: "+( Convert.ToDouble(txtCash.Text)-Convert.ToDouble(txtAmount.Text)).ToString("#,0.0"), "Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Transaction Finished!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //printreciept();
                    this.Close();

                }
            }
        }


        private void printreciept()
        {
            PrintReciept pr = new PrintReciept();
            pr.ShowDialog();
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

        private void frmPayment_Load(object sender, EventArgs e)
        {
            autoCompleteCustomer();
        }

        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
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
            this.DialogResult = DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            //Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            SettlePayment();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            //this.Close();
            frmAddNewCustomer addNewCustomer = new frmAddNewCustomer();
            addNewCustomer.ShowDialog();
            

        }

        private void txtViewCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string phrase = txtViewCustomer.Text;
                string[] words = phrase.Split(' ');
                
                QuerySelect = "SELECT Customer_id From tblCustomers WHERE First_name LIKE '%"+words[0]+"%' OR Last_name LIKE '%"+words[1]+"%'";
                cmd = new SqlCommand(QuerySelect, con);
                con.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    customerID = reader.GetInt32(0);
                    QuerySelect = "SELECT * FROM viewDiscount WHERE [Customer ID] = '" + customerID + "'";
                    cmd = new SqlCommand(QuerySelect, con);
                    con.Close();
                    con.Open();
                    adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);


                    //recompute amount
                     amount = Convert.ToDouble(txtAmount.Text);
                     discount = Convert.ToDouble(dt.Rows[0][2].ToString());
                     discount_total = amount * discount;
                     total = amount - discount_total;
                     txtAmount.Text = total.ToString();
                }
                con.Close();
                txtCash.Focus();
            }
        }
    }
}

