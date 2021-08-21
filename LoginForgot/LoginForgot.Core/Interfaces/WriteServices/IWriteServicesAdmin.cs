namespace LoginForgot.Interfaces
{
    public interface IWriteServicesAdmin
    {
        void ChangePassword(int userID, string password);
    }
}