namespace LoginForgot.Core
{
    #region usings.
    using System;
    using DataAccess.Interfaces;
    using Interfaces;
    using ZAExtensions;
    #endregion
    public class WriteServicesAdmin : IWriteServicesAdmin
    {
        private readonly IServicesUpdate _IServicesUpdate;

        public WriteServicesAdmin(IServicesUpdate iServicesUpdate) => _IServicesUpdate = iServicesUpdate;
        public void ChangePassword(int userId, string password)
        {
            if (userId == 0) throw new ArgumentException("UserID is Empty");
            if (password.IsEmpty()) throw new ArgumentException("Password is Empty");
            _IServicesUpdate.ChangePassword(userId, password);
        }
    }
}