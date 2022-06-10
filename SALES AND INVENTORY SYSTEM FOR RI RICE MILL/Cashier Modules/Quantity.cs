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
        public string unit_measurement { get; set; }
        public string product_Variety { get; set; }
        public string product_Price { get; set; }

        public int Product_Quantity { get; set; }
        public string Batch_number { get; set; }
        public string Product_Stock { get; set; }
        public string[] SKU {get; set;}
        public List<string> SKULIST { get; set; }
       
        // List<string> myList = new List<string>();

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
                       "WHERE Item_id = (SELECT Item_id From tblItems WHERE Description = @desc AND Unit = @unit) " +
                       "AND Batch_number = @batch_num AND status = 'Stock In'";
            cmd = new SqlCommand(QuerySelect, con);
            cmd.Parameters.AddWithValue("@desc", product_Desc);
            cmd.Parameters.AddWithValue("@unit", unit_measurement);
            cmd.Parameters.AddWithValue("@batch_num", Batch_number);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvSKUList.DataSource = dt;

            dgvSKUList.Refresh();
        }

        public void displayExistingSKUValidated()
        {
            string list_sku = String.Join("','", SKULIST.Select(i => i.Replace("'", "''")));
           // string list_sku = String.Join(",", SKULIST);
            con.Close();
            QuerySelect = "Select SKU from tblInventories " +
                       "WHERE Item_id = (SELECT Item_id From tblItems WHERE Description = @desc) " +
                       "AND Batch_number = @batch_num AND SKU NOT IN ('"+list_sku+"') AND status = 'Stock In'";
            cmd = new SqlCommand(QuerySelect, con);
            cmd.Parameters.AddWithValue("@desc", product_Desc);
            cmd.Parameters.AddWithValue("@batch_num", Batch_number);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvSKUList.DataSource = dt;

            dgvSKUList.Refresh();
        }

        public void displayExistingSKUTop()
        {
            int quantity = 0;
            if (txtQty.Text == "")
            {
                quantity = 0;
            }
            else
            {
                quantity = Convert.ToInt32(txtQty.Text);
            }
             
            con.Close();
            QuerySelect = "Select TOP "+ quantity +" SKU from tblInventories " +
                       "WHERE Item_id = (SELECT Item_id From tblItems WHERE Description = @desc AND Unit = @unit) " +
                       "AND Batch_number = @batch_num AND status = 'Stock In'";
            cmd = new SqlCommand(QuerySelect, con);
            cmd.Parameters.AddWithValue("@desc", product_Desc);
            cmd.Parameters.AddWithValue("@unit", unit_measurement);
            cmd.Parameters.AddWithValue("@batch_num", Batch_number);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvSKUList.DataSource = dt;

            dgvSKUList.Refresh();
        }

        public void displayExistingSKUValidatedTop()
        {
            int quantity = 0;
            if (txtQty.Text == "")
            {
                quantity = 0;
            }
            else
            {
                quantity = Convert.ToInt32(txtQty.Text);
            }
            string list_sku = String.Join("','", SKULIST.Select(i => i.Replace("'", "''")));
            // string list_sku = String.Join(",", SKULIST);
            con.Close();
            QuerySelect = "Select TOP " + quantity + " SKU from tblInventories " +
                       "WHERE Item_id = (SELECT Item_id From tblItems WHERE Description = @desc AND Unit = @unit) " +
                       "AND Batch_number = @batch_num AND SKU NOT IN ('" + list_sku + "') AND status = 'Stock In'";
            cmd = new SqlCommand(QuerySelect, con);
            cmd.Parameters.AddWithValue("@desc", product_Desc);
            cmd.Parameters.AddWithValue("@unit", unit_measurement);
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
            //SKU = new string[dgvSKUList.SelectedRows.Count];
            SKU = new string[dgvSKUList.RowCount];

            try
            {

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                if (txtQty.Text != "0" || txtQty.Text != "")
                {
                    //int array_index = dgvSKUList.SelectedRows.Count-1; 

                    //foreach(DataGridViewRow row in dgvSKUList.SelectedRows)
                    //{

                    //    SKU[array_index] = row.Cells["SKU"].Value.ToString();
                    //    SKULIST.Add(row.Cells["SKU"].Value.ToString());
                    //    array_index--;
                    //}
                    //Product_Quantity = Convert.ToInt32(txtQty.Text);
                    //this.Close();

                    int ctr = 0;
                    foreach (DataGridViewRow row in dgvSKUList.Rows)
                    {
                        SKU[ctr] = row.Cells["SKU"].Value.ToString();
                        SKULIST.Add(row.Cells["SKU"].Value.ToString());
                        ctr++;
                        //More code here
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
            dgvSKUList.Enabled = false;
            //bool isEmpty = IsEmpty(SKULIST);
            //if (isEmpty)
            //{
            //    //MessageBox.Show("List is Empty");
            //    SKULIST = new List<string>();
            //    displayExistingSKU();
                txtQty.Enabled = true;
            //    dgvSKUList.Rows[0].Cells[0].Selected = false;
            //    txtQty.Text = dgvSKUList.SelectedRows.Count.ToString();
            //}
            //else
            //{
            //    // MessageBox.Show("List contains elements");
            //    displayExistingSKUValidated();
            //    txtQty.Enabled = true;
            //    dgvSKUList.Rows[0].Cells[0].Selected = false;
            //    txtQty.Text = dgvSKUList.SelectedRows.Count.ToString();
            //}
          
        }

        public static bool IsEmpty<T>(List<T> list)
        {
            if (list == null)
            {
                return true;
            }

            return !list.Any();
        }

        private void dgvSKUList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // txtQty.Text = dgvSKUList.SelectedRows.Count.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtQty_TextChange(object sender, EventArgs e)
        {
            
            bool isEmpty = IsEmpty(SKULIST);
            if (isEmpty)
            {
                //MessageBox.Show("List is Empty");
                SKULIST = new List<string>();
                displayExistingSKUTop();
                dgvSKUList.ClearSelection();
                // txtQty.Enabled = true;
                //dgvSKUList.Rows[0].Cells[0].Selected = false;
                //txtQty.Text = dgvSKUList.SelectedRows.Count.ToString();
            }
            else
            {
                // MessageBox.Show("List contains elements");
                displayExistingSKUValidatedTop();
                dgvSKUList.ClearSelection();
                //txtQty.Enabled = true;
                //dgvSKUList.Rows[0].Cells[0].Selected = false;
                //txtQty.Text = dgvSKUList.SelectedRows.Count.ToString();
            }
        }
    }
}
