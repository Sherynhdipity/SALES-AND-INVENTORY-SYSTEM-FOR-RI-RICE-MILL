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

namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Owner_Modules
{
    public partial class frmUpdateCustomer : Form
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

        public frmUpdateCustomer()
        {
            InitializeComponent();
                   
        }

        public void ClearControls()
        {
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtLastName.Clear();
            txtContact.Clear();
            txtStreet.Clear();
            cmbProvince.SelectedIndex = 0;
            cmbMunicipality.SelectedIndex = 0;
            cmbBarangay.SelectedIndex = 0;
            cmbDiscount.SelectedIndex = 0;

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
            else if (!Regex.IsMatch(txtContact.Text, @"^(09)\d{9}$"))
            {
                MessageBox.Show("Phone number must be 11 digit only");
                txtContact.Clear();
            }
            else if (!Regex.IsMatch(txtFirstName.Text, @"^[^\s]+[-a-zA-Z\s]+([-a-zA-Z]+)*$"))
            {
                MessageBox.Show("First Name must be a letter only");
                txtFirstName.Clear();
            }
            else if (!Regex.IsMatch(txtLastName.Text, @"^[a-z, A-Z,.'-]+$"))
            {
                MessageBox.Show("Last name must be a letter only");
                txtLastName.Clear();
            }
            else if (txtFirstName.Text != ""
                && txtLastName.Text != "" && txtContact.Text != "" && txtStreet.Text != "")
            {
                result = MessageBox.Show("Do you want to update this Customer?", "Update Customer", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        con.Close();
                        con.Open();

                        QueryUpdate = "UPDATE tblCustomers SET First_name = @fName, Middle_name = @mName, Last_name = @lName," +
                                "Street = @street,Barangay = @brgy, Municipality = @city,Province = @province,Contact_number = @cNo," +
                                "Discount_code = @discount WHERE Customer_id= '" + id + "'";

                        cmd = new SqlCommand(QueryUpdate, con);

                        cmd.Parameters.AddWithValue("@fName", txtFirstName.Text);
                        cmd.Parameters.AddWithValue("@mName", txtMiddleName.Text);
                        cmd.Parameters.AddWithValue("@lName", txtLastName.Text);
                        cmd.Parameters.AddWithValue("@province", cmbProvince.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@city", cmbMunicipality.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@brgy", cmbBarangay.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@street", txtStreet.Text);
                        cmd.Parameters.AddWithValue("@cNo", txtContact.Text);
                        cmd.Parameters.AddWithValue("@discount", cmbDiscount.SelectedValue.ToString());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Customer Updated Successfully!", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.StackTrace);
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
                MessageBox.Show("Please Provide Details!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void loadDiscount()
        {
            con.Close();
            con.Open();
            QuerySelect = "Select * From tblDiscounts Order by Discount_Description ASC";
            cmd = new SqlCommand(QuerySelect, con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            cmd.ExecuteNonQuery();
            con.Close();

            cmbDiscount.DisplayMember = "Discount_Description";
            cmbDiscount.ValueMember = "Discount_code";
            cmbDiscount.DataSource = dt;
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
            if (cmbProvince.SelectedIndex == 0)
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
            else
            {

                try
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


                    
                    con.Open();
                    QuerySelect = "SELECT Municipality from tblCustomers WHERE Customer_id = '" + id + "'";


                    cmd = new SqlCommand(QuerySelect, con);
                    adapter = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        cmbMunicipality.SelectedValue = dt.Rows[0][0].ToString();
                    }
                    else
                    {
                        cmbMunicipality.SelectedIndex = 0;
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
  
        }

        public void loadBarangays()
        {
            if(cmbMunicipality.SelectedIndex == 0)
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
            else
            {

                try
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



                    con.Open();
                    QuerySelect = "SELECT Barangay from tblCustomers WHERE Customer_id = '" + id + "'";


                    cmd = new SqlCommand(QuerySelect, con);
                    adapter = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        cmbBarangay.SelectedValue = dt.Rows[0][0].ToString();
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

        }

        public void DisplayCustomer()
        {
            loadProvinces();
            
            try
            {
                con.Open();
                QuerySelect = "SELECT * FROM tblCustomers WHERE Customer_id = @cID";

                cmd = new SqlCommand(QuerySelect, con);
                cmd.Parameters.AddWithValue("@cID", id);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txtFirstName.Text =  dt.Rows[0]["First_name"].ToString();
                    txtMiddleName.Text = dt.Rows[0]["Middle_name"].ToString();
                    txtLastName.Text = dt.Rows[0]["Last_name"].ToString();
                    txtContact.Text = dt.Rows[0]["Contact_number"].ToString();
                    txtStreet.Text = dt.Rows[0]["Street"].ToString();
                    cmbProvince.SelectedValue = dt.Rows[0]["Province"].ToString();
                    cmbDiscount.SelectedValue = dt.Rows[0]["Discount_code"].ToString();


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
            QuerySelect = "SELECT province_desc FROM tblProvinces WHERE province_code = (SELECT Province FROM tblCustomers WHERE Customer_id = '" + id + "')";
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
            QuerySelect = "SELECT municipality_desc from tblMunicipality WHERE municipality_code = (SELECT Municipality FROM tblCustomers WHERE Customer_id = '" + id + "')";
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
            QuerySelect = "SELECT brgy_desc from tblBarangay WHERE brgy_code = (SELECT Barangay FROM tblCustomers WHERE Customer_id = '" + id + "')";
            cmd = new SqlCommand(QuerySelect, con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                cmbBarangay.SelectedIndex = cmbBarangay.FindString(dt.Rows[0]["brgy_desc"].ToString());
            }
        }

        public void setDiscount()
        {
            con.Close();
            con.Open();
            QuerySelect = "SELECT Discount_Description from tblDiscounts WHERE Discount_code = (SELECT Discount_code FROM tblCustomers WHERE Customer_id = '" + id + "')";
            cmd = new SqlCommand(QuerySelect, con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                cmbDiscount.SelectedIndex = cmbDiscount.FindString(dt.Rows[0]["Discount_Description"].ToString());
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

        private void frmUpdateCustomer_Load(object sender, EventArgs e)
        {
            DisplayCustomer();
            loadDiscount();
            setProvince();
            setMunicipality();
            setBarangay();
            setDiscount();
        }
    }
}
