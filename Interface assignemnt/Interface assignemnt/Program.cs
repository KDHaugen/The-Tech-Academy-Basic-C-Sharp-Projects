using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_assignemnt
{
    class Program
    {
        static void Main(string[] args)
        {   
                //Instantiate both Employee as object employee and IQuittable as object quit\.
            Employee employee = new Employee();
            IQuittable quit = new Employee();

                //Call method Quit() from IQuittable
            quit.Quit(employee);    
                //Fill employee lists fName, lName, ID.
            employee.fName = new List<string>() { "Kyle", "Karli", "Elli" };
            employee.lName = new List<string>() { "Haugen", "Hyashi", "Smith" };
            employee.ID = new List<int>() { 1, 2, 3 };
                
                //Call first name from list employee.fName
            foreach (string fname in employee.fName)
            {
                employee.SayName(fname);
            }
            Console.ReadLine();
        }
    }
}
