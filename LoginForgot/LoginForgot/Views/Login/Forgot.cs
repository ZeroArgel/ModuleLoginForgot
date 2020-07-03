using LoginForgot.Core;
using LoginForgot.Core.WriteServices;
using System;
using System.Windows.Forms;

namespace LoginForgot.Views.Login
{
    public partial class Forgot : Form
    {
        // Services.
        private WriteServicesSendSMS WriteServicesSendSMS_;

        public Forgot()
        {
            InitializeComponent();
        }

        private void Btn_Recover_Click(object sender, EventArgs e)
        {
            try
            {
                WriteServicesSendSMS_ = new WriteServicesSendSMS();
                var text = WriteServicesSendSMS_.SendSMS(Txt_Email.Text, "");
                MessageBox.Show(text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                WriteServicesSendSMS_ = null;
            }
        }
    }
}
