using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Methods3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Instatiate object sumObj from class twoIntOperator.
                twoIntOperator sumObj = new twoIntOperator();

                //Prompt and receive an interger from user.
                Console.WriteLine("Please enter a positive whole number.");
                int intOne = Convert.ToInt32(Console.ReadLine());

                //Prompt and receieve a second integer from user. Can be left blank.
                Console.WriteLine("Please enter another positive whole number. You may leave this submission blank.");
                int intTwo = Convert.ToInt32(Console.ReadLine());

                //Call method twoIntMethod() to find sum of intergers and display them on line.
                Console.WriteLine("Your two numbers added together equal " + sumObj.twoIntMethod(intOne, intTwo));

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Your only number you chose is " + intOne);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
