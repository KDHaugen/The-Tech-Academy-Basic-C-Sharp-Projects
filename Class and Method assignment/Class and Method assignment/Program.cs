using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Method_assignment
{
    class Program
    {
        public static int userInp = Convert.ToInt32(Console.ReadLine());
        static void Main(string[] args)
        {
            Console.WriteLine(Operator.userDouble);
            Console.WriteLine(Operator.userTriple);
            Console.WriteLine(Operator.userQuad);
            Console.ReadLine();
        }
    }
}
