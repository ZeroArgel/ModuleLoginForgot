namespace LoginForgot.DataAccess.DBCore.CRUD
{
    using LoginForgot.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Read
    {
        private LoginForgotEntities LoginForgotEntities_;
        public Read()
        {
            LoginForgotEntities_ = new LoginForgotEntities();
        }
        public User ReadUserToLogin(User user) 
        {
            var Users = LoginForgotEntities_.GetUserToLogin(user.UserName, user.Password).ToList();
            return Users.MiddleT<GetUserToLogin_Result, User>().FirstOrDefault();
        }
        public User ReadUserWithEmail(User user)
        {
            var Users = LoginForgotEntities_.GetUserByEmail(user.Email).ToList();
            return Users.MiddleT<GetUserByEmail_Result, User>().FirstOrDefault();
        }
        public IEnumerable<GenericKeyValue> ReadAllCountryPhonesToCombo()
        {
            var Countries = LoginForgotEntities_.GetAllCountryPhonesToCombo().ToList();
            return Countries.MiddleT<GetAllCountryPhonesToCombo_Result, GenericKeyValue>();
        }
        public Forgot ValidByEmail(string email)
        {
            var forgot = LoginForgotEntities_.GetCodeToForgot(email).ToList();
            return forgot.MiddleT<GetCodeToForgot_Result, Forgot>().FirstOrDefault();
        }
        public bool ValidCode(string code)
        {
            var result = LoginForgotEntities_.GetCodeValid(code).FirstOrDefault();
            if (result == null) return false;
            return true;
        }
        ~Read()
        {
            LoginForgotEntities_.Dispose();
            LoginForgotEntities_ = null;
        }
    }
}