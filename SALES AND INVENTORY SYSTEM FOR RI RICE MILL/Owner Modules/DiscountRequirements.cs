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
    public partial class DiscountRequirements : Form
    {

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

        public DiscountRequirements()
        {
            InitializeComponent();
        }

        private void frmDiscountRequirements_Load(object sender, EventArgs e)
        {
            txtTotalTransactions.Focus();
        }

        private void btnSetReq_Click(object sender, EventArgs e)
        {
            if (txtTotalTransactions.Text == "" || txtTotalTransactions.Text == null)
            {
                MessageBox.Show("Null not allowed!");
            }else if (txtTotalCost.Text == "" || txtTotalCost.Text == null)
            {
                MessageBox.Show("Null not allowed!");
            }
            else
            {
                int totalTransaction = Convert.ToInt32(txtTotalTransactions.Text);
                double totalCost = Convert.ToDouble(txtTotalCost.Text);
                QueryInsert = "Update tblDiscounts " +
                    "Set total_transaction = '"+totalTransaction+"', total_cost = '"+totalCost+"'" +
                    "WHERE Discount_code = 'LC01'";
                con.Open();
                cmd = new SqlCommand(QueryInsert, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Success!");
                this.Close();
            }
        }
    }
}
