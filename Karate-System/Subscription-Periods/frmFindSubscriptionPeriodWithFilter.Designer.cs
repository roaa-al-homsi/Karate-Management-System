namespace KarateSystem.Subscription_Periods
{
    partial class frmFindSubscriptionPeriodWithFilter
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
            this.uc_SubscriptionPeriodWithFilter1 = new KarateSystem.Subscription_Periods.uc.uc_SubscriptionPeriodWithFilter();
            this.SuspendLayout();
            // 
            // labTitleForm
            // 
            this.labTitleForm.AutoSize = false;
            this.labTitleForm.BackColor = System.Drawing.Color.Transparent;
            this.labTitleForm.Font = new System.Drawing.Font("Andalus", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitleForm.ForeColor = System.Drawing.Color.Maroon;
            this.labTitleForm.Location = new System.Drawing.Point(324, 12);
            this.labTitleForm.Name = "labTitleForm";
            this.labTitleForm.Size = new System.Drawing.Size(368, 30);
            this.labTitleForm.TabIndex = 141;
            this.labTitleForm.Text = "Find Subsricription Period";
            // 
            // uc_SubscriptionPeriodWithFilter1
            // 
            this.uc_SubscriptionPeriodWithFilter1.FilterEnabled = false;
            this.uc_SubscriptionPeriodWithFilter1.Location = new System.Drawing.Point(12, 79);
            this.uc_SubscriptionPeriodWithFilter1.Name = "uc_SubscriptionPeriodWithFilter1";
            this.uc_SubscriptionPeriodWithFilter1.PeriodId = -1;
            this.uc_SubscriptionPeriodWithFilter1.Size = new System.Drawing.Size(990, 447);
            this.uc_SubscriptionPeriodWithFilter1.TabIndex = 0;
            // 
            // frmFindSubscriptionPeriodWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 527);
            this.Controls.Add(this.labTitleForm);
            this.Controls.Add(this.uc_SubscriptionPeriodWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFindSubscriptionPeriodWithFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Find Subscription Period ";
            this.ResumeLayout(false);

        }

        #endregion

        private uc.uc_SubscriptionPeriodWithFilter uc_SubscriptionPeriodWithFilter1;
        private Guna.UI2.WinForms.Guna2HtmlLabel labTitleForm;
    }
}