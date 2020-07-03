namespace LoginForgot.Views.Login
{
    using LoginForgot.Core.RetrieveServices;
    using System;
    using System.Windows.Forms;
    public partial class Login : Form
    {
        // Services
        private RetriveServicesLogins RetriveServicesLogins_;

        public static string UserName = "";

        public Login()
        {
            InitializeComponent();
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            var register = new Register();
            Hide();
            register.ShowDialog();
            CleanForm();
            Show();
        }

        private void Btn_Forgot_Click(object sender, EventArgs e)
        {
            var forgot = new Forgot();
            Hide();
            forgot.ShowDialog();
            CleanForm();
            Show();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                Hide();
                var home = new Home();
                RetriveServicesLogins_ = new RetriveServicesLogins();
                UserName = RetriveServicesLogins_.Login(Txt_User.Text, Txt_Password.Text);
                home.ShowDialog();
                CleanForm();
                Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Show();
            }
            finally
            {
                RetriveServicesLogins_ = null;
            }
            
        }
        private void CleanForm()
        {
            Txt_User.Text = "";
            Txt_Password.Text = "";
            UserName = "";
        }
    }
}