using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overload
{
    public class Employee : Person , IQuittable
    { 
        public List<int> ID { get; set; }

        public void Quit(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
