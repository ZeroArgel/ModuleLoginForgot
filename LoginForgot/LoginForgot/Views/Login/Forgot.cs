namespace LoginForgot.Views.Login
{
    using LoginForgot.Core.RetrieveServices;
    using LoginForgot.Core.WriteServices;
    using System;
    using System.Windows.Forms;
    public partial class Forgot : Form
    {
        // Services.
        private RetriveServicesLogins RetriveServicesLogins_;
        private WriteServicesLogins WriteServicesLogins_;
        public Forgot()
        {
            InitializeComponent();
            CleanForm();
            GBox_PanelRecover.Enabled = false;
            Pnl_NewPassword.Enabled = false;
        }
        private void Btn_Recover_Click(object sender, EventArgs e)
        {
            try
            {
                RetriveServicesLogins_ = new RetriveServicesLogins();
                MessageBox.Show("Send Code to " + RetriveServicesLogins_.RecoverByEmail(Txt_Email.Text));
                GBox_PanelRecover.Enabled = true;
                GBox_PanelForgot.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                RetriveServicesLogins_ = null;
            }
        }
        private void Btn_Verify_Click(object sender, EventArgs e)
        {
            try
            {
                RetriveServicesLogins_ = new RetriveServicesLogins();
                RetriveServicesLogins_.ValidCode(Txt_Code.Text);
                Pnl_NewPassword.Enabled = true;
                Txt_Code.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                RetriveServicesLogins_ = null;
            }
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                WriteServicesLogins_ = new WriteServicesLogins();
                WriteServicesLogins_.NewPassword(Txt_Email.Text, Txt_NewPassword.Text, Txt_ConfirmNewPassword.Text);
                MessageBox.Show("Password Reset. Try login again");
                CleanForm();
                Dispose();
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                WriteServicesLogins_ = null;
            }
        }
        private void CleanForm()
        {
            Txt_Email.Text = "";
            Txt_Code.Text = "";
            Txt_NewPassword.Text = "";
            Txt_ConfirmNewPassword.Text = "";
            Txt_Code.Enabled = true;
            GBox_PanelForgot.Enabled = true;
            GBox_PanelRecover.Enabled = false;
            Pnl_NewPassword.Enabled = false;
        }
        private void Btn_ReturnLogin_Click(object sender, EventArgs e)
        {
            CleanForm();
            Dispose();
            Close();
        }
    }
}