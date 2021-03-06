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
    public partial class frmMainOwner : Form
    {
        public static SqlConnection con = new SqlConnection(DBConnection.con);
        public static SqlCommand cmd;
        public static SqlDataReader reader;

        public frmMainOwner()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            con.Open();

            lblAdminName.Text = frmLogin.GetUserName.ToString();
            lblAdminRole.Text = frmLogin.GetUserRole.ToString();

            con.Close();
        }

        public bool isFormMinimized = false;

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                bunifuPanel1.Visible = true;
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {


            if (!panelModule.Controls.Contains(ucUsers.usersInstance))
            {
                panelModule.Controls.Add(ucUsers.usersInstance);
                panelModule.Refresh();
                ucUsers.usersInstance.Dock = DockStyle.Fill;
                
            }
            else
            {
                ucUsers.usersInstance.BringToFront();
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {

            if (!panelModule.Controls.Contains(ucReports.reportsInstance))
            {
                panelModule.Controls.Add(ucReports.reportsInstance);
                ucReports.reportsInstance.Dock = DockStyle.Fill;
                ucReports.reportsInstance.BringToFront();
            }
            else
            {

                ucReports.reportsInstance.BringToFront();
            }
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {

            if (!panelModule.Controls.Contains(ucProducts.productsInstance))
            {
                panelModule.Controls.Add(ucProducts.productsInstance);
                ucProducts.productsInstance.Dock = DockStyle.Fill;
            }
            else
            {
                ucProducts.productsInstance.BringToFront();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

            if (!panelModule.Controls.Contains(ucDashboard.dashboardInstance))
            {
                panelModule.Controls.Add(ucDashboard.dashboardInstance);
                ucDashboard.dashboardInstance.Dock = DockStyle.Fill;
                ucDashboard.dashboardInstance.BringToFront();
            }
            else
            {
                ucDashboard.dashboardInstance.BringToFront();
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (!panelModule.Controls.Contains(ucBackupRestore.backupRestoreInstance))
            {
                panelModule.Controls.Add(ucBackupRestore.backupRestoreInstance);
                ucBackupRestore.backupRestoreInstance.Dock = DockStyle.Fill;
                ucBackupRestore.backupRestoreInstance.BringToFront();
            }
            else
            {
                ucBackupRestore.backupRestoreInstance.BringToFront();
            }
        }

        private void panelLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Logout from the System?", "Log-out", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                frmLogin login = new frmLogin();
                this.Hide();
                login.Show();

            }
            else if(dialog == DialogResult.No)
            {

            }
        }
    }
}
