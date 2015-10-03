using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum5Numbers
{
    class Sum5Numbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 5 numbers divided by space:");
            string numbers = Console.ReadLine();
            Console.WriteLine();
            string[] eachNumber = numbers.Split(' ');

            decimal sum = 0;

            foreach (var number in eachNumber)
            {
                sum += (decimal.Parse(number));
            }

            Console.WriteLine("The sum is: " + sum);
        }
    }
}
