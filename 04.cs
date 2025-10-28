using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////IfStatement
            //Console.WriteLine("Enter your age: ");
            //string ageInput = Console.ReadLine();
            //int age = Convert.ToInt32(ageInput);

            //// == > >= < <= != || &&
            //if (age > 18 && age <= 25)
            //{
            //    Console.WriteLine("you are between 18 and 25");
            //}
            //else if (age >= 26)
            //{
            //    Console.WriteLine("You are 26 or older");
            //}
            //if (age < 0 || age > 150)
            //{
            //    Console.WriteLine("!Invalid age!");
            //}
            //else
            //{
            //    if (age >= 18 && age <= 25)
            //    {
            //        Console.WriteLine("Your are between 18 and 25");
            //    }
            //    else if (age >= 26 && age <= 99)
            //    {
            //        Console.WriteLine("You are 26 or older");
            //   }
            // }

            //Example 2
            Console.WriteLine("Enter the first number: ");
            string numberAInput = Console.ReadLine();
            int numberA = Convert.ToInt32(numberAInput);

            Console.WriteLine("Enter the first number: ");
            string numberBInput = Console.ReadLine();
            int numberB = Convert.ToInt32(numberBInput);

            int answer = numberA * numberB;

            //Console.Write("Value of " + numberA + " x " + numberB + ": " + answer);
            Console.Write("Value of " + numberA + " x " + numberB + ": ");
            string answerAOutput = Console.ReadLine();
            int actualAnswer = Convert.ToInt32(answerAOutput);

            if (answer == actualAnswer)
            {
                Console.WriteLine("Well done");
            }
            else if (answer != actualAnswer)
            {
                Console.WriteLine("Close but its wrong");
            }
            Console.ReadLine();
        }
    }
}
