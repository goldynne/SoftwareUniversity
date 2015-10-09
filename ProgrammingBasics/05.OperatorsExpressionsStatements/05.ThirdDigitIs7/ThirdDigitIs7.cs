using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ThirdDigitIs7
{
    class ThirdDigitIs7
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the number you wish to check if third digit is 7: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            n /= 100;
            bool isThirdDigit7 = n % 10 == 7;
            Console.WriteLine("Is the third digit 7? -> {0}", isThirdDigit7);
        }
    }
}
