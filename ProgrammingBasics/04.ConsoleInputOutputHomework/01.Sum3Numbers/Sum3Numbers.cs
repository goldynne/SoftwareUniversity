using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sum3Numbers
{
    class Sum3Numbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first real number: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the second real number: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the third real number: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double sum = a + b + c;

            Console.WriteLine("The sum is: {0}", sum);
        }
    }
}
