using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CalculateFormula
{
    class CalculateFormula
    {
        static void Main(string[] args)
        {
            //Problem 5. Calculate 1 + 1!/X + 2!/X2 + … + N!/XN

            //Write a program that, for a given two integer numbers n and x, calculates the sum 
            //S = 1 + 1!/x + 2!/x2 + … + n!/xn.
            //Use only one loop. Print the result with 5 digits after the decimal point.

            //input 
            Console.WriteLine("Please enter n : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter x : ");
            int x = int.Parse(Console.ReadLine());

            //calculate
            double sum = 1;
            double fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                sum += fact / Math.Pow(x, i);
            }
            Console.WriteLine("The sum is : S = {0:0.00000}", sum);
        }
    }
}
