using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        string[] racers = { "Kyle Haugen", "Chad Bailey", "Paul Smith", "Matt Belcher", "Mike Jack", "Mitch Peterson" };    //Create and fill string array(racers) with names
        Console.WriteLine("Folsom Marathon placement results. \n Please enter numerical placement to see runner's name:");  //Welcome user to program and prompt input
        string racerPlace = Console.ReadLine();                         //Input from User
        int racerPlaceInt = Convert.ToInt32(racerPlace) - 1;            //Convert string imput from user into an integer and subtract 1 to match array base 0.

        if (racerPlaceInt <= 5 && racerPlaceInt >= 0)                                         //Check if requested value is within array's range
        {
            Console.WriteLine(racers[racerPlaceInt]);                   //Display array value if valid input is given
        }
        else
        {
            Console.WriteLine("There were no more than 6 racers in this race.");        //Inform user that their input was invalid.
        }

        List<string> candyList = new List<string>();        //Create and fill string list "candyList"
        candyList.Add("Reeses");                    //Fill list with 5 candy varients
        candyList.Add("Hershey");
        candyList.Add("Snickers");
        candyList.Add("Pay Day");
        candyList.Add("Baby Ruth");

        Console.WriteLine("Please select a number between 1 and 5 to receive a free Candy Bar.");   //Prompt user to pick a valid integer as string.
        string candyPick = Console.ReadLine();                                                      //Take user input
        int candyPickInt = Convert.ToInt32(candyPick) - 1;                                          //Convert user string input into an integer and subtract one to match list base 0.
        if(candyPickInt <= 4 && candyPickInt >= 0)                                                                       //Check if user input was valid
        {
            Console.WriteLine("You get a free " + candyList[candyPickInt] + "!");                   //If valid display corresponding value from list candyList 
        }
        else
        {
            Console.WriteLine("There were only 5 options, and now there are none.");                //If value is invalid, user is notified.
        }

        Console.ReadLine();


    }
}

