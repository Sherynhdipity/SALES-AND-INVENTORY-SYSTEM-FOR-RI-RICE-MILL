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
    public partial class frmPLQuant : Form
    {
        public frmPLQuant()
        {
            InitializeComponent();
        }

        frmProductLookup productLookup = new frmProductLookup();
        frmSalesManagement salesManagement = new frmSalesManagement();
        public static SqlConnection con = new SqlConnection(DBConnection.con);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader reader;
        public static SqlDataAdapter adapter;
        public static DataTable dt = new DataTable();
        public static DialogResult result;
        public static string QueryInsert;
        public static string QuerySelect;
        public static string QueryUpdate;
        public string temp_code;
        public string product_Code { get; set; }
        public string product_Desc { get; set; }
        public string product_Variety { get; set; }
        public string product_Price { get; set; }

        public int Product_Quantity { get; set; }
        public string Batch_number { get; set; }
        public string Product_Stock { get; set; }
        public string[] SKU { get; set; }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                

            }
        }

        public void displayExistingSKU()
        {
            con.Close();
            QuerySelect = "Select SKU from tblInventories " +
                       "WHERE Item_id = (SELECT Item_id From tblItems WHERE Description = @desc) " +
                       "AND Batch_number = @batch_num AND status = 'Stock In'";
            cmd = new SqlCommand(QuerySelect, con);
            cmd.Parameters.AddWithValue("@desc", product_Desc);
            cmd.Parameters.AddWithValue("@batch_num", Batch_number);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvSKUList.DataSource = dt;

            dgvSKUList.Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            SKU = new string[dgvSKUList.SelectedRows.Count];
            try
            {

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                if (txtQty.Text != "0" || txtQty.Text != "")
                {
                    int array_index = dgvSKUList.SelectedRows.Count-1; 
                    foreach(DataGridViewRow row in dgvSKUList.SelectedRows)
                    {

                        SKU[array_index] = row.Cells["SKU"].Value.ToString();
                        array_index--;
                    }
                    Product_Quantity = Convert.ToInt32(txtQty.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please enter quantity!");
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

        private void frmPLQuant_Load(object sender, EventArgs e)
        {                  
            displayExistingSKU();
            txtQty.Enabled = false;
            dgvSKUList.Rows[0].Cells[0].Selected = false;
            txtQty.Text = dgvSKUList.SelectedRows.Count.ToString();
        }

        private void dgvSKUList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtQty.Text = dgvSKUList.SelectedRows.Count.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
