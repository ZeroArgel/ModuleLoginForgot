using LoginForgot.DataAccess.DBCore.CRUD;
using LoginForgot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForgot.Core.WriteServices
{
    public class WriteServicesAdmin
    {
        private Create Create_;
        private Update Update_;

        public WriteServicesAdmin()
        {

        }
        public WriteServicesAdmin(Create create, Update update)
        {
            Create_ = create;
            Update_ = update;
        }
        public void ChangePassword(int userID, string password)
        {
            if (userID == 0) throw new Exception("UserID is Empty");
            if (password.IsEmpty()) throw new Exception("Password is Empty");
            Update_.ChangePassword(userID, password);
        }
        ~WriteServicesAdmin()
        {
            Create_ = null;
            Update_ = null;
        }
    }
}
