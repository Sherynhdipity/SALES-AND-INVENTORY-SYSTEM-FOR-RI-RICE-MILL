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
    public partial class frmDisplaySKU : Form
    {
        public frmDisplaySKU()
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
        public string temp_code;
        public string id;
        public string[] prices;
        public string Transaction_Number { get; set; }
        public string Description { get; set; }

        public string Order_details_id { get; set; }
        public string Price { get; set; }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void bunifuShadowPanel2_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void frmDisplaySKU_Load(object sender, EventArgs e)
        {
            cmbRemarks.SelectedIndex = 0;
            DisplaySKU();

            DateTime date = DateTime.Now;
            dtpReturnDate.Text = string.Format("{0:D}", date);
        }

        public void DisplaySKU()
        {
            //datagrid
            try
            {
                con.Close();
                con.Open();
                //QuerySelect = "SELECT SKU FROM OrderDetailsView WHERE Transaction_number = @trans";
                QuerySelect = "SELECT SKU FROM tblInventories WHERE SKU IN(SELECT SKU FROM tblOrderDetails WHERE Order_id = (SELECT Order_id FROM tblOrders WHERE Transaction_number = @trans_num)) " +
                    "AND Item_id = (SELECT Item_id FROM tblItems WHERE Description = @description) AND Status = 'Stock Out'";
                cmd = new SqlCommand(QuerySelect, con);
                cmd.Parameters.AddWithValue("trans_num", Transaction_Number);
                cmd.Parameters.AddWithValue("description", Description);
                //cmd.Parameters.AddWithValue("@desc", Description);

                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dgvOrderDetails.DataSource = dt;


            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
        }

        //ReturnItem
        public void ReturnItem()
        {
            int selectedRows = dgvOrderDetails.Rows.GetRowCount(DataGridViewElementStates.Selected);
            con.Close();
                if (selectedRows > 0)
                {
                prices = new string[selectedRows];
                int ctr = 0;

                    if (cmbRemarks.SelectedIndex == 0)
                    {
                    //for (int i = 0; i < selectedRows; i++)
                        foreach (DataGridViewRow row in dgvOrderDetails.SelectedRows)
                        {
                            result = MessageBox.Show("Do you want to return this Item/s?", "Return Item", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                try
                                {
                                con.Close();
                                con.Open();
                                QuerySelect = "SELECT TOP 1 Order_details_id FROM OrderDetailsView WHERE SKU = @sku";
                                cmd = new SqlCommand(QuerySelect, con);
                                cmd.Parameters.AddWithValue("@sku", dgvOrderDetails.Rows[row.Index].Cells[0].Value.ToString());

                                reader = cmd.ExecuteReader();
                                if (reader.HasRows)
                                {
                                    reader.Read();
                                    id = reader["Order_details_id"].ToString();

                                    reader.Close();
                                }
                                con.Close();
                                con.Open();
                                QueryInsert = "Insert into tblTemp_return (Order_details_id, SKU, Return_quantity, Remarks, Return_date)" +
                                    "Values(@id, @sku, @qty, @remarks, @date)";
                                cmd = new SqlCommand(QueryInsert, con);
                                cmd.Parameters.AddWithValue("@id", id);
                                cmd.Parameters.AddWithValue("@sku", dgvOrderDetails.Rows[row.Index].Cells[0].Value.ToString());
                                cmd.Parameters.AddWithValue("@qty", '1');
                                cmd.Parameters.AddWithValue("@remarks", "DAMAGED");
                                cmd.Parameters.AddWithValue("@date", dtpReturnDate.Value.Date);
                                cmd.ExecuteNonQuery();

                                con.Close();
                                con.Open();

                                QueryUpdate = "Update tblInventories SET Status = 'Damaged' WHERE SKU = @sku";
                                cmd = new SqlCommand(QueryUpdate, con);
                                cmd.Parameters.AddWithValue("@sku", dgvOrderDetails.Rows[row.Index].Cells[0].Value.ToString());
                                cmd.ExecuteNonQuery();

                            }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                                finally
                                {
                                    con.Close();
                                }

                            con.Open();
                            QuerySelect = "SELECT Price FROM tblItems WHERE Item_id = (SELECT Item_id FROM tblInventories WHERE SKU = @sku)";
                            cmd = new SqlCommand(QuerySelect, con);
                            cmd.Parameters.AddWithValue("@sku", dgvOrderDetails.Rows[row.Index].Cells[0].Value.ToString());
                            reader = cmd.ExecuteReader();
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    if (ctr < selectedRows)
                                    {
                                        prices[ctr] = reader["Price"].ToString();
                                        ctr++;
                                    }

                                }
                            }
                            reader.Close();
                            con.Close();
                            double tempSum = 0;
                            for (int j = 0; j < prices.Length; j++)
                            {
                                tempSum += Convert.ToDouble(prices[j]);
                                
                            }
                            Price = (Convert.ToDouble(tempSum)).ToString("N2");


                        }
                        }

                        //MessageBox.Show("Item Successfully Returned, Please Select Replacement Item. ");
                        this.Close();

                    }

            }
            else
            {
                MessageBox.Show("Please select SKU!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ReturnItem();
        }

        private void dgvOrderDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cmbRemarks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
