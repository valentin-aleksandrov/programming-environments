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
            User user = UserData.TestUser;
            LoginValidation validation = new LoginValidation();

            if (validation.ValidateUserInput())
            {
                Console.WriteLine(user.Username);
                Console.WriteLine(user.Role);
                Console.WriteLine(user.FakNum);
                Console.WriteLine(LoginValidation.currentUserRole);
                
            }

            Console.ReadLine();

        }
    }
}
