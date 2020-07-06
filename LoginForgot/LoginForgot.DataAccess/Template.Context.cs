﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoginForgot.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class LoginForgotEntities : DbContext
    {
        public LoginForgotEntities()
            : base("name=LoginForgotEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CountryPhones> CountryPhones { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<CodeToUsers> CodeToUsers { get; set; }
    
        public virtual int AddUser(string userName, string email, string password, string cellPhone)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var cellPhoneParameter = cellPhone != null ?
                new ObjectParameter("CellPhone", cellPhone) :
                new ObjectParameter("CellPhone", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddUser", userNameParameter, emailParameter, passwordParameter, cellPhoneParameter);
        }
    
        public virtual ObjectResult<GetUserToLogin_Result> GetUserToLogin(string user, string password)
        {
            var userParameter = user != null ?
                new ObjectParameter("User", user) :
                new ObjectParameter("User", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetUserToLogin_Result>("GetUserToLogin", userParameter, passwordParameter);
        }
    
        public virtual ObjectResult<GetAllCountryPhones_Result> GetAllCountryPhones()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllCountryPhones_Result>("GetAllCountryPhones");
        }
    
        public virtual ObjectResult<GetAllCountryPhonesToCombo_Result> GetAllCountryPhonesToCombo()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllCountryPhonesToCombo_Result>("GetAllCountryPhonesToCombo");
        }
    
        public virtual ObjectResult<GetCodeToForgot_Result> GetCodeToForgot(string email)
        {
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetCodeToForgot_Result>("GetCodeToForgot", emailParameter);
        }
    
        public virtual ObjectResult<GetCodeValid_Result> GetCodeValid(string code)
        {
            var codeParameter = code != null ?
                new ObjectParameter("Code", code) :
                new ObjectParameter("Code", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetCodeValid_Result>("GetCodeValid", codeParameter);
        }
    
        public virtual int UpdPassword(Nullable<int> userID, string password)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdPassword", userIDParameter, passwordParameter);
        }
    
        public virtual ObjectResult<GetUserByEmail_Result> GetUserByEmail(string email)
        {
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetUserByEmail_Result>("GetUserByEmail", emailParameter);
        }
    }
}
