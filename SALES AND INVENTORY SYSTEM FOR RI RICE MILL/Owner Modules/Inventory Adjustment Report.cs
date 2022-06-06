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

        private void frmInventoryAdjustmentReport_Load(object sender, EventArgs e)
        {
            dtpToDate.Enabled = false;
            dtpFromDate.Enabled = false;
            btnSearch.Enabled = false;
            btnPrint.Enabled = false;

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
                    dtpToDate.Value = DateTime.Today;
                }
            }
        }

        private void rbnDaily_CheckedChanged(object sender, EventArgs e)
        {
            dtpToDate.Enabled = false;
            dtpFromDate.Enabled = true;
            btnSearch.Enabled = true;
            btnPrint.Enabled = true;
        }

        private void rbnWeekly_CheckedChanged(object sender, EventArgs e)
        {
            dtpToDate.Enabled = false;
            dtpFromDate.Enabled = true;
            btnSearch.Enabled = true;
            btnPrint.Enabled = true;
        }

        private void rbnMonthly_CheckedChanged(object sender, EventArgs e)
        {
            dtpToDate.Enabled = false;
            dtpFromDate.Enabled = true;
            btnSearch.Enabled = true;
            btnPrint.Enabled = true;
        }

        private void rbnYearly_CheckedChanged(object sender, EventArgs e)
        {
            dtpToDate.Enabled = false;
            dtpFromDate.Enabled = true;
            btnSearch.Enabled = true;
            btnPrint.Enabled = true;
        }

        private void rbnCustom_CheckedChanged(object sender, EventArgs e)
        {

            dtpToDate.Enabled = true;
            dtpFromDate.Enabled = true;
            btnSearch.Enabled = true;
            btnPrint.Enabled = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
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
    }
    
}
