namespace LoginForgot.Interfaces
{
    using Models;
    public interface IRetrieveServicesAdmin
    {
        User GetUserByEmail(string email);
    }
}