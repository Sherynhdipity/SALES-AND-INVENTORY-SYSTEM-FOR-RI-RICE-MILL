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
using System.Text.RegularExpressions;

namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL
{
    public partial class frmAddNewUser : Form
    {
        public frmAddNewUser()
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

        private void frmAddNewUser_Load(object sender, EventArgs e)
        {
            cmbGender.SelectedIndex = 0;
            cmbUser_Type.SelectedIndex = 0;

          //  this.ActiveControl = txtFirstName;

            loadProvinces();
        }

        //methods

        //clear controls
        public void ClearControls()
        {
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtLastName.Clear();
            txtContact.Clear();
            txtStreet.Clear();
            cmbBarangay.SelectedIndex =0;
            cmbMunicipality.SelectedIndex = 0;
            cmbProvince.SelectedIndex =0;
            txtUserName.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            cmbGender.SelectedIndex = 0;
            cmbUser_Type.SelectedIndex = 0;
        } 
        //AddUser

        public void AddUser()
        {
            con.Close();

            if (String.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Enter First Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtFirstName.Clear();
            }
            //else if (String.IsNullOrWhiteSpace(txtMiddleName.Text))
            //{
            // MessageBox.Show("Whitespace is not allowed!");
            // txtMiddleName.Clear();
            //}
            else if (String.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Enter Last Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtLastName.Clear();
            }
            else if (String.IsNullOrEmpty(txtContact.Text))
            {
                MessageBox.Show("Enter Contact Number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContact.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtContact.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtContact.Clear();
            }
            else if (String.IsNullOrWhiteSpace(txtStreet.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtStreet.Clear();
            }
            else if (String.IsNullOrEmpty(cmbBarangay.Text))
            {
                MessageBox.Show("Enter Barangay!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbBarangay.Focus();
            }
            else if (String.IsNullOrWhiteSpace(cmbBarangay.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                cmbBarangay.Items.Clear();
            }
            else if (String.IsNullOrEmpty(cmbMunicipality.Text))
            {
                MessageBox.Show("Enter Municipality!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMunicipality.Focus();
            }
            else if (String.IsNullOrWhiteSpace(cmbMunicipality.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                cmbMunicipality.Items.Clear();
            }
            else if (String.IsNullOrEmpty(cmbProvince.Text))
            {
                MessageBox.Show("Enter Province!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbProvince.Focus();
            }
            else if (String.IsNullOrWhiteSpace(cmbProvince.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                cmbProvince.Items.Clear();
            }
            else if (String.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Enter Username!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtUserName.Clear();
            }
            else if (String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Enter Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtPassword.Clear();
            }
            else if (String.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                MessageBox.Show("Enter Confirm Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtConfirmPassword.Clear();
            }
            else if (dtpBirthday.Value.ToString() == "")
            {
                MessageBox.Show("Please select date!");
                dtpBirthday.Focus();
                return;
            }
            else if (!Regex.IsMatch(txtPassword.Text, @"^(?=.*[a-z]).{8,15}$"))
            {
                MessageBox.Show("Password is minimum of 8 characters");
                txtPassword.Clear();
            }
            else if (!Regex.IsMatch(txtPassword.Text, @"^(?=.*[A-Z])"))
            {
                MessageBox.Show("Password must have atleast 1 Uppercase letter");
            }
            else if (!Regex.IsMatch(txtPassword.Text, @"^(?=.*[@$!%*#?&_])"))
            {
                MessageBox.Show("Password must have atleast 1 special characters");
            }
            else if (!Regex.IsMatch(txtContact.Text, @"^(09)\d{9}$"))
            {
                MessageBox.Show("Phone number must be 11 digit only");

            }
            else if (!Regex.IsMatch(txtFirstName.Text, @"^([a-zA-Z-.]+?)([-\s'][a-zA-Z]+)*?$"))
            {
                MessageBox.Show("First Name must be a letter only");

            }

            else if (!Regex.IsMatch(txtLastName.Text, @"^([a-zA-Z-.]+?)([-\s'][a-zA-Z]+)*?$"))
            {
                MessageBox.Show("Last name must be letter only");
                
            }
            else if (!Regex.IsMatch(txtStreet.Text, @"^[A-Za-z0-9\s@]*$"))
            {
                MessageBox.Show("Invalid Street");
            }
            else if (!Regex.IsMatch(txtUserName.Text, @"^[A-Za-z0-9_!@#$%^&*()+={}[]*$"))
            {
                MessageBox.Show("Invalid Username");
            }
            else if (txtFirstName.Text != ""
                && txtLastName.Text != "" && txtContact.Text != "" && txtStreet.Text != ""
                && cmbBarangay.Text != "" && cmbMunicipality.Text != "" && cmbProvince.Text != ""
                && txtUserName.Text != "" && txtPassword.Text != "" && txtConfirmPassword.Text != "")
            {
                if (txtPassword.Text == txtConfirmPassword.Text) {
                    result = MessageBox.Show("Do you want to Add this User?", "Add User", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        con.Close();
                        con.Open();
                        QuerySelect = "SELECT * FROM tblUsers WHERE Username = @uName";

                        cmd = new SqlCommand(QuerySelect, con);
                        cmd.Parameters.AddWithValue("@uName", txtUserName.Text);

                        reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            MessageBox.Show("This user already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtUserName.Clear();
                        }
                        else
                        {
                            try
                            {
                                con.Close();
                                con.Open();
                                QueryInsert = "INSERT INTO tblUsers (Last_name,First_name,Middle_name,Birthday,Street," +
                                "Barangay,Municipality,Province,Contact_number,Sex,Username,Password,User_type) " +
                                "VALUES (@lName, @fName, @mName, @birthday, @street, @brgy, @city, @province, @cNo, @gender, @username, @password, @userType)";

                                cmd = new SqlCommand(QueryInsert, con);

                                cmd.Parameters.AddWithValue("@fName", txtFirstName.Text);
                                cmd.Parameters.AddWithValue("@mName", txtMiddleName.Text);
                                cmd.Parameters.AddWithValue("@lName", txtLastName.Text);
                                cmd.Parameters.AddWithValue("@birthday", dtpBirthday.Value.Date);
                                cmd.Parameters.AddWithValue("@province", cmbProvince.SelectedValue.ToString());
                                cmd.Parameters.AddWithValue("@city", cmbMunicipality.SelectedValue.ToString());
                                cmd.Parameters.AddWithValue("@brgy", cmbBarangay.SelectedValue.ToString());
                                cmd.Parameters.AddWithValue("@street", txtStreet.Text);
                                cmd.Parameters.AddWithValue("@cNo", txtContact.Text);
                                cmd.Parameters.AddWithValue("@gender", cmbGender.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@userName", txtUserName.Text);
                                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                                cmd.Parameters.AddWithValue("@userType", cmbUser_Type.SelectedItem.ToString());

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("User Added Successfully!", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                                ClearControls();

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
                else
                {
                    MessageBox.Show("Password Don't Match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtConfirmPassword.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please Provide Details!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void loadProvinces()
        {
            con.Close();
            con.Open();
            QuerySelect = "Select * From tblProvinces WHERE psg_code = '126500000'";
            cmd = new SqlCommand(QuerySelect, con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            cmd.ExecuteNonQuery();
            con.Close();

            cmbProvince.DisplayMember = "province_desc";
            cmbProvince.ValueMember = "province_code";
            cmbProvince.DataSource = dt;

        }

        public void loadMunicipalities()
        {
            con.Close();
            con.Open();
            QuerySelect = "Select * From tblMunicipality Where province_code = '"+cmbProvince.SelectedValue+ "' Order by municipality_desc ASC";
            cmd = new SqlCommand(QuerySelect, con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            cmd.ExecuteNonQuery();
            con.Close();

            cmbMunicipality.DisplayMember = "municipality_desc";
            cmbMunicipality.ValueMember = "municipality_code";
            cmbMunicipality.DataSource = dt;
        }

        public void loadBarangays()
        {
            con.Close();
            con.Open();
            QuerySelect = "Select * From tblBarangay Where municipality_code = '" + cmbMunicipality.SelectedValue + "' Order by brgy_desc ASC";
            cmd = new SqlCommand(QuerySelect, con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            cmd.ExecuteNonQuery();
            con.Close();

            cmbBarangay.DisplayMember = "brgy_desc";
            cmbBarangay.ValueMember = "brgy_code";
            cmbBarangay.DataSource = dt;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadMunicipalities();
        }

        private void cmbMunicipality_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadBarangays();
        }

        private void chkViewPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkViewPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStreet_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
