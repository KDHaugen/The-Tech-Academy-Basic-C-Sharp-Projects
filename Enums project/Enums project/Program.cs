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
                    //Prompt user to pick a day of weeks
                Console.WriteLine("What is your favorite day of the week");
                    //Receive a string from user and check if it exist in the enum Weekday
                Weekday today = (Weekday)Enum.Parse(typeof(Weekday), Console.ReadLine());
                    //Tell user their favorite day of week
                Console.WriteLine( "Your favorite day of the week is "+ today);
                
              
            }
                //If no proper weekday is inputted by user, display this error message.
            catch
            {
                Console.WriteLine("That is not a day of the week.");
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
