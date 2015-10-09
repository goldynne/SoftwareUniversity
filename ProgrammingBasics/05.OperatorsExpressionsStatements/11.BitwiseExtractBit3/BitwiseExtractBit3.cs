using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BitwiseExtractBit3
{
    class BitwiseExtractBit3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number:");
            int a = int.Parse(Console.ReadLine());
            int p = 3;
            int mask = 1 << p;
            int aAndMask = a & mask;
            int bit = aAndMask >> p;
            Console.WriteLine("The third bit is : {0}", bit);
        }
    }
}
