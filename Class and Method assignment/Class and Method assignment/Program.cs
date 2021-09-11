using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Method_assignment
{
    class Program
    {
        static void intDouble(int userInp)
        {
            int inputDouble = userInp * 2;
            Console.WriteLine("Your number doubled is " + inputDouble);
        }
        static void intTriple(int userInp)
        {
            int inputTriple = userInp * 3;
            Console.WriteLine("Your number tripled is " + inputTriple);
        }
        static void intQuadruple(int userInp)
        {
            int inputQuadruple = userInp * 4;
            Console.WriteLine("Your number quadrupled is " + inputQuadruple);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please pick a whole and positive number.");
            int userInp = Convert.ToInt32(Console.ReadLine());

            intDouble(userInp);
            intTriple(userInp);
            intQuadruple(userInp);
            Console.ReadLine();
        }
    }
}
