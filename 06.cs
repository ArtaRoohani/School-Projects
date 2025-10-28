using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////LOOPS
            ////The wrong way ---
            //Console.WriteLine("HELLO1!!1!11!");
            //Console.WriteLine("HELLO1!!1!11!");
            //Console.WriteLine("HELLO1!!1!11!");
            //Console.WriteLine("HELLO1!!1!11!");
            //Console.WriteLine("HELLO1!!1!11!");
            //Console.WriteLine("HELLO1!!1!11!");

            ////The right way ---
            Console.Write("Type what you want to repeat: ");
            string message = Console.ReadLine();

            Console.Write("How many times do you want to loop? ");
            int loopCounter = Convert.ToInt32(Console.ReadLine());
            //If Else statement
            if (loopCounter <= 0)
            {
                Console.WriteLine("Enter a value above 0 you donut >:(");
            }
            else
            {
                for (int i = 0; i < loopCounter; i++)
                {
                    Console.WriteLine(message);
                }

                for (int i = 0; i < loopCounter; i++)
                {
                    Console.WriteLine("Hi");
                }
                for (int x = 0; x < loopCounter; x++)
                {
                    Console.WriteLine(x);
                }
                Console.ReadLine();

            }
        }
    }
}
