using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem
{
public class LoginValidation
{
    public delegate void ActionOnError(String errorMessage);
    private ActionOnError actionOnError;
public static UserRoles CurrentUserRole
{get {return currentUserRole;} private set {currentUserRole = value;}}
        private static UserRoles currentUserRole;
        private String userName;
        private String password;
        private String errorMessage;

        public LoginValidation(String userName, String password, ActionOnError actionOnError)
        { this.userName = userName; this.password = password; this.actionOnError = actionOnError; }


        public bool ValidateUserInput(User addedUser)
        {

            Boolean emptyUserName = this.userName.Equals(String.Empty); 
            Boolean emptyPassWord = this.password.Equals(String.Empty);
           
            currentUserRole = (UserRoles)addedUser.Role;
          


            if (emptyUserName) { this.errorMessage = "Missing username!"; this.actionOnError(this.errorMessage); addedUser.Role = 0; return false; }
            if (emptyPassWord) { this.errorMessage = "Missing password!"; this.actionOnError(this.errorMessage); addedUser.Role = 0; return false; }
            if (this.userName.Length < 5) { this.errorMessage = "Username too short!"; this.actionOnError(this.errorMessage); addedUser.Role = 0; return false; }
            if (this.password.Length < 5) { this.errorMessage = "Password too short!"; this.actionOnError(this.errorMessage); addedUser.Role = 0; return false; }
            User findUser = UserData.IsUserPassCorrect(this.userName, this.password);
            if (findUser == null) { this.errorMessage = "User not found!"; this.actionOnError(this.errorMessage); addedUser.Role = 0; return false; }
            addedUser.Username = findUser.Username;
            addedUser.Password = findUser.Password;
            addedUser.FakNum = findUser.FakNum;
            addedUser.Role = findUser.Role;
            Logger.LogActivity("Successful Login");
            return true;
        
        }
    }
}