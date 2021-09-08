using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("The Tech Academy.");
            Console.WriteLine("Student Daily Repoty.");


            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your Name is: " + yourName);

            Console.WriteLine("What course are you on?");
            string courseTitle = Console.ReadLine();
            Console.WriteLine("Your currently on: " + courseTitle);

            Console.WriteLine("What page number are you on?");
            string pageNumber = Console.ReadLine();
            Console.WriteLine("Your currently on page: " + pageNumber);

            Console.WriteLine("Do you need help with anything? Please reply True or False.");
            string needHelp = Console.ReadLine();
            Console.WriteLine("You need help: " + needHelp);

            Console.WriteLine("Is there any feedfback you'd like to provide? Please be specific");
            string feedbackSub = Console.ReadLine();
            Console.WriteLine("Your feed back is: " + feedbackSub);

            Console.WriteLine("How many hours did you study today?");
            string hourStudied = Console.ReadLine();
            Console.WriteLine("You studied for " + hourStudied + "hours.");
            Console.ReadLine();
        }
    }
}
