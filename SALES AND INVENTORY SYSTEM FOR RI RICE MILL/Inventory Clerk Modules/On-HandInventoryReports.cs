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
            //DateTime date = DateTime.Now;
            ////dtpFromDate.Text = string.Format("{0:D}", date);

            QuerySelect = " Select [Batch Number], Description, [Remain Stock]  from InventorySummaryReportInventoryClerk";

            cmd = new SqlCommand(QuerySelect, con);
            //cmd.Parameters.AddWithValue("@Date", dtpFromDate.Value);
            //cmd.Parameters.AddWithValue("@ToDate", dtpToDate.Value);

            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvInventoryOwnerReport.DataSource = dt;
            dgvInventoryOwnerReport.Refresh();

            int sum = 0;

            for (int i = 0; i < dgvInventoryOwnerReport.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dgvInventoryOwnerReport.Rows[i].Cells[2].Value);
            }

            lblTotal.Text = sum.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                QuerySelect = " Select [Batch Number], Description, [Remain Stock]  from InventorySummaryReportInventoryClerk where (Description LIKE '%' + @desc + '%')"; 

                cmd = new SqlCommand(QuerySelect, con);
                cmd.Parameters.AddWithValue("@desc", txtSearchInventory.Text);
                //cmd.Parameters.AddWithValue("@ToDate", dtpToDate.Value);

                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dgvInventoryOwnerReport.DataSource = dt;
                dgvInventoryOwnerReport.Refresh();

                int sum = 0;

                for (int i = 0; i < dgvInventoryOwnerReport.Rows.Count; i++)
                {
                    sum += Convert.ToInt32(dgvInventoryOwnerReport.Rows[i].Cells[2].Value);
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

        private void txtSearchInventory_TextChanged(object sender, EventArgs e)
        {
            QuerySelect = " Select [Batch Number], Description, [Remain Stock]  from InventorySummaryReportInventoryClerk where (Description LIKE '%' + @desc + '%')";

            cmd = new SqlCommand(QuerySelect, con);
            cmd.Parameters.AddWithValue("@desc", txtSearchInventory.Text);
            //cmd.Parameters.AddWithValue("@ToDate", dtpToDate.Value);

            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvInventoryOwnerReport.DataSource = dt;
            dgvInventoryOwnerReport.Refresh();

            int sum = 0;

            for (int i = 0; i < dgvInventoryOwnerReport.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dgvInventoryOwnerReport.Rows[i].Cells[2].Value);
            }

            lblTotal.Text = sum.ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            DataSet ds = new DataSet();
            ClerkSumm sum = new ClerkSumm();
            frmClerkSummaryRep frm = new frmClerkSummaryRep();

            try
            {
                dt = new DataTable();

                if (txtSearchInventory.Text == "" || txtSearchInventory.Text == null)
                {
                    QuerySelect = "Select [Batch Number], Description, [Remain Stock]  from InventorySummaryReportInventoryClerk";
                    cmd = new SqlCommand(QuerySelect, con);
                    adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    sum.Database.Tables["InventorySummaryReportInventoryClerk"].SetDataSource(dt);
                    frm.crystalReportViewer1.ReportSource = sum;
                    con.Close();
                    frm.Show();
                }
                else
                {
                    QuerySelect = "Select [Batch Number], Description, [Remain Stock]  from InventorySummaryReportInventoryClerk where (Description LIKE '%' + @desc + '%')";
                    cmd = new SqlCommand(QuerySelect, con);
                    cmd.Parameters.AddWithValue("@desc", txtSearchInventory.Text);
                    adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    sum.Database.Tables["InventorySummaryReportInventoryClerk"].SetDataSource(dt);
                    frm.crystalReportViewer1.ReportSource = sum;
                    con.Close();
                    frm.Show();

                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}
