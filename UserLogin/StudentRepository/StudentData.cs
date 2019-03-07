using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRepository
{
    class StudentData
    {
        private static List<Student> testStudents;
        public static List<Student> TestStudents
        {
            get
            {
                return testStudents;
            }
            private set
            {
                testStudents = value;
            }
        }
       static StudentData()
        {
            testStudents = new List<Student>();

            testStudents.Add(new Student("Pesho", "Ivanov",
                "Petrov", "FKST", "KSI",
                "bachelor", Status.FINNISHED_SEMESTER, "12345678", 3,
                "9", 46, DateTime.Now
                , DateTime.Now));

            testStudents.Add(new Student("Martin", "Ivanov",
                "Ivanov", "FKST", "KSI",
                "bachelor", Status.FINNISHED_SEMESTER, "12345679", 3,
                "9", 46, DateTime.Now
                , DateTime.Now));

            testStudents.Add(new Student("Stamat", "Georgiev",
                "Budurov", "FKST", "KSI",
                "bachelor", Status.FINNISHED_SEMESTER, "12345673", 3,
                "9", 46, DateTime.Now
                , DateTime.Now));
        }

        public static Student isThereStudent(String facNumber)
        {
            Student result = (from currentStudent in TestStudents
                             where currentStudent.FacNumber == facNumber
                             select currentStudent
                             ).First();
            return result;
        }
    }
}