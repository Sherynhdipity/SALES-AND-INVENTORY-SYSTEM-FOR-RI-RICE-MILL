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
    public partial class frmOwnerSalesReport : Form
    {
        public frmOwnerSalesReport()
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


        private void dtpMilledDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmOwnerSalesReport_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowReport();
        }

        public void ShowReport()
        {
            try
            {
                QuerySelect = "Select * from SalesReportView where Order_date between @FromDate and @ToDate";
                    
                cmd = new SqlCommand(QuerySelect, con);
                cmd.Parameters.AddWithValue("@FromDate", dtpFromDate.Value);
                cmd.Parameters.AddWithValue("@ToDate", dtpToDate.Value);

                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
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
    }
}
