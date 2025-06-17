namespace KarateSystem.Instructors
{
    partial class frmShowTrainedMembers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowTrainedMembers));
            this.uc_InstructorInfoCard1 = new KarateSystem.Instructors.uc.uc_InstructorInfoCard();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labCountRecords = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmsMember = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.toolStripMenuMemberDetails = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.cmsMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // uc_InstructorInfoCard1
            // 
            this.uc_InstructorInfoCard1.InstructorId = 0;
            this.uc_InstructorInfoCard1.Location = new System.Drawing.Point(9, 53);
            this.uc_InstructorInfoCard1.Name = "uc_InstructorInfoCard1";
            this.uc_InstructorInfoCard1.Size = new System.Drawing.Size(729, 517);
            this.uc_InstructorInfoCard1.TabIndex = 0;
            // 
            // dgvMembers
            // 
            this.dgvMembers.AllowUserToAddRows = false;
            this.dgvMembers.AllowUserToDeleteRows = false;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.ContextMenuStrip = this.cmsMember;
            this.dgvMembers.Location = new System.Drawing.Point(12, 629);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.ReadOnly = true;
            this.dgvMembers.RowHeadersWidth = 70;
            this.dgvMembers.RowTemplate.Height = 24;
            this.dgvMembers.Size = new System.Drawing.Size(717, 179);
            this.dgvMembers.TabIndex = 30;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Aldhabi", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(70, 576);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(103, 47);
            this.guna2HtmlLabel1.TabIndex = 31;
            this.guna2HtmlLabel1.Text = "Members";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(5, 574);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(66, 47);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 33;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(12, 814);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(114, 32);
            this.guna2HtmlLabel3.TabIndex = 38;
            this.guna2HtmlLabel3.Text = "#Records:";
            // 
            // labCountRecords
            // 
            this.labCountRecords.AutoSize = false;
            this.labCountRecords.BackColor = System.Drawing.Color.Transparent;
            this.labCountRecords.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCountRecords.ForeColor = System.Drawing.Color.Black;
            this.labCountRecords.Location = new System.Drawing.Point(115, 813);
            this.labCountRecords.Name = "labCountRecords";
            this.labCountRecords.Size = new System.Drawing.Size(104, 33);
            this.labCountRecords.TabIndex = 37;
            this.labCountRecords.Text = "??";
            this.labCountRecords.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Aldhabi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Maroon;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(169, 0);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(358, 47);
            this.guna2HtmlLabel2.TabIndex = 39;
            this.guna2HtmlLabel2.Text = "Trained Members By Instructor";
            // 
            // cmsMember
            // 
            this.cmsMember.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsMember.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuMemberDetails});
            this.cmsMember.Name = "cmsMember";
            this.cmsMember.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsMember.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsMember.RenderStyle.ColorTable = null;
            this.cmsMember.RenderStyle.RoundedEdges = true;
            this.cmsMember.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsMember.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsMember.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsMember.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsMember.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsMember.Size = new System.Drawing.Size(211, 56);
            // 
            // toolStripMenuMemberDetails
            // 
            this.toolStripMenuMemberDetails.Name = "toolStripMenuMemberDetails";
            this.toolStripMenuMemberDetails.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuMemberDetails.Text = "Member Details";
            this.toolStripMenuMemberDetails.Click += new System.EventHandler(this.toolStripMenuMemberDetails_Click);
            // 
            // frmShowTrainedMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 847);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.labCountRecords);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.dgvMembers);
            this.Controls.Add(this.uc_InstructorInfoCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowTrainedMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Trained Members";
            this.Load += new System.EventHandler(this.frmShowTrainedMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.cmsMember.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private uc.uc_InstructorInfoCard uc_InstructorInfoCard1;
        private System.Windows.Forms.DataGridView dgvMembers;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel labCountRecords;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsMember;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuMemberDetails;
    }
}