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
    public partial class ReStockInventory : Form
    {
        public ReStockInventory()
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

        private void ReStockInventory_Load(object sender, EventArgs e)
        {
            try
            {

                con.Open();

                string query = "SELECT * FROM lowStockView WHERE [Available Stock] < [Restock Level]";
                cmd = new SqlCommand(query, con);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvSalesOwnerReport.DataSource = dt;
                dgvSalesOwnerReport.Refresh();


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

        private void dgvRestockReport_Scroll(object sender, ScrollEventArgs e)
        {
           
        }

        private void dgvStockIN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            frmInventoryReport frm = new frmInventoryReport();
            RestockReports restock = new RestockReports();

            dt = new DataTable();
            QuerySelect = "SELECT * FROM lowStockView WHERE [Available Stock] < [Restock Level]";
            cmd = new SqlCommand(QuerySelect, con);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            restock.Database.Tables["lowStockView"].SetDataSource(dt);
            frm.InventoryReportViewer1.ReportSource = restock;
            con.Close();
            frm.Show();
        }
    }
}
