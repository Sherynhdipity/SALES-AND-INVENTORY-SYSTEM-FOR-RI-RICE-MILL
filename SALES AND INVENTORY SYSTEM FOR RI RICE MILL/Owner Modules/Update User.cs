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
    public partial class frmUpdateUser : Form
    {
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public frmUpdateUser()
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

        //UpdateUser
        public void UpdateUser()
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
            else if (String.IsNullOrEmpty(txtStreet.Text))
            {
                MessageBox.Show("Enter Street!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStreet.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtStreet.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtStreet.Clear();
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
            else if (!Regex.IsMatch(txtPassword.Text, @"^(?=.*[a-z]).{8,15}$"))
            {
                MessageBox.Show("Password must be 8 characters");
                txtPassword.Clear();
            }
            else if (!Regex.IsMatch(txtPassword.Text, @"^(?=.*[A-Z])"))
            {
                MessageBox.Show("Password must be have atleast 1 Uppercase letter");
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
                && txtUserName.Text != "" && txtPassword.Text != "" && txtConfirmPassword.Text != "")
            {
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    result = MessageBox.Show("Do you want to update this User?", "Update User", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            con.Close();
                            con.Open();

                            QueryUpdate = "UPDATE tblUsers SET First_name = @fName, Middle_name = @mName, Last_name = @lName, Birthday = @birthday," +
                            "Street = @street,Barangay = @brgy, Municipality = @city,Province = @province,Contact_number = @cNo," +
                            "Sex = @gender, Username = @userName, Password = @password,User_type = @userType WHERE User_id = '" + id + "'";

                            cmd = new SqlCommand(QueryUpdate, con);

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

                            MessageBox.Show("User Updated Successfully!", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();

                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            con.Close();
                        }
                        finally
                        {
                            con.Close();
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

        public void DisplayUser()
        {
            loadProvinces();

            try
            {
                con.Open();
                QuerySelect = "SELECT * from tblUsers WHERE User_id = '" + id + "'";


                cmd = new SqlCommand(QuerySelect, con);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txtFirstName.Text = dt.Rows[0]["First_name"].ToString();
                    txtMiddleName.Text = dt.Rows[0]["Middle_name"].ToString();
                    txtLastName.Text = dt.Rows[0]["Last_name"].ToString();
                    txtContact.Text = dt.Rows[0]["Contact_number"].ToString();
                    if (dt.Rows[0]["Sex"].ToString() == "Male")
                    {
                        cmbGender.SelectedIndex = 0;
                    }
                    else
                    {
                        cmbGender.SelectedIndex = 1;
                    }
                    txtStreet.Text = dt.Rows[0]["Street"].ToString();

                    //cmbMunicipality.SelectedValue = dt.Rows[0]["Municipality"].ToString();
                    //cmbBarangay.SelectedValue = dt.Rows[0]["Barangay"].ToString();
                    dtpBirthday.Value = Convert.ToDateTime(dt.Rows[0]["Birthday"].ToString());
                    txtUserName.Text = dt.Rows[0]["Username"].ToString();
                    txtPassword.Text = dt.Rows[0]["Password"].ToString();
                    txtConfirmPassword.Text = dt.Rows[0]["Password"].ToString();
                    if (dt.Rows[0]["User_type"].ToString() == "Cashier")
                    {
                        cmbUser_Type.SelectedIndex = 0;
                    }
                    else if (dt.Rows[0]["User_type"].ToString() == "Inventory Clerk")
                    {
                        cmbUser_Type.SelectedIndex = 1;
                    }
                    else if (dt.Rows[0]["User_type"].ToString() == "Administrator")
                    {
                        cmbUser_Type.SelectedIndex = 2;
                    }
                    //cmbBarangay.SelectedValue = dt.Rows[0]["Barangay"].ToString();

                    cmbProvince.SelectedValue = dt.Rows[0]["Province"].ToString();
                    //cmbMunicipality.SelectedValue = dt.Rows[0]["Municipality"].ToString();
                    // cmbBarangay.SelectedValue = dt.Rows[0]["Barangay"].ToString();

                }

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

        public void setProvince()
        {
            con.Close();
            con.Open();
            QuerySelect = "SELECT province_desc FROM tblProvinces WHERE province_code = (SELECT Province FROM tblUsers WHERE User_id = '" + id + "')";
            cmd = new SqlCommand(QuerySelect, con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                cmbMunicipality.SelectedIndex = cmbMunicipality.FindString(dt.Rows[0]["province_desc"].ToString());
            }
        }

        public void setMunicipality()
        {
            con.Close();
            con.Open();
            QuerySelect = "SELECT municipality_desc from tblMunicipality WHERE municipality_code = (SELECT Municipality FROM tblUsers WHERE User_id = '" + id + "')";
            cmd = new SqlCommand(QuerySelect, con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                cmbMunicipality.SelectedIndex = cmbMunicipality.FindString(dt.Rows[0]["municipality_desc"].ToString());
            }
        }

        public void setBarangay()
        {
            con.Close();
            con.Open();
            QuerySelect = "SELECT brgy_desc from tblBarangay WHERE brgy_code = (SELECT Barangay FROM tblUsers WHERE User_id = '" + id + "')";
            cmd = new SqlCommand(QuerySelect, con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                cmbBarangay.SelectedIndex = cmbBarangay.FindString(dt.Rows[0]["brgy_desc"].ToString());
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateUser();
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

        private void frmUpdateUser_Load(object sender, EventArgs e)
        {
            DisplayUser();
            setProvince();
            setMunicipality();
            setBarangay();
        }
    }
}
