
namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL
{
    partial class lowStockNotif
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lowStockNotif));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dgvLLS = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.productDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varietyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restockLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewAvailableStocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBSalesandInventoryDataSet1 = new SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.DBSalesandInventoryDataSet1();
            this.viewAvailableStocksTableAdapter = new SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.DBSalesandInventoryDataSet1TableAdapters.viewAvailableStocksTableAdapter();
            this.btnClose = new Bunifu.Framework.UI.BunifuTileButton();
            this.dBSalesandInventoryDataSet2 = new SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.DBSalesandInventoryDataSet2();
            this.lowstocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lowstocksTableAdapter = new SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.DBSalesandInventoryDataSet2TableAdapters.lowstocksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLLS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAvailableStocksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSalesandInventoryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSalesandInventoryDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowstocksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.Location = new System.Drawing.Point(12, 26);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(105, 33);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "WARNING";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel1.Click += new System.EventHandler(this.bunifuLabel1_Click);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Consolas", 15F);
            this.bunifuLabel2.Location = new System.Drawing.Point(12, 59);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(176, 23);
            this.bunifuLabel2.TabIndex = 1;
            this.bunifuLabel2.Text = "Low Level Stocks";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dgvLLS
            // 
            this.dgvLLS.AllowCustomTheming = false;
            this.dgvLLS.AllowUserToAddRows = false;
            this.dgvLLS.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvLLS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLLS.AutoGenerateColumns = false;
            this.dgvLLS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvLLS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLLS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLLS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLLS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLLS.ColumnHeadersHeight = 40;
            this.dgvLLS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productDescriptionDataGridViewTextBoxColumn,
            this.varietyDataGridViewTextBoxColumn,
            this.restockLevelDataGridViewTextBoxColumn,
            this.productCodeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.availableStockDataGridViewTextBoxColumn});
            this.dgvLLS.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvLLS.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvLLS.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvLLS.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvLLS.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvLLS.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvLLS.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvLLS.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvLLS.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvLLS.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLLS.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvLLS.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvLLS.CurrentTheme.Name = null;
            this.dgvLLS.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLLS.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvLLS.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvLLS.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvLLS.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvLLS.DataSource = this.viewAvailableStocksBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLLS.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvLLS.EnableHeadersVisualStyles = false;
            this.dgvLLS.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvLLS.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvLLS.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvLLS.HeaderForeColor = System.Drawing.Color.White;
            this.dgvLLS.Location = new System.Drawing.Point(12, 91);
            this.dgvLLS.Name = "dgvLLS";
            this.dgvLLS.ReadOnly = true;
            this.dgvLLS.RowHeadersVisible = false;
            this.dgvLLS.RowTemplate.Height = 40;
            this.dgvLLS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLLS.Size = new System.Drawing.Size(600, 248);
            this.dgvLLS.TabIndex = 2;
            this.dgvLLS.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // productDescriptionDataGridViewTextBoxColumn
            // 
            this.productDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Product Description";
            this.productDescriptionDataGridViewTextBoxColumn.HeaderText = "Product Description";
            this.productDescriptionDataGridViewTextBoxColumn.Name = "productDescriptionDataGridViewTextBoxColumn";
            this.productDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.productDescriptionDataGridViewTextBoxColumn.Width = 179;
            // 
            // varietyDataGridViewTextBoxColumn
            // 
            this.varietyDataGridViewTextBoxColumn.DataPropertyName = "Variety";
            this.varietyDataGridViewTextBoxColumn.HeaderText = "Variety";
            this.varietyDataGridViewTextBoxColumn.Name = "varietyDataGridViewTextBoxColumn";
            this.varietyDataGridViewTextBoxColumn.ReadOnly = true;
            this.varietyDataGridViewTextBoxColumn.Width = 83;
            // 
            // restockLevelDataGridViewTextBoxColumn
            // 
            this.restockLevelDataGridViewTextBoxColumn.DataPropertyName = "Restock Level";
            this.restockLevelDataGridViewTextBoxColumn.HeaderText = "Restock Level";
            this.restockLevelDataGridViewTextBoxColumn.Name = "restockLevelDataGridViewTextBoxColumn";
            this.restockLevelDataGridViewTextBoxColumn.ReadOnly = true;
            this.restockLevelDataGridViewTextBoxColumn.Width = 133;
            // 
            // productCodeDataGridViewTextBoxColumn
            // 
            this.productCodeDataGridViewTextBoxColumn.DataPropertyName = "Product Code";
            this.productCodeDataGridViewTextBoxColumn.HeaderText = "Product Code";
            this.productCodeDataGridViewTextBoxColumn.Name = "productCodeDataGridViewTextBoxColumn";
            this.productCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.productCodeDataGridViewTextBoxColumn.Width = 134;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 69;
            // 
            // availableStockDataGridViewTextBoxColumn
            // 
            this.availableStockDataGridViewTextBoxColumn.DataPropertyName = "Available Stock";
            this.availableStockDataGridViewTextBoxColumn.HeaderText = "Available Stock";
            this.availableStockDataGridViewTextBoxColumn.Name = "availableStockDataGridViewTextBoxColumn";
            this.availableStockDataGridViewTextBoxColumn.ReadOnly = true;
            this.availableStockDataGridViewTextBoxColumn.Width = 144;
            // 
            // viewAvailableStocksBindingSource
            // 
            this.viewAvailableStocksBindingSource.DataMember = "viewAvailableStocks";
            this.viewAvailableStocksBindingSource.DataSource = this.dBSalesandInventoryDataSet1;
            // 
            // dBSalesandInventoryDataSet1
            // 
            this.dBSalesandInventoryDataSet1.DataSetName = "DBSalesandInventoryDataSet1";
            this.dBSalesandInventoryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewAvailableStocksTableAdapter
            // 
            this.viewAvailableStocksTableAdapter.ClearBeforeFill = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.color = System.Drawing.Color.IndianRed;
            this.btnClose.colorActive = System.Drawing.Color.IndianRed;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = null;
            this.btnClose.ImagePosition = 20;
            this.btnClose.ImageZoom = 50;
            this.btnClose.LabelPosition = 41;
            this.btnClose.LabelText = "x";
            this.btnClose.Location = new System.Drawing.Point(573, 7);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 42);
            this.btnClose.TabIndex = 3;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dBSalesandInventoryDataSet2
            // 
            this.dBSalesandInventoryDataSet2.DataSetName = "DBSalesandInventoryDataSet2";
            this.dBSalesandInventoryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lowstocksBindingSource
            // 
            this.lowstocksBindingSource.DataMember = "lowstocks";
            this.lowstocksBindingSource.DataSource = this.dBSalesandInventoryDataSet2;
            // 
            // lowstocksTableAdapter
            // 
            this.lowstocksTableAdapter.ClearBeforeFill = true;
            // 
            // lowStockNotif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(624, 351);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvLLS);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "lowStockNotif";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lowStockNotif";
            this.Load += new System.EventHandler(this.lowStockNotif_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLLS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAvailableStocksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSalesandInventoryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSalesandInventoryDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowstocksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvLLS;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private DBSalesandInventoryDataSet1 dBSalesandInventoryDataSet1;
        private System.Windows.Forms.BindingSource viewAvailableStocksBindingSource;
        private DBSalesandInventoryDataSet1TableAdapters.viewAvailableStocksTableAdapter viewAvailableStocksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varietyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn restockLevelDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuTileButton btnClose;
        private DBSalesandInventoryDataSet2 dBSalesandInventoryDataSet2;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource lowstocksBindingSource;
        private DBSalesandInventoryDataSet2TableAdapters.lowstocksTableAdapter lowstocksTableAdapter;
    }
}