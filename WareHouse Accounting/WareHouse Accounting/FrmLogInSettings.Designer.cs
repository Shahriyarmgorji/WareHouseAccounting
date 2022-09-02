namespace WareHouse_Accounting
{
    partial class FrmLogInSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogInSettings));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.LblCurrentPassword = new DevComponents.DotNetBar.LabelX();
            this.LblNewPassword = new DevComponents.DotNetBar.LabelX();
            this.LblConfirmNewPassword = new DevComponents.DotNetBar.LabelX();
            this.TxtCurrentPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtNewPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtConfirmPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.BtnExit = new DevComponents.DotNetBar.ButtonX();
            this.BtnSave = new DevComponents.DotNetBar.ButtonX();
            this.LblNote = new DevComponents.DotNetBar.LabelX();
            this.panelEx1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.groupPanel3);
            this.panelEx1.Controls.Add(this.groupPanel2);
            this.panelEx1.Controls.Add(this.groupPanel1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(395, 312);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.LblNote);
            this.groupPanel1.Controls.Add(this.TxtCurrentPassword);
            this.groupPanel1.Controls.Add(this.LblCurrentPassword);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(12, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(376, 120);
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
            this.groupPanel1.Text = "Authentication";
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.BtnExit);
            this.groupPanel2.Controls.Add(this.BtnSave);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(12, 251);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(376, 53);
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
            this.groupPanel2.TabIndex = 2;
            // 
            // groupPanel3
            // 
            this.groupPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.TxtConfirmPassword);
            this.groupPanel3.Controls.Add(this.TxtNewPassword);
            this.groupPanel3.Controls.Add(this.LblConfirmNewPassword);
            this.groupPanel3.Controls.Add(this.LblNewPassword);
            this.groupPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel3.Location = new System.Drawing.Point(12, 138);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(376, 107);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel3.TabIndex = 1;
            this.groupPanel3.Text = "Change User Settings";
            // 
            // LblCurrentPassword
            // 
            // 
            // 
            // 
            this.LblCurrentPassword.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LblCurrentPassword.Location = new System.Drawing.Point(17, 3);
            this.LblCurrentPassword.Name = "LblCurrentPassword";
            this.LblCurrentPassword.Size = new System.Drawing.Size(140, 23);
            this.LblCurrentPassword.TabIndex = 0;
            this.LblCurrentPassword.Text = "Current Password";
            // 
            // LblNewPassword
            // 
            // 
            // 
            // 
            this.LblNewPassword.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LblNewPassword.Location = new System.Drawing.Point(17, 3);
            this.LblNewPassword.Name = "LblNewPassword";
            this.LblNewPassword.Size = new System.Drawing.Size(166, 23);
            this.LblNewPassword.TabIndex = 2;
            this.LblNewPassword.Text = "New Password";
            // 
            // LblConfirmNewPassword
            // 
            // 
            // 
            // 
            this.LblConfirmNewPassword.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LblConfirmNewPassword.Location = new System.Drawing.Point(17, 48);
            this.LblConfirmNewPassword.Name = "LblConfirmNewPassword";
            this.LblConfirmNewPassword.Size = new System.Drawing.Size(166, 23);
            this.LblConfirmNewPassword.TabIndex = 2;
            this.LblConfirmNewPassword.Text = "Confirm New Password";
            // 
            // TxtCurrentPassword
            // 
            this.TxtCurrentPassword.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TxtCurrentPassword.Border.Class = "TextBoxBorder";
            this.TxtCurrentPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtCurrentPassword.DisabledBackColor = System.Drawing.Color.White;
            this.TxtCurrentPassword.FocusHighlightColor = System.Drawing.Color.Gainsboro;
            this.TxtCurrentPassword.FocusHighlightEnabled = true;
            this.TxtCurrentPassword.ForeColor = System.Drawing.Color.Black;
            this.TxtCurrentPassword.Location = new System.Drawing.Point(189, 4);
            this.TxtCurrentPassword.Name = "TxtCurrentPassword";
            this.TxtCurrentPassword.PreventEnterBeep = true;
            this.TxtCurrentPassword.Size = new System.Drawing.Size(175, 26);
            this.TxtCurrentPassword.TabIndex = 0;
            this.TxtCurrentPassword.UseSystemPasswordChar = true;
            this.TxtCurrentPassword.WatermarkText = "Enter Current Password";
            // 
            // TxtNewPassword
            // 
            this.TxtNewPassword.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TxtNewPassword.Border.Class = "TextBoxBorder";
            this.TxtNewPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtNewPassword.DisabledBackColor = System.Drawing.Color.White;
            this.TxtNewPassword.FocusHighlightColor = System.Drawing.Color.Gainsboro;
            this.TxtNewPassword.FocusHighlightEnabled = true;
            this.TxtNewPassword.ForeColor = System.Drawing.Color.Black;
            this.TxtNewPassword.Location = new System.Drawing.Point(189, 4);
            this.TxtNewPassword.Name = "TxtNewPassword";
            this.TxtNewPassword.PreventEnterBeep = true;
            this.TxtNewPassword.Size = new System.Drawing.Size(175, 26);
            this.TxtNewPassword.TabIndex = 0;
            this.TxtNewPassword.UseSystemPasswordChar = true;
            this.TxtNewPassword.WatermarkText = "Enter New Password";
            // 
            // TxtConfirmPassword
            // 
            this.TxtConfirmPassword.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TxtConfirmPassword.Border.Class = "TextBoxBorder";
            this.TxtConfirmPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtConfirmPassword.DisabledBackColor = System.Drawing.Color.White;
            this.TxtConfirmPassword.FocusHighlightColor = System.Drawing.Color.Gainsboro;
            this.TxtConfirmPassword.FocusHighlightEnabled = true;
            this.TxtConfirmPassword.ForeColor = System.Drawing.Color.Black;
            this.TxtConfirmPassword.Location = new System.Drawing.Point(189, 45);
            this.TxtConfirmPassword.Name = "TxtConfirmPassword";
            this.TxtConfirmPassword.PreventEnterBeep = true;
            this.TxtConfirmPassword.Size = new System.Drawing.Size(175, 26);
            this.TxtConfirmPassword.TabIndex = 1;
            this.TxtConfirmPassword.UseSystemPasswordChar = true;
            this.TxtConfirmPassword.WatermarkText = "Confirm New Password";
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
            this.BtnExit.TabIndex = 0;
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
            this.BtnSave.Location = new System.Drawing.Point(273, 3);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnSave.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5);
            this.BtnSave.Size = new System.Drawing.Size(91, 36);
            this.BtnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "Save";
            // 
            // LblNote
            // 
            // 
            // 
            // 
            this.LblNote.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LblNote.ForeColor = System.Drawing.Color.DarkBlue;
            this.LblNote.Location = new System.Drawing.Point(3, 37);
            this.LblNote.Name = "LblNote";
            this.LblNote.Size = new System.Drawing.Size(361, 49);
            this.LblNote.TabIndex = 1;
            this.LblNote.Text = "*** In Case of Authentication, the Change User Setting Box will be Actived ***";
            this.LblNote.TextAlignment = System.Drawing.StringAlignment.Center;
            this.LblNote.WordWrap = true;
            // 
            // FrmLogInSettings
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnExit;
            this.ClientSize = new System.Drawing.Size(395, 312);
            this.ControlBox = false;
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmLogInSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelEx1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.LabelX LblConfirmNewPassword;
        private DevComponents.DotNetBar.LabelX LblNewPassword;
        private DevComponents.DotNetBar.LabelX LblCurrentPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtCurrentPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtConfirmPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtNewPassword;
        private DevComponents.DotNetBar.ButtonX BtnExit;
        private DevComponents.DotNetBar.ButtonX BtnSave;
        private DevComponents.DotNetBar.LabelX LblNote;
    }
}