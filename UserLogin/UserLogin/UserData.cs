
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
            for(int i = 0; i < TestUsers.Length; i++)
            {
                TestUsers[i].Created = DateTime.Now;
                TestUsers[i].ExpiryDate = DateTime.MaxValue;
            }
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
        public static void SetUserActiveTo(String username, DateTime newDate)
        {
            for(int i = 0; i < TestUsers.Length; i++)
            {
                if(TestUsers[i].Username == username)
                {
                    TestUsers[i].ExpiryDate = newDate;
                    break;
                }
            }
        }

    }
}
