namespace KarateSystem.Payments
{
    partial class frmShowPaymentDetails
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
            this.uc_PaymentInfoCard1 = new KarateSystem.Payments.uc_PaymentInfoCard();
            this.SuspendLayout();
            // 
            // labTitleForm
            // 
            this.labTitleForm.AutoSize = false;
            this.labTitleForm.BackColor = System.Drawing.Color.Transparent;
            this.labTitleForm.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitleForm.ForeColor = System.Drawing.Color.Maroon;
            this.labTitleForm.Location = new System.Drawing.Point(377, 12);
            this.labTitleForm.Name = "labTitleForm";
            this.labTitleForm.Size = new System.Drawing.Size(196, 30);
            this.labTitleForm.TabIndex = 140;
            this.labTitleForm.Text = "Payment Details";
            // 
            // uc_PaymentInfoCard1
            // 
            this.uc_PaymentInfoCard1.Location = new System.Drawing.Point(4, 48);
            this.uc_PaymentInfoCard1.Name = "uc_PaymentInfoCard1";
            this.uc_PaymentInfoCard1.Size = new System.Drawing.Size(991, 314);
            this.uc_PaymentInfoCard1.TabIndex = 141;
            // 
            // frmShowPaymentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 366);
            this.Controls.Add(this.uc_PaymentInfoCard1);
            this.Controls.Add(this.labTitleForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowPaymentDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Payment Details";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel labTitleForm;
        private uc_PaymentInfoCard uc_PaymentInfoCard1;
    }
}