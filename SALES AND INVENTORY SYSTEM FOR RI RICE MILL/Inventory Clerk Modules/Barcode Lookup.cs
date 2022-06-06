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
using ZXing;
using System.Text.RegularExpressions;
using System.IO;
using System.Drawing.Imaging;

namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Inventory_Clerk_Modules
{
    public partial class frmBarcodeLookup : Form
    {
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public frmBarcodeLookup()
        {
            InitializeComponent();
        }

        public static SqlConnection con = new SqlConnection(DBConnection.con);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader reader;
        public static SqlDataAdapter adapter;
        public static DataTable dt = new DataTable();
        public static DialogResult result;
        public static string QueryInsert;
        public static string QuerySelect;
        public static string QueryUpdate;
        public static string QueryDelete;
        public static string status = "Active";
        private static readonly Regex sWhitespace = new Regex(@"\s+");

        private void frmAddStocks_Load(object sender, EventArgs e)
        {
            dgvSKUList.Refresh();
            autoCompleteDescription();
            this.ActiveControl = txtViewItem;
            DateTime date = DateTime.Now;
        }

        public void ClearControls()
        {
            txtDescription.Clear();
            txtBatchNumber.Clear();
            dgvSKUList.Rows.Clear();
            dgvSKUList.Refresh();
        }

        static String remVowel(String str, String str1)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            List<char> al = vowels.OfType<char>().ToList();

            StringBuilder sb = new StringBuilder(str);

            for (int i = 0; i < sb.Length; i++)
            {

                if (al.Contains(sb[i]))
                {
                    sb.Replace(sb[i].ToString(), "");
                    i--;
                }
            }

            string final = sb.ToString() + "-" + str1.ToString();
            final = final.Replace(" ", String.Empty);
            return final;
        }

        static string RemoveVowel(string input)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                    case '-':
                    case ' ':
                        sb.Append("");
                        break;

                    default:
                        sb.Append(input[i]);
                        break;
                }
            }
            return sb.ToString();
        }

        public void DisplayItems()
        {
            try
            {
                if (txtViewItem.Text == "" || txtViewItem.Text == null)
                {
                    ClearControls();
                }
                else
                {
                    con.Open();
                    QuerySelect = "SELECT * FROM  ItemViews WHERE (ID LIKE '%' + @id + '%') OR (Description LIKE '%' + @desc + '%') OR (Price LIKE '%' + @price + '%') OR ([Critical Level] LIKE '%' + @crit + '%')";


                    cmd = new SqlCommand(QuerySelect, con);
                    cmd.Parameters.AddWithValue("@id", txtViewItem.Text);
                    cmd.Parameters.AddWithValue("@desc", txtViewItem.Text);
                    cmd.Parameters.AddWithValue("@price", txtViewItem.Text);
                    cmd.Parameters.AddWithValue("@crit", txtViewItem.Text);
                    adapter = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        txtDescription.Text = dt.Rows[0]["Description"].ToString();
                    }
                }

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


        public void autoCompleteDescription()
        {
            con.Close();
            QuerySelect = "SELECT [Description] FROM tblItems " +
                "WHERE Description LIKE '" + txtViewItem.Text + "%'";
            cmd = new SqlCommand(QuerySelect, con);
            con.Open();
            reader = cmd.ExecuteReader();
            AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                MyCollection.Add(reader.GetString(0));
            }
            txtViewItem.AutoCompleteCustomSource = MyCollection;
            con.Close();
        }



        private void txtViewItem_TextChange(object sender, EventArgs e)
        {
            if (txtViewItem.Text != "" || txtViewItem.Text != null)
            {
                DisplayItems();
            }
            else
            {
                ClearControls();
            }

        }

        public void displaySKU()
        {
            dgvSKUList.Rows.Clear();
            dgvSKUList.Refresh();

            if (txtDescription.Text == "")
            {
                MessageBox.Show("Enter Item Description!");
            }
            else if (txtBatchNumber.Text == "")
            {
                MessageBox.Show("Enter Batch Number!");
            }
            else
            {
                try
                {
                    con.Close();
                    con.Open();

                    QuerySelect = "Select SKU from tblInventories WHERE Item_id = (SELECT Item_id from tblItems Where [Description] = @desc) AND Batch_number = @batchNum";

                    cmd = new SqlCommand(QuerySelect, con);

                    cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@batchNum", txtBatchNumber.Text);

                    adapter = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    adapter.Fill(dt);

                    dgvSKUList.DataSource = dt;
                    dgvSKUList.Refresh();
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


        private void txtBatchNumber_TextChange(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtBatchNumber.Text, @"^\d+$"))
            {
                MessageBox.Show("Batch Number must be in Numbers Only!");

            }
        }

        private void btnGenerateSKU_Click(object sender, EventArgs e)
        {
            displaySKU();
        }

        private void btnPrintBarcode_Click(object sender, EventArgs e)
        {
            this.appData1.Clear();
            int rows = dgvSKUList.Rows.Count;
            if (rows > 0)
            {
                for (int i = 0; i < rows; i++)
                {
                    //MessageBox.Show(dgvSKUList.Rows[i].Cells[0].Value.ToString());
                    BarcodeLib.Barcode barcode = new BarcodeLib.Barcode();
                    Image img = barcode.Encode(BarcodeLib.TYPE.CODE128, dgvSKUList.Rows[i].Cells[0].Value.ToString(), Color.Black, Color.White, 290, 120);
                    //pbBarcode.Image = img;

                    //this.appData1.Clear();
                    using (MemoryStream ms = new MemoryStream())
                    {
                        img.Save(ms, ImageFormat.Png);
                        //for (int i = 0; i < 5; i++)
                        this.appData1.Barcode.AddBarcodeRow(dgvSKUList.Rows[i].Cells[0].Value.ToString(), ms.ToArray());
                    }


                }
                using (frmBarcodes frm = new frmBarcodes(this.appData1.Barcode))
                {
                    frm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Enter Item First!");
            }
        }
    }
}
