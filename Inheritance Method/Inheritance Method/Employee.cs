using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Method
{
    class Employee : Person
    {
        public List<int> ID { get; set; }
        public void SayName(string x = null, string y = null, string z = null)
        {
            Console.WriteLine("Name: " + x + y);
        }

    }
}
