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
    public partial class frmAddStocks : Form
    {
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public frmAddStocks()
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
            dtpMilledDate.Text = string.Format("{0:D}", date);
            dtpStockInDate.Text = string.Format("{0:D}", date);
        }

        public void ClearControls()
        {
            txtDescription.Clear();
            txtBatchQuantity.Clear();
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
                        //txtItemNumber.Text = dt.Rows[0]["ID"].ToString();
                        txtDescription.Text = dt.Rows[0]["Description"].ToString();
                        //txtBarcode.Text = dt.Rows[0]["Barcode"].ToString();
                        //txtPrice.Text = dt.Rows[0]["Price"].ToString();
                        //txtUnit.Text = dt.Rows[0]["Unit"].ToString();
                        //txtCriticalLevel.Text = dt.Rows[0]["Critical Level"].ToString();
                        //txtSKU.Text = remVowel(dt.Rows[0]["Description"].ToString(), dt.Rows[0]["Unit"].ToString());
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

        //add item

        public void addStock()
        {
            con.Close();

            if (String.IsNullOrEmpty(txtViewItem.Text))
            {
                MessageBox.Show("Enter Item!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtViewItem.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtViewItem.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtViewItem.Clear();
            }
            else if (String.IsNullOrEmpty(txtBatchQuantity.Text))
            {
                MessageBox.Show("Enter Batch Quantity!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBatchQuantity.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtBatchQuantity.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtBatchQuantity.Clear();
            }

           
            else
            {
                result = MessageBox.Show("Do you want to add this stock?", "Update Item", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int rows = dgvSKUList.Rows.Count;
                        con.Close();
                        con.Open();
                        if (rows > 0)
                        {
                            int batch_number;
                            QuerySelect = "SELECT MAX(Batch_number) FROM tblInventories " +
                                "WHERE Item_id = (SELECT Item_id FROM tblItems WHERE Description = @desc)";
                            cmd = new SqlCommand(QuerySelect, con);
                            cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
                            adapter = new SqlDataAdapter(cmd);
                            dt = new DataTable();
                            adapter.Fill(dt);
                            if (dt.Rows[0][0].ToString() == null || dt.Rows[0][0].ToString() == "")
                            {
                                batch_number = 1;
                            }
                            else
                            {
                                batch_number = Convert.ToInt32(dt.Rows[0][0].ToString()) + 1;
                            }


                            for (int i = 0; i < rows; i++)
                            {
                                QueryInsert = "INSERT INTO tblInventories " +
                                "(Batch_number,SKU,Milled_date,Stock_in_date,User_id,Item_id, Status) " +
                                "VALUES ('"
                                + batch_number + "', '"
                                + dgvSKUList.Rows[i].Cells[0].Value.ToString() + "', @mDate, @sDate, '"
                                + Id + "'," +
                                "(SELECT Item_id  FROM tblItems WHERE Description = @desc), 'Stock In')";

                                cmd = new SqlCommand(QueryInsert, con);
                                cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
                                cmd.Parameters.AddWithValue("@mDate", dtpMilledDate.Value.Date);
                                cmd.Parameters.AddWithValue("@sDate", dtpStockInDate.Value.Date);

                                cmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Generate SKU First!");
                        }


                        MessageBox.Show("Stock Added Successfully!", "Add Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnPrintBarcode.PerformClick();
                        txtViewItem.Clear();
                        txtBatchQuantity.Clear();
                        dgvSKUList.Rows.Clear();
                        dgvSKUList.Refresh();
                        this.Close();

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

        public static string ReplaceWhitespace(string input, string replacement)
        {
            return sWhitespace.Replace(input, replacement);
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            addStock();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBatchQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        static string makeShortCode(string i)
        {
            string input = i;
            input = RemoveVowel(input);
            int length = input.Length;
            //if (length >= 9)
            //{
            input = input.Remove(input.Length - 2);
            input = input + "00000000";
            input = input.Substring(0, 9);

            return input;
            //}
            //else
            //{
            //    input = input + "00000000";
            //    input = input.Substring(0, 9);

            //    return input;
            //}

        }

        public void displaySKU()
        {
            try
            {
                dgvSKUList.Rows.Clear();
                dgvSKUList.Refresh();

                if (txtDescription.Text == "")
                {
                    MessageBox.Show("Enter Item Description!");
                }
                else if (txtBatchQuantity.Text == "")
                {
                    MessageBox.Show("Enter Quantity!");
                }
                else
                {
                    string description;
                    int quantity;

                    description = txtDescription.Text;
                    quantity = Convert.ToInt32(txtBatchQuantity.Text);

                    dgvSKUList.ColumnCount = 1;
                    //dgvSKUList.Columns[0].Name = "";
                    dgvSKUList.Columns[0].Name = "SKU";

                    QuerySelect = "Select SKU from tblInventories " +
                        "WHERE Inventory_id = (SELECT MAX(Inventory_id) FROM tblInventories " +
                        "WHERE Item_id = (SELECT Item_id FROM tblItems WHERE Description = '" + description + "')) " +
                        "AND Item_id = (SELECT Item_id FROM tblItems WHERE Description = '" + description + "')";
                    cmd = new SqlCommand(QuerySelect, con);
                    con.Open();
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {

                        string sku = reader.GetString(0);
                        string lastCharacter = sku.Substring(sku.Length - 3);
                        //string lastCharacter = (sku1 + sku2 + sku3).ToString();
                        //MessageBox.Show(lastCharacter.ToString());
                        int lastSKU = Convert.ToInt32(lastCharacter.ToString()) + 1;
                        string newDesc = makeShortCode(description);
                        for (int i = lastSKU; i < quantity + lastSKU; i++)
                        {
                            string[] row = new string[] { ReplaceWhitespace(newDesc, "") + "" + i.ToString("000") };
                            dgvSKUList.Rows.Add(row);
                        }

                    }
                    else
                    {
                        string newDesc = makeShortCode(description);
                        for (int i = 1; i <= quantity; i++)
                        {
                            string[] row = new string[] { ReplaceWhitespace(newDesc, "") + "" + i.ToString("000") };
                            dgvSKUList.Rows.Add(row);
                        }
                    }
                    con.Close();

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

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (txtBatchQuantity.Text == "" || txtViewItem.Text == "")
            {
                MessageBox.Show("Enter Item and Batch Quantity");
            }
            else if (txtViewItem.Text == "")
            {
                MessageBox.Show("Enter Item");
            }
            else if (txtBatchQuantity.Text == "")
            {
                MessageBox.Show("Enter Batch Quantity");
            }
            
            else if (!Regex.IsMatch(txtBatchQuantity.Text, @"^\d+$"))
            {
                MessageBox.Show("Batch Quantity must be number only");
            }
            else if (!Regex.IsMatch(txtViewItem.Text, @"^[A-Za-z0-9\s-]*$"))
            {
                MessageBox.Show("Search must be exact as the product textbox show");
            }
                       
            else
            {
                displaySKU();
            }
            
        }
       
        private void bunifuButton2_Click(object sender, EventArgs e)
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

        private void dtpMilledDate_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Today < dtpMilledDate.Value)
            {
                MessageBox.Show("The selected milled date is Invalid!");
                dtpMilledDate.Value = DateTime.Today;
            }
        }

        private void dtpStockInDate_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Today > dtpStockInDate.Value || DateTime.Today < dtpStockInDate.Value)
            {
                MessageBox.Show("The Selected Stock In Date is Invalid");
                dtpStockInDate.Value = DateTime.Today;
            }
        }

        private void txtViewItem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
