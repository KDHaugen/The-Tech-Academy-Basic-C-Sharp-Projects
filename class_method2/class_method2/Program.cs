using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_method2
{
    class Program
    {
        static void Main(string[] args)
        {   
                //Instatiating a new object from class Converters
            Converters obj1 = new Converters();

                //Prompt user for Integer to double. Call intDoubler() from Converters obj1
            Console.WriteLine("Please input a whole and positive number to double");
            int userInterger = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number doubled is " + obj1.intDoubler(userInterger));

                //Prompt user for Decimal to convert to Interger. Call decToInt() from Converters obj1
            Console.WriteLine("Please enter a decimal value to convert to an integer.");
            decimal userDecimal = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Your decimal as an interger is " + obj1.decToInt(userDecimal));

                //Prompt user for String to convert to Interger. Call stringToInt() from Converters obj1
            Console.WriteLine("Please enter a string value to convert to an integer.");
            string userString = Console.ReadLine();
            Console.WriteLine("Your string as an interger is " + obj1.stringToInt(userString));

            Console.ReadLine();
        }
    }
}
