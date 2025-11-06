using System;

namespace _08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");
            if (int.TryParse(Console.ReadLine(), out int legalAge))
            {
                Console.WriteLine("Enter your name:");
                string name = Console.ReadLine();
                Console.WriteLine("Hello " + name);
                Console.WriteLine("Your age is: " + legalAge);
                Console.WriteLine("Which means...");

                if (legalAge >= 18)
                {
                    Console.WriteLine("You are an adult");
                }
                else
                {
                    Console.WriteLine("You are under the legal age");
                }
                Console.WriteLine("Am I right or am I right?");
                for (int i = 0; i < 5; i++)
                {
                    switch (i)
                    {
                        case 0:
                            Console.WriteLine("one");
                            break;
                        case 1:
                            Console.WriteLine("two");
                            break;
                        case 2:
                            Console.WriteLine("three");
                            break;
                        case 3:
                            Console.WriteLine("four");
                            break;
                        case 4:
                            Console.WriteLine("five");
                            break;
                    }
                }
                Console.WriteLine("By the way, hello " + name);
            }
            else
            {
                Console.WriteLine("Invalid age entered. Please enter a valid number.");
            }
        }
    }
}
