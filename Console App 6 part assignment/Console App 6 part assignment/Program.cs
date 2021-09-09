using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_6_part_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //    string[] inputArray = new string[5];    //Create new string array called inputArray.

            //    for (int i = 0; i < inputArray.Length; i++)
            //    {
            //        if (i == 0)
            //        {
            //            Console.WriteLine("Please enter a string");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Please enter another string");
            //        }
            //        string userInput = Console.ReadLine();
            //        inputArray[i] = userInput;

            //    }

            //    for (int j = 0; j < inputArray.Length; j++)
            //    {
            //        Console.WriteLine(inputArray[j]);

            //    }

            //    List<string> stringList = new List<string>() { "cat", "dog", "bird", "turtle", "fish" };
            //    Console.WriteLine("Please search for animal type avaiable in store:");
            //    string searchAnimal = (Console.ReadLine());
            //    searchAnimal = searchAnimal.ToLower();

            //    foreach (string animal in stringList)
            //    {
            //        if (animal == searchAnimal)
            //        {
            //            Console.WriteLine(animal);
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("We're sorry but we do not have that type of animal.");
            //            break;
            //        }

            //    }

            //List<string> candy = new List<string>() { "snicker", "snicker", "reeses", "butterfinger" };
            //Console.WriteLine("Please select one of the following items to see inventory quantity: Butterfinger, Snicker, Reeses");
            //string searchCandy = (Console.ReadLine());
            //searchCandy = searchCandy.ToLower();

            //List<int> candyCount = new List<int>();

            //foreach (string candies in candy)
            //{
            //    if (candies == searchCandy)
            //    {
            //        candyCount.Add(1);
            //    }
            //    else
            //    {
            //        Console.WriteLine("We do not have that Candy.");
            //        break;
            //    }

            //}
            //Console.WriteLine(candyCount.Count);


            List<string> candy = new List<string>() { "snicker", "snicker", "reeses", "butterfinger" };
            List<string> listedCandy = new List<string> { };
            Console.WriteLine("This program checks for duplicates in a list.");


            foreach (string candies in candy)
            {
                if (!listedCandy.Contains(candies))
                {
                    Console.WriteLine(candies);
                    listedCandy.Add(candies);
                }
                else
                {
                    Console.WriteLine(candies + " duplicate.");

                }

            }


            Console.ReadLine();     //ReadLine to keep program from closing

        }
    }
}
