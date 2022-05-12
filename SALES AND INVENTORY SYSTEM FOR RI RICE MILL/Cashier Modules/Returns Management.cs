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

namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Cashier_Modules
{
    public partial class ucReturns : UserControl
    {

        private static ucReturns returns;

        public static ucReturns returnsInstance
        {
            get
            {
                if (returns == null)
                    returns = new ucReturns();
                return returns;
            }

        }

        frmReturnItem returnItem = new frmReturnItem();

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

        public ucReturns()
        {
            InitializeComponent();
            returnItem.FormClosed += new FormClosedEventHandler(Form_Closed);
        }

        void Form_Closed(object sender, FormClosedEventArgs e)
        {
            frmReturnItem frm = (frmReturnItem)sender;
        }

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
                dgvOrderDeetsList.DataSource = dt;
                dgvOrderDeetsList.Refresh();
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

        private void btnViewReturn_Click(object sender, EventArgs e)
        {
            viewReturn();
        }
    }
}
