using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ExchangeVariablesValues
{
    class ExchangeVariablesValues
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine("Before: ");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            int c = a;
            a = b;
            b = c;
            Console.WriteLine("After change: ");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
    }
}
