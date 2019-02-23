using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    class Program
    {
        static void Main(string[] args)
        {
           // User admin = UserData.TestUsers;

            Console.WriteLine("Please enter username:");
            String userName = Console.ReadLine();
            Console.WriteLine("Please enter password:");
            String password = Console.ReadLine();

            LoginValidation validation = new LoginValidation(userName,password);

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
    }
}
