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
    public partial class frmInventoryAdjustmentReport : Form
    {
        public frmInventoryAdjustmentReport()
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
                QuerySelect = " Select * from InventoryAdjustmentView where [Date] between @fromDate and @ToDate";
               

                cmd = new SqlCommand(QuerySelect, con);
                cmd.Parameters.AddWithValue("@fromDate", dtpFromDate.Value);
                cmd.Parameters.AddWithValue("@ToDate", dtpToDate.Value);

                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dgvInventoryAdjust.DataSource = dt;
                dgvInventoryAdjust.Refresh();
            }
            catch (Exception ex)
            {

            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

            DataSet ds = new DataSet();
            Adjustments ad = new Adjustments();
            frmInventoryAdjust frm = new frmInventoryAdjust();

            date1 = dtpFromDate.Value.Year + "-" + dtpFromDate.Value.Month + "-" + dtpFromDate.Value.Day;
            date2 = dtpToDate.Value.Year + "-" + dtpToDate.Value.Month + "-" + dtpToDate.Value.Day;
            con.Open();

            dt = new DataTable();
            QuerySelect = "SELECT * FROM InventoryAdjustmentView WHERE [Date] BETWEEN '" + date1 + "' AND '" + date2 + "'";
            cmd = new SqlCommand(QuerySelect, con);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            ad.Database.Tables["InventoryAdjustmentView"].SetDataSource(dt);
            frm.crystalReportViewer1.ReportSource = ad;
            con.Close();
            frm.Show();
        }

        private void frmInventoryAdjustmentReport_Load(object sender, EventArgs e)
        {

            DateTime date = DateTime.Now;
            dtpFromDate.Text = string.Format("{0:D}", date);
            dtpToDate.Text = string.Format("{0:D}", date);

            QuerySelect = " Select * from InventoryAdjustmentView";

            cmd = new SqlCommand(QuerySelect, con);
         

            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvInventoryAdjust.DataSource = dt;
            dgvInventoryAdjust.Refresh();
        }
    }
}
