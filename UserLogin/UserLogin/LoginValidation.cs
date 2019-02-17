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
