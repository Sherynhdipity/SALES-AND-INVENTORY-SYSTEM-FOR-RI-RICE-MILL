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

        }

        private void frmOwnerSalesReport_Load(object sender, EventArgs e)
        {
            try
            {
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

                QuerySelect = "Select [Date], Description, [Returned Sales], Remarks from SalesReturnReportView";
                cmd = new SqlCommand(QuerySelect, con);

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
                Gross.Text = sum.ToString();
                Cost.Text = sum2.ToString();

                float sum3 = 0;

                for (int i = 0; i < dgvReturn.Rows.Count; i++)
                {
                    sum += Convert.ToInt32(dgvSalesOwnerReport.Rows[i].Cells[2].Value);
                }
                Return.Text = sum3.ToString();

                net.Text = (Convert.ToDouble(Gross.Text) - Convert.ToDouble(Cost.Text) - Convert.ToDouble(Return.Text)).ToString();
            }

            catch (Exception ex)
            {

            }
            
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

              

                QuerySelect = "Select [Date], Description, [Returned Sales], Remarks from SalesReturnReportView where [Date] between @FromDate and @ToDate";
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
                Gross.Text = sum.ToString();
                Cost.Text = sum2.ToString();

                float sum3 = 0;

                for (int i = 0; i < dgvReturn.Rows.Count; i++)
                {
                    sum += Convert.ToInt32(dgvSalesOwnerReport.Rows[i].Cells[2].Value);
                }
                Return.Text = sum3.ToString();

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
            DataSet ds = new DataSet();
            SalesReport sales = new SalesReport();
            frmSalesReport frm = new frmSalesReport();
            

            try
            {
                date1 = dtpFromDate.Value.Year + "-" + dtpFromDate.Value.Month + "-" + dtpFromDate.Value.Day;
                date2 = dtpToDate.Value.Year + "-" + dtpToDate.Value.Month + "-" + dtpToDate.Value.Day;
                con.Open();

                dt = new DataTable();
                QuerySelect = "SELECT * FROM SalesReportView WHERE [Order Date] BETWEEN '" + date1 + "' AND '" + date2 + "'";
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

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
