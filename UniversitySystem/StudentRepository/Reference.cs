using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRepository
{
    public class Reference
    {
        public Student Student { get; set; }
        public List<String> Subjects; 
        public Reference(Student student)
        { 
            this.Student = student; this.Subjects = new List<string>();
            Subjects.Add("Java");
            Subjects.Add("C++");
            Subjects.Add("Advanced Mathematics");
            Subjects.Add("Machine Learning");
            Subjects.Add("Discrete Structures");
        }
        public Reference(Student student, List<String> Subjects) { this.Student = student; this.Subjects = Subjects;}
        public override string ToString() 
        {
        StringBuilder builder = new StringBuilder();
        builder.Append("First Name: " + this.Student.FirstName).Append(" ").Append("Last Name: " + this.Student.LastName).Append(" ").Append("Faculty Number: " + this.Student.FacultyNumber).Append(Environment.NewLine);
        
            
            for (int i = 0; i < Subjects.Count; i++) 
        {
            builder.Append(this.Subjects[i]).Append(" ").Append(this.Student.status).Append(Environment.NewLine);
        
        }
            return builder.ToString();
        }
    }
}
