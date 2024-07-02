using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
     public class Box
    {
       
        public double Length { get; set; }
        public double Breadth { get; set; }

        public Box(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        public Box Add(Box otherBox)
        {
            double newLength = Length + otherBox.Length;
            double newBreadth = Breadth + otherBox.Breadth;
            return new Box(newLength, newBreadth);
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            Box box1 = new Box(10, 3);
            Box box2 = new Box(2, 40);

            Box resultBox = box1.Add(box2);

            Console.WriteLine($"Box 1: Length = {box1.Length}, Breadth = {box1.Breadth}");
            Console.WriteLine($"Box 2: Length = {box2.Length}, Breadth = {box2.Breadth}");
            Console.WriteLine($"Result Box: Length = {resultBox.Length}, Breadth = {resultBox.Breadth}");
            Console.ReadLine();
        }
    }
}