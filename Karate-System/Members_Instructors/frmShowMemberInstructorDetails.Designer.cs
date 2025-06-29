﻿namespace KarateSystem.Members_Instructors
{
    partial class frmShowMemberInstructorDetails
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
            this.labTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.uc_MemberInstructorInfoCard1 = new KarateSystem.Members_Instructors.uc.uc_MemberInstructorInfoCard();
            this.linkLabShowTrainedMembers = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = false;
            this.labTitle.BackColor = System.Drawing.Color.Transparent;
            this.labTitle.Font = new System.Drawing.Font("Andalus", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labTitle.Location = new System.Drawing.Point(154, 12);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(368, 36);
            this.labTitle.TabIndex = 2;
            this.labTitle.Text = " Instructors-Members Details";
            // 
            // uc_MemberInstructorInfoCard1
            // 
            this.uc_MemberInstructorInfoCard1.Location = new System.Drawing.Point(-5, 54);
            this.uc_MemberInstructorInfoCard1.MemberInstructorId = -1;
            this.uc_MemberInstructorInfoCard1.Name = "uc_MemberInstructorInfoCard1";
            this.uc_MemberInstructorInfoCard1.Size = new System.Drawing.Size(742, 779);
            this.uc_MemberInstructorInfoCard1.TabIndex = 3;
            // 
            // linkLabShowTrainedMembers
            // 
            this.linkLabShowTrainedMembers.AutoSize = true;
            this.linkLabShowTrainedMembers.BackColor = System.Drawing.Color.White;
            this.linkLabShowTrainedMembers.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.linkLabShowTrainedMembers.Font = new System.Drawing.Font("Aldhabi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabShowTrainedMembers.Location = new System.Drawing.Point(497, 773);
            this.linkLabShowTrainedMembers.Name = "linkLabShowTrainedMembers";
            this.linkLabShowTrainedMembers.Size = new System.Drawing.Size(178, 35);
            this.linkLabShowTrainedMembers.TabIndex = 40;
            this.linkLabShowTrainedMembers.TabStop = true;
            this.linkLabShowTrainedMembers.Text = "Show Trained Members";
            this.linkLabShowTrainedMembers.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabShowTrainedMembers_LinkClicked);
            // 
            // frmShowMemberInstructorDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 845);
            this.Controls.Add(this.linkLabShowTrainedMembers);
            this.Controls.Add(this.uc_MemberInstructorInfoCard1);
            this.Controls.Add(this.labTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowMemberInstructorDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Member Instructor Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel labTitle;
        private uc.uc_MemberInstructorInfoCard uc_MemberInstructorInfoCard1;
        private System.Windows.Forms.LinkLabel linkLabShowTrainedMembers;
    }
}