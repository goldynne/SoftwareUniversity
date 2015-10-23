using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.RanddomNumbersInRange
{
    class RanddomNumbersInRange
    {
        static void Main(string[] args)
        {
            //Problem 11. Random Numbers in Given Range

            //Write a program that enters 3 integers n, min and max 
            //(min != max) and prints n random numbers in the range [min...max].

            Console.WriteLine("Please enter n : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter min border : ");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter max border : ");
            int max = int.Parse(Console.ReadLine());
            if (max == min)
            {
                Console.WriteLine("Please enter new max value != min : ");
                max = int.Parse(Console.ReadLine());
            }

            Random num = new Random();
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", num.Next(min, max + 1));
            }
        }
    }
}
