using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem
{
public static class UserData
{

private static List<User> testUsers;

public static List<User> TestUsers
{
get {ResetUserData(); return testUsers;}
set {testUsers = value;}
}

private static void ResetUserData()
{
/*testUsers = new User[3];
testUsers[0] = new User("Puffle5", "12345", "121216007", 1);
testUsers[1] = new User("Johnson", "12321", "121216678", 4);
testUsers[2] = new User("Petur40", "1234567890", "121216123", 4);*/
    testUsers = new List<User>();
    testUsers.Add(new User("Puffle5", "12345", "121216007", 1));
    testUsers.Add(new User("Johnson", "12321", "121216678", 4));
    testUsers.Add(new User("Petur40", "1234567890", "121216123", 4));


for (int i = 0; i < testUsers.Count; i++)
{testUsers[i].Created = DateTime.Now; testUsers[i].ExpirationDate = DateTime.MaxValue;}
//testUsers = new User[] {--"--};
}
public static User IsUserPassCorrect(String username, String password)
{
    User user = (from findUser in TestUsers where findUser.Username == username && findUser.Password == password select findUser).First();
    return user;
}

public static void SetUserActiveTo(int index, DateTime newActivityDate) 
{
   
    testUsers[index].ExpirationDate = newActivityDate;
    Logger.LogActivity("Change of "+testUsers[index].Username+"'s activity");
}
public static void AssignUserRole(int index, UserRoles newRole) 
{
   
    testUsers[index].Role = (int)newRole;
    Logger.LogActivity("Change of " + testUsers[index].Username + "'s role");
}
public static Dictionary<String, int> AllUsersUsernames() 
{
    Dictionary<String, int> result = new Dictionary<string, int>();
    for (int i = 0; i < testUsers.Count; i++) 
    {
        result.Add(testUsers[i].Username, i);
    
    }

        return result;
}
}
}
