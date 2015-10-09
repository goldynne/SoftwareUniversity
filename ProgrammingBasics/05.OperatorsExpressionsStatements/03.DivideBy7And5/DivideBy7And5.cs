using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the number to check if it is divisable by 7 and 5:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            bool isDivisable = (n % 5 == 0) && (n % 7 == 0);
            Console.WriteLine("Is the number divisable by 7 and 5 : {0}.", isDivisable);
        }
    }
}
