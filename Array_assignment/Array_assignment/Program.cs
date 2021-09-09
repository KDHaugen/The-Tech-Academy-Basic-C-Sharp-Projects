using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        string[] racers = { "Kyle Haugen", "Chad Bailey", "Paul Smith", "Matt Belcher", "Mike Jack", "Mitch Peterson" };
        Console.WriteLine("Folsom Marathon placement results. \n Please enter numerical placement to see runner's name:");
        string racerPlace = Console.ReadLine();
        int racerPlaceInt = Convert.ToInt32(racerPlace) - 1;
        if (racerPlaceInt <= 5)
        {
            Console.WriteLine(racers[racerPlaceInt]);
        }
        else
        {
            Console.WriteLine("There were no more than 6 racers in this race.");
        }

        List<string> candyList = new List<string>();
        candyList.Add("Reeses");
        candyList.Add("Hershey");
        candyList.Add("Snickers");
        candyList.Add("Pay Day");
        candyList.Add("Baby Ruth");

        Console.WriteLine("Please select a number between 1 and 5 to receive a free Candy Bar.");
        string candyPick = Console.ReadLine();
        int candyPickInt = Convert.ToInt32(candyPick) - 1;
        if(candyPickInt <= 4)
        {
            Console.WriteLine("You get a free " + candyList[candyPickInt] + "!");
        }
        else
        {
            Console.WriteLine("There were only 5 options, and now there are none.");
        }

        Console.ReadLine();


    }
}

