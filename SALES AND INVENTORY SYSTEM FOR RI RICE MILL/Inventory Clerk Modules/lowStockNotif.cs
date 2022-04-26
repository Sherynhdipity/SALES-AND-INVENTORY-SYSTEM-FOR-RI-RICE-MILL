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
    public partial class lowStockNotif : Form
    {

        public static SqlConnection con = new SqlConnection(DBConnection.con);
        public static SqlCommand cmd = new SqlCommand();
        public lowStockNotif()
        {
            InitializeComponent();
        }

        private void lowStockNotif_Load(object sender, EventArgs e)
        {
            popDgv();
        }
        void popDgv()
        {
            try
            {

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                con.Open();

                string query = "SELECT * FROM lowStockView WHERE [Available Stock] < [Restock Level]";
                cmd = new SqlCommand(query, con);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvLLS.DataSource = dt;
                dgvLLS.Refresh();


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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
