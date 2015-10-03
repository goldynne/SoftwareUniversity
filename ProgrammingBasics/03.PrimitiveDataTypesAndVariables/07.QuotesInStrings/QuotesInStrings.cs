using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.QuotesInStrings
{
    class QuotesInStrings
    {
        static void Main(string[] args)
        {
            string oneWay = "The \"use of\" quotations causes difficulties.";
            string secondWay = @"The ""use of"" quotations causes difficulties.";

            Console.WriteLine(oneWay);
            Console.WriteLine(secondWay);
        }
    }
}
