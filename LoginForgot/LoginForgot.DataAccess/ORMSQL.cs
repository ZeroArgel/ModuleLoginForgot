namespace LoginForgot.DataAccess.Core
{
    using ZAORM.SQL;
    using static ZAORM.ZAEnum;
    public static class ORMSQL
    {
        internal static T Send<T>(this string stringConnection, string cmd, AllCmdType CmdType, object zAParam = null) => new ZADB(stringConnection).Post<T>(new ZABase(cmd, CmdType, zAParam));
        internal static int Send(this string stringConnection, string cmd, AllCmdType CmdType, object zAParam = null) => new ZADB(stringConnection).Post(new ZABase(cmd, CmdType, zAParam));
    }
}