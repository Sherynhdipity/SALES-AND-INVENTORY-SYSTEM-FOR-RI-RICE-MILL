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
    public partial class frmUpdateStocks : Form
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
        public frmUpdateStocks()
        {
            InitializeComponent();
            
        }

        public void DisplayBatchQuantity()
        {

            try
            {
                con.Open();
                QuerySelect = "SELECT * FROM InventoryViews WHERE Inventory_id = @iID";

                cmd = new SqlCommand(QuerySelect, con);
                cmd.Parameters.AddWithValue("@iID", id);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txtBatchNumber.Text = dt.Rows[0]["Batch_number"].ToString();
                   


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

        private void frmUpdateStocks_Load(object sender, EventArgs e)
        {
            DisplayBatchQuantity();
        }
    }
}
