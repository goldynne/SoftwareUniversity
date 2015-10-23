using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sort3NumbersNestedIfs
{
    class Sort3NumbersNestedIfs
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Please enter the second number: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Please enter the third number: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double biggest = 0;
            double bigger = 0;
            double small = 0;

            if (a > b && a > c)
            {
                biggest = a;
                if (b > c)
                {
                    bigger = b;
                    small = c;
                }
                else
                {
                    bigger = c;
                    small = b;
                }
            }
            else if (b > a && b > c)
            {
                biggest = b;
                if (a > c)
                {
                    bigger = a;
                    small = c;
                }
                else
                {
                    bigger = c;
                    small = a;
                }
            }
            else if (c > a && c > b)
            {
                biggest = c;
                if (a > b)
                {
                    bigger = a;
                    small = b;
                }
                else
                {
                    bigger = b;
                    small = a;
                }
            }

            Console.WriteLine("{0} {1} {2}", biggest, bigger, small);
        }
    }
}
