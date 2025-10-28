using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //    //Loop
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine(i);
        //    }

        //    int x = 0;
        //    //While loop
        //    while (x < 10)
        //    {
        //        Console.WriteLine(x);
        //        x++;
        //    }

            Console.Write("Enter the first number: ");
            string numberAInput = Console.ReadLine();
            int numberA = int.Parse(numberAInput);

            Console.Write("Enter the second number: ");
            string numberBInput = Console.ReadLine();
            int numberB = int.Parse(numberBInput);
            Console.WriteLine();

            int answer = numberA * numberB;
            int actualAnswer = 0;

            Console.Write("Value of " + numberA + " * " + numberB + ": ");
            Console.WriteLine();

            //while (answer != actualAnswer)
            //{
            //   Console.Write("Enter your answer: ");
            //    string answeraoutput = Console.ReadLine();
            //    actualAnswer = Convert.ToInt32(answeraoutput);

            //    if (answer != actualAnswer)
            //    {
            //        Console.WriteLine("Close but it wasa wrong");
            //    }
            //}
            do
            {
                Console.Write("Enter your answer");
                string answerInput = Console.ReadLine();
                actualAnswer = Convert.ToInt32(answerInput);

                if(answer != actualAnswer)
                {
                    Console.WriteLine("Close but it was wrong");
                    Console.WriteLine();    
                }
            } while (answer != actualAnswer);
            Console.WriteLine("Well done");
            Console.ReadLine();
        }
    }
}
