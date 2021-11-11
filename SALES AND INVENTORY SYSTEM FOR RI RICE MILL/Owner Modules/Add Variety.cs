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
    public partial class frmAddVariety : Form
    {
        public frmAddVariety()
        {
            InitializeComponent();

        }

        public static SqlConnection con = new SqlConnection(DBConnection.con);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader reader;
        public static SqlDataAdapter adapter;
        public static DataTable dt = new DataTable();
        frmSalesManagement sales = new frmSalesManagement();
        public static DialogResult result;
        public static string QueryInsert;
        public static string QuerySelect;
        public static string QueryUpdate;


        void ClearControls()
        {
            txtVariety.Text = "";   
        }


        void AddVariety()
        {
            try
            {
                if (String.IsNullOrEmpty(txtVariety.Text))
                {
                    MessageBox.Show("fields should not be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (String.IsNullOrWhiteSpace(txtVariety.Text))
                {
                    MessageBox.Show("Whitespace is not allowed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtVariety.Text != "")
                {
                    result = MessageBox.Show("Do you want to Add this Variety?", "Add Variety", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        con.Open();
                        QuerySelect = "SELECT * FROM tblProductVariety WHERE VarietyName = '" + txtVariety.Text + "'";
                        cmd = new SqlCommand(QuerySelect, con);
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            MessageBox.Show("This Product Variety already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        else
                        {
                            try
                            {
                                con.Close();
                                con.Open();
                                QueryInsert = "INSERT INTO tblProductVariety (VarietyName) VALUES ('" + txtVariety.Text + "')";
                                cmd = new SqlCommand(QueryInsert, con);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Product Variety Added Successfully!", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearControls();

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

                    }
                    else
                    {
                        MessageBox.Show("This Product Variety already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddVariety_Click(object sender, EventArgs e)
        {
            AddVariety();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
