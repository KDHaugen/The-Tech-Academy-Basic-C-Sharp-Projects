using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Method_assignment
{
    class Operator
    {
        public Operator()
        {
            userInt = Program.userInp;
            userDouble = Program.userInp * 2;
            userTriple = Program.userInp * 3;
            userQuad = Program.userInp * 4;
        }
        public static int userInt { get; set; }
        public static int userDouble {get; set;}
        public static int userTriple {get; set;}
        public static int userQuad {get; set;}

    }
}
