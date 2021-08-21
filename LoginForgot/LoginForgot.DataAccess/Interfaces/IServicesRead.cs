namespace LoginForgot.DataAccess.Interfaces
{
    using System.Collections.Generic;
    using Models;
    public interface IServicesRead
    {
        User ReadUserToLogin(User user);
        User ReadUserWithEmail(User user);
        IEnumerable<GenericKeyValue> ReadAllCountryPhonesToCombo();
        Forgot ValidByEmail(string email);
        bool ValidCode(string code);
    }
}