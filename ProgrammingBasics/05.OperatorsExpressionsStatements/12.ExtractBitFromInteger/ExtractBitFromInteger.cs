using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ExtractBitFromInteger
{
    class ExtractBitFromInteger
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your number:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the bit position you wish to check:");
            int p = int.Parse(Console.ReadLine());
            int mask = 1 << p;
            int nAndMask = n & mask;
            int bit = nAndMask >> p;
            Console.WriteLine("The bit at position {0} is :{1}", p, bit);
        }
    }
}
