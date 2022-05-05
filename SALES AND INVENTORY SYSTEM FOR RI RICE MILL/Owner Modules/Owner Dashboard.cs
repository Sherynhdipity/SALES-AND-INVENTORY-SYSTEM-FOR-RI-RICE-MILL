﻿using System;
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
    public partial class ucDashboard : UserControl
    {
        private static ucDashboard dashboard;
        public static ucDashboard dashboardInstance
        {
            get
            {
                if (dashboard == null)
                    dashboard = new ucDashboard();
                return dashboard;
            }
        }
        public ucDashboard()
        {
            InitializeComponent();
            //populateDash();
            populateChart();
        }

        public static SqlConnection con = new SqlConnection(DBConnection.con);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader reader;
        public static DataSet ds;
        public static SqlDataAdapter adapter;
        public static DataTable dt = new DataTable();
        public static DialogResult result;
        public static string QuerySelect;



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




        ////not chart
        //public void populateDash()
        //{
        //    // Total Sales
        //    try
        //    {
        //        con.Open();
        //        QuerySelect = "Select * from OwnerDashboardView";
        //        SqlDataReader reader = new SqlCommand(QuerySelect, con).ExecuteReader();
        //        if (reader.Read())
        //        {
        //            lblTotalSales.Text = reader["Total Sales"].ToString();
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }

        //    //Total transactions
        //    try
        //    {
        //        con.Open();
        //        QuerySelect = "SELECT * from OwnerDashboardView";
        //        SqlDataReader reader = new SqlCommand(QuerySelect, con).ExecuteReader();
        //        if (reader.Read())
        //        {
        //            lblTotalTransactions.Text = reader["Total Transactions"].ToString();
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }

        //    //StockedIn

        //    try
        //    {
        //        con.Open();
        //        QuerySelect = "SELECT * from OwnerDashboardView";
        //        SqlDataReader reader = new SqlCommand(QuerySelect, con).ExecuteReader();
        //        if (reader.Read())
        //        {
        //            lblStockedIn.Text = reader["Stocked In"].ToString();
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }

        //    //StockedOut
        //    try
        //    {
        //        con.Open();
        //        QuerySelect = "SELECT * from OwnerDashboardView";
        //        SqlDataReader reader = new SqlCommand(QuerySelect, con).ExecuteReader();
        //        if (reader.Read())
        //        {
        //            lblStockedOut.Text = reader["Stocked Out"].ToString();
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}

    }

}

