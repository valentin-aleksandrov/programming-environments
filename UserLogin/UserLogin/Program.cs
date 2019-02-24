using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    class Program
    {
        //public delegate void ActionOnError(String errorMsg);
        public static void displayError(String error)
        {
            Console.WriteLine("!!! " + error + " !!!");
        }
        static void Main(string[] args)
        {
           // User admin = UserData.TestUsers;

            Console.WriteLine("Please enter username:");
            String userName = Console.ReadLine();
            Console.WriteLine("Please enter password:");
            String password = Console.ReadLine();

            LoginValidation.ActionOnError actionOnError = new LoginValidation.ActionOnError(displayError);
            LoginValidation validation = new LoginValidation(userName,password,actionOnError);

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
                            Console.WriteLine("Изберете опция:");
                            Console.WriteLine("0: Изход");
                            Console.WriteLine("1: Промяна на роля на потребител");
                            Console.WriteLine("2: Промяна на активност на протебителя");
                            adminOption = Console.ReadLine();
                            switch (adminOption)
                            {
                                case "1":
                                    changeUserRole();
                                    break;
                                case "2":
                                    changeUserActivity();
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
            UserData.SetUserActiveTo(uName, inputDate);

        }

        public static void changeUserRole()
        {
            Console.WriteLine("Please enter an Username");
            String uName = Console.ReadLine();
            Console.WriteLine("Please enter new Role");
            int uRole = int.Parse(Console.ReadLine());
            UserRoles currentRole = (UserRoles)uRole;
            UserData.AssignUserRole(uName, currentRole);
        }
    }
}
