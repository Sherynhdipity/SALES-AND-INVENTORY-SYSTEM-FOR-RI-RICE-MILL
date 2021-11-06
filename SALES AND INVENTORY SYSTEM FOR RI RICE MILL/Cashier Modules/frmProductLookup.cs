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
    public partial class frmProductLookup : Form
    {
        public frmProductLookup()
        {
            InitializeComponent();
            DisplayProductList();

            dgvProductList.Columns.Add(new DataGridViewButtonColumn()
            {
                Text = "Add",
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            });
        }

        public static SqlConnection con = new SqlConnection(DBConnection.con);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader reader;
        public static SqlDataAdapter adapter;
        public static DataTable dt = new DataTable();
        frmSalesManagement sales = new frmSalesManagement();
        public static DialogResult result;
        public static string QueryInsert;
        public static string QuerySelect;
        public static string QueryUpdate;
        public static string QueryDelete;
        public string productCode { get; set; }
        public string productDesc { get; set; }
        public string productVariety { get; set; }
        public string productPrice { get; set; }

        public int quantity { get; set; }
        public string stock { get; set; }


    //Display ProductData in DataGridView  
    public void DisplayProductList()
        {

            con.Open();
            QuerySelect = "SELECT b.ProductCode AS 'Product Code', b.ProductDesc AS 'Product Description', b.ProductVariety AS 'Product Variety', b.Price , a.QtyStockedIn AS 'Quantity' FROM tblStockin a INNER JOIN tblProducts b ON a.ProductID = b.ProductID";
            cmd = new SqlCommand(QuerySelect, con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);

            dgvProductList.DataSource = dt;
            dgvProductList.Refresh();
            con.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
                QuerySelect = "SELECT ProductCode AS 'Product Code', ProductDesc AS 'Product Description', ProductVariety AS 'Product Variety', Price FROM tblProducts where ProductCode like '" + txtSearchProduct.Text + "%' OR ProductDesc like '%" + txtSearchProduct.Text + "%' OR ProductVariety like '%" + txtSearchProduct.Text + "%' OR  Price like '%" + txtSearchProduct.Text + "' ORDER BY ProductID DESC";
                cmd = new SqlCommand(QuerySelect, con);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dgvProductList.DataSource = dt;
                dgvProductList.Refresh();

                con.Close();
            }

        }

        private void dgvProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dgvProductList.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvProductList.Rows[selectedrowindex];
            //DataGridViewRow row = dgvProductList.Rows[e.RowIndex];

            var grid = (DataGridView)sender;

            if (e.RowIndex < 0)
            {
                //They clicked the header column, do nothing
                return;
            }

            if (grid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {

               
                frmPLQuant qty = new frmPLQuant();
                qty.product_Code = Convert.ToString(selectedRow.Cells["Product Code"].Value);
                qty.product_Desc = Convert.ToString(selectedRow.Cells["Product Description"].Value);
                qty.product_Variety = Convert.ToString(selectedRow.Cells["Product Variety"].Value);
                qty.product_Price = Convert.ToString(selectedRow.Cells["Price"].Value);
                qty.ShowDialog();
                productCode = qty.product_Code;
                productDesc = qty.product_Desc;
                productVariety = qty.product_Variety;
                productPrice = qty.product_Price;
                quantity = qty.Product_Quantity;
                this.Close();
            }
        }
    }
}
