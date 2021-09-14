using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const_and_Var
{
    class chainedCon
    {
        private int num;
        private string word;

        public chainedCon() : this(0, "")
        {

        }

        public chainedCon(int num, string word)
        {
            this.num = num;
            this.word = word;
        }

        public chainedCon(int num) : this(num, "")
        {

        }

        public chainedCon(string word) : this(0, word)
        {

        }
    }
}
