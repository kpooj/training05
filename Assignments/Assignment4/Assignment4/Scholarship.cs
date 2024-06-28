using Assignment4;
using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{ 
   public class Scholarship
    {
        public int Merit(int marks, int fees)
        {
            int scholarshipAmount = 0;

            if (marks >= 70 && marks <= 80)
            {
                scholarshipAmount = (int)(0.2 * fees);
            }
            else if (marks > 80 && marks <= 90)
            {
                scholarshipAmount = (int)(0.3 * fees);
            }
            else if (marks > 90)
            {
                scholarshipAmount = (int)(0.5 * fees);
            }

            return scholarshipAmount;
        }
    }
}

// public class sub
//{
//    static void Main()
//    {
//        double marks = 85;
//        double fees = 10000;


//        Scholarship scholarshipCalculator = new Scholarship();
//        double result = scholarshipCalculator.Merit(marks, fees);

//        Console.WriteLine($"Scholarship amount for marks {marks} and fees {fees} is {result:C2}");
//        Console.ReadLine();
//    }
//}

public class Program
{
    public static void Main()
    {
        try
        {
            Scholarship scholarship = new Scholarship();

            Console.WriteLine("Enter marks:");
            int marks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter fees:");
            int fees = Convert.ToInt32(Console.ReadLine());

            int scholarshipAmount = scholarship .Merit(marks, fees);
            Console.WriteLine("Scholarship amount for marks " + marks + " and fees " + fees + ": " + scholarshipAmount);
            Console.ReadLine();
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter valid numbers.");
            Console.ReadLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
            Console.ReadLine();
        }
    }
}


