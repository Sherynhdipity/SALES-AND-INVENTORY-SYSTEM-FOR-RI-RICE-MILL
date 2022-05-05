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
    public partial class ucInventoryReports : UserControl
    {
        private static ucInventoryReports inventoryReports;
        public static ucInventoryReports inventoryReportsInstance
        {
            get
            {
                if (inventoryReports == null)
                    inventoryReports = new ucInventoryReports();
                return inventoryReports;
            }
        }
        public ucInventoryReports()
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

        private void btnViewSalesReports_Click(object sender, EventArgs e)
        {
           
        }

        private void btnViewInventoryReports_Click(object sender, EventArgs e)
        {
            Inventory_Clerk_Modules.On_HandInventoryReports f1 = new Inventory_Clerk_Modules.On_HandInventoryReports();
            f1.ShowDialog();

        }

        private void ucInventoryReports_Load(object sender, EventArgs e)
        {
            AvailableStock();
            StockOut();
        }

        public void AvailableStock()
        {
            try
            {
                con.Open();
                QuerySelect = "SELECT * from InventoryDashboardView";
                SqlDataReader reader = new SqlCommand(QuerySelect, con).ExecuteReader();
                if (reader.Read())
                {
                    txtTotalAvailableStock.Text = reader["Available Stock"].ToString();

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

        public void StockOut()
        {
            try
            {
                con.Open();
                QuerySelect = "SELECT * from InventoryDashboardView";
                SqlDataReader reader = new SqlCommand(QuerySelect, con).ExecuteReader();
                if (reader.Read())
                {
                   txtStockOut.Text = reader["Stock out"].ToString();

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

       

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            Inventory_Clerk_Modules.ReStockInventory f2 = new Inventory_Clerk_Modules.ReStockInventory();
            f2.ShowDialog();
        }
    }
}
