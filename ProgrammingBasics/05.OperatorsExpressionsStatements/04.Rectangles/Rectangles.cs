using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter rectangle's width: ");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Please enter rectangle's height: ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double perimeter = 2 * (width + height);
            double area = width * height;

            Console.WriteLine("The rectangle's perimeter is: {0}", perimeter);
            Console.WriteLine("The rectangle's area is: {0}", area);
        }
    }
}
