using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_catch_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try     //Open Try block
            {   
                    //Create a list in which the user picks an integer to divide the list by
                List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };            
                Console.WriteLine("Please enter a whole number to which divide the numbers 1-9.");
                int userNum = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < intList.Count; i++)
                {
                    int listDivInp = intList[i] / userNum;
                    Console.WriteLine(listDivInp);
                }
            }
                //If user inputs a non integer, display this error message
            catch (FormatException ex)
            {
                Console.Write("Please choose a positive whole number.");
            }   
                //If user inputs 0, display this error message
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please do not try to divide by zero.");
            }
                //finally Readline to keep program open even if program ends prematurely.
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
