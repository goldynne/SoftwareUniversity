using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SumNNumbers
{
    class SumNNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            double[] numbers = new double[n];
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number {0}: ", i + 1);
                numbers[i] = double.Parse(Console.ReadLine());
                sum += numbers[i];
                Console.WriteLine();
            }
            Console.WriteLine("The sum is: " + sum);
        }
    }
}
