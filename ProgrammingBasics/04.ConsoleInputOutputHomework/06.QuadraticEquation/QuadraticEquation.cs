using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            Console.Write("Enter coeficient a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter coeficient b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter coeficient c: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double x1 = (-b - Math.Sqrt((Math.Pow(b, 2)) - (4 * a * c))) / (2 * a);
            double x2 = (-b + Math.Sqrt((Math.Pow(b, 2)) - (4 * a * c))) / (2 * a);
            

            Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
        }
    }
}
