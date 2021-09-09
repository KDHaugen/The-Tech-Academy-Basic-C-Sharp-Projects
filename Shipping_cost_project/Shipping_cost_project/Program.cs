using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_cost_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Package Express. Please follow the instructions below."); //Welcome user to program

                //Prompt User for Weight
            Console.WriteLine("Please enter package weight in pounds.");    
            string pWeight = Console.ReadLine();
            int pWeightInt = Convert.ToInt32(pWeight);

                //If weight exceeds 50 lbs show user error message, otherwise continue to receive dimensions.
            if (pWeightInt > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
                //Prompt and receive dimension inputs from user. Convert their string inputs into integers
            else
            {
                Console.WriteLine("Please enter package width in centimeters.");
                string pWidth = Console.ReadLine();
                int pWidthInt = Convert.ToInt32(pWidth);

                Console.WriteLine("Please enter package Length in centimeters.");
                string pLength = Console.ReadLine();
                int pLengthInt = Convert.ToInt32(pLength);

                Console.WriteLine("Please enter package height in centimeters.");
                string pHeight = Console.ReadLine();
                int pHeightInt = Convert.ToInt32(pHeight);

                    //Take sum of Dimensions integers
                int pDimensions = (pHeightInt + pLengthInt + pWidthInt);

                    //Assess if sum of integers is below max limit of 50, if not, display error message to user.
                if (pDimensions <= 50)
                {
                    decimal priceTotal = Convert.ToDecimal(pWeightInt * pLengthInt * pHeightInt * pWidthInt) / 100;

                    //Display estimated price to user.
                    if ((priceTotal * 100) % 100 == 0) //If price comes out to even dollar, add ".00" to end value.
                    {
                        Console.WriteLine("Your estimated total for shipping this package is $" + priceTotal + ".00.");
                    }
                    else if ((priceTotal * 100) % 10 == 0) //If price comes to nearest tenth cent, add "0" to end value.
                    {
                        Console.WriteLine("Your estimated total for shipping this package is $" + priceTotal + "0.");
                    }
                    else                //If price comes out to 2 decimals, don't add 0s to end value.
                    {
                        Console.WriteLine("Your estimated total for shipping this package is $" + priceTotal + ".");
                    }
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Sum of dimensions exceed max limit of 50. We apologize but Package Express cannot take your package.");
                    Console.ReadLine();
                }

                }
            }
    }
}
