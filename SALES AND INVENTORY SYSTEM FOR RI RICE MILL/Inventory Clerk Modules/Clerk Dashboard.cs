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
    public partial class ucInventoryDashboard : UserControl
    {
        private static ucInventoryDashboard dashboard;
        public static ucInventoryDashboard dashboardInstance
        {
            get
            {
                if (dashboard == null)
                    dashboard = new ucInventoryDashboard();
                return dashboard;
            }
        }
        public ucInventoryDashboard()
        {
            InitializeComponent();
            populateDash();
            populateChart();

        }

        public static SqlConnection con = new SqlConnection(DBConnection.con);
        public static SqlCommand cmd;
        public static SqlDataReader reader;
        public static SqlDataAdapter adapter;
        public static DataSet ds;
        public static DataTable dt;
        public static DialogResult result;
        public static string QuerySelect;



        public void populateChart()
        {
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
                StocksChart.Series[0].YValueMembers = "Quantity";

                StocksChart.Series[1].XValueMember = "Description";
                StocksChart.Series[1].YValueMembers = "QtySold";

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
            //stockin
            try
            {
                con.Open();
                QuerySelect = "SELECT COUNT(SKU) AS [Available Stock] FROM tblInventories";
                SqlDataReader reader = new SqlCommand(QuerySelect, con).ExecuteReader();

                if (reader.Read())
                {
                    lblTotalAvailableStock.Text = reader["Available Stock"].ToString();
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


            // stock out
            try
            {
                con.Open();
                QuerySelect = "SELECT COUNT(SKU) AS [Stock out] FROM tblOrderDetails";
                SqlDataReader reader = new SqlCommand(QuerySelect, con).ExecuteReader();

                if (reader.Read())
                {
                    lblQtyStockedOut.Text = reader["Stock out"].ToString();
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
}

