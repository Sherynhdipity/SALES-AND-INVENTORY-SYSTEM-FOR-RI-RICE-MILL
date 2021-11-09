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

        public string discountID { get; set; }
        public void DisplayDiscounts()
        {
            con.Close();
            con.Open();
            QuerySelect = "SELECT DiscountID, DiscountName from tblDiscount";
            cmd = new SqlCommand(QuerySelect, con);

            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);

            drpDiscount.DataSource = dt;
            drpDiscount.DisplayMember = "DiscountName";
            drpDiscount.ValueMember = "DiscountID";
            drpDiscount.SelectedIndex = 0;
        }


        private void btnXit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void drpDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            discountID = drpDiscount.SelectedValue.ToString();
        }

        private void frmDiscount_Load(object sender, EventArgs e)
        {
            DisplayDiscounts();
        }

        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            btnXit_Click(sender, e);
        }
    }
}
