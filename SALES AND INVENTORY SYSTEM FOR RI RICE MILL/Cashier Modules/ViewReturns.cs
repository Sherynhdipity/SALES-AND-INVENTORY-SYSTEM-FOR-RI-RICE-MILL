using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL
{
    public partial class frmViewReturns : Form
    {
        public frmViewReturns()
        {
            InitializeComponent();
            viewReturn();
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


        void viewReturn()
        {
            try
            {
                con.Open();

                QuerySelect = "SELECT * FROM  tblReturns";
                cmd = new SqlCommand(QuerySelect, con);
                
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dgvReturns.DataSource = dt;
                dgvReturns.Refresh();
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
