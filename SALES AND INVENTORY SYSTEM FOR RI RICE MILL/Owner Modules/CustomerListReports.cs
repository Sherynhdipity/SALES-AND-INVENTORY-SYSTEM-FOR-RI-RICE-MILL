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
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Owner_Modules
{
    public partial class frmCustomerListReports : Form
    {
        public frmCustomerListReports()
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
               
                QuerySelect = "Select * from CustomerRecords where [First Name] = @first Or [Last Name] = @Last";

                cmd = new SqlCommand(QuerySelect, con);
                cmd.Parameters.AddWithValue("@first", txtSearchCustomers.Text);
                cmd.Parameters.AddWithValue("@last", txtSearchCustomers.Text);

                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dgvCustomerList.DataSource = dt;
                dgvCustomerList.Refresh();
            }
            catch(Exception ex)
            {

            }
        }
    }
}
