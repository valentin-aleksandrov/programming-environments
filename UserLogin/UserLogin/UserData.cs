
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

            User user = (from findUser in TestUsers
                         where findUser.Username == username && findUser.Password == password
                         select findUser).First();
            return user;
        }
        public static void SetUserActiveTo(int index, DateTime newDate)
        {
          
            testUsers[index].ExpiryDate = newDate;
            Logger.LogActivity("Change activity " + testUsers[index].Username);
        }
        public static void AssignUserRole(int index, UserRoles newRole)
        {
            testUsers[index].Role = (int)newRole;
            Logger.LogActivity("Change role on " + testUsers[index].Username);
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
