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
            populateGraph();


        }

        public static SqlConnection con = new SqlConnection(DBConnection.con);
        public static SqlCommand cmd;
        public static SqlDataReader reader;
        public static SqlDataAdapter adapter;
        public static DataSet ds;
        public static DataTable dt;
        public static DialogResult result;
        public static string QuerySelect;



        public void populateGraph()
        {
            //StockedIN

            try
            {
                con.Open();

                QuerySelect = "SELECT * from OwnerDashboardView";
                cmd = new SqlCommand(QuerySelect, con);
                adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds);
                DataView source = new DataView(ds.Tables[0]);
                StocksChart.DataSource = source;

                StocksChart.Series[0].XValueMember = "Stocked In";
                StocksChart.Series[0].YValueMembers = "Stocked In";

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

            //StockedOUT

            try
            {
                con.Open();

                QuerySelect = "SELECT * from OwnerDashboardView";
                cmd = new SqlCommand(QuerySelect, con);
                adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds);
                DataView source = new DataView(ds.Tables[0]);
                StocksChart.DataSource = source;

                StocksChart.Series[1].XValueMember = "Stocked Out";
                StocksChart.Series[1].YValueMembers = "Stocked Out";

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
            //stockout
            try
            {
                con.Open();
                QuerySelect = "SELECT * from InventoryDashboardView";
                SqlDataReader reader = new SqlCommand(QuerySelect, con).ExecuteReader();
              
                if (reader.Read())
                {
                    lblTotalAvailableStock.Text = reader["Total Available Stock"].ToString();
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
                QuerySelect = "SELECT * from InventoryDashboardView";
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

