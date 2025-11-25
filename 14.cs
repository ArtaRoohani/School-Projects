using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Define and initialize num and length with values 7 and 6, respectively
            int num = 7;
            int length = 6;

            //Created a int array with size same and length
            int[] multiplicationArray = new int[length];

            //repeats multiplication
            for (int i = 0; i < length; i++)
            {
                multiplicationArray[i] = num * (i + 1);
            }
            //prints a value in the array
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(multiplicationArray[i]);

            }

            //prints the entire array 
            Console.WriteLine($"Multiplication table for {num} up to length {length}: {string.Join(", ", multiplicationArray)}");
        }
    }
}
