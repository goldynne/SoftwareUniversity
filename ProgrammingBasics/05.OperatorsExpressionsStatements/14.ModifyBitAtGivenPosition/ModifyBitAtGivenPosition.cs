using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ModifyBitAtGivenPosition
{
    class ModifyBitAtGivenPosition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number you wish to modify:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the value of modification:");
            int v = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the position to modify:");
            int p = int.Parse(Console.ReadLine());
            if (v == 1)
            {
                int mask = 1 << p;
                int result = n | mask;
                Console.Write("Here is your number in binary(32bit):");
                Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
                Console.WriteLine("Here is the actual number:{0}", result);
            }
            else
            {
                int mask = ~(1 << p);
                int result = n & mask;
                Console.Write("Here is your number in binary(32bit):");
                Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
                Console.WriteLine("Here is the actual number:{0}", result);
            }
        }
    }
}