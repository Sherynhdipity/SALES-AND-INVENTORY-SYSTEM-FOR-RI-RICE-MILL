using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;

namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Owner_Modules
{
    public partial class frmInventoryValuation : Form
    {
        public frmInventoryValuation()
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

        private void InventoryValuation_Load(object sender, EventArgs e)
        {
           
            QuerySelect = "Select Batch_number, Description, [In Stock], Cost_Price, Price, [Item Total Cost], [Total Selling Price], [Total Selling Price] - [Item Total Cost] as [Potential Profit]  from InventoryValuationView";

            cmd = new SqlCommand(QuerySelect, con);
            cmd.Parameters.AddWithValue("@batch", txtSearchInventory.Text);
            cmd.Parameters.AddWithValue("@desc", txtSearchInventory.Text);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvInventoryValuation.DataSource = dt;
            dgvInventoryValuation.Refresh();

            double sum = 0;
            for (int i = 0; i < dgvInventoryValuation.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dgvInventoryValuation.Rows[i].Cells[7].Value);
            }

            lblTotalProfit.Text = sum.ToString("N2");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                QuerySelect = "Select Batch_number, Description, [In Stock], Cost_Price, Price, [Item Total Cost], [Total Selling Price], [Total Selling Price] - [Item Total Cost] as [Potential Profit]  from InventoryValuationView where (Batch_number LIKE '%' + @batch + '%') or (Description LIKE '%' + @desc + '%')";

                cmd = new SqlCommand(QuerySelect, con);
                cmd.Parameters.AddWithValue("@batch", txtSearchInventory.Text);
                cmd.Parameters.AddWithValue("@desc", txtSearchInventory.Text);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dgvInventoryValuation.DataSource = dt;
                dgvInventoryValuation.Refresh();

                float sum = 0;
                for (int i = 0; i < dgvInventoryValuation.Rows.Count; i++)
                {
                    sum += Convert.ToInt32(dgvInventoryValuation.Rows[i].Cells[7].Value);
                }

                lblTotalProfit.Text = sum.ToString("N2");
            }
            catch (Exception ex)
            {

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (dgvInventoryValuation.Rows.Count == 0)
            {
                MessageBox.Show("No Data");
            }
            else
            {
                showInventoryValuation();
            }
        }

        public void showInventoryValuation()
        {

            InventoryValuation valuation = new InventoryValuation();
            frmInventoryValuationReport frm = new frmInventoryValuationReport();
            DataSet dt = new DataSet();
            if (txtSearchInventory.Text == "" || txtSearchInventory.Text == null)
            {
                QuerySelect = "Select Batch_number, Description, [In Stock], Cost_Price, Price, [Item Total Cost], [Total Selling Price], [Total Selling Price] - [Item Total Cost] as [Potential Profit]  from InventoryValuationView where (Batch_number LIKE '%' + @batch + '%') OR (Description LIKE '%' + @desc + '%')";
                
            }
            else
            {
                QuerySelect = "Select Batch_number, Description, [In Stock], Cost_Price, Price, [Item Total Cost], [Total Selling Price], [Total Selling Price] - [Item Total Cost] as [Potential Profit]  from InventoryValuationView";
            }

            cmd = new SqlCommand(QuerySelect, con);
            cmd.Parameters.AddWithValue("@batch", txtSearchInventory.Text);
            cmd.Parameters.AddWithValue("@desc", txtSearchInventory.Text);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            valuation.Database.Tables["InventoryValuationView"].SetDataSource(dt);
            frm.InventoryValuationViewer.ReportSource = valuation;
            con.Close();
            frm.Show();

        }

        private void txtSearchInventory_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchInventory.Text == "" || txtSearchInventory.Text == null)
            {
                QuerySelect = "Select Batch_number, Description, [In Stock], Cost_Price, Price, [Item Total Cost], [Total Selling Price], [Total Selling Price] - [Item Total Cost] as [Potential Profit]  from InventoryValuationView";
            }
            else
            {
                QuerySelect = "Select Batch_number, Description, [In Stock], Cost_Price, Price, [Item Total Cost], [Total Selling Price], [Total Selling Price] - [Item Total Cost] as [Potential Profit]  from InventoryValuationView where (Batch_number LIKE '%' + @batch + '%') OR (Description LIKE '%' + @desc + '%')";
            }

            cmd = new SqlCommand(QuerySelect, con);
            cmd.Parameters.AddWithValue("@batch", txtSearchInventory.Text);
            cmd.Parameters.AddWithValue("@desc", txtSearchInventory.Text);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvInventoryValuation.DataSource = dt;
            dgvInventoryValuation.Refresh();

            float sum = 0;
            for (int i = 0; i < dgvInventoryValuation.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dgvInventoryValuation.Rows[i].Cells[7].Value);
            }

            lblTotalProfit.Text = sum.ToString("N2");
        }

        private void dgvInventoryValuation_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 || e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 6 || e.ColumnIndex == 7)
            {
                e.CellStyle.Format = "N2";
            }
        }

        private void dgvInventoryValuation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
