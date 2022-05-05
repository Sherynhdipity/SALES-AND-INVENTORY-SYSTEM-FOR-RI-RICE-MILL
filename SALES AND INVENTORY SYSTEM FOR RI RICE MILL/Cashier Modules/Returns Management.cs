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
    public partial class ucReturns : UserControl
    {

        private static ucReturns returns;

        public static ucReturns returnsInstance
        {
            get
            {
                if (returns == null)
                    returns = new ucReturns();
                return returns;
            }

        }

        frmReturnItem returnItem = new frmReturnItem();

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

        public ucReturns()
        {
            InitializeComponent();

            returnItem.FormClosed += new FormClosedEventHandler(Form_Closed);        
        }

        void Form_Closed(object sender, FormClosedEventArgs e)
        {
            frmReturnItem frm = (frmReturnItem)sender;
        }

            public void DisplayCustomerName()
        {
            if (txtTransNo.Text == "")
            {
                txtCustomer.Text = "";
            }
            else
            {
                try
                {
                    con.Close();
                    con.Open();
                    QuerySelect = "SELECT First_name + ' ' + Last_name AS [FullName] FROM tblCustomers INNER JOIN tblOrders ON tblCustomers.Customer_id = tblOrders.Customer_id WHERE tblOrders.Transaction_number = @transNo";

                    cmd = new SqlCommand(QuerySelect, con);
                    cmd.Parameters.AddWithValue("@transNo", txtTransNo.Text);

                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        txtCustomer.Text = reader["FullName"].ToString();

                        reader.Close();
                    }
                    else
                    {
                        txtCustomer.Text = "";

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
                con.Close();
            }
        }

        public void populateDgvOrderDeets()
        {           

            if (txtCustomer.Text == "")
            {
                MessageBox.Show("Enter Transaction Number!");
            }
            else
            {
                try
                {
                    con.Close();
                    con.Open();

                    QuerySelect = "SELECT Order_id, Description, SKU, Price, [Order Date] FROM OrderDetailsView WHERE TransNum = @transNo";

                    cmd = new SqlCommand(QuerySelect, con);
                    cmd.Parameters.AddWithValue("@transNo", txtTransNo.Text);


                    adapter = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    adapter.Fill(dt);

                    dgvOrderDeetsList.DataSource = dt;
                    dgvOrderDeetsList.Refresh();
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

        private void txtTransNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DisplayCustomerName();
                populateDgvOrderDeets();
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Name = "";
                btn.Text = "Return";
                btn.UseColumnTextForButtonValue = true;
                dgvOrderDeetsList.Columns.Add(btn);

            }
        }

        private void dgvOrderDeetsList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("error");
            //if (dgvOrderDeetsList[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            //{
            //    returnItem.Id = dgvOrderDeetsList[1, e.RowIndex].Value.ToString();
            //    returnItem.ShowDialog();
            //}
        }

        private void dgvOrderDeetsList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrderDeetsList[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                returnItem.SKU = dgvOrderDeetsList[2, e.RowIndex].Value.ToString();
                returnItem.Id = dgvOrderDeetsList[0, e.RowIndex].Value.ToString();
                //MessageBox.Show(returnItem.Id);
                returnItem.ShowDialog();
            }
        }

        private void btnViewReturn_Click(object sender, EventArgs e)
        {
            frmViewReturns viewReturns = new frmViewReturns();
            viewReturns.Show();
        }

        private void txtTransNo_TextChange(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            dgvOrderDeetsList.Refresh();
            txtCustomer.Clear();
        }
    }
}
