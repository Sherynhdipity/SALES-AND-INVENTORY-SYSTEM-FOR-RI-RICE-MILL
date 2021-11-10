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
    public partial class frmPLQuant : Form
    {
        public frmPLQuant()
        {
            InitializeComponent();
        }

        frmProductLookup productLookup = new frmProductLookup();
        frmSalesManagement salesManagement = new frmSalesManagement();
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
        public string product_Code { get; set; }
        public string product_Desc { get; set; }
        public string product_Variety { get; set; }
        public string product_Price { get; set; }

        public int Product_Quantity { get; set; }
        public string Product_Stock { get; set; }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                try
                {

                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }

                    Product_Quantity = Convert.ToInt32(txtQty.Text);
                    this.Close();

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
    }
}
