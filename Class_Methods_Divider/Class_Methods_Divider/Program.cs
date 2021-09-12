using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Methods_Divider
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instatiate the Divider class with the object "half"
            Divider half = new Divider();

            //Prompt and recieve an interger value from User.
            Console.WriteLine("Please enter a number to be divided in half");
            int userInput = Convert.ToInt32(Console.ReadLine());

            //Call the halver function from Divider class using objject half using 1 and 2 parameters by overloading the second time.
            half.halver(userInput);
            half.halver(userInput,2);

            
            Console.ReadLine();
        }
    }
}
