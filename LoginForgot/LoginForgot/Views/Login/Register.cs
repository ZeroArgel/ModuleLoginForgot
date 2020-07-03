using LoginForgot.Core.WriteServices;
using System;
using System.Windows.Forms;

namespace LoginForgot.Views.Login
{
    public partial class Register : Form
    {
        private WriteServicesLogins WriteServicesLogins_;
        public Register()
        {
            InitializeComponent();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                WriteServicesLogins_ = new WriteServicesLogins();
                WriteServicesLogins_.Register(Txt_UserName.Text, Txt_Email.Text, Txt_Password.Text, Txt_ConfirmPassword.Text, Txt_Cellphone.Text);
                CleanForm();
                MessageBox.Show("User Create, Login now");
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
            Txt_UserName.Text = "";
            Txt_Email.Text = "";
            Txt_ConfirmPassword.Text = "";
            Txt_Password.Text = "";
            Txt_Cellphone.Text = "";
        }
    }
}