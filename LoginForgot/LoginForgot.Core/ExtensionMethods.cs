namespace LoginForgot.Core
{
    using Twilio;
    using Twilio.Rest.Api.V2010.Account;
    using System.Configuration;
    public static class ExtensionMethods
    {
        #region Twilio Config.
        private static readonly string TwilioAccountSID = ConfigurationManager.AppSettings["TwilioAccountSID"].ToString();
        private static readonly string TwilioToken = ConfigurationManager.AppSettings["TwilioToken"].ToString();
        private static readonly string TwilioPhone = ConfigurationManager.AppSettings["TwilioPhone"].ToString();
        #endregion
        public static bool IsValidEmail(this string email) => !email.Contains("@");
        public static string SendMsg(this string to, string code)
        {
            TwilioClient.Init(TwilioAccountSID, TwilioToken);
            var message = MessageResource.Create(
                body: "This is your Code: " + code + ". You have 15 minutes to used.",
                from: new Twilio.Types.PhoneNumber(TwilioPhone),
                to: new Twilio.Types.PhoneNumber(to)
            );
            return message.Sid;
        }
    }
}