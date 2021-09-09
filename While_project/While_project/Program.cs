using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_project
{
    class Program
    {
        static void Main(string[] args)
        {
            int timer = 1;
            while(timer <= 10)
            {
                Console.WriteLine(timer);
                timer++;
            }
            do
            {
                Console.WriteLine(timer);
                timer++;
            }
            while (timer >= 10 && timer < 21);
            Console.ReadLine();
        }
    }
}
