using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    class LoginValidation
    {
        static private UserRoles role;
        private String errorMessage;
        private String userName;
        private String password;
        public LoginValidation(String userName, String password)
        {
            this.userName = userName;
            this.password = password;
        }
        public bool ValidateUserInput(User user)
        {
            user.Username = this.userName;
            user.Password = this.password;
            return true;
        }
        static public UserRoles currentUserRole
        {
            get
            {
                return role;
            }
            private set
            {
                role = value;
            }
        }
    }
   
}
