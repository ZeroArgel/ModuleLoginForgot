namespace LoginForgot.Views.Login
{
    partial class Forgot
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
            this.GBox_PanelForgot = new System.Windows.Forms.GroupBox();
            this.Btn_Recover = new System.Windows.Forms.Button();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.GBox_PanelRecover = new System.Windows.Forms.GroupBox();
            this.Pnl_NewPassword = new System.Windows.Forms.Panel();
            this.Lbl_ConfirmNewPassword = new System.Windows.Forms.Label();
            this.Lbl_NewPassword = new System.Windows.Forms.Label();
            this.Txt_ConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.Txt_NewPassword = new System.Windows.Forms.TextBox();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Verify = new System.Windows.Forms.Button();
            this.Txt_Code = new System.Windows.Forms.TextBox();
            this.Lbl_Code = new System.Windows.Forms.Label();
            this.Btn_ReturnLogin = new System.Windows.Forms.Button();
            this.GBox_PanelForgot.SuspendLayout();
            this.GBox_PanelRecover.SuspendLayout();
            this.Pnl_NewPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBox_PanelForgot
            // 
            this.GBox_PanelForgot.Controls.Add(this.Btn_Recover);
            this.GBox_PanelForgot.Controls.Add(this.Txt_Email);
            this.GBox_PanelForgot.Controls.Add(this.Lbl_Email);
            this.GBox_PanelForgot.Location = new System.Drawing.Point(12, 12);
            this.GBox_PanelForgot.Name = "GBox_PanelForgot";
            this.GBox_PanelForgot.Size = new System.Drawing.Size(210, 103);
            this.GBox_PanelForgot.TabIndex = 0;
            this.GBox_PanelForgot.TabStop = false;
            this.GBox_PanelForgot.Text = "Forgot";
            // 
            // Btn_Recover
            // 
            this.Btn_Recover.Location = new System.Drawing.Point(9, 67);
            this.Btn_Recover.Name = "Btn_Recover";
            this.Btn_Recover.Size = new System.Drawing.Size(192, 23);
            this.Btn_Recover.TabIndex = 2;
            this.Btn_Recover.Text = "Recover";
            this.Btn_Recover.UseVisualStyleBackColor = true;
            this.Btn_Recover.Click += new System.EventHandler(this.Btn_Recover_Click);
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(9, 41);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(192, 20);
            this.Txt_Email.TabIndex = 1;
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.Location = new System.Drawing.Point(6, 25);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Email.TabIndex = 0;
            this.Lbl_Email.Text = "Email:";
            // 
            // GBox_PanelRecover
            // 
            this.GBox_PanelRecover.Controls.Add(this.Pnl_NewPassword);
            this.GBox_PanelRecover.Controls.Add(this.Btn_Verify);
            this.GBox_PanelRecover.Controls.Add(this.Txt_Code);
            this.GBox_PanelRecover.Controls.Add(this.Lbl_Code);
            this.GBox_PanelRecover.Location = new System.Drawing.Point(12, 121);
            this.GBox_PanelRecover.Name = "GBox_PanelRecover";
            this.GBox_PanelRecover.Size = new System.Drawing.Size(210, 216);
            this.GBox_PanelRecover.TabIndex = 1;
            this.GBox_PanelRecover.TabStop = false;
            this.GBox_PanelRecover.Text = "Recover";
            // 
            // Pnl_NewPassword
            // 
            this.Pnl_NewPassword.Controls.Add(this.Lbl_ConfirmNewPassword);
            this.Pnl_NewPassword.Controls.Add(this.Lbl_NewPassword);
            this.Pnl_NewPassword.Controls.Add(this.Txt_ConfirmNewPassword);
            this.Pnl_NewPassword.Controls.Add(this.Txt_NewPassword);
            this.Pnl_NewPassword.Controls.Add(this.Btn_Save);
            this.Pnl_NewPassword.Location = new System.Drawing.Point(0, 96);
            this.Pnl_NewPassword.Name = "Pnl_NewPassword";
            this.Pnl_NewPassword.Size = new System.Drawing.Size(207, 114);
            this.Pnl_NewPassword.TabIndex = 4;
            // 
            // Lbl_ConfirmNewPassword
            // 
            this.Lbl_ConfirmNewPassword.AutoSize = true;
            this.Lbl_ConfirmNewPassword.Location = new System.Drawing.Point(3, 45);
            this.Lbl_ConfirmNewPassword.Name = "Lbl_ConfirmNewPassword";
            this.Lbl_ConfirmNewPassword.Size = new System.Drawing.Size(81, 13);
            this.Lbl_ConfirmNewPassword.TabIndex = 7;
            this.Lbl_ConfirmNewPassword.Text = "New Password:";
            // 
            // Lbl_NewPassword
            // 
            this.Lbl_NewPassword.AutoSize = true;
            this.Lbl_NewPassword.Location = new System.Drawing.Point(3, 1);
            this.Lbl_NewPassword.Name = "Lbl_NewPassword";
            this.Lbl_NewPassword.Size = new System.Drawing.Size(81, 13);
            this.Lbl_NewPassword.TabIndex = 3;
            this.Lbl_NewPassword.Text = "New Password:";
            // 
            // Txt_ConfirmNewPassword
            // 
            this.Txt_ConfirmNewPassword.Location = new System.Drawing.Point(3, 61);
            this.Txt_ConfirmNewPassword.Name = "Txt_ConfirmNewPassword";
            this.Txt_ConfirmNewPassword.Size = new System.Drawing.Size(195, 20);
            this.Txt_ConfirmNewPassword.TabIndex = 4;
            // 
            // Txt_NewPassword
            // 
            this.Txt_NewPassword.Location = new System.Drawing.Point(3, 17);
            this.Txt_NewPassword.Name = "Txt_NewPassword";
            this.Txt_NewPassword.Size = new System.Drawing.Size(195, 20);
            this.Txt_NewPassword.TabIndex = 3;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(115, 87);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(83, 23);
            this.Btn_Save.TabIndex = 5;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Verify
            // 
            this.Btn_Verify.Location = new System.Drawing.Point(118, 67);
            this.Btn_Verify.Name = "Btn_Verify";
            this.Btn_Verify.Size = new System.Drawing.Size(83, 23);
            this.Btn_Verify.TabIndex = 3;
            this.Btn_Verify.Text = "Verify";
            this.Btn_Verify.UseVisualStyleBackColor = true;
            this.Btn_Verify.Click += new System.EventHandler(this.Btn_Verify_Click);
            // 
            // Txt_Code
            // 
            this.Txt_Code.Location = new System.Drawing.Point(6, 41);
            this.Txt_Code.Name = "Txt_Code";
            this.Txt_Code.Size = new System.Drawing.Size(195, 20);
            this.Txt_Code.TabIndex = 2;
            // 
            // Lbl_Code
            // 
            this.Lbl_Code.AutoSize = true;
            this.Lbl_Code.Location = new System.Drawing.Point(6, 25);
            this.Lbl_Code.Name = "Lbl_Code";
            this.Lbl_Code.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Code.TabIndex = 0;
            this.Lbl_Code.Text = "Code:";
            // 
            // Btn_ReturnLogin
            // 
            this.Btn_ReturnLogin.Location = new System.Drawing.Point(139, 343);
            this.Btn_ReturnLogin.Name = "Btn_ReturnLogin";
            this.Btn_ReturnLogin.Size = new System.Drawing.Size(83, 23);
            this.Btn_ReturnLogin.TabIndex = 6;
            this.Btn_ReturnLogin.Text = "Return Login";
            this.Btn_ReturnLogin.UseVisualStyleBackColor = true;
            this.Btn_ReturnLogin.Click += new System.EventHandler(this.Btn_ReturnLogin_Click);
            // 
            // Forgot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 375);
            this.Controls.Add(this.Btn_ReturnLogin);
            this.Controls.Add(this.GBox_PanelRecover);
            this.Controls.Add(this.GBox_PanelForgot);
            this.Name = "Forgot";
            this.Text = "Forgot";
            this.GBox_PanelForgot.ResumeLayout(false);
            this.GBox_PanelForgot.PerformLayout();
            this.GBox_PanelRecover.ResumeLayout(false);
            this.GBox_PanelRecover.PerformLayout();
            this.Pnl_NewPassword.ResumeLayout(false);
            this.Pnl_NewPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBox_PanelForgot;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.Label Lbl_Email;
        private System.Windows.Forms.GroupBox GBox_PanelRecover;
        private System.Windows.Forms.Label Lbl_Code;
        private System.Windows.Forms.TextBox Txt_Code;
        private System.Windows.Forms.Button Btn_Recover;
        private System.Windows.Forms.TextBox Txt_NewPassword;
        private System.Windows.Forms.Label Lbl_NewPassword;
        private System.Windows.Forms.Button Btn_ReturnLogin;
        private System.Windows.Forms.Button Btn_Verify;
        private System.Windows.Forms.Label Lbl_ConfirmNewPassword;
        private System.Windows.Forms.TextBox Txt_ConfirmNewPassword;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Panel Pnl_NewPassword;
    }
}