namespace LoginForgot.Core
{
    #region using.
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using DataAccess.Interfaces;
    using Interfaces;
    using Models;
    using ZAExtensions;
    #endregion
    public class RetrieveServicesLogins : IRetrieveServicesLogins
    {
        private readonly IServicesRead _IServicesRead;
        public RetrieveServicesLogins(IServicesRead iServicesRead) => _IServicesRead = iServicesRead;
        public IEnumerable<GenericKeyValue> GetCountryForCombobox() => _IServicesRead.ReadAllCountryPhonesToCombo().ToList();
        public string Login(string userName, string password)
        {
            if (userName.IsEmpty()) throw new ArgumentException("UserName is Empty");
            if (password.IsEmpty()) throw new ArgumentException("Password is Empty");

            var User = _IServicesRead.ReadUserToLogin(new User(userName, password.ToHash()));
            if (User == null) throw new ArgumentException("Not exist this UserName or Email");
            return User.UserName;
        }
        public string RecoverByEmail(string email)
        {
            if (email.IsEmpty()) throw new ArgumentException("Email is Empty");
            var code = _IServicesRead.ValidByEmail(email);
            code.CellPhone.SendMsg(code.Code);
            return code.CellPhone;
        }
        public void ValidCode(string code)
        {
            if (code.IsEmpty()) throw new ArgumentException("Code is Empty");
            _IServicesRead.ValidCode(code);
        }
    }
}