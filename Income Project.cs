using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)

        {
            //Title of Program
            Console.WriteLine("Anonyumous Income Comparison Program");


            Console.WriteLine("Person 1");                                                  //Indicator for Person 1.
            Console.WriteLine("Please enter Hourly Rate:");                                 //Prompt for Person 1's Hourly Rate.
            float p1Hourly = Console.ReadLine();                                            //Input for Person 1's Hourly Rate.     
            Console.WriteLine("Person 1's Hourly Rate is: $" + p1Hourly +" per hour.");     //Confirmation of Person 1's Hourly Rate
            Console.WriteLine("Please enter Hours Worked per Week:");                       //Prompt for Person 1's Hours worked.
            float p1HoursPW = Console.ReadLine();                                           //Input for Person 1's Hourly Rate
            Console.WriteLine("Person 1 works " + p1HoursPW + " hours per week");           //Confirmation of Perons 1's Hours worked per week.

            Console.WriteLine("Thank you, now for Person 2. Press Enter to continue.");     //Thank you and transition to Person 2.
            Console.ReadLine();                                                             //Enter brings to next Person.                                                      

            Console.WriteLine("Person 2");                                                  //Indicator for Person 2.
            Console.WriteLine("Please enter Hourly Rate:");                                 //Prompt for Person 2's Hourly Rate.
            float p2Hourly = Console.ReadLine();                                            //Input for Person 2's Hourly Rate.     
            Console.WriteLine("Person 2's Hourly Rate is: $" + p2Hourly + " per hour.");     //Confirmation of Person 2's Hourly Rate
            Console.WriteLine("Please enter Hours Worked per Week:");                       //Prompt for Person 2's Hours worked.
            float p2HoursPW = Console.ReadLine();                                           //Input for Person 2's Hourly Rate
            Console.WriteLine("Person 2 works " + p2HoursPW + " hours per week");           //Confirmation of Perons 2's Hours worked per week.

            float weeksPerYear = 52;    //Take average weeks per year for annual sallary

            int ToInt32(p1Total) = p1Hourly * p1HoursPW * weeksPerYear;    //Find total annual salary for person 1 by finding product of hourly rate, hours per week and weeks per year.
            int ToInt32(p2Total) = p2Hourly * p2HoursPW * weeksPerYear;    //Find total annual salary for person 2 by finding product of hourly rate, hours per week and weeks per year.


            Console.WriteLine("Annual salary of person 1:");
            Console.WriteLine(p1Total)

            Console.ReadLine(); //End line to keep command open.
        }
    }
}
