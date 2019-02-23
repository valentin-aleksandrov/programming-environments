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
            if(this.userName.Length < 5)
            {
                this.errorMessage = "Username length too short.";
                return false;
            }
            if(this.password.Length < 5)
            {
                this.errorMessage = "Password length too short.";
                return false;
            }
            User findUser = UserData.IsUserPassCorrect(this.userName, this.password);
            user.Username = findUser.Username;
            user.Password = findUser.Password;
            user.FakNum = findUser.FakNum;
            user.Role = findUser.Role;
            return true;
        }
    }
   
}
