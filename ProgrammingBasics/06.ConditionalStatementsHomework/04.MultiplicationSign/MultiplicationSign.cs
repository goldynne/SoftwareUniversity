using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Please enter second number: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Please enter third number: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine();

            if ((a < 0 && b > 0 && c > 0) || (a > 0 && b < 0 && c > 0)
                || (a > 0 && b > 0 && c < 0))
            {
                Console.WriteLine("-");
            }
            else if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("0");
            }
            else if ((a < 0 && b < 0 && c > 0)
                || (a < 0 && b > 0 && c < 0)
                || (a > 0 && b < 0 && c < 0))
            {
                Console.WriteLine("+");
            }
            else if (a < 0 && b < 0 && c < 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("+");
            }
        }
    }
}
        