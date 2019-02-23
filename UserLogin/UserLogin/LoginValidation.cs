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
        public LoginValidation(String errorMessage, String userName, String password)
        {
            this.errorMessage = errorMessage;
            this.userName = userName;
            this.password = password;
        }
        public bool ValidateUserInput()
        {
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
