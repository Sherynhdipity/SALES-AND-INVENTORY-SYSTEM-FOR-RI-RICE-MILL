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


        //Display InventoryData in DataGridView  
        public void DisplayStockList()
        {

            try
            {

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                con.Open();

                //start code here
                QuerySelect = "SELECT * FROM viewAvailableStocks";
                cmd = new SqlCommand(QuerySelect, con);

                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);

                dgvStockList.DataSource = dt;
                dgvStockList.Refresh();

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

        private void frmInventory_Load(object sender, EventArgs e)
        {
            DisplayStockList();
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            frmAddStock stock = new frmAddStock();
            DialogResult res =  stock.ShowDialog();

            if (res==DialogResult.OK)
            {
                DisplayStockList();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayStockList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //frmUpdateStock stock = new frmUpdateStock();
            //stock.Show();
        }
    }
}
