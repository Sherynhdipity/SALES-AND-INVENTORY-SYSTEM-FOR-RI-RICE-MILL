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
    public partial class UserManagement : UserControl
    {


        private static UserManagement users;

        public static UserManagement usersInstance
        {
            get
            {
                if (users == null)
                    users = new UserManagement();
                return users;
            }
 
        }
        frmAddNewUser addNew = new frmAddNewUser();
        frmUpdateUser updateUser = new frmUpdateUser();

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
        public UserManagement()
        {
            InitializeComponent();
            addNew.FormClosed += new FormClosedEventHandler(Form_Closed);
            updateUser.FormClosed += new FormClosedEventHandler(Form_Closed1);
            DisplayUser();
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "";
            btn.Text = "Update";
            btn.UseColumnTextForButtonValue = true;

            dgvUserList.Columns.Add(btn);
        }
        void Form_Closed(object sender, FormClosedEventArgs e)
        {
            frmAddNewUser frm = (frmAddNewUser)sender;
            DisplayUser();
        }

        void Form_Closed1(object sender, FormClosedEventArgs e)
        {
            frmUpdateUser frm = (frmUpdateUser)sender;
            DisplayUser();
        }

        public void DisplayUserList()
        {
            //con.Close();
            try
            {
                con.Open();
                QuerySelect = "SELECT * from tblUsers";
                cmd = new SqlCommand(QuerySelect, con);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);

                dgvUserList.DataSource = dt;
                dgvUserList.Refresh();
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

        public void DisplayUser()
        {
            try
            {
                con.Open();

                if (txtViewUsers.Text == "" || txtViewUsers.Text == null)
                {
                    QuerySelect = "SELECT user_id as 'ID', first_name as 'First Name', " +
                   "last_name as 'Last Name' ,contact_number as 'Contact', username as 'Username'," +
                   " user_type as 'User Type' from tblUsers";
                }
                else
                {
                    QuerySelect = "SELECT user_id as 'ID', first_name as 'First Name', " +
                   "last_name as 'Last Name' ,contact_number as 'Contact', username as 'Username'," +
                   " user_type as 'User Type' from tblUsers WHERE user_id LIKE '" + txtViewUsers.Text + "%' " +
                   "OR first_name LIKE '"+txtViewUsers.Text+"%' " +
                   "OR last_name LIKE '"+txtViewUsers.Text+"%' " +
                   "OR contact_number LIKE '"+txtViewUsers.Text+"%' " +
                   "OR username LIKE '"+txtViewUsers.Text+"%' " +
                   "OR user_type LIKE '"+txtViewUsers.Text+"%'";
                } 
                
                cmd = new SqlCommand(QuerySelect, con);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dgvUserList.DataSource = dt;
               
                dgvUserList.Refresh();
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

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            
            addNew.ShowDialog();
        }

        private void dgvUserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void txtViewUsers_TextChange(object sender, EventArgs e)
        {
            DisplayUser();
        }

        private void dgvUserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUserList[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {         
                updateUser.Id = dgvUserList[1, e.RowIndex].Value.ToString();
                updateUser.ShowDialog();
            }
        }
    }
}
