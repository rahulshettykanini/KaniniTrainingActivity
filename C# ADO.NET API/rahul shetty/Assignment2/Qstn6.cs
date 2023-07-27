using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Qstn6
    {
        int cups;
        int Additional = 0;
        public int calculate(int cups)
        {
            this.cups = cups;
            Additional += this.cups/6 ;
            return this.cups+Additional;
        }
    }
}
