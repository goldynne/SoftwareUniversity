using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BiggestOfFiveNumbers
{
    class BiggestOfFiveNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the second number: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the third number: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the fourth number: ");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the fifth number: ");
            double e = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double biggest = a;
            if (b > a && b > c && b > d && b > e)
            {
                biggest = b;
            }
            else if (c > a && c > b && c > d && c > e)
            {
                biggest = c;
            }
            else if (d > a && d > b && d > c && d > e)
            {
                biggest = d;
            }
            else if (e > a && e > b && e > c && e > d)
            {
                biggest = e;
            }

            Console.WriteLine("The biggest number is: " + biggest);
        }
    }
}
