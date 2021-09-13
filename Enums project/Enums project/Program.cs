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
                Console.WriteLine("Please enter today's day of the week");
                string today = Console.ReadLine();
                Weekday day = Weekday.Monday;

                Console.WriteLine( "Yes, today is "+ today);
                
              
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
        //create enum class Weekday with real day weekdays listed Sunday-Saturday.
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
