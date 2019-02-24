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
            DateTime date = new DateTime(2017, 9, 15, 10, 30, 0);
            Console.WriteLine(date);
            Console.WriteLine("Year --> " + date.Year);
            Console.WriteLine("Date --> " + date.Day);




            Console.ReadLine();
        }
    }
}
