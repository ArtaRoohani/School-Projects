using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //making the user input values.

            //Width
            Console.WriteLine("Enter the width of the triangle:");
            int Width = int.Parse(Console.ReadLine());
            
            //Height
            Console.WriteLine("Enter the height of the triangle:");
            int Height = int.Parse(Console.ReadLine());


            //Calculatin the area of the triangle.
            int area = (Width * Height) / 2;

            //Printin out the area.
            Console.WriteLine("The area of the triangle is: " + area);
        }
    }
}
