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
            Console.WriteLine("Hour --> " + date.Hour);
            Console.WriteLine("Today --> " + DateTime.Today);
            Console.WriteLine("Now --> " + DateTime.Now);
            Console.WriteLine("Now --> " + DateTime.Now);
            Console.WriteLine("Current Hour --> " + DateTime.Now.Hour);

            //Date after 12 hours
            Console.WriteLine("DateTime after 12 hours" + DateTime.Now.AddHours(12));


            Console.ReadLine();
        }
    }
}
