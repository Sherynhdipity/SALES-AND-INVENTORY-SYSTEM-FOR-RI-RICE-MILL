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
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Owner_Modules
{
    public partial class frmSales_Return : Form
    {
        public frmSales_Return()
        {
            InitializeComponent();
        }
        string date1;
        string date2;

        public static SqlConnection con = new SqlConnection(DBConnection.con);
        public static SqlCommand cmd;
        public static SqlDataReader reader;
        public static SqlDataAdapter adapter;
        public static DataSet ds;
        public static DataTable dt;
        public static DialogResult result;
        public static string QuerySelect;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                QuerySelect = " Select * from SalesReturnReportView where [Date] between @FromDate and @ToDate";

                cmd = new SqlCommand(QuerySelect, con);
                cmd.Parameters.AddWithValue("@FromDate", dtpFromDate.Value);
                cmd.Parameters.AddWithValue("@ToDate", dtpToDate.Value);

                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dgvReturnOwnerReport.DataSource = dt;
                dgvReturnOwnerReport.Refresh();

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

        private void frmSales_Return_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            dtpFromDate.Text = string.Format("{0:D}", date);
            dtpToDate.Text = string.Format("{0:D}", date);
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SalesReturn sales = new SalesReturn();
            frmSalesReturnReport list = new frmSalesReturnReport();

            try
            {
                date1 = dtpFromDate.Value.Year + "-" + dtpFromDate.Value.Month + "-" + dtpFromDate.Value.Day;
                date2 = dtpToDate.Value.Year + "-" + dtpToDate.Value.Month + "-" + dtpToDate.Value.Day;
                con.Open();

                dt = new DataTable();
                QuerySelect = "Select * from SalesReturnReportView";
                cmd = new SqlCommand(QuerySelect, con);
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                sales.Database.Tables["SalesReturnReportView"].SetDataSource(dt);
                list.SalesReturnViewer.ReportSource = sales;
                con.Close();
                list.Show();
            }

            catch (Exception ex)
            {

            }

          
        }

        private void dgvReturnOwnerReport_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 3 || e.ColumnIndex == 6)
            {
                e.CellStyle.Format = "N2";
            }
        }
    }
}
