using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Methods_Divider
{
    class Divider
    {
        public void halver(int x)
        {
            int halved = x / 2;
            Console.WriteLine("Your number halved is " + halved + ".");
        }
        public static Divider halver(int y, int times)
        {
            for (int i = 0; i < times; i++)
            {
                y = halver(y);
            }
            return y;
        }

        //public void halver(int input, int times = 1)
        //{
        //    for (int i = 0; times < 0; i++)
        //    {
        //        int halved2 = input / 2;
        //        Console.WriteLine("Your number halved twice is " + halved2);
        //    }
        //}
    }
}
