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
    public partial class frmSalesHistory : Form
    {
        public frmSalesHistory()
        {
            InitializeComponent();
            DisplaySalesHistory();
        }

        public static SqlConnection con = new SqlConnection(DBConnection.con);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader reader;
        public static SqlDataAdapter adapter;
        public static DataTable dt = new DataTable();
        public static string QuerySelect;




    //Display TransactionData in DataGridView  
    public void DisplaySalesHistory()
        {

            con.Open();
            QuerySelect = "SELECT t.TransactionDate AS 'Transaction Date', t.TransactionNo AS 'Transaction No.', p.QuantityBought AS 'Quantity', p.VAT AS 'Tax', pm.TotalAmount AS 'Total Amount' FROM tblTransactions t INNER JOIN tblPurchases p ON t.PurchaseID = p.PurchaseID INNER JOIN tblPayments pm ON t.PurchaseID = p.PurchaseID";
            cmd = new SqlCommand(QuerySelect, con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);

            dgvSalesHistory.DataSource = dt;
            dgvSalesHistory.Refresh();
            con.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
