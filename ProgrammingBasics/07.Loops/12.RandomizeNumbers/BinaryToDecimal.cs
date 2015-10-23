using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.RandomizeNumbers
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            //    Problem 13. Binary to Decimal Number

            //    Using loops write a program that converts a binary integer number to its decimal form.
            //    The input is entered as string. The output should be a variable of type long.
            //    Do not use the built-in .NET functionality.
            Console.WriteLine("Please enter your binary number : ");
            string binaryNumber = Console.ReadLine();

            int number = 0;
            int powerOfN = 1;
            for (int i = 0; i < binaryNumber.Length; i++)
            {
                int signN = binaryNumber[i] - 48;
                if (signN == 1)
                {
                    number += signN * powerOfN;
                }
                powerOfN *= 2;
            }
            Console.WriteLine(number);
        }
    }
}
