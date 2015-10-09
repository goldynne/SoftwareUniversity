using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Trapezoids
{
    class Trapezoids
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the trapezoid's side a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the trapezoid's side b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the trapezoi's height h:");
            double h = double.Parse(Console.ReadLine());
            double area = ((a + b) / 2) * h;
            Console.WriteLine("The trapezoid's area is : {0}", area);
        }
    }
}
