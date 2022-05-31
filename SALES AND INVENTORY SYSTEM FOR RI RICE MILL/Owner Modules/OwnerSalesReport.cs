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
    public partial class frmOwnerSalesReport : Form
    {
        public frmOwnerSalesReport()
        {
            InitializeComponent();
        }

        public static SqlConnection con = new SqlConnection(DBConnection.con);
        public static SqlCommand cmd;
        public static SqlDataReader reader;
        public static SqlDataAdapter adapter;
        public static DataSet ds;
        public static DataTable dt;
        public static DialogResult result;
        public static string QuerySelect;



        string date1;
        string date2;
        private void dtpMilledDate_ValueChanged(object sender, EventArgs e)
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
                    dtpToDate.Value = DateTime.Today;
                }
            }

        }

        private void frmOwnerSalesReport_Load(object sender, EventArgs e)
        {
            try
            {
                dtpToDate.Enabled = false;
                dtpFromDate.Enabled = false;
                btnSearch.Enabled = false;
                btnPrintReport.Enabled = false;


                DateTime date = DateTime.Now;
                dtpFromDate.Text = string.Format("{0:D}", date);
                dtpToDate.Text = string.Format("{0:D}", date);

                QuerySelect = "Select [Date], Description, [Cost Sales], [Gross Sales] from SalesReportView";

                cmd = new SqlCommand(QuerySelect, con);

                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dgvSalesOwnerReport.DataSource = dt;
                dgvSalesOwnerReport.Refresh();

                QuerySelect = "Select [Date], Description, Remarks, [Returned Sales] from SalesReturnReportView";
                cmd = new SqlCommand(QuerySelect, con);

                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dgvReturn.DataSource = dt;
                dgvReturn.Refresh();

                double sum = 0;
                double sum2 = 0;

                for (int i = 0; i < dgvSalesOwnerReport.Rows.Count; i++)
                {
                    sum += Convert.ToDouble(dgvSalesOwnerReport.Rows[i].Cells[3].Value);
                    sum2 += Convert.ToDouble(dgvSalesOwnerReport.Rows[i].Cells[2].Value);
                }
                Gross.Text = sum.ToString("N2");
                Cost.Text = sum2.ToString("N2");

                double sum3 = 0;

                for (int i = 0; i < dgvReturn.Rows.Count; i++)
                {
                    sum3 += Convert.ToDouble(dgvReturn.Rows[i].Cells[3].Value);
                }
                Return.Text = sum3.ToString("N2");

                net.Text = (Convert.ToDouble(Gross.Text) - Convert.ToDouble(Cost.Text) - Convert.ToDouble(Return.Text)).ToString("N2");
            }

            catch (Exception ex)
            {

            }
            dgvReturn.Visible = false;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowReport();
        }

        public void ShowReport()
        {

            try
            {

                QuerySelect = "Select [Date], Description, [Cost Sales], [Gross Sales] from SalesReportView where [Date] between @FromDate and @ToDate";

                cmd = new SqlCommand(QuerySelect, con);
                cmd.Parameters.AddWithValue("@FromDate", dtpFromDate.Value);
                cmd.Parameters.AddWithValue("@ToDate", dtpToDate.Value);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dgvSalesOwnerReport.DataSource = dt;
                dgvSalesOwnerReport.Refresh();



                QuerySelect = "Select [Date], Description, Remarks, [Returned Sales] from SalesReturnReportView where [Date] between @FromDate and @ToDate";
                cmd = new SqlCommand(QuerySelect, con);
                cmd.Parameters.AddWithValue("@FromDate", dtpFromDate.Value);
                cmd.Parameters.AddWithValue("@ToDate", dtpToDate.Value);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dgvReturn.DataSource = dt;
                dgvReturn.Refresh();

                float sum = 0;
                float sum2 = 0;

                for (int i = 0; i < dgvSalesOwnerReport.Rows.Count; i++)
                {
                    sum += Convert.ToInt32(dgvSalesOwnerReport.Rows[i].Cells[3].Value);
                    sum2 += Convert.ToInt32(dgvSalesOwnerReport.Rows[i].Cells[2].Value);
                }
                Gross.Text = sum.ToString("N2");
                Cost.Text = sum2.ToString("N2");

                float sum3 = 0;

                for (int i = 0; i < dgvReturn.Rows.Count; i++)
                {
                    sum3 += Convert.ToInt32(dgvReturn.Rows[i].Cells[3].Value);
                }
                Return.Text = sum3.ToString("N2");

                net.Text = (Convert.ToDouble(Gross.Text) - Convert.ToDouble(Cost.Text) - Convert.ToDouble(Return.Text)).ToString();


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

        private void btnPrintReport_Click(object sender, EventArgs e)
        {

            if (dgvSalesOwnerReport.Rows.Count == 0)
            {
                MessageBox.Show("No Data");
            }
            else
            {
                SalesReport();
            }


            //DataSet ds = new DataSet();
            //SalesReport sales = new SalesReport();
            //frmSalesReport frm = new frmSalesReport();


            //try
            //{
            //    date1 = dtpFromDate.Value.Year + "-" + dtpFromDate.Value.Month + "-" + dtpFromDate.Value.Day;
            //    date2 = dtpToDate.Value.Year + "-" + dtpToDate.Value.Month + "-" + dtpToDate.Value.Day;
            //    con.Open();

            //    dt = new DataTable();
            //    QuerySelect = "SELECT * FROM SalesReportView WHERE [Order Date] BETWEEN '" + date1 + "' AND '" + date2 + "'";
            //    cmd = new SqlCommand(QuerySelect, con);
            //    adapter = new SqlDataAdapter(cmd);
            //    adapter.Fill(dt);

            //    sales.Database.Tables["SalesReportView"].SetDataSource(dt);
            //    frm.SalesReportViewer.ReportSource = sales;
            //    con.Close();
            //    frm.Show();

            //}
            //catch (Exception ex)
            //{

            //}


        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            //if (DateTime.Today > dtpToDate.Value || DateTime.Today < dtpToDate.Value)
            //{
            //    MessageBox.Show("The date is Invalid");
            //    dtpToDate.Value = DateTime.Today;
            //}

            if (dtpFromDate.Value > dtpToDate.Value)
            {
                MessageBox.Show("To Date must be greater than From Date");
                dtpToDate.Value = DateTime.Today;
            }


        }

        void SalesReport()
        {
            DataSet ds = new DataSet();
            SalesReport salesreport = new SalesReport();
            frmSalesReport frm = new frmSalesReport();


            //Date
            TextObject DateFrom = (TextObject)salesreport.ReportDefinition.Sections["PageHeaderSection1"].ReportObjects["DateFrom"];
            DateFrom.Text = dtpFromDate.Value.ToString();
            TextObject DateTo = (TextObject)salesreport.ReportDefinition.Sections["PageHeaderSection1"].ReportObjects["DateTo"];
            DateTo.Text = dtpToDate.Value.ToString();

            //TotalGross
            TextObject GrossSales = (TextObject)salesreport.ReportDefinition.Sections["ReportFooterSection1"].ReportObjects["TotalGross"];
            GrossSales.Text = Gross.Text;

            //TotalCost
            TextObject CostSales = (TextObject)salesreport.ReportDefinition.Sections["ReportFooterSection1"].ReportObjects["TotalCost"];
            CostSales.Text = Cost.Text;

            //Return
            TextObject ReturnSales = (TextObject)salesreport.ReportDefinition.Sections["ReportFooterSection1"].ReportObjects["TotalReturn"];
            ReturnSales.Text = Return.Text;

            //NetSales
            TextObject NetSales = (TextObject)salesreport.ReportDefinition.Sections["ReportFooterSection1"].ReportObjects["Net"];
            NetSales.Text = net.Text;

            date1 = dtpFromDate.Value.Year + "-" + dtpFromDate.Value.Month + "-" + dtpFromDate.Value.Day;
            date2 = dtpToDate.Value.Year + "-" + dtpToDate.Value.Month + "-" + dtpToDate.Value.Day;
            con.Open();

            dt = new DataTable();
            QuerySelect = "SELECT * FROM SalesReportView WHERE [Date] BETWEEN '" + date1 + "' AND '" + date2 + "'";
            cmd = new SqlCommand(QuerySelect, con);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            salesreport.Database.Tables["SalesReportView"].SetDataSource(dt);
            frm.SalesReportViewer.ReportSource = salesreport;
            con.Close();
            frm.Show();

        }

        private void rbnDaily_CheckedChanged(object sender, EventArgs e)
        {
            dtpToDate.Enabled = false;
            dtpFromDate.Enabled = true;
            btnSearch.Enabled = true;
            btnPrintReport.Enabled = true;
        }

        private void rbnCustom_CheckedChanged(object sender, EventArgs e)
        {
            dtpToDate.Enabled = true;
            dtpFromDate.Enabled = true;
            btnSearch.Enabled = true;
            btnPrintReport.Enabled = true;

            

        }

        private void rbnWeekly_CheckedChanged(object sender, EventArgs e)
        {
            dtpToDate.Enabled = false;
            dtpFromDate.Enabled = true;
            btnSearch.Enabled = true;
            btnPrintReport.Enabled = true;
        }

        private void rbnMonthly_CheckedChanged(object sender, EventArgs e)
        {
            dtpToDate.Enabled = false;
            dtpFromDate.Enabled = true;
            btnSearch.Enabled = true;
            btnPrintReport.Enabled = true;
        }

        private void rbnYearly_CheckedChanged(object sender, EventArgs e)
        {
            dtpToDate.Enabled = false;
            dtpFromDate.Enabled = true;
            btnSearch.Enabled = true;
            btnPrintReport.Enabled = true;
        }

        private void dgvSalesOwnerReport_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           if (e.ColumnIndex == 2 || e.ColumnIndex == 3)
            {
                e.CellStyle.Format = "N2";
            }
        }

        private void dgvSalesOwnerReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
