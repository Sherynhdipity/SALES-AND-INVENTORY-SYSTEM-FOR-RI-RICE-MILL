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
    public partial class frmDiscount : Form
    {
        public frmDiscount()
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


        public void DisplayDiscounts()
        {
            con.Close();
            con.Open();
            QuerySelect = "SELECT DiscountID, DiscountName from tblDiscounts";
            cmd = new SqlCommand(QuerySelect, con);

            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);

            drpDiscount.DataSource = dt;
            drpDiscount.DisplayMember = "DiscountName";
            drpDiscount.ValueMember = "DiscountID";
        }


        private void btnXit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
