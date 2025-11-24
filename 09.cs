using System;

namespace Booleans
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //boolean
            bool isTrue = true;
            bool isFalse = false;

            //Print boolean
            Console.WriteLine($"isTrue: {isTrue}");
            Console.WriteLine($"isFalse: {isFalse}");

            //Logical
            Console.WriteLine($"Logical AND: {isTrue && isFalse}");//False
            Console.WriteLine($"Logical OR: {isTrue || isFalse}");//True
            Console.WriteLine($"Logical NOT for true: {!isTrue}");//False
            Console.WriteLine($"Logical NOT for false: {!isTrue}");//True

            //Comparison
            int num1 = 200;
            int num2 = 100;
            int num3 = 50;
            int num4 = num1;

            bool resultNot = !isTrue;

            //Boolean expression
            bool expression1 = (num1 > num3) && isTrue;
            bool expression2 = (num2 < num4) && isFalse;

            Console.ReadLine();

        }
    }
}