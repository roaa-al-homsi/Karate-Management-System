namespace KarateSystem.Members_Instructors.uc
{
    partial class uc_MemberInstructorInfoCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_MemberInstructorInfoCard));
            this.tcMemberInstructor = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpMember = new System.Windows.Forms.TabPage();
            this.tpInstructor = new System.Windows.Forms.TabPage();
            this.panelLoginInfo = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.linkLabEditMemberInstructor = new System.Windows.Forms.LinkLabel();
            this.dtpAssignDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtMemberInstructorId = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.uc_MemberInfoCard1 = new KarateSystem.Members.uc.uc_MemberInfoCard();
            this.uc_InstructorInfoCard1 = new KarateSystem.Instructors.uc.uc_InstructorInfoCard();
            this.tcMemberInstructor.SuspendLayout();
            this.tpMember.SuspendLayout();
            this.tpInstructor.SuspendLayout();
            this.panelLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMemberInstructor
            // 
            this.tcMemberInstructor.Controls.Add(this.tpMember);
            this.tcMemberInstructor.Controls.Add(this.tpInstructor);
            this.tcMemberInstructor.ItemSize = new System.Drawing.Size(180, 40);
            this.tcMemberInstructor.Location = new System.Drawing.Point(3, 3);
            this.tcMemberInstructor.Name = "tcMemberInstructor";
            this.tcMemberInstructor.SelectedIndex = 0;
            this.tcMemberInstructor.Size = new System.Drawing.Size(735, 657);
            this.tcMemberInstructor.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcMemberInstructor.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcMemberInstructor.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcMemberInstructor.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcMemberInstructor.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcMemberInstructor.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcMemberInstructor.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcMemberInstructor.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcMemberInstructor.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tcMemberInstructor.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcMemberInstructor.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcMemberInstructor.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tcMemberInstructor.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcMemberInstructor.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcMemberInstructor.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tcMemberInstructor.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tcMemberInstructor.TabIndex = 4;
            this.tcMemberInstructor.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcMemberInstructor.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpMember
            // 
            this.tpMember.Controls.Add(this.uc_MemberInfoCard1);
            this.tpMember.Location = new System.Drawing.Point(4, 44);
            this.tpMember.Name = "tpMember";
            this.tpMember.Padding = new System.Windows.Forms.Padding(3);
            this.tpMember.Size = new System.Drawing.Size(727, 609);
            this.tpMember.TabIndex = 0;
            this.tpMember.Text = "Member";
            this.tpMember.UseVisualStyleBackColor = true;
            // 
            // tpInstructor
            // 
            this.tpInstructor.Controls.Add(this.uc_InstructorInfoCard1);
            this.tpInstructor.Location = new System.Drawing.Point(4, 44);
            this.tpInstructor.Name = "tpInstructor";
            this.tpInstructor.Padding = new System.Windows.Forms.Padding(3);
            this.tpInstructor.Size = new System.Drawing.Size(727, 609);
            this.tpInstructor.TabIndex = 1;
            this.tpInstructor.Text = "Instructor";
            this.tpInstructor.UseVisualStyleBackColor = true;
            // 
            // panelLoginInfo
            // 
            this.panelLoginInfo.BorderColor = System.Drawing.Color.Black;
            this.panelLoginInfo.BorderThickness = 1;
            this.panelLoginInfo.Controls.Add(this.linkLabEditMemberInstructor);
            this.panelLoginInfo.Controls.Add(this.dtpAssignDate);
            this.panelLoginInfo.Controls.Add(this.guna2PictureBox2);
            this.panelLoginInfo.Controls.Add(this.guna2PictureBox1);
            this.panelLoginInfo.Controls.Add(this.txtMemberInstructorId);
            this.panelLoginInfo.Controls.Add(this.guna2HtmlLabel2);
            this.panelLoginInfo.Controls.Add(this.guna2HtmlLabel1);
            this.panelLoginInfo.Location = new System.Drawing.Point(7, 666);
            this.panelLoginInfo.Name = "panelLoginInfo";
            this.panelLoginInfo.Size = new System.Drawing.Size(727, 109);
            this.panelLoginInfo.TabIndex = 139;
            // 
            // linkLabEditMemberInstructor
            // 
            this.linkLabEditMemberInstructor.AutoSize = true;
            this.linkLabEditMemberInstructor.BackColor = System.Drawing.Color.Transparent;
            this.linkLabEditMemberInstructor.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.linkLabEditMemberInstructor.Font = new System.Drawing.Font("Aldhabi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabEditMemberInstructor.Location = new System.Drawing.Point(488, 10);
            this.linkLabEditMemberInstructor.Name = "linkLabEditMemberInstructor";
            this.linkLabEditMemberInstructor.Size = new System.Drawing.Size(215, 35);
            this.linkLabEditMemberInstructor.TabIndex = 40;
            this.linkLabEditMemberInstructor.TabStop = true;
            this.linkLabEditMemberInstructor.Text = "Edit Member-Instructor Info";
            this.linkLabEditMemberInstructor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabEditMemberInstructor_LinkClicked);
            // 
            // dtpAssignDate
            // 
            this.dtpAssignDate.AutoRoundedCorners = true;
            this.dtpAssignDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpAssignDate.Checked = true;
            this.dtpAssignDate.Enabled = false;
            this.dtpAssignDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtpAssignDate.Font = new System.Drawing.Font("Andalus", 10.2F);
            this.dtpAssignDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpAssignDate.Location = new System.Drawing.Point(199, 57);
            this.dtpAssignDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpAssignDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpAssignDate.Name = "dtpAssignDate";
            this.dtpAssignDate.Size = new System.Drawing.Size(200, 36);
            this.dtpAssignDate.TabIndex = 12;
            this.dtpAssignDate.UseTransparentBackground = true;
            this.dtpAssignDate.Value = new System.DateTime(2025, 6, 18, 17, 49, 23, 364);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(26, 57);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(32, 36);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 11;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(26, 9);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(32, 36);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // txtMemberInstructorId
            // 
            this.txtMemberInstructorId.AutoRoundedCorners = true;
            this.txtMemberInstructorId.BackColor = System.Drawing.Color.Transparent;
            this.txtMemberInstructorId.BorderColor = System.Drawing.Color.Transparent;
            this.txtMemberInstructorId.BorderRadius = 16;
            this.txtMemberInstructorId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMemberInstructorId.DefaultText = "";
            this.txtMemberInstructorId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMemberInstructorId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMemberInstructorId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMemberInstructorId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMemberInstructorId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMemberInstructorId.Font = new System.Drawing.Font("Andalus", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberInstructorId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtMemberInstructorId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMemberInstructorId.Location = new System.Drawing.Point(314, 15);
            this.txtMemberInstructorId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMemberInstructorId.Name = "txtMemberInstructorId";
            this.txtMemberInstructorId.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.txtMemberInstructorId.PlaceholderText = "";
            this.txtMemberInstructorId.ReadOnly = true;
            this.txtMemberInstructorId.SelectedText = "";
            this.txtMemberInstructorId.Size = new System.Drawing.Size(85, 34);
            this.txtMemberInstructorId.TabIndex = 6;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(64, 57);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(170, 30);
            this.guna2HtmlLabel2.TabIndex = 1;
            this.guna2HtmlLabel2.Text = "Assign Date:";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(64, 21);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(196, 30);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Member-Instructor Id:";
            // 
            // uc_MemberInfoCard1
            // 
            this.uc_MemberInfoCard1.Location = new System.Drawing.Point(0, 0);
            this.uc_MemberInfoCard1.MemberId = -1;
            this.uc_MemberInfoCard1.Name = "uc_MemberInfoCard1";
            this.uc_MemberInfoCard1.Size = new System.Drawing.Size(727, 602);
            this.uc_MemberInfoCard1.TabIndex = 0;
            // 
            // uc_InstructorInfoCard1
            // 
            this.uc_InstructorInfoCard1.InstructorId = 0;
            this.uc_InstructorInfoCard1.Location = new System.Drawing.Point(0, 0);
            this.uc_InstructorInfoCard1.Name = "uc_InstructorInfoCard1";
            this.uc_InstructorInfoCard1.Size = new System.Drawing.Size(729, 517);
            this.uc_InstructorInfoCard1.TabIndex = 0;
            // 
            // uc_MemberInstructorInfoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelLoginInfo);
            this.Controls.Add(this.tcMemberInstructor);
            this.Name = "uc_MemberInstructorInfoCard";
            this.Size = new System.Drawing.Size(742, 779);
            this.tcMemberInstructor.ResumeLayout(false);
            this.tpMember.ResumeLayout(false);
            this.tpInstructor.ResumeLayout(false);
            this.panelLoginInfo.ResumeLayout(false);
            this.panelLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tcMemberInstructor;
        private System.Windows.Forms.TabPage tpMember;
        private Members.uc.uc_MemberInfoCard uc_MemberInfoCard1;
        private System.Windows.Forms.TabPage tpInstructor;
        private Instructors.uc.uc_InstructorInfoCard uc_InstructorInfoCard1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelLoginInfo;
        private System.Windows.Forms.LinkLabel linkLabEditMemberInstructor;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpAssignDate;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtMemberInstructorId;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}
