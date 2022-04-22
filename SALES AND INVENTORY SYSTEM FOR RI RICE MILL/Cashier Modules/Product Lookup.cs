﻿using System;
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
    public partial class frmProductLookup : Form
    {
        public frmProductLookup()
        {
            InitializeComponent();
            DisplayProductList();

            dgvProductList.Columns.Add(new DataGridViewButtonColumn()
            {
                Text = "Add",
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            });
        }

        public static SqlConnection con = new SqlConnection(DBConnection.con);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader reader;
        public static SqlDataAdapter adapter;
        public static DataTable dt = new DataTable();
        public static string QuerySelect;
        public string productCode { get; set; }
        public string productDesc { get; set; }
        public string productVariety { get; set; }
        public string productPrice { get; set; }

        public int quantity { get; set; }
        public string stock { get; set; }


    //Display ProductData in DataGridView  
    public void DisplayProductList()
        {

            con.Open();
            QuerySelect = "SELECT Description, Price, Stock FROM ItemLookUp";
            cmd = new SqlCommand(QuerySelect, con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);

            dgvProductList.DataSource = dt;
            dgvProductList.Refresh();
            con.Close();
        }

        private void txtSearchProduct_TextChange(object sender, EventArgs e)
        {
            if (txtSearchProduct.Text == "")
            {
                DisplayProductList();
            }
            else
            {
                con.Open();
                QuerySelect = "SELECT Barcode, Description , Price FROM tblItems WHERE Barcode LIKE '" + txtSearchProduct.Text + "%' OR Description LIKE '%" + txtSearchProduct.Text + "%' OR Price LIKE '%" + txtSearchProduct.Text + "' ORDER BY Item_id DESC";
                cmd = new SqlCommand(QuerySelect, con);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dgvProductList.DataSource = dt;
                dgvProductList.Refresh();

                con.Close();
            }

        }

        private void dgvProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dgvProductList.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvProductList.Rows[selectedrowindex];
            //DataGridViewRow row = dgvProductList.Rows[e.RowIndex];

            var grid = (DataGridView)sender;

            if (e.RowIndex < 0)
            {
                //They clicked the header column, do nothing
                return;
            }

            if (grid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                string temp_stock = "";
                con.Close();
                con.Open();
                QuerySelect = "SELECT COUNT(a.Item_id) as 'Stock' FROM tblInventories a INNER JOIN tblItems b ON a.Item_id = b.Item_id WHERE b.Description = '" + Convert.ToString(selectedRow.Cells["Description"].Value) + "';";
                //QuerySelect = "select Count(tblBatchProduct.BatchID) AS Stock from tblBatchProduct INNER JOIN tblStockin on tblBatchProduct.BatchID = tblStockin.BatchID where Status='IN' AND tblStockin.ProductID = (SELECT ProductID FROM tblProducts WHERE ProductCode = '"  + Convert.ToString(selectedRow.Cells["Product Code"].Value) + "')";
                cmd = new SqlCommand(QuerySelect, con);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    temp_stock = reader["Stock"].ToString();
                    reader.Close();
                }
                else
                {
                    temp_stock = "888888";
                }
                con.Close();

                frmPLQuant qty = new frmPLQuant();
                //qty.product_Code = Convert.ToString(selectedRow.Cells["Barcode"].Value);
                qty.product_Desc = Convert.ToString(selectedRow.Cells["Description"].Value);
              //  qty.product_Variety = Convert.ToString(selectedRow.Cells["Product Variety"].Value);
                qty.product_Price = Convert.ToString(selectedRow.Cells["Price"].Value);
                qty.Product_Stock = temp_stock;
                qty.ShowDialog();
                productCode = qty.product_Code;
                productDesc = qty.product_Desc;
                productVariety = qty.product_Variety;
                productPrice = qty.product_Price;
                quantity = qty.Product_Quantity;
                stock = qty.Product_Stock;
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
