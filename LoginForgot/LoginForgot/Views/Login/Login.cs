namespace LoginForgot.Views.Login
{
    using System;
    using System.Windows.Forms;
    using Interfaces;
    public partial class Login : Form
    {
        // Services
        private readonly IRetrieveServicesLogins _IRetrieveServicesLogins;
        private readonly IWriteServicesLogins _IWriteServicesLogins;
        public static string UserName = "";

        public Login(IRetrieveServicesLogins iRetrieveServicesLogins, IWriteServicesLogins iWriteServicesLogins)
        {
            InitializeComponent();
            _IRetrieveServicesLogins = iRetrieveServicesLogins;
            _IWriteServicesLogins = iWriteServicesLogins;
        }
        #region Btn_Register_Click
        private void Btn_Register_Click(object sender, EventArgs e)
        {
            var register = new Register(_IRetrieveServicesLogins, _IWriteServicesLogins);
            Hide();
            register.ShowDialog();
            CleanForm();
            Show();
        }
        #endregion
        #region Btn_Forgot_Clickd
        private void Btn_Forgot_Click(object sender, EventArgs e)
        {
            var forgot = new Forgot(_IRetrieveServicesLogins, _IWriteServicesLogins);
            Hide();
            forgot.ShowDialog();
            CleanForm();
            Show();
        }
        #endregion
        #region Btn_Login_Click
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                Hide();
                var home = new Home();
                UserName = _IRetrieveServicesLogins.Login(Txt_User.Text, Txt_Password.Text);
                home.ShowDialog();
                CleanForm();
                Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Show();
            }
        }
        #endregion
        private void CleanForm()
        {
            Txt_User.Text = "";
            Txt_Password.Text = "";
            UserName = "";
        }
    }
}