﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc1
{
    class swapnumber
    {
        static void Main()
        {
            string myStr, rev;
            myStr = "abcd";
            rev = "";
            Console.WriteLine("String is {0}", myStr);
            // find string length
            int len;
            len = myStr.Length - 1;
            while (len >= 0)
            {
                rev = rev + myStr[len];
                len--;
            }
            Console.WriteLine("Reversed String is {0}", rev);
            Console.ReadLine();
        }
    }
}
