using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC3
{  
       class Box
        {
            public double Length { get; set; }
            public double Breadth { get; set; }

            public Box(double length, double breadth)
            {
                Length = length ;
                Breadth = breadth;

             }

        public Box Add(Box otherBox)
            {
                double newLength = Length + otherBox.Length;
                double newBreadth = Breadth + otherBox.Breadth;
                 //double newLength1 = Length + otBreadth;
                return new Box(newLength, newBreadth);
            }

            public void DisplayDetails()
            {
                Console.WriteLine($"Box details: Length = {Length}, Breadth = {Breadth}");
            }
        }

        class Test
        {
            static void Main(string[] args)
            {
                Box box1 = new Box(50, 3);
                Box box2 = new Box(2, 40);

                Box box3 = box1.Add(box2);
                box3.DisplayDetails();
                Console.ReadLine();
            }
        }
    }


