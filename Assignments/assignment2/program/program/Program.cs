using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a;
            int b;
            
            Console.WriteLine("program1");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Value of a is {0}", a);
            Console.WriteLine("Value of b is {0}", b);
            Console.WriteLine("Result is {0}", program1.calculateSum(a, b));
            
            Console.WriteLine("program2");
            Console.WriteLine("{0}!! ",program2.findDay());

            Console.WriteLine("program3");
            Console.WriteLine("Array average value is {0}",program3.Avgcalc());

            Console.WriteLine("program3.1");
            Console.WriteLine("Array Maximum value is {0}",program3.maxvalue());

            Console.WriteLine("program3.2");
            Console.WriteLine("Array Minimum value is {0}", program3.minvalue());

            Console.WriteLine("program4");
            Console.WriteLine("Total marks is {0}", program4.MarksValue());

            Console.WriteLine("program5");
            Console.WriteLine("Length of string  is {0}", program5.length());

            Console.WriteLine("program6");
            Console.WriteLine("{0}", program6.reverselength());

            Console.WriteLine("program7");
            Console.WriteLine("{0}", program7.sizeofwords());


            Console.ReadLine();
        }
    }
}
