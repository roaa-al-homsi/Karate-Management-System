namespace KarateSystem.Users
{
    partial class frmAddUpdateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateUser));
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.tcAddUser = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.uc_PersonInfoWithFilter1 = new KarateSystem.People.uc_Controls.uc_PersonInfoWithFilter();
            this.tpUserInfo = new System.Windows.Forms.TabPage();
            this.panelContainerUserInfo = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.chkIsActive = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.picUser = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.labUserId = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labUser = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcAddUser.SuspendLayout();
            this.tpPersonInfo.SuspendLayout();
            this.tpUserInfo.SuspendLayout();
            this.panelContainerUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BorderRadius = 21;
            this.btnSave.CheckedState.CustomBorderColor = System.Drawing.Color.HotPink;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.Black;
            this.btnSave.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.CustomBorderColor = System.Drawing.Color.HotPink;
            this.btnSave.Location = new System.Drawing.Point(262, 675);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 45);
            this.btnSave.TabIndex = 126;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoRoundedCorners = true;
            this.btnCancel.BorderRadius = 21;
            this.btnCancel.CheckedState.CustomBorderColor = System.Drawing.Color.HotPink;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.Black;
            this.btnCancel.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.CustomBorderColor = System.Drawing.Color.HotPink;
            this.btnCancel.Location = new System.Drawing.Point(443, 675);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 45);
            this.btnCancel.TabIndex = 127;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tcAddUser
            // 
            this.tcAddUser.Controls.Add(this.tpPersonInfo);
            this.tcAddUser.Controls.Add(this.tpUserInfo);
            this.tcAddUser.ItemSize = new System.Drawing.Size(180, 40);
            this.tcAddUser.Location = new System.Drawing.Point(12, 12);
            this.tcAddUser.Name = "tcAddUser";
            this.tcAddUser.SelectedIndex = 0;
            this.tcAddUser.Size = new System.Drawing.Size(847, 642);
            this.tcAddUser.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcAddUser.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcAddUser.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcAddUser.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcAddUser.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcAddUser.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcAddUser.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcAddUser.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcAddUser.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tcAddUser.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcAddUser.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcAddUser.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tcAddUser.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcAddUser.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcAddUser.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tcAddUser.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tcAddUser.TabIndex = 128;
            this.tcAddUser.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcAddUser.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpPersonInfo
            // 
            this.tpPersonInfo.Controls.Add(this.btnNext);
            this.tpPersonInfo.Controls.Add(this.uc_PersonInfoWithFilter1);
            this.tpPersonInfo.Location = new System.Drawing.Point(4, 44);
            this.tpPersonInfo.Name = "tpPersonInfo";
            this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonInfo.Size = new System.Drawing.Size(839, 594);
            this.tpPersonInfo.TabIndex = 0;
            this.tpPersonInfo.Text = "Person";
            this.tpPersonInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.AutoRoundedCorners = true;
            this.btnNext.BorderRadius = 21;
            this.btnNext.CheckedState.CustomBorderColor = System.Drawing.Color.HotPink;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.Black;
            this.btnNext.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.HoverState.CustomBorderColor = System.Drawing.Color.HotPink;
            this.btnNext.Location = new System.Drawing.Point(733, 546);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 45);
            this.btnNext.TabIndex = 129;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // uc_PersonInfoWithFilter1
            // 
            this.uc_PersonInfoWithFilter1.FilterEnable = true;
            this.uc_PersonInfoWithFilter1.Location = new System.Drawing.Point(6, 33);
            this.uc_PersonInfoWithFilter1.Name = "uc_PersonInfoWithFilter1";
            this.uc_PersonInfoWithFilter1.ShowAddPerson = true;
            this.uc_PersonInfoWithFilter1.Size = new System.Drawing.Size(729, 528);
            this.uc_PersonInfoWithFilter1.TabIndex = 0;
            // 
            // tpUserInfo
            // 
            this.tpUserInfo.Controls.Add(this.panelContainerUserInfo);
            this.tpUserInfo.Location = new System.Drawing.Point(4, 44);
            this.tpUserInfo.Name = "tpUserInfo";
            this.tpUserInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpUserInfo.Size = new System.Drawing.Size(839, 594);
            this.tpUserInfo.TabIndex = 1;
            this.tpUserInfo.Text = "User";
            this.tpUserInfo.UseVisualStyleBackColor = true;
            // 
            // panelContainerUserInfo
            // 
            this.panelContainerUserInfo.Controls.Add(this.guna2HtmlLabel4);
            this.panelContainerUserInfo.Controls.Add(this.chkIsActive);
            this.panelContainerUserInfo.Controls.Add(this.txtConfirmPassword);
            this.panelContainerUserInfo.Controls.Add(this.guna2HtmlLabel1);
            this.panelContainerUserInfo.Controls.Add(this.txtPassword);
            this.panelContainerUserInfo.Controls.Add(this.guna2HtmlLabel2);
            this.panelContainerUserInfo.Controls.Add(this.picUser);
            this.panelContainerUserInfo.Controls.Add(this.labUserId);
            this.panelContainerUserInfo.Controls.Add(this.txtUserName);
            this.panelContainerUserInfo.Controls.Add(this.guna2HtmlLabel9);
            this.panelContainerUserInfo.Controls.Add(this.labUser);
            this.panelContainerUserInfo.FillColor = System.Drawing.Color.AliceBlue;
            this.panelContainerUserInfo.Location = new System.Drawing.Point(182, 22);
            this.panelContainerUserInfo.Name = "panelContainerUserInfo";
            this.panelContainerUserInfo.Size = new System.Drawing.Size(512, 520);
            this.panelContainerUserInfo.TabIndex = 151;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(47, 424);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(109, 36);
            this.guna2HtmlLabel4.TabIndex = 168;
            this.guna2HtmlLabel4.Text = "Is Active: ";
            // 
            // chkIsActive
            // 
            this.chkIsActive.BackColor = System.Drawing.Color.Transparent;
            this.chkIsActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkIsActive.CheckedState.BorderRadius = 2;
            this.chkIsActive.CheckedState.BorderThickness = 0;
            this.chkIsActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkIsActive.Location = new System.Drawing.Point(274, 439);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(31, 21);
            this.chkIsActive.TabIndex = 167;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkIsActive.UncheckedState.BorderRadius = 2;
            this.chkIsActive.UncheckedState.BorderThickness = 0;
            this.chkIsActive.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkIsActive.UseTransparentBackground = true;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Animated = true;
            this.txtConfirmPassword.AutoRoundedCorners = true;
            this.txtConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtConfirmPassword.BorderRadius = 17;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.DefaultText = "";
            this.txtConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.Black;
            this.txtConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.Location = new System.Drawing.Point(274, 383);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '●';
            this.txtConfirmPassword.PlaceholderText = "";
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.Size = new System.Drawing.Size(200, 36);
            this.txtConfirmPassword.TabIndex = 166;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(47, 378);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(196, 36);
            this.guna2HtmlLabel1.TabIndex = 165;
            this.guna2HtmlLabel1.Text = " Confirm Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Animated = true;
            this.txtPassword.AutoRoundedCorners = true;
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BorderRadius = 17;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(274, 321);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(200, 36);
            this.txtPassword.TabIndex = 159;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(47, 317);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(146, 36);
            this.guna2HtmlLabel2.TabIndex = 158;
            this.guna2HtmlLabel2.Text = "Password:";
            // 
            // picUser
            // 
            this.picUser.BackColor = System.Drawing.Color.Transparent;
            this.picUser.FillColor = System.Drawing.Color.DimGray;
            this.picUser.Image = ((System.Drawing.Image)(resources.GetObject("picUser.Image")));
            this.picUser.ImageRotate = 0F;
            this.picUser.Location = new System.Drawing.Point(130, 5);
            this.picUser.Name = "picUser";
            this.picUser.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picUser.Size = new System.Drawing.Size(217, 200);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 157;
            this.picUser.TabStop = false;
            // 
            // labUserId
            // 
            this.labUserId.AutoSize = false;
            this.labUserId.BackColor = System.Drawing.Color.Transparent;
            this.labUserId.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUserId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labUserId.Location = new System.Drawing.Point(293, 211);
            this.labUserId.Name = "labUserId";
            this.labUserId.Size = new System.Drawing.Size(95, 32);
            this.labUserId.TabIndex = 146;
            this.labUserId.Text = "??";
            this.labUserId.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.labUserId.Visible = false;
            // 
            // txtUserName
            // 
            this.txtUserName.Animated = true;
            this.txtUserName.AutoRoundedCorners = true;
            this.txtUserName.BackColor = System.Drawing.Color.Transparent;
            this.txtUserName.BorderRadius = 17;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Location = new System.Drawing.Point(274, 256);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PlaceholderText = "";
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(200, 36);
            this.txtUserName.TabIndex = 152;
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.AutoSize = false;
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(47, 256);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(146, 36);
            this.guna2HtmlLabel9.TabIndex = 151;
            this.guna2HtmlLabel9.Text = "UserName:";
            // 
            // labUser
            // 
            this.labUser.AutoSize = false;
            this.labUser.BackColor = System.Drawing.Color.Transparent;
            this.labUser.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labUser.Location = new System.Drawing.Point(130, 211);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(157, 32);
            this.labUser.TabIndex = 154;
            this.labUser.Text = "User Id:";
            this.labUser.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 735);
            this.Controls.Add(this.tcAddUser);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddUpdateUser";
            this.Load += new System.EventHandler(this.frmAddUpdateUser_Load);
            this.tcAddUser.ResumeLayout(false);
            this.tpPersonInfo.ResumeLayout(false);
            this.tpUserInfo.ResumeLayout(false);
            this.panelContainerUserInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2TabControl tcAddUser;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private System.Windows.Forms.TabPage tpUserInfo;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private People.uc_Controls.uc_PersonInfoWithFilter uc_PersonInfoWithFilter1;
        private Guna.UI2.WinForms.Guna2GradientPanel panelContainerUserInfo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2CustomCheckBox chkIsActive;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picUser;
        private Guna.UI2.WinForms.Guna2HtmlLabel labUserId;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel labUser;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}