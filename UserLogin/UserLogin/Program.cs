using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UserLogin
{
    class Program
    {
        //public delegate void ActionOnError(String errorMsg);
        public static void displayError(String error)
        {
            Console.WriteLine("!!! " + error + " !!!");
        }
        public static void displayError2(String error)
        {
            Console.WriteLine("!!! " + error + " !!!");
        }
        static void Main(string[] args)
        {
           // User admin = UserData.TestUsers[;

            Console.WriteLine("Please enter username:");
            String userName = Console.ReadLine();
            Console.WriteLine("Please enter password:");
            String password = Console.ReadLine();

            //LoginValidation.ActionOnError actionOnError = new LoginValidation.ActionOnError(displayError);

            LoginValidation validation = new LoginValidation(userName,password, displayError2);

            User user = new User();
            if (validation.ValidateUserInput(user))
            {
                Console.WriteLine(user.Username);
                Console.WriteLine(user.Role);
                Console.WriteLine(user.FakNum);
                switch (user.Role)
                {
                    case 0:
                      Console.WriteLine("Welcome, ANNONYMOUS!");
                            break;
                    case 1:
                      Console.WriteLine("Welcome, ADMIN!");
                        String adminOption = "-1";
                        while(adminOption != "0")
                        {
                            Console.WriteLine("Choose option:");
                            Console.WriteLine("0: Exit");
                            Console.WriteLine("1: Change user role.");
                            Console.WriteLine("2: Change user activity.");
                            Console.WriteLine("3: User list.");
                            Console.WriteLine("4: Display activity log.");
                            Console.WriteLine("5: Display current activity logs.");
                            adminOption = Console.ReadLine();
                            switch (adminOption)
                            {
                                case "1":
                                    changeUserRole();
                                    break;
                                case "2":
                                    changeUserActivity();
                                    break;
                                case "3":
                                    Dictionary<String, int> allUsers = UserData.allUsersUsernames();
                                    foreach (var currentUser in allUsers)
                                    {
                                        Console.WriteLine(currentUser.Key);
                                        Console.WriteLine(UserData.TestUsers[currentUser.Value]);
                                    }
                                    break;
                                case "4":
                                    loadActivityLogs();
                                    break;
                                case "5":
                                    Console.WriteLine("Enter filter for log");
                                    String filter = Console.ReadLine();
                                    String currentLogData = Logger.getCurrentSessionActivities(filter);
                                    Console.WriteLine(currentLogData);
                                    break;
                            }
                        }
                            break;
                    case 2:
                        Console.WriteLine("Welcome, INSPECTOR!");
                            break;
                    case 3:
                        Console.WriteLine("Welcome, PROFESSOR!");
                            break;
                    case 4:
                      Console.WriteLine("Welcome, STUDENT!");
                            break;
                }  
            }
            else
            {
                Console.WriteLine("Validation fails.");
                Console.WriteLine(LoginValidation.CurrentUserRole);
            }
            Console.ReadLine();
        }

        public static void changeUserActivity()
        {
            Console.WriteLine("Please enter an Username");
            String uName = Console.ReadLine();
            Console.WriteLine("Please Enter date");
            int date = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter month");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter year");
            int year = int.Parse(Console.ReadLine());
            DateTime inputDate = new DateTime(year, month, date);
            Dictionary<String, int> allUsers = UserData.allUsersUsernames();
            UserData.SetUserActiveTo(allUsers[uName], inputDate);

        }

        public static void changeUserRole()
        {
            Console.WriteLine("Please enter an Username");
            String uName = Console.ReadLine();
            Console.WriteLine("Please enter new Role");
            int uRole = int.Parse(Console.ReadLine());
            UserRoles currentRole = (UserRoles)uRole;
            Dictionary<String, int> allUsers = UserData.allUsersUsernames();
            UserData.AssignUserRole(allUsers[uName], currentRole);
        }
        public static void loadActivityLogs()
        {
            StreamReader reader = new StreamReader(@"C:\Users\Lenny\Documents\Lenny\projects\Програмни среди\programming-environments\UserLogin\UserLogin\test.txt");
            String currentLine = reader.ReadLine();
            StringBuilder logBuilder = new StringBuilder();
            while (currentLine != null)
            {
                logBuilder.Append(currentLine);
                logBuilder.Append(Environment.NewLine);
                currentLine = reader.ReadLine();
            }
            Console.WriteLine(logBuilder.ToString());
            reader.Close();
        }
    }
}
