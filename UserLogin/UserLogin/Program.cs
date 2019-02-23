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
            User admin = UserData.TestUser;

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
                Console.WriteLine(LoginValidation.CurrentUserRole);  
            }
            Console.ReadLine();
        }
    }
}
