using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care_Insurance_Form
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please fill out this form to assess insurance eligibility."); //Adress purpose of program.

            Console.WriteLine("How old are you?");      //Prompt for age.           
            string custAge = Console.ReadLine();        //Input for age.
            int custAgeint = Convert.ToInt32(custAge);  //Convert age string to integer.

            Console.WriteLine("Have you ever had a DUI? Please respond with True of False"); //Prompt DUI question.
            string duiInp = Console.ReadLine();                                             //Input DUI question.
            bool duiInpBool = Convert.ToBoolean(duiInp);                                    //Convert duiImp to Boolean

            Console.WriteLine("How many speeding tickets do you have?");    //Prompt ticket question.
            string tickets = Console.ReadLine();                            //Input ticket question.
            int ticketsInt = Convert.ToInt32(tickets);                      //Convert tickets to integer.

            bool eligible = (custAgeint > 15 && !duiInpBool && ticketsInt < 4); //Check parameters for eligibility.

            Console.WriteLine("Qualified?");
            Console.WriteLine(eligible);
            Console.ReadLine();
        }
    }
}
