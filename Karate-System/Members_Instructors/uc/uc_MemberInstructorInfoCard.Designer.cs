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
            this.tcMemberInstructor = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpMember = new System.Windows.Forms.TabPage();
            this.uc_MemberInfoCard1 = new KarateSystem.Members.uc.uc_MemberInfoCard();
            this.tpInstructor = new System.Windows.Forms.TabPage();
            this.uc_InstructorInfoCard1 = new KarateSystem.Instructors.uc.uc_InstructorInfoCard();
            this.tcMemberInstructor.SuspendLayout();
            this.tpMember.SuspendLayout();
            this.tpInstructor.SuspendLayout();
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
            // uc_MemberInfoCard1
            // 
            this.uc_MemberInfoCard1.Location = new System.Drawing.Point(0, 0);
            this.uc_MemberInfoCard1.MemberId = -1;
            this.uc_MemberInfoCard1.Name = "uc_MemberInfoCard1";
            this.uc_MemberInfoCard1.Size = new System.Drawing.Size(727, 602);
            this.uc_MemberInfoCard1.TabIndex = 0;
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
            // uc_InstructorInfoCard1
            // 
            this.uc_InstructorInfoCard1.InstructorId = 0;
            this.uc_InstructorInfoCard1.Location = new System.Drawing.Point(0, 0);
            this.uc_InstructorInfoCard1.Name = "uc_InstructorInfoCard1";
            this.uc_InstructorInfoCard1.Size = new System.Drawing.Size(729, 517);
            this.uc_InstructorInfoCard1.TabIndex = 0;
            // 
            // MemberInstructorInfoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcMemberInstructor);
            this.Name = "MemberInstructorInfoCard";
            this.Size = new System.Drawing.Size(742, 662);
            this.tcMemberInstructor.ResumeLayout(false);
            this.tpMember.ResumeLayout(false);
            this.tpInstructor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tcMemberInstructor;
        private System.Windows.Forms.TabPage tpMember;
        private Members.uc.uc_MemberInfoCard uc_MemberInfoCard1;
        private System.Windows.Forms.TabPage tpInstructor;
        private Instructors.uc.uc_InstructorInfoCard uc_InstructorInfoCard1;
    }
}
