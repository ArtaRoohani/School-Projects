using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1___Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Asks the user to input the first number
            Console.Write("Enter the first number: ");
            string input1 = Console.ReadLine();

            //Asks the user to input the second number
            Console.Write("Enter the second number: ");

            //Writes out the second input
            string input2 = Console.ReadLine();

            //adds the two inputs
            string sum = Add(input1, input2);

            //subtracts the two inputs
            string difference = Subtract(input1, input2);

            //multiplies the two inputs
            string product = Multiply(input1, input2);

            //divides the two inputs
            string quotient = Divide(input1, input2);

            //Writes out a text and adds the sum variable
            Console.WriteLine($"The sum of the numbers is: {sum}");

            //Writes out a text and adds the difference variable
            Console.WriteLine($"The difference of the numbers is: {difference}");

            //Writes out a text and adds the product variable
            Console.WriteLine($"The product of the numbers is: {product}");

            //Writes out a text and adds the quotient variable
            Console.WriteLine($"The quotient of the numbers is: {quotient}");

            //Prevents the console from closing right after printin the stuff out
            Console.ReadLine();
        }

        //Function that adds the two numbers and also adds the mathematical symbols in the middle of the two numbers
        static string Add(string num1, string num2)
        {
            return num1 + num2;
        }
        static string Subtract(string num1, string num2)
        {
            return num1 + "-" + num2;
        }
        static string Multiply(string num1, string num2)
        {
            return num1 + "*" + num2;
        }
        static string Divide(string num1, string num2)
        {
            return num1 + "/" + num2;
        }
    }
}
