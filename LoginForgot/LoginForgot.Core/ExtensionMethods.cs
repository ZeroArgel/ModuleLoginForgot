using LoginForgot.Models;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using System.Security.Cryptography;
using System.Text;
using System.Configuration;

namespace LoginForgot.Core
{
    public static class ExtensionMethods
    {
        #region Twilio Config.
        private static readonly string TwilioAccountSID = ConfigurationManager.AppSettings["TwilioAccountSID"].ToString();
        private static readonly string TwilioToken = ConfigurationManager.AppSettings["TwilioToken"].ToString();
        private static readonly string TwilioPhone = ConfigurationManager.AppSettings["TwilioPhone"].ToString();
        #endregion
        public static bool IsEmpty(this string str) => string.IsNullOrEmpty(str);
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
        public static User CreateModelUser(this string user, string password, int userId=0, string email=null, string cellPhone=null) =>
            new User()
            {
                UserID = userId,
                UserName = user,
                Password = password,
                Email = email,
                CellPhone = cellPhone
            };
        public static string ToHash(this string str)
        {
            // Create a SHA256   
            using (var sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(str));

                // Convert byte array to a string   
                var builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}