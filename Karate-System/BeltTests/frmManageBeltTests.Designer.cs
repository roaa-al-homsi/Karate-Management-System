namespace KarateSystem.BeltTests
{
    partial class frmManageBeltTests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageBeltTests));
            this.dgvAllBeltTests = new System.Windows.Forms.DataGridView();
            this.cmsManageBeltTests = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.takeNextTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retakeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labCountRecords = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtFilterBy = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnAddTest = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBeltTests)).BeginInit();
            this.cmsManageBeltTests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllBeltTests
            // 
            this.dgvAllBeltTests.AllowUserToAddRows = false;
            this.dgvAllBeltTests.AllowUserToDeleteRows = false;
            this.dgvAllBeltTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllBeltTests.ContextMenuStrip = this.cmsManageBeltTests;
            this.dgvAllBeltTests.Location = new System.Drawing.Point(43, 419);
            this.dgvAllBeltTests.Name = "dgvAllBeltTests";
            this.dgvAllBeltTests.ReadOnly = true;
            this.dgvAllBeltTests.RowHeadersWidth = 70;
            this.dgvAllBeltTests.RowTemplate.Height = 24;
            this.dgvAllBeltTests.Size = new System.Drawing.Size(1317, 304);
            this.dgvAllBeltTests.TabIndex = 29;
            // 
            // cmsManageBeltTests
            // 
            this.cmsManageBeltTests.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsManageBeltTests.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.takeNextTestToolStripMenuItem,
            this.retakeTestToolStripMenuItem});
            this.cmsManageBeltTests.Name = "cmsManagePeople";
            this.cmsManageBeltTests.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsManageBeltTests.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsManageBeltTests.RenderStyle.ColorTable = null;
            this.cmsManageBeltTests.RenderStyle.RoundedEdges = true;
            this.cmsManageBeltTests.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsManageBeltTests.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsManageBeltTests.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsManageBeltTests.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsManageBeltTests.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsManageBeltTests.Size = new System.Drawing.Size(211, 80);
            this.cmsManageBeltTests.Opening += new System.ComponentModel.CancelEventHandler(this.cmsManageBeltTests_Opening);
            // 
            // takeNextTestToolStripMenuItem
            // 
            this.takeNextTestToolStripMenuItem.Name = "takeNextTestToolStripMenuItem";
            this.takeNextTestToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.takeNextTestToolStripMenuItem.Text = "Take Next Test";
            this.takeNextTestToolStripMenuItem.Click += new System.EventHandler(this.takeNextTestToolStripMenuItem_Click);
            // 
            // retakeTestToolStripMenuItem
            // 
            this.retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            this.retakeTestToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.retakeTestToolStripMenuItem.Text = "Retake Test";
            this.retakeTestToolStripMenuItem.Click += new System.EventHandler(this.retakeTestToolStripMenuItem_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(626, 56);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(300, 200);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 37;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(42, 741);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(114, 32);
            this.guna2HtmlLabel3.TabIndex = 36;
            this.guna2HtmlLabel3.Text = "#Records:";
            // 
            // labCountRecords
            // 
            this.labCountRecords.AutoSize = false;
            this.labCountRecords.BackColor = System.Drawing.Color.Transparent;
            this.labCountRecords.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCountRecords.ForeColor = System.Drawing.Color.Black;
            this.labCountRecords.Location = new System.Drawing.Point(145, 740);
            this.labCountRecords.Name = "labCountRecords";
            this.labCountRecords.Size = new System.Drawing.Size(104, 33);
            this.labCountRecords.TabIndex = 35;
            this.labCountRecords.Text = "??";
            this.labCountRecords.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.txtFilterBy.Location = new System.Drawing.Point(437, 360);
            this.txtFilterBy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterBy.Name = "txtFilterBy";
            this.txtFilterBy.PlaceholderText = "";
            this.txtFilterBy.SelectedText = "";
            this.txtFilterBy.Size = new System.Drawing.Size(259, 36);
            this.txtFilterBy.TabIndex = 33;
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
            this.cmbFilterBy.Location = new System.Drawing.Point(128, 360);
            this.cmbFilterBy.Name = "cmbFilterBy";
            this.cmbFilterBy.Size = new System.Drawing.Size(259, 36);
            this.cmbFilterBy.TabIndex = 32;
            this.cmbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmbFilterBy_SelectedIndexChanged);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(48, 363);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(74, 33);
            this.guna2HtmlLabel2.TabIndex = 31;
            this.guna2HtmlLabel2.Text = "Filter By: ";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Sakkal Majalla", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(626, 249);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(300, 75);
            this.guna2HtmlLabel1.TabIndex = 30;
            this.guna2HtmlLabel1.Text = "Manage Belt Tests";
            // 
            // btnAddTest
            // 
            this.btnAddTest.AutoRoundedCorners = true;
            this.btnAddTest.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTest.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTest.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddTest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddTest.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddTest.ForeColor = System.Drawing.Color.White;
            this.btnAddTest.Location = new System.Drawing.Point(1264, 360);
            this.btnAddTest.Name = "btnAddTest";
            this.btnAddTest.Size = new System.Drawing.Size(96, 45);
            this.btnAddTest.TabIndex = 38;
            this.btnAddTest.Text = "ADD";
            this.btnAddTest.Click += new System.EventHandler(this.btnAddTest_Click);
            // 
            // frmManageBeltTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 833);
            this.Controls.Add(this.btnAddTest);
            this.Controls.Add(this.dgvAllBeltTests);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.labCountRecords);
            this.Controls.Add(this.txtFilterBy);
            this.Controls.Add(this.cmbFilterBy);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageBeltTests";
            this.Text = "frmManageBeltTests";
            this.Load += new System.EventHandler(this.frmManageBeltTests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBeltTests)).EndInit();
            this.cmsManageBeltTests.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllBeltTests;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsManageBeltTests;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel labCountRecords;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterBy;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFilterBy;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnAddTest;
        private System.Windows.Forms.ToolStripMenuItem takeNextTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retakeTestToolStripMenuItem;
    }
}