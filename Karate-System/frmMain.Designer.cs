﻿namespace KarateSystem
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.pnlOptions = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAccountSetting = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnPayments = new Guna.UI2.WinForms.Guna2Button();
            this.btnBeltTests = new Guna.UI2.WinForms.Guna2Button();
            this.btnSubscriptionPeriods = new Guna.UI2.WinForms.Guna2Button();
            this.btnBeltRanks = new Guna.UI2.WinForms.Guna2Button();
            this.btnMembersInstructors = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnInstructors = new Guna.UI2.WinForms.Guna2Button();
            this.btnMembers = new Guna.UI2.WinForms.Guna2Button();
            this.btnManagePeople = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelMainMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picCurrentUser = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTitle = new Guna.UI2.WinForms.Guna2Button();
            this.labUserName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labCurrentUser = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlOptions.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panelMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCurrentUser)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.btnDashboard.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDashboard.Location = new System.Drawing.Point(0, 157);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(291, 59);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Tag = "Dashboard";
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.btnAllBooks_Click);
            // 
            // pnlOptions
            // 
            this.pnlOptions.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pnlOptions.Controls.Add(this.btnAccountSetting);
            this.pnlOptions.Controls.Add(this.btnLogout);
            this.pnlOptions.Controls.Add(this.btnPayments);
            this.pnlOptions.Controls.Add(this.btnBeltTests);
            this.pnlOptions.Controls.Add(this.btnSubscriptionPeriods);
            this.pnlOptions.Controls.Add(this.btnBeltRanks);
            this.pnlOptions.Controls.Add(this.btnMembersInstructors);
            this.pnlOptions.Controls.Add(this.btnManageUsers);
            this.pnlOptions.Controls.Add(this.btnInstructors);
            this.pnlOptions.Controls.Add(this.btnMembers);
            this.pnlOptions.Controls.Add(this.btnManagePeople);
            this.pnlOptions.Controls.Add(this.btnDashboard);
            this.pnlOptions.Controls.Add(this.guna2Panel1);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOptions.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.pnlOptions.Location = new System.Drawing.Point(0, 72);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(291, 868);
            this.pnlOptions.TabIndex = 6;
            // 
            // btnAccountSetting
            // 
            this.btnAccountSetting.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnAccountSetting.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAccountSetting.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAccountSetting.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAccountSetting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAccountSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccountSetting.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.btnAccountSetting.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountSetting.ForeColor = System.Drawing.Color.White;
            this.btnAccountSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnAccountSetting.Image")));
            this.btnAccountSetting.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAccountSetting.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAccountSetting.Location = new System.Drawing.Point(0, 806);
            this.btnAccountSetting.Name = "btnAccountSetting";
            this.btnAccountSetting.Size = new System.Drawing.Size(291, 59);
            this.btnAccountSetting.TabIndex = 24;
            this.btnAccountSetting.Tag = "Account Setting";
            this.btnAccountSetting.Text = "Account Setting";
            this.btnAccountSetting.Click += new System.EventHandler(this.btnAccountSetting_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.btnLogout.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.ImageSize = new System.Drawing.Size(40, 40);
            this.btnLogout.Location = new System.Drawing.Point(0, 747);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(291, 59);
            this.btnLogout.TabIndex = 23;
            this.btnLogout.Tag = "Logout";
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnPayments.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPayments.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPayments.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPayments.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPayments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayments.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.btnPayments.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayments.ForeColor = System.Drawing.Color.White;
            this.btnPayments.Image = ((System.Drawing.Image)(resources.GetObject("btnPayments.Image")));
            this.btnPayments.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPayments.ImageSize = new System.Drawing.Size(40, 40);
            this.btnPayments.Location = new System.Drawing.Point(0, 688);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(291, 59);
            this.btnPayments.TabIndex = 22;
            this.btnPayments.Tag = "Payments";
            this.btnPayments.Text = "Payments";
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnBeltTests
            // 
            this.btnBeltTests.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnBeltTests.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBeltTests.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBeltTests.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBeltTests.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBeltTests.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBeltTests.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.btnBeltTests.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeltTests.ForeColor = System.Drawing.Color.White;
            this.btnBeltTests.Image = ((System.Drawing.Image)(resources.GetObject("btnBeltTests.Image")));
            this.btnBeltTests.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBeltTests.ImageSize = new System.Drawing.Size(40, 40);
            this.btnBeltTests.Location = new System.Drawing.Point(0, 629);
            this.btnBeltTests.Name = "btnBeltTests";
            this.btnBeltTests.Size = new System.Drawing.Size(291, 59);
            this.btnBeltTests.TabIndex = 21;
            this.btnBeltTests.Tag = "Belt Tests";
            this.btnBeltTests.Text = "Belt Tests";
            this.btnBeltTests.Click += new System.EventHandler(this.btnBeltTests_Click);
            // 
            // btnSubscriptionPeriods
            // 
            this.btnSubscriptionPeriods.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnSubscriptionPeriods.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubscriptionPeriods.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubscriptionPeriods.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubscriptionPeriods.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubscriptionPeriods.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubscriptionPeriods.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.btnSubscriptionPeriods.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubscriptionPeriods.ForeColor = System.Drawing.Color.White;
            this.btnSubscriptionPeriods.Image = ((System.Drawing.Image)(resources.GetObject("btnSubscriptionPeriods.Image")));
            this.btnSubscriptionPeriods.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSubscriptionPeriods.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSubscriptionPeriods.Location = new System.Drawing.Point(0, 570);
            this.btnSubscriptionPeriods.Name = "btnSubscriptionPeriods";
            this.btnSubscriptionPeriods.Size = new System.Drawing.Size(291, 59);
            this.btnSubscriptionPeriods.TabIndex = 20;
            this.btnSubscriptionPeriods.Tag = "Subscription Periods";
            this.btnSubscriptionPeriods.Text = "Subscription Periods";
            this.btnSubscriptionPeriods.Click += new System.EventHandler(this.btnSubscriptionPeriods_Click);
            // 
            // btnBeltRanks
            // 
            this.btnBeltRanks.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnBeltRanks.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBeltRanks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBeltRanks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBeltRanks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBeltRanks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBeltRanks.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.btnBeltRanks.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeltRanks.ForeColor = System.Drawing.Color.White;
            this.btnBeltRanks.Image = ((System.Drawing.Image)(resources.GetObject("btnBeltRanks.Image")));
            this.btnBeltRanks.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBeltRanks.ImageSize = new System.Drawing.Size(40, 40);
            this.btnBeltRanks.Location = new System.Drawing.Point(0, 511);
            this.btnBeltRanks.Name = "btnBeltRanks";
            this.btnBeltRanks.Size = new System.Drawing.Size(291, 59);
            this.btnBeltRanks.TabIndex = 19;
            this.btnBeltRanks.Tag = "Belt Ranks";
            this.btnBeltRanks.Text = "Belt Ranks";
            this.btnBeltRanks.Click += new System.EventHandler(this.btnBeltRanks_Click);
            // 
            // btnMembersInstructors
            // 
            this.btnMembersInstructors.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnMembersInstructors.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMembersInstructors.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMembersInstructors.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMembersInstructors.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMembersInstructors.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMembersInstructors.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.btnMembersInstructors.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembersInstructors.ForeColor = System.Drawing.Color.White;
            this.btnMembersInstructors.Image = ((System.Drawing.Image)(resources.GetObject("btnMembersInstructors.Image")));
            this.btnMembersInstructors.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMembersInstructors.ImageSize = new System.Drawing.Size(40, 40);
            this.btnMembersInstructors.Location = new System.Drawing.Point(0, 452);
            this.btnMembersInstructors.Name = "btnMembersInstructors";
            this.btnMembersInstructors.Size = new System.Drawing.Size(291, 59);
            this.btnMembersInstructors.TabIndex = 18;
            this.btnMembersInstructors.Tag = "Members Instructors";
            this.btnMembersInstructors.Text = "Members Instructors";
            this.btnMembersInstructors.Click += new System.EventHandler(this.btnMembersInstructors_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnManageUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageUsers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.btnManageUsers.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.ForeColor = System.Drawing.Color.White;
            this.btnManageUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnManageUsers.Image")));
            this.btnManageUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageUsers.ImageSize = new System.Drawing.Size(40, 40);
            this.btnManageUsers.Location = new System.Drawing.Point(0, 393);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(291, 59);
            this.btnManageUsers.TabIndex = 17;
            this.btnManageUsers.Tag = "Users";
            this.btnManageUsers.Text = "Users";
            this.btnManageUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnInstructors
            // 
            this.btnInstructors.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnInstructors.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInstructors.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInstructors.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInstructors.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInstructors.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInstructors.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.btnInstructors.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructors.ForeColor = System.Drawing.Color.White;
            this.btnInstructors.Image = ((System.Drawing.Image)(resources.GetObject("btnInstructors.Image")));
            this.btnInstructors.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInstructors.ImageSize = new System.Drawing.Size(40, 40);
            this.btnInstructors.Location = new System.Drawing.Point(0, 334);
            this.btnInstructors.Name = "btnInstructors";
            this.btnInstructors.Size = new System.Drawing.Size(291, 59);
            this.btnInstructors.TabIndex = 16;
            this.btnInstructors.Tag = "Instructors";
            this.btnInstructors.Text = "Instructors";
            this.btnInstructors.Click += new System.EventHandler(this.btnInstructors_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnMembers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMembers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMembers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMembers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMembers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMembers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.btnMembers.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembers.ForeColor = System.Drawing.Color.White;
            this.btnMembers.Image = ((System.Drawing.Image)(resources.GetObject("btnMembers.Image")));
            this.btnMembers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMembers.ImageSize = new System.Drawing.Size(40, 40);
            this.btnMembers.Location = new System.Drawing.Point(0, 275);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(291, 59);
            this.btnMembers.TabIndex = 15;
            this.btnMembers.Tag = "Members";
            this.btnMembers.Text = "Members";
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // btnManagePeople
            // 
            this.btnManagePeople.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnManagePeople.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManagePeople.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManagePeople.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManagePeople.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManagePeople.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManagePeople.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.btnManagePeople.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagePeople.ForeColor = System.Drawing.Color.White;
            this.btnManagePeople.Image = ((System.Drawing.Image)(resources.GetObject("btnManagePeople.Image")));
            this.btnManagePeople.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManagePeople.ImageSize = new System.Drawing.Size(40, 40);
            this.btnManagePeople.Location = new System.Drawing.Point(0, 216);
            this.btnManagePeople.Name = "btnManagePeople";
            this.btnManagePeople.Size = new System.Drawing.Size(291, 59);
            this.btnManagePeople.TabIndex = 14;
            this.btnManagePeople.Tag = "People";
            this.btnManagePeople.Text = "People";
            this.btnManagePeople.Click += new System.EventHandler(this.btnManagePeople_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.guna2PictureBox2);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(291, 157);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(146, 24);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(84, 83);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 49;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(56, 24);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(84, 83);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(44, 113);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(202, 38);
            this.guna2HtmlLabel3.TabIndex = 48;
            this.guna2HtmlLabel3.Text = "Karate Club";
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panelMainMenu.Controls.Add(this.guna2HtmlLabel1);
            this.panelMainMenu.Controls.Add(this.guna2PictureBox3);
            this.panelMainMenu.FillColor = System.Drawing.Color.White;
            this.panelMainMenu.Location = new System.Drawing.Point(289, 72);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(1509, 865);
            this.panelMainMenu.TabIndex = 8;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(516, 94);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(400, 38);
            this.guna2HtmlLabel1.TabIndex = 50;
            this.guna2HtmlLabel1.Text = "Welcome To Karate Club";
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(752, 113);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(745, 749);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 50;
            this.guna2PictureBox3.TabStop = false;
            this.guna2PictureBox3.UseTransparentBackground = true;
            // 
            // picCurrentUser
            // 
            this.picCurrentUser.BackColor = System.Drawing.Color.Transparent;
            this.picCurrentUser.Image = ((System.Drawing.Image)(resources.GetObject("picCurrentUser.Image")));
            this.picCurrentUser.ImageRotate = 0F;
            this.picCurrentUser.Location = new System.Drawing.Point(1585, 13);
            this.picCurrentUser.Name = "picCurrentUser";
            this.picCurrentUser.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picCurrentUser.Size = new System.Drawing.Size(59, 39);
            this.picCurrentUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCurrentUser.TabIndex = 3;
            this.picCurrentUser.TabStop = false;
            this.picCurrentUser.UseTransparentBackground = true;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.guna2Panel2.Controls.Add(this.picCurrentUser);
            this.guna2Panel2.Controls.Add(this.btnTitle);
            this.guna2Panel2.Controls.Add(this.labUserName);
            this.guna2Panel2.Controls.Add(this.labCurrentUser);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1798, 72);
            this.guna2Panel2.TabIndex = 7;
            // 
            // btnTitle
            // 
            this.btnTitle.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnTitle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTitle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTitle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.btnTitle.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitle.ForeColor = System.Drawing.Color.MintCream;
            this.btnTitle.Image = ((System.Drawing.Image)(resources.GetObject("btnTitle.Image")));
            this.btnTitle.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTitle.ImageSize = new System.Drawing.Size(40, 40);
            this.btnTitle.Location = new System.Drawing.Point(289, 9);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(474, 60);
            this.btnTitle.TabIndex = 2;
            this.btnTitle.Text = "Home";
            this.btnTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labUserName
            // 
            this.labUserName.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labUserName.Font = new System.Drawing.Font("Andalus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(73)))), ((int)(((byte)(225)))));
            this.labUserName.Location = new System.Drawing.Point(827, 38);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(3, 2);
            this.labUserName.TabIndex = 1;
            this.labUserName.Text = null;
            this.labUserName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labCurrentUser
            // 
            this.labCurrentUser.AutoSize = false;
            this.labCurrentUser.BackColor = System.Drawing.Color.Transparent;
            this.labCurrentUser.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCurrentUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labCurrentUser.Location = new System.Drawing.Point(1650, 27);
            this.labCurrentUser.Name = "labCurrentUser";
            this.labCurrentUser.Size = new System.Drawing.Size(105, 25);
            this.labCurrentUser.TabIndex = 0;
            this.labCurrentUser.Text = "Username";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1798, 940);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.panelMainMenu);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlOptions.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panelMainMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCurrentUser)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Panel pnlOptions;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Panel panelMainMenu;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picCurrentUser;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel labUserName;
        private Guna.UI2.WinForms.Guna2HtmlLabel labCurrentUser;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnPayments;
        private Guna.UI2.WinForms.Guna2Button btnBeltTests;
        private Guna.UI2.WinForms.Guna2Button btnSubscriptionPeriods;
        private Guna.UI2.WinForms.Guna2Button btnBeltRanks;
        private Guna.UI2.WinForms.Guna2Button btnMembersInstructors;
        private Guna.UI2.WinForms.Guna2Button btnManageUsers;
        private Guna.UI2.WinForms.Guna2Button btnInstructors;
        private Guna.UI2.WinForms.Guna2Button btnMembers;
        private Guna.UI2.WinForms.Guna2Button btnManagePeople;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnAccountSetting;
    }
}

