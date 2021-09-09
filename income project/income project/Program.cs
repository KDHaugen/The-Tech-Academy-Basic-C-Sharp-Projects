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
            string p1Hourly = Console.ReadLine();                                            //Input for Person 1's Hourly Rate.     
            float p1HourlyF = float.Parse(p1Hourly);                                         //Convert hourly string to Float.     
            Console.WriteLine("Person 1's Hourly Rate is: $" + p1Hourly + " per hour.");     //Confirmation of Person 1's Hourly Rate
            Console.WriteLine("Please enter Hours Worked per Week:");                        //Prompt for Person 1's Hours worked.
            string p1HoursPW = Console.ReadLine();                                           //Input for Person 1's Hourly Rate
            float p1HoursPWF = float.Parse(p1HoursPW);                                       //Convert Hours per week to Float.
            Console.WriteLine("Person 1 works " + p1HoursPWF + " hours per week");           //Confirmation of Perons 1's Hours worked per week.

            Console.WriteLine("Thank you, now for Person 2. Press Enter to continue.");     //Thank you and transition to Person 2.
            Console.ReadLine();                                                             //Enter brings to next Person.                                                      

            Console.WriteLine("Person 2");                                                  //Indicator for Person 2.
            Console.WriteLine("Please enter Hourly Rate:");                                 //Prompt for Person 2's Hourly Rate.
            string p2Hourly = Console.ReadLine();                                            //Input for Person 2's Hourly Rate.        
            float p2HourlyF = float.Parse(p2Hourly);                                         //Convert hourly string to Float. 
            Console.WriteLine("Person 2's Hourly Rate is: $" + p2Hourly + " per hour.");     //Confirmation of Person 2's Hourly Rate
            Console.WriteLine("Please enter Hours Worked per Week:");                       //Prompt for Person 2's Hours worked.
            string p2HoursPW = Console.ReadLine();                                           //Input for Person 2's Hourly Rate
            float p2HoursPWF = float.Parse(p2HoursPW);                                       //Convert Hours per week to Float.
            Console.WriteLine("Person 2 works " + p2HoursPW + " hours per week");           //Confirmation of Perons 2's Hours worked per week.

            float weeksPerYear = 52;    //Take average weeks per year for annual sallary

            int p1Total = Convert.ToInt32(p1HourlyF * p1HoursPWF * weeksPerYear);    //Find total annual salary for person 1 by finding product of hourly rate, hours per week and weeks per year.
            int p2Total = Convert.ToInt32(p2HourlyF * p2HoursPWF * weeksPerYear);    //Find total annual salary for person 2 by finding product of hourly rate, hours per week and weeks per year.


            Console.WriteLine("Annual salary of person 1:");
            Console.WriteLine(p1Total);
            Console.WriteLine("Annual salary of person 2:");
            Console.WriteLine(p2Total);

            bool p1Morep2 = p1Total > p2Total;

            Console.WriteLine("Does Person 1 make more money than Person 2?");  //Ask if Person 1 makes more than person 2.
            Console.WriteLine(p1Morep2);                                        //Boolean answer retrived from var p1Morep2.



            Console.ReadLine(); //End line to keep command open.
        }
    }
}
