namespace LoginForgot.DataAccess.Core
{
    #region usings.
    using Microsoft.Extensions.Configuration;
    using System.Collections.Generic;
    using Interfaces;
    using ZAORM.SQL;
    using static ZAORM.ZAEnum;
    #endregion
    public class ServicesUpdate : IServicesUpdate
    {
        private readonly string _strConn;
        public ServicesUpdate(IConfiguration configuration) => _strConn = configuration.GetConnectionString("LoginFogotDB");
        #region ChangePassword
        public void ChangePassword(int userID, string password)
        {
            var zAParam = new List<ZAParam>()
            {
                new ZAParam("UserID", userID, AllSQLType.Int),
                new ZAParam("Password", password, AllSQLType.VarChar, 70)
            };
            _strConn.Send("[dbo].[UpdPassword]", AllCmdType.SP, zAParam);
        }
        #endregion
    }
}