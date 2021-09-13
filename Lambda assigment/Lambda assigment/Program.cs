using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_assigment
{
    class Program
    {
        static void Main(string[] args)
        {
                //Instatiate class Employee with obj employee
            Employee employee = new Employee();

                //assign a list of strings to fName and lname, and int to ID.
            employee.fName = new List<string>() { "Joe", "Karli", "Kyle", "Joe", "Elli", "Mariko", "Don", "Paul", "Matt", "Jerry"};
            employee.lName = new List<string>() { "Smith", "Hayashi", "Haugen", "Smoke", "Eri", "Tsuki", "Hagen", "Hollwedel", "Belcher", "Smith"};
            employee.ID = new List<int>() {1,2,3,4,5,6,7,8,9,10};

                //take count of employee.fName strings that are "Joe"
            int count = employee.fName.Count(x => x == "Joe");

                //create a list joeList from employee.fName that contains "Joe"
            List<string> joeList = employee.fName.Where(x => x == "Joe").ToList();

                //Create a list aboveFive from employee.ID where ID is
            List<int> aboveFive = employee.ID.Where(x => x > 5).ToList();

                //Create a loop that prints out a list of employee data from the list aboveFive

            for(int j = aboveFive[0]-1; j < aboveFive[0]+aboveFive.Count-1; j++)
            {
                Console.WriteLine(employee.ID[j]+" "+employee.fName[j] + " " + employee.lName[j]);
            }

                //Create a loop that prints out a list of employee data from the list joeList
            foreach (string joe in joeList)
            {
                Console.WriteLine("\n"+joe);
            }


            //for(int i = 0; i < employee.fName.Count; i++)
            //{
            //    Console.WriteLine(employee.ID[i]+" "+employee.fName[i] + " " + employee.lName[i]);
            //}

            //Console.WriteLine("\n There are " + count + " Joes in the company");
            Console.ReadLine();
        }
    }
}
