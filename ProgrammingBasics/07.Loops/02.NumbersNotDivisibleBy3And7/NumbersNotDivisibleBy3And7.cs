using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.NumbersNotDivisibleBy3And7
{
    class NumbersNotDivisibleBy3And7
    {
        static void Main(string[] args)
        {
            //Problem 2. Numbers Not Divisible by 3 and 7

            //Write a program that enters from the console a positive integer n 
            //and prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space.
            Console.WriteLine("Please enter you number:");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if ((i % 3 == 0) || (i % 7 == 0))
                {

                }
                else
                {
                    Console.Write("{0}, ", i);
                }


            }
            Console.WriteLine();
        }
    }
}
