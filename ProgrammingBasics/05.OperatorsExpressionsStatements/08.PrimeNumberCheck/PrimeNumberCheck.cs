using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your positive number(from 0 to 100):");
            int a = int.Parse(Console.ReadLine());
            bool isItPrime = false;
            if (a > 1 && a <= 100)
            {
                if (a == 2 || a == 3 || a == 5 || a == 7)
                {
                    isItPrime = true;
                }
                else if (a % 2 != 0 && a % 3 != 0 && a % 5 != 0 && a % 7 != 0)
                {
                    isItPrime = true;
                }
            }
            Console.WriteLine("Is the number prime:{0}", isItPrime);
        }
    }
}
