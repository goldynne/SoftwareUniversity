using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double perimeter = 2 * Math.PI * radius;
            double area = Math.PI * (Math.Pow(radius, 2));

            Console.WriteLine("Circle's perimeter: {0:F2}", perimeter);
            Console.WriteLine("Circle's area: {0:F2}", area);
        }
    }
}
