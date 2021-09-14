using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const_and_Var
{
    class Program
    {
        static void Main(string[] args)
        {
            const string wontChange = "this won't change";
            Console.WriteLine(wontChange);
            var anInt = 12;
            if (anInt < 20)
            {
                Console.WriteLine("Var recognizes anInt as an interer.");
            }

            

            Console.ReadLine();
        }
    }
}

