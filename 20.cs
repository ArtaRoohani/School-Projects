using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    class Circle
    {
        //Making the variable
        public double Radius { get; }

        //Giving the variable the value
        public Circle(double radius)
        {
            Radius = radius;
        }

        //Calculating the area of the circle
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(1.5);
            double area = circle.CalculateArea();
            Console.WriteLine($"Area of the circle is: {area}");
        }
    }
}
//READ ME:I tried to make the code completely original and diffrent but i copied and pasted the script after failing to make it kinda close to the style i wanted it to be. Im kinda dissapointed so i tried to atleast explain the code.