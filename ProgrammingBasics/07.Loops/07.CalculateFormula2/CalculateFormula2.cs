using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CalculateFormula2
{
    class CalculateFormula2
    {
        static void Main(string[] args)
        {
            //Problem 7. Calculate N! / (K! * (N-K)!)

            //In combinatorics, the number of ways to choose k different members out of a group of n different elements 
            //(also known as the number of combinations) is calculated 
            //by the following formula: formula For example, there are 2598960 ways to 
            //withdraw 5 cards out of a standard deck of 52 cards.
            //Your task is to write a program that calculates
            //n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.

            //input
            Console.WriteLine("Please enter n : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter K : ");
            int k = int.Parse(Console.ReadLine());

            //Calculations
            int factorielN = 1;
            int factorielKNK = 1;
            int result = 0;
            if (1 < k && n > k && n < 100)
            {
                for (int i = (k + 1); i <= n; i++)
                {
                    factorielN *= i;
                }
                for (int j = 1; j <= (n - k); j++)
                {
                    factorielKNK *= j;
                }
            }

            //results
            result += (factorielN / factorielKNK);
            Console.WriteLine(result);
        }
    }
}
