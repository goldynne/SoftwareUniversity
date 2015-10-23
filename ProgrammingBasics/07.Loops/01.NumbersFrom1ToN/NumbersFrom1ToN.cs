using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.NumbersFrom1ToN
{
    class NumbersFrom1ToN
    {
        static void Main(string[] args)
        {
            //Problem 1. Numbers from 1 to N

            //Write a program that enters from the console a positive integer n and prints all the numbers 
            //from 1 to n, on a single line, separated by a space.
            Console.WriteLine("Please enter your number:");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= n)
            {
                Console.Write("{0} ", i);
                i++;
            }
        }
    }
}
