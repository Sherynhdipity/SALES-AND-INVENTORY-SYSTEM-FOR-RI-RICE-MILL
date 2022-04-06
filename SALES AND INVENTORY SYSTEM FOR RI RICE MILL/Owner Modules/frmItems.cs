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

namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Owner_Modules
{
    public partial class frmItems : UserControl
    {

        private static frmItems items;

        public static frmItems itemsInstance
        {
            get
            {
                if (items == null)
                    items = new frmItems();
                return items;
            }

        }

        frmAddItem addNew = new frmAddItem();
        frmUpdateItem updateItem = new frmUpdateItem();

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
        public frmItems()
        {
            InitializeComponent();
            addNew.FormClosed += new FormClosedEventHandler(Form_Closed);
            updateItem.FormClosed += new FormClosedEventHandler(Form_Closed1);

            DisplayItems();
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "";
            btn.Text = "Update";
            btn.UseColumnTextForButtonValue = true;

            dgvItemList.Columns.Add(btn);
        }

        void Form_Closed(object sender, FormClosedEventArgs e)
        {
            frmAddItem frm = (frmAddItem)sender;
            DisplayItems();
        }

        void Form_Closed1(object sender, FormClosedEventArgs e)
        {
            frmUpdateItem frm = (frmUpdateItem)sender;
            DisplayItems();
        }

        public void DisplayItems()
        {
            try
            {
                con.Open();

                if (txtViewItems.Text == "" || txtViewItems.Text == null)
                {
                    QuerySelect = "SELECT item_number as 'ID', barcode as 'Barcode', " +
                   "description as 'Description' ,unit_measurement as 'Unit', price as 'Price'," +
                   " critical_level as 'Critical Level' from tblItem";
                }
                else
                {
                    QuerySelect = "SELECT item_number as 'ID', barcode as 'Barcode', " +
                   "description as 'Description' ,unit_measurement as 'Unit', price as 'Price'," +
                   " critical_level as 'Critical Level' from tblItem WHERE item_number LIKE '" + txtViewItems.Text + "%' " +
                   "OR barcode LIKE '" + txtViewItems.Text + "%' " +
                   "OR description LIKE '" + txtViewItems.Text + "%' " +
                   "OR unit_measurement LIKE '" + txtViewItems.Text + "%' " +
                   "OR price LIKE '" + txtViewItems.Text + "%' " +
                   "OR critical_level LIKE '" + txtViewItems.Text + "%'";
                }

                cmd = new SqlCommand(QuerySelect, con);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dgvItemList.DataSource = dt;

                dgvItemList.Refresh();
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

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            addNew.ShowDialog();
        }

        private void txtViewItems_TextChange(object sender, EventArgs e)
        {
            DisplayItems();
        }

        private void dgvItemList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItemList[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                updateItem.Id = dgvItemList[1, e.RowIndex].Value.ToString();
                updateItem.ShowDialog();
            }
        }
    }
}
