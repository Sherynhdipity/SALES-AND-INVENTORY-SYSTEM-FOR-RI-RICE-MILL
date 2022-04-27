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
    public partial class frmRestockReport : Form
    {
        public frmRestockReport()
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


        private void btnSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvSalesOwnerReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RestockReport_Load(object sender, EventArgs e)
        {
            try
            {

                con.Open();

                string query = "SELECT * FROM RestockListReportView";
                cmd = new SqlCommand(query, con);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvRestockReport.DataSource = dt;
                dgvRestockReport.Refresh();


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
