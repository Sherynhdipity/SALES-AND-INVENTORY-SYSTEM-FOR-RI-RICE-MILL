
namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL
{
    partial class frmInventory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dgvStockList = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.btnUpdate = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnAddStock = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnRefresh = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockList)).BeginInit();
            this.bunifuPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel2.Location = new System.Drawing.Point(26, 43);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(446, 46);
            this.bunifuLabel2.TabIndex = 44;
            this.bunifuLabel2.Text = "Inventory Management";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.bunifuPanel1.BorderRadius = 10;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.bunifuLabel5);
            this.bunifuPanel1.Controls.Add(this.dgvStockList);
            this.bunifuPanel1.Location = new System.Drawing.Point(26, 223);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = false;
            this.bunifuPanel1.Size = new System.Drawing.Size(1037, 429);
            this.bunifuPanel1.TabIndex = 8;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.bunifuLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel5.Location = new System.Drawing.Point(13, 8);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(109, 18);
            this.bunifuLabel5.TabIndex = 0;
            this.bunifuLabel5.Text = "Inventory List";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dgvStockList
            // 
            this.dgvStockList.AllowCustomTheming = false;
            this.dgvStockList.AllowUserToAddRows = false;
            this.dgvStockList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvStockList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStockList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStockList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStockList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStockList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStockList.ColumnHeadersHeight = 40;
            this.dgvStockList.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvStockList.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvStockList.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvStockList.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvStockList.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvStockList.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvStockList.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvStockList.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvStockList.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvStockList.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvStockList.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvStockList.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvStockList.CurrentTheme.Name = null;
            this.dgvStockList.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStockList.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvStockList.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvStockList.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvStockList.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStockList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStockList.EnableHeadersVisualStyles = false;
            this.dgvStockList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvStockList.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvStockList.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvStockList.HeaderForeColor = System.Drawing.Color.White;
            this.dgvStockList.Location = new System.Drawing.Point(16, 32);
            this.dgvStockList.Name = "dgvStockList";
            this.dgvStockList.ReadOnly = true;
            this.dgvStockList.RowHeadersVisible = false;
            this.dgvStockList.RowTemplate.Height = 40;
            this.dgvStockList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStockList.Size = new System.Drawing.Size(996, 379);
            this.dgvStockList.TabIndex = 4;
            this.dgvStockList.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AllowAnimations = true;
            this.btnUpdate.AllowMouseEffects = true;
            this.btnUpdate.AllowToggling = false;
            this.btnUpdate.AnimationSpeed = 200;
            this.btnUpdate.AutoGenerateColors = false;
            this.btnUpdate.AutoRoundBorders = false;
            this.btnUpdate.AutoSizeLeftIcon = true;
            this.btnUpdate.AutoSizeRightIcon = true;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUpdate.ButtonText = "Update Stocks";
            this.btnUpdate.ButtonTextMarginLeft = 0;
            this.btnUpdate.ColorContrastOnClick = 45;
            this.btnUpdate.ColorContrastOnHover = 45;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnUpdate.CustomizableEdges = borderEdges1;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdate.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnUpdate.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnUpdate.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnUpdate.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.IconLeft = null;
            this.btnUpdate.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnUpdate.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnUpdate.IconMarginLeft = 11;
            this.btnUpdate.IconPadding = 10;
            this.btnUpdate.IconRight = null;
            this.btnUpdate.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnUpdate.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnUpdate.IconSize = 25;
            this.btnUpdate.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnUpdate.IdleBorderRadius = 0;
            this.btnUpdate.IdleBorderThickness = 0;
            this.btnUpdate.IdleFillColor = System.Drawing.Color.Empty;
            this.btnUpdate.IdleIconLeftImage = null;
            this.btnUpdate.IdleIconRightImage = null;
            this.btnUpdate.IndicateFocus = false;
            this.btnUpdate.Location = new System.Drawing.Point(196, 16);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnUpdate.OnDisabledState.BorderRadius = 1;
            this.btnUpdate.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUpdate.OnDisabledState.BorderThickness = 1;
            this.btnUpdate.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnUpdate.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnUpdate.OnDisabledState.IconLeftImage = null;
            this.btnUpdate.OnDisabledState.IconRightImage = null;
            this.btnUpdate.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnUpdate.onHoverState.BorderRadius = 1;
            this.btnUpdate.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUpdate.onHoverState.BorderThickness = 1;
            this.btnUpdate.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnUpdate.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.onHoverState.IconLeftImage = null;
            this.btnUpdate.onHoverState.IconRightImage = null;
            this.btnUpdate.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.OnIdleState.BorderRadius = 1;
            this.btnUpdate.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUpdate.OnIdleState.BorderThickness = 1;
            this.btnUpdate.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.OnIdleState.IconLeftImage = null;
            this.btnUpdate.OnIdleState.IconRightImage = null;
            this.btnUpdate.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnUpdate.OnPressedState.BorderRadius = 1;
            this.btnUpdate.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUpdate.OnPressedState.BorderThickness = 1;
            this.btnUpdate.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnUpdate.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnPressedState.IconLeftImage = null;
            this.btnUpdate.OnPressedState.IconRightImage = null;
            this.btnUpdate.Size = new System.Drawing.Size(150, 39);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdate.TextMarginLeft = 0;
            this.btnUpdate.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnUpdate.UseDefaultRadiusAndThickness = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddStock
            // 
            this.btnAddStock.AllowAnimations = true;
            this.btnAddStock.AllowMouseEffects = true;
            this.btnAddStock.AllowToggling = false;
            this.btnAddStock.AnimationSpeed = 200;
            this.btnAddStock.AutoGenerateColors = false;
            this.btnAddStock.AutoRoundBorders = false;
            this.btnAddStock.AutoSizeLeftIcon = true;
            this.btnAddStock.AutoSizeRightIcon = true;
            this.btnAddStock.BackColor = System.Drawing.Color.Transparent;
            this.btnAddStock.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAddStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddStock.BackgroundImage")));
            this.btnAddStock.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddStock.ButtonText = "Add Stock";
            this.btnAddStock.ButtonTextMarginLeft = 0;
            this.btnAddStock.ColorContrastOnClick = 45;
            this.btnAddStock.ColorContrastOnHover = 45;
            this.btnAddStock.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnAddStock.CustomizableEdges = borderEdges2;
            this.btnAddStock.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddStock.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddStock.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnAddStock.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnAddStock.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddStock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStock.ForeColor = System.Drawing.Color.Black;
            this.btnAddStock.IconLeft = null;
            this.btnAddStock.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStock.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddStock.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddStock.IconMarginLeft = 11;
            this.btnAddStock.IconPadding = 10;
            this.btnAddStock.IconRight = null;
            this.btnAddStock.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddStock.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddStock.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddStock.IconSize = 25;
            this.btnAddStock.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnAddStock.IdleBorderRadius = 0;
            this.btnAddStock.IdleBorderThickness = 0;
            this.btnAddStock.IdleFillColor = System.Drawing.Color.Empty;
            this.btnAddStock.IdleIconLeftImage = null;
            this.btnAddStock.IdleIconRightImage = null;
            this.btnAddStock.IndicateFocus = false;
            this.btnAddStock.Location = new System.Drawing.Point(29, 16);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddStock.OnDisabledState.BorderRadius = 1;
            this.btnAddStock.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddStock.OnDisabledState.BorderThickness = 1;
            this.btnAddStock.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddStock.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddStock.OnDisabledState.IconLeftImage = null;
            this.btnAddStock.OnDisabledState.IconRightImage = null;
            this.btnAddStock.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnAddStock.onHoverState.BorderRadius = 1;
            this.btnAddStock.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddStock.onHoverState.BorderThickness = 1;
            this.btnAddStock.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnAddStock.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddStock.onHoverState.IconLeftImage = null;
            this.btnAddStock.onHoverState.IconRightImage = null;
            this.btnAddStock.OnIdleState.BorderColor = System.Drawing.Color.Orange;
            this.btnAddStock.OnIdleState.BorderRadius = 1;
            this.btnAddStock.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddStock.OnIdleState.BorderThickness = 1;
            this.btnAddStock.OnIdleState.FillColor = System.Drawing.Color.Orange;
            this.btnAddStock.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnAddStock.OnIdleState.IconLeftImage = null;
            this.btnAddStock.OnIdleState.IconRightImage = null;
            this.btnAddStock.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddStock.OnPressedState.BorderRadius = 1;
            this.btnAddStock.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddStock.OnPressedState.BorderThickness = 1;
            this.btnAddStock.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddStock.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddStock.OnPressedState.IconLeftImage = null;
            this.btnAddStock.OnPressedState.IconRightImage = null;
            this.btnAddStock.Size = new System.Drawing.Size(150, 39);
            this.btnAddStock.TabIndex = 9;
            this.btnAddStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddStock.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddStock.TextMarginLeft = 0;
            this.btnAddStock.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddStock.UseDefaultRadiusAndThickness = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 10;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.btnRefresh);
            this.bunifuPanel2.Controls.Add(this.btnUpdate);
            this.bunifuPanel2.Controls.Add(this.btnAddStock);
            this.bunifuPanel2.Location = new System.Drawing.Point(26, 133);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(431, 70);
            this.bunifuPanel2.TabIndex = 45;
            // 
            // btnRefresh
            // 
            this.btnRefresh.ActiveImage = null;
            this.btnRefresh.AllowAnimations = true;
            this.btnRefresh.AllowBuffering = false;
            this.btnRefresh.AllowToggling = false;
            this.btnRefresh.AllowZooming = false;
            this.btnRefresh.AllowZoomingOnFocus = false;
            this.btnRefresh.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRefresh.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ErrorImage")));
            this.btnRefresh.FadeWhenInactive = false;
            this.btnRefresh.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnRefresh.Image = global::SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Properties.Resources.reload;
            this.btnRefresh.ImageActive = null;
            this.btnRefresh.ImageLocation = null;
            this.btnRefresh.ImageMargin = 20;
            this.btnRefresh.ImageSize = new System.Drawing.Size(22, 19);
            this.btnRefresh.ImageZoomSize = new System.Drawing.Size(42, 39);
            this.btnRefresh.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.InitialImage")));
            this.btnRefresh.Location = new System.Drawing.Point(371, 16);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Rotation = 0;
            this.btnRefresh.ShowActiveImage = true;
            this.btnRefresh.ShowCursorChanges = true;
            this.btnRefresh.ShowImageBorders = true;
            this.btnRefresh.ShowSizeMarkers = false;
            this.btnRefresh.Size = new System.Drawing.Size(42, 39);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.ToolTipText = "";
            this.btnRefresh.WaitOnLoad = false;
            this.btnRefresh.Zoom = 20;
            this.btnRefresh.ZoomSpeed = 10;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "frmInventory";
            this.Size = new System.Drawing.Size(1087, 675);
            this.Load += new System.EventHandler(this.frmInventory_Load);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockList)).EndInit();
            this.bunifuPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvStockList;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddStock;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnUpdate;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuImageButton btnRefresh;
    }
}
