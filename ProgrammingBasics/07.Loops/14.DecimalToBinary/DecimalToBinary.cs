using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            //Problem 14. Decimal to Binary Number

            //Using loops write a program that converts an integer number to its binary representation.
            //The input is entered as long. The output should be a variable of type string.
            //Do not use the built-in .NET functionality.

            Console.WriteLine("Please enter your number: ");
            long decimalNum = long.Parse(Console.ReadLine());
            long remainder;
            StringBuilder binary = new StringBuilder();

            while (decimalNum > 0)
            {
                int index = 0;
                remainder = decimalNum % 2;
                binary.Insert(index, remainder);

                decimalNum /= 2;
                index++;
            }
            Console.WriteLine(binary);
        }
    }
}
