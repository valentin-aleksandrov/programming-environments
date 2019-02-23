using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    class LoginValidation
    {
        static private UserRoles currentUserRole;
        static public UserRoles CurrentUserRole
        {
            get
            {
                return currentUserRole;
            }
            private set
            {
                currentUserRole = value;
            }
        }
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
            Boolean emptyUserName;
            emptyUserName = this.userName.Equals(String.Empty);
            Boolean emptyPassword = this.password.Equals(String.Empty);
            user.Username = this.userName;
            user.Password = this.password;
            currentUserRole = (UserRoles)user.Role;
            if (emptyUserName)
            {
                this.errorMessage = "Missing username.";
                return false;
            }
            if (emptyPassword)
            {
                this.errorMessage = "Missing password.";
                return false;
            }
            return true;
        }
        
    }
   
}
