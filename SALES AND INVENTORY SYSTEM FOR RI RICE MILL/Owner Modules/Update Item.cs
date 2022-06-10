﻿using System;
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
    public partial class frmUpdateItem : Form
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

        public frmUpdateItem()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateItem();
        }

        private void frmUpdateItem_Load(object sender, EventArgs e)
        {
            DisplayItems();
        }

        public void DisplayItems()
        {
            try
            {
                con.Open();
                QuerySelect = "SELECT * from tblItems WHERE Item_id = '" + id + "'";


                cmd = new SqlCommand(QuerySelect, con);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txtDescription.Text = dt.Rows[0]["Description"].ToString();
                    cmbUnit.Text = dt.Rows[0]["Unit"].ToString();
                    txtCriticalLevel.Text = dt.Rows[0]["Critical_level"].ToString();
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


        //clear controls
        public void ClearControls()
        {
            txtDescription.Clear();
            txtCriticalLevel.Clear();

        }


        //UpdateItem
        public void UpdateItem()
        {
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
            else if (String.IsNullOrEmpty(txtCriticalLevel.Text))
            {
                MessageBox.Show("Enter Critical Level!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCriticalLevel.Focus();
            }
            else if (!Regex.IsMatch(txtDescription.Text, @"^[A-Za-z0-9\s-]*$"))
            {
                MessageBox.Show("Description must be letter, dash, space and numbers only");
            }
            else if (!Regex.IsMatch(txtCriticalLevel.Text, @"^\d+$"))
            {
                MessageBox.Show("Critical Level Number Only");
            }
            else if (txtDescription.Text != "" && txtCriticalLevel.Text != "")
            {
                result = MessageBox.Show("Do you want to update this item?", "Update Item", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    con.Close();
                    con.Open();

                    try
                    {
                        con.Close();
                        con.Open();
                        QueryUpdate = "UPDATE tblItems SET Description = @desc, Unit = @unit,Critical_Level = @crit WHERE Item_id = '" + id + "'";

                        cmd = new SqlCommand(QueryUpdate, con);

                        cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
                        cmd.Parameters.AddWithValue("@unit", cmbUnit.SelectedItem);
                        cmd.Parameters.AddWithValue("@crit", txtCriticalLevel.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Item Updated Successfully!", "Update Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                con.Close();
            }
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

        private void txtCriticalLevel_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCostPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
