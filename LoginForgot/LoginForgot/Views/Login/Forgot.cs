namespace LoginForgot.Views.Login
{
    using System;
    using System.Windows.Forms;
    using Interfaces;
    public partial class Forgot : Form
    {
        // Services.
        private readonly IRetrieveServicesLogins _IRetrieveServicesLogins;
        private readonly IWriteServicesLogins _IWriteServicesLogins;

        public Forgot(IRetrieveServicesLogins iRetrieveServicesLogins, IWriteServicesLogins iWriteServicesLogins)
        {
            InitializeComponent();
            _IRetrieveServicesLogins = iRetrieveServicesLogins;
            _IWriteServicesLogins = iWriteServicesLogins;
            CleanForm();
            GBox_PanelRecover.Enabled = false;
            Pnl_NewPassword.Enabled = false;
        }
        #region Btn_Recover_Click
        private void Btn_Recover_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Send Code to " + _IRetrieveServicesLogins.RecoverByEmail(Txt_Email.Text));
                GBox_PanelRecover.Enabled = true;
                GBox_PanelForgot.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Btn_Verify_Click
        private void Btn_Verify_Click(object sender, EventArgs e)
        {
            try
            {
                _IRetrieveServicesLogins.ValidCode(Txt_Code.Text);
                Pnl_NewPassword.Enabled = true;
                Txt_Code.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Btn_Save_Click
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                _IWriteServicesLogins.NewPassword(Txt_Email.Text, Txt_NewPassword.Text, Txt_ConfirmNewPassword.Text);
                MessageBox.Show("Password Reset. Try login again");
                CleanForm();
                Dispose();
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region CleanForm
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
        #endregion
        #region Btn_ReturnLogin_Click
        private void Btn_ReturnLogin_Click(object sender, EventArgs e)
        {
            CleanForm();
            Dispose();
            Close();
        }
        #endregion
    }
}