namespace WareHouse_Accounting
{
    partial class FrmAddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddUser));
            this.EPAddUser = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.BtnExit = new DevComponents.DotNetBar.ButtonX();
            this.BtnSave = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.TxtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.BsAddUser = new System.Windows.Forms.BindingSource(this.components);
            this.TxtUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LblPassword = new DevComponents.DotNetBar.LabelX();
            this.LblUserName = new DevComponents.DotNetBar.LabelX();
            this.LblAddRoles = new DevComponents.DotNetBar.LabelX();
            this.CBAddRole = new System.Windows.Forms.ComboBox();
            this.BsRoles = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EPAddUser)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsAddUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // EPAddUser
            // 
            this.EPAddUser.ContainerControl = this;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.groupPanel2);
            this.panelEx1.Controls.Add(this.groupPanel1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(335, 264);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.BtnExit);
            this.groupPanel2.Controls.Add(this.BtnSave);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(12, 202);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(310, 54);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 1;
            // 
            // BtnExit
            // 
            this.BtnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnExit.FocusCuesEnabled = false;
            this.BtnExit.Image = global::WareHouse_Accounting.Properties.Resources.Cancel;
            this.BtnExit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.BtnExit.Location = new System.Drawing.Point(3, 3);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnExit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5);
            this.BtnExit.Size = new System.Drawing.Size(100, 36);
            this.BtnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "Exit";
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnSave.FocusCuesEnabled = false;
            this.BtnSave.Image = global::WareHouse_Accounting.Properties.Resources.Save1;
            this.BtnSave.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.BtnSave.Location = new System.Drawing.Point(205, 3);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnSave.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5);
            this.BtnSave.Size = new System.Drawing.Size(91, 36);
            this.BtnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.CBAddRole);
            this.groupPanel1.Controls.Add(this.TxtPassword);
            this.groupPanel1.Controls.Add(this.TxtUserName);
            this.groupPanel1.Controls.Add(this.LblPassword);
            this.groupPanel1.Controls.Add(this.LblUserName);
            this.groupPanel1.Controls.Add(this.LblAddRoles);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(12, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(310, 184);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "Add Users";
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TxtPassword.Border.Class = "TextBoxBorder";
            this.TxtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsAddUser, "Password", true));
            this.TxtPassword.DisabledBackColor = System.Drawing.Color.White;
            this.TxtPassword.FocusHighlightColor = System.Drawing.Color.Gainsboro;
            this.TxtPassword.FocusHighlightEnabled = true;
            this.TxtPassword.ForeColor = System.Drawing.Color.Black;
            this.TxtPassword.Location = new System.Drawing.Point(97, 120);
            this.TxtPassword.MaxLength = 50;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.PreventEnterBeep = true;
            this.TxtPassword.Size = new System.Drawing.Size(199, 26);
            this.TxtPassword.TabIndex = 2;
            this.TxtPassword.UseSystemPasswordChar = true;
            this.TxtPassword.WatermarkText = "Enter PassWord";
            // 
            // BsAddUser
            // 
            this.BsAddUser.DataSource = typeof(WareHouse_Accounting.User);
            // 
            // TxtUserName
            // 
            this.TxtUserName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TxtUserName.Border.Class = "TextBoxBorder";
            this.TxtUserName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsAddUser, "UserName", true));
            this.TxtUserName.DisabledBackColor = System.Drawing.Color.White;
            this.TxtUserName.FocusHighlightColor = System.Drawing.Color.Gainsboro;
            this.TxtUserName.FocusHighlightEnabled = true;
            this.TxtUserName.ForeColor = System.Drawing.Color.Black;
            this.TxtUserName.Location = new System.Drawing.Point(97, 67);
            this.TxtUserName.MaxLength = 50;
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.PreventEnterBeep = true;
            this.TxtUserName.Size = new System.Drawing.Size(199, 26);
            this.TxtUserName.TabIndex = 1;
            this.TxtUserName.WatermarkText = "Enter UserName";
            // 
            // LblPassword
            // 
            // 
            // 
            // 
            this.LblPassword.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LblPassword.Location = new System.Drawing.Point(3, 120);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(115, 23);
            this.LblPassword.TabIndex = 2;
            this.LblPassword.Text = "Password";
            // 
            // LblUserName
            // 
            // 
            // 
            // 
            this.LblUserName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LblUserName.Location = new System.Drawing.Point(3, 70);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(115, 23);
            this.LblUserName.TabIndex = 1;
            this.LblUserName.Text = "UserName";
            // 
            // LblAddRoles
            // 
            // 
            // 
            // 
            this.LblAddRoles.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LblAddRoles.Location = new System.Drawing.Point(3, 24);
            this.LblAddRoles.Name = "LblAddRoles";
            this.LblAddRoles.Size = new System.Drawing.Size(115, 23);
            this.LblAddRoles.TabIndex = 0;
            this.LblAddRoles.Text = "Add Roles";
            // 
            // CBAddRole
            // 
            this.CBAddRole.BackColor = System.Drawing.Color.LightGray;
            this.CBAddRole.DataSource = this.BsRoles;
            this.CBAddRole.DisplayMember = "RoleName";
            this.CBAddRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBAddRole.FormattingEnabled = true;
            this.CBAddRole.Location = new System.Drawing.Point(97, 24);
            this.CBAddRole.Name = "CBAddRole";
            this.CBAddRole.Size = new System.Drawing.Size(199, 26);
            this.CBAddRole.TabIndex = 12;
            this.CBAddRole.ValueMember = "Role_Id";
            // 
            // BsRoles
            // 
            this.BsRoles.DataSource = typeof(WareHouse_Accounting.Role);
            // 
            // FrmAddUser
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnExit;
            this.ClientSize = new System.Drawing.Size(335, 264);
            this.ControlBox = false;
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAddUser_FormClosed);
            this.Load += new System.EventHandler(this.FrmAddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EPAddUser)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BsAddUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsRoles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource BsAddUser;
        private System.Windows.Forms.ErrorProvider EPAddUser;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.LabelX LblPassword;
        private DevComponents.DotNetBar.LabelX LblUserName;
        private DevComponents.DotNetBar.LabelX LblAddRoles;
        private DevComponents.DotNetBar.ButtonX BtnExit;
        private DevComponents.DotNetBar.ButtonX BtnSave;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtUserName;
        private System.Windows.Forms.ComboBox CBAddRole;
        private System.Windows.Forms.BindingSource BsRoles;
    }
}