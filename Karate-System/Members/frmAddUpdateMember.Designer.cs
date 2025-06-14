namespace KarateSystem.Members
{
    partial class frmAddUpdateMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateMember));
            this.labTitleForm = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelContainerMemberInfo = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.chkIsActive = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.txtContactInfo = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtLastBeltRankId = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.picMember = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.labMemberId = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labMember = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tpMemberInfo = new System.Windows.Forms.TabPage();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.uc_PersonInfoWithFilter1 = new KarateSystem.People.uc_Controls.uc_PersonInfoWithFilter();
            this.tcMember = new Guna.UI2.WinForms.Guna2TabControl();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelContainerMemberInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMember)).BeginInit();
            this.tpMemberInfo.SuspendLayout();
            this.tpPersonInfo.SuspendLayout();
            this.tcMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // labTitleForm
            // 
            this.labTitleForm.AutoSize = false;
            this.labTitleForm.BackColor = System.Drawing.Color.Transparent;
            this.labTitleForm.Font = new System.Drawing.Font("Andalus", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitleForm.ForeColor = System.Drawing.Color.Maroon;
            this.labTitleForm.Location = new System.Drawing.Point(262, 12);
            this.labTitleForm.Name = "labTitleForm";
            this.labTitleForm.Size = new System.Drawing.Size(379, 44);
            this.labTitleForm.TabIndex = 17;
            this.labTitleForm.Text = "Add a Member";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(64, 425);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(109, 36);
            this.guna2HtmlLabel4.TabIndex = 168;
            this.guna2HtmlLabel4.Text = "Is Active: ";
            // 
            // panelContainerMemberInfo
            // 
            this.panelContainerMemberInfo.BorderColor = System.Drawing.Color.White;
            this.panelContainerMemberInfo.Controls.Add(this.guna2HtmlLabel4);
            this.panelContainerMemberInfo.Controls.Add(this.chkIsActive);
            this.panelContainerMemberInfo.Controls.Add(this.txtContactInfo);
            this.panelContainerMemberInfo.Controls.Add(this.guna2HtmlLabel1);
            this.panelContainerMemberInfo.Controls.Add(this.txtLastBeltRankId);
            this.panelContainerMemberInfo.Controls.Add(this.guna2HtmlLabel2);
            this.panelContainerMemberInfo.Controls.Add(this.picMember);
            this.panelContainerMemberInfo.Controls.Add(this.labMemberId);
            this.panelContainerMemberInfo.Controls.Add(this.labMember);
            this.panelContainerMemberInfo.FillColor = System.Drawing.Color.White;
            this.panelContainerMemberInfo.Location = new System.Drawing.Point(182, 3);
            this.panelContainerMemberInfo.Name = "panelContainerMemberInfo";
            this.panelContainerMemberInfo.Size = new System.Drawing.Size(512, 588);
            this.panelContainerMemberInfo.TabIndex = 151;
            // 
            // chkIsActive
            // 
            this.chkIsActive.BackColor = System.Drawing.Color.Transparent;
            this.chkIsActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkIsActive.CheckedState.BorderRadius = 2;
            this.chkIsActive.CheckedState.BorderThickness = 0;
            this.chkIsActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkIsActive.Location = new System.Drawing.Point(291, 440);
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
            // txtContactInfo
            // 
            this.txtContactInfo.Animated = true;
            this.txtContactInfo.AutoRoundedCorners = true;
            this.txtContactInfo.BackColor = System.Drawing.Color.Transparent;
            this.txtContactInfo.BorderRadius = 17;
            this.txtContactInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContactInfo.DefaultText = "";
            this.txtContactInfo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContactInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContactInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContactInfo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContactInfo.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtContactInfo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContactInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtContactInfo.ForeColor = System.Drawing.Color.Black;
            this.txtContactInfo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContactInfo.Location = new System.Drawing.Point(291, 384);
            this.txtContactInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContactInfo.Name = "txtContactInfo";
            this.txtContactInfo.PlaceholderText = "";
            this.txtContactInfo.SelectedText = "";
            this.txtContactInfo.Size = new System.Drawing.Size(200, 36);
            this.txtContactInfo.TabIndex = 166;
            this.txtContactInfo.Validating += new System.ComponentModel.CancelEventHandler(this._ValidateEmptyTextBox);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(64, 379);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(196, 36);
            this.guna2HtmlLabel1.TabIndex = 165;
            this.guna2HtmlLabel1.Text = "Emergency Contact:";
            // 
            // txtLastBeltRankId
            // 
            this.txtLastBeltRankId.Animated = true;
            this.txtLastBeltRankId.AutoRoundedCorners = true;
            this.txtLastBeltRankId.BackColor = System.Drawing.Color.Transparent;
            this.txtLastBeltRankId.BorderRadius = 17;
            this.txtLastBeltRankId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastBeltRankId.DefaultText = "";
            this.txtLastBeltRankId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLastBeltRankId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLastBeltRankId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastBeltRankId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastBeltRankId.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtLastBeltRankId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastBeltRankId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLastBeltRankId.ForeColor = System.Drawing.Color.Black;
            this.txtLastBeltRankId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastBeltRankId.Location = new System.Drawing.Point(291, 322);
            this.txtLastBeltRankId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastBeltRankId.Name = "txtLastBeltRankId";
            this.txtLastBeltRankId.PlaceholderText = "";
            this.txtLastBeltRankId.SelectedText = "";
            this.txtLastBeltRankId.Size = new System.Drawing.Size(200, 36);
            this.txtLastBeltRankId.TabIndex = 159;
            this.txtLastBeltRankId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastBeltRankId_KeyPress);
            this.txtLastBeltRankId.Validating += new System.ComponentModel.CancelEventHandler(this._ValidateEmptyTextBox);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(64, 318);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(179, 36);
            this.guna2HtmlLabel2.TabIndex = 158;
            this.guna2HtmlLabel2.Text = "Last Belt Rank Id:";
            // 
            // picMember
            // 
            this.picMember.BackColor = System.Drawing.Color.Transparent;
            this.picMember.FillColor = System.Drawing.Color.DimGray;
            this.picMember.Image = ((System.Drawing.Image)(resources.GetObject("picMember.Image")));
            this.picMember.ImageRotate = 0F;
            this.picMember.Location = new System.Drawing.Point(130, 5);
            this.picMember.Name = "picMember";
            this.picMember.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picMember.Size = new System.Drawing.Size(217, 200);
            this.picMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMember.TabIndex = 157;
            this.picMember.TabStop = false;
            // 
            // labMemberId
            // 
            this.labMemberId.AutoSize = false;
            this.labMemberId.BackColor = System.Drawing.Color.Transparent;
            this.labMemberId.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMemberId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labMemberId.Location = new System.Drawing.Point(280, 263);
            this.labMemberId.Name = "labMemberId";
            this.labMemberId.Size = new System.Drawing.Size(95, 32);
            this.labMemberId.TabIndex = 146;
            this.labMemberId.Text = "??";
            this.labMemberId.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labMember
            // 
            this.labMember.AutoSize = false;
            this.labMember.BackColor = System.Drawing.Color.Transparent;
            this.labMember.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMember.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labMember.Location = new System.Drawing.Point(117, 263);
            this.labMember.Name = "labMember";
            this.labMember.Size = new System.Drawing.Size(157, 32);
            this.labMember.TabIndex = 154;
            this.labMember.Text = "Member Id:";
            // 
            // tpMemberInfo
            // 
            this.tpMemberInfo.Controls.Add(this.panelContainerMemberInfo);
            this.tpMemberInfo.Location = new System.Drawing.Point(4, 44);
            this.tpMemberInfo.Name = "tpMemberInfo";
            this.tpMemberInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpMemberInfo.Size = new System.Drawing.Size(839, 600);
            this.tpMemberInfo.TabIndex = 1;
            this.tpMemberInfo.Text = "Member";
            this.tpMemberInfo.UseVisualStyleBackColor = true;
            // 
            // tpPersonInfo
            // 
            this.tpPersonInfo.Controls.Add(this.btnNext);
            this.tpPersonInfo.Controls.Add(this.uc_PersonInfoWithFilter1);
            this.tpPersonInfo.Location = new System.Drawing.Point(4, 44);
            this.tpPersonInfo.Name = "tpPersonInfo";
            this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonInfo.Size = new System.Drawing.Size(839, 600);
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
            this.btnNext.Location = new System.Drawing.Point(344, 543);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 45);
            this.btnNext.TabIndex = 129;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // uc_PersonInfoWithFilter1
            // 
            this.uc_PersonInfoWithFilter1.FilterEnable = true;
            this.uc_PersonInfoWithFilter1.Location = new System.Drawing.Point(42, 0);
            this.uc_PersonInfoWithFilter1.Name = "uc_PersonInfoWithFilter1";
            this.uc_PersonInfoWithFilter1.ShowAddPerson = true;
            this.uc_PersonInfoWithFilter1.Size = new System.Drawing.Size(729, 528);
            this.uc_PersonInfoWithFilter1.TabIndex = 0;
            // 
            // tcMember
            // 
            this.tcMember.Controls.Add(this.tpPersonInfo);
            this.tcMember.Controls.Add(this.tpMemberInfo);
            this.tcMember.ItemSize = new System.Drawing.Size(180, 40);
            this.tcMember.Location = new System.Drawing.Point(12, 62);
            this.tcMember.Name = "tcMember";
            this.tcMember.SelectedIndex = 0;
            this.tcMember.Size = new System.Drawing.Size(847, 648);
            this.tcMember.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcMember.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcMember.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcMember.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcMember.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcMember.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcMember.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcMember.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcMember.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tcMember.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcMember.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcMember.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tcMember.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcMember.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcMember.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tcMember.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tcMember.TabIndex = 131;
            this.tcMember.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcMember.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
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
            this.btnCancel.Location = new System.Drawing.Point(443, 716);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 45);
            this.btnCancel.TabIndex = 130;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnSave.Location = new System.Drawing.Point(262, 716);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 45);
            this.btnSave.TabIndex = 129;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddUpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 773);
            this.Controls.Add(this.tcMember);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labTitleForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUpdateMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Update Member";
            this.Load += new System.EventHandler(this.frmAddUpdateMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panelContainerMemberInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMember)).EndInit();
            this.tpMemberInfo.ResumeLayout(false);
            this.tpPersonInfo.ResumeLayout(false);
            this.tcMember.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel labTitleForm;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2TabControl tcMember;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private People.uc_Controls.uc_PersonInfoWithFilter uc_PersonInfoWithFilter1;
        private System.Windows.Forms.TabPage tpMemberInfo;
        private Guna.UI2.WinForms.Guna2GradientPanel panelContainerMemberInfo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2CustomCheckBox chkIsActive;
        private Guna.UI2.WinForms.Guna2TextBox txtContactInfo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtLastBeltRankId;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picMember;
        private Guna.UI2.WinForms.Guna2HtmlLabel labMemberId;
        private Guna.UI2.WinForms.Guna2HtmlLabel labMember;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
    }
}