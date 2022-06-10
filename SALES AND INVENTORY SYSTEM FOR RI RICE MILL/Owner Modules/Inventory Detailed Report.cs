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
    public partial class frmInventoryDetailedReport : Form
    {
        public frmInventoryDetailedReport()
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

        private void InventoryDetailedReport_Load(object sender, EventArgs e)
        {
            showInventoryDetailed();
        }

        public void showInventoryDetailed()
        {

            QuerySelect = "Select * from InventoryDetailedReport";
            cmd = new SqlCommand(QuerySelect, con);

            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvInventoryDetailed.DataSource = dt;
            dgvInventoryDetailed.Refresh();

            int sum = 0;
            int sum2 = 0;
            for (int i = 0; i < dgvInventoryDetailed.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dgvInventoryDetailed.Rows[i].Cells[7].Value);
                sum2 += Convert.ToInt32(dgvInventoryDetailed.Rows[i].Cells[6].Value);
            }

            lblTotalProfit.Text = sum.ToString();
            lblTotalStockSold.Text = sum2.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            QuerySelect = "Select * from InventoryDetailedReport where (Batch_number LIKE '%' + @batch + '%') or (Description LIKE '%' + @desc + '%')";
            cmd = new SqlCommand(QuerySelect, con);
            cmd.Parameters.AddWithValue("@batch", txtSearchInventory.Text);
            cmd.Parameters.AddWithValue("@desc", txtSearchInventory.Text);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvInventoryDetailed.DataSource = dt;
            dgvInventoryDetailed.Refresh();

            int sum = 0;
            int sum2 = 0;
            for (int i = 0; i < dgvInventoryDetailed.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dgvInventoryDetailed.Rows[i].Cells[7].Value);
                sum2 += Convert.ToInt32(dgvInventoryDetailed.Rows[i].Cells[6].Value);
            }

            lblTotalProfit.Text = sum.ToString();
            lblTotalStockSold.Text = sum2.ToString();
        }

        private void txtSearchInventory_TextChanged(object sender, EventArgs e)
        {
            QuerySelect = "Select * from InventoryDetailedReport where (Batch_number LIKE '%' + @batch + '%') or (Description LIKE '%' + @desc + '%')";
            cmd = new SqlCommand(QuerySelect, con);
            cmd.Parameters.AddWithValue("@batch", txtSearchInventory.Text);
            cmd.Parameters.AddWithValue("@desc", txtSearchInventory.Text);

            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvInventoryDetailed.DataSource = dt;
            dgvInventoryDetailed.Refresh();

            int sum = 0;
            int sum2 = 0;
            for (int i = 0; i < dgvInventoryDetailed.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dgvInventoryDetailed.Rows[i].Cells[7].Value);
                sum2 += Convert.ToInt32(dgvInventoryDetailed.Rows[i].Cells[6].Value);
            }

            lblTotalProfit.Text = sum.ToString();
            lblTotalStockSold.Text = sum2.ToString();
        }

        private void dgvInventoryDetailed_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4 || e.ColumnIndex == 3)
            {
                e.CellStyle.Format = "N2";
            }
        }

        public void showInventoryDetails()
        {
            InventoryDetailed detail = new InventoryDetailed();
            frmInventoryDetailed det = new frmInventoryDetailed();
            DataTable dt = new DataTable();

            con.Open();

            if (txtSearchInventory.Text == "" || txtSearchInventory.Text == null)
            {
                QuerySelect = "Select * from InventoryDetailedReport";
                cmd = new SqlCommand(QuerySelect, con);
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                detail.Database.Tables["InventoryDetailedReport"].SetDataSource(dt);
                det.InventoryDetailedViewer.ReportSource = detail;
                con.Close();
                det.Show();

            }
            else
            {
                QuerySelect = "Select * from InventoryDetailedReport where (Batch_number LIKE '%' + @batch + '%') or (Description LIKE '%' + @desc + '%')";
                cmd = new SqlCommand(QuerySelect, con);
                cmd.Parameters.AddWithValue("@batch", txtSearchInventory.Text);
                cmd.Parameters.AddWithValue("@desc", txtSearchInventory.Text);
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                detail.Database.Tables["InventoryDetailedReport"].SetDataSource(dt);
                det.InventoryDetailedViewer.ReportSource = detail;
                con.Close();
                det.Show();
            }

            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            showInventoryDetails();
        }
    }
}
