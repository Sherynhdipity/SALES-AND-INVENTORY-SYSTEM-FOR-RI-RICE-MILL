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

namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Inventory_Clerk_Modules
{
    public partial class frmAddStocks : Form
    {
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public frmAddStocks()
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

        private void frmAddStocks_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtViewItem;
        }

        public void ClearControls()
        {
            txtDescription.Clear();
            txtUnit.Clear();
            txtPrice.Clear();
            txtCriticalLevel.Clear();
            txtBarcode.Clear();
            txtItemNumber.Clear();
        }

        static String remVowel(String str, String str1)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            List<char> al = vowels.OfType<char>().ToList();

            StringBuilder sb = new StringBuilder(str);

            for (int i = 0; i < sb.Length; i++)
            {

                if (al.Contains(sb[i]))
                {
                    sb.Replace(sb[i].ToString(), "");
                    i--;
                }
            }

            string final = sb.ToString() + "-" + str1.ToString();
            final = final.Replace(" ", String.Empty);
            return final;
        }

        public void DisplayItems()
        {
            try
            {
                if (txtViewItem.Text == "" || txtViewItem.Text == null)
                {
                    ClearControls();
                }
                else
                {
                    con.Open();
                    QuerySelect = "SELECT item_number as 'ID', barcode as 'Barcode', " +
                      "description as 'Description' ,unit_measurement as 'Unit', price as 'Price'," +
                      " critical_level as 'Critical Level' from tblItem WHERE item_number LIKE '" + txtViewItem.Text + "%' " +
                      "OR barcode LIKE '" + txtViewItem.Text + "%' " +
                      "OR description LIKE '" + txtViewItem.Text + "%' " +
                      "OR unit_measurement LIKE '" + txtViewItem.Text + "%' " +
                      "OR price LIKE '" + txtViewItem.Text + "%' " +
                      "OR critical_level LIKE '" + txtViewItem.Text + "%'";


                    cmd = new SqlCommand(QuerySelect, con);
                    adapter = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        txtItemNumber.Text = dt.Rows[0]["ID"].ToString();
                        txtDescription.Text = dt.Rows[0]["Description"].ToString();
                        txtBarcode.Text = dt.Rows[0]["Barcode"].ToString();
                        txtPrice.Text = dt.Rows[0]["Price"].ToString();
                        txtUnit.Text = dt.Rows[0]["Unit"].ToString();
                        txtCriticalLevel.Text = dt.Rows[0]["Critical Level"].ToString();
                        txtSKU.Text = remVowel(dt.Rows[0]["Description"].ToString(), dt.Rows[0]["Unit"].ToString());
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

        //add item

        public void addStock()
        {
            con.Close();

            if (String.IsNullOrEmpty(txtItemNumber.Text))
            {
                MessageBox.Show("Enter Item!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtItemNumber.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtItemNumber.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtItemNumber.Clear();
            }
            else if (String.IsNullOrEmpty(txtBatchNumber.Text))
            {
                MessageBox.Show("Enter Batch Number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBatchNumber.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtBatchNumber.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtBatchNumber.Clear();
            }
            else if (String.IsNullOrEmpty(txtSKU.Text))
            {
                MessageBox.Show("Enter SKU!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSKU.Focus();
            }
            else if (String.IsNullOrEmpty(txtBatchQuantity.Text))
            {
                MessageBox.Show("Enter Batch Quantity!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBatchQuantity.Focus();
            }
            else
            {
                result = MessageBox.Show("Do you want to add this stock?", "Update Item", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        con.Close();
                        con.Open();
                        QueryInsert = "INSERT INTO tblInventory " +
                        "(item_number,user_id,batch_number,SKU,batch_quantity,milled_date,stock_in_date) " +
                        "VALUES ('"
                        + txtItemNumber.Text + "', '"
                        + Id + "', '"
                        + txtBatchNumber.Text + "', '"
                        + txtSKU.Text + "', '"
                        + txtBatchQuantity.Text + "'," +
                        "'" + dtpMilledDate.Value.Date + "'," +
                        "'" + dtpStockInDate.Value.Date + "')";
                        cmd = new SqlCommand(QueryInsert, con);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Stock Added Successfully!", "Add Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtViewItem_TextChange(object sender, EventArgs e)
        {
            if (txtViewItem.Text != "" || txtViewItem.Text != null)
            {
                DisplayItems();
            }
            else
            {
                ClearControls();
            }
            
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            addStock();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBatchNumber_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtBatchQuantity_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
