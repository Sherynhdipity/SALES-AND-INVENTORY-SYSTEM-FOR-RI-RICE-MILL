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
    public partial class frmCustomer : UserControl
    {

        private static frmCustomer customer;

        public static frmCustomer customersInstance
        {
            get
            {
                if (customer == null)
                    customer = new frmCustomer();
                return customer;
            }

        }

        frmAddNewCustomer addNew = new frmAddNewCustomer();
        frmUpdateCustomer updateCustomer = new frmUpdateCustomer();

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

        public frmCustomer()
        {
            InitializeComponent();
            addNew.FormClosed += new FormClosedEventHandler(Form_Closed);
            updateCustomer.FormClosed += new FormClosedEventHandler(Form_Closed1);

            DisplayCustomers();
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "";
            btn.Text = "Update";
            btn.UseColumnTextForButtonValue = true;

            dgvCustomerList.Columns.Add(btn);
        }

        void Form_Closed(object sender, FormClosedEventArgs e)
        {
            frmAddNewCustomer frm = (frmAddNewCustomer)sender;
            DisplayCustomers();
        }

        void Form_Closed1(object sender, FormClosedEventArgs e)
        {
            frmUpdateCustomer frm = (frmUpdateCustomer)sender;
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

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            addNew.ShowDialog();
        }


        private void txtViewCustomers_TextChange(object sender, EventArgs e)
        {
            DisplayCustomers();
        }

        private void dgvCustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCustomerList[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                updateCustomer.Id = dgvCustomerList[1, e.RowIndex].Value.ToString();
                updateCustomer.ShowDialog();
            }
        }

        private void btnDiscountReq_Click(object sender, EventArgs e)
        {
            frmDiscountRequirements discount = new frmDiscountRequirements();
            discount.ShowDialog();
        }
    }
}
