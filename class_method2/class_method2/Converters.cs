using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_method2
{
    class Converters
    {   
            //Create method that doubles interger given
        public int intDoubler(int x)
        {
            return x * 2;
        }
            //Create method to convert given decimal to interger.
        public int decToInt(decimal x)
        {
            return Convert.ToInt32(x);
        }
        //Create method to convert given string to interger.
        public int stringToInt(string x)
        {
            return Convert.ToInt32(x);
        }
    }
}
