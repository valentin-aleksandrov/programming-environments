using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRepository
{
class Program
{
static void Main(string[] args)
    {
        Console.WriteLine("Enter faculty number: ");
        String facultyNumber = Console.ReadLine();
        StudentData.CreateReferences(@"C:\Users\Elly\IdeaProjects\TU_C_Sharp\UniversitySystem\StudentRepository\ReferenceLog.txt", facultyNumber);

    /*DateTime date = new DateTime(2017, 9, 15, 10, 30, 0);
    Console.WriteLine("Year: "+date.Year);
    Console.WriteLine("Day: "+date.Day);
    Console.WriteLine("Hour: "+date.Hour);
    Console.WriteLine("Now: "+DateTime.Now.Hour);
    Console.WriteLine("Today: "+DateTime.Today);
    //Date in 12 Hours:
    Console.WriteLine("Date in 12 Hours: "+DateTime.Now.AddHours(12));
    Console.WriteLine("Enter Year: ");
    int year = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter Month: ");
    int month = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter Day: ");
    int day = int.Parse(Console.ReadLine());
    DateTime Date = new DateTime(year, month, day);
    Console.WriteLine(Date);*/
    Console.ReadLine();
}
}
}
