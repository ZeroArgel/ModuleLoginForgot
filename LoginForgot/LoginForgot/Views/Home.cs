namespace LoginForgot
{
    using LoginForgot.Views.Login;
    using System.Windows.Forms;
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            Lbl_UserName.Text = Login.UserName;
        }
    }
}
