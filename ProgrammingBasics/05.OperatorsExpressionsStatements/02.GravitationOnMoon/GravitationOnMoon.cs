using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GravitationOnMoon
{
    class GravitationOnMoon
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your weight in kilos: ");
            double personWeight = double.Parse(Console.ReadLine());
            Console.WriteLine();
            double weightOnMoon = 0.17 * personWeight;
            Console.WriteLine("Your weight on moon will be: {0}.", weightOnMoon);
        }
    }
}
