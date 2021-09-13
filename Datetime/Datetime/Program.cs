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
                //Open with current time using DateTime.Now
            Console.WriteLine("The current time and date is "+DateTime.Now);

                //Prompt user to pick an interger to add hours
            Console.WriteLine("Pick a number of hours to pass in time");
            int passHours = Int32.Parse(Console.ReadLine());
                //Use .AddHours(passHours) to add hours to DateTime.Now to show time with passHours hours added.
            Console.WriteLine("In " + passHours + " hours it'll be " + DateTime.Now.AddHours(passHours));
            Console.ReadLine();
        }
    }
}
