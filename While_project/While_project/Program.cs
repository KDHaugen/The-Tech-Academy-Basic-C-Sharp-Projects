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
            int timer = 1;      //Create integer "timer"
            while(timer <= 10)  //Create while clause for when timer is <= 10
            {
                Console.WriteLine(timer);   //Show user timer count
                timer++;                    //With each loop increase value of timer by 1;
            }

            do                              //Create a do loop
            {
                Console.WriteLine(timer);   //Show user timer count
                timer++;                    //With each loop increase value of timer by 1;
            }
            while (timer >= 10 && timer < 21);  //Create a while clause that causes above do loop to run when timer is >=10 and < 21
            Console.ReadLine();                 //End ReadLine() to keep program from shutting.
        }
    }
}
