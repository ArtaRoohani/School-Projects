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

            Console.Write("Enter grade between 0-5; ");
            int grade = Convert.ToInt32(Console.ReadLine());
            switch (grade)

            {
                case 0:
                    Console.WriteLine("Fail");
                    break;
                case 1:
                    Console.WriteLine("Needs improvement");
                    break;
                case 2:
                    Console.WriteLine("Ok");
                    break;
                case 3:
                    Console.WriteLine("Satisfactory");
                    break;
                case 4:
                    Console.WriteLine("Good");
                    break;
                case 5:
                    Console.WriteLine("Excelent");
                    break;
                default:
                    Console.WriteLine("Dont even think about bypassing this grade system! >:(");
                    break;
            }
        }
    }
}
