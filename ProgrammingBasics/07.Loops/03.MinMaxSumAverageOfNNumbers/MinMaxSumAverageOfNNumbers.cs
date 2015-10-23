using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MinMaxSumAverageOfNNumbers
{
    class MinMaxSumAverageOfNNumbers
    {
        static void Main(string[] args)
        {
            //Problem 3. Min, Max, Sum and Average of N Numbers

            //Write a program that reads from the console a sequence of n integer numbers and returns
            //the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
            //The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
            //The output is like in the examples below
            Console.WriteLine("Please enter your number :");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            double maxValue = double.MinValue;
            double minValue = double.MaxValue;
            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                sum += number;
                if (number > maxValue)

                {
                    maxValue = number;

                }
                if (number < minValue)
                {
                    minValue = number;
                }

            }
            double average = sum / n;
            Console.WriteLine("min=" + minValue);
            Console.WriteLine("max={0}", maxValue);
            Console.WriteLine("sum=" + sum);
            Console.WriteLine("avg={0:0.00}", average);
        }
    }
}
