namespace LoginForgot.Core
{
    #region usings.
    using System;
    using Models;
    using DataAccess.Interfaces;
    using Interfaces;
    using ZAExtensions;
    #endregion
    public class RetrieveServicesAdmin : IRetrieveServicesAdmin
    {
        private readonly IServicesRead _IServicesRead;
        public RetrieveServicesAdmin(IServicesRead iServicesRead) => _IServicesRead = iServicesRead;
        public User GetUserByEmail(string email)
        {
            if (email.IsEmpty()) throw new ArgumentException("Email is empty");
            return _IServicesRead.ReadUserWithEmail(new User(email));
        }
    }
}