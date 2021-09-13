using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The current time and date is "+DateTime.Now);
            Console.WriteLine("Pick a number of hours to pass in time");
            int passHours = Int32.Parse(Console.ReadLine());
            Console.WriteLine("In " + passHours + " hours it'll be " + DateTime.Now.AddHours(passHours));
            Console.ReadLine();
        }
    }
}
