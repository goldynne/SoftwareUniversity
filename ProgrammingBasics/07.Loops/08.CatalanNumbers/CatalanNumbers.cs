using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main(string[] args)
        {
            //Problem 8. Catalan Numbers

            //In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
            //Write a program to calculate the nth Catalan number by given n (1 < n < 100).
            Console.WriteLine("Please enter  n : ");
            int n = int.Parse(Console.ReadLine());
            BigInteger fact1 = 1;
            BigInteger fact2 = 1;
            BigInteger fact3 = 1;
            for (int i = 1; i <= (2 * n); i++)
            {
                fact1 *= i;

            }
            for (int j = 1; j <= (n + 1); j++)
            {
                fact2 *= j;

            }
            for (int k = 1; k <= n; k++)
            {
                fact3 *= k;
            }
            BigInteger calculate = (fact1) / (fact2 * fact3);
            Console.WriteLine(calculate);
        }
    }
}
