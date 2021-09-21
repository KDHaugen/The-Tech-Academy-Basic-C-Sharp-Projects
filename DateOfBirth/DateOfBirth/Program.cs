using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateOfBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dob = Convert.ToDateTime("1989/10/22");
            DateTime today = DateTime.Today;

            var age = today - dob;

            Console.WriteLine(dob);
            Console.WriteLine(age);
            Console.ReadLine();

            var today1 = DateTime.Today;
            int age1 = Convert.ToInt32((today1 - dob)) / 365;

            Console.WriteLine(age1);
            Console.ReadLine();
        }
    }
}
