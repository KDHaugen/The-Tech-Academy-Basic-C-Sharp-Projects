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
                //Instantiate Employee class as object employee
            Employee employee = new Employee();

                //Assign strings fName and lName.
            employee.fName = "Sample";
            employee.lName = "Student";

            employee.SayName(employee.fName, employee.lName);

            Console.ReadLine();

        }
    }
}
