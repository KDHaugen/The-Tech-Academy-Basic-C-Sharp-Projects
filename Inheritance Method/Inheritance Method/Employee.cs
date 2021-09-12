using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Method
{
    class Employee : Person
    {
        public int ID { get; set; }
        public void SayName(string firstName, string lastName)
        {
            Console.WriteLine(firstName + " " + lastName);
        }

    }
}
