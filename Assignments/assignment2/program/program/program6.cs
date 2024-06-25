using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    //Write a program in C# to accept a word from the user and display the reverse of it.
    public class program6
    {
        public static String reverselength()
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            

            
            string reversedWord = "";

            
            for (int i = word.Length - 1; i >= 0; i--)
            {
                
                //Console.Write("{0}", word[i]);
                reversedWord += word[i];
            }
            Console.WriteLine($"The reversed word without using reverse function: {reversedWord}");

            return reversedWord;
            

        }
    }
}
