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
    public partial class frmBackup : Form
    {
        public frmBackup()
        {
            InitializeComponent();
        }


        public static SqlConnection con = new SqlConnection(DBConnection.con);
        public static SqlCommand cmd = new SqlCommand();
        public static string QueryBackup;


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                txtBackupFileLoc.Text = dialog.SelectedPath;
                btnBackup.Enabled = true;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            string database = con.Database.ToString();
            if(txtBackupFileLoc.Text == string.Empty)
            {
                MessageBox.Show("Enter Backup File Location!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                QueryBackup = "BACKUP DATABASE [" + database + "] TO DISK='" + txtBackupFileLoc.Text + "\\" + "database" + "-" + DateTime.Now.ToString("yyyyy-MM-dd--HH-mm-ss") + ".bak'";
                con.Open();
                cmd = new SqlCommand(QueryBackup, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Database Backed up Successfully!", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                btnBackup.Enabled = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
