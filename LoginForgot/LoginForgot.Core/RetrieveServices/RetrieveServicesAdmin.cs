using LoginForgot.DataAccess.DBCore.CRUD;
using LoginForgot.Models;
using System;

namespace LoginForgot.Core.RetrieveServices
{
    public class RetrieveServicesAdmin
    {
        private Read Read_;

        public RetrieveServicesAdmin() { }
        public RetrieveServicesAdmin(Read read) => Read_ = read;
        public User GetUserByEmail(string email)
        {
            if (email.IsEmpty()) throw new Exception("Password is Empty");
            return Read_.ReadUserWithEmail("ByEmail".CreateModelUser("ByEmail", 0, email, "ByEmail"));
        }
        ~RetrieveServicesAdmin() => Read_ = null;
    }
}