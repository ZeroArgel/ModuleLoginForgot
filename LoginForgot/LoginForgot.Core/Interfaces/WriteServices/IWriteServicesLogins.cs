namespace LoginForgot.Interfaces
{
    public interface IWriteServicesLogins
    {
        void Register(string userName, string email, string password, string confirmPassword, string cellPhone);
        void NewPassword(string email, string newPassword, string confirmNewPassword);
    }
}