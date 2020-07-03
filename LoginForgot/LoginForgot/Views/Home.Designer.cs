namespace LoginForgot
{
    using LoginForgot.Views.Login;
    partial class Home
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
            this.GBox_Home = new System.Windows.Forms.GroupBox();
            this.Lbl_UserName = new System.Windows.Forms.Label();
            this.GBox_Home.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBox_Home
            // 
            this.GBox_Home.Controls.Add(this.Lbl_UserName);
            this.GBox_Home.Location = new System.Drawing.Point(12, 12);
            this.GBox_Home.Name = "GBox_Home";
            this.GBox_Home.Size = new System.Drawing.Size(570, 333);
            this.GBox_Home.TabIndex = 0;
            this.GBox_Home.TabStop = false;
            this.GBox_Home.Text = "Home";
            // 
            // Lbl_UserName
            // 
            this.Lbl_UserName.AutoSize = true;
            this.Lbl_UserName.Location = new System.Drawing.Point(17, 20);
            this.Lbl_UserName.Name = "Lbl_UserName";
            this.Lbl_UserName.Size = new System.Drawing.Size(77, 13);
            this.Lbl_UserName.TabIndex = 0;
            this.Lbl_UserName.Text = Login.UserName;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 355);
            this.Controls.Add(this.GBox_Home);
            this.Name = "Home";
            this.Text = "Home";
            this.GBox_Home.ResumeLayout(false);
            this.GBox_Home.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBox_Home;
        private System.Windows.Forms.Label Lbl_UserName;
    }
}