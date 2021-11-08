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
    public partial class frmUpdateStock : Form
    {
        public frmUpdateStock()
        {
            InitializeComponent();
        }

        public static SqlConnection con = new SqlConnection(DBConnection.con);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader reader;
        public static SqlDataAdapter adapter;
        public static DataTable dt = new DataTable();
        public static DialogResult result;
        public static string QuerySelect;
        public static string QueryUpdate;

        private void UpdateStock()
        {
            if (String.IsNullOrWhiteSpace(txtSackNo.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtSackNo.Clear();
            }
            else if (String.IsNullOrEmpty(txtSackNo.Text))
            {
                MessageBox.Show("Enter Quantity!");
                txtSackNo.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtQuantity.Clear();
            }
            else if (String.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("Enter Quantity!");
                txtQuantity.Focus();
            }
            else if (txtSackNo.Text != "" && txtQuantity.Text != "")
            {
                result = MessageBox.Show("Do you want to Update this Stock?", "Update Stock", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                  
                        try
                        {
                            con.Close();
                            con.Open();
                            QueryUpdate = "UPDATE tblBatch SET MillingDate = '" + dtpMillingDate.Value.Date.ToShortDateString() + "', BatchNumber = '"+txtSackNo.Text+ "' WHERE BatchID = (SELECT BatchID FROM tblStockIn WHERE StockinID = '" + txtStockID.Text+"')";
                            cmd = new SqlCommand(QueryUpdate, con);
                            cmd.ExecuteNonQuery();
                            con.Close();


                        con.Open();
                        string query = "DELETE FROM tblBatchProduct WHERE BatchID = (SELECT BatchID FROM tblStockIn WHERE StockinID = '" + txtStockID.Text + "')";
                        cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();

                        con.Close();

                        con.Open();
                        int quant = Convert.ToInt32(txtQuantity.Text);
                        for (int i = 0; i < quant; i++)
                        {
                            QueryUpdate = "INSERT INTO tblBatchProduct(BatchID, BatchNumber, Status)Values((SELECT MAX(BatchID) FROM tblBatch), '" + txtSackNo.Text + "', 'IN')";
                            cmd = new SqlCommand(QueryUpdate, con);
                            cmd.ExecuteNonQuery();
                        }
                        con.Close();


                        con.Open();
                            QueryUpdate = "UPDATE tblStockin SET StockinDate = '" + dtpStockinDate.Value.Date.ToShortDateString() + "', QtyStockedIn = '" + txtQuantity.Text + "' WHERE ProductID = (SELECT ProductID FROM tblProducts WHERE ProductCode = '" + txtProductCode.Text + "')";
                            cmd = new SqlCommand(QueryUpdate, con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Stock Updated Successfully!", "Update Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    
                    con.Close();

                }
                else
                {

                }
            }
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            UpdateStock();
        }

        private void txtStockID_TextChange(object sender, EventArgs e)
        {
            if (txtStockID.Text == "")
            {
                txtProductCode.Text = "";
                txtProdDesc.Text = "";
                txtVariety.Text = "";
                txtQuantity.Text = "";
                txtSackNo.Text = "";
            }
            else
            {
                try
                {
                    con.Close();
                    con.Open();
                    QuerySelect = "SELECT p.ProductCode AS 'Product Code', p.ProductDesc AS 'Product Description', c.VarietyName AS 'Product Variety', b.BatchNumber AS 'Batch Number', s.QtyStockedIn AS 'Quantity', s.StockinDate AS 'Stock-in Date' FROM tblStockin s INNER JOIN tblProducts p ON s.ProductID = p.ProductID INNER JOIN tblBatch b ON s.BatchID = b.BatchID INNER JOIN tblProductVariety c ON p.VarietyID= c.VarietyID WHERE s.StockinID = '" + txtStockID.Text + "';";

                    cmd = new SqlCommand(QuerySelect, con);
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        txtProductCode.Text = reader["Product Code"].ToString();
                        txtProdDesc.Text = reader["Product Description"].ToString();
                        txtVariety.Text = reader["Product Variety"].ToString();
                        txtSackNo.Text = reader["Batch Number"].ToString();
                        txtQuantity.Text = reader["Quantity"].ToString();

                        reader.Close();
                    }
                    else
                    {
                        txtProductCode.Text = "";
                        txtProdDesc.Text = "";
                        txtVariety.Text = "";
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
