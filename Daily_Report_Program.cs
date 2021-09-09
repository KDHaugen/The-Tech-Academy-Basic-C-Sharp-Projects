using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)

        {
            //Welcome message for students for their daily report
            Console.WriteLine("The Tech Academy."); 
            Console.WriteLine("Student Daily Repoty.");


            Console.WriteLine("What is your name?");        //Prompting text for Name Quesition
            string yourName = Console.ReadLine();           //Input line for user to answer Name Question 
            Console.WriteLine("Your Name is: " + yourName); //Confirmation of user input as string.

            Console.WriteLine("What course are you on?");           //Prompt for "which course" question
            string courseTitle = Console.ReadLine();                //Input line for user for "which course" question
            Console.WriteLine("Your currently on: " + courseTitle); //Confimation of user input as string.

            Console.WriteLine("What page number are you on?");          //Prompt for "page number" question.
            string pageNumber = Console.ReadLine();                     //Input line for use for  "page number" question.
            Console.WriteLine("Your currently on page: " + pageNumber); //Confirmation of user input as string.

            Console.WriteLine("Do you need help with anything? Please reply True or False.");   //Prompt for "help" question.
            string needHelp = Console.ReadLine();                                               //Input line for "help" question.
            bool needHelpBool = Convert.ToBoolean(needHelp);                                    //Convert string input into boolens for "help" question.
            Console.WriteLine("You need help: " + needHelpBool);                                //Confirmation of user input given as a boolean.

            Console.WriteLine("Is there any feedback you'd like to provide? Please be specific");   //Prompt for "feedback" question.
            string feedbackSub = Console.ReadLine();                                                //Input line for "help" question.
            Console.WriteLine("Your feed back is: " + feedbackSub);                                 //Confirmation of user input as string.

            Console.WriteLine("How many hours did you study today?");                               //Prompt for "hours studied" question.
            string hourStudied = Console.ReadLine();                                                //Input line "hours studied" question.
            int hourStudiedInt = Convert.ToInt32(hourStudied);                                      //Convert string input into interger.
            Console.WriteLine("You studied for " + hourStudiedInt + " hours");                      //Confirmation of user input as interger.

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!"); //Confirmation and thank you message for completing the Daily Survey.

            Console.ReadLine(); //End line to keep command open.
        }
    }
}
