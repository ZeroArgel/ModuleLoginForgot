namespace LoginForgot.Interfaces
{
    using System.Collections.Generic;
    using Models;
    public interface IRetrieveServicesLogins
    {
        IEnumerable<GenericKeyValue> GetCountryForCombobox();
        string Login(string userName, string password);
        string RecoverByEmail(string email);
        void ValidCode(string code);
    }
}