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
using ZXing;
using System.Text.RegularExpressions;

namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Owner_Modules
{
    public partial class frmAddItem : Form
    {
        public frmAddItem()
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

        private void frmAddItem_Load(object sender, EventArgs e)
        {
            
        }

        //methods

        //clear controls
        public void ClearControls()
        {
            txtDescription.Clear();
            txtCriticalLevel.Clear();
        }

        //add item
        public void addItem()
        {
            con.Close();

            if (String.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Enter Description!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescription.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtDescription.Clear();
            }
            else if (!Regex.IsMatch(txtDescription.Text, @"^[A-Za-z0-9\s-]*$"))
            {
                MessageBox.Show("Description must contain letters, numbers, space and dash only");
            }

            else if (!Regex.IsMatch(txtCriticalLevel.Text, @"^\d+$"))
            {
                MessageBox.Show("Critical Level Number Only");

            }
            else if (String.IsNullOrEmpty(txtCriticalLevel.Text))
            {
                MessageBox.Show("Enter Critical Level!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCriticalLevel.Focus();
            }
            else
            {
                if (cmbUnit.SelectedIndex == 0)
                {
                    result = MessageBox.Show("Do you want to add this item?", "Add Item", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)

                    {
                        con.Close();
                        con.Open();
                        QuerySelect = "SELECT * FROM tblItems WHERE Description = @desc";

                        cmd = new SqlCommand(QuerySelect, con);
                        cmd.Parameters.AddWithValue("@desc", txtDescription.Text);

                        reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            MessageBox.Show("This Item already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            con.Close();
                            con.Open();
                            QuerySelect = "SELECT * FROM tblItems WHERE Description = @desc AND Unit = @unit AND Critical_Level = @critical";

                            cmd = new SqlCommand(QuerySelect, con);
                            cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
                            cmd.Parameters.AddWithValue("@unit", cmbUnit.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@critical", txtCriticalLevel.Text);

                            reader = cmd.ExecuteReader();

                            if (reader.HasRows)
                            {
                                MessageBox.Show("This Item already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                ClearControls();
                            }

                            else
                            {
                                try
                                {
                                    con.Close();
                                    con.Open();
                                    QueryInsert = "INSERT INTO tblItems (Description,Unit,Critical_Level) VALUES (@desc, @unit, @critical)";

                                    cmd = new SqlCommand(QueryInsert, con);
                                    cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
                                    cmd.Parameters.AddWithValue("@unit", cmbUnit.SelectedItem.ToString());
                                    cmd.Parameters.AddWithValue("@critical", txtCriticalLevel.Text);
                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Item Added Successfully!", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ClearControls();
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
                }
                else if(cmbUnit.SelectedIndex == 1)
                {
                    result = MessageBox.Show("Do you want to add this item?", "Add Item", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)

                    {
                        con.Close();
                        con.Open();
                        QuerySelect = "SELECT * FROM tblItems WHERE Description = @desc";

                        cmd = new SqlCommand(QuerySelect, con);
                        cmd.Parameters.AddWithValue("@desc", txtDescription.Text);

                        reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            MessageBox.Show("This Item already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            con.Close();
                            con.Open();
                            QuerySelect = "SELECT * FROM tblItems WHERE Description = @desc AND Unit = @unit AND Critical_Level = @critical";

                            cmd = new SqlCommand(QuerySelect, con);
                            cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
                            cmd.Parameters.AddWithValue("@unit", cmbUnit.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@critical", txtCriticalLevel.Text);

                            reader = cmd.ExecuteReader();

                            if (reader.HasRows)
                            {
                                MessageBox.Show("This Item already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                ClearControls();
                            }

                            else
                            {
                                try
                                {
                                    con.Close();
                                    con.Open();
                                    QueryInsert = "INSERT INTO tblItems (Description,Unit,Critical_Level) VALUES (@desc, @unit, @critical)";

                                    cmd = new SqlCommand(QueryInsert, con);
                                    cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
                                    cmd.Parameters.AddWithValue("@unit", cmbUnit.SelectedItem.ToString());
                                    cmd.Parameters.AddWithValue("@critical", txtCriticalLevel.Text);
                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Item Added Successfully!", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ClearControls();
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
                }
                else
                {
                    MessageBox.Show("Please Select Unit");
                }
            }
        }

        private void txtCriticalLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            ClearControls();
            this.Close();
        }


        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            addItem();
        }

        private void txtCostPrice_TextChange(object sender, EventArgs e)
        {
            //try
            //{
            //    txtCostPrice.Text = string.Format("{0:#,##0.00}", double.Parse(txtCostPrice.Text));
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            
        }

        private void txtCostPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_TextChange(object sender, EventArgs e)
        {
            //try
            //{
            //    txtPrice.Text = string.Format("{0:#,##0.00}", double.Parse(txtPrice.Text));
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void txtCostPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
