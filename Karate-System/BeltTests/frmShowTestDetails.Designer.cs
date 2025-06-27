namespace KarateSystem.BeltTests
{
    partial class frmShowTestDetails
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
            this.uc_BeltTestDetailsCard1 = new KarateSystem.BeltTests.uc.uc_BeltTestDetailsCard();
            this.SuspendLayout();
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = false;
            this.labTitle.BackColor = System.Drawing.Color.Transparent;
            this.labTitle.Font = new System.Drawing.Font("Andalus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.ForeColor = System.Drawing.Color.Maroon;
            this.labTitle.Location = new System.Drawing.Point(330, 12);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(252, 36);
            this.labTitle.TabIndex = 3;
            this.labTitle.Text = "Belt Test Details";
            // 
            // uc_BeltTestDetailsCard1
            // 
            this.uc_BeltTestDetailsCard1.BeltTestId = -1;
            this.uc_BeltTestDetailsCard1.Location = new System.Drawing.Point(3, 54);
            this.uc_BeltTestDetailsCard1.Name = "uc_BeltTestDetailsCard1";
            this.uc_BeltTestDetailsCard1.Size = new System.Drawing.Size(913, 284);
            this.uc_BeltTestDetailsCard1.TabIndex = 4;
            // 
            // frmShowTestDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 347);
            this.Controls.Add(this.uc_BeltTestDetailsCard1);
            this.Controls.Add(this.labTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowTestDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Show Test Details";
         
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel labTitle;
        private uc.uc_BeltTestDetailsCard uc_BeltTestDetailsCard1;
    }
}