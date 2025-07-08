namespace KarateSystem.Subscription_Periods
{
    partial class frmManageSubscriptionPeriods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageSubscriptionPeriods));
            this.dgvAllPeriods = new System.Windows.Forms.DataGridView();
            this.cmsManagePeriods = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewSubscriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPeriodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labCountRecords = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnAddSubscriptionPeriod = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtFilterBy = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnFind = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnRenewPeriod = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPeriods)).BeginInit();
            this.cmsManagePeriods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllPeriods
            // 
            this.dgvAllPeriods.AllowUserToAddRows = false;
            this.dgvAllPeriods.AllowUserToDeleteRows = false;
            this.dgvAllPeriods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllPeriods.ContextMenuStrip = this.cmsManagePeriods;
            this.dgvAllPeriods.Location = new System.Drawing.Point(177, 373);
            this.dgvAllPeriods.Name = "dgvAllPeriods";
            this.dgvAllPeriods.ReadOnly = true;
            this.dgvAllPeriods.RowHeadersWidth = 70;
            this.dgvAllPeriods.RowTemplate.Height = 24;
            this.dgvAllPeriods.Size = new System.Drawing.Size(1092, 304);
            this.dgvAllPeriods.TabIndex = 20;
            // 
            // cmsManagePeriods
            // 
            this.cmsManagePeriods.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsManagePeriods.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.showDetailsToolStripMenuItem,
            this.renewSubscriptionToolStripMenuItem,
            this.addNewPeriodToolStripMenuItem});
            this.cmsManagePeriods.Name = "cmsManagePeople";
            this.cmsManagePeriods.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsManagePeriods.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsManagePeriods.RenderStyle.ColorTable = null;
            this.cmsManagePeriods.RenderStyle.RoundedEdges = true;
            this.cmsManagePeriods.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsManagePeriods.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsManagePeriods.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsManagePeriods.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsManagePeriods.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsManagePeriods.Size = new System.Drawing.Size(312, 134);
            this.cmsManagePeriods.Opening += new System.ComponentModel.CancelEventHandler(this.cmsManagePeriods_Opening);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateToolStripMenuItem.Image")));
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(311, 26);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(311, 26);
            this.deleteToolStripMenuItem.Text = "Show Periods Histrory For Member";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showDetailsToolStripMenuItem.Image")));
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(311, 26);
            this.showDetailsToolStripMenuItem.Text = "Show Period Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // renewSubscriptionToolStripMenuItem
            // 
            this.renewSubscriptionToolStripMenuItem.Name = "renewSubscriptionToolStripMenuItem";
            this.renewSubscriptionToolStripMenuItem.Size = new System.Drawing.Size(311, 26);
            this.renewSubscriptionToolStripMenuItem.Text = "Renew Subscription";
            this.renewSubscriptionToolStripMenuItem.Click += new System.EventHandler(this.renewSubscriptionToolStripMenuItem_Click);
            // 
            // addNewPeriodToolStripMenuItem
            // 
            this.addNewPeriodToolStripMenuItem.Name = "addNewPeriodToolStripMenuItem";
            this.addNewPeriodToolStripMenuItem.Size = new System.Drawing.Size(311, 26);
            this.addNewPeriodToolStripMenuItem.Text = "Add New Period";
            this.addNewPeriodToolStripMenuItem.Click += new System.EventHandler(this.addNewPeriodToolStripMenuItem_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(590, 48);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(300, 200);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 28;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(46, 724);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(114, 32);
            this.guna2HtmlLabel3.TabIndex = 27;
            this.guna2HtmlLabel3.Text = "#Records:";
            // 
            // labCountRecords
            // 
            this.labCountRecords.AutoSize = false;
            this.labCountRecords.BackColor = System.Drawing.Color.Transparent;
            this.labCountRecords.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCountRecords.ForeColor = System.Drawing.Color.Black;
            this.labCountRecords.Location = new System.Drawing.Point(149, 723);
            this.labCountRecords.Name = "labCountRecords";
            this.labCountRecords.Size = new System.Drawing.Size(104, 33);
            this.labCountRecords.TabIndex = 26;
            this.labCountRecords.Text = "??";
            this.labCountRecords.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddSubscriptionPeriod
            // 
            this.btnAddSubscriptionPeriod.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddSubscriptionPeriod.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddSubscriptionPeriod.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSubscriptionPeriod.Image")));
            this.btnAddSubscriptionPeriod.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAddSubscriptionPeriod.ImageRotate = 0F;
            this.btnAddSubscriptionPeriod.Location = new System.Drawing.Point(1197, 302);
            this.btnAddSubscriptionPeriod.Name = "btnAddSubscriptionPeriod";
            this.btnAddSubscriptionPeriod.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddSubscriptionPeriod.Size = new System.Drawing.Size(72, 65);
            this.btnAddSubscriptionPeriod.TabIndex = 25;
            this.btnAddSubscriptionPeriod.Click += new System.EventHandler(this.btnAddSubscriptionPeriod_Click);
            // 
            // txtFilterBy
            // 
            this.txtFilterBy.AutoRoundedCorners = true;
            this.txtFilterBy.BorderRadius = 17;
            this.txtFilterBy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterBy.DefaultText = "";
            this.txtFilterBy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilterBy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilterBy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterBy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterBy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFilterBy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterBy.Location = new System.Drawing.Point(469, 329);
            this.txtFilterBy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterBy.Name = "txtFilterBy";
            this.txtFilterBy.PlaceholderText = "";
            this.txtFilterBy.SelectedText = "";
            this.txtFilterBy.Size = new System.Drawing.Size(175, 36);
            this.txtFilterBy.TabIndex = 24;
            this.txtFilterBy.TextChanged += new System.EventHandler(this.txtFilterBy_TextChanged);
            this.txtFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterBy_KeyPress);
            // 
            // cmbFilterBy
            // 
            this.cmbFilterBy.AutoRoundedCorners = true;
            this.cmbFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.cmbFilterBy.BorderRadius = 17;
            this.cmbFilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFilterBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFilterBy.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterBy.ForeColor = System.Drawing.Color.Black;
            this.cmbFilterBy.ItemHeight = 30;
            this.cmbFilterBy.Items.AddRange(new object[] {
            "None"});
            this.cmbFilterBy.Location = new System.Drawing.Point(260, 330);
            this.cmbFilterBy.Name = "cmbFilterBy";
            this.cmbFilterBy.Size = new System.Drawing.Size(186, 36);
            this.cmbFilterBy.TabIndex = 23;
            this.cmbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmbFilterBy_SelectedIndexChanged);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(180, 333);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(74, 33);
            this.guna2HtmlLabel2.TabIndex = 22;
            this.guna2HtmlLabel2.Text = "Filter By: ";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Sakkal Majalla", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(518, 244);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(499, 75);
            this.guna2HtmlLabel1.TabIndex = 21;
            this.guna2HtmlLabel1.Text = "Manage Subscription Periods";
            // 
            // btnFind
            // 
            this.btnFind.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnFind.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnFind.ImageRotate = 0F;
            this.btnFind.Location = new System.Drawing.Point(1119, 300);
            this.btnFind.Name = "btnFind";
            this.btnFind.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnFind.Size = new System.Drawing.Size(72, 65);
            this.btnFind.TabIndex = 29;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnRenewPeriod
            // 
            this.btnRenewPeriod.AutoRoundedCorners = true;
            this.btnRenewPeriod.BackColor = System.Drawing.Color.Transparent;
            this.btnRenewPeriod.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRenewPeriod.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRenewPeriod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRenewPeriod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRenewPeriod.FillColor = System.Drawing.Color.Silver;
            this.btnRenewPeriod.Font = new System.Drawing.Font("Andalus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenewPeriod.ForeColor = System.Drawing.Color.Black;
            this.btnRenewPeriod.Location = new System.Drawing.Point(1119, 698);
            this.btnRenewPeriod.Name = "btnRenewPeriod";
            this.btnRenewPeriod.Size = new System.Drawing.Size(150, 45);
            this.btnRenewPeriod.TabIndex = 30;
            this.btnRenewPeriod.Text = "Renew Period";
            this.btnRenewPeriod.Click += new System.EventHandler(this.btnRenewPeriod_Click);
            // 
            // frmManageSubscriptionPeriods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 833);
            this.Controls.Add(this.btnRenewPeriod);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.dgvAllPeriods);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.labCountRecords);
            this.Controls.Add(this.btnAddSubscriptionPeriod);
            this.Controls.Add(this.txtFilterBy);
            this.Controls.Add(this.cmbFilterBy);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageSubscriptionPeriods";
            this.Text = "Manage Subscription Periods";
            this.Load += new System.EventHandler(this.frmManageSubscriptionPeriods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPeriods)).EndInit();
            this.cmsManagePeriods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllPeriods;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsManagePeriods;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel labCountRecords;
        private Guna.UI2.WinForms.Guna2ImageButton btnAddSubscriptionPeriod;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterBy;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFilterBy;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.ToolStripMenuItem renewSubscriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPeriodToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ImageButton btnFind;
        private Guna.UI2.WinForms.Guna2Button btnRenewPeriod;
    }
}