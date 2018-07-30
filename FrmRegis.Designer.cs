namespace MoneyManager
{
    partial class FrmRegis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegis));
            this.Lbl_PassInfo = new System.Windows.Forms.Label();
            this.lblSampingID = new System.Windows.Forms.Label();
            this.lblSampingPass = new System.Windows.Forms.Label();
            this.lblQestionMark = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRetypePass = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCaptchaAnswer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblReType = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.checkboxSafetyQuestion = new System.Windows.Forms.CheckBox();
            this.btnCycle = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCaptcha = new System.Windows.Forms.TextBox();
            this.lblSampingEmail = new System.Windows.Forms.Label();
            this.checkBoxShowPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Lbl_PassInfo
            // 
            this.Lbl_PassInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_PassInfo.AutoSize = true;
            this.Lbl_PassInfo.ForeColor = System.Drawing.Color.Red;
            this.Lbl_PassInfo.Location = new System.Drawing.Point(470, 212);
            this.Lbl_PassInfo.Name = "Lbl_PassInfo";
            this.Lbl_PassInfo.Size = new System.Drawing.Size(85, 17);
            this.Lbl_PassInfo.TabIndex = 59;
            this.Lbl_PassInfo.Text = "Pass Wrong";
            this.Lbl_PassInfo.Visible = false;
            // 
            // lblSampingID
            // 
            this.lblSampingID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSampingID.AutoSize = true;
            this.lblSampingID.ForeColor = System.Drawing.Color.DimGray;
            this.lblSampingID.Location = new System.Drawing.Point(470, 155);
            this.lblSampingID.Name = "lblSampingID";
            this.lblSampingID.Size = new System.Drawing.Size(79, 17);
            this.lblSampingID.TabIndex = 58;
            this.lblSampingID.Text = "*MIN 6 digit";
            // 
            // lblSampingPass
            // 
            this.lblSampingPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSampingPass.AutoSize = true;
            this.lblSampingPass.ForeColor = System.Drawing.Color.DimGray;
            this.lblSampingPass.Location = new System.Drawing.Point(470, 184);
            this.lblSampingPass.Name = "lblSampingPass";
            this.lblSampingPass.Size = new System.Drawing.Size(79, 17);
            this.lblSampingPass.TabIndex = 57;
            this.lblSampingPass.Text = "*MIN 6 digit";
            // 
            // lblQestionMark
            // 
            this.lblQestionMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQestionMark.AutoSize = true;
            this.lblQestionMark.Enabled = false;
            this.lblQestionMark.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblQestionMark.Location = new System.Drawing.Point(533, 339);
            this.lblQestionMark.Name = "lblQestionMark";
            this.lblQestionMark.Size = new System.Drawing.Size(16, 17);
            this.lblQestionMark.TabIndex = 56;
            this.lblQestionMark.Text = "?";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAnswer.Enabled = false;
            this.txtAnswer.Location = new System.Drawing.Point(135, 363);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(394, 22);
            this.txtAnswer.TabIndex = 10;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuestion.Enabled = false;
            this.txtQuestion.Location = new System.Drawing.Point(135, 336);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(394, 22);
            this.txtQuestion.TabIndex = 9;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Enabled = false;
            this.lblAnswer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAnswer.Location = new System.Drawing.Point(9, 362);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(122, 17);
            this.lblAnswer.TabIndex = 51;
            this.lblAnswer.Text = "Answer                :";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Enabled = false;
            this.lblQuestion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblQuestion.Location = new System.Drawing.Point(9, 335);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(121, 17);
            this.lblQuestion.TabIndex = 50;
            this.lblQuestion.Text = "Qustion               :";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(302, 491);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 32);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRegister.BackColor = System.Drawing.Color.Silver;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Location = new System.Drawing.Point(206, 491);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(90, 32);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(135, 265);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(330, 22);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtRetypePass
            // 
            this.txtRetypePass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRetypePass.Location = new System.Drawing.Point(135, 209);
            this.txtRetypePass.Name = "txtRetypePass";
            this.txtRetypePass.PasswordChar = '*';
            this.txtRetypePass.Size = new System.Drawing.Size(330, 22);
            this.txtRetypePass.TabIndex = 7;
            this.txtRetypePass.TextChanged += new System.EventHandler(this.txtRetypePass_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(135, 181);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(330, 22);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtId.Location = new System.Drawing.Point(135, 152);
            this.txtId.MaxLength = 20;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(330, 22);
            this.txtId.TabIndex = 5;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            this.txtId.Leave += new System.EventHandler(this.txtId_Leave);
            // 
            // txtNama
            // 
            this.txtNama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNama.Location = new System.Drawing.Point(135, 122);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(330, 22);
            this.txtNama.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(117, 266);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 17);
            this.label11.TabIndex = 42;
            this.label11.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(117, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 17);
            this.label10.TabIndex = 41;
            this.label10.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(117, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 17);
            this.label9.TabIndex = 40;
            this.label9.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = ":";
            // 
            // txtCaptchaAnswer
            // 
            this.txtCaptchaAnswer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCaptchaAnswer.Location = new System.Drawing.Point(206, 463);
            this.txtCaptchaAnswer.Name = "txtCaptchaAnswer";
            this.txtCaptchaAnswer.Size = new System.Drawing.Size(167, 22);
            this.txtCaptchaAnswer.TabIndex = 11;
            this.txtCaptchaAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaptchaAnswer_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Write This Text Below :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(9, 265);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 34;
            this.lblEmail.Text = "Email";
            // 
            // lblReType
            // 
            this.lblReType.AutoSize = true;
            this.lblReType.Location = new System.Drawing.Point(8, 209);
            this.lblReType.Name = "lblReType";
            this.lblReType.Size = new System.Drawing.Size(88, 17);
            this.lblReType.TabIndex = 33;
            this.lblReType.Text = "Retype Pass";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(9, 183);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(69, 17);
            this.lblPass.TabIndex = 32;
            this.lblPass.Text = "Password";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(9, 152);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 31;
            this.lblID.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 122);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 30;
            this.lblName.Text = "Name";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(105, 413);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(95, 17);
            this.label21.TabIndex = 101;
            this.label21.Text = "Confirmation :";
            // 
            // checkboxSafetyQuestion
            // 
            this.checkboxSafetyQuestion.AutoSize = true;
            this.checkboxSafetyQuestion.Location = new System.Drawing.Point(11, 311);
            this.checkboxSafetyQuestion.Name = "checkboxSafetyQuestion";
            this.checkboxSafetyQuestion.Size = new System.Drawing.Size(191, 21);
            this.checkboxSafetyQuestion.TabIndex = 102;
            this.checkboxSafetyQuestion.Text = "Include a safety question.";
            this.checkboxSafetyQuestion.UseVisualStyleBackColor = true;
            this.checkboxSafetyQuestion.CheckedChanged += new System.EventHandler(this.checkboxSafetyQuestion_CheckedChanged);
            // 
            // btnCycle
            // 
            this.btnCycle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCycle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCycle.BackgroundImage")));
            this.btnCycle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCycle.Location = new System.Drawing.Point(377, 410);
            this.btnCycle.Name = "btnCycle";
            this.btnCycle.Size = new System.Drawing.Size(29, 22);
            this.btnCycle.TabIndex = 103;
            this.btnCycle.UseVisualStyleBackColor = true;
            this.btnCycle.Click += new System.EventHandler(this.btnCycle_Click);
            // 
            // label19
            // 
            this.label19.Dock = System.Windows.Forms.DockStyle.Top;
            this.label19.Font = new System.Drawing.Font("Ravie", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(0, 81);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(561, 19);
            this.label19.TabIndex = 105;
            this.label19.Text = "Your Worthy Money Manager";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.Dock = System.Windows.Forms.DockStyle.Top;
            this.label20.Font = new System.Drawing.Font("Ravie", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(0, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(561, 81);
            this.label20.TabIndex = 104;
            this.label20.Text = "E&&I";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCaptcha
            // 
            this.txtCaptcha.Enabled = false;
            this.txtCaptcha.ForeColor = System.Drawing.Color.Black;
            this.txtCaptcha.Location = new System.Drawing.Point(207, 410);
            this.txtCaptcha.Name = "txtCaptcha";
            this.txtCaptcha.Size = new System.Drawing.Size(167, 22);
            this.txtCaptcha.TabIndex = 106;
            this.txtCaptcha.Text = "{random captcha}";
            this.txtCaptcha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSampingEmail
            // 
            this.lblSampingEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSampingEmail.AutoSize = true;
            this.lblSampingEmail.ForeColor = System.Drawing.Color.DimGray;
            this.lblSampingEmail.Location = new System.Drawing.Point(470, 268);
            this.lblSampingEmail.Name = "lblSampingEmail";
            this.lblSampingEmail.Size = new System.Drawing.Size(0, 17);
            this.lblSampingEmail.TabIndex = 107;
            // 
            // checkBoxShowPass
            // 
            this.checkBoxShowPass.AutoSize = true;
            this.checkBoxShowPass.Location = new System.Drawing.Point(135, 237);
            this.checkBoxShowPass.Name = "checkBoxShowPass";
            this.checkBoxShowPass.Size = new System.Drawing.Size(129, 21);
            this.checkBoxShowPass.TabIndex = 108;
            this.checkBoxShowPass.Text = "Show Password";
            this.checkBoxShowPass.UseVisualStyleBackColor = true;
            this.checkBoxShowPass.CheckedChanged += new System.EventHandler(this.checkBoxShowPass_CheckedChanged);
            // 
            // FrmRegis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 530);
            this.Controls.Add(this.checkBoxShowPass);
            this.Controls.Add(this.lblSampingEmail);
            this.Controls.Add(this.txtCaptcha);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnCycle);
            this.Controls.Add(this.checkboxSafetyQuestion);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.Lbl_PassInfo);
            this.Controls.Add(this.lblSampingID);
            this.Controls.Add(this.lblSampingPass);
            this.Controls.Add(this.lblQestionMark);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtRetypePass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCaptchaAnswer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblReType);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmRegis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration Page";
            this.Load += new System.EventHandler(this.FrmRegis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_PassInfo;
        private System.Windows.Forms.Label lblSampingID;
        private System.Windows.Forms.Label lblSampingPass;
        private System.Windows.Forms.Label lblQestionMark;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtRetypePass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCaptchaAnswer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblReType;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox checkboxSafetyQuestion;
        private System.Windows.Forms.Button btnCycle;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtCaptcha;
        private System.Windows.Forms.Label lblSampingEmail;
        private System.Windows.Forms.CheckBox checkBoxShowPass;
    }
}