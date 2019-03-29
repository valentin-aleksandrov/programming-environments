using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentRepository
{
    public static class StudentData
    {
        private static List<Student> testStudents;
        public static List<Student> TestStudents 
        
        {get {return testStudents;}

            private set {testStudents = value;}
        }
        public static List<Reference> references { get; set; }

        static StudentData() 
        {
            testStudents = new List<Student>();
            testStudents.Add(new Student("Crocky", "Stoyanova", "Ivanova", "FCST", "CSI", "Bachelor", Status.CERTIFIED, "121216156", 3, 1, 45, DateTime.Now, DateTime.Now));
            testStudents.Add(new Student("Bodil40", "Petrov", "Mersikov", "FCST", "ITI", "Bachelor", Status.DROPPED, "121216000", 4, 8, 57, DateTime.Now, DateTime.Now));
            testStudents.Add(new Student("Costa", "Caesar", "Rica", "FTC", "Telecommunications", "Master", Status.GRADUATED, "121216404", 5, 5, 48, DateTime.Now, DateTime.Now));
            references = new List<Reference>();
        }
        public static Student IsThereStudent(String facultyNumber) 
        { 
        Student result = (from currentStudent in TestStudents where currentStudent.FacultyNumber == facultyNumber select currentStudent).First();
        return result;
        }
        public static String AcadReference(String facultyNumber) 
        {
            Student foundStudent = foundStudentByNumber(facultyNumber);
            if (foundStudent == null) { return null; }
            Reference currentReference = new Reference(foundStudent);
            references.Add(currentReference);
            Console.WriteLine(currentReference.ToString());
            return currentReference.ToString();
        
        }

        public static Student foundStudentByNumber(String facultyNumber) 
        {
            for (int i = 0; i < testStudents.Count; i++) 
            {
                if (facultyNumber == testStudents[i].FacultyNumber) 
                {return testStudents[i];}
            }
            return null;
        }
        public static void CreateReferences(String path, String facultyNumber) 
        {
            Reference foundReference = FindReferencebyNumber(facultyNumber);
            if (foundReference == null)
            {
                String createdReference = AcadReference(facultyNumber);
                Student currentStudent = foundStudentByNumber(facultyNumber);
                if (currentStudent.status == Status.CERTIFIED)
                {File.AppendAllText(path, createdReference + Environment.NewLine);}
                else
                {Console.WriteLine(currentStudent.FirstName + " hasn't finished the semester.");}

            }
            else 
            {File.AppendAllText(path, foundReference.ToString() + Environment.NewLine);}
         }
public static Reference FindReferencebyNumber(String facultyNumber) 
        {
            for (int i = 0; i < references.Count; i++) 
            {if (facultyNumber == references[i].Student.FacultyNumber) {return references[i];}}
            return null;
        }

    }
}
