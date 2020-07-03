namespace LoginForgot.DataAccess.DBCore.CRUD
{
    using LoginForgot.Models;
    public class Create
    {
        private LoginForgotEntities LoginForgotEntities_;
        public Create()
        {
            LoginForgotEntities_ = new LoginForgotEntities();
        }
        public void CreateDB(User user) => LoginForgotEntities_.AddUser(user.UserName, user.Email, user.Password, user.CellPhone);
        ~Create()
        {
            LoginForgotEntities_ = null;
        }
    }
}