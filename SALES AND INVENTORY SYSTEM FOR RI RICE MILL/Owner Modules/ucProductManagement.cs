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
        public static string QueryDelete;


        //Display ProductData in DataGridView  
        public void DisplayProductList()
        {
            con.Close();
            con.Open();
            QuerySelect = "SELECT ProductCode AS 'Product Code', ProductDesc AS 'Product Description', ProductVariety AS 'Product Variety', Price, RestockLevel AS 'Restock Level' FROM tblProducts ORDER BY ProductID ASC";
            cmd = new SqlCommand(QuerySelect, con);

            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);

            dgvProductList.DataSource = dt;
            dgvProductList.Refresh();
            con.Close();
        }


        //Clear Controls 
        public void ClearControls()
        {
            txtProductCode.Text = "";
            txtProductDesc.Text = "";
            txtProdPrice.Text = "";
            drpVariety.Text = "";
            txtStockLevel.Text = "";
        }


        //Method AddProduct
        private void AddProduct()
        {
            if (String.IsNullOrEmpty(txtProductCode.Text) && String.IsNullOrEmpty(txtProductDesc.Text) && String.IsNullOrEmpty(txtProdPrice.Text))
            {
                MessageBox.Show("Fields should not be empty!");
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
            }
            else if (String.IsNullOrEmpty(txtProdPrice.Text))
            {
                MessageBox.Show("Enter Item Price first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProdPrice.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtProdPrice.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtProdPrice.Clear();
            }
            else if (String.IsNullOrEmpty(txtStockLevel.Text))
            {
                MessageBox.Show("Enter Restock Level first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStockLevel.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtStockLevel.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtStockLevel.Clear();
            }
            else if (txtProductCode.Text != "" && txtProductDesc.Text != "" && drpVariety.Text != "" && txtProdPrice.Text != "" && txtStockLevel.Text !="")
            {
                result = MessageBox.Show("Do you want to Add this Product?", "Add Product", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
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
                            con.Close();
                            con.Open();
                            QueryInsert = "INSERT INTO tblProducts (ProductCode,ProductDesc,ProductVariety,Price, RestockLevel) VALUES ('" + txtProductCode.Text + "', '" + txtProductDesc.Text + "', '" + drpVariety.Text + "', '" + txtProdPrice.Text + "', '" + txtStockLevel.Text + "')";
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
                else
                {
                    MessageBox.Show("The product already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        //Method UpdateProduct
        private void UpdateProduct()
        {
            if (txtProductCode.Text != "" && txtProductDesc.Text != "" && txtProdPrice.Text != "" && drpVariety.Text != "" && txtStockLevel.Text!="") 
            { 

                result = MessageBox.Show("Do you want to update this Product?", "Update Product", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)

                {
                    try
                    {
                        con.Close();
                        con.Open();
                        QueryUpdate = "UPDATE tblProducts SET ProductCode='" + txtProductCode.Text + "', ProductDesc='" + txtProductDesc.Text + "', ProductVariety='" + drpVariety.Text + "', Price='" + txtProdPrice.Text + "', RestockLevel='" + txtStockLevel.Text +"' WHERE ProductID='" + lblItemID.Text + "'";
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
                txtProdPrice.Text = row.Cells[3].Value.ToString();
                txtStockLevel.Text = row.Cells[4].Value.ToString();

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

        private void txtProdPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            dgvProductList.Visible = false;
            panelProductInfo.Visible = true;
            btnUpdate.Visible = false;
            lblAddProduct.Visible = true;
            lblProductList.Visible = false;
            lblUpdateProduct.Visible = false;
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            panelProductInfo.Visible = true;
            btnUpdate.Visible = true;
            lblUpdateProduct.Visible = true;
            lblAddProduct.Visible = false;
            lblProductList.Visible = false;
            dgvProductList.Visible = false;
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
                con.Open();
                QuerySelect = "SELECT ProductCode AS 'Product Code', ProductDesc AS 'Product Description', ProductVariety AS 'Product Variety', Price, RestockLevel AS 'Restock Level' FROM tblProducts where ProductCode like '" + txtSearchProduct.Text + "%' OR ProductDesc like '%" + txtSearchProduct.Text + "%' OR ProductVariety like '%" + txtSearchProduct.Text + "%' OR  Price like '%" + txtSearchProduct.Text + "%' OR RestockLevel like '%" + txtSearchProduct.Text + "' ORDER BY ProductID DESC";
                cmd = new SqlCommand(QuerySelect, con);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dgvProductList.DataSource = dt;
                dgvProductList.Refresh();

                con.Close();
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
                
            }

        }

        private void txtStockLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
