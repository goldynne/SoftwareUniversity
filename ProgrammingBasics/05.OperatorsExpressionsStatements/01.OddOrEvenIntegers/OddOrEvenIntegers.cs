using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OddOrEvenIntegers
{
    class OddOrEvenIntegers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number to check if it is odd:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            bool isOdd = num % 2 != 0;

            Console.WriteLine("Odd? -> {0}", isOdd);
        }
    }
}
