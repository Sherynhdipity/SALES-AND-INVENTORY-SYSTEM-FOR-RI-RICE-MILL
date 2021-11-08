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
    public partial class frmRestore : Form
    {
        public frmRestore()
        {
            InitializeComponent();
        }

        public static SqlConnection con = new SqlConnection(DBConnection.con);
        public static SqlCommand cmd = new SqlCommand();
        public static string QueryRestore1, QueryRestore2, QueryRestore3;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "SQL SERVER Database Backup File |*.bak";
            dialog.Title = "Database Restore";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                txtRestore.Text = dialog.FileName;
                btnRestore.Enabled = true;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            string database = con.Database.ToString();
            con.Open();

            try
            {
                QueryRestore1 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                cmd = new SqlCommand(QueryRestore1, con);
                cmd.ExecuteNonQuery();

                QueryRestore2 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + txtRestore.Text + "' WITH REPLACE;";
                cmd = new SqlCommand(QueryRestore2, con);
                cmd.ExecuteNonQuery();

                QueryRestore3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER ");
                cmd = new SqlCommand(QueryRestore3, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Database Backed up Successfully!", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
