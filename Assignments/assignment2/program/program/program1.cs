using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    //1. Write a C# program to compute the sum of two given integers. If two values are the same,
    //return the triple of their sum.
    public class program1
    {
        public static int calculateSum(int a, int b)

        {
            if (a == b)
            {
                return 3 * (a + b);
            }
            else
            {
                return (a + b);
            }
        }
    }
}
