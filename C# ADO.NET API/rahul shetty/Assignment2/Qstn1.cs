using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Qstn1
    {
        int chicken;
        int cow;
        int pig;
        int result;
        public int calculate(int chicken , int cow, int pig)
        {
            this.chicken = chicken*2;
            this.cow = cow*4;
            this.pig = pig*4;

            result=this.chicken+this.cow+this.pig;
            return result;
        }
    }
}
