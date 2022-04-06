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
            this.ActiveControl = txtBarcode;
            cmbUnit.SelectedIndex = 0;    
        }

        //methods

        //clear controls
        public void ClearControls()
        {
            txtDescription.Clear();
            cmbUnit.SelectedIndex = 0;
            txtPrice.Clear();
            txtCriticalLevel.Clear();
            txtBarcode.Clear();
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
            else if (String.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Enter Price!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtPrice.Clear();
            }
            else if (String.IsNullOrEmpty(txtCriticalLevel.Text))
            {
                MessageBox.Show("Enter Critical Level!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCriticalLevel.Focus();
            }
            else if (String.IsNullOrEmpty(txtBarcode.Text))
            {
                MessageBox.Show("Enter Barcode!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBarcode.Focus();
            }
            else
            {
                result = MessageBox.Show("Do you want to add this item?", "Update Item", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        con.Close();
                        con.Open();
                        QueryInsert = "INSERT INTO tblItem " +
                        "(barcode,description,unit_measurement,price,critical_level) " +
                        "VALUES ('"
                        + txtBarcode.Text + "', '"
                        + txtDescription.Text + "', '"
                        + cmbUnit.SelectedItem.ToString() + "', '"
                        + txtPrice.Text + "', '"
                        + txtCriticalLevel.Text + "')";
                        cmd = new SqlCommand(QueryInsert, con);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Item Added Successfully!", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtBarcode_TextChange(object sender, EventArgs e)
        {
            if (txtBarcode.Text == "")
            {
                ptbBarcode.Image = null;
            }
            else
            {
                try
                {
                    BarcodeWriter barcode = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
                    ptbBarcode.Image = barcode.Write(txtBarcode.Text);
                }
                catch (Exception ex)
                {

                }
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBarcode.Text = "";
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
    }
}
