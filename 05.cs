using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Switch statement

            Console.Write("Enter a day of the week; ");
            int day = Convert.ToInt32(Console.ReadLine());

            //if(day == 1)
            //{
            //    Console.WriteLine("Monday");
            //}
            //else if (day == 2 || day == 3)
            //{
            //    Console.WriteLine("Tuesday ");
            //}
            //else 
            //{
            //    Console.WriteLine("Invalid, Enter a value between 1 and 7");
            //}

            switch (day)

            {
                case 1:
                    Console.WriteLine("Mon");
                    break;
                case 2:
                    Console.WriteLine("Tue");
                    break;
                case 3:
                    Console.WriteLine("Wed");
                    break;
                case 4:
                    Console.WriteLine("Thu");
                    break;
                case 5:
                    Console.WriteLine("Fri");
                    break;
                case 6:
                    Console.WriteLine("Sat");
                    break;
                case 7:
                    Console.WriteLine("Sun");
                    break;
                default:
                    Console.WriteLine("Invalid, Enter a value between 1 and 7");
                    break;
            }
        }
    }
}
