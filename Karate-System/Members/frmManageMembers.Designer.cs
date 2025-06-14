namespace KarateSystem.Members
{
    partial class frmManageMembers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageMembers));
            this.dgvAllMembers = new System.Windows.Forms.DataGridView();
            this.cmsManagePeople = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFind = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labCountRecords = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnAddMember = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtFilterBy = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllMembers)).BeginInit();
            this.cmsManagePeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllMembers
            // 
            this.dgvAllMembers.AllowUserToAddRows = false;
            this.dgvAllMembers.AllowUserToDeleteRows = false;
            this.dgvAllMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllMembers.ContextMenuStrip = this.cmsManagePeople;
            this.dgvAllMembers.Location = new System.Drawing.Point(159, 368);
            this.dgvAllMembers.Name = "dgvAllMembers";
            this.dgvAllMembers.ReadOnly = true;
            this.dgvAllMembers.RowHeadersWidth = 70;
            this.dgvAllMembers.RowTemplate.Height = 24;
            this.dgvAllMembers.Size = new System.Drawing.Size(1191, 286);
            this.dgvAllMembers.TabIndex = 20;
            // 
            // cmsManagePeople
            // 
            this.cmsManagePeople.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsManagePeople.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.showDetailsToolStripMenuItem});
            this.cmsManagePeople.Name = "cmsManagePeople";
            this.cmsManagePeople.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsManagePeople.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsManagePeople.RenderStyle.ColorTable = null;
            this.cmsManagePeople.RenderStyle.RoundedEdges = true;
            this.cmsManagePeople.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsManagePeople.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsManagePeople.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsManagePeople.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsManagePeople.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsManagePeople.Size = new System.Drawing.Size(169, 82);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateToolStripMenuItem.Image")));
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showDetailsToolStripMenuItem.Image")));
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.ImageRotate = 0F;
            this.btnFind.Location = new System.Drawing.Point(1157, 296);
            this.btnFind.Name = "btnFind";
            this.btnFind.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnFind.Size = new System.Drawing.Size(81, 65);
            this.btnFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFind.TabIndex = 29;
            this.btnFind.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(631, 12);
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
            // btnAddMember
            // 
            this.btnAddMember.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddMember.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddMember.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMember.Image")));
            this.btnAddMember.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAddMember.ImageRotate = 0F;
            this.btnAddMember.Location = new System.Drawing.Point(1232, 296);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddMember.Size = new System.Drawing.Size(89, 65);
            this.btnAddMember.TabIndex = 25;
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
            this.txtFilterBy.Location = new System.Drawing.Point(457, 325);
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
            this.cmbFilterBy.Location = new System.Drawing.Point(248, 326);
            this.cmbFilterBy.Name = "cmbFilterBy";
            this.cmbFilterBy.Size = new System.Drawing.Size(186, 36);
            this.cmbFilterBy.TabIndex = 23;
            this.cmbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmbFilterBy_SelectedIndexChanged);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(168, 329);
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
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(631, 218);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(300, 75);
            this.guna2HtmlLabel1.TabIndex = 21;
            this.guna2HtmlLabel1.Text = "Manage Members";
            // 
            // frmManageMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 833);
            this.Controls.Add(this.dgvAllMembers);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.labCountRecords);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.txtFilterBy);
            this.Controls.Add(this.cmbFilterBy);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageMembers";
            this.Text = "frmManageMembers";
            this.Load += new System.EventHandler(this.frmManageMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllMembers)).EndInit();
            this.cmsManagePeople.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnFind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllMembers;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsManagePeople;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnFind;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel labCountRecords;
        private Guna.UI2.WinForms.Guna2ImageButton btnAddMember;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterBy;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFilterBy;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}