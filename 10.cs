using System;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 8;

            //Arithmetic operators
            Console.WriteLine($"Arithemtic Operators:");
            Console.WriteLine($"a + b = {a + b}");// Addition
            Console.WriteLine($"a - b = {a - b}");//Subtraction
            Console.WriteLine($"a * b = {a * b}");//Multiplication
            Console.WriteLine($"a / b = {a / b}");//Division
            Console.WriteLine($"a % b = {a % b}");//Modules

            //Comparison operators
            Console.WriteLine($"Comparison Operators:");
            Console.WriteLine($"a == b is: {a == b}");// Equal to
            Console.WriteLine($"a != b is: {a != b}");//Not equal to 
            Console.WriteLine($"a > b is: {a > b}");//Greater than
            Console.WriteLine($"a < b is: {a < b}");//Less than
            Console.WriteLine($"a >= b is: {a >= b}");//Greater than or equal to
            Console.WriteLine($"a <= b is: {a <= b}");//Less than or equal to

            //Assigment operators
            int c = 20;
            Console.WriteLine($"Assignment Operators:");
            Console.WriteLine($"c += 5 -> is: {c += 5}");// C = c + 5
            Console.WriteLine($"c -= 5 -> is: {c -= 5}");// C = c - 5
            Console.WriteLine($"c *= 5 -> is: {c *= 5}");// C = c * 5
            Console.WriteLine($"c /= 5 -> is: {c /= 5}");// C = c / 5
            Console.WriteLine($"c %= 5 -> is: {c %= 5}");// C = c % 5

            //Increment and Decrement operators
            int d = 10;
            Console.WriteLine($"Increment and Decrement operators:");
            Console.WriteLine($"d++ is: {d++}");// Postfix 
            Console.WriteLine($"++d is: {++d}");// Prefix
            Console.WriteLine($"d-- is: {d--}");// Postfix
            Console.WriteLine($"--d is: {--d}");// Predix

            //Logical operators
            bool x = true;
            bool y = false;
            Console.WriteLine($"Logical Operators:");
            Console.WriteLine($"x && y is {x && y}"); // AND
            Console.WriteLine($"x || y is {x || y}"); // OR
            Console.WriteLine($"!x is {!x}"); // NOT

            Console.ReadLine();

        }
    }
}
