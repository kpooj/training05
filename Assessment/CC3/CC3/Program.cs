using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC3
{
    public class Cricket
    {
        public void Pointscalculation(int  no_of_matches)
        {
            int sum = 0;

            for (int i = 1; i <= no_of_matches; i++)
            {
                Console.Write($"Enter the score for match of IPL {i}: ");
                int score = Convert.ToInt32(Console.ReadLine());
                sum += score;
            }

            double average = (double)sum / no_of_matches;

            Console.WriteLine($"\nThe sum of scores for  all matches {no_of_matches} matches is: {sum}");
            Console.WriteLine($"The average score of all matches is: {average:F3}"); // Format average to three decimal places
        }

        public static void Main(string[] args)
        {
            Cricket cricket = new Cricket();

            Console.Write("Enter the number of matches played in the IPL : ");
            int no_of_matches = Convert.ToInt32(Console.ReadLine());

            cricket.Pointscalculation(no_of_matches);
            Console.ReadLine();
        }
    }
}

//Pointscalculation(int no_of_matches)