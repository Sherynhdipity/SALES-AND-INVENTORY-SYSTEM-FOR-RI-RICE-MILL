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

        public ucCashierReports()
        {
            InitializeComponent();
        }


        public void DisplaySalesReport()
        {
            try
            {
           

                QuerySelect = "Select * from CashierSales where [Date] = @FromDate";

                cmd = new SqlCommand(QuerySelect, con);
                cmd.Parameters.AddWithValue("@FromDate", dtpDate.Value);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dgvSalesReport.DataSource = dt;
                dgvSalesReport.Refresh();

                double sum1 = 0;
                double sum2 = 0;

                for (int i = 0; i < dgvSalesReport.Rows.Count; i++)
                {
                    sum1 += Convert.ToDouble(dgvSalesReport.Rows[i].Cells[5].Value);
                    sum2 += Convert.ToDouble(dgvSalesReport.Rows[i].Cells[6].Value);
                }
                lblTotal.Text = sum1.ToString();
                lblSales.Text = sum2.ToString("N2");
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



        private void ucCashierReports_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            dtpDate.Text = string.Format("{0:D}", date);

            DisplaySalesReport();
        }



        private void Search_Click(object sender, EventArgs e)
        {
            DisplaySalesReport();
          
        }


        private void dgvSalesReport_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6 || e.ColumnIndex == 4)
            {
                e.CellStyle.Format = "N2";
            }
        }



        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            CashierRep rep = new CashierRep();
            frmCashier_Report frm = new frmCashier_Report();

            try
            {
                date1 = dtpDate.Value.Year + "-" + dtpDate.Value.Month + "-" + dtpDate.Value.Day;
                con.Open();

                dt = new DataTable();

                TextObject DateFrom = (TextObject)rep.ReportDefinition.Sections["PageHeaderSection1"].ReportObjects["DateFrom"];
                DateFrom.Text = date1.ToString();
                QuerySelect = "SELECT * FROM CashierSales WHERE [Date] = '" + date1 + "'";
                cmd = new SqlCommand(QuerySelect, con);
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                rep.Database.Tables["CashierSales"].SetDataSource(dt);
                frm.crystalReportViewer1.ReportSource = rep;
                con.Close();
                frm.Show();

            }
            catch (Exception ex)
            {

            }
        }
    }
}
