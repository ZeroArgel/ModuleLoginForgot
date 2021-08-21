namespace LoginForgot.Models
{
    public class User
    {
        public User() { }
        public User(string email) => Email = email;
        public User(int userId, string password) 
        {
            UserId = userId;
            Password = password; 
        }
        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string CellPhone { get; set; }
    }
}