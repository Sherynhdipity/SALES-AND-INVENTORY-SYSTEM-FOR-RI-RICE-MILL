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
            populateDash();
            populateChart();
        }

        public void populateChart()
        {
            // Sales 

            try
            {
                con.Open();

                QuerySelect = "SELECT * FROM SalesChartView";
                cmd = new SqlCommand(QuerySelect, con);
                adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds);
                DataView source = new DataView(ds.Tables[0]);
                salesChart.DataSource = source;

                salesChart.Series[0].XValueMember = "Date";
                salesChart.Series[0].YValueMembers = "Total";

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

            //Stocks

            try
            {
                con.Open();

                QuerySelect = "SELECT * FROM StockChartView";
                cmd = new SqlCommand(QuerySelect, con);
                adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds);
                DataView source = new DataView(ds.Tables[0]);
                StocksChart.DataSource = source;

                StocksChart.Series[0].XValueMember = "Description";
                StocksChart.Series[0].YValueMembers = "QtySold";


                StocksChart.DataBind();

            }
            catch (Exception ex)
            {
                throw;
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
                    string var = reader["totalSales"].ToString();
                    lblTotalSales.Text = Convert.ToDouble(var).ToString("N2");
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
                QuerySelect = "SELECT COUNT(Transaction_number) AS [totalTrans] FROM tblOrders";
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
            InitTimer();
        }

        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 3000; // in miliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            populateDash();
            populateChart();
        }
    }
}

