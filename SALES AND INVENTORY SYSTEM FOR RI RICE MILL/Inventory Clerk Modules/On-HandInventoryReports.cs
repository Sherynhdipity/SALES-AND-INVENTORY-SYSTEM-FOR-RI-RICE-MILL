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
using CrystalDecisions.CrystalReports.Engine;

namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Inventory_Clerk_Modules
{
    public partial class On_HandInventoryReports : Form
    {
        public On_HandInventoryReports()
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

        private void On_HandInventoryReports_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            dtpFromDate.Text = string.Format("{0:D}", date);

            QuerySelect = " Select [Date], [Batch Number], Description, [Remain Stock]  from InventorySummaryReportInventoryClerk";

            cmd = new SqlCommand(QuerySelect, con);
            cmd.Parameters.AddWithValue("@Date", dtpFromDate.Value);
            //cmd.Parameters.AddWithValue("@ToDate", dtpToDate.Value);

            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvInventoryOwnerReport.DataSource = dt;
            dgvInventoryOwnerReport.Refresh();

            int sum = 0;

            for (int i = 0; i < dgvInventoryOwnerReport.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dgvInventoryOwnerReport.Rows[i].Cells[3].Value);
            }

            lblTotal.Text = sum.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                QuerySelect = " Select [Date], [Batch Number], Description, [Remain Stock]  from InventorySummaryReportInventoryClerk where [Date] = @Date";

                cmd = new SqlCommand(QuerySelect, con);
                cmd.Parameters.AddWithValue("@Date", dtpFromDate.Value);
                //cmd.Parameters.AddWithValue("@ToDate", dtpToDate.Value);

                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dgvInventoryOwnerReport.DataSource = dt;
                dgvInventoryOwnerReport.Refresh();

                int sum = 0;

                for (int i = 0; i < dgvInventoryOwnerReport.Rows.Count; i++)
                {
                    sum += Convert.ToInt32(dgvInventoryOwnerReport.Rows[i].Cells[3].Value);
                }

                lblTotal.Text = sum.ToString();

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

        private void dgvInventoryOwnerReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvInventoryOwnerReport_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ClerkSumm sum = new ClerkSumm();
            frmClerkSummaryRep frm = new frmClerkSummaryRep();

            try
            {
                date1 = dtpFromDate.Value.Year + "-" + dtpFromDate.Value.Month + "-" + dtpFromDate.Value.Day;
                //date2 = dtpToDate.Value.Year + "-" + dtpToDate.Value.Month + "-" + dtpToDate.Value.Day;
                con.Open();

                dt = new DataTable();

                TextObject DateFrom = (TextObject)sum.ReportDefinition.Sections["PageHeaderSection1"].ReportObjects["DateFrom"];
                DateFrom.Text = dtpFromDate.Value.ToString();


                QuerySelect = "Select [Date], [Batch Number], Description, [Remain Stock]  from InventorySummaryReportInventoryClerk where [Date] = @Date";
                
                cmd = new SqlCommand(QuerySelect, con);
                cmd.Parameters.AddWithValue("@Date", dtpFromDate.Value);
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                sum.Database.Tables["InventorySummaryReportInventoryClerk"].SetDataSource(dt);
                frm.crystalReportViewer1.ReportSource = sum;
                con.Close();
                frm.Show();



            }
            catch (Exception ex)
            {

            }
        }
    }
}
