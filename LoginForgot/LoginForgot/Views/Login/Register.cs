namespace LoginForgot.Views.Login
{
    using System;
    using System.Windows.Forms;
    using Interfaces;
    public partial class Register : Form
    {
        // Services.
        private readonly IRetrieveServicesLogins _IRetrieveServicesLogins;
        private readonly IWriteServicesLogins _IWriteServicesLogins;

        public Register(IRetrieveServicesLogins iRetrieveServicesLogins, IWriteServicesLogins iWriteServicesLogins)
        {
            InitializeComponent();
            _IRetrieveServicesLogins = iRetrieveServicesLogins;
            _IWriteServicesLogins = iWriteServicesLogins;
            InitCbx_Code();
        }
        #region Btn_Save_Click
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                _IWriteServicesLogins.Register(Txt_UserName.Text, Txt_Email.Text, Txt_Password.Text, Txt_ConfirmPassword.Text, Cbx_Code.SelectedValue + Txt_Cellphone.Text);
                CleanForm();
                MessageBox.Show("User Create, Login now");
                Close();
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region InitCbx_Code
        private void InitCbx_Code()
        {
            try 
            { 
                var listCode = _IRetrieveServicesLogins.GetCountryForCombobox();
                Cbx_Code.DisplayMember = "Value";
                Cbx_Code.ValueMember = "Key";
                Cbx_Code.DataSource = listCode;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region CleanForm
        private void CleanForm()
        {
            Txt_UserName.Text = "";
            Txt_Email.Text = "";
            Txt_ConfirmPassword.Text = "";
            Txt_Password.Text = "";
            Txt_Cellphone.Text = "";
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