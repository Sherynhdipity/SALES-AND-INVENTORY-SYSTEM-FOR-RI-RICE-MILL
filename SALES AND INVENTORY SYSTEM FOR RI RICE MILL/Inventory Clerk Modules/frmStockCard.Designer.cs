namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Inventory_Clerk_Modules
{
    partial class frmStockCard
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
            this.dtvStockCard = new System.Windows.Forms.DataGridView();
            this.dtStockCard = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtvStockCard)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvStockCard
            // 
            this.dtvStockCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvStockCard.Location = new System.Drawing.Point(28, 49);
            this.dtvStockCard.Name = "dtvStockCard";
            this.dtvStockCard.Size = new System.Drawing.Size(825, 377);
            this.dtvStockCard.TabIndex = 0;
            
            // 
            // dtStockCard
            // 
            this.dtStockCard.Location = new System.Drawing.Point(290, 12);
            this.dtStockCard.Name = "dtStockCard";
            this.dtStockCard.Size = new System.Drawing.Size(200, 20);
            this.dtStockCard.TabIndex = 1;
            // 
            // frmStockCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 450);
            this.Controls.Add(this.dtStockCard);
            this.Controls.Add(this.dtvStockCard);
            this.Name = "frmStockCard";
            this.Text = "frmStockCard";
            this.Load += new System.EventHandler(this.frmStockCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvStockCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvStockCard;
        private System.Windows.Forms.DateTimePicker dtStockCard;
    }
}