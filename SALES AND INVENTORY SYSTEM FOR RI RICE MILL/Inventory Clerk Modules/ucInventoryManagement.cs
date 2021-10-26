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
    public partial class frmInventory : UserControl
    {
        private static frmInventory inventory;
        public static frmInventory inventoryInstance
        {
            get
            {
                if (inventory == null)
                    inventory = new frmInventory();
                return inventory;
            }
        }
        public frmInventory()
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


        //Display ProductData in DataGridView  
        public void DisplayProductList()
        {
            con.Close();
            con.Open();
            QuerySelect = "SELECT ProductCode AS 'Product Code', ProductDesc AS 'Product Description', ProductVariety AS 'Product Variety', Price FROM tblProducts ORDER BY ProductID ASC";
            cmd = new SqlCommand(QuerySelect, con);

            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);

            dgvProductList.DataSource = dt;
            dgvProductList.Refresh();
            con.Close();
        }

        public void DisplayStockList()
        {
            con.Close();
            con.Open();
            QuerySelect = "SELECT a.stockinID AS 'Stock ID', b.ProductDesc AS 'Product Description', a.QtyStockedIn AS 'Quantity', a.StockinDate AS 'Stock-in Date', a.BatchID AS 'Batch ID' FROM tblStockin a INNER JOIN tblProducts b ON a.ProductID = b.ProductID";
            cmd = new SqlCommand(QuerySelect, con);

            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);

            dgvStockList.DataSource = dt;
            dgvStockList.Refresh();
            con.Close();
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            DisplayProductList();
            DisplayStockList();
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            frmAddStock stock = new frmAddStock();
            stock.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayProductList();
            DisplayStockList();
        }
    }
}
