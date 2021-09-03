namespace LoginForgot.DataAccess.Core
{
    #region usings.
    using Microsoft.Extensions.Configuration;
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces;
    using Models;
    using ZAORM.SQL;
    using static ZAORM.ZAEnum;
    #endregion
    public class ServicesRead : IServicesRead
    {
        private readonly string _strConn;
        public ServicesRead(IConfiguration configuration) => _strConn = configuration.GetConnectionString("LoginFogotDB");
        #region ReadUserToLogin
        public User ReadUserToLogin(User user) 
        {
            var zAParam = new List<ZAParam>()
            {
                new ZAParam("UserName", user.UserName, AllSQLType.VarChar, 50),
                new ZAParam("Password", user.Password, AllSQLType.VarChar, 70)
            };
            return _strConn.Send<IEnumerable<User>>("[dbo].[GetUserToLogin]", AllCmdType.SP, zAParam)
                           .FirstOrDefault();
        }
        #endregion
        #region ReadUserWithEmail
        public User ReadUserWithEmail(User user) =>
            _strConn.Send<IEnumerable<User>>("[dbo].[GetUserByEmail]", AllCmdType.SP, new ZAParam("Email", user.Email, AllSQLType.VarChar, 150))
                    .FirstOrDefault();
        #endregion
        public IEnumerable<GenericKeyValue> ReadAllCountryPhonesToCombo() => _strConn.Send<IEnumerable<GenericKeyValue>>("[dbo].[GetAllCountryPhonesToCombo]", AllCmdType.SP);
        #region ValidByEmail
        public Forgot ValidByEmail(string email) =>
            _strConn.Send<IEnumerable<Forgot>>("[dbo].[GetCodeToForgot]", AllCmdType.SP, new ZAParam("Email", email, AllSQLType.VarChar, 150))
                    .FirstOrDefault();
        #endregion
        public bool ValidCode(string code) => _strConn.Send("[dbo].[GetCodeValid]", AllCmdType.SP, new ZAParam("Code", code, AllSQLType.VarChar, 5)) > 0;
    }
}