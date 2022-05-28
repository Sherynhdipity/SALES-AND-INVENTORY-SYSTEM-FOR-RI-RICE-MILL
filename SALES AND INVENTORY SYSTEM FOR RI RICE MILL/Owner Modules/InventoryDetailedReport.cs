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

        private void dgvInventoryDetailed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

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
                sum += Convert.ToInt32(dgvInventoryDetailed.Rows[i].Cells[6].Value);
                sum2 += Convert.ToInt32(dgvInventoryDetailed.Rows[i].Cells[4].Value);
            }

            lblTotalProfit.Text = sum.ToString();
            lblTotalStockSold.Text = sum2.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            QuerySelect = "Select * from InventoryDetailedReport where Batch_number = @batch or Description = @desc";
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
                sum += Convert.ToInt32(dgvInventoryDetailed.Rows[i].Cells[6].Value);
                sum2 += Convert.ToInt32(dgvInventoryDetailed.Rows[i].Cells[4].Value);
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
                sum += Convert.ToInt32(dgvInventoryDetailed.Rows[i].Cells[6].Value);
                sum2 += Convert.ToInt32(dgvInventoryDetailed.Rows[i].Cells[4].Value);
            }

            lblTotalProfit.Text = sum.ToString();
            lblTotalStockSold.Text = sum2.ToString();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }
    }
}
