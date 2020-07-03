using LoginForgot.DataAccess.DBCore.CRUD;
using System;

namespace LoginForgot.Core.WriteServices
{
    public class WriteServicesLogins
    {
        private Create Create_;
        public WriteServicesLogins()
        {
            Create_ = new Create();
        }
        public void Register(string userName, string email, string password, string confirmPassword, string cellPhone)
        {
            ThrowErrors(userName, email, password, cellPhone, confirmPassword);
            Create_.CreateDB(userName.CreateModelUser(password.ToHash(), 0, email, cellPhone));
        }
        private void ThrowErrors(string userName, string email, string password, string cellPhone, string confirmPassword=null)
        {
            if (confirmPassword != password) throw new Exception("Password not coincide with Confirm Password");
            if (userName.IsEmpty()) throw new Exception("UserName is Empty");
            if (email.IsEmpty()) throw new Exception("Email is Empty");
            if (email.IsValidEmail()) throw new Exception("Email hasn't correct format");
            if (password.IsEmpty()) throw new Exception("Password is Empty");
            if (cellPhone.IsEmpty()) throw new Exception("Cellphone is Empty");
        }
        ~WriteServicesLogins()
        {
            Create_ = null;
        }
    }
}