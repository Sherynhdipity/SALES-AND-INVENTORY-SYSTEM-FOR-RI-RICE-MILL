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
            DisplayUser();
        }

        public void DisplayUser()
        {
            try
            {
                con.Open();
                QuerySelect = "SELECT * from tblItem WHERE item_number = '" + id + "'";


                cmd = new SqlCommand(QuerySelect, con);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txtDescription.Text = dt.Rows[0]["description"].ToString();
                    txtBarcode.Text = dt.Rows[0]["barcode"].ToString();
                    txtPrice.Text = dt.Rows[0]["price"].ToString();
                    txtCriticalLevel.Text = dt.Rows[0]["critical_level"].ToString();
                    if (dt.Rows[0]["unit_measurement"].ToString() == "50")
                    {
                        cmbUnit.SelectedIndex = 0;
                    }
                    else
                    {
                        cmbUnit.SelectedIndex = 1;
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

        public void UpdateItem()
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
            else if (txtDescription.Text != "" && txtPrice.Text != ""
                && txtCriticalLevel.Text != "" && txtBarcode.Text != "")
            {
                result = MessageBox.Show("Do you want to update this item?", "Update Item", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        con.Close();
                        con.Open();
                        QueryUpdate = "Update tblItem Set " +
                        "barcode ='" + txtBarcode.Text + "',description = '" + txtDescription.Text + "'" +
                        ",unit_measurement = '" + cmbUnit.SelectedItem.ToString() + "',price = '" + txtPrice.Text +
                        "',critical_level = '" + txtCriticalLevel.Text + "' WHERE item_number = '" + id + "'";

                        cmd = new SqlCommand(QueryUpdate, con);
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
            }
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
    }
}
