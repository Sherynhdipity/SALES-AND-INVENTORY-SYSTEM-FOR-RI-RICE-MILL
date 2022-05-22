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
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Owner_Modules
{
    public partial class frmItemList : Form
    {
        public frmItemList()
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


        private void ItemList_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "Select Description, Cost_Price, Price, Critical_Level from tblItems";
                cmd = new SqlCommand(query, con);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dgvItemList.DataSource = dt;
                dgvItemList.Refresh();

            }
            catch (Exception ex)
            {
                
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "Select Description, Cost_Price, Price, Critical_Level from tblItems where Description = @desc";
    
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@desc", txtSearchItem.Text);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvItemList.DataSource = dt;
            dgvItemList.Refresh();
        }
    }
}
