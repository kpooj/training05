using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    //Write a program in C# to accept two words from user and find out if they are same.
    public class program7

    {
        public static int sizeofwords()
        {

            Console.Write("Enter the first word: ");
            string word1 = Console.ReadLine();

            Console.Write("Enter the second word: ");
            string word2 = Console.ReadLine();

            // Compare the words (case-insensitive)
            if (string.Equals(word1, word2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("The words are the same.");
            }
            else
            {
                Console.WriteLine("The words are different.");
            }
            return 0;
            
        }

    }
}
