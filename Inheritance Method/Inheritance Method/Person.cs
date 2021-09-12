using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Method
{
    class Person
    {
        public List<string> fName { get; set; }
        public List<string> lName { get; set; }

        public void SayName(string x = null, string y = null, string z = null)
        {
            Console.WriteLine("Name: "+ x + y);
        }
    }
}
