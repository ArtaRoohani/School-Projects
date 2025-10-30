using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class Program
    {
        static void Main(string[] args)
        {
                        ////The right way ---
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
                    Console.WriteLine(i);
                }
                Console.WriteLine("The loop is done");
            }
        }
    }
}
