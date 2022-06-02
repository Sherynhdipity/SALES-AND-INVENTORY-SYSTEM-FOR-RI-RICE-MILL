
namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Inventory_Clerk_Modules
{
    partial class On_HandInventoryReports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(On_HandInventoryReports));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dgvInventoryOwnerReport = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblTotal = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnPrintReport = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtSearchInventory = new Bunifu.UI.WinForms.BunifuTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryOwnerReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearchInventory);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.bunifuLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(14, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 108);
            this.groupBox1.TabIndex = 123;
            this.groupBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.ActiveImage = null;
            this.btnSearch.AllowAnimations = true;
            this.btnSearch.AllowBuffering = false;
            this.btnSearch.AllowToggling = false;
            this.btnSearch.AllowZooming = false;
            this.btnSearch.AllowZoomingOnFocus = false;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.ErrorImage")));
            this.btnSearch.FadeWhenInactive = false;
            this.btnSearch.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnSearch.Image = global::SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Properties.Resources.search;
            this.btnSearch.ImageActive = null;
            this.btnSearch.ImageLocation = null;
            this.btnSearch.ImageMargin = 20;
            this.btnSearch.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSearch.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.btnSearch.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.InitialImage")));
            this.btnSearch.Location = new System.Drawing.Point(581, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Rotation = 0;
            this.btnSearch.ShowActiveImage = true;
            this.btnSearch.ShowCursorChanges = true;
            this.btnSearch.ShowImageBorders = true;
            this.btnSearch.ShowSizeMarkers = false;
            this.btnSearch.Size = new System.Drawing.Size(50, 50);
            this.btnSearch.TabIndex = 119;
            this.btnSearch.ToolTipText = "";
            this.btnSearch.WaitOnLoad = false;
            this.btnSearch.Zoom = 20;
            this.btnSearch.ZoomSpeed = 10;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel1.Location = new System.Drawing.Point(103, 54);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(102, 18);
            this.bunifuLabel1.TabIndex = 116;
            this.bunifuLabel1.Text = "Search Item:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel3.Location = new System.Drawing.Point(330, 12);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(330, 80);
            this.bunifuLabel3.TabIndex = 122;
            this.bunifuLabel3.Text = "Inventory Summary\r\nReports";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dgvInventoryOwnerReport
            // 
            this.dgvInventoryOwnerReport.AllowCustomTheming = false;
            this.dgvInventoryOwnerReport.AllowUserToAddRows = false;
            this.dgvInventoryOwnerReport.AllowUserToDeleteRows = false;
            this.dgvInventoryOwnerReport.AllowUserToResizeColumns = false;
            this.dgvInventoryOwnerReport.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvInventoryOwnerReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventoryOwnerReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventoryOwnerReport.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvInventoryOwnerReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventoryOwnerReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInventoryOwnerReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventoryOwnerReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventoryOwnerReport.ColumnHeadersHeight = 40;
            this.dgvInventoryOwnerReport.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvInventoryOwnerReport.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvInventoryOwnerReport.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvInventoryOwnerReport.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvInventoryOwnerReport.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvInventoryOwnerReport.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvInventoryOwnerReport.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvInventoryOwnerReport.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvInventoryOwnerReport.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvInventoryOwnerReport.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvInventoryOwnerReport.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvInventoryOwnerReport.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvInventoryOwnerReport.CurrentTheme.Name = null;
            this.dgvInventoryOwnerReport.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvInventoryOwnerReport.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvInventoryOwnerReport.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvInventoryOwnerReport.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvInventoryOwnerReport.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventoryOwnerReport.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInventoryOwnerReport.EnableHeadersVisualStyles = false;
            this.dgvInventoryOwnerReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvInventoryOwnerReport.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvInventoryOwnerReport.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvInventoryOwnerReport.HeaderForeColor = System.Drawing.Color.White;
            this.dgvInventoryOwnerReport.Location = new System.Drawing.Point(14, 205);
            this.dgvInventoryOwnerReport.Name = "dgvInventoryOwnerReport";
            this.dgvInventoryOwnerReport.ReadOnly = true;
            this.dgvInventoryOwnerReport.RowHeadersVisible = false;
            this.dgvInventoryOwnerReport.RowTemplate.Height = 40;
            this.dgvInventoryOwnerReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventoryOwnerReport.Size = new System.Drawing.Size(926, 299);
            this.dgvInventoryOwnerReport.TabIndex = 132;
            this.dgvInventoryOwnerReport.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvInventoryOwnerReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventoryOwnerReport_CellContentClick);
            this.dgvInventoryOwnerReport.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvInventoryOwnerReport_Scroll);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel2.Location = new System.Drawing.Point(638, 507);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(154, 18);
            this.bunifuLabel2.TabIndex = 134;
            this.bunifuLabel2.Text = "Total Remain Stock";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblTotal
            // 
            this.lblTotal.AllowParentOverrides = false;
            this.lblTotal.AutoEllipsis = false;
            this.lblTotal.CursorType = null;
            this.lblTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(848, 507);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotal.Size = new System.Drawing.Size(10, 18);
            this.lblTotal.TabIndex = 135;
            this.lblTotal.Text = "0";
            this.lblTotal.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTotal.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Properties.Resources.clipboard;
            this.pictureBox6.Location = new System.Drawing.Point(239, 7);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(85, 69);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 124;
            this.pictureBox6.TabStop = false;
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.AllowAnimations = true;
            this.btnPrintReport.AllowMouseEffects = true;
            this.btnPrintReport.AllowToggling = false;
            this.btnPrintReport.AnimationSpeed = 200;
            this.btnPrintReport.AutoGenerateColors = false;
            this.btnPrintReport.AutoRoundBorders = false;
            this.btnPrintReport.AutoSizeLeftIcon = true;
            this.btnPrintReport.AutoSizeRightIcon = true;
            this.btnPrintReport.BackColor = System.Drawing.Color.Transparent;
            this.btnPrintReport.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnPrintReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrintReport.BackgroundImage")));
            this.btnPrintReport.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrintReport.ButtonText = "Print Report";
            this.btnPrintReport.ButtonTextMarginLeft = 0;
            this.btnPrintReport.ColorContrastOnClick = 45;
            this.btnPrintReport.ColorContrastOnHover = 45;
            this.btnPrintReport.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnPrintReport.CustomizableEdges = borderEdges1;
            this.btnPrintReport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrintReport.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPrintReport.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnPrintReport.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnPrintReport.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnPrintReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReport.ForeColor = System.Drawing.Color.Black;
            this.btnPrintReport.IconLeft = null;
            this.btnPrintReport.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintReport.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPrintReport.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnPrintReport.IconMarginLeft = 11;
            this.btnPrintReport.IconPadding = 10;
            this.btnPrintReport.IconRight = null;
            this.btnPrintReport.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintReport.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPrintReport.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPrintReport.IconSize = 25;
            this.btnPrintReport.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnPrintReport.IdleBorderRadius = 0;
            this.btnPrintReport.IdleBorderThickness = 0;
            this.btnPrintReport.IdleFillColor = System.Drawing.Color.Empty;
            this.btnPrintReport.IdleIconLeftImage = null;
            this.btnPrintReport.IdleIconRightImage = null;
            this.btnPrintReport.IndicateFocus = false;
            this.btnPrintReport.Location = new System.Drawing.Point(768, 124);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPrintReport.OnDisabledState.BorderRadius = 1;
            this.btnPrintReport.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrintReport.OnDisabledState.BorderThickness = 1;
            this.btnPrintReport.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPrintReport.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPrintReport.OnDisabledState.IconLeftImage = null;
            this.btnPrintReport.OnDisabledState.IconRightImage = null;
            this.btnPrintReport.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnPrintReport.onHoverState.BorderRadius = 1;
            this.btnPrintReport.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrintReport.onHoverState.BorderThickness = 1;
            this.btnPrintReport.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnPrintReport.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnPrintReport.onHoverState.IconLeftImage = null;
            this.btnPrintReport.onHoverState.IconRightImage = null;
            this.btnPrintReport.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPrintReport.OnIdleState.BorderRadius = 1;
            this.btnPrintReport.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrintReport.OnIdleState.BorderThickness = 1;
            this.btnPrintReport.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnPrintReport.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnPrintReport.OnIdleState.IconLeftImage = null;
            this.btnPrintReport.OnIdleState.IconRightImage = null;
            this.btnPrintReport.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnPrintReport.OnPressedState.BorderRadius = 1;
            this.btnPrintReport.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrintReport.OnPressedState.BorderThickness = 1;
            this.btnPrintReport.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnPrintReport.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnPrintReport.OnPressedState.IconLeftImage = null;
            this.btnPrintReport.OnPressedState.IconRightImage = null;
            this.btnPrintReport.Size = new System.Drawing.Size(158, 39);
            this.btnPrintReport.TabIndex = 133;
            this.btnPrintReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrintReport.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPrintReport.TextMarginLeft = 0;
            this.btnPrintReport.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnPrintReport.UseDefaultRadiusAndThickness = true;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // txtSearchInventory
            // 
            this.txtSearchInventory.AcceptsReturn = false;
            this.txtSearchInventory.AcceptsTab = false;
            this.txtSearchInventory.AnimationSpeed = 200;
            this.txtSearchInventory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearchInventory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearchInventory.AutoSizeHeight = true;
            this.txtSearchInventory.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchInventory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearchInventory.BackgroundImage")));
            this.txtSearchInventory.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtSearchInventory.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSearchInventory.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtSearchInventory.BorderColorIdle = System.Drawing.Color.Black;
            this.txtSearchInventory.BorderRadius = 20;
            this.txtSearchInventory.BorderThickness = 1;
            this.txtSearchInventory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearchInventory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchInventory.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtSearchInventory.DefaultText = "";
            this.txtSearchInventory.FillColor = System.Drawing.Color.White;
            this.txtSearchInventory.HideSelection = true;
            this.txtSearchInventory.IconLeft = null;
            this.txtSearchInventory.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchInventory.IconPadding = 10;
            this.txtSearchInventory.IconRight = null;
            this.txtSearchInventory.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchInventory.Lines = new string[0];
            this.txtSearchInventory.Location = new System.Drawing.Point(211, 44);
            this.txtSearchInventory.MaxLength = 32767;
            this.txtSearchInventory.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSearchInventory.Modified = false;
            this.txtSearchInventory.Multiline = false;
            this.txtSearchInventory.Name = "txtSearchInventory";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearchInventory.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSearchInventory.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearchInventory.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Black;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearchInventory.OnIdleState = stateProperties4;
            this.txtSearchInventory.Padding = new System.Windows.Forms.Padding(3);
            this.txtSearchInventory.PasswordChar = '\0';
            this.txtSearchInventory.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSearchInventory.PlaceholderText = "Search..";
            this.txtSearchInventory.ReadOnly = false;
            this.txtSearchInventory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchInventory.SelectedText = "";
            this.txtSearchInventory.SelectionLength = 0;
            this.txtSearchInventory.SelectionStart = 0;
            this.txtSearchInventory.ShortcutsEnabled = true;
            this.txtSearchInventory.Size = new System.Drawing.Size(349, 39);
            this.txtSearchInventory.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtSearchInventory.TabIndex = 121;
            this.txtSearchInventory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchInventory.TextMarginBottom = 0;
            this.txtSearchInventory.TextMarginLeft = 3;
            this.txtSearchInventory.TextMarginTop = 1;
            this.txtSearchInventory.TextPlaceholder = "Search..";
            this.txtSearchInventory.UseSystemPasswordChar = false;
            this.txtSearchInventory.WordWrap = true;
            this.txtSearchInventory.TextChanged += new System.EventHandler(this.txtSearchInventory_TextChanged);
            // 
            // On_HandInventoryReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 529);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.dgvInventoryOwnerReport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.bunifuLabel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "On_HandInventoryReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.On_HandInventoryReports_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryOwnerReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.UI.WinForms.BunifuImageButton btnSearch;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvInventoryOwnerReport;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel lblTotal;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPrintReport;
        private Bunifu.UI.WinForms.BunifuTextBox txtSearchInventory;
    }
}