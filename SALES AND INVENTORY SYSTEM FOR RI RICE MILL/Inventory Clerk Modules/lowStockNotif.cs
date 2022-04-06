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

namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL
{
    public partial class lowStockNotif : Form
    {

        public static SqlConnection con = new SqlConnection(DBConnection.con);
        public static SqlCommand cmd = new SqlCommand();
        public lowStockNotif()
        {
            InitializeComponent();
            popDgv();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void lowStockNotif_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBSalesandInventoryDataSet2.lowstocks' table. You can move, or remove it, as needed.
            //this.lowstocksTableAdapter.Fill(this.dBSalesandInventoryDataSet2.lowstocks);
            // TODO: This line of code loads data into the 'dBSalesandInventoryDataSet1.viewAvailableStocks' table. You can move, or remove it, as needed.
            //this.viewAvailableStocksTableAdapter.Fill(this.dBSalesandInventoryDataSet1.viewAvailableStocks);
            //popDgv();
        }
        void popDgv()
        {
            try
            {

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                con.Open();

                string query = "Select ID, Description, Unit, SKU, [Batch Quantity], [Critical Level] from InventoryView WHERE  [Batch Quantity] < [Critical Level]";
                cmd = new SqlCommand(query, con);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvLLS.DataSource = dt;
                dgvLLS.Refresh();


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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
