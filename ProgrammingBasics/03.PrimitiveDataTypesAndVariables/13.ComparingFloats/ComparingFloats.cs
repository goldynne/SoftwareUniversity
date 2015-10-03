using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            const double eps = 0.000001;
            Console.Write("Please enter first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Please enter second number: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine();
            double difference = a - b;
            if (difference < 0)
            {
                difference *= -1;
            }
            bool result = (difference < eps);
            Console.WriteLine("Are the numbers equal ? -> " + result);
        }
    }
}
