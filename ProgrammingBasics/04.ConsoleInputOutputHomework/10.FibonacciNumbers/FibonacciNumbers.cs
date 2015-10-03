using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter n:");
            long n = long.Parse(Console.ReadLine());
            Console.Write("The Fibonacci sequance is: ");
            for (long i = 0, previos = 0, current = 1; i < n; i++)
            {
                Console.Write("{0} ", previos);
                long temp = current;
                current += previos;
                previos = temp;
            }
            Console.WriteLine();
       }
    }
}
