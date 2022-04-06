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

            this.ActiveControl = txtFirstName;
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
            txtBarangay.Clear();
            txtMunicipality.Clear();
            txtProvince.Clear();
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
            else if (String.IsNullOrEmpty(txtMiddleName.Text))
            {
                MessageBox.Show("Enter Middle Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMiddleName.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtMiddleName.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtMiddleName.Clear();
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
            else if (String.IsNullOrEmpty(txtBarangay.Text))
            {
                MessageBox.Show("Enter Barangay!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBarangay.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtBarangay.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtBarangay.Clear();
            }
            else if (String.IsNullOrEmpty(txtMunicipality.Text))
            {
                MessageBox.Show("Enter Municipality!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMunicipality.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtMunicipality.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtMunicipality.Clear();
            }
            else if (String.IsNullOrEmpty(txtProvince.Text))
            {
                MessageBox.Show("Enter Province!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProvince.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtProvince.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtProvince.Clear();
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
            else if (txtFirstName.Text != "" && txtMiddleName.Text != ""
                && txtLastName.Text != "" && txtContact.Text != "" && txtStreet.Text != ""
                && txtBarangay.Text != "" && txtMunicipality.Text != "" && txtProvince.Text != ""
                && txtUserName.Text != "" && txtPassword.Text != "" && txtConfirmPassword.Text != "")
            {
                if (txtPassword.Text == txtConfirmPassword.Text) {
                result = MessageBox.Show("Do you want to Add this User?", "Add User", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    con.Close();
                    con.Open();
                    QuerySelect = "SELECT * FROM tblUsers " +
                        "WHERE first_name = '" + txtFirstName.Text + "' " +
                        "AND middle_name = '" + txtMiddleName.Text + "' " +
                        "AND last_name = '" + txtLastName.Text + "' " +
                        "AND username = '" + txtUserName.Text + "'";
                    cmd = new SqlCommand(QuerySelect, con);
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("This user already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ClearControls();
                    }
                    else
                    {
                        try
                        {
                            con.Close();
                            con.Open();
                            QueryInsert = "INSERT INTO tblUsers " +
                            "(last_name,first_name,middle_name,birthday,street," +
                            "barangay,municipality,province,contact_number,sex," +
                            "username,password,user_type) " +
                            "VALUES ('" 
                            + txtLastName.Text + "', '" 
                            + txtFirstName.Text + "', '" 
                            + txtMiddleName.Text + "', '"
                            + dtpBirthday.Value.Date + "', '"
                            + txtStreet.Text + "', '"
                            + txtBarangay.Text + "', '"
                            + txtMunicipality.Text + "', '"
                            + txtProvince.Text + "', '"
                            + txtContact.Text + "', '"
                            + cmbGender.SelectedItem.ToString() + "', '"
                            + txtUserName.Text + "', '"
                            + txtPassword.Text + "', '"
                            + cmbUser_Type.SelectedItem.ToString() + "')";
                            cmd = new SqlCommand(QueryInsert, con);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("User Added Successfully!", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                           
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

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
