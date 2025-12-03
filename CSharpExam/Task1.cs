using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1___Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Asks the user for an integer and converts it to int.
            Console.WriteLine("Please enter an integer:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            //Asks the user for a double and converts it to double.
            Console.WriteLine("Please enter a double:");
            double userDouble = Convert.ToDouble(Console.ReadLine());
            
            //Asks the user for a float and converts it to float.
            Console.WriteLine("Please enter a float:");
            float userFloat = float.Parse(Console.ReadLine());

            //Asks the user for a string. 
            Console.WriteLine("Please enter a string:");
            string userString = Console.ReadLine();

            //Print all four inputs in the console.
            Console.WriteLine("You have entered the following values:");
            Console.WriteLine("Integer: " + userInput);

            //After printing the inputs, print brief explanations of what int, float, double, and string are.
            Console.WriteLine("Double: " + userDouble);
            Console.WriteLine("Float: " + userFloat);
            Console.WriteLine("String: " + userString);
            Console.WriteLine("\nExplanations:");
            Console.WriteLine("An integer (int) is a whole number without a decimal point.");
            Console.WriteLine("A double is a data type that can store decimal numbers with double precision.");
            Console.WriteLine("A float is a data type that can store decimal numbers with single precision.");
            Console.WriteLine("A string is a sequence of characters used to represent text.");


        }
    }
}
