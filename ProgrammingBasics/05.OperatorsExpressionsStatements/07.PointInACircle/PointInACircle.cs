using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PointInACircle
{
    class PointInACircle
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter point's x: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Please enter point's y: ");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine();
            double centerX = 0;
            double centerY = 0;
            double radius = 2;

            bool isPointInside = Math.Pow((x - centerX), 2) + Math.Pow((y - centerY), 2) < Math.Pow(radius, 2);
            bool isPointOnTheCircle = Math.Pow((x - centerX), 2) + Math.Pow((y - centerY), 2) == Math.Pow(radius, 2);
            if (isPointInside == true)
            {
                Console.WriteLine("Is the point inside the circle? -> " + isPointInside);
            }
            else if (isPointOnTheCircle == true)
            {
                Console.WriteLine("Is the point on the circle? -> " + isPointOnTheCircle);
            }
            else
            {
                Console.WriteLine("Point is outside the cirlce.");
            }
        }
    }
}
