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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

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
        string date1;
        string date2;

        public ucCashierReports()
        {
            InitializeComponent();
        }


        public void DisplaySalesReport()
        {
            try
            {
                QuerySelect = "Select * from SalesReportView where [Order Date] = @date";

                cmd = new SqlCommand(QuerySelect, con);
                cmd.Parameters.AddWithValue("@date", dtpDate.Value);

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
            
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            
        }

        private void ucCashierReports_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            DisplaySalesReport();
          
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SalesReport sales = new SalesReport();
            frmSalesReport frm = new frmSalesReport();

            try
            {
                date1 = dtpDate.Value.Year + "-" + dtpDate.Value.Month + "-" + dtpDate.Value.Day;
                con.Open();

                dt = new DataTable();
                QuerySelect = "SELECT * FROM SalesReportView WHERE [Order Date] = '" + date1 + "'";
                cmd = new SqlCommand(QuerySelect, con);
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                sales.Database.Tables["SalesReportView"].SetDataSource(dt);
                frm.SalesReportViewer.ReportSource = sales;
                con.Close();
                frm.Show();

            }
            catch (Exception ex)
            {

            }
        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
