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
        }

        public static SqlConnection con = new SqlConnection(DBConnection.con);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader reader;
        public static SqlDataAdapter adapter;
        public static DataTable dt = new DataTable();
        public static DialogResult result;
        public static string QuerySelect;




        public void populateDash()
        {
            //stockout
            try
            {
                con.Open();
                QuerySelect = "SELECT sum(tblStockout.QtyStockedOut) as res from tblStockout";
                SqlDataReader reader = new SqlCommand(QuerySelect, con).ExecuteReader();
                if (reader.Read())
                {
                    lblProductsSold.Text = reader["res"].ToString();
                    lblQtyStockedOut.Text = reader["res"].ToString();
                    lblstocksSold.Text = reader["res"].ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }

            //transactions
            try
            {
                con.Open();
                QuerySelect = "SELECT count(TransactionNo) as res from tblTransactions";
                SqlDataReader reader = new SqlCommand(QuerySelect, con).ExecuteReader();
                if (reader.Read())
                {
                    txtotaltrans.Text = lblTotalTransactions.Text = reader["res"].ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }

            //sales
            try
            {
                con.Open();
                QuerySelect = "SELECT sum(TotalAmount) as res from tblPayments";
                SqlDataReader reader = new SqlCommand(QuerySelect, con).ExecuteReader();
                if (reader.Read())
                {
                    string temp = reader["res"].ToString();
                    lblTotalSales.Text = (Convert.ToDouble(temp)).ToString("n2");

                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
            //average stocks per trans
            txtavgStocks.Text = (Convert.ToDouble(lblProductsSold.Text.ToString()) / Convert.ToDouble(lblTotalTransactions.Text.ToString())).ToString("n2");
            txtavgSales.Text = (Convert.ToDouble(lblTotalSales.Text.ToString()) / Convert.ToDouble(lblTotalTransactions.Text.ToString())).ToString("n2");

            //prods
            try
            {
                con.Open();
                QuerySelect = "SELECT count(ProductID) as res from tblProducts";
                SqlDataReader reader = new SqlCommand(QuerySelect, con).ExecuteReader();
                if (reader.Read())
                {
                    string temp = reader["res"].ToString();
                    lbladdedproducts.Text = temp;

                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
            //vary
            try
            {
                con.Open();
                QuerySelect = "SELECT count(VarietyID) as res from tblProductVariety";
                SqlDataReader reader = new SqlCommand(QuerySelect, con).ExecuteReader();
                if (reader.Read())
                {
                    string temp = reader["res"].ToString();
                    lblNumVarieties.Text = temp;
                    lblavgsalespervar.Text = (Convert.ToDouble(lblTotalSales.Text.ToString()) / Convert.ToDouble(temp)).ToString("n2");

                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }


            //Stockin


            try
            {

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                con.Open();
                QuerySelect = "SELECT sum(tblStockin.QtyStockedIn) as res from tblStockin";
                SqlDataReader reader = new SqlCommand(QuerySelect, con).ExecuteReader();
                if (reader.Read())
                {
                    lbladdedproducts.Text = reader["res"].ToString();
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



            //prods
            try
            {
                con.Open();
                QuerySelect = "SELECT count(ProductID) as res from tblProducts";
                SqlDataReader reader = new SqlCommand(QuerySelect, con).ExecuteReader();
                if (reader.Read())
                {
                    string temp = reader["res"].ToString();
                    lbladdedproducts.Text = temp;

                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }

            //vary
            try
            {
                con.Open();
                QuerySelect = "SELECT count(VarietyID) as res from tblProductVariety";
                SqlDataReader reader = new SqlCommand(QuerySelect, con).ExecuteReader();
                if (reader.Read())
                {
                    string temp = reader["res"].ToString();
                    lblNumVarieties.Text = temp;
                    lblavgsalespervar.Text = (Convert.ToDouble(lblTotalSales.Text.ToString()) / Convert.ToDouble(temp)).ToString("n2");

                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }

            //inventory report
            try
            {
                con.Open();
                QuerySelect = "SELECT count(StockinID) as res from tblStockin";
                SqlDataReader reader = new SqlCommand(QuerySelect, con).ExecuteReader();
                if (reader.Read())
                {
                    string temp = reader["res"].ToString();
                    lbladdedstocks.Text = temp;

                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
        }

    }

    }

