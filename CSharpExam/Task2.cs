using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1___Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Asks the user to input a number
            Console.WriteLine("Please enter a number:");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double number))
            {
                //Checks if the inserted number is above zero
                if (number > 0)
                {
                    Console.WriteLine("The number is positive");
                }

                //Checks if the number is zero or not
                else if (number == 0)
                {
                    Console.WriteLine("The number is zero");
                }

                else
                {
                    Console.WriteLine("The number is negative");
                }

                //If none of the above is true then its invalid
            }
            else
            {
                Console.WriteLine("Invalid input");

            }
        }
    }
}
