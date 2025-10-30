using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);
            if (age >= 18)
            {
                Console.WriteLine("Your 18+ :D");
            }
            else
            {
                Console.WriteLine("Not old enough");
            }
            //Boo!did i scare you?
        }
    }
}
