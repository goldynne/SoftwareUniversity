using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NumberComparer
{
    class NumberComparer
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter second number: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (a.CompareTo(b))
            {
                case 1:
                    Console.WriteLine("{0} > {1}", a, b);
                    break;
                case -1:
                    Console.WriteLine("{0} < {1}", a, b);
                    break;
                default:
                    Console.WriteLine("{0} == {1}", a, b);
                    break;
            }
        }
    }
}
