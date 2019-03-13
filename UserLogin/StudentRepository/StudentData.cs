using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentRepository
{
    static class StudentData
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

        public static List<Refernece> referneces { get; set; }


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

            referneces = new List<Refernece>();
        }

        public static Student isThereStudent(String facNumber)
        {
            Student result = (from currentStudent in TestStudents
                             where currentStudent.FacNumber == facNumber
                             select currentStudent
                             ).First();
            return result;
        }

        public static String AcadReference(String facNumber)
        {
            Student foundStudent = findStudentByFacNumber(facNumber);
            if(foundStudent == null)
            {
                return null;
            }
            Refernece currentRefence = new Refernece(foundStudent);
            referneces.Add(currentRefence);
            Console.WriteLine(currentRefence.ToString());
            return currentRefence.ToString();

        }
        public static Student findStudentByFacNumber(String facNumber)
        {
            for(int i = 0; i < testStudents.Count; i++)
            {
                if(facNumber == testStudents[i].FacNumber)
                {
                    return testStudents[i];
                }
            }
            // if there is no such student
            return null;
        }

        public static void CreateReferences(String filePath, String facNumber)
        {
            Refernece foundReference = FindReferenceByFacNumber(facNumber);
            if(foundReference == null)
            {
                String createdRefernce = AcadReference(facNumber);
                Student currentStudent = findStudentByFacNumber(facNumber);
                if(currentStudent.status == Status.FINNISHED_SEMESTER)
                {
                    File.AppendAllText(filePath, createdRefernce + Environment.NewLine);
                } else
                {
                    Console.WriteLine(currentStudent.FirstName + " hasn't finnished succesfully the semester.");
                }    
            }  else
            {
                File.AppendAllText(filePath, foundReference.ToString() + Environment.NewLine);
            }
            
        }
        public static Refernece FindReferenceByFacNumber(String facnumber)
        {
            for(int i = 0; i < referneces.Count; i++)
            {
                if(facnumber == referneces[i].Student.FacNumber)
                {
                    return referneces[i];
                }
            }
            return null;
        }
        
    }
}