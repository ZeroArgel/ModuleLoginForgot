using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForgot.DataAccess.DBCore.CRUD
{
    public class Update
    {
        private LoginForgotEntities LoginForgotEntities_;
        public Update() => LoginForgotEntities_ = new LoginForgotEntities();
        public void ChangePassword(int userID, string password) => LoginForgotEntities_.UpdPassword(userID, password);
        ~Update() => LoginForgotEntities_ = null;
    }
}
