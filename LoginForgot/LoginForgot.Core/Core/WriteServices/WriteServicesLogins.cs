namespace LoginForgot.Core
{
    #region usings.
    using System;
    using DataAccess.Interfaces;
    using Interfaces;
    using Models;
    using ZAExtensions;
    #endregion
    public class WriteServicesLogins : IWriteServicesLogins
    {
        private readonly IServicesCreate _IServicesCreate;
        private readonly IServicesUpdate _IServicesUpdate;
        private readonly IRetrieveServicesAdmin _IRetrieveServicesAdmin;
        public WriteServicesLogins(IServicesCreate iServicesCreate, 
            IServicesUpdate iServicesUpdate,
            IRetrieveServicesAdmin iRetrieveServicesAdmin)
        {
            _IServicesCreate = iServicesCreate;
            _IServicesUpdate = iServicesUpdate;
            _IRetrieveServicesAdmin = iRetrieveServicesAdmin;
        }
        public void Register(string userName, string email, string password, string confirmPassword, string cellPhone)
        {
            if (confirmPassword != password) throw new ArgumentException("Password not coincide with Confirm Password");
            if (userName.IsEmpty()) throw new ArgumentException("UserName is Empty");
            if (email.IsEmpty()) throw new ArgumentException("Email is Empty");
            if (email.IsValidEmail()) throw new ArgumentException("Email hasn't correct format");
            if (password.IsEmpty()) throw new ArgumentException("Password is Empty");
            if (cellPhone.IsEmpty()) throw new ArgumentException("Cellphone is Empty");

            var user = new User()
            {
                UserName = userName,
                Email = email,
                CellPhone = cellPhone,
                Password = password.ToHash()
            };
            _IServicesCreate.AddUser(user);
        }
        public void NewPassword(string email, string newPassword, string confirmNewPassword)
        {
            if (confirmNewPassword != newPassword) throw new ArgumentException("Password not coincide with Confirm Password");
            if (email.IsEmpty()) throw new ArgumentException("Email is Empty");
            if (email.IsValidEmail()) throw new ArgumentException("Email hasn't correct format");
            if (newPassword.IsEmpty()) throw new ArgumentException("Password is Empty");

            var User = _IRetrieveServicesAdmin.GetUserByEmail(email);
            if (User == null) throw new ArgumentException($"{email} not exist, please contact with administrator");

            _IServicesUpdate.ChangePassword(User.UserId, newPassword.ToHash());
        }
    }
}