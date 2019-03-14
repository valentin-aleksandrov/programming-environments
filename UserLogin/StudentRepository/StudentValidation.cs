using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;
namespace StudentRepository
{
    public class StudentValidation
    {
        public static Student GetStudentDataByUser(User user)
        {
            if (user == null || user.FakNum == null)
            {
                Console.WriteLine("No such student");
                return null;
            }

            Student student = StudentData.findStudentByFacNumber(user.FakNum);

            if(student == null)
            {
                Console.WriteLine("No such student");
                return null;
            } else
            {
                return student;
            }
        }
    }
}
