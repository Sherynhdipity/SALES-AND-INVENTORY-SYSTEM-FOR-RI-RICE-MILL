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


        public void DisplayUser()
        {
            try
            {
                con.Open();

                if (txtViewUsers.Text == "" || txtViewUsers.Text == null)
                {
                    QuerySelect = "SELECT * FROM UserViews";
                }
                else
                {
                    QuerySelect = "SELECT * FROM  UserViews WHERE (ID LIKE '%' + @id + '%') OR ([First Name] LIKE '%' + @fName + '%') OR ([Last Name] LIKE '%' + @lName + '%') OR ([Contact Number] LIKE '%' + @cNum + '%') OR (Username LIKE '%' + @userName + '%') OR ([User Type] LIKE '%' + @userType + '%')";
                } 
                
                cmd = new SqlCommand(QuerySelect, con);
                cmd.Parameters.AddWithValue("@id", txtViewUsers.Text);
                cmd.Parameters.AddWithValue("@fName", txtViewUsers.Text);
                cmd.Parameters.AddWithValue("@lName", txtViewUsers.Text);
                cmd.Parameters.AddWithValue("@cNum", txtViewUsers.Text);
                cmd.Parameters.AddWithValue("@userName", txtViewUsers.Text);
                cmd.Parameters.AddWithValue("@userType", txtViewUsers.Text);

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
