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

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                QuerySelect = " Select *  from InventoryReportView where Stock_in_date between @FromDate and @ToDate";

                cmd = new SqlCommand(QuerySelect, con);
                cmd.Parameters.AddWithValue("@FromDate", dtpFromDate.Value);
                cmd.Parameters.AddWithValue("@ToDate", dtpToDate.Value);

                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dgvInventoryOwnerReport.DataSource = dt;
                dgvInventoryOwnerReport.Refresh();

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
            InventoryReport inventory = new InventoryReport();
            frmInventoryReport frm = new frmInventoryReport();

            try
            {
                date1 = dtpFromDate.Value.Year + "-" + dtpFromDate.Value.Month + "-" + dtpFromDate.Value.Day;
                date2 = dtpToDate.Value.Year + "-" + dtpToDate.Value.Month + "-" + dtpToDate.Value.Day;
                con.Open();

                dt = new DataTable();
                QuerySelect = "SELECT * FROM InventoryReportView WHERE Stock_in_date BETWEEN '" + date1 + "' AND '" + date2 + "'";
                cmd = new SqlCommand(QuerySelect, con);
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                inventory.Database.Tables["InventoryReportView"].SetDataSource(dt);
                frm.InventoryReportViewer1.ReportSource = inventory;
                con.Close();
                frm.Show();



            }
            catch (Exception ex)
            {

            }
        }
    }
}
