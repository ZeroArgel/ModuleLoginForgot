using LoginForgot.DataAccess.DBCore.CRUD;
using System;

namespace LoginForgot.Core.RetrieveServices
{
    public class RetriveServicesLogins
    {
        private Read Read_;
        public RetriveServicesLogins()
        {
            Read_ = new Read();
        }
        public string Login(string user, string password)
        {
            ThrowErrors(user, password);
            var User = Read_.ReadUserToLogin(user.CreateModelUser(password.ToHash()));
            if (User == null) throw new Exception("Not exist this UserName or Email");
            return User.UserName;
        }
        private void ThrowErrors(string user, string password)
        {
            if (user.IsEmpty()) throw new Exception("UserName is Empty");
            if (password.IsEmpty()) throw new Exception("Password is Empty");
        }
        ~RetriveServicesLogins()
        {
            Read_ = null;
        }
    }
}