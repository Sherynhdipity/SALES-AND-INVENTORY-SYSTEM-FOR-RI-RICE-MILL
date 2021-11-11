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
            
        public void populateDash()
        {
            //stockout
            try
            {
                con.Open();
                string query = "SELECT sum(tblStockout.QtyStockedOut) as res from tblStockout";
                SqlDataReader reader = new SqlCommand(query, con).ExecuteReader();
                if (reader.Read())
                {
                    lblProductsSold.Text = reader["res"].ToString();
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
                string query = "SELECT count(TransactionNo) as res from tblTransactions";
                SqlDataReader reader = new SqlCommand(query, con).ExecuteReader();
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
                string query = "SELECT sum(TotalAmount) as res from tblPayments";
                SqlDataReader reader = new SqlCommand(query, con).ExecuteReader();
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
                string query = "SELECT count(ProductID) as res from tblProducts";
                SqlDataReader reader = new SqlCommand(query, con).ExecuteReader();
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
                string query = "SELECT count(VarietyID) as res from tblProductVariety";
                SqlDataReader reader = new SqlCommand(query, con).ExecuteReader();
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
        }

        private void ucSalesDashboard_Load(object sender, EventArgs e)
        {
            populateDash();
        }

        private void bunifuLabel18_Click(object sender, EventArgs e)
        {

        }
    }

    }

