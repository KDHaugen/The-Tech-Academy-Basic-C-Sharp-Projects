using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_assignemnt
{
    class Employee : Person, IQuittable
    {
        public List<int> ID { get; set; }

        public void Quit(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
