using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_equalequal_overload
{
    class Compare {
        int ID;
        public Compare()
        {
            ID = 0;
        }
        public Compare(int x)
        {
            ID = x;
        }
        public static bool operator == (Compare x, Compare y)
        {
            if (x.ID == y.ID)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool operator !=(Compare x, Compare y)
        {
            if (x.ID != y.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    class Program
    {
        static void Main(string[] args)
        {
            Compare ID1 = new Compare(1);
            Compare ID2 = new Compare(1);

                if (ID1 == ID2)
                    Console.WriteLine("Same ID");
                else
                    Console.WriteLine("Different ID");

            Console.ReadLine();

        }

        


        }
    }
}
