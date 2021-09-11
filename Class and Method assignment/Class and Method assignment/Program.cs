using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Method_assignment
{
    class Program
    {
        
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
