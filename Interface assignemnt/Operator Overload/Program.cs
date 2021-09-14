using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overload
{
    class Program
    {
        static void Main(string[] args)
        {
                //Instatiate Employee class using obj employee
            Employee employee = new Employee();
            IQuittable quit = new Employee();
            employee.Quit(employee);
                //Fill employee lists fName, lName and ID.
            employee.fName = new List<string>() { "Kyle", "Karli", "Elli" };
            employee.lName = new List<string>() { "Haugen", "Hyashi", "Smith" };
            employee.ID = new List<int>() { 1, 2, 3 };

            foreach (string fname in employee.fName)
            {
                employee.SayName(fname);
            }
            Console.ReadLine();
        }
    }
}
