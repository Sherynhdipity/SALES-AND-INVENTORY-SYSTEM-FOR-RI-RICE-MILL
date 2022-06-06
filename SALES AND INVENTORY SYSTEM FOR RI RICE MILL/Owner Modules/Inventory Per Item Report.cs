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

namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Owner_Modules
{
    public partial class frmOwnerInventoryReport : Form
    {
        public frmOwnerInventoryReport()
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

        string date1;
        string date2;

        public void displayItems()
        {
            try
            {

                if (txtSearchItem.Text == "" || txtSearchItem.Text == null)
                {
                    QuerySelect = "Select * from InventoryPerItemView";
                }
                else
                {
                    QuerySelect = "Select * from InventoryPerItemView where (Description LIKE '%' + @desc + '%')";
                }


                cmd = new SqlCommand(QuerySelect, con);
                cmd.Parameters.AddWithValue("@desc", txtSearchItem.Text);

                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dgvInventoryOwnerReport.DataSource = dt;
                dgvInventoryOwnerReport.Refresh();

                int sum = 0;
                for (int i = 0; i < dgvInventoryOwnerReport.Rows.Count; i++)
                {
                    sum += Convert.ToInt32(dgvInventoryOwnerReport.Rows[i].Cells[4].Value);
                }
                txtTotal.Text = sum.ToString();

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

        private void frmOwnerInventoryReport_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;

            QuerySelect = "Select * from InventoryPerItemView";

            cmd = new SqlCommand(QuerySelect, con);

            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvInventoryOwnerReport.DataSource = dt;
            dgvInventoryOwnerReport.Refresh();

            int sum = 0;
            for (int i = 0; i < dgvInventoryOwnerReport.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dgvInventoryOwnerReport.Rows[i].Cells[4].Value);
            }
            txtTotal.Text = sum.ToString();
        }

        private void txtSearchItem_TextChange(object sender, EventArgs e)
        {
            displayItems();
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            PerItems inventory = new PerItems();
            frmInventoryReport frm = new frmInventoryReport();

            try
            {

                con.Open();

                dt = new DataTable();

                if (txtSearchItem.Text == "" || txtSearchItem.Text == null)
                {
                    QuerySelect = "Select * from InventoryPerItemView";
                    cmd = new SqlCommand(QuerySelect, con);
                    adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    inventory.Database.Tables["InventoryPerItemView"].SetDataSource(dt);
                    frm.InventoryReportViewer1.ReportSource = inventory;
                    con.Close();
                    frm.Show();
                }

                else
                {
                    QuerySelect = "Select * from InventoryPerItemView where (Description LIKE '%' + @desc + '%')";
                    cmd = new SqlCommand(QuerySelect, con);
                    cmd.Parameters.AddWithValue("@desc", txtSearchItem.Text);
                    adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    inventory.Database.Tables["InventoryPerItemView"].SetDataSource(dt);
                    frm.InventoryReportViewer1.ReportSource = inventory;
                    con.Close();
                    frm.Show();
                }





            }
            catch (Exception ex)
            {

            }
        }
    }
}