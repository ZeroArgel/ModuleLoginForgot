namespace LoginForgot.DataAccess.Interfaces
{
    public interface IServicesUpdate
    {
        void ChangePassword(int userID, string password);
    }
}