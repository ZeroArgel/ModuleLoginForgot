namespace LoginForgot.DataAccess.DBCore.CRUD
{
    using LoginForgot.Models;
    using System.Linq;
    public class Read
    {
        private LoginForgotEntities LoginForgotEntities_;
        public Read()
        {

        }
        public User ReadUserToLogin(User user) 
        {
            LoginForgotEntities_ = new LoginForgotEntities();
            var Users = LoginForgotEntities_.GetUserToLogin(user.UserName, user.Password).ToList();
            return Users.MiddleT<GetUserToLogin_Result, User>().FirstOrDefault();
        }
        ~Read()
        {
            LoginForgotEntities_ = null;
        }
    }
}