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
    public partial class frmUpdateStocks : Form
    {
        private string quantity;
        private string description;
        private string batch_number;
        public string Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Batch_number
        {
            get { return batch_number; }
            set { batch_number = value; }
        }
        public frmUpdateStocks()
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
        public static int index;

        private void frmAddStocks_Load(object sender, EventArgs e)
        {
            txtDescription.Text = Description;
            txtBatchQuantity.Text = Quantity;
          
            txtBatchQuantity.Enabled = false;
            txtAdjustment.Enabled = false;
            bunifuButton1.Enabled = false;
            dgvSKUList.Refresh();
            displayExistingSKU();
            dgvSKUList.ClearSelection();
           // autoCompleteDescription();
            //this.ActiveControl = txtViewItem;

            DateTime date = DateTime.Now;
            dtpMilledDate.Text = string.Format("{0:D}", date);
            dtpStockInDate.Text = string.Format("{0:D}", date);
            dtpDate.Text = string.Format("{0:D}", date);
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
            //try
            //{
            //    if (txtViewItem.Text == "" || txtViewItem.Text == null)
            //    {
            //        ClearControls();
            //    }
            //    else
            //    {
            //        con.Open();
            //        QuerySelect = "SELECT * FROM  ItemViews WHERE (ID LIKE '%' + @id + '%') OR (Description LIKE '%' + @desc + '%') OR (Price LIKE '%' + @price + '%') OR ([Critical Level] LIKE '%' + @crit + '%')";


            //        cmd = new SqlCommand(QuerySelect, con);
            //        cmd.Parameters.AddWithValue("@id", txtViewItem.Text);
            //        cmd.Parameters.AddWithValue("@desc", txtViewItem.Text);
            //        cmd.Parameters.AddWithValue("@price", txtViewItem.Text);
            //        cmd.Parameters.AddWithValue("@crit", txtViewItem.Text);
            //        adapter = new SqlDataAdapter(cmd);
            //        dt = new DataTable();
            //        adapter.Fill(dt);
            //        if (dt.Rows.Count > 0)
            //        {
            //            //txtItemNumber.Text = dt.Rows[0]["ID"].ToString();
            //            txtDescription.Text = dt.Rows[0]["Description"].ToString();
            //            //txtBarcode.Text = dt.Rows[0]["Barcode"].ToString();
            //            //txtPrice.Text = dt.Rows[0]["Price"].ToString();
            //            //txtUnit.Text = dt.Rows[0]["Unit"].ToString();
            //            //txtCriticalLevel.Text = dt.Rows[0]["Critical Level"].ToString();
            //            //txtSKU.Text = remVowel(dt.Rows[0]["Description"].ToString(), dt.Rows[0]["Unit"].ToString());
            //        }
            //    }
                
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    con.Close();
            //}
        }

        //add item

        public void updateStock()
        {
            con.Close();

            if (String.IsNullOrEmpty(txtBatchQuantity.Text))
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
                result = MessageBox.Show("Do you want to update this stock?", "Update Item", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        QuerySelect  = "Select TOP "+index+ " SKU from tblInventories WHERE Item_id = (SELECT Item_id From tblItems WHERE Description = '"+Description+ "') AND Batch_number = '" + Batch_number + "' AND status = 'Stock In' ORDER BY Inventory_id DESC";
                        cmd = new SqlCommand(QuerySelect, con);
                        cmd.Parameters.AddWithValue("@desc", Description);
                        cmd.Parameters.AddWithValue("@batch_num", Batch_number);
                        cmd = new SqlCommand(QuerySelect, con);
                        adapter = new SqlDataAdapter(cmd);
                        dt = new DataTable();
                        adapter.Fill(dt);
                        if(dt.Rows.Count > 0)
                        {
                            for(int i = 0; i < dt.Rows.Count; i++)
                            {
                                QueryDelete = "DELETE FROM tblInventories WHERE SKU = '" + dt.Rows[i][0].ToString() + "' AND Batch_number = '"+Batch_number+"'";
                                cmd = new SqlCommand(QueryDelete, con);
                                cmd.ExecuteNonQuery();

                                
                            }
                            MessageBox.Show("Stock updated!");
                            this.Close();
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

            }
        }

        public void autoCompleteDescription()
        {
            //con.Close();
            //QuerySelect = "SELECT [Description] FROM tblItems " +
            //    "WHERE Description LIKE '"+txtViewItem.Text+"%'";
            //cmd = new SqlCommand(QuerySelect, con);
            //con.Open();
            //reader = cmd.ExecuteReader();
            //AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            //while (reader.Read())
            //{
            //    MyCollection.Add(reader.GetString(0));
            //}
            //txtViewItem.AutoCompleteCustomSource = MyCollection;
            //con.Close();
        }



        public static string ReplaceWhitespace(string input, string replacement)
        {
            return sWhitespace.Replace(input, replacement);
        }

        public void adjustStock()
        {
            string id = "";
           
            int selectedRows = dgvSKUList.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if(selectedRows > 0)
            {
                con.Close();
                con.Open();
                foreach (DataGridViewRow row in dgvSKUList.SelectedRows)
                {
                    QuerySelect = "SELECT Inventory_id FROM tblInventories WHERE SKU = @sku AND Status = 'Stock In'";
                    cmd = new SqlCommand(QuerySelect, con);
                    cmd.Parameters.AddWithValue("sku", dgvSKUList.Rows[row.Index].Cells[0].Value.ToString());
                    
 
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            id = reader["Inventory_id"].ToString();
                        }
                    }
                    reader.Close();


                    QueryInsert = "INSERT INTO tblInventoryAdjustment (Inventory_id, Reason, SKU, Date)" +
                        "VALUES (@inventory_id, @reason,@SKU,@date)";
                    cmd = new SqlCommand(QueryInsert, con);
                    cmd.Parameters.AddWithValue("inventory_id", id);
                    cmd.Parameters.AddWithValue("reason", txtReason.Text);
                    cmd.Parameters.AddWithValue("SKU", dgvSKUList.Rows[row.Index].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("Date", dtpDate.Value.ToString());
                    cmd.ExecuteNonQuery();

                    QueryDelete = "DELETE FROM tblInventories WHERE SKU = '" + dgvSKUList.Rows[row.Index].Cells[0].Value.ToString() + "' AND Batch_number = '" + Batch_number + "'";
                    cmd = new SqlCommand(QueryDelete, con);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                dgvSKUList.ClearSelection();
                txtReason.Text = "";
                MessageBox.Show("Stock adjusted!");
                this.Close();

            }
            else
            {
                MessageBox.Show("Please select row/s!");
            }
          

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            // updateStock();
            adjustStock();
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

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
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

        public void displayExistingSKU()
        {
            con.Close();
            QuerySelect = "Select SKU from tblInventories " +
                       "WHERE Item_id = (SELECT Item_id From tblItems WHERE Description = @desc) " +
                       "AND Batch_number = @batch_num AND status = 'Stock In'";
            cmd = new SqlCommand(QuerySelect, con);
            cmd.Parameters.AddWithValue("@desc", Description);
            cmd.Parameters.AddWithValue("@batch_num", Batch_number);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvSKUList.DataSource = dt;

            dgvSKUList.Refresh();
        }

        public void displaySKU()
        {
            displayExistingSKU();
            int existingQuantity = Convert.ToInt32(Quantity);
            int updatedQuantity = Convert.ToInt32(txtBatchQuantity.Text);
            index = existingQuantity - updatedQuantity;
            for(int i = 0; i<index; i++)
            {
                dgvSKUList.Rows.RemoveAt(dgvSKUList.Rows.Count - 1);
            }
            
            //try
            //{
            //    dgvSKUList.Rows.Clear();
            //    dgvSKUList.Refresh();

            //    if (txtBatchQuantity.Text == "")
            //    {
            //        MessageBox.Show("Enter Quantity!");
            //    }
            //    else
            //    {
            //        string description;
            //        int quantity;

            //        description = txtDescription.Text;
            //        quantity = Convert.ToInt32(txtBatchQuantity.Text);

            //        dgvSKUList.ColumnCount = 1;
            //        //dgvSKUList.Columns[0].Name = "";
            //        dgvSKUList.Columns[0].Name = "SKU";

            //        QuerySelect = "Select SKU from tblInventories " +
            //            "WHERE Inventory_id = (SELECT MAX(Inventory_id) FROM tblInventories) " +
            //            "AND Item_id = (SELECT Item_id FROM tblItems WHERE Description = '" + description + "')";
            //        cmd = new SqlCommand(QuerySelect, con);
            //        con.Open();
            //        reader = cmd.ExecuteReader();
            //        reader.Read();
            //        if (reader.HasRows)
            //        {

            //            string sku = reader.GetString(0);
            //            string lastCharacter = sku.Substring(sku.Length - 3);
            //            //string lastCharacter = (sku1 + sku2 + sku3).ToString();
            //            //MessageBox.Show(lastCharacter.ToString());
            //            int lastSKU = Convert.ToInt32(lastCharacter.ToString()) + 1;
            //            string newDesc = makeShortCode(description);
            //            for (int i = lastSKU; i < quantity + lastSKU; i++)
            //            {
            //                string[] row = new string[] { ReplaceWhitespace(newDesc, "") + "" + i.ToString("000") };
            //                dgvSKUList.Rows.Add(row);
            //            }

            //        }
            //        else
            //        {
            //            string newDesc = makeShortCode(description);
            //            for (int i = 1; i <= quantity; i++)
            //            {
            //                string[] row = new string[] { ReplaceWhitespace(newDesc, "") + "" + i.ToString("000") };
            //                dgvSKUList.Rows.Add(row);
            //            }
            //        }
            //        con.Close();

            //    }
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    con.Close();
            //}

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            int existingQuantity = Convert.ToInt32(Quantity);
            int updatedQuantity = Convert.ToInt32(txtBatchQuantity.Text);
            if(existingQuantity < updatedQuantity)
            {
                MessageBox.Show("Please input lesser quantity", "Authorization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBatchQuantity.Text = Quantity;
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
            if(rows > 0)
            {
                for (int i =0; i < rows; i++)
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
            dtpMilledDate.Enabled = false;
        }

        private void pbBarcode_Click(object sender, EventArgs e)
        {

        }

        private void dgvSKUList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRows = dgvSKUList.Rows.GetRowCount(DataGridViewElementStates.Selected);
            int currentQuantity = Convert.ToInt32(Quantity);
            txtBatchQuantity.Text = (currentQuantity - selectedRows).ToString();
            txtAdjustment.Text = selectedRows.ToString();
           // MessageBox.Show("test");
        }

        private void dtpStockInDate_ValueChanged(object sender, EventArgs e)
        {
            dtpStockInDate.Enabled = false;
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Today > dtpDate.Value || DateTime.Today < dtpDate.Value)
            {
                MessageBox.Show("The Selected date is Invalid!!");
                dtpDate.Value = DateTime.Today;
            }
        }
    }
}
