using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.NumbersInInterval
{
    class NumbersInInterval
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the start number: ");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the end number: ");
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int dividableNumsCounter = 0;
            List<int> divisableNumber = new List<int>();
            for (int i = start; i <= end; i++)
            {
                if (i % 5 == 0)
                {
                    dividableNumsCounter += 1;
                    divisableNumber.Add(i);
                }
            }

            Console.WriteLine("The count of dividable numbers are: {0}.", dividableNumsCounter);
            foreach (var num in divisableNumber)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine();
        }
    }
}
