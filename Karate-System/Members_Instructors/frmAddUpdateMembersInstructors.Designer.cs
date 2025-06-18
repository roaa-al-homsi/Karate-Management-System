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
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpMember = new System.Windows.Forms.TabPage();
            this.tpInstructor = new System.Windows.Forms.TabPage();
            this.labTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.uc_MemberInfoWithFilter1 = new KarateSystem.Members.uc.uc_MemberInfoWithFilter();
            this.guna2TabControl1.SuspendLayout();
            this.tpMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Controls.Add(this.tpMember);
            this.guna2TabControl1.Controls.Add(this.tpInstructor);
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(-2, 67);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(745, 788);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabIndex = 0;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpMember
            // 
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
            this.tpInstructor.Location = new System.Drawing.Point(4, 44);
            this.tpInstructor.Name = "tpInstructor";
            this.tpInstructor.Padding = new System.Windows.Forms.Padding(3);
            this.tpInstructor.Size = new System.Drawing.Size(946, 532);
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
            this.labTitle.Location = new System.Drawing.Point(109, 12);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(483, 36);
            this.labTitle.TabIndex = 1;
            this.labTitle.Text = "Add New Instructors-Members";
            // 
            // uc_MemberInfoWithFilter1
            // 
            this.uc_MemberInfoWithFilter1.FilterEnabled = false;
            this.uc_MemberInfoWithFilter1.Location = new System.Drawing.Point(0, 0);
            this.uc_MemberInfoWithFilter1.MemberId = -1;
            this.uc_MemberInfoWithFilter1.Name = "uc_MemberInfoWithFilter1";
            this.uc_MemberInfoWithFilter1.ShowAddPerson = true;
            this.uc_MemberInfoWithFilter1.Size = new System.Drawing.Size(729, 735);
            this.uc_MemberInfoWithFilter1.TabIndex = 0;
            // 
            // frmAddUpdateMembersInstructors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 857);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.guna2TabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUpdateMembersInstructors";
            this.Text = "frmAddUpdateMembersInstructors";
            this.guna2TabControl1.ResumeLayout(false);
            this.tpMember.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tpMember;
        private System.Windows.Forms.TabPage tpInstructor;
        private Guna.UI2.WinForms.Guna2HtmlLabel labTitle;
        private Members.uc.uc_MemberInfoWithFilter uc_MemberInfoWithFilter1;
    }
}