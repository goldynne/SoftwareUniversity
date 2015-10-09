using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PointInCircleNOutRectangle
{
    class PointInCircleNOutRectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first cordinate X:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second cordinate Y:");
            double y = double.Parse(Console.ReadLine());

            if ((((x - 1) * (x - 1)) + ((y - 1) * (y - 1))) <= (1.5 * 1.5))
            {
                if (y > 1)
                {
                    Console.WriteLine("It is in the circle and outside the rectangle.");
                }
                else
                {
                    Console.WriteLine("It is not in the circle and outside of the rectangle.");
                }
            }
        }
    }
}
