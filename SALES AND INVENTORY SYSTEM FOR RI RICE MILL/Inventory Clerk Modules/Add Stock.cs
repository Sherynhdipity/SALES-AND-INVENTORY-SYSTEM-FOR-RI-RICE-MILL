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
    public partial class frmAddStock : Form
    {
        public frmAddStock()
        {
            InitializeComponent();
        }

        public static SqlConnection con = new SqlConnection(DBConnection.con);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader reader;
        public static SqlDataAdapter adapter;
        public static DataTable dt = new DataTable();
        public static DialogResult result;
        public static string QueryInsert;
        public static string QuerySelect;
        public static string QueryUpdate;


        //Display ProductData in DataGridView  
        public void DisplayProductList()
        {
            con.Open();
            QuerySelect = "SELECT b.ProductCode AS 'Product Code',b.ProductDesc AS 'Product Description', c.VarietyName AS 'Product Variety', b.Price FROM tblProducts a INNER JOIN tblProducts b ON a.ProductID = b.ProductID INNER JOIN tblProductVariety c ON b.VarietyID = c.VarietyID;";
            cmd = new SqlCommand(QuerySelect, con);

            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);

            dgvProductList.DataSource = dt;
            dgvProductList.Refresh();
            con.Close();
        }


        private void addStock()
        {
            if (String.IsNullOrWhiteSpace(txtBatchNo.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtBatchNo.Clear();
            }
            else if (String.IsNullOrEmpty(txtBatchNo.Text))
            {
                MessageBox.Show("Enter Batch Number!");
                txtBatchNo.Focus();
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
            else if (txtBatchNo.Text != "" && txtQuantity.Text != "")
            {
                result = MessageBox.Show("Do you want to Add this Stock?", "Add Stock", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        //INSERT tblBatch
                        con.Open();
                        QueryInsert = "INSERT INTO tblBatch(MillingDate) VALUES ( '" + dtpMillingDate.Value.Date.ToShortDateString() + "') ";
                        cmd = new SqlCommand(QueryInsert, con);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        //INSERT tblBatchProduct
                        con.Open();
                        int qty = Convert.ToInt32(txtQuantity.Text);
                        for (int i = 0; i < qty; i++)
                        {
                            QueryInsert = "INSERT INTO tblBatchProduct(BatchID, BatchNumber, Status)Values((SELECT MAX(BatchID) FROM tblBatch), '" + txtBatchNo.Text + "', 'IN')";
                            cmd = new SqlCommand(QueryInsert, con);
                            cmd.ExecuteNonQuery();
                        }
                            con.Close();


                        //INSERT tblStockin
                        con.Open();
                        QueryInsert = "INSERT INTO tblStockin (ProductID,QtyStockedIn,StockinDate,BatchID) VALUES((SELECT ProductID FROM tblProducts WHERE ProductCode = '" + txtProductCode.Text + "'), '" + txtQuantity.Text + "', '" + dtpStockinDate.Value.Date.ToShortDateString() + "', (SELECT MAX(BatchID) FROM tblBatch))";
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



        private void txtProductSearch_TextChange(object sender, EventArgs e)
        {
            if (txtProductSearch.Text == "")
            {
                txtProductCode.Text = "";
                txtProdDesc.Text = "";
                txtVariety.Text = "";
            }
            else
            {
                try
                {
                    con.Open();
                    QuerySelect = "SELECT ProductCode, ProductDesc, ProductVariety FROM tblProducts WHERE ProductCode ='" + txtProductSearch.Text + "' OR ProductDesc LIKE'%" + txtProductSearch.Text + "%'";
                    cmd = new SqlCommand(QuerySelect, con);
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        txtProductCode.Text = reader["ProductCode"].ToString();
                        txtProdDesc.Text = reader["ProductDesc"].ToString();
                        txtVariety.Text = reader["ProductVariety"].ToString();
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

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            addStock();
        }

        private void frmAddStock_Load(object sender, EventArgs e)
        {
            DisplayProductList();
        }

        private void dgvProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvProductList.Rows[e.RowIndex];

                txtProductCode.Text = row.Cells[0].Value.ToString();
                txtProdDesc.Text = row.Cells[1].Value.ToString();
                txtVariety.Text = row.Cells[2].Value.ToString();

                con.Open();
                QuerySelect = "SELECT ProductID FROM tblProducts WHERE ProductCode='" + txtProductCode.Text + "'";
                cmd = new SqlCommand(QuerySelect, con);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    lblItemID.Text = reader["ProductID"].ToString();
                    reader.Close();
                }
                con.Close();

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddStock_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
