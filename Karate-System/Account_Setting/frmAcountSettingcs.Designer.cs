namespace KarateSystem.Account_Setting
{
    partial class frmAccountSettingcs
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
            this.btnCurrentUserInfo = new Guna.UI2.WinForms.Guna2Button();
            this.btnChangePassword = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // btnCurrentUserInfo
            // 
            this.btnCurrentUserInfo.AutoRoundedCorners = true;
            this.btnCurrentUserInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnCurrentUserInfo.BorderColor = System.Drawing.Color.White;
            this.btnCurrentUserInfo.BorderThickness = 1;
            this.btnCurrentUserInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCurrentUserInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCurrentUserInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCurrentUserInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCurrentUserInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.btnCurrentUserInfo.Font = new System.Drawing.Font("Algerian", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrentUserInfo.ForeColor = System.Drawing.Color.White;
            this.btnCurrentUserInfo.HoverState.FillColor = System.Drawing.Color.LightSteelBlue;
            this.btnCurrentUserInfo.Location = new System.Drawing.Point(12, 122);
            this.btnCurrentUserInfo.Name = "btnCurrentUserInfo";
            this.btnCurrentUserInfo.Size = new System.Drawing.Size(244, 45);
            this.btnCurrentUserInfo.TabIndex = 0;
            this.btnCurrentUserInfo.Text = "Current User Info";
            this.btnCurrentUserInfo.UseTransparentBackground = true;
            this.btnCurrentUserInfo.Click += new System.EventHandler(this.btnCurrentUserInfo_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.AutoRoundedCorners = true;
            this.btnChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.btnChangePassword.BorderColor = System.Drawing.Color.White;
            this.btnChangePassword.BorderThickness = 1;
            this.btnChangePassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChangePassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChangePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChangePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChangePassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.btnChangePassword.Font = new System.Drawing.Font("Algerian", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.HoverState.FillColor = System.Drawing.Color.LightSteelBlue;
            this.btnChangePassword.Location = new System.Drawing.Point(281, 122);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(244, 45);
            this.btnChangePassword.TabIndex = 1;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseTransparentBackground = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(126, 23);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(289, 38);
            this.guna2HtmlLabel1.TabIndex = 51;
            this.guna2HtmlLabel1.Text = "Account Settings";
            // 
            // frmAccountSettingcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 241);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnCurrentUserInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAccountSettingcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnCurrentUserInfo;
        private Guna.UI2.WinForms.Guna2Button btnChangePassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}