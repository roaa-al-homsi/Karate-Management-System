namespace KarateSystem.Instructors
{
    partial class frmAddUpdateInstructor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateInstructor));
            this.tcInstructor = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.uc_PersonInfoWithFilter1 = new KarateSystem.People.uc_Controls.uc_PersonInfoWithFilter();
            this.tpInstructorInfo = new System.Windows.Forms.TabPage();
            this.panelContainerMemberInfo = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.txtQualifications = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.picInstructor = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.labInstructorId = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labMember = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labTitleForm = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tcInstructor.SuspendLayout();
            this.tpPersonInfo.SuspendLayout();
            this.tpInstructorInfo.SuspendLayout();
            this.panelContainerMemberInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInstructor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcInstructor
            // 
            this.tcInstructor.Controls.Add(this.tpPersonInfo);
            this.tcInstructor.Controls.Add(this.tpInstructorInfo);
            this.tcInstructor.ItemSize = new System.Drawing.Size(180, 40);
            this.tcInstructor.Location = new System.Drawing.Point(16, 62);
            this.tcInstructor.Name = "tcInstructor";
            this.tcInstructor.SelectedIndex = 0;
            this.tcInstructor.Size = new System.Drawing.Size(847, 648);
            this.tcInstructor.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcInstructor.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcInstructor.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcInstructor.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcInstructor.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcInstructor.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcInstructor.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcInstructor.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcInstructor.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tcInstructor.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcInstructor.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcInstructor.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tcInstructor.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcInstructor.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcInstructor.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tcInstructor.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tcInstructor.TabIndex = 135;
            this.tcInstructor.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcInstructor.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpPersonInfo
            // 
            this.tpPersonInfo.Controls.Add(this.btnNext);
            this.tpPersonInfo.Controls.Add(this.uc_PersonInfoWithFilter1);
            this.tpPersonInfo.Location = new System.Drawing.Point(4, 44);
            this.tpPersonInfo.Name = "tpPersonInfo";
            this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonInfo.Size = new System.Drawing.Size(839, 600);
            this.tpPersonInfo.TabIndex = 0;
            this.tpPersonInfo.Text = "Person";
            this.tpPersonInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.AutoRoundedCorners = true;
            this.btnNext.BorderRadius = 21;
            this.btnNext.CheckedState.CustomBorderColor = System.Drawing.Color.HotPink;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.Black;
            this.btnNext.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.HoverState.CustomBorderColor = System.Drawing.Color.HotPink;
            this.btnNext.Location = new System.Drawing.Point(344, 543);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 45);
            this.btnNext.TabIndex = 129;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // uc_PersonInfoWithFilter1
            // 
            this.uc_PersonInfoWithFilter1.FilterEnable = true;
            this.uc_PersonInfoWithFilter1.Location = new System.Drawing.Point(42, 0);
            this.uc_PersonInfoWithFilter1.Name = "uc_PersonInfoWithFilter1";
            this.uc_PersonInfoWithFilter1.ShowAddPerson = true;
            this.uc_PersonInfoWithFilter1.Size = new System.Drawing.Size(729, 528);
            this.uc_PersonInfoWithFilter1.TabIndex = 0;
            // 
            // tpInstructorInfo
            // 
            this.tpInstructorInfo.Controls.Add(this.panelContainerMemberInfo);
            this.tpInstructorInfo.Location = new System.Drawing.Point(4, 44);
            this.tpInstructorInfo.Name = "tpInstructorInfo";
            this.tpInstructorInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpInstructorInfo.Size = new System.Drawing.Size(839, 600);
            this.tpInstructorInfo.TabIndex = 1;
            this.tpInstructorInfo.Text = "Instructor";
            this.tpInstructorInfo.UseVisualStyleBackColor = true;
            // 
            // panelContainerMemberInfo
            // 
            this.panelContainerMemberInfo.BorderColor = System.Drawing.Color.White;
            this.panelContainerMemberInfo.Controls.Add(this.txtQualifications);
            this.panelContainerMemberInfo.Controls.Add(this.guna2HtmlLabel2);
            this.panelContainerMemberInfo.Controls.Add(this.picInstructor);
            this.panelContainerMemberInfo.Controls.Add(this.labInstructorId);
            this.panelContainerMemberInfo.Controls.Add(this.labMember);
            this.panelContainerMemberInfo.FillColor = System.Drawing.Color.White;
            this.panelContainerMemberInfo.Location = new System.Drawing.Point(182, 3);
            this.panelContainerMemberInfo.Name = "panelContainerMemberInfo";
            this.panelContainerMemberInfo.Size = new System.Drawing.Size(512, 505);
            this.panelContainerMemberInfo.TabIndex = 151;
            // 
            // txtQualifications
            // 
            this.txtQualifications.Animated = true;
            this.txtQualifications.AutoRoundedCorners = true;
            this.txtQualifications.BackColor = System.Drawing.Color.Transparent;
            this.txtQualifications.BorderRadius = 49;
            this.txtQualifications.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQualifications.DefaultText = "";
            this.txtQualifications.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQualifications.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQualifications.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQualifications.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQualifications.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtQualifications.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQualifications.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQualifications.ForeColor = System.Drawing.Color.Black;
            this.txtQualifications.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQualifications.Location = new System.Drawing.Point(99, 383);
            this.txtQualifications.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQualifications.Name = "txtQualifications";
            this.txtQualifications.PlaceholderText = "";
            this.txtQualifications.SelectedText = "";
            this.txtQualifications.Size = new System.Drawing.Size(310, 100);
            this.txtQualifications.TabIndex = 159;
            this.txtQualifications.Validating += new System.ComponentModel.CancelEventHandler(this.txtQualifications_Validating);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(168, 340);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(179, 36);
            this.guna2HtmlLabel2.TabIndex = 158;
            this.guna2HtmlLabel2.Text = "Qualifications:";
            // 
            // picInstructor
            // 
            this.picInstructor.BackColor = System.Drawing.Color.Transparent;
            this.picInstructor.FillColor = System.Drawing.Color.DimGray;
            this.picInstructor.Image = ((System.Drawing.Image)(resources.GetObject("picInstructor.Image")));
            this.picInstructor.ImageRotate = 0F;
            this.picInstructor.Location = new System.Drawing.Point(130, 5);
            this.picInstructor.Name = "picInstructor";
            this.picInstructor.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picInstructor.Size = new System.Drawing.Size(217, 200);
            this.picInstructor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInstructor.TabIndex = 157;
            this.picInstructor.TabStop = false;
            // 
            // labInstructorId
            // 
            this.labInstructorId.AutoSize = false;
            this.labInstructorId.BackColor = System.Drawing.Color.Transparent;
            this.labInstructorId.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labInstructorId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labInstructorId.Location = new System.Drawing.Point(280, 263);
            this.labInstructorId.Name = "labInstructorId";
            this.labInstructorId.Size = new System.Drawing.Size(95, 32);
            this.labInstructorId.TabIndex = 146;
            this.labInstructorId.Text = "??";
            this.labInstructorId.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labMember
            // 
            this.labMember.AutoSize = false;
            this.labMember.BackColor = System.Drawing.Color.Transparent;
            this.labMember.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMember.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labMember.Location = new System.Drawing.Point(117, 263);
            this.labMember.Name = "labMember";
            this.labMember.Size = new System.Drawing.Size(157, 32);
            this.labMember.TabIndex = 154;
            this.labMember.Text = "Instructor Id:";
            // 
            // btnSave
            // 
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BorderRadius = 21;
            this.btnSave.CheckedState.CustomBorderColor = System.Drawing.Color.HotPink;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.Black;
            this.btnSave.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.CustomBorderColor = System.Drawing.Color.HotPink;
            this.btnSave.Location = new System.Drawing.Point(266, 716);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 45);
            this.btnSave.TabIndex = 133;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoRoundedCorners = true;
            this.btnCancel.BorderRadius = 21;
            this.btnCancel.CheckedState.CustomBorderColor = System.Drawing.Color.HotPink;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.Black;
            this.btnCancel.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.CustomBorderColor = System.Drawing.Color.HotPink;
            this.btnCancel.Location = new System.Drawing.Point(447, 716);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 45);
            this.btnCancel.TabIndex = 134;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // labTitleForm
            // 
            this.labTitleForm.AutoSize = false;
            this.labTitleForm.BackColor = System.Drawing.Color.Transparent;
            this.labTitleForm.Font = new System.Drawing.Font("Andalus", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitleForm.ForeColor = System.Drawing.Color.Maroon;
            this.labTitleForm.Location = new System.Drawing.Point(266, 12);
            this.labTitleForm.Name = "labTitleForm";
            this.labTitleForm.Size = new System.Drawing.Size(379, 44);
            this.labTitleForm.TabIndex = 132;
            this.labTitleForm.Text = "Add a Instructor";
            // 
            // frmAddUpdateInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 773);
            this.Controls.Add(this.tcInstructor);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.labTitleForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUpdateInstructor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddUpdateInstructor";
            this.Load += new System.EventHandler(this.frmAddUpdateInstructor_Load);
            this.tcInstructor.ResumeLayout(false);
            this.tpPersonInfo.ResumeLayout(false);
            this.tpInstructorInfo.ResumeLayout(false);
            this.panelContainerMemberInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picInstructor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tcInstructor;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private People.uc_Controls.uc_PersonInfoWithFilter uc_PersonInfoWithFilter1;
        private System.Windows.Forms.TabPage tpInstructorInfo;
        private Guna.UI2.WinForms.Guna2GradientPanel panelContainerMemberInfo;
        private Guna.UI2.WinForms.Guna2TextBox txtQualifications;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picInstructor;
        private Guna.UI2.WinForms.Guna2HtmlLabel labInstructorId;
        private Guna.UI2.WinForms.Guna2HtmlLabel labMember;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2HtmlLabel labTitleForm;
    }
}