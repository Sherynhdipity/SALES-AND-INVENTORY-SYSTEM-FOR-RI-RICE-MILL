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
    public partial class ucReports : UserControl
    {
        private static ucReports reports;

   

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
        public static string status = "Active";

        public static ucReports reportsInstance
        {
            get
            {
                if (reports == null)
                    reports = new ucReports();
                return reports;
            }
        }
        public ucReports()
        {
            InitializeComponent();
        }

        public void SaleSummaryReport()
        {
            try
            {
                con.Open();
                QuerySelect = "SELECT SUM(DISTINCT Total_cost) as totalSales  from tblOrders";
                SqlDataReader reader = new SqlCommand(QuerySelect, con).ExecuteReader();
                if (reader.Read())
                {
                    txtTotalSales.Text = reader["totalSales"].ToString();
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

        public void TransactionSummary()
        {
            try
            {
                con.Open();
                QuerySelect = "SELECT Count(DISTINCT Transaction_number) as TotalTransaction  from tblOrders";
                SqlDataReader reader = new SqlCommand(QuerySelect, con).ExecuteReader();
                if (reader.Read())
                {
                    txtTotalTransaction.Text = reader["totaltransaction"].ToString();
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

        public void ReturnItemSummary()
        {
            try
            {
                con.Open();
                QuerySelect = "Select Count(SKU) as [Return] from tblReturns";
                SqlDataReader reader = new SqlCommand(QuerySelect, con).ExecuteReader();
                if (reader.Read())
                {
                    txtTotalReturn.Text = reader["Return"].ToString();

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

        public void InventorySummary()
        {
            try
            {
                con.Open();
                QuerySelect = "SELECT * from InventoryDashboardView";
                SqlDataReader reader = new SqlCommand(QuerySelect, con).ExecuteReader();
                if (reader.Read())
                {
                    txtTotalnventoryItem.Text = reader["Total Available Stock"].ToString();

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

        private void btnViewSalesReports_Click(object sender, EventArgs e)
        {
            Owner_Modules.frmOwnerSalesReport f1 = new Owner_Modules.frmOwnerSalesReport();
            f1.Show();
        }

        private void btnViewInventoryReports_Click(object sender, EventArgs e)
        {
            Owner_Modules.frmOwnerInventoryReport f2 = new Owner_Modules.frmOwnerInventoryReport();
            f2.Show();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            SaleSummaryReport();
            TransactionSummary();
            InventorySummary();
            ReturnItemSummary();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            Owner_Modules.frmRestockReport f3 = new Owner_Modules.frmRestockReport();
            f3.Show();
        }

        private void bunifuPanel5_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            Owner_Modules.frmSales_Return f4 = new Owner_Modules.frmSales_Return();
            f4.Show();
        }

        private void txtTotalReturn_Click(object sender, EventArgs e)
        {

        }
    }
}
