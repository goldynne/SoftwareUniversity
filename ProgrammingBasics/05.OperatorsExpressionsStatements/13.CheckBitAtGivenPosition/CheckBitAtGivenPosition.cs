using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.CheckBitAtGivenPosition
{
    class CheckBitAtGivenPosition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number you wish to check:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the position you wish to check:");
            int p = int.Parse(Console.ReadLine());
            int mask = 1 << p;
            int nAndMask = n & mask;
            int bitCheck = nAndMask >> p;
            bool isIt = bitCheck == 1;
            Console.WriteLine(isIt);
        }
    }
}
