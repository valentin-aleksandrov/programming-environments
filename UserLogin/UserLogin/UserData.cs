using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    static class UserData
    {
        private static User[] testUsers;

        static public User[] TestUsers
        {
            get
            {
                ResetTestUserData();
                return testUsers;
            }
            private set { }
        }
        static private void ResetTestUserData()
        {
            testUsers = new User[3];
            testUsers[0] = new User("Pesho", "123234", "12131313", 1);
            testUsers[1] = new User("Goshko", "000234", "12131314", 4);
            testUsers[2] = new User("Toshko", "1111234", "12131315", 4);
            //TestUsers = new User[] { new User("Pesho", "123234", "12131313", 0), new User("Pesho2", "123234", "12131313", 0) };
        }
        static public User IsUserPassCorrect(String username, String password)
        {
            foreach (User currentUser in TestUsers)
            {
                if(currentUser.Username == username && currentUser.Password == password)
                {
                    return currentUser;
                }
            }
            return null;
        }

    }
}
