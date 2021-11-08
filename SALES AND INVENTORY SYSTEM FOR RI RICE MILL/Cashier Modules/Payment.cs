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
                        QueryInsert = "INSERT INTO tblPayments(TotalAmount ,AmountPaid)VALUES ('" + txtAmount.Text + "', '" + txtCash.Text + "') ";
                        cmd = new SqlCommand(QueryInsert, con);
                        cmd.ExecuteNonQuery();
                        con.Close();


                        ////INSERT tblPurchases
                        con.Open();
                        QueryInsert = "INSERT INTO [dbo].[tblPurchases]" +
                            "([PurchaseDate],[InvoiceNumber],[QuantityBought],[ProductID],[DiscountID],[PaymentID],[VAT])" +
                            "VALUES" +
                            "("+DateTime.Now.ToString("	YYYY-MM-DD hh:mm:ss[.nnn]")+
                            ","+transNo +
                            ","+dtFromSalesMgt.Rows[0][3].ToString()+
                            ",(SELECT ProductID from tblProducts where ProductCode like('"+ dtFromSalesMgt.Rows[0][0].ToString() + "'))," +
                            "1," +
                            "(SELECT MAX(PaymentID) as pID from tblPayments)," +
                            "0.12)";
                        //QueryInsert = "INSERT INTO tblPurchases(PurchaseDate ,InvoiceNumber, QuantityBought, ProductID, DiscountID, PaymentID, VAT) VALUES ('" + sales.lblTransDate.Text + "', '" + sales.lblIVno.Text + "','" + sales.txtQuantityCount.Text + "','" + "', (Select ProductID from tblProducts Where ProductCode = '" + dtFromSalesMgt.Rows[0][0].ToString() + "'), '" ) ";
                        cmd = new SqlCommand(QueryInsert, con);
                        cmd.ExecuteNonQuery();
                        con.Close();


                        //INSERT tblStockout
                        con.Open();
                        
                        //QueryInsert = "INSERT INTO tblStockout (ProductID,QtyStockedIn,StockinDate,BatchID) VALUES((SELECT ProductID FROM tblProducts WHERE ProductCode = '" + txtProductCode.Text + "'), '" + txtQuantity.Text + "', '" + dtpStockinDate.Value.Date.ToShortDateString() + "', (SELECT MAX(BatchID) FROM tblBatch))";
                        cmd = new SqlCommand(QueryInsert, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Stock Added Successfully!", "Add Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        frmInventory inventory = new frmInventory();
                        inventory.dgvStockList.Refresh();

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

                double amount = double.Parse(txtAmount.Text.ToString());
                double cash = double.Parse(txtCash.Text.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "/n" + ex.StackTrace);
            }
        }
    }
}

