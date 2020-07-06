using LoginForgot.Core.RetrieveServices;
using LoginForgot.Core.WriteServices;
using LoginForgot.Models;
using System;
using System.Windows.Forms;

namespace LoginForgot.Views.Login
{
    public partial class Register : Form
    {
        // Services.
        private WriteServicesLogins WriteServicesLogins_;
        private RetriveServicesLogins RetriveServicesLogins_;

        public Register()
        {
            InitializeComponent();
            InitCbx_Code();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                WriteServicesLogins_ = new WriteServicesLogins();
                WriteServicesLogins_.Register(Txt_UserName.Text, Txt_Email.Text, Txt_Password.Text, Txt_ConfirmPassword.Text, Cbx_Code.SelectedValue + Txt_Cellphone.Text);
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
        private void InitCbx_Code()
        {
            try 
            { 
                RetriveServicesLogins_ = new RetriveServicesLogins();
                var listCode = RetriveServicesLogins_.GetCountryForCombobox();
                Cbx_Code.DisplayMember = "Value";
                Cbx_Code.ValueMember = "Key";
                Cbx_Code.DataSource = listCode;
            }
            finally
            {
                RetriveServicesLogins_ = null;
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

        private void Btn_ReturnLogin_Click(object sender, EventArgs e)
        {
            CleanForm();
            Dispose();
            Close();
        }
    }
}