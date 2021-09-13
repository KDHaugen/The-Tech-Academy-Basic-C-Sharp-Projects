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
            Employee employee = new Employee();

            employee.fName = new List<string>() { "Joe", "Karli", "Kyle", "Joe", "Elli", "Mariko", "Don", "Paul", "Matt", "Jerry"};
            employee.lName = new List<string>() { "Smith", "Hayashi", "Haugen", "Smoke", "Eri", "Tsuki", "Hagen", "Hollwedel", "Belcher", "Smith"};
            employee.ID = new List<int>() {1,2,3,4,5,6,7,8,9,10};

            int count = employee.fName.Count(x => x == "Joe");

            List<string> joeList = employee.fName.Where(x => x == "Joe").ToList();

            List<int> aboveFive = employee.ID.Where(x => x > 5).ToList();

           
            for(int j = aboveFive[0]-1; j < aboveFive[0]+aboveFive.Count-1; j++)
            {
                Console.WriteLine(employee.ID[j]+" "+employee.fName[j] + " " + employee.lName[j]);
            }


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
