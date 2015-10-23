using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main(string[] args)
        {
            //Problem 9. Matrix of Numbers

            //Write a program that reads from the console a positive integer number n (1 = n = 20) 

            //and prints a matrix like in the examples below. Use two nested loops.
            Console.WriteLine("Please enter number n : ");
            short n = short.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int nums = i + j;
                    if (nums < 10)
                    {
                        Console.Write(nums + " ");
                    }
                    else
                    {
                        Console.Write((i + j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

