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

namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Inventory_Clerk_Modules
{
    public partial class InventoryManagement : UserControl
    {
        public static string ID;
        private static InventoryManagement inventory;
        
        public static InventoryManagement inventoryInstance
        {
            get
            {
                if (inventory == null)
                    inventory = new InventoryManagement();
                return inventory;
            }

        }

        frmAddStocks addNew = new frmAddStocks();
        frmUpdateStocks updateNew = new frmUpdateStocks();

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
        public InventoryManagement()
        {
            InitializeComponent();
            addNew.FormClosed += new FormClosedEventHandler(Form_Closed);
            updateNew.FormClosed += new FormClosedEventHandler(Form_Closed1);

            DisplayItems();
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "";
            btn.Text = "Update";
            btn.UseColumnTextForButtonValue = true;

            dgvStockList.Columns.Add(btn);
        }

        void Form_Closed(object sender, FormClosedEventArgs e)
        {
            frmAddStocks frm = (frmAddStocks)sender;
            DisplayItems();
        }

        void Form_Closed1(object sender, FormClosedEventArgs e)
        {
            frmUpdateStocks frm = (frmUpdateStocks)sender;
            DisplayItems();
        }

        public void DisplayItems()
        {
            try
            {
                con.Open();

                if (txtViewStocks.Text == "" || txtViewStocks.Text == null)
                {
                    QuerySelect = "SELECT * from InventoryViews";
                }
                else
                {
                    QuerySelect = "SELECT * from InventoryViews WHERE (Description LIKE '%' + @desc + '%') OR ([Batch Number] LIKE '%' + @batchNo + '%') OR ([Critical Level] LIKE '%' + @crit + '%')";
                }

                cmd = new SqlCommand(QuerySelect, con);
                cmd.Parameters.AddWithValue("@desc", txtViewStocks.Text);
                cmd.Parameters.AddWithValue("@batchNo", txtViewStocks.Text);
                cmd.Parameters.AddWithValue("@crit", txtViewStocks.Text);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dgvStockList.DataSource = dt;

                dgvStockList.Refresh();
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

            private void btnAddStock_Click(object sender, EventArgs e)
        {
            addNew.Id = ID;
            addNew.ShowDialog();
            
        }                   

        private void txtViewStocks_TextChange(object sender, EventArgs e)
        {
            DisplayItems();
        }

        private void btnPrintBarcode_Click(object sender, EventArgs e)
        {
            frmBarcodeLookup lookup = new frmBarcodeLookup();
            lookup.ShowDialog();

        }

        private void btnStockCard_Click(object sender, EventArgs e)
        {
            Inventory_Clerk_Modules.frmStockCard f1 = new Inventory_Clerk_Modules.frmStockCard();
            f1.ShowDialog();
        }

        private void dgvStockList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStockList[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                updateNew.Id = dgvStockList[2, e.RowIndex].Value.ToString();
                updateNew.ShowDialog();
            }
        }
    }
}
