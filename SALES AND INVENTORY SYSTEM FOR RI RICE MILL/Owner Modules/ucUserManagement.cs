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
    public partial class ucUsers : UserControl
    {
        private static ucUsers users;
        public static ucUsers usersInstance
        {
            get
            {
                if (users == null)
                    users = new ucUsers();
                return users;
            }
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


        public ucUsers()
        {
            InitializeComponent();
        }

        //Display Data in DataGridView  
        public void DisplayUserList()
        {
            con.Close();
            con.Open();
            QuerySelect = "SELECT a.Name as 'Name', a.Username as 'Username', a.Status as 'Status', b.Role as 'Role' FROM tblUsers a INNER JOIN tblRoles b ON a.RoleID = b.RoleID ORDER BY UserID DESC";
            cmd = new SqlCommand(QuerySelect, con);

            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);

            dgvUserList.DataSource = dt;
            dgvUserList.Refresh();
            con.Close();
        }
        //Clear Data  
        public void ClearControls()
        {
            txtName.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmPass.Text = "";
            drpRole.Text = "";
            drpStatus.Text = "";
        }

        //Method AddUser
        private void AddUser()
        {
            if (String.IsNullOrEmpty(txtName.Text) && String.IsNullOrEmpty(txtUsername.Text) && String.IsNullOrEmpty(txtPassword.Text) && String.IsNullOrEmpty(drpRole.Text) && String.IsNullOrEmpty(drpStatus.Text))
            {
                MessageBox.Show("Fields should not be empty!");
            }
            else if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Enter Name first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtName.Clear();
            }
            else if (String.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Enter Username first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtUsername.Clear();
            }
            else if (String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Enter Password first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtPassword.Clear();
            }
            else if (txtName.Text != "" && txtUsername.Text != "" && txtPassword.Text != "" && drpRole.Text != "")
            {
                result = MessageBox.Show("Do you want to Add this User?", "Add User", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        con.Close();
                        con.Open();
                        QueryInsert = "INSERT INTO tblUsers (Name,Username,Password,Status,RoleID) VALUES ('" + txtName.Text + "', '" + txtUsername.Text + "', '" + txtPassword.Text + "', '" + status + "', (SELECT RoleID FROM tblRoles WHERE Role = '" + drpRole.SelectedItem.ToString() + "'))";
                        cmd = new SqlCommand(QueryInsert, con);
                        cmd.ExecuteNonQuery();
                        DisplayUserList();
                        ClearControls();
                        MessageBox.Show("User Added Successfully!", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        //MessageBox.Show("This user already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Provide Details!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Method UpdateUser
        private void UpdateUser()
        {
            result = MessageBox.Show("Do you want to update this user?", "Update User", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (String.IsNullOrEmpty(txtName1.Text) && String.IsNullOrEmpty(txtUsername1.Text) && String.IsNullOrEmpty(drpRole.Text) && String.IsNullOrEmpty(drpStatus.Text))
                {
                    MessageBox.Show("Please Select User to Update");
                    dgvUserList.Visible = true;
                    DisplayUserList();
                }
                else if (String.IsNullOrEmpty(txtName.Text))
                {
                    MessageBox.Show("Enter Name first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtName.Focus();
                }
                else if (String.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Whitespace is not allowed!");
                    txtName.Clear();
                }
                else if (String.IsNullOrEmpty(txtUsername.Text))
                {
                    MessageBox.Show("Enter Username first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                }
                else if (String.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    MessageBox.Show("Whitespace is not allowed!");
                    txtUsername.Clear();
                }
                else
                {
                    try
                    {
                        con.Close();
                        con.Open();
                        QueryUpdate = "UPDATE tblUsers SET Name = '" + txtName1.Text + "', Username = '" + txtUsername1.Text + "', Status = '" + drpStatus.Text + "', RoleID = (SELECT RoleID FROM tblRoles WHERE Role = '" + drpRole.Text + "') WHERE UserID = '" + lblUserID.Text + "'";
                        cmd = new SqlCommand(QueryUpdate, con);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("User Updated Successfully!", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplayUserList();
                        ClearControls();

 

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("This User already exists. Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //MessageBox.Show(drpRole.SelectedItem.ToString());
                    }

                    finally
                    {
                        con.Close();
                    }
                }
            }
        }

        private void dgvUserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvUserList.Rows[e.RowIndex];


                txtName.Text = row.Cells[0].Value.ToString();
                txtUsername.Text = row.Cells[1].Value.ToString();
                drpStatus.Text = row.Cells[2].Value.ToString();
                drpRole.Text = row.Cells[3].Value.ToString();


                con.Close();
                con.Open();
                QuerySelect = "SELECT UserID FROM tblUsers WHERE Name='" + txtName.Text + "'";
                cmd = new SqlCommand(QuerySelect, con);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    lblUserID.Text = reader["UserID"].ToString();
                    reader.Close();
                }
                con.Close();

            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            dgvUserList.Visible = false;
            panelAdd.Visible = true;
            btnUpdate.Visible = false;

            drpStatus.Visible = false;
            lblStatus.Visible = false;

            lblAddUser.Visible = true;
            lblUserList.Visible = false;
            lblUpdateUser.Visible = false;

            //Password

            bunifuLabel4.Visible = true;
            txtPassword.Visible = true;
            txtConfirmPass.Visible = true;
            lblPassNotif.Visible = true;
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = true;
            btnUpdate.Visible = true;
            lblUpdateUser.Visible = true;
            lblAddUser.Visible = false;
            lblUserList.Visible = false;
            dgvUserList.Visible = false;


            drpStatus.Visible = true;
            lblStatus.Visible = true;

            //Password

            bunifuLabel4.Visible = false;
            txtPassword.Visible = false;
            txtConfirmPass.Visible = false;
            lblPassNotif.Visible = false;


        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            lblUserList.Visible = true;
            lblAddUser.Visible = false;
            lblUpdateUser.Visible = false;
            panelAdd.Visible = false;
            dgvUserList.Visible = true;
            DisplayUserList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            UpdateUser();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void ucUsers_Load(object sender, EventArgs e)
        {

        }

        private void txtConfirmPass_TextChange(object sender, EventArgs e)
        {
            if(txtConfirmPass.Text == txtPassword.Text)
            {
                lblPassNotif.ForeColor = System.Drawing.Color.Green;
                lblPassNotif.Text = "Passwords Matched";
            }
            else
            {
                lblPassNotif.ForeColor = System.Drawing.Color.Red;
                lblPassNotif.Text = "Passwords Don't Match";
            }
        }
    }
}
