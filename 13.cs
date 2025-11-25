using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //prompt for the player to enter a number
            Console.WriteLine("Enter a number:");
            string inputnumber = Console.ReadLine();

            //My way of turning the inputed string number into a int
            int number = int.Parse(inputnumber);

            //Checking if the number is even or odd
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
        }
    }
}
