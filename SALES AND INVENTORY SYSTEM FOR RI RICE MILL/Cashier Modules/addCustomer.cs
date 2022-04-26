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

namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Cashier_Modules
{
    public partial class addCustomer : Form
    {
        public addCustomer()
        {
            InitializeComponent();
        }

        public static SqlConnection con = new SqlConnection(DBConnection.con);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader reader;
        public static SqlDataAdapter adapter;
        public static DataTable dt = new DataTable();
        public static DialogResult result;
        public static string QueryInsert;
        public static string QuerySelect;
        public static string QueryUpdate;
        public static string QueryDelete;
        public static string status = "Active";
        public string customerID;

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmPayment payment = new frmPayment();
            payment.ShowDialog();
        }

        private void addCustomer_Load(object sender, EventArgs e)
        {
            DisplayCustomers();
        }

        public void DisplayCustomers()
        {
            try
            {
                con.Open();

                if (txtViewCustomers.Text == "" || txtViewCustomers.Text == null)
                {
                    QuerySelect = "SELECT * from CustomerViews";
                }
                else
                {
                    QuerySelect = "SELECT * FROM  CustomerViews WHERE (ID LIKE '%' + @id + '%') OR ([First Name] LIKE '%' + @fName + '%') OR ([Last Name] LIKE '%' + @lName + '%') OR ([Contact Number] LIKE '%' + @cNum + '%') OR ([Discount Code] LIKE '%' + @discount + '%')";

                  


                }

                cmd = new SqlCommand(QuerySelect, con);

                cmd.Parameters.AddWithValue("@id", txtViewCustomers.Text);
                cmd.Parameters.AddWithValue("@fName", txtViewCustomers.Text);
                cmd.Parameters.AddWithValue("@lName", txtViewCustomers.Text);
                cmd.Parameters.AddWithValue("@cNum", txtViewCustomers.Text);
                cmd.Parameters.AddWithValue("@province", txtViewCustomers.Text);
                cmd.Parameters.AddWithValue("@city", txtViewCustomers.Text);
                cmd.Parameters.AddWithValue("@street", txtViewCustomers.Text);
                cmd.Parameters.AddWithValue("@discount", txtViewCustomers.Text);


                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dgvCustomerList.DataSource = dt;

                dgvCustomerList.Refresh();
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

        private void dgvCustomerList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.Close();
            //customerID = dgvCustomerList.Rows[e.RowIndex].Cells[0].Value.ToString();
            //frmPayment payment = new frmPayment();
            //payment.CustomerID = customerID;
            //payment.ShowDialog();
            
        }



        private void dgvCustomerList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
  
            //Form2 = new Form2(myValue); //you pass it to Form2
        }
    }
}
