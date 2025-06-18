namespace KarateSystem.Members_Instructors
{
    partial class frmAddUpdateMembersInstructors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateMembersInstructors));
            this.tcMemberInstructor = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpMember = new System.Windows.Forms.TabPage();
            this.tpInstructor = new System.Windows.Forms.TabPage();
            this.labTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.uc_MemberInfoWithFilter1 = new KarateSystem.Members.uc.uc_MemberInfoWithFilter();
            this.uc_InstructorInfoWithFilter1 = new KarateSystem.Instructors.uc.uc_InstructorInfoWithFilter();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.panelLoginInfo = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtMemberInstructorId = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.dtpAssignDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
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
            this.tcMemberInstructor.Location = new System.Drawing.Point(-2, 67);
            this.tcMemberInstructor.Name = "tcMemberInstructor";
            this.tcMemberInstructor.SelectedIndex = 0;
            this.tcMemberInstructor.Size = new System.Drawing.Size(745, 788);
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
            this.tcMemberInstructor.TabIndex = 0;
            this.tcMemberInstructor.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcMemberInstructor.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpMember
            // 
            this.tpMember.Controls.Add(this.btnNext);
            this.tpMember.Controls.Add(this.uc_MemberInfoWithFilter1);
            this.tpMember.Location = new System.Drawing.Point(4, 44);
            this.tpMember.Name = "tpMember";
            this.tpMember.Padding = new System.Windows.Forms.Padding(3);
            this.tpMember.Size = new System.Drawing.Size(737, 740);
            this.tpMember.TabIndex = 0;
            this.tpMember.Text = "Member";
            this.tpMember.UseVisualStyleBackColor = true;
            // 
            // tpInstructor
            // 
            this.tpInstructor.Controls.Add(this.uc_InstructorInfoWithFilter1);
            this.tpInstructor.Location = new System.Drawing.Point(4, 44);
            this.tpInstructor.Name = "tpInstructor";
            this.tpInstructor.Padding = new System.Windows.Forms.Padding(3);
            this.tpInstructor.Size = new System.Drawing.Size(737, 740);
            this.tpInstructor.TabIndex = 1;
            this.tpInstructor.Text = "Instructor";
            this.tpInstructor.UseVisualStyleBackColor = true;
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = false;
            this.labTitle.BackColor = System.Drawing.Color.Transparent;
            this.labTitle.Font = new System.Drawing.Font("Andalus", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labTitle.Location = new System.Drawing.Point(136, 12);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(483, 36);
            this.labTitle.TabIndex = 1;
            this.labTitle.Text = "Add New Instructors-Members";
            // 
            // uc_MemberInfoWithFilter1
            // 
            this.uc_MemberInfoWithFilter1.FilterEnabled = false;
            this.uc_MemberInfoWithFilter1.Location = new System.Drawing.Point(0, 0);
          
            this.uc_MemberInfoWithFilter1.Name = "uc_MemberInfoWithFilter1";
            this.uc_MemberInfoWithFilter1.ShowAddPerson = true;
            this.uc_MemberInfoWithFilter1.Size = new System.Drawing.Size(729, 734);
            this.uc_MemberInfoWithFilter1.TabIndex = 0;
            // 
            // uc_InstructorInfoWithFilter1
            // 
            this.uc_InstructorInfoWithFilter1.FilterEnabled = false;
          
            this.uc_InstructorInfoWithFilter1.Location = new System.Drawing.Point(0, 0);
            this.uc_InstructorInfoWithFilter1.Name = "uc_InstructorInfoWithFilter1";
            this.uc_InstructorInfoWithFilter1.ShowAddInstructor = false;
            this.uc_InstructorInfoWithFilter1.Size = new System.Drawing.Size(726, 645);
            this.uc_InstructorInfoWithFilter1.TabIndex = 0;
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
            this.btnSave.Location = new System.Drawing.Point(597, 870);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 45);
            this.btnSave.TabIndex = 135;
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
            this.btnCancel.Location = new System.Drawing.Point(597, 937);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 45);
            this.btnCancel.TabIndex = 136;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelLoginInfo
            // 
            this.panelLoginInfo.BorderColor = System.Drawing.Color.Black;
            this.panelLoginInfo.BorderThickness = 1;
            this.panelLoginInfo.Controls.Add(this.dtpAssignDate);
            this.panelLoginInfo.Controls.Add(this.guna2PictureBox2);
            this.panelLoginInfo.Controls.Add(this.guna2PictureBox1);
            this.panelLoginInfo.Controls.Add(this.txtMemberInstructorId);
            this.panelLoginInfo.Controls.Add(this.guna2HtmlLabel2);
            this.panelLoginInfo.Controls.Add(this.guna2HtmlLabel1);
            this.panelLoginInfo.Location = new System.Drawing.Point(2, 861);
            this.panelLoginInfo.Name = "panelLoginInfo";
            this.panelLoginInfo.Size = new System.Drawing.Size(421, 109);
            this.panelLoginInfo.TabIndex = 137;
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
            this.btnNext.Location = new System.Drawing.Point(595, 667);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 45);
            this.btnNext.TabIndex = 138;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // dtpAssignDate
            // 
            this.dtpAssignDate.AutoRoundedCorners = true;
            this.dtpAssignDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpAssignDate.Checked = true;
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
            // frmAddUpdateMembersInstructors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 980);
            this.Controls.Add(this.panelLoginInfo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.tcMemberInstructor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUpdateMembersInstructors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddUpdateMembersInstructors";
            this.Load += new System.EventHandler(this.frmAddUpdateMembersInstructors_Load);
            this.tcMemberInstructor.ResumeLayout(false);
            this.tpMember.ResumeLayout(false);
            this.tpInstructor.ResumeLayout(false);
            this.panelLoginInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tcMemberInstructor;
        private System.Windows.Forms.TabPage tpMember;
        private System.Windows.Forms.TabPage tpInstructor;
        private Guna.UI2.WinForms.Guna2HtmlLabel labTitle;
        private Members.uc.uc_MemberInfoWithFilter uc_MemberInfoWithFilter1;
        private Instructors.uc.uc_InstructorInfoWithFilter uc_InstructorInfoWithFilter1;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelLoginInfo;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtMemberInstructorId;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpAssignDate;
    }
}