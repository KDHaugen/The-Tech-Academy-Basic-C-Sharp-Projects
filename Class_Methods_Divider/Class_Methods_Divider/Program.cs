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
            Divider half = new Divider();
            Console.WriteLine("Please enter a number to be divided in half");
            int userInput = Convert.ToInt32(Console.ReadLine());

            half.halver(userInput);
            half.halver(userInput,2);

            
            Console.ReadLine();
        }
    }
}
