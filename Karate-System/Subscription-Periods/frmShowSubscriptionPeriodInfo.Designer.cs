namespace KarateSystem.Subscription_Periods
{
    partial class frmShowSubscriptionPeriodInfo
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
            this.labTitleForm = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.uc_SubscriptionPeriodInfoCard1 = new KarateSystem.Subscription_Periods.uc.uc_SubscriptionPeriodInfoCard();
            this.SuspendLayout();
            // 
            // labTitleForm
            // 
            this.labTitleForm.AutoSize = false;
            this.labTitleForm.BackColor = System.Drawing.Color.Transparent;
            this.labTitleForm.Font = new System.Drawing.Font("Andalus", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitleForm.ForeColor = System.Drawing.Color.Maroon;
            this.labTitleForm.Location = new System.Drawing.Point(313, 12);
            this.labTitleForm.Name = "labTitleForm";
            this.labTitleForm.Size = new System.Drawing.Size(355, 45);
            this.labTitleForm.TabIndex = 140;
            this.labTitleForm.Text = "Subscription Period Details";
            // 
            // uc_SubscriptionPeriodInfoCard1
            // 
            this.uc_SubscriptionPeriodInfoCard1.Location = new System.Drawing.Point(8, 63);
            this.uc_SubscriptionPeriodInfoCard1.Name = "uc_SubscriptionPeriodInfoCard1";
            this.uc_SubscriptionPeriodInfoCard1.PeriodId = 0;
            this.uc_SubscriptionPeriodInfoCard1.Size = new System.Drawing.Size(988, 309);
            this.uc_SubscriptionPeriodInfoCard1.SubscriptionPeriod = null;
            this.uc_SubscriptionPeriodInfoCard1.TabIndex = 141;
            // 
            // frmShowSubscriptionPeriodInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 373);
            this.Controls.Add(this.uc_SubscriptionPeriodInfoCard1);
            this.Controls.Add(this.labTitleForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowSubscriptionPeriodInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Subscription Period Info";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel labTitleForm;
        private uc.uc_SubscriptionPeriodInfoCard uc_SubscriptionPeriodInfoCard1;
    }
}