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
    public partial class frmAddNewCustomer : Form
    {
        public frmAddNewCustomer()
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
        public static string discountCode = "NC01";
        

        private void frmAddNewCustomer_Load(object sender, EventArgs e)
        {
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
            cmbBarangay.SelectedIndex = 0;
            cmbMunicipality.SelectedIndex = 0;
            cmbProvince.SelectedIndex = 0;
        }

        //AddCustomer

        public void AddCustomer()
        {
            con.Close();

            if (String.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Enter First Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtFirstName.Clear();
            }
            else if (String.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Enter Last Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtLastName.Clear();
            }
            else if (String.IsNullOrEmpty(txtContact.Text))
            {
                MessageBox.Show("Enter Contact Number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrWhiteSpace(txtContact.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtContact.Clear();
            }
            else if (String.IsNullOrEmpty(txtStreet.Text))
            {
                MessageBox.Show("Enter Street!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrWhiteSpace(txtStreet.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtStreet.Clear();
            }
            else if (!Regex.IsMatch(txtContact.Text, @"^(09)\d{9}$"))
            {
                MessageBox.Show("Phone number must be 11 digit only");
                txtContact.Clear();
            }
            else if (!Regex.IsMatch(txtFirstName.Text, @"^([a-zA-Z]+?)([-\s'][a-zA-Z]+)*?$"))
            {
                MessageBox.Show("First Name must be a letter only and no spacial characters or numbers");
                
            }
            //else if (!Regex.IsMatch(txtMiddleName.Text, @"^([a-zA-Z]+?)([-\s'][a-zA-Z]+)*?$"))
            //{
            //    MessageBox.Show("Middle Name must be a letter only");
            //    txtFirstName.Clear();
            //}
            else if (!Regex.IsMatch(txtLastName.Text, @"^([a-zA-Z]+?)([-\s'][a-zA-Z]+)*?$"))
            {
                MessageBox.Show("Last name must be a letter only and no spacial characters or numbers");
                
            }
            //else if (cmbProvince.SelectedIndex == -1)//Nothing selected
            //{
            //    MessageBox.Show("You must select a Province!", "Error");
            //}
            else if (cmbMunicipality.SelectedIndex == -1)//Nothing selected
            {
                MessageBox.Show("You must select a Municipality!", "Error");
            }
            else if (cmbBarangay.SelectedIndex == -1)//Nothing selected
            {
                MessageBox.Show("You must select a Barangay!", "Error");
            }
            else if (txtFirstName.Text != ""
                && txtLastName.Text != "" && txtContact.Text != "" && txtStreet.Text != ""
                && cmbBarangay.Text != "" && cmbMunicipality.Text != "" && cmbProvince.Text != "")
            {
                result = MessageBox.Show("Do you want to Add this Customer?", "Add User", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    con.Close();
                    con.Open();
                    QuerySelect = "SELECT * FROM tblCustomers WHERE First_name =@fName AND Middle_name =@mName AND Last_name =@lName";

                    cmd = new SqlCommand(QuerySelect, con);
                    cmd.Parameters.AddWithValue("@fName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@mName", txtMiddleName.Text);
                    cmd.Parameters.AddWithValue("@lName", txtLastName.Text);

                    reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        MessageBox.Show("This customer already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ClearControls();
                    }
                    else
                    {
                        try
                        {
                            con.Close();
                            con.Open();
                            QueryInsert = "INSERT INTO tblCustomers (Last_name,First_name,Middle_name,Street," +
                            "Barangay,Municipality,Province,Contact_number, Discount_code) " +
                            "VALUES (@lName, @fName, @mName, @street, @brgy, @city, @province, @cNo, @discount)";

                            cmd = new SqlCommand(QueryInsert, con);

                            cmd.Parameters.AddWithValue("@fName", txtFirstName.Text);
                            cmd.Parameters.AddWithValue("@mName", txtMiddleName.Text);
                            cmd.Parameters.AddWithValue("@lName", txtLastName.Text);
                            cmd.Parameters.AddWithValue("@province", cmbProvince.SelectedValue.ToString());
                            cmd.Parameters.AddWithValue("@city", cmbMunicipality.SelectedValue.ToString());
                            cmd.Parameters.AddWithValue("@brgy", cmbBarangay.SelectedValue.ToString());
                            cmd.Parameters.AddWithValue("@street", txtStreet.Text);
                            cmd.Parameters.AddWithValue("@cNo", txtContact.Text);
                            cmd.Parameters.AddWithValue("@discount", discountCode);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Customer Added Successfully!", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            QuerySelect = "Select * From tblMunicipality Where province_code = '" + cmbProvince.SelectedValue + "' Order by municipality_desc ASC";
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
            AddCustomer();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            ClearControls();
        }


        private void cmbMunicipality_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            loadBarangays();
        }

        private void cmbProvince_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            loadMunicipalities();
        }

        private void frmAddNewCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            //frmPayment payment = new frmPayment();
            //payment.frmPayment_Load(sender, e);
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            //if (Regex.IsMatch(txtFirstName.Text, @"^([a-z,A-Z]+?)([-,\s'][a-z,A-Z]+)*?$") == true)
            //{
                
            //}
            //else
            //{
            //    MessageBox.Show("First Name must be a letter only");
            //}
        }
        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            //if (!Regex.IsMatch(txtMiddleName.Text, @"^([a-zA-Z]+?)([-\s'][a-zA-Z]+)*?$"))
            //{
            //    MessageBox.Show("Middle Name must be a letter only");
            //    txtFirstName.Clear();
            //}
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //var regex = new Regex(@"^([a-zA-Z]+?)([-\s'][a-zA-Z]+)*?$");
            //if (regex.IsMatch(e.KeyChar.ToString()))
            //{
            //    e.Handled = true;
            //}
        }
    }
}
