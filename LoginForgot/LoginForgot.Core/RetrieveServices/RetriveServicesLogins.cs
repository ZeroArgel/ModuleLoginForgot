using LoginForgot.DataAccess.DBCore;
using LoginForgot.DataAccess.DBCore.CRUD;
using LoginForgot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Rest.Api.V2010;

namespace LoginForgot.Core.RetrieveServices
{
    public class RetriveServicesLogins
    {
        private Read Read_;
        public RetriveServicesLogins() => Read_ = new Read();
        public IEnumerable<GenericKeyValue> GetCountryForCombobox() => Read_.ReadAllCountryPhonesToCombo().ToList();
        
        public string Login(string user, string password)
        {
            ThrowErrors(user, password);
            var User = Read_.ReadUserToLogin(user.CreateModelUser(password.ToHash()));
            if (User == null) throw new Exception("Not exist this UserName or Email");
            return User.UserName;
        }
        public string RecoverByEmail(string email)
        {
            if (email.IsEmpty()) throw new Exception("Email is Empty");
            var code = Read_.ValidByEmail(email);
            code.CellPhone.SendMsg(code.Code);
            return code.CellPhone;
        }
        public void ValidCode(string code)
        {
            if (code.IsEmpty()) throw new Exception("Code is Empty");
            Read_.ValidCode(code);
        }
        private void ThrowErrors(string user, string password)
        {
            if (user.IsEmpty()) throw new Exception("UserName is Empty");
            if (password.IsEmpty()) throw new Exception("Password is Empty");
        }
        ~RetriveServicesLogins() => Read_ = null;
    }
}