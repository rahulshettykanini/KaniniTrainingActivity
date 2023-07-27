using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Qstn5
    {
        int age;
        bool BreakStatus;

        public bool calculate(int age , bool BreakStatus)
        {
            if (age>=18 && BreakStatus == false)
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
