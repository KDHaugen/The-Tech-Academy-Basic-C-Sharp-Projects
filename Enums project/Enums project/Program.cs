using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_project
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Weekday day = Weekday.Sunday;
                Console.WriteLine("Please enter today's day of the week");
                string today = Console.ReadLine();
                Console.WriteLine( "Yes, today is "+ day);
                
              
            }
            catch
            {
                Console.WriteLine("That is not today.");
            }
            finally
            {
                Console.ReadLine();
            }

        }
    }
    public enum Weekday
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
}
