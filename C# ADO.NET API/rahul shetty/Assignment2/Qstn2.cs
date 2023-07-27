using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Qstn2
    {
        int win;
        int draw;
        int loss;
        int result;

        public int calculate(int win,int draw,int loss)
        {
            this.win = win*3;
            this.draw = draw*1;
            this.loss = loss*0;

            this.result = this.win + this.draw + this.loss ;
            return this.result;
        }
    }
}
