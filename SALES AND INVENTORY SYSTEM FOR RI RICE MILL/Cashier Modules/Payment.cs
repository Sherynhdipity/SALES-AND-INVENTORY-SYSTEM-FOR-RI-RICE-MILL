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
                                QueryInsert = "INSERT INTO tblOrderDetails(Order_id, SKU, Transaction_number)" +
                                "VALUES((SELECT MAX(Order_id) FROM tblOrders), @sku, @transNo)";

                                cmd = new SqlCommand(QueryInsert, con);
                                cmd.Parameters.AddWithValue("@sku", SKU[i]);
                                cmd.Parameters.AddWithValue("@transNo", transNo);
                                cmd.ExecuteNonQuery();

                                QueryDelete = "DELETE FROM tblInventories WHERE SKU = @sku";
                                cmd = new SqlCommand(QueryDelete, con);
                                cmd.Parameters.AddWithValue("@sku", SKU[i]);
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
                txtAmount.Enabled = false;
                txtCash.Focus();
            }
        }
    }
}

