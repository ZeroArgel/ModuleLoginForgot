using LoginForgot.Models;
using System.Security.Cryptography;
using System.Text;

namespace LoginForgot.Core
{
    public static class ExtensionMethods
    {
        public static bool IsEmpty(this string str) => string.IsNullOrEmpty(str);
        public static bool IsValidEmail(this string email) => !email.Contains("@");
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