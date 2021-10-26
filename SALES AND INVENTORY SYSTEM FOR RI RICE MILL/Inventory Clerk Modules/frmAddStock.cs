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
        public static string QueryDelete;


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
                    con.Close();
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
                result = MessageBox.Show("Do you want to Add this Stock?", "Add Stock", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        con.Close();
                        con.Open();
                        QueryInsert = "INSERT INTO tblBatch(MillingDate,SackNumber) VALUES ('" + dtpMillingDate.Value.Date.ToShortDateString() + "', '" + txtSackNo.Text + "') ";
                        cmd = new SqlCommand(QueryInsert, con);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        con.Open();
                        QueryInsert = "INSERT INTO tblStockin (ProductID,QtyStockedIn,StockinDate,BatchID) VALUES((SELECT ProductID FROM tblProducts WHERE ProductDesc = '" + txtProdDesc.Text + "'), '" + txtQuantity.Text + "', '" + dtpStockinDate.Value.Date.ToShortDateString() + "', (SELECT MAX(BatchID) FROM tblBatch))";
                        cmd = new SqlCommand(QueryInsert, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Stock Added Successfully!", "Add Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                else
                {

                }
            }
        }
    }
}
