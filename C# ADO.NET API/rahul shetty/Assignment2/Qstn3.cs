
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Qstn3
    {
        double prob;
        double pay;
        double prize;

        public bool calculate(double prob,double prize,double pay)
        {
            this.prob = prob;
            this.prize = prize;
            this.pay = pay;
        
            if ((this.prob*this.prize)>this.pay && this.pay>1)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
