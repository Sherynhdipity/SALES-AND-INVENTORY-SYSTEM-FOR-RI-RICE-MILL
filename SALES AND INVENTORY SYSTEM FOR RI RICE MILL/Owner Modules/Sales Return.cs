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

            dtpToDate.Enabled = false;
            dtpFromDate.Enabled = false;
            btnSearch.Enabled = false;
            btnGenerateReport.Enabled = false;

            DateTime date = DateTime.Now;
            dtpFromDate.Text = string.Format("{0:D}", date);
            dtpToDate.Text = string.Format("{0:D}", date);

            QuerySelect = " Select * from SalesReturnReportView";

            cmd = new SqlCommand(QuerySelect, con);
            cmd.Parameters.AddWithValue("@FromDate", dtpFromDate.Value);
            cmd.Parameters.AddWithValue("@ToDate", dtpToDate.Value);

            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvReturnOwnerReport.DataSource = dt;
            dgvReturnOwnerReport.Refresh();

            double sum = 0;
            double sum2 = 0;

            for (int i = 0; i < dgvReturnOwnerReport.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dgvReturnOwnerReport.Rows[i].Cells[4].Value);
                sum2 += Convert.ToDouble(dgvReturnOwnerReport.Rows[i].Cells[6].Value);
            }
            lblTotalReturnItem.Text = sum.ToString();
            TotalReturnedSales.Text = sum2.ToString("N2");
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

                TextObject DateFrom = (TextObject)sales.ReportDefinition.Sections["PageHeaderSection1"].ReportObjects["DateFrom"];
                DateFrom.Text = dtpFromDate.Value.ToString();
                TextObject DateTo = (TextObject)sales.ReportDefinition.Sections["PageHeaderSection1"].ReportObjects["DateTo"];
                DateTo.Text = dtpToDate.Value.ToString();

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

        private void rbnDaily_CheckedChanged(object sender, EventArgs e)
        {
            dtpToDate.Enabled = false;
            dtpFromDate.Enabled = true;
            btnSearch.Enabled = true;
            btnGenerateReport.Enabled = true;
        }

        private void rbnWeekly_CheckedChanged(object sender, EventArgs e)
        {
            dtpToDate.Enabled = false;
            dtpFromDate.Enabled = true;
            btnSearch.Enabled = true;
            btnGenerateReport.Enabled = true;
        }

        private void rbnCustom_CheckedChanged(object sender, EventArgs e)
        {
            dtpToDate.Enabled = true;
            dtpFromDate.Enabled = true;
            btnSearch.Enabled = true;
            btnGenerateReport.Enabled = true;
        }

        private void rbnMonthly_CheckedChanged(object sender, EventArgs e)
        {
            dtpToDate.Enabled = false;
            dtpFromDate.Enabled = true;
            btnSearch.Enabled = true;
            btnGenerateReport.Enabled = true;
        }

        private void rbnYearly_CheckedChanged(object sender, EventArgs e)
        {
            dtpToDate.Enabled = false;
            dtpFromDate.Enabled = true;
            btnSearch.Enabled = true;
            btnGenerateReport.Enabled = true;
        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            if (rbnDaily.Checked)
            {
                dtpToDate.Value = dtpFromDate.Value;

            }
            else if (rbnWeekly.Checked)
            {
                dtpToDate.Value = dtpFromDate.Value.AddDays(7);

            }
            else if (rbnMonthly.Checked)
            {
                dtpToDate.Value = dtpFromDate.Value.AddMonths(1).AddDays(-1);

            }
            else if (rbnYearly.Checked)
            {
                dtpToDate.Value = dtpFromDate.Value.AddYears(1).AddMonths(-1);

            }
            else if (rbnCustom.Checked)
            {
                if (DateTime.Today < dtpFromDate.Value)
                {
                    MessageBox.Show("The Date is Invalid");
                    dtpFromDate.Value = DateTime.Today;
                }
                else if (dtpToDate.Value < dtpToDate.Value)
                {
                    MessageBox.Show("To Date must be greater than From Date");
                }

            }
        }

        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
