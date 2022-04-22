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
    public partial class ucProducts : UserControl
    {
        public ucProducts()
        {
            InitializeComponent();
        }

        private static ucProducts products;
        public static ucProducts productsInstance
        {
            get
            {
                if (products == null)
                    products = new ucProducts();
                return products;
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


        public void DisplayVarieties()
        {

            try
            {

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                con.Open();


                QuerySelect = "SELECT VarietyID, VarietyName from tblProductsVariety";
                cmd = new SqlCommand(QuerySelect, con);

                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);

                drpVariety.DataSource = dt;
                drpVariety.DisplayMember = "VarietyName";
                drpVariety.ValueMember = "VarietyID";


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
            txtProductCode.Text = "";
            txtProductDesc.Text = "";
            //txtProdPrice.Text = "";
            txtrReStocklvl.Text= drpVariety.Text = "";
            pbBarcode.Image = null;
        }


        //Method AddProduct
        private void AddProduct()
        {
            if (String.IsNullOrEmpty(txtProductCode.Text) && String.IsNullOrEmpty(txtProductDesc.Text) && String.IsNullOrEmpty(txtrReStocklvl.Text))
            {
                MessageBox.Show("Fields should not be empty!");
                txtProductCode.Focus();
            }
            else if (String.IsNullOrEmpty(txtProductCode.Text))
            {
                MessageBox.Show("Enter Product Code first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductCode.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtProductCode.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtProductCode.Clear();
                txtProductCode.Focus();
            }
            else if (String.IsNullOrEmpty(txtProductDesc.Text))
            {
                MessageBox.Show("Enter Product Description first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductDesc.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtProductDesc.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtProductDesc.Clear();
                txtProductDesc.Focus();
            }
            //else if (String.IsNullOrEmpty(txtProdPrice.Text))
            //{
            //    MessageBox.Show("Enter Item Price first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtProdPrice.Focus();
            //}
            //else if (String.IsNullOrWhiteSpace(txtProdPrice.Text))
            //{
            //    MessageBox.Show("Whitespace is not allowed!");
            //    txtProdPrice.Clear();
            //    txtProdPrice.Focus();
            //}
            else if (String.IsNullOrEmpty(txtrReStocklvl.Text))
            {
                MessageBox.Show("Enter Restock Level first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtrReStocklvl.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtrReStocklvl.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtrReStocklvl.Clear();
                txtrReStocklvl.Focus();
            }
            else if (txtProductCode.Text != "" && txtProductDesc.Text != "" && drpVariety.Text != "")
            {
                result = MessageBox.Show("Do you want to Add this Product?", "Add Product", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    try
                    {

                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }

                        con.Open();
                        QuerySelect = "SELECT * FROM tblProducts WHERE ProductCode = '" + txtProductCode.Text + "'";
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

                                QueryInsert = "INSERT INTO tblProducts (ProductCode,ProductDesc,ProductShortCode,VarietyID,RestockLevel) VALUES ('" + txtProductCode.Text + "', '" + txtProductDesc.Text + "','', (Select VarietyID from tblProductsVariety Where VarietyName = '" + drpVariety.Text + "'), '" + txtrReStocklvl.Text + "')";
                                cmd = new SqlCommand(QueryInsert, con);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Product Added Successfully!", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                DisplayProductList();
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


        //Method UpdateProduct
        private void UpdateProduct()
        {
            if (txtProductCode.Text != "" && txtProductDesc.Text != "" && drpVariety.Text != "" && txtrReStocklvl.Text != "") 
            { 

                result = MessageBox.Show("Do you want to update this Product?", "Update Product", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)

                {

                    try
                    {

                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }

                        con.Open();

                        QueryUpdate = "UPDATE tblProducts SET ProductCode='" + txtProductCode.Text + "', ProductDesc='" + txtProductDesc.Text + "', VarietyID=(Select VarietyID from tblProductsVariety Where VarietyName = '" + drpVariety.Text + "') , RestockLevel =" + txtrReStocklvl.Text + " WHERE ProductID='" + lblItemID.Text + "'";
                        cmd = new SqlCommand(QueryUpdate, con);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Product Updated Successfully!", "Update Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplayProductList();
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
                dgvProductList.Visible = true;
                DisplayProductList();
            }
        }

        //Cellclick for Update
        private void dgvProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvProductList.Rows[e.RowIndex];

                txtProductCode.Text = row.Cells[0].Value.ToString();
                txtProductDesc.Text = row.Cells[1].Value.ToString();
                drpVariety.Text = row.Cells[2].Value.ToString();
                //txtProdPrice.Text = row.Cells[3].Value.ToString();
                txtrReStocklvl.Text = row.Cells[3].Value.ToString();


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

        private void txtProdPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            //{
            //    e.Handled = true;
            //}

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ClearControls();
            DisplayVarieties();
            dgvProductList.Visible = false;
            panelProductInfo.Visible = true;
            btnUpdate.Visible = false;
            lblAddProduct.Visible = true;
            lblProductList.Visible = false;
            lblUpdateProduct.Visible = false;
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            lblProductList.Visible = true;
            panelProductInfo.Visible = true;
            btnUpdate.Visible = true;
            lblUpdateProduct.Visible = true;
            lblAddProduct.Visible = false;
            lblProductList.Visible = false;
            dgvProductList.Visible = true;
            DisplayProductList();
        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            lblProductList.Visible = true;
            lblAddProduct.Visible = false;
            lblUpdateProduct.Visible = false;
            panelProductInfo.Visible = false;
            dgvProductList.Visible = true;
            DisplayProductList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateProduct();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void txtSearchProduct_TextChange(object sender, EventArgs e)
        {
            if (txtSearchProduct.Text == "")
            {
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

                    QuerySelect = "SELECT * FROM viewProducts where [Product Code] like '%" + txtSearchProduct.Text + "%' OR [Product Description] like '%" + txtSearchProduct.Text + "%' OR Variety like '%" + txtSearchProduct.Text + "%' OR [Restock Level] like '%" + txtSearchProduct.Text + "%' ORDER BY [Product Code] DESC";
                    cmd = new SqlCommand(QuerySelect, con);
                    adapter = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dgvProductList.DataSource = null;
                    dgvProductList.DataSource = dt;


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

        private void txtProductCode_TextChange(object sender, EventArgs e)
        {
            try
            {
                BarcodeWriter barcode = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
                pbBarcode.Image = barcode.Write(txtProductCode.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtStockLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnAddVariety_Click(object sender, EventArgs e)
        {
            //frmAddVariety variety = new frmAddVariety();
            //variety.ShowDialog();
            //refresh combobox
            DisplayVarieties();
        }


        private void ucProducts_Load(object sender, EventArgs e)
        {
            DisplayVarieties();
        }

        private void panelProductInfo_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            txtSearchProduct_TextChange(sender, e);
        }

        private void dgvProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProductList_CellClick(sender, e);
            btnUpdateProduct_Click(sender, e);
        }
    }
}
