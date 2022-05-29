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

        string desc;

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
            if (txtSearchItem.Text == "" || txtSearchItem.Text == null)
            {
                QuerySelect = "Select * from tblItems";
            }
            else
            {
                QuerySelect = "Select Description, Cost_Price, Price, Critical_Level from tblItems where (Description LIKE '%' + @desc + '%')";
            }

            cmd = new SqlCommand(QuerySelect, con);
            cmd.Parameters.AddWithValue("@desc", txtSearchItem.Text);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvItemList.DataSource = dt;
            dgvItemList.Refresh();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ItemListReport item = new ItemListReport();
            frmItemListReport list = new frmItemListReport();

            try
            {
                
                con.Open();
                dt = new DataTable();
                if (txtSearchItem.Text == "" || txtSearchItem.Text == null)
                {
                    QuerySelect = "Select * from tblItems";
                }
                else
                {
                    QuerySelect = "Select Description, Cost_Price, Price, Critical_Level from tblItems where (Description LIKE '%' + @desc + '%')";
                }
                cmd = new SqlCommand(QuerySelect, con);
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                item.Database.Tables["tblItems"].SetDataSource(dt);
                list.ItemListViewer.ReportSource = item;
                con.Close();
                list.Show();
            }

            catch (Exception ex)
            {

            }
        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvItemList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1 || e.ColumnIndex == 2)
            {
                e.CellStyle.Format = "N2";
            }
        }
    }
}
