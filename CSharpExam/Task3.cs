using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1___Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creates two arrays. A string and a Int
            string[] names = { "Bob", "Steve", "Nina" };
            int[] numbers = { 5, 57, 87, 1, 150, 32, 14 };

            //Loop through the first array and prints goodbye for each name.
            foreach (string name in names)
            {
                Console.WriteLine("Goodbye " + name);
            }

            //Sorts the second array in ascending order.
            Array.Sort(numbers);

            //Removes the last element (highest number) from the array.
            Array.Resize(ref numbers, numbers.Length - 1);

            ///Prints out the array and also adds a ",".
            Console.WriteLine(string.Join(", ", numbers));
            Console.ReadLine();

        }
    }
}
