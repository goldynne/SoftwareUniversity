using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.DecimalToHexadecimal
{
    class DecimalToHexadecimal
    {
        static void Main(string[] args)
        {
            //Problem 16. Decimal to Hexadecimal Number

            //Using loops write a program that converts an integer number to its hexadecimal representation.
            //The input is entered as long. The output should be a variable of type string.
            //Do not use the built-in .NET functionality.
            long number = long.Parse(Console.ReadLine());

            StringBuilder bin = new StringBuilder();
            while (number > 0)
            {
                int index = 0;
                char hexNum = '0';
                long remainder = number % 16;
                if (remainder > 9)
                {
                    switch (remainder)
                    {
                        case 10:
                            hexNum = 'A';
                            break;
                        case 11:
                            hexNum = 'B';
                            break;
                        case 12:
                            hexNum = 'C';
                            break;
                        case 13:
                            hexNum = 'D';
                            break;
                        case 14:
                            hexNum = 'E';
                            break;
                        case 15:
                            hexNum = 'F';
                            break;
                        default:
                            Console.WriteLine("Fail");
                            break;
                    }
                    bin.Insert(index, hexNum);
                }
                else
                {
                    bin.Insert(index, remainder);
                }
                number /= 16;
                index++;
            }
            Console.WriteLine(bin);
        }
    }
}
