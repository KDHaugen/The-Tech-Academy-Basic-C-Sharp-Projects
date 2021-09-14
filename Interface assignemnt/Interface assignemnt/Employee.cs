using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_assignemnt
{
    class Employee : Person, IQuittable
    {   
        //Create int list called ID
        public List<int> ID { get; set; }
            //Define Quit() method.
        public void Quit(Employee employee)
        {
            Console.WriteLine("Something");
        }
    }
}
