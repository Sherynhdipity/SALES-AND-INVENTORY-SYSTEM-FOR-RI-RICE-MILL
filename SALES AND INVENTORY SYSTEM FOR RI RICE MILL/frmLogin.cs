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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public static SqlConnection con = new SqlConnection(DBConnection.con);
        public static SqlCommand cmd;
        public static SqlDataReader reader;
        public static string QuerySelect;
        public static string GetUserID;
        public static string GetUserName;
        public static string GetUserUsername;
        public static string GetUserRole;
        public static string GetUserStatus;

        private void ClearControls()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Log-in from the System?", "Login", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                if (txtUsername.Text == "")
                {
                    MessageBox.Show("Enter your Username first", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsername.Focus();
                }
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("Enter your Password first", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Focus();
                }
                else
                {
                    try
                    {
                        QuerySelect = "SELECT a.UserID as 'UserID', a.Name as 'Name', a.Username as 'Username', a.Password as 'Password', a.Status as 'Status', b.Role as 'Role' FROM tblUsers a INNER JOIN tblRoles b ON a.RoleID = b.RoleID  WHERE Username='" + txtUsername.Text + "' AND Password='" + txtPassword.Text + "'";
                        con.Close();
                        con.Open();
                        cmd = new SqlCommand(QuerySelect, con);
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            reader.Read();
                            GetUserID = reader["UserID"].ToString();
                            GetUserName = reader["Name"].ToString();
                            GetUserUsername = reader["Username"].ToString();
                            GetUserRole = reader["Role"].ToString();
                            GetUserStatus = reader["Status"].ToString();

                            if (reader[4].ToString() == "Inactive")
                            {
                                MessageBox.Show("Can't log-in into the system. Admin has deactivated your account", "User Deactivated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                switch (reader[5].ToString())
                                {
                                    case "Administrator":
                                        {
                                            MessageBox.Show("Welcome user " + GetUserName + "\n" + GetUserRole);
                                            frmMainOwner main = new frmMainOwner();
                                            main.Show();
                                            this.Hide();
                                            break;
                                        }
                                    case "Cashier":
                                        {
                                            MessageBox.Show("Welcome user " + GetUserName + "\n" + GetUserRole);
                                            frmMainSales sales = new frmMainSales();
                                            sales.Show();
                                            this.Hide();
                                            break;
                                        }
                                    case "Inventory Clerk":
                                        {
                                            MessageBox.Show("Welcome user " + GetUserName + "\n" + GetUserRole);
                                            frmMainInventory inventory = new frmMainInventory();
                                            inventory.Show();
                                            this.Hide();
                                            break;
                                        }
                                    default:
                                        {
                                            MessageBox.Show("Enter Correct Username and Password");
                                            break;
                                        }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Account! Try Again", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ClearControls();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    finally
                    {
                        reader.Close();
                        con.Close();
                    }
                }
            }
           
        }
        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            lblTime.Text = time.ToString("h:mm:ss tt");

            DateTime date = DateTime.Now;
            lblDayDate.Text = string.Format("{0:D}", date);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
