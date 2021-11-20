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

            try
            {

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                con.Open();

                QuerySelect = "SELECT * FROM viewProducts";
                cmd = new SqlCommand(QuerySelect, con);

                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);

                dgvProductList.DataSource = dt;
                dgvProductList.Refresh();


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
                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }

                        try
                        {

                            if (con.State == ConnectionState.Open)
                            {
                                con.Close();
                            }

                            con.Open();

                            QueryInsert = "INSERT INTO tblBatch(MillingDate) VALUES ( '" + dtpMillingDate.Value.Date.ToShortDateString() + "') ";
                            cmd = new SqlCommand(QueryInsert, con);
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


                        //INSERT tblBatchProduct

                        try
                        {

                            if (con.State == ConnectionState.Open)
                            {
                                con.Close();
                            }

                            con.Open();

                            int qty = Convert.ToInt32(txtQuantity.Text);
                            for (int i = 0; i < qty; i++)
                            {
                                QueryInsert = "INSERT INTO tblBatchProduct(BatchID, BatchNumber, Status)Values((SELECT MAX(BatchID) FROM tblBatch), '" + txtBatchNo.Text + "', 'IN')";
                                cmd = new SqlCommand(QueryInsert, con);
                                cmd.ExecuteNonQuery();
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


                        //INSERT tblStockin

                        try
                        {

                            if (con.State == ConnectionState.Open)
                            {
                                con.Close();
                            }

                            con.Open();

                            QueryInsert = "INSERT INTO tblStockin (ProductID,StockinQuantity,StockinDate,BatchID) VALUES((SELECT ProductID FROM tblProducts WHERE ProductCode = '" + txtProductCode.Text + "'), '" + txtQuantity.Text + "', '" + dtpStockinDate.Value.Date.ToShortDateString() + "', (SELECT MAX(BatchID) FROM tblBatch))";
                            cmd = new SqlCommand(QueryInsert, con);
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

                        MessageBox.Show("Stock Added Successfully!", "Add Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtProductCode.Text = "";
                        txtProdDesc.Text = "";
                        txtVariety.Text = "";
                        DisplayProductList();
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
                DisplayProductList();
            }
            else
            {

                try
                {

                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }

                    con.Open();
                    QuerySelect = "SELECT * FROM viewProducts WHERE [Product Code] LIKE '" + txtProductSearch.Text + "%' OR [Product Description] LIKE'%" + txtProductSearch.Text + "%'";
                    cmd = new SqlCommand(QuerySelect, con);

                    adapter = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    adapter.Fill(dt);

                    dgvProductList.DataSource = dt;
                    dgvProductList.Refresh();
                   
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


                try
                {

                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddStock_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void txtBatchNo_Leave(object sender, EventArgs e)
        {

            try
            {

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                con.Open();
                QuerySelect = "SELECT BatchNumber FROM tblBatchProduct WHERE BatchNumber = "+txtBatchNo.Text;
                reader = new SqlCommand(QuerySelect, con).ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show(this, "Batch number already exists.", "Duplicate Batch Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtBatchNo.Focus();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
