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
using ZXing;
using System.Text.RegularExpressions;
using System.IO;
using System.Drawing.Imaging;

namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Inventory_Clerk_Modules
{
    public partial class frmStockCard : Form
    {
        public frmStockCard()
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
        public static string QueryDelete;
        public static string status = "Active";

      

        private void frmStockCard_Load(object sender, EventArgs e)
        {
            dtvStockCard.Refresh();
            
        }
    }
}
