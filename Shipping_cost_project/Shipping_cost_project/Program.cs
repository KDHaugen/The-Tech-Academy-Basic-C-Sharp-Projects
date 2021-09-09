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
            Console.WriteLine("Welcome to the Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter package weight in pounds.");
            string pWeight = Console.ReadLine();
            int pWeightInt = Convert.ToInt32(pWeight);

            if (pWeightInt > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
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

                decimal priceTotal = Convert.ToDecimal(pWeightInt * pLengthInt * pHeightInt * pWidthInt) / 100;

                //Display estimated price to user.
                if ((priceTotal*100)%100 == 0) //If price comes out to even dollar, add ".00" to end value.
                {
                    Console.WriteLine("Your estimated total for shipping this package is $" + priceTotal + ".00.");
                }
                else if((priceTotal*100)%10 == 0) //If price comes to nearest tenth cent, add "0" to end value.
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
        }
    }
}
