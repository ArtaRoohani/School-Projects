using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    class Program
    {
        class Circle
        {
            void Main(string[] args)
            {
                double Radius = 1.5;
                double area = CalculateArea(Radius);
                Console.WriteLine($"Math PI ({Math.PI}) * Radius ({Radius}) * Radius ({Radius}) = {area}");
                Console.WriteLine($"Area of the chircle is: {area.ToString(CultureInfo.InvariantCulture)}");
            }

            private static double CalculateArea(double Radius)
            {
                return Math.PI * Radius * Radius;
            }
        }
    }
}