using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Qstn4
    {
        private int n;

        public int N { get => n; set => n = value; }

        public int calculate(int n)
        {
            this.n = n;
            return n * n;
        }
    }
}
