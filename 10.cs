using System;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 4;
            int num5 = 5;
            int num6 = 6;


            //Arithmetic operators
            Console.WriteLine($"Arithemtic Operators:");
            Console.WriteLine($"num1 + num2 = {num1 + num2}");// Addition
            Console.WriteLine($"num1 - num2 = {num1 - num2}");//Subtraction
            Console.WriteLine($"num1 * num2 = {num1 * num2}");//Multiplication
            Console.WriteLine($"num1 / num2 = {num1 / num2}");//Division
            Console.WriteLine($"num1 % num2 = {num1 % num2}");//Modules

            //Arithmetic operators (again)
            Console.WriteLine($"Arithemtic Operators:");
            Console.WriteLine($"num5 + num6 = {num5 + num6}");// Addition
            Console.WriteLine($"num5 - num6 = {num5 - num6}");//Subtraction
            Console.WriteLine($"num5 * num6 = {num5 * num6}");//Multiplication
            Console.WriteLine($"num5 / num6 = {num5 / num6}");//Division
            Console.WriteLine($"num5 % num6 = {num5 % num6}");//Modules

            //Assigment operators
            Console.WriteLine($"Assignment Operators:");
            Console.WriteLine($"num5 += 5 -> is: {num5 += num1}");
            Console.WriteLine($"num5 -= 5 -> is: {num5 -= num2}");
            Console.WriteLine($"nu53 *= 5 -> is: {num5 *= num3}");
            Console.WriteLine($"num5 /= 5 -> is: {num5 /= num4}");
            Console.WriteLine($"num5 %= 5 -> is: {num5 %= num6}");

            //Increment and Decrement operators
            Console.WriteLine($"Increment and Decrement operators:");
            Console.WriteLine($"num6++ is: {num6++}");// Postfix 
            Console.WriteLine($"++num6 is: {++num6}");// Prefix
            Console.WriteLine($"num6-- is: {num6--}");// Postfix
            Console.WriteLine($"--num6 is: {--num6}");// Predix

        }
    }
}