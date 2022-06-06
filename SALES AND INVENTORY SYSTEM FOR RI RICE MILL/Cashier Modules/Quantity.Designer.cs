
namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL
{
    partial class frmPLQuant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPLQuant));
            Kimtoo.ValidationProvider.ValidationObject validationObject1 = new Kimtoo.ValidationProvider.ValidationObject();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Kimtoo.ValidationProvider.ValidationObject validationObject2 = new Kimtoo.ValidationProvider.ValidationObject();
            Kimtoo.ValidationProvider.ValidationObject validationObject3 = new Kimtoo.ValidationProvider.ValidationObject();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Kimtoo.ValidationProvider.ValidationObject validationObject4 = new Kimtoo.ValidationProvider.ValidationObject();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Kimtoo.ValidationProvider.ValidationObject validationObject5 = new Kimtoo.ValidationProvider.ValidationObject();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Kimtoo.ValidationProvider.ValidationObject validationObject6 = new Kimtoo.ValidationProvider.ValidationObject();
            Kimtoo.ValidationProvider.ValidationObject validationObject7 = new Kimtoo.ValidationProvider.ValidationObject();
            this.txtQty = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnClose = new Bunifu.Framework.UI.BunifuTileButton();
            this.validationProvider1 = new Kimtoo.ValidationProvider.ValidationProvider();
            this.dgvSKUList = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.btnEnter = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnCancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSKUList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQty
            // 
            this.txtQty.AcceptsReturn = false;
            this.txtQty.AcceptsTab = false;
            this.txtQty.AnimationSpeed = 200;
            this.txtQty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtQty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtQty.AutoSizeHeight = true;
            this.txtQty.BackColor = System.Drawing.Color.Transparent;
            this.txtQty.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtQty.BackgroundImage")));
            this.txtQty.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtQty.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtQty.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtQty.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtQty.BorderRadius = 1;
            this.txtQty.BorderThickness = 1;
            this.txtQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQty.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtQty.DefaultText = "";
            this.txtQty.FillColor = System.Drawing.Color.White;
            this.txtQty.HideSelection = true;
            this.txtQty.IconLeft = null;
            this.txtQty.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQty.IconPadding = 10;
            this.txtQty.IconRight = null;
            this.txtQty.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQty.Lines = new string[0];
            validationObject1.CustomErrorMessage = "";
            validationObject1.Optional = false;
            validationObject1.PropertyName = "Text";
            validationObject1.Regex = null;
            validationObject1.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider1.SetLink(this.txtQty, validationObject1);
            this.txtQty.Location = new System.Drawing.Point(431, 79);
            this.txtQty.MaxLength = 4;
            this.txtQty.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtQty.Modified = false;
            this.txtQty.Multiline = false;
            this.txtQty.Name = "txtQty";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtQty.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtQty.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtQty.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtQty.OnIdleState = stateProperties4;
            this.txtQty.Padding = new System.Windows.Forms.Padding(3);
            this.txtQty.PasswordChar = '\0';
            this.txtQty.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtQty.PlaceholderText = "";
            this.txtQty.ReadOnly = false;
            this.txtQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQty.SelectedText = "";
            this.txtQty.SelectionLength = 0;
            this.txtQty.SelectionStart = 0;
            this.txtQty.ShortcutsEnabled = true;
            this.txtQty.Size = new System.Drawing.Size(198, 39);
            this.txtQty.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtQty.TabIndex = 0;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQty.TextMarginBottom = 0;
            this.txtQty.TextMarginLeft = 3;
            this.txtQty.TextMarginTop = 1;
            this.txtQty.TextPlaceholder = "";
            this.txtQty.UseSystemPasswordChar = false;
            this.txtQty.WordWrap = true;
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            validationObject2.CustomErrorMessage = "";
            validationObject2.Optional = false;
            validationObject2.PropertyName = "Text";
            validationObject2.Regex = null;
            validationObject2.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider1.SetLink(this.bunifuLabel1, validationObject2);
            this.bunifuLabel1.Location = new System.Drawing.Point(352, 90);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(73, 18);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Quantity:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Crimson;
            this.btnClose.color = System.Drawing.Color.RoyalBlue;
            this.btnClose.colorActive = System.Drawing.Color.IndianRed;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Image = null;
            this.btnClose.ImagePosition = 21;
            this.btnClose.ImageZoom = 50;
            this.btnClose.LabelPosition = 43;
            this.btnClose.LabelText = "x";
            validationObject3.CustomErrorMessage = "";
            validationObject3.Optional = false;
            validationObject3.PropertyName = "Text";
            validationObject3.Regex = null;
            validationObject3.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider1.SetLink(this.btnClose, validationObject3);
            this.btnClose.Location = new System.Drawing.Point(582, -5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(63, 56);
            this.btnClose.TabIndex = 49;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // validationProvider1
            // 
            this.validationProvider1.ErrorColor = System.Drawing.Color.Crimson;
            // 
            // dgvSKUList
            // 
            this.dgvSKUList.AllowCustomTheming = false;
            this.dgvSKUList.AllowUserToAddRows = false;
            this.dgvSKUList.AllowUserToDeleteRows = false;
            this.dgvSKUList.AllowUserToResizeColumns = false;
            this.dgvSKUList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvSKUList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSKUList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSKUList.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvSKUList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSKUList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSKUList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSKUList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSKUList.ColumnHeadersHeight = 40;
            this.dgvSKUList.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvSKUList.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvSKUList.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSKUList.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvSKUList.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSKUList.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvSKUList.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvSKUList.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvSKUList.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvSKUList.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSKUList.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvSKUList.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSKUList.CurrentTheme.Name = null;
            this.dgvSKUList.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSKUList.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvSKUList.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSKUList.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvSKUList.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSKUList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSKUList.EnableHeadersVisualStyles = false;
            this.dgvSKUList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvSKUList.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvSKUList.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvSKUList.HeaderForeColor = System.Drawing.Color.White;
            validationObject4.CustomErrorMessage = "";
            validationObject4.Optional = false;
            validationObject4.PropertyName = "Text";
            validationObject4.Regex = null;
            validationObject4.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider1.SetLink(this.dgvSKUList, validationObject4);
            this.dgvSKUList.Location = new System.Drawing.Point(8, 134);
            this.dgvSKUList.Name = "dgvSKUList";
            this.dgvSKUList.ReadOnly = true;
            this.dgvSKUList.RowHeadersVisible = false;
            this.dgvSKUList.RowTemplate.Height = 40;
            this.dgvSKUList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSKUList.Size = new System.Drawing.Size(625, 187);
            this.dgvSKUList.TabIndex = 50;
            this.dgvSKUList.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvSKUList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSKUList_CellClick);
            // 
            // btnEnter
            // 
            this.btnEnter.AllowAnimations = true;
            this.btnEnter.AllowMouseEffects = true;
            this.btnEnter.AllowToggling = false;
            this.btnEnter.AnimationSpeed = 200;
            this.btnEnter.AutoGenerateColors = false;
            this.btnEnter.AutoRoundBorders = false;
            this.btnEnter.AutoSizeLeftIcon = true;
            this.btnEnter.AutoSizeRightIcon = true;
            this.btnEnter.BackColor = System.Drawing.Color.Transparent;
            this.btnEnter.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnEnter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnter.BackgroundImage")));
            this.btnEnter.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEnter.ButtonText = "Enter";
            this.btnEnter.ButtonTextMarginLeft = 0;
            this.btnEnter.ColorContrastOnClick = 45;
            this.btnEnter.ColorContrastOnHover = 45;
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnEnter.CustomizableEdges = borderEdges1;
            this.btnEnter.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEnter.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEnter.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnEnter.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnEnter.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnEnter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.IconLeft = null;
            this.btnEnter.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnter.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnEnter.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnEnter.IconMarginLeft = 11;
            this.btnEnter.IconPadding = 10;
            this.btnEnter.IconRight = null;
            this.btnEnter.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnter.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnEnter.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnEnter.IconSize = 25;
            this.btnEnter.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnEnter.IdleBorderRadius = 0;
            this.btnEnter.IdleBorderThickness = 0;
            this.btnEnter.IdleFillColor = System.Drawing.Color.Empty;
            this.btnEnter.IdleIconLeftImage = null;
            this.btnEnter.IdleIconRightImage = null;
            this.btnEnter.IndicateFocus = false;
            validationObject5.CustomErrorMessage = "";
            validationObject5.Optional = false;
            validationObject5.PropertyName = "Text";
            validationObject5.Regex = null;
            validationObject5.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider1.SetLink(this.btnEnter, validationObject5);
            this.btnEnter.Location = new System.Drawing.Point(497, 327);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEnter.OnDisabledState.BorderRadius = 1;
            this.btnEnter.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEnter.OnDisabledState.BorderThickness = 1;
            this.btnEnter.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEnter.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEnter.OnDisabledState.IconLeftImage = null;
            this.btnEnter.OnDisabledState.IconRightImage = null;
            this.btnEnter.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnEnter.onHoverState.BorderRadius = 1;
            this.btnEnter.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEnter.onHoverState.BorderThickness = 1;
            this.btnEnter.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnEnter.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnEnter.onHoverState.IconLeftImage = null;
            this.btnEnter.onHoverState.IconRightImage = null;
            this.btnEnter.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnEnter.OnIdleState.BorderRadius = 1;
            this.btnEnter.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEnter.OnIdleState.BorderThickness = 1;
            this.btnEnter.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnEnter.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnEnter.OnIdleState.IconLeftImage = null;
            this.btnEnter.OnIdleState.IconRightImage = null;
            this.btnEnter.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnEnter.OnPressedState.BorderRadius = 1;
            this.btnEnter.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEnter.OnPressedState.BorderThickness = 1;
            this.btnEnter.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnEnter.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnEnter.OnPressedState.IconLeftImage = null;
            this.btnEnter.OnPressedState.IconRightImage = null;
            this.btnEnter.Size = new System.Drawing.Size(136, 39);
            this.btnEnter.TabIndex = 52;
            this.btnEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEnter.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEnter.TextMarginLeft = 0;
            this.btnEnter.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnEnter.UseDefaultRadiusAndThickness = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AllowAnimations = true;
            this.btnCancel.AllowMouseEffects = true;
            this.btnCancel.AllowToggling = false;
            this.btnCancel.AnimationSpeed = 200;
            this.btnCancel.AutoGenerateColors = false;
            this.btnCancel.AutoRoundBorders = false;
            this.btnCancel.AutoSizeLeftIcon = true;
            this.btnCancel.AutoSizeRightIcon = true;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.ButtonTextMarginLeft = 0;
            this.btnCancel.ColorContrastOnClick = 45;
            this.btnCancel.ColorContrastOnHover = 45;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnCancel.CustomizableEdges = borderEdges2;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCancel.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnCancel.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnCancel.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.IconLeft = null;
            this.btnCancel.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancel.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCancel.IconMarginLeft = 11;
            this.btnCancel.IconPadding = 10;
            this.btnCancel.IconRight = null;
            this.btnCancel.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancel.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCancel.IconSize = 25;
            this.btnCancel.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnCancel.IdleBorderRadius = 0;
            this.btnCancel.IdleBorderThickness = 0;
            this.btnCancel.IdleFillColor = System.Drawing.Color.Empty;
            this.btnCancel.IdleIconLeftImage = null;
            this.btnCancel.IdleIconRightImage = null;
            this.btnCancel.IndicateFocus = false;
            validationObject6.CustomErrorMessage = "";
            validationObject6.Optional = false;
            validationObject6.PropertyName = "Text";
            validationObject6.Regex = null;
            validationObject6.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider1.SetLink(this.btnCancel, validationObject6);
            this.btnCancel.Location = new System.Drawing.Point(351, 327);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCancel.OnDisabledState.BorderRadius = 1;
            this.btnCancel.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancel.OnDisabledState.BorderThickness = 1;
            this.btnCancel.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCancel.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCancel.OnDisabledState.IconLeftImage = null;
            this.btnCancel.OnDisabledState.IconRightImage = null;
            this.btnCancel.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnCancel.onHoverState.BorderRadius = 1;
            this.btnCancel.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancel.onHoverState.BorderThickness = 1;
            this.btnCancel.onHoverState.FillColor = System.Drawing.Color.White;
            this.btnCancel.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.onHoverState.IconLeftImage = null;
            this.btnCancel.onHoverState.IconRightImage = null;
            this.btnCancel.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.OnIdleState.BorderRadius = 1;
            this.btnCancel.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancel.OnIdleState.BorderThickness = 1;
            this.btnCancel.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btnCancel.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.OnIdleState.IconLeftImage = null;
            this.btnCancel.OnIdleState.IconRightImage = null;
            this.btnCancel.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCancel.OnPressedState.BorderRadius = 1;
            this.btnCancel.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancel.OnPressedState.BorderThickness = 1;
            this.btnCancel.OnPressedState.FillColor = System.Drawing.Color.White;
            this.btnCancel.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.OnPressedState.IconLeftImage = null;
            this.btnCancel.OnPressedState.IconRightImage = null;
            this.btnCancel.Size = new System.Drawing.Size(136, 39);
            this.btnCancel.TabIndex = 53;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancel.TextMarginLeft = 0;
            this.btnCancel.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCancel.UseDefaultRadiusAndThickness = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            validationObject7.CustomErrorMessage = "";
            validationObject7.Optional = false;
            validationObject7.PropertyName = "Text";
            validationObject7.Regex = null;
            validationObject7.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider1.SetLink(this.bunifuLabel2, validationObject7);
            this.bunifuLabel2.Location = new System.Drawing.Point(8, 110);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(68, 18);
            this.bunifuLabel2.TabIndex = 54;
            this.bunifuLabel2.Text = "SKU List";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // frmPLQuant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 388);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.dgvSKUList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.txtQty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPLQuant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Quantity";
            this.Load += new System.EventHandler(this.frmPLQuant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSKUList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        public Bunifu.UI.WinForms.BunifuTextBox txtQty;
        private Bunifu.Framework.UI.BunifuTileButton btnClose;
        private Kimtoo.ValidationProvider.ValidationProvider validationProvider1;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvSKUList;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnEnter;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCancel;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
    }
}