using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRepository
{
    public class Refernece
    {
        public Student Student { get; set; }
        public List<String> Subjects;

        public Refernece(Student student)
        {
            this.Student = student;
            // default values for subjects
            this.Subjects = new List<string>();
            Subjects.Add("Math");
            Subjects.Add("English");
            Subjects.Add("Sport");
            Subjects.Add("Programming");
        }
        public Refernece(Student student, List<String> Subjects)
        {
            this.Student = student;
            this.Subjects = Subjects;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("First name " + this.Student.FirstName)
                .Append(" ")
                .Append("Last name " + this.Student.LastName)
                .Append(" ")
                .Append("Fac. Number ")
                .Append(this.Student.FacNumber)
                .Append(Environment.NewLine);
            for(int i = 0; i < this.Subjects.Count; i++)
            {
                sb.Append(this.Subjects[i])
                    .Append(" ")
                    .Append(this.Student.status)
                    .Append(Environment.NewLine);
            }
            return sb.ToString();
        }
    }
}
