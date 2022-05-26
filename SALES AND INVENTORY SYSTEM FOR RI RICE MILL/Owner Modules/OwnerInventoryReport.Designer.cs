
namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Owner_Modules
{
    partial class frmOwnerInventoryReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOwnerInventoryReport));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dgvInventoryOwnerReport = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtTotal = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtSearchItem = new Bunifu.UI.WinForms.BunifuTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryOwnerReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearchItem);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.bunifuLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(37, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 108);
            this.groupBox1.TabIndex = 119;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.btnSearch.Location = new System.Drawing.Point(543, 37);
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
            this.bunifuLabel1.Location = new System.Drawing.Point(21, 54);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(97, 18);
            this.bunifuLabel1.TabIndex = 116;
            this.bunifuLabel1.Text = "Search Item";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel1.Click += new System.EventHandler(this.bunifuLabel1_Click);
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel3.Location = new System.Drawing.Point(353, 12);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(287, 80);
            this.bunifuLabel3.TabIndex = 117;
            this.bunifuLabel3.Text = "Inventory\r\nReports Per Item\r\n";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel3.Click += new System.EventHandler(this.bunifuLabel3_Click);
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
            this.dgvInventoryOwnerReport.Location = new System.Drawing.Point(37, 216);
            this.dgvInventoryOwnerReport.Name = "dgvInventoryOwnerReport";
            this.dgvInventoryOwnerReport.ReadOnly = true;
            this.dgvInventoryOwnerReport.RowHeadersVisible = false;
            this.dgvInventoryOwnerReport.RowTemplate.Height = 40;
            this.dgvInventoryOwnerReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventoryOwnerReport.Size = new System.Drawing.Size(950, 263);
            this.dgvInventoryOwnerReport.TabIndex = 134;
            this.dgvInventoryOwnerReport.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvInventoryOwnerReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventoryOwnerReport_CellContentClick);
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowAnimations = true;
            this.bunifuButton1.AllowMouseEffects = true;
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.AutoRoundBorders = false;
            this.bunifuButton1.AutoSizeLeftIcon = true;
            this.bunifuButton1.AutoSizeRightIcon = true;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "Print Report";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges1;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.Empty;
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.Empty;
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton1.ForeColor = System.Drawing.Color.Black;
            this.bunifuButton1.IconLeft = null;
            this.bunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRight = null;
            this.bunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton1.IconSize = 25;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.Empty;
            this.bunifuButton1.IdleBorderRadius = 0;
            this.bunifuButton1.IdleBorderThickness = 0;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.Empty;
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(812, 139);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.OnDisabledState.BorderRadius = 1;
            this.bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnDisabledState.BorderThickness = 1;
            this.bunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.OnDisabledState.IconLeftImage = null;
            this.bunifuButton1.OnDisabledState.IconRightImage = null;
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.BorderRadius = 1;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.IconLeftImage = null;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.OnIdleState.BorderRadius = 1;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.bunifuButton1.OnIdleState.IconLeftImage = null;
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.BorderRadius = 1;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.IconLeftImage = null;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(158, 39);
            this.bunifuButton1.TabIndex = 135;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Properties.Resources.clipboard;
            this.pictureBox6.Location = new System.Drawing.Point(262, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(85, 69);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 120;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel4.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel4.Location = new System.Drawing.Point(670, 494);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(222, 18);
            this.bunifuLabel4.TabIndex = 136;
            this.bunifuLabel4.Text = "Overall Quantity Remaining:";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtTotal
            // 
            this.txtTotal.AllowParentOverrides = false;
            this.txtTotal.AutoEllipsis = false;
            this.txtTotal.CursorType = null;
            this.txtTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.Location = new System.Drawing.Point(933, 494);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotal.Size = new System.Drawing.Size(10, 18);
            this.txtTotal.TabIndex = 137;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.txtTotal.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.txtTotal.Click += new System.EventHandler(this.bunifuLabel5_Click);
            // 
            // txtSearchItem
            // 
            this.txtSearchItem.AcceptsReturn = false;
            this.txtSearchItem.AcceptsTab = false;
            this.txtSearchItem.AnimationSpeed = 200;
            this.txtSearchItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearchItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearchItem.AutoSizeHeight = true;
            this.txtSearchItem.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearchItem.BackgroundImage")));
            this.txtSearchItem.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtSearchItem.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSearchItem.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtSearchItem.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtSearchItem.BorderRadius = 5;
            this.txtSearchItem.BorderThickness = 1;
            this.txtSearchItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearchItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchItem.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtSearchItem.DefaultText = "";
            this.txtSearchItem.FillColor = System.Drawing.Color.White;
            this.txtSearchItem.HideSelection = true;
            this.txtSearchItem.IconLeft = null;
            this.txtSearchItem.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchItem.IconPadding = 10;
            this.txtSearchItem.IconRight = null;
            this.txtSearchItem.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchItem.Lines = new string[0];
            this.txtSearchItem.Location = new System.Drawing.Point(124, 48);
            this.txtSearchItem.MaxLength = 32767;
            this.txtSearchItem.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSearchItem.Modified = false;
            this.txtSearchItem.Multiline = false;
            this.txtSearchItem.Name = "txtSearchItem";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearchItem.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSearchItem.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearchItem.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearchItem.OnIdleState = stateProperties4;
            this.txtSearchItem.Padding = new System.Windows.Forms.Padding(3);
            this.txtSearchItem.PasswordChar = '\0';
            this.txtSearchItem.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtSearchItem.PlaceholderText = "Search Product Item Code / Description";
            this.txtSearchItem.ReadOnly = false;
            this.txtSearchItem.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchItem.SelectedText = "";
            this.txtSearchItem.SelectionLength = 0;
            this.txtSearchItem.SelectionStart = 0;
            this.txtSearchItem.ShortcutsEnabled = true;
            this.txtSearchItem.Size = new System.Drawing.Size(344, 39);
            this.txtSearchItem.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtSearchItem.TabIndex = 120;
            this.txtSearchItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchItem.TextMarginBottom = 0;
            this.txtSearchItem.TextMarginLeft = 3;
            this.txtSearchItem.TextMarginTop = 1;
            this.txtSearchItem.TextPlaceholder = "Search Product Item Code / Description";
            this.txtSearchItem.UseSystemPasswordChar = false;
            this.txtSearchItem.WordWrap = true;
            this.txtSearchItem.TextChange += new System.EventHandler(this.txtSearchItem_TextChange);
            this.txtSearchItem.TextChanged += new System.EventHandler(this.txtSearchItem_TextChanged);
            // 
            // frmOwnerInventoryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 547);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.dgvInventoryOwnerReport);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bunifuLabel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmOwnerInventoryReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmOwnerInventoryReport_Load);
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
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvInventoryOwnerReport;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuLabel txtTotal;
        private Bunifu.UI.WinForms.BunifuTextBox txtSearchItem;
    }
}