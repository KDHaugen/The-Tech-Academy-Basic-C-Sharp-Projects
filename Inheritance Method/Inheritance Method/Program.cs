using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.fName = new List<string>() { "Kyle", "Karli", "Elli" };
            employee.lName = new List<string>() { "Haugen", "Hyashi", "Smith" };
            employee.ID = new List<int>() { 1, 2, 3 };

            foreach(string fname in employee.fName)
            {
                string y = employee.lName.ToString();
                employee.SayName(fname, y);
            }
            Console.ReadLine();

        }
    }
}
