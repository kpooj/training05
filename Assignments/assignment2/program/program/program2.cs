using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    //Write a C# Sharp program to read any day number as an integer and display the name of the day as a word.

    public class program2
    {

        public static string findDay()
        {
            Console.Write("Enter a day number (1-7): ");
            int dayNumber = int.Parse(Console.ReadLine());

            string dayName;
            switch (dayNumber)
            {
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                case 7:
                    dayName = "Sunday";
                    break;
                default:
                    dayName = "Invalid day number";
                    break;
            }

            dayName = "The name of day" +" "+ " is "+ dayName;

            return (dayName);

        }

    }
}
