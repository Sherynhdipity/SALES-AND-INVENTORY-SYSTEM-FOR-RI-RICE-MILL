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

        string first;
        string last;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                
                QuerySelect = " Select * from CustomerRecords where ([First Name] LIKE '%' + @first + '%') Or ([Last Name] LIKE '%' + @last + '%')";
                
             
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

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            CustomerList cust = new CustomerList();
            frmCustomerLists list = new frmCustomerLists();
           
            try
            {
                
                con.Open();
                dt = new DataTable();

                if (txtSearchCustomers.Text == "" || txtSearchCustomers.Text == null)
                {
                    QuerySelect = "Select * from CustomerRecords";
                    cmd = new SqlCommand(QuerySelect, con);
                    adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    cust.Database.Tables["CustomerRecords"].SetDataSource(dt);
                    list.CustomerListViewer.ReportSource = cust;
                    con.Close();
                    list.Show();
                }
                else
                {
                    QuerySelect = " Select * from CustomerRecords where ([First Name] LIKE '%' + @first + '%') Or ([Last Name] LIKE '%' + @last + '%')";
                    cmd = new SqlCommand(QuerySelect, con);
                    adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    cust.Database.Tables["CustomerRecords"].SetDataSource(dt);
                    list.CustomerListViewer.ReportSource = cust;
                    con.Close();
                    list.Show();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void frmCustomerListReports_Load(object sender, EventArgs e)
        {
            try
            {

                QuerySelect = "Select * from CustomerRecords";

                cmd = new SqlCommand(QuerySelect, con);

                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dgvCustomerList.DataSource = dt;
                dgvCustomerList.Refresh();
            }
            catch (Exception ex)
            {

            }
        }

        private void dgvCustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvCustomerList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                e.CellStyle.Format = "N2";
            }
        }
    }
}
