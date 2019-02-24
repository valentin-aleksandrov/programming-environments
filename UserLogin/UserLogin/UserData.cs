
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    static class UserData
    {
        private static List<User> testUsers;

        static public List<User> TestUsers
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
            /*testUsers = new User[3];
            testUsers[0] = new User("Pesho", "123234", "12131313", 1);
            testUsers[1] = new User("Goshko", "000234", "12131314", 4);
            testUsers[2] = new User("Toshko", "1111234", "12131315", 4);*/
            //TestUsers = new User[] { new User("Pesho", "123234", "12131313", 0), new User("Pesho2", "123234", "12131313", 0) };
            testUsers = new List<User>();
            testUsers.Add(new User("Pesho", "123234", "12131313", 1));
            testUsers.Add(new User("Goshko", "000234", "12131314", 4));
            testUsers.Add(new User("Toshko", "1111234", "12131315", 4));
            for(int i = 0; i < testUsers.Count; i++)
            {
                testUsers[i].Created = DateTime.Now;
                testUsers[i].ExpiryDate = DateTime.MaxValue;
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
            for(int i = 0; i < TestUsers.Count; i++)
            {
                if(testUsers[i].Username == username)
                {
                    testUsers[i].ExpiryDate = newDate;
                    break;
                }
            }
            Logger.LogActivity("Промяна на активност на " + username);
        }
        public static void AssignUserRole(String username, UserRoles newRole)
        {
            for (int i = 0; i < TestUsers.Count; i++)
            {
                if (testUsers[i].Username == username)
                {
                    testUsers[i].Role = (int)newRole;
                    break;
                }
            }
            Logger.LogActivity("Промяна на роля на " + username);
        }
        public static Dictionary<String, int> allUsersUsernames()
        {
            Dictionary<String, int> result = new Dictionary<string, int>();
            for(int i = 0; i < testUsers.Count; i++)
            {
                result.Add(testUsers[i].Username, i);
            }

            return result;
        }
    }
}
