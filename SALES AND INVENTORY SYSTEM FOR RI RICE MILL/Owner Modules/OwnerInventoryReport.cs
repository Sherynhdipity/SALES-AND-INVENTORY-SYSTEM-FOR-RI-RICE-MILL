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

namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Owner_Modules
{
    public partial class frmOwnerInventoryReport : Form
    {
        public frmOwnerInventoryReport()
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                QuerySelect = " Select *  from InventoryReportsView where Stock_in_date between @FromDate and @ToDate";

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

        private void frmOwnerInventoryReport_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            dtpFromDate.Text = string.Format("{0:D}", date);
            dtpToDate.Text = string.Format("{0:D}", date);
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
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
                QuerySelect = "SELECT * FROM InventoryReportsView WHERE Stock_in_date BETWEEN '" + date1 + "' AND '" + date2 + "'";
                cmd = new SqlCommand(QuerySelect, con);
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                inventory.Database.Tables["InventoryReportsView"].SetDataSource(dt);
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
