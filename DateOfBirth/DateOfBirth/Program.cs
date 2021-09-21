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
            DateTime dob = Convert.ToDateTime("2015/10/22");
            DateTime today = DateTime.Today;

            var eighteenYearsAgo = today.AddYears(-18);

            var age = today - dob;

            Console.WriteLine(dob);
            Console.WriteLine(age);
            Console.WriteLine(eighteenYearsAgo);
            if(dob > eighteenYearsAgo)
            {
                Console.WriteLine("You are younger than 18");
            }
            else
            {
                Console.WriteLine("You are older than 18");

            }
            Console.ReadLine();
        }
    }
}
