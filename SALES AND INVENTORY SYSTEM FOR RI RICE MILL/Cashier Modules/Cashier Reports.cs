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
    public partial class ucCashierReports : UserControl
    {
        private static ucCashierReports cashierReports;

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

        public static ucCashierReports cashierReportsInstance
        {
            get
            {
                if (cashierReports == null)
                    cashierReports = new ucCashierReports();
                return cashierReports;
            }
        }
        public ucCashierReports()
        {
            InitializeComponent();
        }

        //public void DisplaySalesReport()
        //{
        //    try
        //    {
        //        con.Open();

        //        if (txtViewCustomers.Text == "" || txtViewCustomers.Text == null)
        //        {
        //            QuerySelect = "SELECT * from CustomerViews";
        //        }
        //        else
        //        {
        //            QuerySelect = "SELECT * FROM  CustomerViews WHERE (ID LIKE '%' + @id + '%') OR ([First Name] LIKE '%' + @fName + '%') OR ([Last Name] LIKE '%' + @lName + '%') OR ([Contact Number] LIKE '%' + @cNum + '%') OR ([Discount Code] LIKE '%' + @discount + '%')";

        //        }

        //        cmd = new SqlCommand(QuerySelect, con);

        //        cmd.Parameters.AddWithValue("@id", txtViewCustomers.Text);
        //        cmd.Parameters.AddWithValue("@fName", txtViewCustomers.Text);
        //        cmd.Parameters.AddWithValue("@lName", txtViewCustomers.Text);
        //        cmd.Parameters.AddWithValue("@cNum", txtViewCustomers.Text);
        //        cmd.Parameters.AddWithValue("@province", txtViewCustomers.Text);
        //        cmd.Parameters.AddWithValue("@city", txtViewCustomers.Text);
        //        cmd.Parameters.AddWithValue("@street", txtViewCustomers.Text);
        //        cmd.Parameters.AddWithValue("@discount", txtViewCustomers.Text);


        //        adapter = new SqlDataAdapter(cmd);
        //        dt = new DataTable();
        //        adapter.Fill(dt);
        //        dgvCustomerList.DataSource = dt;

        //        dgvCustomerList.Refresh();
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}

        public void DisplaySalesReport()
        {
            try
            {
                QuerySelect = "SELECT * FROM  SalesReportView";

                cmd = new SqlCommand(QuerySelect, con);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dgvSalesReport.DataSource = dt;
                dgvSalesReport.Refresh();
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


        private void btnViewReport_Click(object sender, EventArgs e)
        {
            DisplaySalesReport();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
