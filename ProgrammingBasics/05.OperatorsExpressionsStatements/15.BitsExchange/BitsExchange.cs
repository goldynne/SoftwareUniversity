using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.BitsExchange
{
    class BitsExchange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your 32bit number:");
            int n = int.Parse(Console.ReadLine());
            int mask, mask2;
            for (int pos = 3; pos < 6; pos++)
            {
                int tempNumber = (n >> pos) & 1;
                int tempNumber2 = (n >> pos + 21) & 1;
                if (tempNumber != tempNumber2)
                {
                    mask = 1 << pos + 21;
                    mask2 = 1 << pos;
                    n = n ^ (int)mask;
                    n = n ^ (int)mask2;
                }
            }
            Console.Write("Here is your number in binary(32bit):");
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
            Console.WriteLine("Here is the actual number:{0}", n);
        }
    }
}
