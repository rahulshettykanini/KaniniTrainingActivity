using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Qstn7
    {

    public void calculate()
        {
            string[][] arr = new string[2][];
            arr[0] = new string[] { "new", "pander", "scoop" };
            arr[1] = new string[] { "er" };

            foreach (string s in arr[0])
            {
                Console.WriteLine(s + arr[1][0]);
            }
        }
    }
}
