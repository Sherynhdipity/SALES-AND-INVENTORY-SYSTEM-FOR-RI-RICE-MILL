
namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL
{
    partial class frmSearchTransNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchTransNo));
            Kimtoo.ValidationProvider.ValidationObject validationObject1 = new Kimtoo.ValidationProvider.ValidationObject();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Kimtoo.ValidationProvider.ValidationObject validationObject2 = new Kimtoo.ValidationProvider.ValidationObject();
            Kimtoo.ValidationProvider.ValidationObject validationObject3 = new Kimtoo.ValidationProvider.ValidationObject();
            this.txtQty = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnClose = new Bunifu.Framework.UI.BunifuTileButton();
            this.validationProvider1 = new Kimtoo.ValidationProvider.ValidationProvider();
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
            this.txtQty.Location = new System.Drawing.Point(65, 94);
            this.txtQty.MaxLength = 50;
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
            this.txtQty.Size = new System.Drawing.Size(245, 39);
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
            this.bunifuLabel1.Location = new System.Drawing.Point(27, 59);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(168, 18);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Transaction Number:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.color = System.Drawing.Color.RoyalBlue;
            this.btnClose.colorActive = System.Drawing.Color.IndianRed;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Image = null;
            this.btnClose.ImagePosition = 21;
            this.btnClose.ImageZoom = 50;
            this.btnClose.LabelPosition = 43;
            this.btnClose.LabelText = "X";
            validationObject3.CustomErrorMessage = "";
            validationObject3.Optional = false;
            validationObject3.PropertyName = "Text";
            validationObject3.Regex = null;
            validationObject3.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider1.SetLink(this.btnClose, validationObject3);
            this.btnClose.Location = new System.Drawing.Point(305, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(63, 61);
            this.btnClose.TabIndex = 49;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // validationProvider1
            // 
            this.validationProvider1.ErrorColor = System.Drawing.Color.Crimson;
            // 
            // frmSearchTransNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 182);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.txtQty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSearchTransNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Quantity";
            this.Load += new System.EventHandler(this.frmSearchTransNo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        public Bunifu.UI.WinForms.BunifuTextBox txtQty;
        private Bunifu.Framework.UI.BunifuTileButton btnClose;
        private Kimtoo.ValidationProvider.ValidationProvider validationProvider1;
    }
}