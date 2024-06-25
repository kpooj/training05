using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poisitive_or_negative_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Value of a is {0} ", a);
            if (a >= 0)
                Console.WriteLine("Number is positive {0}", a);
            else
                Console.WriteLine("Number is negative{0}", a);
            Console.ReadLine();
        }
    }
}
