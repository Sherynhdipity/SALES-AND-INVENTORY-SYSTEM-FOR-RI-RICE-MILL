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
        private string sku;

        public string productCode { get; set; }
        public string productDesc { get; set; }
        public string productVariety { get; set; }
        public string productPrice { get; set; }

        public int quantity { get; set; }
        public string stock { get; set; }

        public bool isReturn { get; set; }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string SKU
        {
            get { return sku; }
            set { sku = value; }
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
            txtTransNumber.Clear();
            //txtSKU.Clear();
            //txtPrice.Clear();
            //txtRemarks.Clear();

        }

        //ReturnItem
        public void ReturnItem()
        {
            int selectedRows = dgvOrderDetails.Rows.GetRowCount(DataGridViewElementStates.Selected);
            con.Close();
            if (String.IsNullOrEmpty(txtTransNumber.Text))
            {
                MessageBox.Show("Enter Remark!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTransNumber.Focus();
            }
            else
            {
                if (selectedRows > 0)
                {
                    if(cmbRemarks.SelectedIndex == 0)
                    {
                        for (int i = 0; i < selectedRows; i++)
                        {
                            result = MessageBox.Show("Do you want to return this Item/s?", "Return Item", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                try
                                {
                                    con.Close();
                                    con.Open();
                                    QueryUpdate = "Update tblInventories SET Status = 'Stock In' WHERE SKU = @sku";
                                    cmd = new SqlCommand(QueryUpdate, con);
                                    cmd.Parameters.AddWithValue("@sku", dgvOrderDetails.Rows[i].Cells[2].Value.ToString());
                                    cmd.ExecuteNonQuery();

                                    QueryInsert = "Insert into tblReturns (Order_details_id, SKU, Return_quantity, Remarks, Return_date)" +
                                        "Values(@id, @sku, @qty, @remarks, @date)";
                                    cmd = new SqlCommand(QueryInsert, con);
                                    cmd.Parameters.AddWithValue("@id", dgvOrderDetails.Rows[i].Cells[0].Value.ToString());
                                    cmd.Parameters.AddWithValue("@sku", dgvOrderDetails.Rows[i].Cells[2].Value.ToString());
                                    cmd.Parameters.AddWithValue("@qty", dgvOrderDetails.Rows[i].Cells[3].Value.ToString());
                                    cmd.Parameters.AddWithValue("@remarks", "WRONG ITEM");
                                    cmd.Parameters.AddWithValue("@date", dtpReturnDate.Value.Date);
                                    cmd.ExecuteNonQuery();


                                

                                }
                                catch(Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                                finally
                                {
                                    con.Close();
                                }
                                
                                
                            }
                        }
                       
                           MessageBox.Show("Item Successfully Returned, Please Select Replacement Item. ");
                       
                        
                      
                        this.Close();
        
                    }
                    else if(cmbRemarks.SelectedIndex == 1)
                    {
                        for (int i = 0; i < selectedRows; i++)
                        {
                            result = MessageBox.Show("Do you want to return this Item/s?", "Return Item", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                try
                                {
                                    con.Close();
                                    con.Open();
                               

                                    QueryInsert = "Insert into tblReturns (Order_details_id, SKU, Return_quantity, Remarks, Return_date)" +
                                        "Values(@id, @sku, @qty, @remarks, @date)";
                                    cmd = new SqlCommand(QueryInsert, con);
                                    cmd.Parameters.AddWithValue("@id", dgvOrderDetails.Rows[i].Cells[0].Value.ToString());
                                    cmd.Parameters.AddWithValue("@sku", dgvOrderDetails.Rows[i].Cells[2].Value.ToString());
                                    cmd.Parameters.AddWithValue("@qty", dgvOrderDetails.Rows[i].Cells[3].Value.ToString());
                                    cmd.Parameters.AddWithValue("@remarks", "DAMAGED");
                                    cmd.Parameters.AddWithValue("@date", dtpReturnDate.Value.Date);
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


                            }
                        }
                        MessageBox.Show("Item Successfully Returned, Please Select Replacement Item. ");


                        this.Close();

                    }

                }
                
            }
        }

            public void DisplayReturnSelection()
            {
            dgvOrderDetails.Refresh();
            try
            {
                con.Open();
                QuerySelect = "SELECT Order_id, Description, SKU, Price from OrderDetailsView WHERE TransNum = '" + txtTransNumber.Text + "'";


                cmd = new SqlCommand(QuerySelect, con);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvOrderDetails.DataSource = dt;
                    // txtDescription.Text = dt.Rows[0]["Description"].ToString();
                    // txtSKU.Text = dt.Rows[0]["SKU"].ToString();
                    //txtPrice.Text = dt.Rows[0]["Price"].ToString();

                }
                else
                {
                    dgvOrderDetails.DataSource = null;
                    MessageBox.Show("Transaction Number Not Found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


            private void btnCancel_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void frmUpdateCustomer_Load(object sender, EventArgs e)
            {
                cmbRemarks.SelectedIndex = 0;
              //  DisplayReturnSelection();

            }

       

        private void txtTransNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrEmpty(txtTransNumber.Text))
                {
                    MessageBox.Show("Enter Transaction Number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTransNumber.Focus();
                }
                else if (String.IsNullOrWhiteSpace(txtTransNumber.Text))
                {
                    MessageBox.Show("Whitespace is not allowed!");
                    txtTransNumber.Clear();
                }
                else
                {
                    DisplayReturnSelection();
                }
            }
        }

    }
    }
