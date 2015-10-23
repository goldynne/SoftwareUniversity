using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BiggestOf3Numbers
{
    class BiggestOf3Numbers
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter the first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the second number: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the third number: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double biggest = a;
            if (b > a && b > c)
            {
                biggest = b;
            }
            else if (c > a && c > b)
            {
                biggest = c;
            }

            Console.WriteLine("The biggest number is: " + biggest);
        }
    }
}
