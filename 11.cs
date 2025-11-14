using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StringLooping
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            string message = "Hello, World!";
            string reversedText = ReverseString(message);

            Console.WriteLine("Original message:");
            foreach (char c in message)
            {
                Console.WriteLine(c); 
            }

            Console.WriteLine("\nReversed message:"); 
            foreach (char c in reversedText)
            {
                Console.WriteLine(c);
            }
        }

        public static string ReverseString(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}

//Hejsan :) 