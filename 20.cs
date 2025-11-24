using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWithMathMethods //Cant name it "20"
{
    internal class Program
    {
        class Circle
        {
            public double Radius;

            //Contructor
            public Circle(double radius)
            {
                Radius = radius;
            }

            //Method to calculate the perimeter
            public double GetPerimiter()
            {
                return 2 * Math.PI * Radius;
            }

            //Method to calculate the area
            public double GetArea()
            {
                return Math.PI * Math.Pow(Radius, 2);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Circle circle = new Circle(radius);

            double GetPerimiter = circle.GetPerimiter();
            double area = circle.GetArea();

            Console.WriteLine($"The GetPerimiter of the circle is: {GetPerimiter:F2}");
            Console.WriteLine($"The area of the circle is: {area:F2}");

        }
    }
}
