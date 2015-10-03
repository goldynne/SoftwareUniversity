using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FormattingNumbers
{
    class FormattingNumbers
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
            string d = Convert.ToString((int)a, 2);
            string hex = Convert.ToString((int)a, 16);

            Console.WriteLine("|{0,-10}|{1,10}|{2,10:F2}|{3,-10:F3}|", hex, d.PadLeft(10, '0'), b, c);

        }
    }
}
