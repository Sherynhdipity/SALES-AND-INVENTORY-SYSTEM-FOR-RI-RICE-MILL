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
    public partial class frmUpdateUser : Form
    {
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
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

        public frmUpdateUser()
        {
            InitializeComponent();
            
           
        }

        private void frmUpdateUser_Load(object sender, EventArgs e)
        {
            DisplayUser();

        }

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

        //Method UpdateUser

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
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    result = MessageBox.Show("Do you want to update this User?", "Update User", MessageBoxButtons.YesNo);
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
                            this.Close();
                        }
                        else
                        {
                            try
                            {
                                con.Close();
                                con.Open();
                                QueryUpdate = "Update tblUsers Set " +
                                "last_name ='" + txtLastName.Text + "',first_name = '" + txtFirstName.Text + "'" +
                                ",middle_name = '" + txtMiddleName.Text + "',birthday = '" + dtpBirthday.Value.Date +
                                "',street = '" + txtStreet.Text + "',barangay = '" + txtBarangay.Text + "'" +
                                ",municipality = '" + txtMunicipality.Text + "',province = '" + txtProvince.Text + "'" +
                                ",contact_number = '" + txtContact.Text + "', sex = '" + cmbGender.SelectedItem.ToString() + "'" +
                                ",username = '" + txtUserName.Text + "', password = '" + txtPassword.Text + "'" +
                                ",user_type = '" + cmbUser_Type.SelectedItem.ToString() + "' WHERE user_id = '" + id + "'";
                               
                                cmd = new SqlCommand(QueryUpdate, con);
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

        public void DisplayUser()
        {
            try
            {
                con.Open();
                QuerySelect = "SELECT * from tblUsers WHERE user_id = '"+id+"'";
                

                cmd = new SqlCommand(QuerySelect, con);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txtFirstName.Text =  dt.Rows[0]["first_name"].ToString();
                    txtMiddleName.Text = dt.Rows[0]["middle_name"].ToString();
                    txtLastName.Text = dt.Rows[0]["last_name"].ToString();
                    txtContact.Text = dt.Rows[0]["contact_number"].ToString();
                    if (dt.Rows[0]["sex"].ToString() == "Male")
                    {
                        cmbGender.SelectedIndex = 0;
                    }
                    else
                    {
                        cmbGender.SelectedIndex = 1;
                    }
                    txtStreet.Text = dt.Rows[0]["street"].ToString();
                    txtBarangay.Text = dt.Rows[0]["barangay"].ToString();
                    txtMunicipality.Text = dt.Rows[0]["municipality"].ToString();
                    txtProvince.Text = dt.Rows[0]["province"].ToString();
                    dtpBirthday.Value = Convert.ToDateTime(dt.Rows[0]["birthday"].ToString());
                    txtUserName.Text = dt.Rows[0]["username"].ToString();
                    txtPassword.Text = dt.Rows[0]["password"].ToString();
                    txtConfirmPassword.Text = dt.Rows[0]["password"].ToString();
                    if (dt.Rows[0]["user_type"].ToString() == "Cashier")
                    {
                        cmbUser_Type.SelectedIndex = 0;
                    }
                    else if(dt.Rows[0]["user_type"].ToString() == "Inventory Clerk")
                    {
                        cmbUser_Type.SelectedIndex = 1;
                    }
                    else if (dt.Rows[0]["user_type"].ToString() == "Administrator")
                    {
                        cmbUser_Type.SelectedIndex = 2;
                    }
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
