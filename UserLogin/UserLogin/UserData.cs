using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    static class UserData
    {
        private static User[] _testUsers;

        static public User[] TestUsers
        {
            get
            {
                ResetTestUserData();
                return _testUsers;
            }
            set
            {
                _testUsers = value;
            }
        }
        static private void ResetTestUserData()
        {
            TestUsers = new User[3];
            TestUsers[0] = new User("Pesho", "123234", "12131313", 0);
            TestUsers[1] = new User("Goshko", "000234", "12131314", 0);
            TestUsers[2] = new User("Toshko", "1111234", "12131315", 0);
        }

    }
}
