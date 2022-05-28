using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;

namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Owner_Modules
{
    public partial class frmInventoryValuation : Form
    {
        public frmInventoryValuation()
        {
            InitializeComponent();
        }

        public static SqlConnection con = new SqlConnection(DBConnection.con);
        public static SqlCommand cmd;
        public static SqlDataReader reader;
        public static SqlDataAdapter adapter;
        public static DataSet ds;
        public static DataTable dt;
        public static DialogResult result;
        public static string QuerySelect;

        private void InventoryValuation_Load(object sender, EventArgs e)
        {

            QuerySelect = "Select Batch_number, Description, [In Stock], Cost_Price, Price, [Item Total Cost], [Total Selling Price], [Total Selling Price] - [Item Total Cost] as [Potential Profit]  from InventoryValuationView";

            cmd = new SqlCommand(QuerySelect, con);

            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvInventoryValuation.DataSource = dt;
            dgvInventoryValuation.Refresh();

            double sum = 0;
            for (int i = 0; i < dgvInventoryValuation.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dgvInventoryValuation.Rows[i].Cells[6].Value);
            }

            lblTotalProfit.Text = sum.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                QuerySelect = "Select Batch_number, Description, [In Stock], Cost_Price, Price, [Item Total Cost], [Total Selling Price], [Total Selling Price] - [Item Total Cost] as [Potential Profit]  from InventoryValuationView";

                cmd = new SqlCommand(QuerySelect, con);

                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dgvInventoryValuation.DataSource = dt;
                dgvInventoryValuation.Refresh();

                float sum = 0;
                for (int i = 0; i < dgvInventoryValuation.Rows.Count; i++)
                {
                    sum += Convert.ToInt32(dgvInventoryValuation.Rows[i].Cells[6].Value);
                }

                lblTotalProfit.Text = sum.ToString();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
