using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Methods_Divider
{
    class Divider
    {
        //me
        public void halver(int x)
        {
            int halved = x / 2;
            Console.WriteLine("Your number halved is " + halved + ".");
        }

        //Add an overloaded method that divides the 
        public void halver(int input, int times = 1)
        {
                int halved2 = input / (2*times);
                Console.WriteLine("Your number halved " +times+" times is "+halved2);
        }
    }
}
