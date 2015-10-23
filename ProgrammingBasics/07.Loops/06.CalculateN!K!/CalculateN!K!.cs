using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CalculateN_K_
{
    class CalculateNK
    {
        static void Main(string[] args)
        {
            //Problem 6. Calculate N! / K!

            //Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
            //Use only one loop.

            //input
            Console.WriteLine("Please enter n : ");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter k : ");
            double k = double.Parse(Console.ReadLine());

            //calculations
            double factorielN = 1;
            double factorielK = 1;
            double result = 0;

            for (int i = 1; i <= n; i++)
            {
                if (k > 0)
                {
                    factorielK *= k;
                    k--;
                }
                factorielN *= i;

            }

            //result
            result += (factorielN / factorielK);
            Console.WriteLine("The result is : {0}", result);
        }
    }
}
