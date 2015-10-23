using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the second number b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine();

            if (a > b)
            {
                double c = b;
                b = a;
                a = c;
                Console.WriteLine(a + " " + b);
            }
            else
            {
                Console.WriteLine(a + " " + b);
            }
        }
    }
}
