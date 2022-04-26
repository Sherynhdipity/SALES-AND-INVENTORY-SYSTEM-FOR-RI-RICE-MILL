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

namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Cashier_Modules
{
    public partial class frmReturnItem : Form
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

        public frmReturnItem()
        {
            InitializeComponent();
            
           
        }

        public void ClearControls()
        {
            txtDescription.Clear();
            txtSKU.Clear();
            txtPrice.Clear();
            txtRemarks.Clear();

        }

        //ReturnItem
        public void ReturnItem()
        {
            con.Close();
            if (String.IsNullOrEmpty(txtRemarks.Text))
            {
                MessageBox.Show("Enter Contact Number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRemarks.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtRemarks.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtRemarks.Clear();
            }
            else if (txtDescription.Text != "" && txtSKU.Text != ""
                && txtPrice.Text != "" && txtRemarks.Text != "")
            {
                result = MessageBox.Show("Do you want to return this Item?", "Return Item", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        con.Close();
                        con.Open();

                        QueryInsert = "INSERT INTO tblReturns(Order_id,Return_quantity,Remarks, Return_date)" +
                            "VALUES(@oID,(SELECT COUNT(SKU) AS QTYRETURNED FROM tblOrderDetails WHERE SKU = @sku), @remarks, @returnDate)";
                        cmd = new SqlCommand(QueryInsert, con);

                        cmd.Parameters.AddWithValue("@oID", id);
                        cmd.Parameters.AddWithValue("@sku", txtSKU.Text);
                        cmd.Parameters.AddWithValue("@remarks", txtRemarks.Text);
                        cmd.Parameters.AddWithValue("@returnDate", dtpReturnDate.Value.Date);
                        

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Item Returned Successfully!", "Item Return", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        public void DisplayReturnSelection()
        {
            try
            {
                con.Open();
                QuerySelect = "SELECT Description, SKU, Price from OrderDetailsView WHERE Order_id = '" + id +"'";
                

                cmd = new SqlCommand(QuerySelect, con);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txtDescription.Text =  dt.Rows[0]["Description"].ToString();
                    txtSKU.Text = dt.Rows[0]["SKU"].ToString();
                    txtPrice.Text = dt.Rows[0]["Price"].ToString();

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
            ReturnItem();
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

        private void frmUpdateCustomer_Load(object sender, EventArgs e)
        {
            DisplayReturnSelection();

        }
    }
}
