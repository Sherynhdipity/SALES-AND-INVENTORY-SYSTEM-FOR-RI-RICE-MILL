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
using ZXing;

namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL
{
    public partial class ucCustomers : UserControl
    {
        public ucCustomers()
        {
            InitializeComponent();
        }

        private static ucCustomers customers;
        public static ucCustomers customersInstance
        {
            get
            {
                if (customers == null)
                    customers = new ucCustomers();
                return customers;
            }
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


        public void RefreshControl()
        {
            Refresh();
        }

        //Display CustomerData in DataGridView  
        public void DisplayCustomerList()
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

                dgvCustomerList.DataSource = dt;
                dgvCustomerList.Refresh();
                
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

        //Clear Controls 
        public void ClearControls()
        {
            txtCustomerCode.Text = "";
            txtCustomerName.Text = "";
            txtContactNo.Text = "";
            txtAddress.Text = "";
        }


        //Method AddCustomer
        private void AddCustomer()
        {
            if (String.IsNullOrEmpty(txtCustomerCode.Text) && String.IsNullOrEmpty(txtCustomerName.Text) && String.IsNullOrEmpty(txtContactNo.Text) && String.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Fields should not be empty!");
                txtCustomerCode.Focus();
            }
            else if (String.IsNullOrEmpty(txtCustomerCode.Text))
            {
                MessageBox.Show("Enter Customer Code first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerCode.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtCustomerCode.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtCustomerCode.Clear();
                txtCustomerCode.Focus();
            }
            else if (String.IsNullOrEmpty(txtCustomerName.Text))
            {
                MessageBox.Show("Enter Customer Name first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerName.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtCustomerName.Clear();
                txtCustomerName.Focus();
            }
            else if (String.IsNullOrEmpty(txtContactNo.Text))
            {
                MessageBox.Show("Enter Contact Number first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContactNo.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtContactNo.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtContactNo.Clear();
                txtContactNo.Focus();
            }
            else if (String.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Enter Address first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtAddress.Clear();
                txtAddress.Focus();
            }
            else if (txtCustomerCode.Text != "" && txtCustomerName.Text != "" && txtAddress.Text != "" && txtContactNo.Text != "")
            {
                result = MessageBox.Show("Do you want to Add this Customer?", "Add Customer", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    try
                    {

                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }

                        con.Open();
                        QuerySelect = "SELECT * FROM tblProducts WHERE ProductCode = '" + txtCustomerCode.Text + "'";
                        cmd = new SqlCommand(QuerySelect, con);
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            MessageBox.Show("This Product already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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

                                //QueryInsert = "INSERT INTO tblProducts (ProductCode,ProductDesc,VarietyID,Price,RestockLevel) VALUES ('" + txtCustomerCode.Text + "', '" + txtCustomerName.Text + "', (Select VarietyID from tblProductVariety Where VarietyName = '" + drpVariety.Text + "'),'"+txtContactNo.Text+"', '" + txtrReStocklvl.Text + "')";
                                cmd = new SqlCommand(QueryInsert, con);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Product Added Successfully!", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                                ClearControls();


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
                    MessageBox.Show("The Product already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        //Method UpdateCustomer
        private void UpdateCustomer()
        {
            if (txtCustomerCode.Text != "" && txtCustomerName.Text != "" && txtContactNo.Text != "" && txtAddress.Text != "") 
            { 

                result = MessageBox.Show("Do you want to Update this Customer?", "Update Customert", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)

                {

                    try
                    {

                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }

                        con.Open();

                        //QueryUpdate = "UPDATE tblProducts SET ProductCode='" + txtCustomerCode.Text + "', ProductDesc='" + txtCustomerName.Text + "', VarietyID=(Select VarietyID from tblProductVariety Where VarietyName = '" + drpVariety.Text + "'), Price='" + txtContactNo.Text + "' , RestockLevel =" + txtrReStocklvl.Text + " WHERE ProductID='" + lblItemID.Text + "'";
                        cmd = new SqlCommand(QueryUpdate, con);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Product Updated Successfully!", "Update Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplayCustomerList();
                        ClearControls();


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
            else
            {
                MessageBox.Show("Please Select Product to Update");
                dgvCustomerList.Visible = true;
                DisplayCustomerList();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateCustomer();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddCustomer();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void txtSearchCustomer_TextChange(object sender, EventArgs e)
        {
            if (txtSearchCustomer.Text == "")
            {
                DisplayCustomerList();
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

                    QuerySelect = "SELECT * FROM viewProducts where [Product Code] like '%" + txtSearchCustomer.Text + "%' OR [Product Description] like '%" + txtSearchCustomer.Text + "%' OR Variety like '%" + txtSearchCustomer.Text + "%' OR  Price like '%" + txtSearchCustomer.Text + "%' OR [Restock Level] like '%" + txtSearchCustomer.Text + "%' ORDER BY [Product Code] DESC";
                    cmd = new SqlCommand(QuerySelect, con);
                    adapter = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dgvCustomerList.DataSource = null;
                    dgvCustomerList.DataSource = dt;


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

        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            ClearControls();
            dgvCustomerList.Visible = false;
            panelCustomerInfo.Visible = true;
            btnUpdate.Visible = false;
            lblAddProduct.Visible = true;
            lblProductList.Visible = false;
            lblUpdateProduct.Visible = false;
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            panelCustomerInfo.Visible = true;
            btnUpdate.Visible = true;
            lblUpdateProduct.Visible = true;
            lblAddProduct.Visible = false;
            lblProductList.Visible = false;
            dgvCustomerList.Visible = false;
        }

        private void btnViewCustomers_Click(object sender, EventArgs e)
        {
            lblProductList.Visible = true;
            lblAddProduct.Visible = false;
            lblUpdateProduct.Visible = false;
            panelCustomerInfo.Visible = false;
            dgvCustomerList.Visible = true;
            DisplayCustomerList();
        }

        //Cellclick for Update
        private void dgvCustomerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvCustomerList.Rows[e.RowIndex];

                txtCustomerCode.Text = row.Cells[0].Value.ToString();
                txtCustomerName.Text = row.Cells[1].Value.ToString();
                txtAddress.Text = row.Cells[2].Value.ToString();
                txtContactNo.Text = row.Cells[3].Value.ToString();
                //txtrReStocklvl.Text = row.Cells[4].Value.ToString();


                try
                {

                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }

                    con.Open();

                    QuerySelect = "SELECT ProductID FROM tblProducts WHERE ProductCode='" + txtCustomerCode.Text + "'";
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

        private void dgvCustomerList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvCustomerList_CellClick(sender, e);
            btnUpdateCustomer_Click(sender, e);
        }
    }
}
