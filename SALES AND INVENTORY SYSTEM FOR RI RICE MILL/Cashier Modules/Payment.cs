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
        }
        //start mods
        public  DataTable dtFromSalesMgt;
        public string transNo = "";
        public  void storeDt(DataTable tempDT)
        {
            dtFromSalesMgt = tempDT;
        }
        //end mods


        public static SqlConnection con = new SqlConnection(DBConnection.con);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader reader;
        public static SqlDataAdapter adapter;
        public static DataTable dt = new DataTable();
        public static DialogResult result;
        public static string QueryInsert;
        public static string QuerySelect;
        public static string QueryUpdate;
        frmSalesManagement sales = new frmSalesManagement();

        void SettlePayment()
        {
            if (String.IsNullOrEmpty(txtCash.Text) && String.IsNullOrWhiteSpace(txtCash.Text))
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
                            //INSERT tblPayments
                            con.Open();
                            QueryInsert = "INSERT INTO tblPayments(TotalAmount ,AmountPaid)VALUES (" + Convert.ToDouble(txtAmount.Text.Trim().ToString()).ToString() + ", " + Convert.ToDouble(txtCash.Text.Trim().ToString()).ToString() + ") ";
                            cmd = new SqlCommand(QueryInsert, con);
                            cmd.ExecuteNonQuery();
                            con.Close();

                        for (int i = 0; i < dtFromSalesMgt.Rows.Count; i++)
                        {
                            ////INSERT tblPurchases
                            con.Open();
                            QueryInsert = "INSERT INTO [dbo].[tblPurchases]" +
                                "([PurchaseDate],[InvoiceNumber],[QuantityBought],[ProductID],[DiscountID],[PaymentID],[VAT])" +
                                "VALUES" +
                                "('" + DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") +
                                "'," + transNo +
                                "," + dtFromSalesMgt.Rows[i][3].ToString() +
                                ",(SELECT ProductID from tblProducts where ProductCode like('" + dtFromSalesMgt.Rows[i][0].ToString() + "'))," +
                                "1," +
                                "(SELECT MAX(PaymentID) as pID from tblPayments)," +
                                "0.12)";
                            //QueryInsert = "INSERT INTO tblPurchases(PurchaseDate ,InvoiceNumber, QuantityBought, ProductID, DiscountID, PaymentID, VAT) VALUES ('" + sales.lblTransDate.Text + "', '" + sales.lblIVno.Text + "','" + sales.txtQuantityCount.Text + "','" + "', (Select ProductID from tblProducts Where ProductCode = '" + dtFromSalesMgt.Rows[0][0].ToString() + "'), '" ) ";
                            cmd = new SqlCommand(QueryInsert, con);
                            cmd.ExecuteNonQuery();
                            con.Close();

                            //stockout

                            try
                            {
                                string temp = "";
                                int tempctr = 0;
                                string temp2 = "";
                                int temp2ctr = 0;
                                string temp3 = "";
                                int temp3ctr = 0;
                                string query = "select TOP " + dtFromSalesMgt.Rows[i][3].ToString() + " tblBatchProduct.BatchID, tblStockin.ProductID FROM tblBatchProduct" +
                                " full join tblStockin on tblBatchProduct.BatchID = tblStockin.BatchID where tblStockin.ProductID =" +
                                "  (SELECT ProductID from tblProducts where ProductCode like('" + dtFromSalesMgt.Rows[i][0].ToString() + "')) " +
                                "AND UPPER(tblBatchProduct.Status) like('IN')";
                                con.Open();
                                SqlDataReader reader = new SqlCommand(query, con).ExecuteReader();
                                while (reader.Read())
                                {
                                    if (temp.Equals(string.Empty))
                                    {
                                        temp = reader["BatchID"].ToString();
                                        tempctr++;
                                    }
                                    else
                                    {
                                        if (temp.Equals(reader["BatchID"].ToString()))
                                        {
                                            tempctr++;
                                        }
                                        else if (!temp.Equals(reader["BatchID"].ToString()) && temp2.Equals(string.Empty))
                                        {
                                            temp2 = reader["BatchID"].ToString();
                                            temp2ctr++;
                                        }
                                        else if (!temp.Equals(reader["BatchID"].ToString()) && !temp2.Equals(string.Empty))
                                        {
                                            if (temp2.Equals(reader["BatchID"].ToString()))
                                            {
                                                tempctr++;
                                            }
                                            else if (!temp2.Equals(reader["BatchID"].ToString()) && temp3.Equals(string.Empty))
                                            {
                                                temp3 = reader["BatchID"].ToString();
                                                temp3ctr++;
                                            }
                                            else if (!temp2.Equals(reader["BatchID"].ToString()) && !temp3.Equals(string.Empty))
                                            {

                                                temp3ctr++;
                                            }
                                        }
                                    }
                                }
                                con.Close();


                                con.Open();

                                QueryInsert = "INSERT INTO tblStockout ([ProductID],[QtyStockedOut],[PurchaseID],[StockoutDate],[BatchID])" +
                                    " VALUES(" + "(SELECT ProductID from tblProducts where ProductCode like('" + dtFromSalesMgt.Rows[i][0].ToString() + "')), " +
                                    "'" + tempctr.ToString() + "', (select max(PurchaseID) from tblPurchases),'" + DateTime.Now.Date.ToString("yyyy-MM-dd H:mm:ss") + "'" +
                                    ", " + temp + ")";
                                cmd = new SqlCommand(QueryInsert, con);
                                cmd.ExecuteNonQuery();
                                con.Close();

                                for (int ctr = 0; ctr < tempctr; ctr++)
                                {
                                    con.Open();

                                    QueryInsert = "UPDATE tblBatchProduct SET Status = 'OUT'" +
                                        " WHERE BatchID = " + temp +
                                        " AND ID=(SELECT MIN(ID) FROM tblBatchProduct WHERE BatchID = " + temp + " AND UPPER(Status) = 'IN')";
                                    cmd = new SqlCommand(QueryInsert, con);
                                    cmd.ExecuteNonQuery();
                                    con.Close();
                                }

                                if (!temp2.Equals(string.Empty))
                                {
                                    con.Open();

                                    QueryInsert = "INSERT INTO tblStockout ([ProductID],[QtyStockedOut],[PurchaseID],[StockoutDate],[BatchID])" +
                                        " VALUES(" + "(SELECT ProductID from tblProducts where ProductCode like('" + dtFromSalesMgt.Rows[i][0].ToString() + "')), " +
                                        "'" + temp2ctr.ToString() + "', (select max(PurchaseID) from tblPurchases),'" + DateTime.Now.Date.ToString("yyyy-MM-dd H:mm:ss") + "'" +
                                        ", " + temp2 + ")";
                                    cmd = new SqlCommand(QueryInsert, con);
                                    cmd.ExecuteNonQuery();
                                    con.Close();

                                    for (int ctr = 0; ctr < temp2ctr; ctr++)
                                    {
                                        con.Open();

                                        QueryInsert = "UPDATE tblBatchProduct SET Status = 'OUT'" +
                                            " WHERE BatchID = " + temp2 +
                                            " AND ID=(SELECT MIN(ID) FROM tblBatchProduct WHERE BatchID = " + temp2 + " AND UPPER(Status) = 'IN')";
                                        cmd = new SqlCommand(QueryInsert, con);
                                        cmd.ExecuteNonQuery();
                                        con.Close();
                                    }
                                }
                                if (!temp3.Equals(string.Empty))
                                {
                                    con.Open();

                                    QueryInsert = "INSERT INTO tblStockout ([ProductID],[QtyStockedOut],[PurchaseID],[StockoutDate],[BatchID])" +
                                        " VALUES(" + "(SELECT ProductID from tblProducts where ProductCode like('" + dtFromSalesMgt.Rows[i][0].ToString() + "')), " +
                                        "'" + temp3ctr.ToString() + "', (select max(PurchaseID) from tblPurchases),'" + DateTime.Now.Date.ToString("yyyy-MM-dd H:mm:ss") + "'" +
                                        ", " + temp3 + ")";
                                    cmd = new SqlCommand(QueryInsert, con);
                                    cmd.ExecuteNonQuery();
                                    con.Close();

                                    for (int ctr = 0; ctr < temp3ctr; ctr++)
                                    {
                                        con.Open();

                                        QueryInsert = "UPDATE tblBatchProduct SET Status = 'OUT'" +
                                            " WHERE BatchID = " + temp3 +
                                            " AND ID=(SELECT MIN(ID) FROM tblBatchProduct WHERE BatchID = " + temp3 + " AND UPPER(Status) = 'IN')";
                                        cmd = new SqlCommand(QueryInsert, con);
                                        cmd.ExecuteNonQuery();
                                        con.Close();
                                    }
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
                        }//for(int i = 0; i < dtFromSalesMgt.Rows.Count; i++) end
                         //transactions

                        try
                            {
                                con.Open();
                                QueryInsert = "insert into tblTransactions values(" + transNo.Trim().ToString() + ",'" + DateTime.Now.Date.ToString("yyyy-MM-dd H:mm:ss") + "'," +
                                    "(select max(PurchaseID) from tblPurchases),(SELECT UserID from tblUsers where [Name] LIKE('" + frmLogin.GetUserName.ToString() + "')))";
                                cmd = new SqlCommand(QueryInsert, con);
                                cmd.ExecuteNonQuery();
                                con.Close();

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                            }
                            finally
                            {
                                con.Close();
                            }

                            MessageBox.Show("Transaction Finished Succesfully!", "Finished Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmInventory inventory = new frmInventory();
                            inventory.dgvStockList.Refresh();
                            this.Close();
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
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnXit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            SettlePayment();
        }

        private void txtCash_TextChange(object sender, EventArgs e)
        {
            
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
    }
}

