namespace LoginForgot.DataAccess.Core
{
    #region usings.
    using Microsoft.Extensions.Configuration;
    using System.Collections.Generic;
    using Interfaces;
    using Models;
    using ZAORM.SQL;
    using static ZAORM.ZAEnum;
    #endregion
    public class ServicesCreate : IServicesCreate
    {
        private readonly string _strConn;
        public ServicesCreate(IConfiguration configuration) => _strConn = configuration.GetConnectionString("LoginFogotDB");
        public void AddUser(User user)
        {
            var zAParam = new List<ZAParam>()
            {
                new ZAParam("UserName", user.UserName, AllSQLType.VarChar, 50),
                new ZAParam("Email", user.Email, AllSQLType.VarChar, 150),
                new ZAParam("Password", user.Password, AllSQLType.VarChar, 70),
                new ZAParam("CellPhone", user.CellPhone, AllSQLType.VarChar, 50)

            };
            _strConn.Send("[dbo].[AddUser]", AllCmdType.SP, zAParam);
        }
    }
}