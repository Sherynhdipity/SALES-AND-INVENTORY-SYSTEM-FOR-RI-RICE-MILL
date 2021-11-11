using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Cashier_Modules
{
    public partial class Print_Receipt : Form
    {
        public static SqlConnection con = new SqlConnection(DBConnection.con);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader reader;
        public static SqlDataAdapter adapter;
        public Print_Receipt()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Print_Receipt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBSalesandInventoryDataSet.viewForReciept' table. You can move, or remove it, as needed.
            this.viewForRecieptTableAdapter.Fill(this.dBSalesandInventoryDataSet.viewForReciept);

        }
    }
}
