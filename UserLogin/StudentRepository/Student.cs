using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRepository
{
    public class Student
    {
        public String FirstName { get; set; }
        public String MiddleName { get; set; }
        public String LastName { get; set; }
        public String Faculty { get; set; }
        public String Speciality { get; set; }
        public String Degree { get; set; }
        public Status status { get; set; }
        public String FacNumber { get; set; }
        public int Course { get; set; }
        public String Flow { get; set; }
        public int Group { get; set; }
        public DateTime FinishedSemesterDate { get; set;}
        public DateTime SemesterPaymentDate { get; set;}

       public Student(string firstName, string middleName,
            string lastName, string faculty,
            string speciality, string degree,
            Status status, string facNumber, 
            int course, string flow, int group)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Faculty = faculty;
            Speciality = speciality;
            Degree = degree;
            this.status = status;
            FacNumber = facNumber;
            Course = course;
            Flow = flow;
            Group = group;
        }
        public Student(string firstName, string middleName,
            string lastName, string faculty, string speciality,
            string degree, Status status, string facNumber, int course, 
            string flow, int group, DateTime FinishedSemesterDate
            , DateTime SemesterPaymentDate)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Faculty = faculty;
            Speciality = speciality;
            Degree = degree;
            this.status = status;
            FacNumber = facNumber;
            Course = course;
            Flow = flow;
            Group = group;
        }
    }
}
