using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    static class UserData
    {
        public static User _testUser;

        static public User TestUser
        {
            get
            {
                ResetTestUserData();
                return _testUser;
            }
            set {  }
        }
        static private void ResetTestUserData()
        {
            _testUser = new User("Honda", "123", "112233", 1);
        }

    }
}
