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
    public partial class frmInventoryAdjustmentReport : Form
    {
        public frmInventoryAdjustmentReport()
        {
            InitializeComponent();
        }
        public static SqlConnection con = new SqlConnection(DBConnection.con);
        public static SqlCommand cmd;
        public static SqlDataReader reader;
        public static SqlDataAdapter adapter;
        public static DataSet ds;
        public static DataTable dt;
        public static DialogResult result;
        public static string QuerySelect;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtSearchInventory.Text == "" || txtSearchInventory.Text == null)
                {
                    QuerySelect = "Select * from InventoryAdjustmentView";
                }
                else
                {
                    QuerySelect = " Select * from InventoryAdjustmentView where (Description LIKE '%' + @desc + '%')";
                }

                cmd = new SqlCommand(QuerySelect, con);
                cmd.Parameters.AddWithValue("@desc", txtSearchInventory.Text);

                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dgvInventoryAdjust.DataSource = dt;
                dgvInventoryAdjust.Refresh();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
