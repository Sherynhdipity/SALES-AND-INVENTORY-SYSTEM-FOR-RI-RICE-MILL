using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL
{
    public partial class ucSalesDashboard : UserControl
    {

        public static SqlConnection con = new SqlConnection(DBConnection.con);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader reader;
        public static SqlDataAdapter adapter;
        public static DataTable dt = new DataTable();
        public static DataSet ds = new DataSet();
        public static DialogResult result;
        public static string QuerySelect;

        private static ucSalesDashboard dashboard;
        public static ucSalesDashboard dashboardInstance
        {
            get
            {
                if (dashboard == null)
                    dashboard = new ucSalesDashboard();
                return dashboard;
            }
        }
        public ucSalesDashboard()
        {
            InitializeComponent();
        }

        public void populateChart()
        {
            // Sales 

            try
            {
                con.Open();

                QuerySelect = "SELECT * from CashierDashboardView";
                cmd = new SqlCommand(QuerySelect, con);
                adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds);
                DataView source = new DataView(ds.Tables[0]);
                salesChart.DataSource = source;

                salesChart.Series[0].XValueMember = "Total Amount";
                salesChart.Series[0].YValueMembers = "Total Amount";

                salesChart.DataBind();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            // Trans

            try
            {
                con.Open();

                QuerySelect = "SELECT * from CashierDashboardView";
                cmd = new SqlCommand(QuerySelect, con);
                adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds);
                DataView source = new DataView(ds.Tables[0]);
                transChart.DataSource = source;

                transChart.Series[0].XValueMember = "Total Transaction";
                transChart.Series[0].YValueMembers = "Total Transaction";

                transChart.DataBind();

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

        public void populateDash()
        {
            // Total Sales
            try
            {
                con.Open();
                QuerySelect = "SELECT SUM(Total_cost) as totalSales from tblOrders";
                SqlDataReader reader = new SqlCommand(QuerySelect, con).ExecuteReader();
                if (reader.Read())
                {
                    lblTotalSales.Text = reader["totalSales"].ToString();
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

            //Total transactions
            try
            {
                con.Open();
                QuerySelect = "SELECT COUNT(Order_id) as totalTrans from tblOrders";
                SqlDataReader reader = new SqlCommand(QuerySelect, con).ExecuteReader();
                if (reader.Read())
                {
                    lblTotalTransactions.Text = reader["totalTrans"].ToString();
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

        private void ucSalesDashboard_Load(object sender, EventArgs e)
        {
            populateDash();
            populateChart();

        }
    }
}

